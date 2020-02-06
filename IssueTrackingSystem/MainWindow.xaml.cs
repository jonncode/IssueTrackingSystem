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
using Newtonsoft.Json;
using System.IO;

namespace IssueTrackingSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Issue> listIssue = new List<Issue>();
        public string directoryName = @"customers\";
        public string fileName = @"data.txt";
        public MainWindow()
        {
            InitializeComponent();
            string directoryFile = directoryName + fileName;
            try
            {
                if (File.Exists(directoryFile))
                {
                    string jsonString = File.ReadAllText(directoryFile);
                    listIssue = JsonConvert.DeserializeObject<List<Issue>>(jsonString);
                }
                DataGridXAML.Items.Refresh();
                DataGridXAML.ItemsSource = listIssue;
            }
            catch
            {
                lbJsonError.Content = "Error loading JSON content, please this issue before continuing!"; 
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CreateIssue Window2 = new CreateIssue() { DataGridXAML = DataGridXAML, list = listIssue };
            Window2.Show();
        }

        private void SaveIssues(object sender, RoutedEventArgs e)
        {
            string directoryFile = directoryName + fileName;
            if (Directory.Exists(directoryName) == false) //If directory does not exist
            {
                Directory.CreateDirectory(directoryName); //Create directory
            }
            if (File.Exists(directoryFile) == false) //If file does not exist
            {
                var createdFile = File.Create(directoryFile); //Create file in selected directory
                createdFile.Close();
            }
            string json = JsonConvert.SerializeObject(listIssue); //Convert list to json format
            File.WriteAllText(directoryFile, json); //Store list into into .txt file

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ScrollViewerXAML.Visibility = Visibility.Hidden;
            ShowContent.Visibility = Visibility.Hidden;
            Home.Visibility = Visibility.Visible;

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ScrollViewerXAML.Visibility = Visibility.Visible;
            ShowContent.Visibility = Visibility.Hidden;
            Home.Visibility = Visibility.Hidden;
        }

        private void DataGridXAML_BeginningEdit(object sender, DataGridBeginningEditEventArgs e)
        {
            ScrollViewerXAML.Visibility = Visibility.Hidden;
            Home.Visibility = Visibility.Hidden;
            ShowContent.Visibility = Visibility.Visible;
            Issue item = ((DataGridRow)e.Row).Item as Issue;
            lbIssueName.Content = item.Name;
            lbIssueDate.Content = item.Created.ToString("dddd, dd MMMM yyyy HH:mm").ToUpper();
            lbIssueAssignee.Content = item.Assignee;
            cBIssuePriority.SelectedItem = item.Priority;
            cBIssueStatus.SelectedItem = item.Status;
            lbIssueDescription.Text = item.Description;

        }
    }
}