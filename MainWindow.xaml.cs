using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Globalization;
using System.IO;
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
using System.Xml.Serialization;

namespace ezhednevnik
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window { 

        public MainWindow()
      
        {
            InitializeComponent();
            
            DateTimePicker.SelectedDate = DateTime.Now;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
          
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
                

        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (pole.Text == " ")
            {
                MessageBox.Show("Надо ввести текст");
            }
            else
            {
                Tip zametka = new Tip();
                zametka.name = pole.Text;
                zametka.opisanie = text.Text;
                zametka.datetime = (DateTime) DateTimePicker.SelectedDate;

                crudisp crudisp = new crudisp();
                crudisp.create(zametka);

                MessageBox.Show("Заметка создана");
            }
        }


        private void button2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
