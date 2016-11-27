using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace WorkingWithContainer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int Index = 0;
        Product product;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            product = new Product(Code.Text,
                                Name.Text,
                                Description.Text,
                                Amount.Text,
                                Price.Text,
                                TypeGood.IsChecked.Value,
                                InStock.IsChecked.Value);

            ListOfGoods.Text += ++Index + product.ToString();
        }
    }

    public class Product
    {
        public String fCode { get; set; }
        public String fName { get; set; }
        public String fDescription { get; set; }
        public String fAmount { get; set; }
        public String fPrice { get; set; }
        public Boolean fTypeGood { get; set; }
        public Boolean fInStock { get; set; }

        public Product(String fCode, String fName, String fDescription, String fAmount, String fPrice, Boolean fTypeGood, Boolean fInStock)
        {
            this.fCode = fCode;
            this.fName = fName;
            this.fDescription = fDescription;
            this.fAmount = fAmount;
            this.fPrice = fPrice;
            this.fTypeGood = fTypeGood;
            this.fInStock = fInStock;

        }

        public override string ToString()
        {
            return String.Format("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\n",
                fCode,
                fName,
                fDescription,
                fAmount.ToString(),
                fPrice.ToString(),
                (fTypeGood) ? "Product" : "Service",
                fInStock.ToString()
                );
        }
    }
}
