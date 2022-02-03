using Exam.Data.Data.Classes;
using Exam.Data.Data.Model;
using Exam.Data.Data.Models;
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
using System.Windows.Shapes;

namespace Exam.Win.Windows
{
    /// <summary>
    /// Interaction logic for BookWindow.xaml
    /// </summary>
    public partial class BookWindow : Window
    {
        Book book;
        List<Genre> genres;

        BookService bookService = new BookService(new BookRepository());

        public BookWindow(Book book, IEnumerable<Genre> genres)
        {
            InitializeComponent();

            this.book = book;
            this.genres = (List<Genre>)genres;
            GenresItemsSourceReconnect();

            

            NameTb.Text = book.Name;
            AuthorTb.Text = book.Author;
            PagesTb.Text = book.PagesCount.ToString();
            PublishingYearTb.Text = book.PublishingYear.ToString();
            PublisherNameTb.Text = book.PublisherName;
            CostPriceTb.Text = book.CostPrice.ToString();
            PriceTb.Text = book.Price.ToString();
            InstockTb.Text = book.InStock.ToString();
            IsExtenshionCb.IsChecked = book.IsExtenshion;

            if(book.Genre != null && book.Genre != "")
            {
                GenresCmb.SelectedItem = genres.FirstOrDefault(g => g.Name == book.Genre);
            }
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
                book.CostPrice = decimal.Parse(CostPriceTb.Text);
                book.Price = decimal.Parse(PriceTb.Text);
                book.InStock = int.Parse(InstockTb.Text);
                book.IsExtenshion = (bool)IsExtenshionCb.IsChecked;
                book.Genre = GenresCmb.SelectedItem.ToString();
                this.DialogResult = true;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddGenreBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                StringBuilder genreName = new StringBuilder();
                GetStringWindow getStringWindow = new GetStringWindow(genreName, "Genre Name");

                if (getStringWindow.ShowDialog() == true)
                {
                    Genre genre = new Genre
                    {
                        Name = genreName.ToString()
                    };
                    

                    bookService.AddGenre(genre);
                    genres.Add(genre);
                    GenresItemsSourceReconnect();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void DeleteGenreBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                bookService.DeleteGenre((Genre)GenresCmb.SelectedItem);
                genres.Remove((Genre)GenresCmb.SelectedItem);
                GenresItemsSourceReconnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GenresItemsSourceReconnect()
        {
            GenresCmb.ItemsSource = null;
            GenresCmb.ItemsSource = genres;
            GenresCmb.SelectedIndex = 0;
        }
    }
}
