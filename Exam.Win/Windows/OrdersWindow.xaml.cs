using Exam.Data.Data.Classes;
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
using System.Windows.Shapes;

namespace Exam.Win.Windows
{
    /// <summary>
    /// Interaction logic for OrdersWindow.xaml
    /// </summary>
    public partial class OrdersWindow : Window
    {
        OrderService orderService;
        List<Order> orders;
        public OrdersWindow()
        {
            InitializeComponent();

            orderService = new OrderService(new OrderRepository());
            SetOrders();
        }

        private void RefreshBtn_Click(object sender, RoutedEventArgs e)
        {
            SetOrders();
        }

        private void SetOrders()
        {
            orders = (List<Order>)orderService.GetAll();

            OrdersList.ItemsSource = orders;
        }
    }
}
