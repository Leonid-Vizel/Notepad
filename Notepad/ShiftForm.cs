using System;
using System.Windows.Forms;

namespace Notepad
{
    public partial class ShiftForm : Form
    {
        TextBox parentTextBox;
        public ShiftForm(TextBox parentTextBox)
        {
            this.parentTextBox = parentTextBox;
            InitializeComponent();
        }

        private void Shift(object sender, EventArgs e)
        {
            int lineIndex = (int)lineNumber.Value - 1;
            if (parentTextBox.Lines.Length > lineIndex && lineIndex >= 0)
            {
                parentTextBox
                    .Select(parentTextBox.GetFirstCharIndexFromLine(lineIndex), parentTextBox.Lines[lineIndex].Length);
            }
            else
            {
                MessageBox.Show("Таковая строка не найдена.","Блокнот");
            }
            Close();
        }
    }
}
