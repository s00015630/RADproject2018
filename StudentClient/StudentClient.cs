using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Formatting;
using CommonObjects;
 
namespace StudentClient
{
    public enum AUTHSTATUS { NONE, OK, INVALID, FAILED }
     

    public static class ClientApiLib
    {
        static public string baseWebAddress;
        static public string Token = "";
        static public AUTHSTATUS Status = AUTHSTATUS.NONE;

        static public bool login(string username, string password)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                // Create a from object
                var content = new FormUrlEncodedContent(new[]
                    {
                        new KeyValuePair<string, string>("grant_type", "password"),
                        new KeyValuePair<string, string>("username", username),
                        new KeyValuePair<string, string>("password", password),
                    });
                // Post the form to the Toekn end point
                var result = client.PostAsync(baseWebAddress + "Token", content).Result;
                try
                {
                    // Make sure System.Net.Http.Extensoins is referenced through Nuget
                    // For async http action calls
                    var resultContent = result.Content.ReadAsAsync<Token>(
                        new[] { new JsonMediaTypeFormatter() }
                        ).Result;
                    string ServerError = string.Empty;
                    if (!(String.IsNullOrEmpty(resultContent.AccessToken)))
                    {
                        Console.WriteLine(resultContent.AccessToken);
                        Token = resultContent.AccessToken;
                        Status = AUTHSTATUS.OK;
                        return true;
                    }
                    else
                    {
                        Token = "Invalid Login";
                        Status = AUTHSTATUS.INVALID;
                        Console.WriteLine("Invalid credentials");
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    Status = AUTHSTATUS.FAILED;
                    Token = "Server Error -> " + ex.Message;
                    Console.WriteLine(ex.Message);
                    return false;
                }

            }
        }

        static public List<StudentDTO> geStudentList()
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                // Insert the Bearer Token Header
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Token);
                var response = client.GetAsync(baseWebAddress + "api/Students").Result;
                // Newtonsoft Json deserialiser Will attempt to Match the fields in the DTO 
                // against the Student Object passed back from the ReorderList Method
                var resultContent = response.Content.ReadAsAsync<List<StudentDTO>>(
                    new[] { new JsonMediaTypeFormatter() }).Result;
                return resultContent;
            }
        }

        static public StudentDTO addStudent(StudentDTO student)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Token);
                var response = client.PostAsJsonAsync(baseWebAddress + "api/Students/add/Course", student).Result;
                if (response.IsSuccessStatusCode)
                {
                    var resultContent = response.Content.ReadAsAsync<StudentDTO>(
                        new[] { new JsonMediaTypeFormatter() }).Result;

                    return resultContent;
                }
                return null;
            }
        }

        static public CourseDTO delete(int courseID)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Token);
                var response = client.DeleteAsync(baseWebAddress + "api/Students/delete/Course/" + courseID).Result;
                if (response.IsSuccessStatusCode)
                {
                    var resultContent = response.Content.ReadAsAsync<CourseDTO>(
                        new[] { new JsonMediaTypeFormatter() }).Result;

                    return resultContent;
                }
                return null;
            }
        }

    }
}
