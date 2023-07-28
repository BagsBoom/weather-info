namespace WeatherApp
{
    partial class UserControlForecast
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
            this.pictureBoxIconUC = new System.Windows.Forms.PictureBox();
            this.labelTimeUC = new System.Windows.Forms.Label();
            this.labelTempUC = new System.Windows.Forms.Label();
            this.labelDescUC = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIconUC)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxIconUC
            // 
            this.pictureBoxIconUC.Location = new System.Drawing.Point(3, 29);
            this.pictureBoxIconUC.Name = "pictureBoxIconUC";
            this.pictureBoxIconUC.Size = new System.Drawing.Size(100, 80);
            this.pictureBoxIconUC.TabIndex = 0;
            this.pictureBoxIconUC.TabStop = false;
            // 
            // labelTimeUC
            // 
            this.labelTimeUC.AutoSize = true;
            this.labelTimeUC.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTimeUC.Location = new System.Drawing.Point(11, 5);
            this.labelTimeUC.Name = "labelTimeUC";
            this.labelTimeUC.Size = new System.Drawing.Size(46, 19);
            this.labelTimeUC.TabIndex = 1;
            this.labelTimeUC.Text = "Time:";
            // 
            // labelTempUC
            // 
            this.labelTempUC.AutoSize = true;
            this.labelTempUC.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTempUC.Location = new System.Drawing.Point(109, 45);
            this.labelTempUC.Name = "labelTempUC";
            this.labelTempUC.Size = new System.Drawing.Size(56, 23);
            this.labelTempUC.TabIndex = 2;
            this.labelTempUC.Text = "Temp";
            // 
            // labelDescUC
            // 
            this.labelDescUC.AutoSize = true;
            this.labelDescUC.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDescUC.Location = new System.Drawing.Point(109, 68);
            this.labelDescUC.Name = "labelDescUC";
            this.labelDescUC.Size = new System.Drawing.Size(48, 23);
            this.labelDescUC.TabIndex = 3;
            this.labelDescUC.Text = "Desc";
            // 
            // UserControlForecast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelDescUC);
            this.Controls.Add(this.labelTempUC);
            this.Controls.Add(this.labelTimeUC);
            this.Controls.Add(this.pictureBoxIconUC);
            this.Name = "UserControlForecast";
            this.Size = new System.Drawing.Size(185, 119);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIconUC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public PictureBox pictureBoxIconUC;
        public Label labelTimeUC;
        public Label labelTempUC;
        public Label labelDescUC;
    }
}
