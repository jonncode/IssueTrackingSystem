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
        static List<Issue> listIssue = new List<Issue>();
        public MainWindow()
        {
            InitializeComponent();
            listIssue.Add(new Issue("Fix the sink", "ionathan Eriksson", "Open", 1));
            listIssue.Add(new Issue("Fix the sink", "lonathan Eriksson", "Open", 1));
            listIssue.Add(new Issue("Fix the sink", "lonathan Eriksson", "Open", 1));
            listIssue.Add(new Issue("Fix the sink", "ponathan Eriksson", "Open", 1));
            listIssue.Add(new Issue("Fix the sink", "Jonathan Eriksson", "Open", 1));
            listIssue.Add(new Issue("Fix the sink", "ponathan Eriksson", "Open", 1));
            listIssue.Add(new Issue("Fix the sink", "Jonathan Eriksson", "Open", 1));
            listIssue.Add(new Issue("Fix the sink", "konathan Eriksson", "Open", 1));
            listIssue.Add(new Issue("Fix the sink", "Jonathan Eriksson", "Open", 1));
            listIssue.Add(new Issue("Fix the sink", "Jonathan Eriksson", "Open", 1));
            listIssue.Add(new Issue("Fix the sink", "Jonathan Eriksson", "Open", 1));
            listIssue.Add(new Issue("Fix the sink", "Jonathan Eriksson", "Open", 1));
            listIssue.Add(new Issue("Fix the sink", "Jonathan Eriksson", "Open", 1));
            listIssue.Add(new Issue("Fix the sink", "Jonathan Eriksson", "Open", 1));
            listIssue.Add(new Issue("Fix the sink", "Jonathan Eriksson", "Open", 1));
            listIssue.Add(new Issue("Fix the sink", "Jonathan Eriksson", "Open", 1));
            listIssue.Add(new Issue("Fix the sink", "Jonathan Eriksson", "Open", 1));
            listIssue.Add(new Issue("Fix the sink", "Jonathan Eriksson", "Open", 1));
            listIssue.Add(new Issue("Fix the sink", "Jonathan Eriksson", "Open", 1));
            listIssue.Add(new Issue("Fix the sink", "Jonathan Eriksson", "Open", 1));
            listIssue.Add(new Issue("Fix the sink", "Jonathan Eriksson", "Open", 1));
            listIssue.Add(new Issue("Fix the sink", "Jonathan Eriksson", "Open", 1));
            listIssue.Add(new Issue("Fix the sink", "Jonathan Eriksson", "Open", 1));
            listIssue.Add(new Issue("Fix the sink", "Jonathan Eriksson", "Open", 1));

            foreach (var item in listIssue)
            {
                DataGridXAML.Items.Add(item);
            }
            CreateIssue Window2 = new CreateIssue();
            Window2.Show();
        }
            
    }
}
