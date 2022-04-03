using SalaryLibrary;
using System.Data;
using System.Windows.Forms;

namespace SalaryManagerApp
{
    public partial class TableForm : Form
    {
        public TableForm(string tableName)
        {
            InitializeComponent();

            tableNameLabel.Text = tableName;
            CreateTable(tableName);
        }

        private void CreateTable(string tableName)
        {
            DataSet dataSet = Service.TableManager.GetDataSet(tableName);

            foreach (DataColumn column in dataSet.Tables[0].Columns)
            {
                DataGridViewTextBoxColumn dataColumn = new DataGridViewTextBoxColumn();

                dataColumn.HeaderText = column.ColumnName;
                dataColumn.Name = column.ColumnName;

                if (column.ColumnName == "Id") dataColumn.Width = 40;
                else dataColumn.Width = 150;

                dataTable.Columns.Add(dataColumn);
            }

            foreach (DataRow row in dataSet.Tables[0].Rows)
                dataTable.Rows.Add(row.ItemArray);
        }
    }
}
