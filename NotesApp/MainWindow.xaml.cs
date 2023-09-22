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

namespace NotesApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string input_txt = "";
        string title_txt = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void create_note(object sender, RoutedEventArgs e)
        {
            input_txt = input.Text;
            title_txt = title.Text;

            System.Windows.Controls.Button newBtn = new Button();

            newBtn.Content = title_txt;
            newBtn.Name = title_txt;
           

        }
    }
}
