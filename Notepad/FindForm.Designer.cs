
namespace Notepad
{
    partial class FindForm
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
            this.findLabel = new System.Windows.Forms.Label();
            this.findTextBox = new System.Windows.Forms.TextBox();
            this.directionGroup = new System.Windows.Forms.GroupBox();
            this.DownwardsBtn = new System.Windows.Forms.RadioButton();
            this.UpwardsBtn = new System.Windows.Forms.RadioButton();
            this.findBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.registerCheck = new System.Windows.Forms.CheckBox();
            this.directionGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // findLabel
            // 
            this.findLabel.AutoSize = true;
            this.findLabel.Location = new System.Drawing.Point(12, 9);
            this.findLabel.Name = "findLabel";
            this.findLabel.Size = new System.Drawing.Size(41, 13);
            this.findLabel.TabIndex = 0;
            this.findLabel.Text = "Найти:";
            // 
            // findTextBox
            // 
            this.findTextBox.Location = new System.Drawing.Point(12, 25);
            this.findTextBox.Name = "findTextBox";
            this.findTextBox.Size = new System.Drawing.Size(374, 20);
            this.findTextBox.TabIndex = 1;
            // 
            // directionGroup
            // 
            this.directionGroup.Controls.Add(this.DownwardsBtn);
            this.directionGroup.Controls.Add(this.UpwardsBtn);
            this.directionGroup.Location = new System.Drawing.Point(291, 52);
            this.directionGroup.Name = "directionGroup";
            this.directionGroup.Size = new System.Drawing.Size(95, 68);
            this.directionGroup.TabIndex = 2;
            this.directionGroup.TabStop = false;
            this.directionGroup.Text = "Направление";
            // 
            // DownwardsBtn
            // 
            this.DownwardsBtn.AutoSize = true;
            this.DownwardsBtn.Location = new System.Drawing.Point(6, 42);
            this.DownwardsBtn.Name = "DownwardsBtn";
            this.DownwardsBtn.Size = new System.Drawing.Size(58, 17);
            this.DownwardsBtn.TabIndex = 1;
            this.DownwardsBtn.TabStop = true;
            this.DownwardsBtn.Text = "Далее";
            this.DownwardsBtn.UseVisualStyleBackColor = true;
            // 
            // UpwardsBtn
            // 
            this.UpwardsBtn.AutoSize = true;
            this.UpwardsBtn.Checked = true;
            this.UpwardsBtn.Location = new System.Drawing.Point(6, 19);
            this.UpwardsBtn.Name = "UpwardsBtn";
            this.UpwardsBtn.Size = new System.Drawing.Size(56, 17);
            this.UpwardsBtn.TabIndex = 0;
            this.UpwardsBtn.TabStop = true;
            this.UpwardsBtn.Text = "Ранее";
            this.UpwardsBtn.UseVisualStyleBackColor = true;
            // 
            // findBtn
            // 
            this.findBtn.Location = new System.Drawing.Point(392, 23);
            this.findBtn.Name = "findBtn";
            this.findBtn.Size = new System.Drawing.Size(75, 23);
            this.findBtn.TabIndex = 3;
            this.findBtn.Text = "Найти";
            this.findBtn.UseVisualStyleBackColor = true;
            this.findBtn.Click += new System.EventHandler(this.Find);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(392, 52);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "Отмена";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // registerCheck
            // 
            this.registerCheck.AutoSize = true;
            this.registerCheck.Checked = true;
            this.registerCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.registerCheck.Location = new System.Drawing.Point(12, 51);
            this.registerCheck.Name = "registerCheck";
            this.registerCheck.Size = new System.Drawing.Size(124, 17);
            this.registerCheck.TabIndex = 5;
            this.registerCheck.Text = "Учитывать регистр";
            this.registerCheck.UseVisualStyleBackColor = true;
            // 
            // FindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 127);
            this.Controls.Add(this.registerCheck);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.findBtn);
            this.Controls.Add(this.directionGroup);
            this.Controls.Add(this.findTextBox);
            this.Controls.Add(this.findLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FindForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Блокнот";
            this.directionGroup.ResumeLayout(false);
            this.directionGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label findLabel;
        private System.Windows.Forms.TextBox findTextBox;
        private System.Windows.Forms.GroupBox directionGroup;
        private System.Windows.Forms.Button findBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.CheckBox registerCheck;
        private System.Windows.Forms.RadioButton DownwardsBtn;
        private System.Windows.Forms.RadioButton UpwardsBtn;
    }
}