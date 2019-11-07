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

namespace IssueTrackingSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Issue> listIssue = new List<Issue>();
        public MainWindow()
        {
            InitializeComponent();

            listIssue.Add(new Issue("Jon", "l", "l", "l", "l", DateTime.Now));
            DataGridXAML.ItemsSource = listIssue; 
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CreateIssue Window2 = new CreateIssue() { DataGridXAML = DataGridXAML, list = listIssue };
            Window2.Show();
        }
    }
}
