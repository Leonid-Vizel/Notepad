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
using System.Drawing.Printing;

namespace TestForm
{
    public partial class MainWindow : Form
    {
        /// <summary>
        /// Игнорировать изменения в текстовом поле
        /// </summary>
        bool ignoreTextChanges;
        /// <summary>
        /// Поле для свойства 'path' (Не использовать)
        /// </summary>
        private string _path;
        /// <summary>
        /// Путь до открытого документа
        /// </summary> 
        private string path
        {
            get => _path;
            set
            {
                _path = value;
                fileName = _path.Substring(path.LastIndexOf('\\') + 1);
                Text = $"Блокнот - {fileName}";
            }
        }
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
            _path = string.Empty;
            fileName = "Безымянный.txt";
            InitializeComponent();
            Text = $"Блокнот - {fileName}";
        }

        public MainWindow(string path)
        {
            status = true;
            InitializeComponent();
            this.path = path;
        }

        /// <summary>
        /// Метод проверки сохранения и запроса пользователю
        /// </summary>
        /// <returns>true - действие подтверждено; false - дейтвие отклонено</returns>
        private bool CheckSave()
        {
            if (!status)
            {
                if (File.Exists(path))
                {
                    DialogResult result = SaveDialog.ShowDialog(fileName);
                    if (result == DialogResult.Yes)
                    {
                        SaveFile(this,null);
                    }
                    else if (result == DialogResult.Cancel)
                    {
                        return false;
                    }
                }
                else
                {
                    if (!textBox.Text.Equals(string.Empty))
                    {
                        DialogResult result = SaveDialog.ShowDialog(fileName);
                        if (result == DialogResult.Yes)
                        {
                            SaveFileAs(this, null);
                        }
                        else if (result == DialogResult.Cancel)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// Обработка события нажатия Файл->Выход
        /// </summary>
        private void ExitApplication(object sender, EventArgs e)
        {
            if (CheckSave())
            {
                Close();
            }
        }

        /// <summary>
        /// Обработка события нажатия Файл->Сохранить
        /// </summary>
        private void SaveFile(object sender, EventArgs e)
        {
            bool exists = File.Exists(path);
            if (exists && !status)
            {
                try
                {
                    File.WriteAllText(path, textBox.Text);
                    status = true;
                }
                catch (Exception exception)
                {
                    DialogResult result = MessageBox.Show(this,"Ошибка сохранения", $"{exception.Message}]\nХотите сохранить файл '{fileName}' в папке 'Документы'?", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        File.WriteAllText($"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}/{fileName}", textBox.Text);
                    }
                }
            }
            else if (!exists)
            {
                SaveFileAs(sender,e);
            }
        }

        /// <summary>
        /// Обработка события нажатия Файл->Сохранить как
        /// </summary>
        private void SaveFileAs(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            saveDialog.Title = "Сохранение файла";
            saveDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllText(saveDialog.FileName, textBox.Text);
                    path = saveDialog.FileName;
                    status = true;
                }
                catch (Exception exception)
                {
                    DialogResult result = MessageBox.Show(this, $"{exception.Message}]\nХотите сохранить файл '{fileName}' в папке 'Документы'?", "Ошибка сохранения", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        path = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}/{fileName}";
                        File.WriteAllText(path, textBox.Text);
                        status = true;
                    }
                }
            }
        }

        /// <summary>
        /// Обработка события нажатия Файл->Новое окно
        /// </summary>
        private void OpenAgain(object sender, EventArgs e) => Process.Start(Application.ExecutablePath);

        /// <summary>
        /// Обработка события нажатия Файл->Открыть
        /// </summary>
        private void OpenFile(object sender, EventArgs e)
        {
            if (CheckSave())
            {
                OpenFileDialog openDialog = new OpenFileDialog();
                openDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                openDialog.Title = "Открытие файла";
                openDialog.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        ignoreTextChanges = true;
                        textBox.Text = File.ReadAllText(openDialog.FileName);
                        ignoreTextChanges = false;
                        path = openDialog.FileName;
                        status = true;
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(this, exception.Message, "Ошибка чтения");
                    }
                }
            }
        }

        /// <summary>
        /// Обработка события нажатия Файл->Создать
        /// </summary>
        private void Create(object sender, EventArgs e)
        {
            if (CheckSave())
            {
                _path = ""; //Задаю вручную, чтобы не затрагивать fileName
                fileName = "Безымянный.txt";
                Text = $"Блокнот - {fileName}";
                textBox.Text = "";
            }
        }

        /// <summary>
        /// Обработка события нажатия Файл->Печать
        /// </summary>
        private void Print(object sender, EventArgs e)
        {
            PrintDocument document = new PrintDocument();
            document.PrintPage += PrintPage;
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = document;
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                document.Print();
            }
        }

        /// <summary>
        /// Обработка события отрисовки страницы для печати на принтере
        /// </summary>
        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(textBox.Text, textBox.Font, new SolidBrush(textBox.ForeColor), 10, 10);
        }

        /// <summary>
        /// Обрачотка события загрузки формы
        /// </summary>
        private void MainWindow_Load(object sender, EventArgs e)
        {
            if (status)
            {
                try
                {
                    ignoreTextChanges = true;
                    textBox.Text = File.ReadAllText(path);
                    ignoreTextChanges = false;
                }
                catch (Exception exception)
                {
                    MessageBox.Show(this, exception.Message, "Ошибка чтения");
                    Close();
                }
            }
        }

        /// <summary>
        /// Обработка события обновления текста в TextBox
        /// </summary>
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (!ignoreTextChanges)
            {
                if (!Text.StartsWith("*"))
                {
                    //Возможно уберу эту часть кода, так как она нужна болько для красоты (добавления *) и может при больших операциях давать нагрузку
                    Text = $"*{Text}";
                }
                status = false;
            }
        }
    }
}
