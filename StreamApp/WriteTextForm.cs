using StreamLibrary;
using System;
using System.Windows.Forms;

namespace StreamApp
{
    public partial class WriteTextForm : Form
    {
        private string stream,
            filename;

        public WriteTextForm(string stream, string filename)
        {
            InitializeComponent();
            this.stream = stream;
            this.filename = filename;
        }

        private void WriteTextForm_Load(object sender, EventArgs e)
        {
            infoLabel.Text = $"Stream type: {stream}\nFile: {filename}";
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (textToWrite.Text is null)
                {
                    throw new Exception("You must enter the text");
                }

                if (textToWrite.Text.Contains(combText.Text) && combText.Text.Length > 0)
                {
                    throw new Exception($"Stream was closed because the entered text contains a combination \"{combText.Text}\"");
                }

                MyStream myStream = new MyStream(filename);

                switch (stream)
                {
                    case "FileStream":
                        myStream = new MyFileStream(myStream);
                        myStream.Write(textToWrite.Text);
                        break;
                    case "BufferStream":
                        myStream = new MyBufferStream(myStream);
                        myStream.Write(textToWrite.Text);
                        break;
                    case "MemoryStream":
                        myStream = new MyMemoryStream(myStream);
                        myStream.Write(textToWrite.Text);
                        break;
                }

                MessageBox.Show($"Text was written into {filename} with using {stream}", "Success!");
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }
    }
}
