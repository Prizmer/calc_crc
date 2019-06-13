namespace CRCCalc
{
    partial class CtlCrcCalc
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBoxAlgorithms = new System.Windows.Forms.ListBox();
            this.panelDrop = new System.Windows.Forms.Panel();
            this.lblDropNote = new System.Windows.Forms.Label();
            this.tbCRC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelDrop.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxAlgorithms
            // 
            this.listBoxAlgorithms.FormattingEnabled = true;
            this.listBoxAlgorithms.ItemHeight = 16;
            this.listBoxAlgorithms.Location = new System.Drawing.Point(15, 15);
            this.listBoxAlgorithms.Name = "listBoxAlgorithms";
            this.listBoxAlgorithms.Size = new System.Drawing.Size(213, 260);
            this.listBoxAlgorithms.TabIndex = 0;
            this.listBoxAlgorithms.DoubleClick += new System.EventHandler(this.listBoxAlgorithms_DoubleClick);
            // 
            // panelDrop
            // 
            this.panelDrop.AllowDrop = true;
            this.panelDrop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDrop.Controls.Add(this.lblDropNote);
            this.panelDrop.Location = new System.Drawing.Point(15, 321);
            this.panelDrop.Name = "panelDrop";
            this.panelDrop.Size = new System.Drawing.Size(213, 51);
            this.panelDrop.TabIndex = 1;
            this.panelDrop.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelDrop_DragDrop);
            this.panelDrop.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelDrop_DragEnter);
            this.panelDrop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDrop_Paint);
            this.panelDrop.MouseEnter += new System.EventHandler(this.panelDrop_MouseEnter);
            // 
            // lblDropNote
            // 
            this.lblDropNote.AutoSize = true;
            this.lblDropNote.Location = new System.Drawing.Point(41, 16);
            this.lblDropNote.Name = "lblDropNote";
            this.lblDropNote.Size = new System.Drawing.Size(128, 17);
            this.lblDropNote.TabIndex = 0;
            this.lblDropNote.Text = "Перетащите сюда";
            // 
            // tbCRC
            // 
            this.tbCRC.Location = new System.Drawing.Point(60, 281);
            this.tbCRC.Name = "tbCRC";
            this.tbCRC.ReadOnly = true;
            this.tbCRC.Size = new System.Drawing.Size(168, 22);
            this.tbCRC.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "CRC";
            // 
            // CtlCrcCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCRC);
            this.Controls.Add(this.panelDrop);
            this.Controls.Add(this.listBoxAlgorithms);
            this.Name = "CtlCrcCalc";
            this.Size = new System.Drawing.Size(243, 389);
            this.Load += new System.EventHandler(this.CtlCrcCalc_Load);
            this.panelDrop.ResumeLayout(false);
            this.panelDrop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAlgorithms;
        private System.Windows.Forms.Panel panelDrop;
        private System.Windows.Forms.Label lblDropNote;
        private System.Windows.Forms.TextBox tbCRC;
        private System.Windows.Forms.Label label2;
    }
}
