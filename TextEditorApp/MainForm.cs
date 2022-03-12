using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditorApp
{
    public partial class MainForm : Form
    {
        private Label _header = new Label(),
            _chooseFileLabel = new Label();

        private ComboBox _filesComboBox = new ComboBox();

        private Button _openBtn = new Button(),
            _addBtn = new Button(),
            _deleteBtn = new Button();

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _header.Name = "Header";
            _header.Text = "Text Editor";
            _header.Font = new Font(Font.FontFamily, 13);
            _header.Location = new Point(130, 15);
            Controls.Add(_header);

            _chooseFileLabel.Name = "ChoseFileLabel";
            _chooseFileLabel.Text = "Choose file:";
            _chooseFileLabel.Font = new Font(Font.FontFamily, 11);
            _chooseFileLabel.Location = new Point(30, 70);
            Controls.Add(_chooseFileLabel);

            _filesComboBox.Name = "FileComboBox";
            _filesComboBox.Location = new Point(30, 100);
            _filesComboBox.Width = 150;
            Controls.Add(_filesComboBox);

            _openBtn.Name = "openFileButton";
            _openBtn.Text = "Open";
            _openBtn.Location = new Point(30, 150);
            _openBtn.Width = 90;
            _openBtn.Height = 35;
            _openBtn.Font = new Font(Font.FontFamily, 11);
            Controls.Add(_openBtn);

            _addBtn.Name = "addFileButton";
            _addBtn.Text = "Add";
            _addBtn.Location = new Point(130, 150);
            _addBtn.Width = 90;
            _addBtn.Height = 35;
            _addBtn.Font = new Font(Font.FontFamily, 11);
            Controls.Add(_addBtn);

            _deleteBtn.Name = "deleteFileButton";
            _deleteBtn.Text = "Delete";
            _deleteBtn.Location = new Point(230, 150);
            _deleteBtn.Width = 90;
            _deleteBtn.Height = 35;
            _deleteBtn.Font = new Font(Font.FontFamily, 11);
            Controls.Add(_deleteBtn);
        }
    }
}
