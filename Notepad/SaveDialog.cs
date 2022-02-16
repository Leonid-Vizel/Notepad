using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestForm
{
    public partial class SaveDialog : Form
    {
        private DialogResult result;
        public SaveDialog(string text)
        {
            result = DialogResult.None;
            InitializeComponent();
            label1.Text = $"Вы хотите сохранить изменения в файле '{text}'?";
        }

        public static DialogResult ShowDialog(string name)
        {
            SaveDialog dialog = new SaveDialog(name);
            dialog.ShowDialog();
            return dialog.result;
        }

        private void saveBtn_Click(object sender, EventArgs e) => Answer(DialogResult.Yes);

        private void notSaveBtn_Click(object sender, EventArgs e) => Answer(DialogResult.No);

        private void cancelBtn_Click(object sender, EventArgs e) => Answer(DialogResult.Cancel);

        private void SaveDialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (result == DialogResult.None)
            {
                result = DialogResult.Cancel;
            }
        }

        private void Answer(DialogResult result)
        {
            this.result = result;
            Close();
        }
    }
}
