using System;
using System.Windows.Forms;

namespace TestForm
{
    public partial class SaveDialog : Form
    {
        /// <summary>
        /// Результат, который выбрал пользователь
        /// </summary>
        private DialogResult result;

        /// <summary>
        /// НЕ ИСПОЛЬЗОВАТЬ. ЗАМЕНА: ShowDialog
        /// </summary>
        public SaveDialog(string fileName)
        {
            result = DialogResult.None;
            InitializeComponent();
            label1.Text = $"Вы хотите сохранить изменения в файле '{fileName}'?";
        }

        /// <summary>
        /// Метод для ПРАВИЛЬНОГО отображения формы и возвращения результата
        /// </summary>
        public static DialogResult ShowDialog(string name)
        {
            SaveDialog dialog = new SaveDialog(name);
            dialog.ShowDialog();
            return dialog.result;
        }

        /// <summary>
        /// Обработка события нажатия на кнопку "Сохранить"
        /// </summary>
        private void saveBtnClick(object sender, EventArgs e) => Answer(DialogResult.Yes);

        /// <summary>
        /// Обработка события нажатия на кнопку "Не сохранять"
        /// </summary>
        private void notSaveBtnClick(object sender, EventArgs e) => Answer(DialogResult.No);

        /// <summary>
        /// Обработка события нажатия на кнопку "Отмена"
        /// </summary>
        private void cancelBtnClick(object sender, EventArgs e) => Answer(DialogResult.Cancel);

        /// <summary>
        /// Обработка события закрытия формы
        /// </summary>
        private void OnFormClosed(object sender, FormClosedEventArgs e)
        {
            if (result == DialogResult.None)
            {
                result = DialogResult.Cancel;
            }
        }

        /// <summary>
        /// Сохранить ответ и загрыть окно
        /// </summary>
        private void Answer(DialogResult result)
        {
            this.result = result;
            Close();
        }
    }
}
