using SalaryLibrary;
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
    public partial class DeleteEntityForm : Form
    {
        public DeleteEntityForm(string tableName)
        {
            InitializeComponent();

            tableNameLabel.Text = tableName;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            Service.ORM.DeleteValue(tableNameLabel.Text, Convert.ToInt32(idTextBox.Text));

            MessageBox.Show($"Entity with id {idTextBox.Text} was removed");
            Close();
        }
    }
}
