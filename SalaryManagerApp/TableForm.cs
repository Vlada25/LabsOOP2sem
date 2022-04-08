using SalaryLibrary;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SalaryManagerApp
{
    public partial class TableForm : Form
    {
        Button specBtn = new Button();
        TextBox specTextBox = new TextBox();
        private int _queruId;

        public TableForm(string tableName, string btnText = "", int queryId = -1)
        {
            InitializeComponent();

            _queruId = queryId;
            tableNameLabel.Text = tableName;

            if (queryId == -1)
                CreateTable(Service.TableManager.GetDataSet(tableName));
            else
            {
                CreateTable(Service.GetSpecialDataSet(queryId));

                specBtn.Name = "specBtn";
                specBtn.Text = btnText;
                specBtn.Width = 140;
                specBtn.Height = 30;
                specBtn.Font = new Font(Font.FontFamily, 10);
                specBtn.Location = new Point(300, 15);
                specBtn.Click += specBtn_Click;

                specTextBox.Location = new Point(450, 20);
                specTextBox.Width = 120;

                Controls.Add(specBtn);
                Controls.Add(specTextBox);

            }
        }

        private void specBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!decimal.TryParse(specTextBox.Text, out decimal price))
                {
                    throw new Exception("Incorrect value!");
                }

                DataSet ds = Service.GetSpecialDataSet(_queruId);

                var rows = from obj in ds.Tables[0].AsEnumerable()
                           where (decimal)obj["Price"] > price
                           select obj;

                string res = "";
                foreach (var row in rows)
                {
                    foreach (var ceil in row.ItemArray)
                    {
                        res += $"{ceil}; ";
                    }
                    res += "\n";
                }

                MessageBox.Show(res);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CreateTable(DataSet dataSet)
        {
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
