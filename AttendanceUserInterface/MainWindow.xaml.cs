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
        static SqlConnection db = new SqlConnection(@"Data Source=(LocalDb)\MSSQLLocalDB;AttachDbFilename=&quot;|DataDirectory|\DefaultConnection.mdf&quot;;Initial Catalog=&quot;aspnet-Server API-20180314083742&quot;;Integrated Security=True");
        static SqlCommand cmd = new SqlCommand();
        static Student[] students;
        public MainWindow()
        {
            db.Open();
            students = null;
            string sql = @"SELECT FirstName, LastName FROM  Student";
            cmd.Connection = db;
            using (var command = new SqlCommand(sql, db))
            {
                using (var reader = command.ExecuteReader())
                {
                    var list = new List<Student>();
                    while (reader.Read())
                        list.Add(new Student { FirstName = reader.GetString(0), LastName = reader.GetString(1) });
                    students = list.ToArray();
                }
            }

            db.Close();

            InitializeComponent();
            studentList.ItemsSource = students;
            foreach (var item in students)
            {
                studentList.DisplayMemberPath = "FirstName";
            }
           
        }
        private void studentList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Student selectedItem = studentList.SelectedItem as Student;

            if(selectedItem != null)
            {
                studentFName.Content = selectedItem.FirstName.ToString();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        { 
            string txtName = studentFName.Content.ToString();
            EditStudent newWindow = new EditStudent(txtName);
            newWindow.tbStudentFName.Text = txtName;
            newWindow.ShowDialog();
            
        }
    }
    public class Student
    {
        public string ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StudentNumber { get; set; }
        public string Email { get; set; }

        public Student()
        {

        }
        /*
        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
        */
    }
}
