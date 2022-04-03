using MySql.Data.MySqlClient;
using SalaryLibrary;
using SalaryManager.ORM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryManagerApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            tablesComboBox.Items.AddRange(Service.TablesInDb);

            try
            {
                //string com = "INSERT productionUnits (UnitName, Price) values ('iPhone', 7500);";
                //sqlExecutor.ExecuteScalar(com);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ShowBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (tablesComboBox.SelectedItem is null)
                {
                    throw new Exception("You must choose table!");
                }

                TableForm tableForm = new TableForm((string)tablesComboBox.SelectedItem);
                tableForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
