
namespace Notepad
{
    partial class ReplaceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.oldLabel = new System.Windows.Forms.Label();
            this.newLabel = new System.Windows.Forms.Label();
            this.oldTextBox = new System.Windows.Forms.TextBox();
            this.newTextBox = new System.Windows.Forms.TextBox();
            this.findNextBtn = new System.Windows.Forms.Button();
            this.replaceOnceBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.replaceAllBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // oldLabel
            // 
            this.oldLabel.AutoSize = true;
            this.oldLabel.Location = new System.Drawing.Point(3, 9);
            this.oldLabel.Name = "oldLabel";
            this.oldLabel.Size = new System.Drawing.Size(29, 13);
            this.oldLabel.TabIndex = 0;
            this.oldLabel.Text = "Что:";
            // 
            // newLabel
            // 
            this.newLabel.AutoSize = true;
            this.newLabel.Location = new System.Drawing.Point(3, 35);
            this.newLabel.Name = "newLabel";
            this.newLabel.Size = new System.Drawing.Size(32, 13);
            this.newLabel.TabIndex = 1;
            this.newLabel.Text = "Чем:";
            // 
            // oldTextBox
            // 
            this.oldTextBox.Location = new System.Drawing.Point(38, 6);
            this.oldTextBox.Name = "oldTextBox";
            this.oldTextBox.Size = new System.Drawing.Size(170, 20);
            this.oldTextBox.TabIndex = 2;
            // 
            // newTextBox
            // 
            this.newTextBox.Location = new System.Drawing.Point(38, 32);
            this.newTextBox.Name = "newTextBox";
            this.newTextBox.Size = new System.Drawing.Size(170, 20);
            this.newTextBox.TabIndex = 3;
            // 
            // findNextBtn
            // 
            this.findNextBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.findNextBtn.Location = new System.Drawing.Point(214, 4);
            this.findNextBtn.Name = "findNextBtn";
            this.findNextBtn.Size = new System.Drawing.Size(101, 23);
            this.findNextBtn.TabIndex = 4;
            this.findNextBtn.Text = "Найти далее";
            this.findNextBtn.UseVisualStyleBackColor = true;
            this.findNextBtn.Click += new System.EventHandler(this.findNextBtn_Click);
            // 
            // replaceOnceBtn
            // 
            this.replaceOnceBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.replaceOnceBtn.Location = new System.Drawing.Point(214, 30);
            this.replaceOnceBtn.Name = "replaceOnceBtn";
            this.replaceOnceBtn.Size = new System.Drawing.Size(101, 23);
            this.replaceOnceBtn.TabIndex = 5;
            this.replaceOnceBtn.Text = "Заменить";
            this.replaceOnceBtn.UseVisualStyleBackColor = true;
            this.replaceOnceBtn.Click += new System.EventHandler(this.replaceOnce);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelBtn.Location = new System.Drawing.Point(214, 82);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(101, 23);
            this.cancelBtn.TabIndex = 7;
            this.cancelBtn.Text = "Отмена";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.CloseForm);
            // 
            // replaceAllBtn
            // 
            this.replaceAllBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.replaceAllBtn.Location = new System.Drawing.Point(214, 56);
            this.replaceAllBtn.Name = "replaceAllBtn";
            this.replaceAllBtn.Size = new System.Drawing.Size(101, 23);
            this.replaceAllBtn.TabIndex = 6;
            this.replaceAllBtn.Text = "Заменить все";
            this.replaceAllBtn.UseVisualStyleBackColor = true;
            this.replaceAllBtn.Click += new System.EventHandler(this.replaceAll);
            // 
            // ReplaceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 109);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.replaceAllBtn);
            this.Controls.Add(this.replaceOnceBtn);
            this.Controls.Add(this.findNextBtn);
            this.Controls.Add(this.newTextBox);
            this.Controls.Add(this.oldTextBox);
            this.Controls.Add(this.newLabel);
            this.Controls.Add(this.oldLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReplaceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заменить";
            this.Load += new System.EventHandler(this.OnLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label oldLabel;
        private System.Windows.Forms.Label newLabel;
        private System.Windows.Forms.TextBox oldTextBox;
        private System.Windows.Forms.TextBox newTextBox;
        private System.Windows.Forms.Button findNextBtn;
        private System.Windows.Forms.Button replaceOnceBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button replaceAllBtn;
    }
}