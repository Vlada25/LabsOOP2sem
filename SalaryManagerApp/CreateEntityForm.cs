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
    public partial class CreateEntityForm : Form
    {
        private List<TextBox> _propsTextBox = new List<TextBox>();
        private Type _entityType;

        public CreateEntityForm(string tableName, Type entityType)
        {
            InitializeComponent();

            tableNameLable.Text = tableName;
            _entityType = entityType;

            CreatePropertiesTable();
        }

        private void CreatePropertiesTable()
        {
            int xLabelLoc = 20,
                yLabelLoc = 90,
                xTextBoxLoc = 200,
                yTextBoxLoc = 90;

            foreach (var prop in Service.TableManager.GetBaseProps(_entityType))
            {
                Label label = new Label();
                label.Text = prop.Name;
                label.Name = prop.Name + "Label";
                label.Font = new Font(Font.FontFamily, 10);
                label.Location = new Point(xLabelLoc, yLabelLoc);

                TextBox textBox = new TextBox();
                textBox.Name = prop.Name + "TextBox";
                textBox.Font = new Font(Font.FontFamily, 10);
                textBox.Width = 200;
                textBox.Location = new Point(xTextBoxLoc, yTextBoxLoc);

                Controls.Add(label);
                Controls.Add(textBox);

                _propsTextBox.Add(textBox);

                yLabelLoc += 30;
                yTextBoxLoc += 30;
            }

            CreationBtn.Location = new Point(180, yLabelLoc + 30);
        }

        private void CreationBtn_Click(object sender, EventArgs e)
        {
            List<string> props = new List<string>();

            foreach (TextBox textBox in _propsTextBox) props.Add(textBox.Text);

            Service.CreateEntity(_entityType, props);

            MessageBox.Show("Entity was created");
            Close();
        }
    }
}
