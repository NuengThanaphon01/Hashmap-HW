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
using System.Collections;

namespace Hashmap
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Hashtable hashtable;

        public MainWindow()
        {
            InitializeComponent();
            hashtable = new Hashtable();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            hashtable.Add(txtKey.Text,txtValue.Text);
        }

        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            hashtable.Remove(txtKey.Text);
        }

        private void btnShowall_Click(object sender, RoutedEventArgs e)
        {
            ICollection icollection = hashtable.Keys;

            string Result = "KEY    VALUE" + System.Environment.NewLine;
            foreach(string key in icollection)
            {
                Result += key+"   "+hashtable[key].ToString() + System.Environment.NewLine;
            }

            MessageBox.Show(Result);
        }
    }
}
