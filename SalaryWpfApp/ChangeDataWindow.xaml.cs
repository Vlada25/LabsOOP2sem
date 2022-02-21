using SalaryLibrary;
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

namespace SalaryWpfApp
{
    /// <summary>
    /// Логика взаимодействия для ChangeDataWindow.xaml
    /// </summary>
    public partial class ChangeDataWindow : Window
    {
        public ChangeDataWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            WokerSelector.ItemsSource = Service.GetWorkersNames();
            UnitSelector.ItemsSource = Service.GetWorkersAttributes();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string worker = (string)WokerSelector.SelectedItem;
                string attribute = (string)UnitSelector.SelectedItem;
                string newValue = NewValueField.Text;

                if (string.IsNullOrEmpty(worker) || string.IsNullOrEmpty(attribute) || string.IsNullOrEmpty(newValue)) 
                {
                    throw new Exception("You have to fill in all fields");
                }

                Service.ChangeSomeValue(worker, attribute, newValue);
                MessageBox.Show("Done");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
