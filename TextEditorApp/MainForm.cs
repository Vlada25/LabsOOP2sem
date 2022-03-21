using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TextEditorLibrary;

namespace TextEditorApp
{
    public partial class MainForm : Form
    {
        private Label _header = new Label(),
            _chooseFileLabel = new Label();

        private ComboBox _filesComboBox = new ComboBox();

        private Button _openBtn = new Button(),
            _createBtn = new Button(),
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
            _filesComboBox.Items.AddRange(FileManager.Filepaths.ToArray());
            Controls.Add(_filesComboBox);

            _openBtn.Name = "openFileButton";
            _openBtn.Text = "Open";
            _openBtn.Location = new Point(30, 150);
            _openBtn.Width = 90;
            _openBtn.Height = 35;
            _openBtn.Font = new Font(Font.FontFamily, 11);
            _openBtn.Click += OpenButton_Click;
            Controls.Add(_openBtn);

            _createBtn.Name = "createFileButton";
            _createBtn.Text = "Create";
            _createBtn.Location = new Point(130, 150);
            _createBtn.Width = 90;
            _createBtn.Height = 35;
            _createBtn.Font = new Font(Font.FontFamily, 11);
            _createBtn.Click += CreateButton_Click;
            Controls.Add(_createBtn);
        }

        public void OpenButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (_filesComboBox.SelectedItem is null)
                {
                    throw new Exception("You must choose file");
                }

                string filepath = (string)_filesComboBox.SelectedItem;

                OpenFileForm openFileForm = new OpenFileForm(filepath);
                openFileForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        public void CreateButton_Click(object sender, EventArgs e)
        {
            try
            {
                CreateFileForm createFileForm = new CreateFileForm();
                createFileForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }
    }
}
