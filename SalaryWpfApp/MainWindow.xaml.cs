using SalaryLibrary;
using System;
using System.Windows;

namespace SalaryWpfApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string _filename = @"..\data.xml";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Read_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Service.ReadXML(_filename);
                WorkerGrid.ItemsSource = Service.Workers;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Change_Click(object sender, RoutedEventArgs e)
        {
            ChangeDataWindow changeDataWindow = new ChangeDataWindow();
            changeDataWindow.Show();
        }

        private void Button_Save_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Service.SaveToXml(_filename);
                MessageBox.Show("Data was saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Update_Click(object sender, RoutedEventArgs e)
        {
            WorkerGrid.ItemsSource = Service.Workers;
            WorkerGrid.Items.Refresh();
        }
    }
}
