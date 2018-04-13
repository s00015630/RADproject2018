using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

using System.Data.SqlClient;

namespace AttendanceUserInterface
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static SqlConnection db = new SqlConnection(@"Data Source = (LocalDb)\MSSQLLocalDB; AttachDbFilename=&quot;|DataDirectory|\DefaultConnection.mdf&quot;;Initial Catalog = &quot; aspnet-Server API-20180314083742&quot;;Integrated Security = True" providerName="System.Data.SqlClient" );
        static SqlCommand cmd = new SqlCommand();
        static Student[] students;
        public MainWindow()
        {
             
            db.Close();
            LoadStudents();
            InitializeComponent();
            studentList.ItemsSource = students;

        }
        private void studentList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Student selectedItem = studentList.SelectedItem as Student;
            if (selectedItem != null)
            {
                studentName.Text = selectedItem.FirstName + " " + selectedItem.LastName;
                studentEmail.Text = selectedItem.Email;
                studentNum.Text = selectedItem.StudentNumber;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        { 
            string txtName = studentName.Text;
            string txtEmail = studentEmail.Text;
            string txtNum = studentNum.Text;
            EditStudent newWindow = new EditStudent(txtName);
            newWindow.tbStudentName.Text = txtName;
            newWindow.tbStudentEmail.Text = txtEmail;
            newWindow.tbStudentNumber.Text = txtNum;
            newWindow.ShowDialog();
            LoadStudents();
            
        }
        public void LoadStudents()
        {
            db.Open();
            students = null;
            string sql = @"SELECT FirstName, LastName, Email, StudentNum FROM  Student";
            cmd.Connection = db;
            using (var command = new SqlCommand(sql, db))
            {
                using (var reader = command.ExecuteReader())
                {
                    var list = new List<Student>();
                    while (reader.Read())
                        list.Add(new Student { FirstName = reader.GetString(0), LastName = reader.GetString(1), Email = reader.GetString(2), StudentNumber = reader.GetString(3) });
                    students = list.ToArray();
                    
                }
            }
            db.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            LoadStudents();
            studentList.ItemsSource = students;
        }
    }
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StudentNumber { get; set; }
        public string Email { get; set; }

        public Student()
        {

        }
    }
}
