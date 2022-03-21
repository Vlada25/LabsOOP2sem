using System;
using System.Drawing;
using System.Windows.Forms;
using TextEditorLibrary;

namespace TextEditorApp
{
    public partial class OpenFileForm : Form
    {
        private Button _saveBtn = new Button();
        private TextBox _textBox = new TextBox();

        private string _filepath;
        private string _text;

        public OpenFileForm(string filepath)
        {
            InitializeComponent();

            _filepath = filepath;
            _text = FileManager.OpenFile(filepath);

            _textBox.Name = "textBox";
            _textBox.Text = _text;
            _textBox.Multiline = true;
            _textBox.Location = new Point(20, 30);
            _textBox.Width = 360;
            _textBox.Height = 200;
            _textBox.ScrollBars = ScrollBars.Vertical;
            _textBox.Font = new Font(Font.FontFamily, 10);
            _textBox.KeyDown += TextBox_KeyDown;
            Controls.Add(_textBox);

            _saveBtn.Name = "saveFileButton";
            _saveBtn.Text = "Save";
            _saveBtn.Location = new Point(150, 260);
            _saveBtn.Width = 90;
            _saveBtn.Height = 35;
            _saveBtn.Font = new Font(Font.FontFamily, 11);
            _saveBtn.Click += SaveButton_Click;
            Controls.Add(_saveBtn);
        }

        public void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                FileManager.SaveToFile(_filepath, _textBox.Text);

                MessageBox.Show($"Text was written into {_filepath}", "Success!");

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
