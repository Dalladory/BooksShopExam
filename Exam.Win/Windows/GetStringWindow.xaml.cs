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

namespace Exam.Win.Windows
{
    /// <summary>
    /// Interaction logic for GetStringWindow.xaml
    /// </summary>
    public partial class GetStringWindow : Window
    {
        StringBuilder result;
        public GetStringWindow(StringBuilder result, string label)
        {
            InitializeComponent();
            this.result = result;
            MainLabel.Content = label;
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            if(ResultTb.Text != "" || ResultTb.Text != null)
            {
                result.AppendLine(ResultTb.Text);
                this.DialogResult = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("String is not valid");
            }
            

        }
    }
}
