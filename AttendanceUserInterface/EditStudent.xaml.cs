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

namespace AttendanceUserInterface
{
    /// <summary>
    /// Interaction logic for EditStudent.xaml
    /// </summary>
    public partial class EditStudent : Window
    {
        public string fname {get; set;}
        public EditStudent(string fname)
        {
            InitializeComponent();
            tbStudentFName.Text = fname;
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
