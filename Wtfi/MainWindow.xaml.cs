
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;


namespace Wtfi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        OpenFileDialog dialog = new OpenFileDialog();
        string safeXmlFileName = "";

        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void Button_Click(object sender, System.EventArgs e)
        {
            // Show open file dialog box
            DialogResult result = dialog.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new
                   System.IO.StreamReader(dialog.FileName);
                //fileName.Text = dialog.FileName;
                safeXmlFileName = dialog.SafeFileName;
                fileName.Text = safeXmlFileName;
                Console.WriteLine("Filename:{0}", safeXmlFileName);
                sr.Close();
            }
        }

        private void doitButton_Click(object sender, RoutedEventArgs e)
        {
            testClass.Test(keyBox, valueBox, safeXmlFileName);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AboutBox about = new AboutBox();
            about.Show();
        }
    }
}
