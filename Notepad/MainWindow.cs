using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace TestForm
{
    public partial class MainWindow : Form
    {
        /// <summary>
        /// Путь до открытого документа
        /// </summary>
        private string path;
        /// <summary>
        /// Статус: Сохранено/Не сохранено
        /// </summary>
        private bool status;
        /// <summary>
        /// Имя открытого документа
        /// </summary>
        private string fileName;

        public MainWindow()
        {
            path = string.Empty;
            InitializeComponent();
        }

        public MainWindow(string path)
        {
            status = true;
            this.path = path;
            fileName = path.Substring(path.LastIndexOf('\\')+1);
            InitializeComponent();
        }

        private bool CheckSave()
        {
            if (!status)
            {
                if ()
                {

                }
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Оработка события нажатия Файл->Выход
        /// </summary>
        private void ExitApplication(object sender, EventArgs e)
        {
            if (CheckSave())
            {
                Close();
            }
        }

        /// <summary>
        /// Оработка события нажатия Файл->Сохранить
        /// </summary>
        private void SaveFile(object sender, EventArgs e)
        {
            if (!status && file)
        }

        /// <summary>
        /// Оработка события нажатия Файл->Сохранить как
        /// </summary>
        private void SaveFileAs(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Оработка события нажатия Файл->Новое окно
        /// </summary>
        private void OpenAgain(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Оработка события нажатия Файл->Создать
        /// </summary>
        private void Create(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Оработка события нажатия Файл->Печать
        /// </summary>
        private void Print(object sender, EventArgs e)
        {

        }
    }
}
