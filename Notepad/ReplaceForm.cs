using System;
using System.Windows.Forms;

namespace Notepad
{
    public partial class ReplaceForm : Form
    {
        private TextBox parentTextBox;
        public ReplaceForm(TextBox parentTextBox)
        {
            this.parentTextBox = parentTextBox;
            InitializeComponent();
        }

        private void CloseForm(object sender, EventArgs e) => Close();

        private void OnLoad(object sender, EventArgs e)
        {
            oldTextBox.Text = Clipboard.GetText();
        }

        private void replaceAll(object sender, EventArgs e)
        {
            if (oldTextBox.Text.Length > 0)
            {
                parentTextBox.Text = parentTextBox.Text.Replace(oldTextBox.Text, newTextBox.Text);
                MessageBox.Show("Выполнено!", "Блокнот");
            }
        }

        private void replaceOnce(object sender, EventArgs e)
        {
            string analysingText = parentTextBox.Text.Substring(parentTextBox.SelectionStart);
            int firstPosition = analysingText.IndexOf(oldTextBox.Text);
            if (firstPosition == -1)
            {
                MessageBox.Show($"Не удаётся найти '{oldTextBox.Text}'", "Блокнот");
            }
            else
            {
                parentTextBox.Text = parentTextBox.Text
                            .Remove(parentTextBox.SelectionStart)
                            + analysingText
                            .Remove(firstPosition, oldTextBox.Text.Length)
                            .Insert(firstPosition, newTextBox.Text);
            }
        }

        private void findNextBtn_Click(object sender, EventArgs e)
        {
            string analysingText = parentTextBox.Text.Substring(parentTextBox.SelectionStart);
            int firstPosition = analysingText.IndexOf(oldTextBox.Text);
            if (firstPosition == -1)
            {
                MessageBox.Show($"Не удаётся найти '{oldTextBox.Text}'", "Блокнот");
            }
            else
            {
                parentTextBox.Select(parentTextBox.SelectionStart + firstPosition, oldTextBox.Text.Length);
                parentTextBox.Focus();
            }
        }
    }
}
