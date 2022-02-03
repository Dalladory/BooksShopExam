using Exam.Data.Data.Classes;
using Exam.Data.Data.Model;
using Exam.Data.Data.Models;
using Exam.Service;
using Exam.Win.Windows;
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
    /// 
   
    public partial class MainWindow : Window
    {

        BookService bookService = new BookService(new BookRepository());
        OrderService orderService = new OrderService(new OrderRepository());


        List<Book> books;
        List<Genre> genres;
        
        public MainWindow()
        {
            InitializeComponent();

            books = (List<Book>)bookService.GetAll();
            genres = (List<Genre>)bookService.GetAllGenres();

            
            ItemsSourceReconnect();
        }

        private void ItemsSourceReconnect()
        {
            BooksList.ItemsSource = null;
            BooksList.ItemsSource = books;
        }

        private void BookAddBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Book book = new Book();
                BookWindow bookWindow = new BookWindow(book, genres);

                if(bookWindow.ShowDialog() == true)
                {
                    bookService.Add(book);
                    books.Add(book);
                    ItemsSourceReconnect();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void BookDeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                foreach (Book item in BooksList.SelectedItems)
                {
                    bookService.Delete(item);
                    books.Remove(item);
                }
                ItemsSourceReconnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BooksList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            try
            {
                Book book = BooksList.SelectedItem as Book;

                BookWindow bookWindow = new BookWindow(book, genres);
                if(bookWindow.ShowDialog() == true)
                {
                    bookService.Update(book);
                    ItemsSourceReconnect();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SearchTb_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(SearchTb.Text == "")
            {
                ItemsSourceReconnect();
            }
            else
            {
                BooksList.ItemsSource = books.Where(b => (b.Name + b.Author + b.Genre).ToLower().IndexOf(SearchTb.Text) >= 0).ToList();
            }
        }

        private void SellBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                foreach (Book item in BooksList.SelectedItems)
                {
                    if (item.InStock == 0)
                    {
                        MessageBox.Show($"Book {item.Name} is not available");
                        continue;
                    }

                    orderService.Add(
                        new Order()
                        {
                            Price = item.Price,
                            BookId = item.Id,
                            Date = DateTime.Now
                        }
                    );

                    item.InStock--;
                    bookService.Update(item);
                }
                ItemsSourceReconnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        private void OrdersBtn_Click(object sender, RoutedEventArgs e)
        {
            OrdersWindow ordersWindow = new OrdersWindow();
            ordersWindow.Show();
        }
    }
}
