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

namespace IssueTrackingSystem
{
    /// <summary>
    /// Interaction logic for CreateIssue.xaml
    /// </summary>
    public partial class CreateIssue : Window
    {
        public CreateIssue()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string name = tBIssueName.Text;
            string description = new TextRange(rTBIssueDescription.Document.ContentStart, rTBIssueDescription.Document.ContentEnd).Text;
            string assignee = tBIssueAssignee.Text;
            string status = cBIssueStatus.Text;
            string priority = cBIssueStatus.Text;
            DateTime time = DateTime.Now;
            
            
        }
    }
}
