namespace WinasynchMethod
{
    partial class Form1
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
            this.btnrun = new System.Windows.Forms.Button();
            this.btnwork = new System.Windows.Forms.Button();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txbB = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // btnrun
            // 
            this.btnrun.Location = new System.Drawing.Point(16, 64);
            this.btnrun.Name = "btnrun";
            this.btnrun.Size = new System.Drawing.Size(75, 23);
            this.btnrun.TabIndex = 0;
            this.btnrun.Text = "Сумма";
            this.btnrun.UseVisualStyleBackColor = true;
            this.btnrun.Click += new System.EventHandler(this.btnrun_Click);
            // 
            // btnwork
            // 
            this.btnwork.Location = new System.Drawing.Point(120, 128);
            this.btnwork.Name = "btnwork";
            this.btnwork.Size = new System.Drawing.Size(75, 23);
            this.btnwork.TabIndex = 1;
            this.btnwork.Text = "Работа";
            this.btnwork.UseVisualStyleBackColor = true;
            this.btnwork.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(8, 24);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(65, 13);
            this.lblA.TabIndex = 2;
            this.lblA.Text = "Значение А";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(216, 24);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(71, 13);
            this.lblB.TabIndex = 3;
            this.lblB.Text = "Знавчение В";
            this.lblB.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtA
            // 
            this.helpProvider1.SetHelpString(this.txtA, "For input integer A");
            this.txtA.Location = new System.Drawing.Point(88, 24);
            this.txtA.Name = "txtA";
            this.helpProvider1.SetShowHelp(this.txtA, true);
            this.txtA.Size = new System.Drawing.Size(100, 20);
            this.txtA.TabIndex = 4;
            // 
            // txbB
            // 
            this.txbB.Location = new System.Drawing.Point(296, 24);
            this.txbB.Name = "txbB";
            this.txbB.Size = new System.Drawing.Size(100, 20);
            this.txbB.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 161);
            this.Controls.Add(this.txbB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.btnwork);
            this.Controls.Add(this.btnrun);
            this.Name = "Form1";
            this.Text = "Ассинхронный запуск";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnrun;
        private System.Windows.Forms.Button btnwork;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txbB;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}

