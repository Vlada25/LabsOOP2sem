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
            try
            {
                CreatePropertiesTable(Service.ORM.GetValue(tableNameLable.Text, _entityType, Convert.ToInt32(idTextBox.Text)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                label.Width = 170;
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

            SaveBtn.Location = new Point(160, yLabelLoc + 30);
            SaveBtn.Visible = true;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> props = new List<string>();

                props.Add(idTextBox.Text);

                foreach (TextBox textBox in _propsTextBox) props.Add(textBox.Text);

                Service.UpdateEntity(_entityType, props);

                MessageBox.Show("Entity was updated");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
