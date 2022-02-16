
namespace TestForm
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newWindowMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileItemSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.pageParametersMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileItemSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.CutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.searchMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findNextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findBeforeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WordWrapMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.шрифтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repositoryMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.textBox = new System.Windows.Forms.TextBox();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.editToolStripMenuItem,
            this.formatMenuItem,
            this.viewMenuItem,
            this.infoMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 7;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createMenuItem,
            this.newWindowMenuItem,
            this.openToolStripMenuItem,
            this.saveMenuItem,
            this.saveAsMenuItem,
            this.fileItemSeparator1,
            this.pageParametersMenuItem,
            this.printMenuItem,
            this.fileItemSeparator2,
            this.exitMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(48, 24);
            this.fileMenuItem.Text = "Файл";
            // 
            // createMenuItem
            // 
            this.createMenuItem.Name = "createMenuItem";
            this.createMenuItem.Size = new System.Drawing.Size(204, 22);
            this.createMenuItem.Text = "Создать";
            this.createMenuItem.Click += new System.EventHandler(this.Create);
            // 
            // newWindowMenuItem
            // 
            this.newWindowMenuItem.Name = "newWindowMenuItem";
            this.newWindowMenuItem.Size = new System.Drawing.Size(204, 22);
            this.newWindowMenuItem.Text = "Новое окно";
            this.newWindowMenuItem.Click += new System.EventHandler(this.OpenAgain);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.openToolStripMenuItem.Text = "Открыть...";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenFile);
            // 
            // saveMenuItem
            // 
            this.saveMenuItem.Name = "saveMenuItem";
            this.saveMenuItem.Size = new System.Drawing.Size(204, 22);
            this.saveMenuItem.Text = "Сохранить";
            this.saveMenuItem.Click += new System.EventHandler(this.SaveFile);
            // 
            // saveAsMenuItem
            // 
            this.saveAsMenuItem.Name = "saveAsMenuItem";
            this.saveAsMenuItem.Size = new System.Drawing.Size(204, 22);
            this.saveAsMenuItem.Text = "Сохранить как...";
            this.saveAsMenuItem.Click += new System.EventHandler(this.SaveFileAs);
            // 
            // fileItemSeparator1
            // 
            this.fileItemSeparator1.Name = "fileItemSeparator1";
            this.fileItemSeparator1.Size = new System.Drawing.Size(201, 6);
            // 
            // pageParametersMenuItem
            // 
            this.pageParametersMenuItem.Name = "pageParametersMenuItem";
            this.pageParametersMenuItem.Size = new System.Drawing.Size(204, 22);
            this.pageParametersMenuItem.Text = "Параметры страницы...";
            // 
            // printMenuItem
            // 
            this.printMenuItem.Name = "printMenuItem";
            this.printMenuItem.Size = new System.Drawing.Size(204, 22);
            this.printMenuItem.Text = "Печать...";
            this.printMenuItem.Click += new System.EventHandler(this.Print);
            // 
            // fileItemSeparator2
            // 
            this.fileItemSeparator2.Name = "fileItemSeparator2";
            this.fileItemSeparator2.Size = new System.Drawing.Size(201, 6);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(204, 22);
            this.exitMenuItem.Text = "Выход";
            this.exitMenuItem.Click += new System.EventHandler(this.ExitApplication);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoMenuItem,
            this.EditSeparator1,
            this.CutMenuItem,
            this.copyMenuItem,
            this.pasteMenuItem,
            this.deleteMenuItem,
            this.EditSeparator2,
            this.searchMenuItem,
            this.findToolStripMenuItem,
            this.findNextToolStripMenuItem,
            this.findBeforeToolStripMenuItem,
            this.replaceToolStripMenuItem,
            this.getToToolStripMenuItem,
            this.EditSeparator3,
            this.selectAllMenuItem,
            this.dateTimeMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.editToolStripMenuItem.Text = "Правка";
            // 
            // undoMenuItem
            // 
            this.undoMenuItem.Name = "undoMenuItem";
            this.undoMenuItem.Size = new System.Drawing.Size(179, 22);
            this.undoMenuItem.Text = "Отменить";
            this.undoMenuItem.Click += new System.EventHandler(this.Undo);
            // 
            // EditSeparator1
            // 
            this.EditSeparator1.Name = "EditSeparator1";
            this.EditSeparator1.Size = new System.Drawing.Size(176, 6);
            // 
            // CutMenuItem
            // 
            this.CutMenuItem.Name = "CutMenuItem";
            this.CutMenuItem.Size = new System.Drawing.Size(179, 22);
            this.CutMenuItem.Text = "Вырезать";
            this.CutMenuItem.Click += new System.EventHandler(this.Cut);
            // 
            // copyMenuItem
            // 
            this.copyMenuItem.Name = "copyMenuItem";
            this.copyMenuItem.Size = new System.Drawing.Size(179, 22);
            this.copyMenuItem.Text = "Копировать";
            this.copyMenuItem.Click += new System.EventHandler(this.Copy);
            // 
            // pasteMenuItem
            // 
            this.pasteMenuItem.Name = "pasteMenuItem";
            this.pasteMenuItem.Size = new System.Drawing.Size(179, 22);
            this.pasteMenuItem.Text = "Вставить";
            this.pasteMenuItem.Click += new System.EventHandler(this.Paste);
            // 
            // deleteMenuItem
            // 
            this.deleteMenuItem.Name = "deleteMenuItem";
            this.deleteMenuItem.Size = new System.Drawing.Size(179, 22);
            this.deleteMenuItem.Text = "Удалить";
            this.deleteMenuItem.Click += new System.EventHandler(this.Delete);
            // 
            // EditSeparator2
            // 
            this.EditSeparator2.Name = "EditSeparator2";
            this.EditSeparator2.Size = new System.Drawing.Size(176, 6);
            // 
            // searchMenuItem
            // 
            this.searchMenuItem.Name = "searchMenuItem";
            this.searchMenuItem.Size = new System.Drawing.Size(179, 22);
            this.searchMenuItem.Text = "Поиск в Интернете";
            this.searchMenuItem.Click += new System.EventHandler(this.Search);
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.findToolStripMenuItem.Text = "Найти...";
            // 
            // findNextToolStripMenuItem
            // 
            this.findNextToolStripMenuItem.Name = "findNextToolStripMenuItem";
            this.findNextToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.findNextToolStripMenuItem.Text = "Найти далее";
            // 
            // findBeforeToolStripMenuItem
            // 
            this.findBeforeToolStripMenuItem.Name = "findBeforeToolStripMenuItem";
            this.findBeforeToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.findBeforeToolStripMenuItem.Text = "Найти ранее";
            // 
            // replaceToolStripMenuItem
            // 
            this.replaceToolStripMenuItem.Name = "replaceToolStripMenuItem";
            this.replaceToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.replaceToolStripMenuItem.Text = "Заменить...";
            // 
            // getToToolStripMenuItem
            // 
            this.getToToolStripMenuItem.Name = "getToToolStripMenuItem";
            this.getToToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.getToToolStripMenuItem.Text = "Перейти...";
            // 
            // EditSeparator3
            // 
            this.EditSeparator3.Name = "EditSeparator3";
            this.EditSeparator3.Size = new System.Drawing.Size(176, 6);
            // 
            // selectAllMenuItem
            // 
            this.selectAllMenuItem.Name = "selectAllMenuItem";
            this.selectAllMenuItem.Size = new System.Drawing.Size(179, 22);
            this.selectAllMenuItem.Text = "Выделить всё";
            // 
            // dateTimeMenuItem
            // 
            this.dateTimeMenuItem.Name = "dateTimeMenuItem";
            this.dateTimeMenuItem.Size = new System.Drawing.Size(179, 22);
            this.dateTimeMenuItem.Text = "Дата и время";
            // 
            // formatMenuItem
            // 
            this.formatMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WordWrapMenuItem,
            this.шрифтToolStripMenuItem});
            this.formatMenuItem.Name = "formatMenuItem";
            this.formatMenuItem.Size = new System.Drawing.Size(62, 24);
            this.formatMenuItem.Text = "Формат";
            // 
            // WordWrapMenuItem
            // 
            this.WordWrapMenuItem.Checked = true;
            this.WordWrapMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.WordWrapMenuItem.Name = "WordWrapMenuItem";
            this.WordWrapMenuItem.Size = new System.Drawing.Size(183, 22);
            this.WordWrapMenuItem.Text = "Перенос по словам";
            this.WordWrapMenuItem.Click += new System.EventHandler(this.ChangeWordWrap);
            // 
            // шрифтToolStripMenuItem
            // 
            this.шрифтToolStripMenuItem.Name = "шрифтToolStripMenuItem";
            this.шрифтToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.шрифтToolStripMenuItem.Text = "Шрифт...";
            this.шрифтToolStripMenuItem.Click += new System.EventHandler(this.ChangeFont);
            // 
            // viewMenuItem
            // 
            this.viewMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusStripMenuItem});
            this.viewMenuItem.Name = "viewMenuItem";
            this.viewMenuItem.Size = new System.Drawing.Size(39, 24);
            this.viewMenuItem.Text = "Вид";
            // 
            // statusStripMenuItem
            // 
            this.statusStripMenuItem.Checked = true;
            this.statusStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.statusStripMenuItem.Name = "statusStripMenuItem";
            this.statusStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.statusStripMenuItem.Text = "Строка состояния";
            this.statusStripMenuItem.Click += new System.EventHandler(this.SetStatuStripVisibility);
            // 
            // infoMenuItem
            // 
            this.infoMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.repositoryMenuItem});
            this.infoMenuItem.Name = "infoMenuItem";
            this.infoMenuItem.Size = new System.Drawing.Size(65, 24);
            this.infoMenuItem.Text = "Справка";
            // 
            // repositoryMenuItem
            // 
            this.repositoryMenuItem.Name = "repositoryMenuItem";
            this.repositoryMenuItem.Size = new System.Drawing.Size(146, 22);
            this.repositoryMenuItem.Text = "Репозиторий";
            this.repositoryMenuItem.Click += new System.EventHandler(this.ShowRepository);
            // 
            // statusStrip
            // 
            this.statusStrip.Location = new System.Drawing.Point(0, 428);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(800, 22);
            this.statusStrip.TabIndex = 8;
            this.statusStrip.Text = "statusStrip";
            // 
            // textBox
            // 
            this.textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox.Location = new System.Drawing.Point(0, 24);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(800, 404);
            this.textBox.TabIndex = 9;
            this.textBox.TextChanged += new System.EventHandler(this.OnTextChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Блокнот";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newWindowMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsMenuItem;
        private System.Windows.Forms.ToolStripSeparator fileItemSeparator1;
        private System.Windows.Forms.ToolStripSeparator fileItemSeparator2;
        private System.Windows.Forms.ToolStripMenuItem pageParametersMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.ToolStripMenuItem formatMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoMenuItem;
        private System.Windows.Forms.ToolStripSeparator EditSeparator1;
        private System.Windows.Forms.ToolStripSeparator EditSeparator2;
        private System.Windows.Forms.ToolStripSeparator EditSeparator3;
        private System.Windows.Forms.ToolStripMenuItem CutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findNextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findBeforeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateTimeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repositoryMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WordWrapMenuItem;
        private System.Windows.Forms.ToolStripMenuItem шрифтToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusStripMenuItem;
    }
}

