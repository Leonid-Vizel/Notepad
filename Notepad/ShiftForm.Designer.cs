
namespace Notepad
{
    partial class ShiftForm
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
            this.lineLabel = new System.Windows.Forms.Label();
            this.lineNumber = new System.Windows.Forms.NumericUpDown();
            this.shiftBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lineNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // lineLabel
            // 
            this.lineLabel.AutoSize = true;
            this.lineLabel.Location = new System.Drawing.Point(12, 9);
            this.lineLabel.Name = "lineLabel";
            this.lineLabel.Size = new System.Drawing.Size(125, 13);
            this.lineLabel.TabIndex = 0;
            this.lineLabel.Text = "Укажите номер строки";
            // 
            // lineNumber
            // 
            this.lineNumber.Location = new System.Drawing.Point(15, 25);
            this.lineNumber.Name = "lineNumber";
            this.lineNumber.Size = new System.Drawing.Size(122, 20);
            this.lineNumber.TabIndex = 1;
            // 
            // shiftBtn
            // 
            this.shiftBtn.Location = new System.Drawing.Point(15, 51);
            this.shiftBtn.Name = "shiftBtn";
            this.shiftBtn.Size = new System.Drawing.Size(122, 23);
            this.shiftBtn.TabIndex = 2;
            this.shiftBtn.Text = "Перейти";
            this.shiftBtn.UseVisualStyleBackColor = true;
            this.shiftBtn.Click += new System.EventHandler(this.Shift);
            // 
            // ShiftForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(153, 86);
            this.Controls.Add(this.shiftBtn);
            this.Controls.Add(this.lineNumber);
            this.Controls.Add(this.lineLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShiftForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Блокнот";
            ((System.ComponentModel.ISupportInitialize)(this.lineNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lineLabel;
        private System.Windows.Forms.NumericUpDown lineNumber;
        private System.Windows.Forms.Button shiftBtn;
    }
}