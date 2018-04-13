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
using System.Windows.Shapes; 
using System.Data.SqlClient;
//edit window

namespace AttendanceUserInterface   
{
    /// <summary>
    /// Interaction logic for EditStudent.xaml
    /// </summary>
    public partial class EditStudent : Window
    {
        public string name {get; set;}
        public string stunum { get; set; }
        public string stem { get; set; }
        static SqlConnection db = new SqlConnection(@"Data Source=(LocalDb)\MSSQLLocalDB;AttachDbFilename='C:\Users\nauri\Desktop\RADproject2018-master\Server API\App_Data\defaultConnection.mdf';Initial Catalog=defaultConnection;Integrated Security=True");
        static SqlCommand cmd = new SqlCommand();
        public EditStudent(string name)
        {
            //InitializeComponent();
            //tbStudentName.Text = name;
            //tbStudentEmail.Text = stem;
            //tbStudentNumber.Text = stunum;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            string[] studentName = tbStudentName.Text.Split(' ');
            string fName = studentName[0];
            string lName = studentName[1];
            stem = tbStudentEmail.Text;
            stunum = tbStudentNumber.Text;
            db.Open();
            cmd.Connection = db;
            cmd.CommandText = "UPDATE Student SET FirstName = @fName, LastName = @lName, Email = @email  WHERE StudentNum = @num";
            cmd.Parameters.AddWithValue("@fName", fName);
            cmd.Parameters.AddWithValue("@lName", lName);
            cmd.Parameters.AddWithValue("@email", stem);
            cmd.Parameters.AddWithValue("@num", stunum);
            cmd.ExecuteNonQuery();
            db.Close();
            this.Close();
        }
    }
}
