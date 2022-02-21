using System;
using System.Windows.Forms;

namespace Notepad
{
    public partial class FindForm : Form
    {
        TextBox parentTextBox;
        public FindForm(TextBox parentTextBox)
        {
            this.parentTextBox = parentTextBox;
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e) => Close();

        private void Find(object sender, EventArgs e)
        {
            string analyzeText = parentTextBox.Text;
            string searchKey = findTextBox.Text;
            if (!registerCheck.Checked)
            {
                analyzeText = analyzeText.ToLower();
                searchKey = searchKey.ToLower();
            }
            if (DownwardsBtn.Checked)
            {
                analyzeText = analyzeText.Substring(parentTextBox.SelectionStart);
                int firstPosition = analyzeText.IndexOf(searchKey);
                if (firstPosition == -1)
                {
                    MessageBox.Show($"Не удаётся найти '{findTextBox.Text}'", "Блокнот");
                }
                else
                {
                    parentTextBox.Select(parentTextBox.SelectionStart + firstPosition, searchKey.Length);
                    parentTextBox.Focus();
                    Close();
                }
            }
            else
            {
                analyzeText = analyzeText.Substring(0,parentTextBox.SelectionStart);
                int firstPosition = analyzeText.IndexOf(searchKey);
                if (firstPosition == -1)
                {
                    MessageBox.Show($"Не удаётся найти '{findTextBox.Text}'", "Блокнот");
                }
                else
                {
                    parentTextBox.Select(firstPosition, searchKey.Length);
                    parentTextBox.Focus();
                    Close();
                }
            }
        }
    }
}
