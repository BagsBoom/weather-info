namespace WeatherApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timeLabel = new System.Windows.Forms.Label();
            this.changeLocButton = new System.Windows.Forms.Button();
            this.labelCity = new System.Windows.Forms.Label();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            this.labelTemp = new System.Windows.Forms.Label();
            this.textBoxCity = new System.Windows.Forms.TextBox();
            this.labelDesc = new System.Windows.Forms.Label();
            this.FLPForecast = new System.Windows.Forms.FlowLayoutPanel();
            this.labelDayOfWeek = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.timeLabel.Location = new System.Drawing.Point(424, 9);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(61, 26);
            this.timeLabel.TabIndex = 0;
            this.timeLabel.Text = "Time:";
            // 
            // changeLocButton
            // 
            this.changeLocButton.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.changeLocButton.Location = new System.Drawing.Point(12, 38);
            this.changeLocButton.Name = "changeLocButton";
            this.changeLocButton.Size = new System.Drawing.Size(118, 23);
            this.changeLocButton.TabIndex = 1;
            this.changeLocButton.Text = "Change location";
            this.changeLocButton.UseVisualStyleBackColor = true;
            this.changeLocButton.Click += new System.EventHandler(this.changeLocButton_Click);
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCity.Location = new System.Drawing.Point(229, 167);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(129, 26);
            this.labelCity.TabIndex = 2;
            this.labelCity.Text = "City, Country";
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxIcon.Location = new System.Drawing.Point(245, 99);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(100, 64);
            this.pictureBoxIcon.TabIndex = 3;
            this.pictureBoxIcon.TabStop = false;
            // 
            // labelTemp
            // 
            this.labelTemp.AutoSize = true;
            this.labelTemp.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTemp.Location = new System.Drawing.Point(243, 192);
            this.labelTemp.Name = "labelTemp";
            this.labelTemp.Size = new System.Drawing.Size(62, 26);
            this.labelTemp.TabIndex = 4;
            this.labelTemp.Text = "Temp";
            // 
            // textBoxCity
            // 
            this.textBoxCity.Location = new System.Drawing.Point(12, 9);
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.PlaceholderText = "City name:";
            this.textBoxCity.Size = new System.Drawing.Size(118, 23);
            this.textBoxCity.TabIndex = 5;
            // 
            // labelDesc
            // 
            this.labelDesc.AutoSize = true;
            this.labelDesc.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDesc.Location = new System.Drawing.Point(230, 67);
            this.labelDesc.Name = "labelDesc";
            this.labelDesc.Size = new System.Drawing.Size(61, 29);
            this.labelDesc.TabIndex = 6;
            this.labelDesc.Text = "Desc";
            // 
            // FLPForecast
            // 
            this.FLPForecast.BackColor = System.Drawing.Color.Transparent;
            this.FLPForecast.Location = new System.Drawing.Point(31, 233);
            this.FLPForecast.Name = "FLPForecast";
            this.FLPForecast.Size = new System.Drawing.Size(524, 116);
            this.FLPForecast.TabIndex = 7;
            // 
            // labelDayOfWeek
            // 
            this.labelDayOfWeek.AutoSize = true;
            this.labelDayOfWeek.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelDayOfWeek.Location = new System.Drawing.Point(424, 38);
            this.labelDayOfWeek.Name = "labelDayOfWeek";
            this.labelDayOfWeek.Size = new System.Drawing.Size(61, 26);
            this.labelDayOfWeek.TabIndex = 8;
            this.labelDayOfWeek.Text = "Time:";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Tan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.labelDayOfWeek);
            this.Controls.Add(this.FLPForecast);
            this.Controls.Add(this.labelDesc);
            this.Controls.Add(this.textBoxCity);
            this.Controls.Add(this.labelTemp);
            this.Controls.Add(this.pictureBoxIcon);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.changeLocButton);
            this.Controls.Add(this.timeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weather Info";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label timeLabel;
        private Button changeLocButton;
        private Label labelCity;
        private PictureBox pictureBoxIcon;
        private Label labelTemp;
        private TextBox textBoxCity;
        private Label labelDesc;
        private FlowLayoutPanel FLPForecast;
        private Label labelDayOfWeek;
    }
}