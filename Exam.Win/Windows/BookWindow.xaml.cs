using Exam.Data.Data.Model;
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
    /// Interaction logic for BookWindow.xaml
    /// </summary>
    public partial class BookWindow : Window
    {
        Book book;
        public BookWindow(Book book)
        {
            InitializeComponent();

            this.book = book;

            NameTb.Text = book.Name;
            AuthorTb.Text = book.Author;
            PagesTb.Text = book.PagesCount.ToString();
            PublishingYearTb.Text = book.PublishingYear.ToString();
            PublisherNameTb.Text = book.PublisherName;
            PriceTb.Text = book.Price.ToString();
            IsExtenshionCb.IsChecked = book.IsExtenshion;


        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                book.Name = NameTb.Text;
                book.Author = AuthorTb.Text;
                book.PagesCount = int.Parse(PagesTb.Text);
                book.PublishingYear = int.Parse(PublishingYearTb.Text);
                book.PublisherName = PublisherNameTb.Text;
                book.Price = decimal.Parse(PriceTb.Text);
                book.IsExtenshion = (bool)IsExtenshionCb.IsChecked;
                this.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
