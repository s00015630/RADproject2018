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

namespace AttendanceUserInterface
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static Student student = new Student()
        {
            ID = 1,
            Name = "John Doe"
        };
        public MainWindow()
        {
            InitializeComponent();

            studentList.Items.Add(student.Name);
        }

        private void studentList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedItem = studentList.SelectedItem as string;
            if(selectedItem != null)
            {
                if (selectedItem == student.Name)
                {
                    studentDetsID.Content = student.ID.ToString();
                    studentDetsName.Content = student.Name.ToString();
                }
            }
        }
    }

    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Student()
        {

        }
    }
}
