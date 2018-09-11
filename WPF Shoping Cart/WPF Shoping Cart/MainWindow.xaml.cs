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

namespace WPF_Shoping_Cart
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }


        public static List<string> listname = new List<string>();

        bool empty()
        {
            if (input_text.Text == "")
            {
                MessageBox.Show("Please Input Iterm!");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Addtask_btn_Click(object sender, RoutedEventArgs e)
        {
           if (this.input_text.Text != "")
            {
                list_box.Items.Add(input_text.Text);
                input_text.Clear();
            }
            else
            {
                MessageBox.Show("Please Input Item!");
            }
            
        }


      

        private void Delete_btn_Click_1(object sender, RoutedEventArgs e)
        {
            while(list_box.SelectedItems.Count > 0)
            {
                list_box.Items.Remove(list_box.SelectedItems[0]);
                input_text.Clear();
            }
        }

        private void Edit_btn_Click(object sender, RoutedEventArgs e)
        {
            int Index = list_box.SelectedIndex;
            list_box.Items.RemoveAt(Index);
            list_box.Items.Insert(Index, input_text.Text);
            input_text.Clear();
        }

        private void list_box_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                input_text.Text = list_box.SelectedItem.ToString();
            }
            catch
            {

            }
        }
    }
}
