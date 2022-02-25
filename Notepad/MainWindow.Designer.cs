
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
            this.openMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileItemSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileItemSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.CutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.searchMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shiftMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WordWrapMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FontMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encodingMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ASCIIEncodingMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UTF7EncodingMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UTF8EncodingMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UTF32EncodingMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UnicodeEncodingMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BigUnicodeEncodingMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repositoryMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.rowColStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.encodingStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.textBox = new System.Windows.Forms.TextBox();
            this.colorMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.editMenuItem,
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
            this.openMenuItem,
            this.saveMenuItem,
            this.saveAsMenuItem,
            this.fileItemSeparator1,
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
            this.createMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.createMenuItem.Size = new System.Drawing.Size(235, 22);
            this.createMenuItem.Text = "Создать";
            this.createMenuItem.Click += new System.EventHandler(this.Create);
            // 
            // newWindowMenuItem
            // 
            this.newWindowMenuItem.Name = "newWindowMenuItem";
            this.newWindowMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.newWindowMenuItem.Size = new System.Drawing.Size(235, 22);
            this.newWindowMenuItem.Text = "Новое окно";
            this.newWindowMenuItem.Click += new System.EventHandler(this.OpenAgain);
            // 
            // openMenuItem
            // 
            this.openMenuItem.Name = "openMenuItem";
            this.openMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openMenuItem.Size = new System.Drawing.Size(235, 22);
            this.openMenuItem.Text = "Открыть...";
            this.openMenuItem.Click += new System.EventHandler(this.OpenFile);
            // 
            // saveMenuItem
            // 
            this.saveMenuItem.Name = "saveMenuItem";
            this.saveMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveMenuItem.Size = new System.Drawing.Size(235, 22);
            this.saveMenuItem.Text = "Сохранить";
            this.saveMenuItem.Click += new System.EventHandler(this.SaveFile);
            // 
            // saveAsMenuItem
            // 
            this.saveAsMenuItem.Name = "saveAsMenuItem";
            this.saveAsMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsMenuItem.Size = new System.Drawing.Size(235, 22);
            this.saveAsMenuItem.Text = "Сохранить как...";
            this.saveAsMenuItem.Click += new System.EventHandler(this.SaveFileAs);
            // 
            // fileItemSeparator1
            // 
            this.fileItemSeparator1.Name = "fileItemSeparator1";
            this.fileItemSeparator1.Size = new System.Drawing.Size(232, 6);
            // 
            // printMenuItem
            // 
            this.printMenuItem.Name = "printMenuItem";
            this.printMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printMenuItem.Size = new System.Drawing.Size(235, 22);
            this.printMenuItem.Text = "Печать...";
            this.printMenuItem.Click += new System.EventHandler(this.Print);
            // 
            // fileItemSeparator2
            // 
            this.fileItemSeparator2.Name = "fileItemSeparator2";
            this.fileItemSeparator2.Size = new System.Drawing.Size(232, 6);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.ShortcutKeyDisplayString = "ALT+F4";
            this.exitMenuItem.Size = new System.Drawing.Size(235, 22);
            this.exitMenuItem.Text = "Выход";
            this.exitMenuItem.Click += new System.EventHandler(this.ExitApplication);
            // 
            // editMenuItem
            // 
            this.editMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoMenuItem,
            this.EditSeparator1,
            this.CutMenuItem,
            this.copyMenuItem,
            this.pasteMenuItem,
            this.deleteMenuItem,
            this.EditSeparator2,
            this.searchMenuItem,
            this.findMenuItem,
            this.replaceMenuItem,
            this.shiftMenuItem,
            this.EditSeparator3,
            this.selectAllMenuItem,
            this.dateTimeMenuItem});
            this.editMenuItem.Name = "editMenuItem";
            this.editMenuItem.Size = new System.Drawing.Size(59, 24);
            this.editMenuItem.Text = "Правка";
            // 
            // undoMenuItem
            // 
            this.undoMenuItem.Name = "undoMenuItem";
            this.undoMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoMenuItem.Size = new System.Drawing.Size(219, 22);
            this.undoMenuItem.Text = "Отменить";
            this.undoMenuItem.Click += new System.EventHandler(this.Undo);
            // 
            // EditSeparator1
            // 
            this.EditSeparator1.Name = "EditSeparator1";
            this.EditSeparator1.Size = new System.Drawing.Size(216, 6);
            // 
            // CutMenuItem
            // 
            this.CutMenuItem.Name = "CutMenuItem";
            this.CutMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.CutMenuItem.Size = new System.Drawing.Size(219, 22);
            this.CutMenuItem.Text = "Вырезать";
            this.CutMenuItem.Click += new System.EventHandler(this.Cut);
            // 
            // copyMenuItem
            // 
            this.copyMenuItem.Name = "copyMenuItem";
            this.copyMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyMenuItem.Size = new System.Drawing.Size(219, 22);
            this.copyMenuItem.Text = "Копировать";
            this.copyMenuItem.Click += new System.EventHandler(this.Copy);
            // 
            // pasteMenuItem
            // 
            this.pasteMenuItem.Name = "pasteMenuItem";
            this.pasteMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteMenuItem.Size = new System.Drawing.Size(219, 22);
            this.pasteMenuItem.Text = "Вставить";
            this.pasteMenuItem.Click += new System.EventHandler(this.Paste);
            // 
            // deleteMenuItem
            // 
            this.deleteMenuItem.Name = "deleteMenuItem";
            this.deleteMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteMenuItem.Size = new System.Drawing.Size(219, 22);
            this.deleteMenuItem.Text = "Удалить";
            this.deleteMenuItem.Click += new System.EventHandler(this.Delete);
            // 
            // EditSeparator2
            // 
            this.EditSeparator2.Name = "EditSeparator2";
            this.EditSeparator2.Size = new System.Drawing.Size(216, 6);
            // 
            // searchMenuItem
            // 
            this.searchMenuItem.Name = "searchMenuItem";
            this.searchMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.searchMenuItem.Size = new System.Drawing.Size(219, 22);
            this.searchMenuItem.Text = "Поиск в Интернете";
            this.searchMenuItem.Click += new System.EventHandler(this.Search);
            // 
            // findMenuItem
            // 
            this.findMenuItem.Name = "findMenuItem";
            this.findMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.findMenuItem.Size = new System.Drawing.Size(219, 22);
            this.findMenuItem.Text = "Найти...";
            this.findMenuItem.Click += new System.EventHandler(this.OpenFinder);
            // 
            // replaceMenuItem
            // 
            this.replaceMenuItem.Name = "replaceMenuItem";
            this.replaceMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.replaceMenuItem.Size = new System.Drawing.Size(219, 22);
            this.replaceMenuItem.Text = "Заменить...";
            this.replaceMenuItem.Click += new System.EventHandler(this.OpenReplacer);
            // 
            // shiftMenuItem
            // 
            this.shiftMenuItem.Name = "shiftMenuItem";
            this.shiftMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.shiftMenuItem.Size = new System.Drawing.Size(219, 22);
            this.shiftMenuItem.Text = "Перейти...";
            this.shiftMenuItem.Click += new System.EventHandler(this.OpenShifter);
            // 
            // EditSeparator3
            // 
            this.EditSeparator3.Name = "EditSeparator3";
            this.EditSeparator3.Size = new System.Drawing.Size(216, 6);
            // 
            // selectAllMenuItem
            // 
            this.selectAllMenuItem.Name = "selectAllMenuItem";
            this.selectAllMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllMenuItem.Size = new System.Drawing.Size(219, 22);
            this.selectAllMenuItem.Text = "Выделить всё";
            this.selectAllMenuItem.Click += new System.EventHandler(this.SelectAll);
            // 
            // dateTimeMenuItem
            // 
            this.dateTimeMenuItem.Name = "dateTimeMenuItem";
            this.dateTimeMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.dateTimeMenuItem.Size = new System.Drawing.Size(219, 22);
            this.dateTimeMenuItem.Text = "Время и дата";
            this.dateTimeMenuItem.Click += new System.EventHandler(this.PasteCurrentDateTime);
            // 
            // formatMenuItem
            // 
            this.formatMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WordWrapMenuItem,
            this.FontMenuItem,
            this.encodingMenuItem,
            this.colorMenuItem});
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
            // FontMenuItem
            // 
            this.FontMenuItem.Name = "FontMenuItem";
            this.FontMenuItem.Size = new System.Drawing.Size(183, 22);
            this.FontMenuItem.Text = "Шрифт...";
            this.FontMenuItem.Click += new System.EventHandler(this.ChangeFont);
            // 
            // encodingMenuItem
            // 
            this.encodingMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ASCIIEncodingMenuItem,
            this.UTF7EncodingMenuItem,
            this.UTF8EncodingMenuItem,
            this.UTF32EncodingMenuItem,
            this.UnicodeEncodingMenuItem,
            this.BigUnicodeEncodingMenuItem});
            this.encodingMenuItem.Name = "encodingMenuItem";
            this.encodingMenuItem.Size = new System.Drawing.Size(183, 22);
            this.encodingMenuItem.Text = "Кодировка";
            // 
            // ASCIIEncodingMenuItem
            // 
            this.ASCIIEncodingMenuItem.Name = "ASCIIEncodingMenuItem";
            this.ASCIIEncodingMenuItem.Size = new System.Drawing.Size(177, 22);
            this.ASCIIEncodingMenuItem.Text = "ASCII";
            this.ASCIIEncodingMenuItem.Click += new System.EventHandler(this.UpdateEncoding);
            // 
            // UTF7EncodingMenuItem
            // 
            this.UTF7EncodingMenuItem.Name = "UTF7EncodingMenuItem";
            this.UTF7EncodingMenuItem.Size = new System.Drawing.Size(177, 22);
            this.UTF7EncodingMenuItem.Text = "UTF-7";
            this.UTF7EncodingMenuItem.Click += new System.EventHandler(this.UpdateEncoding);
            // 
            // UTF8EncodingMenuItem
            // 
            this.UTF8EncodingMenuItem.Checked = true;
            this.UTF8EncodingMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.UTF8EncodingMenuItem.Name = "UTF8EncodingMenuItem";
            this.UTF8EncodingMenuItem.Size = new System.Drawing.Size(177, 22);
            this.UTF8EncodingMenuItem.Text = "UTF-8";
            this.UTF8EncodingMenuItem.Click += new System.EventHandler(this.UpdateEncoding);
            // 
            // UTF32EncodingMenuItem
            // 
            this.UTF32EncodingMenuItem.Name = "UTF32EncodingMenuItem";
            this.UTF32EncodingMenuItem.Size = new System.Drawing.Size(177, 22);
            this.UTF32EncodingMenuItem.Text = "UTF-32";
            this.UTF32EncodingMenuItem.Click += new System.EventHandler(this.UpdateEncoding);
            // 
            // UnicodeEncodingMenuItem
            // 
            this.UnicodeEncodingMenuItem.Name = "UnicodeEncodingMenuItem";
            this.UnicodeEncodingMenuItem.Size = new System.Drawing.Size(177, 22);
            this.UnicodeEncodingMenuItem.Text = "Unicode";
            this.UnicodeEncodingMenuItem.Click += new System.EventHandler(this.UpdateEncoding);
            // 
            // BigUnicodeEncodingMenuItem
            // 
            this.BigUnicodeEncodingMenuItem.Name = "BigUnicodeEncodingMenuItem";
            this.BigUnicodeEncodingMenuItem.Size = new System.Drawing.Size(177, 22);
            this.BigUnicodeEncodingMenuItem.Text = "Big Endian Unicode";
            this.BigUnicodeEncodingMenuItem.Click += new System.EventHandler(this.UpdateEncoding);
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
            this.repositoryMenuItem.Size = new System.Drawing.Size(180, 22);
            this.repositoryMenuItem.Text = "Репозиторий";
            this.repositoryMenuItem.Click += new System.EventHandler(this.ShowRepository);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rowColStatusLabel,
            this.encodingStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 428);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(800, 22);
            this.statusStrip.TabIndex = 8;
            this.statusStrip.Text = "statusStrip";
            // 
            // rowColStatusLabel
            // 
            this.rowColStatusLabel.Name = "rowColStatusLabel";
            this.rowColStatusLabel.Size = new System.Drawing.Size(115, 17);
            this.rowColStatusLabel.Text = "Строка:1, столбец:1";
            // 
            // encodingStatus
            // 
            this.encodingStatus.Name = "encodingStatus";
            this.encodingStatus.Size = new System.Drawing.Size(103, 17);
            this.encodingStatus.Text = "Кодировка: UTF-8";
            // 
            // textBox
            // 
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox.Location = new System.Drawing.Point(0, 24);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox.Size = new System.Drawing.Size(800, 404);
            this.textBox.TabIndex = 9;
            this.textBox.TextChanged += new System.EventHandler(this.OnTextChanged);
            this.textBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyUp);
            this.textBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // colorMenuItem
            // 
            this.colorMenuItem.Name = "colorMenuItem";
            this.colorMenuItem.Size = new System.Drawing.Size(183, 22);
            this.colorMenuItem.Text = "Цвет...";
            this.colorMenuItem.Click += new System.EventHandler(this.ChangeColor);
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newWindowMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsMenuItem;
        private System.Windows.Forms.ToolStripSeparator fileItemSeparator1;
        private System.Windows.Forms.ToolStripSeparator fileItemSeparator2;
        private System.Windows.Forms.ToolStripMenuItem printMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMenuItem;
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
        private System.Windows.Forms.ToolStripMenuItem findMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replaceMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shiftMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateTimeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repositoryMenuItem;
        private System.Windows.Forms.ToolStripMenuItem WordWrapMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FontMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel rowColStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel encodingStatus;
        private System.Windows.Forms.ToolStripMenuItem encodingMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ASCIIEncodingMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UTF7EncodingMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UTF8EncodingMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UTF32EncodingMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UnicodeEncodingMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BigUnicodeEncodingMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorMenuItem;
    }
}

