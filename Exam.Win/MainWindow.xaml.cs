using Exam.Data.Data.Model;
using Exam.Service;
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

namespace Exam.Win
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            
            
            Book book = new Book()
            {
                Name = "Name",
                Author ="Author",
                PagesCount = 805,
                PublishingYear = 1998,
                PublicherName ="PubName",
                CostPrice = 15,
                Price = 30,
                IsExtenshion = false
            };

            BooksList.Items.Add(book);

            



        }
    }
}
