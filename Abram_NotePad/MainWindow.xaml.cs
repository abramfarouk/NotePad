using Microsoft.Win32;
using System;
using System.Collections.Generic;
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

namespace Abram_NotePad
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

        private void New_Menu_Click(object sender, RoutedEventArgs e)
        {
            TxtContent.Text = string.Empty; 
            TxtContent.Focus();
        }

        private void Open_Menu_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Open y yad y user";
            openFileDialog.Filter = "Text Files|*.txt";
            openFileDialog.AddExtension = true;
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFileDialog.ShowDialog();
            if(openFileDialog.FileName != string.Empty)
            {
             TxtContent.Text =File.ReadAllText(openFileDialog.FileName, Encoding.UTF8 );
            }
        }

        private void Save_Menu_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog  = new SaveFileDialog();
            saveFileDialog.Title = "Save y yad y user";
            saveFileDialog.Filter = "Text Files|*.txt";
            saveFileDialog.AddExtension = true; 
            saveFileDialog.InitialDirectory=Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != "")
            {
                File.WriteAllText(saveFileDialog.FileName, TxtContent.Text, Encoding.UTF8);
                MessageBox.Show("Done");
            }
        }

        private void Exit_Menu_Click(object sender, RoutedEventArgs e)
        {
            this.Close();

        }

        private void TxtContent_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Undo_Menu_Click(object sender, RoutedEventArgs e)
        {
            TxtContent.Undo(); 
        }

        private void Redo_Menu_Click(object sender, RoutedEventArgs e)
        {
            TxtContent.Redo();
        }

        private void Cut_Menu_Click(object sender, RoutedEventArgs e)
        {
            TxtContent.Cut();
        }

        private void Copy_Menu_Click(object sender, RoutedEventArgs e)
        {
            TxtContent.Copy();
        }

        private void Past_Menu_Click(object sender, RoutedEventArgs e)
        {
            TxtContent.Paste(); 
        }

        private void Select_All_Click(object sender, RoutedEventArgs e)
        {
            TxtContent.Focus(); 
            TxtContent.SelectAll(); 
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Red_Menu_Click(object sender, RoutedEventArgs e)
        {
            TxtContent.Foreground = new SolidColorBrush(Color.FromRgb(255, 0, 0)); 
        }

        private void Blue_Menu_Click(object sender, RoutedEventArgs e)
        {
            TxtContent.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 255));

        }

        private void Black_Menu_Click(object sender, RoutedEventArgs e)
        {
            TxtContent.Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));

        }

        private void Word_Wrap_Click(object sender, RoutedEventArgs e)
        {
            if(Word_Wrap.IsChecked== true) { 
            TxtContent.TextWrapping = TextWrapping.Wrap;
                TxtContent.HorizontalScrollBarVisibility = ScrollBarVisibility.Hidden;
                TxtContent.VerticalScrollBarVisibility = ScrollBarVisibility.Auto;
            }
            else
            {
                TxtContent.TextWrapping = TextWrapping.NoWrap;
                TxtContent.HorizontalScrollBarVisibility = ScrollBarVisibility.Auto;
                TxtContent.VerticalScrollBarVisibility = ScrollBarVisibility.Hidden;
            }
        }

        private void Zoom_In_Menu_Click(object sender, RoutedEventArgs e)
        {
           if(TxtContent.FontSize+5 < 100)
            {
                TxtContent.FontSize =TxtContent.FontSize + 5;   
            }
        }

        private void x_Name__Zoom_Out_Menu__Click(object sender, RoutedEventArgs e)
        {
            if(TxtContent.FontSize-5 > 8)
            {
                TxtContent.FontSize= TxtContent.FontSize - 5;    
            }
        }

        private void Zoom__Menu_Click(object sender, RoutedEventArgs e)
        {
            TxtContent.FontSize = 20; 
        }

        private void About_Menu_Click(object sender, RoutedEventArgs e)
        {
            Abram_NotePad.About_Menu about_Menu = new About_Menu(); 
            about_Menu.ShowDialog();
        }
    }
}
