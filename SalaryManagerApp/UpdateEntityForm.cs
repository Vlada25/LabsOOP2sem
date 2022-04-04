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
    public partial class UpdateEntityForm : Form
    {
        private Type _entityType;
        private List<TextBox> _propsTextBox = new List<TextBox>();

        public UpdateEntityForm(string tableName, Type entityType)
        {
            InitializeComponent();

            tableNameLable.Text = tableName;
            _entityType = entityType;
        }

        private void GetEntityBtn_Click(object sender, EventArgs e)
        {
            CreatePropertiesTable(Service.ORM.GetValue(tableNameLable.Text, _entityType, Convert.ToInt32(idTextBox.Text)));
        }

        private void CreatePropertiesTable(DataRow dataRow)
        {
            int xLabelLoc = 20,
                yLabelLoc = 90,
                xTextBoxLoc = 200,
                yTextBoxLoc = 90,
                index = 1;

            foreach (var prop in Service.TableManager.GetBaseProps(_entityType, false))
            {
                Label label = new Label();
                label.Text = prop.Name;
                label.Name = prop.Name + "Label";
                label.Font = new Font(Font.FontFamily, 10);
                label.Location = new Point(xLabelLoc, yLabelLoc);

                TextBox textBox = new TextBox();
                textBox.Name = prop.Name + "TextBox";
                textBox.Text = dataRow.ItemArray[index].ToString();
                textBox.Font = new Font(Font.FontFamily, 10);
                textBox.Width = 200;
                textBox.Location = new Point(xTextBoxLoc, yTextBoxLoc);

                Controls.Add(label);
                Controls.Add(textBox);

                _propsTextBox.Add(textBox);

                yLabelLoc += 30;
                yTextBoxLoc += 30;
                index++;
            }
        }
    }
}
