using System;
using System.Drawing;
using System.Windows.Forms;
using TextEditorLibrary;

namespace TextEditorApp
{
    public partial class CreateFileForm : Form
    {
        private Button _createBtn = new Button();

        private TextBox _textBox = new TextBox(),
            _filenameTextBox = new TextBox();

        private Label _nameLable = new Label(),
            _textLabel = new Label();

        public CreateFileForm()
        {
            InitializeComponent();

            _nameLable.Name = "Filename";
            _nameLable.Text = "Enter filename:";
            _nameLable.Width = 150;
            _nameLable.Font = new Font(Font.FontFamily, 11);
            _nameLable.Location = new Point(20, 15);
            Controls.Add(_nameLable);

            _textLabel.Name = "TextLabel";
            _textLabel.Text = "Enter text:";
            _textLabel.Font = new Font(Font.FontFamily, 11);
            _textLabel.Location = new Point(20, 75);
            Controls.Add(_textLabel);

            _filenameTextBox.Name = "filenameTextBox";
            _filenameTextBox.Location = new Point(20, 40);
            _filenameTextBox.Width = 360;
            _filenameTextBox.Font = new Font(Font.FontFamily, 10);
            Controls.Add(_filenameTextBox);

            _textBox.Name = "textBox";
            _textBox.Multiline = true;
            _textBox.Location = new Point(20, 100);
            _textBox.Width = 360;
            _textBox.Height = 150;
            _textBox.ScrollBars = ScrollBars.Vertical;
            _textBox.Font = new Font(Font.FontFamily, 10);
            _textBox.KeyDown += TextBox_KeyDown;
            Controls.Add(_textBox);

            _createBtn.Name = "createFileButton";
            _createBtn.Text = "Create";
            _createBtn.Location = new Point(150, 270);
            _createBtn.Width = 90;
            _createBtn.Height = 35;
            _createBtn.Font = new Font(Font.FontFamily, 11);
            _createBtn.Click += CreateButton_Click;
            Controls.Add(_createBtn);
        }

        public void CreateButton_Click(object sender, EventArgs e)
        {
            try
            {
                string filename = _filenameTextBox.Text;
                string text = _textBox.Text;

                FileManager.CreateFile(filename, text);

                MessageBox.Show($"File {filename} was created", "Success!");

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.T && e.Modifiers == Keys.Control)
            {
                _textBox.SelectionStart += 4;
            }
        }
    }
}
