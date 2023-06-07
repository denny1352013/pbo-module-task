namespace WeatherApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.lab_condtion = new System.Windows.Forms.Label();
            this.lab_detail = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lab_sunrise = new System.Windows.Forms.Label();
            this.lab_sunset = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lab_windspeed = new System.Windows.Forms.Label();
            this.lab_pressure = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Texcari = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(46, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cari kota :";
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Transparent;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(588, 70);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(166, 40);
            this.btn_search.TabIndex = 3;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // lab_condtion
            // 
            this.lab_condtion.AutoSize = true;
            this.lab_condtion.BackColor = System.Drawing.Color.Transparent;
            this.lab_condtion.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_condtion.ForeColor = System.Drawing.Color.White;
            this.lab_condtion.Location = new System.Drawing.Point(49, 146);
            this.lab_condtion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_condtion.Name = "lab_condtion";
            this.lab_condtion.Size = new System.Drawing.Size(113, 29);
            this.lab_condtion.TabIndex = 4;
            this.lab_condtion.Text = "Kondisi:";
            // 
            // lab_detail
            // 
            this.lab_detail.AutoSize = true;
            this.lab_detail.BackColor = System.Drawing.Color.Transparent;
            this.lab_detail.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_detail.ForeColor = System.Drawing.Color.White;
            this.lab_detail.Location = new System.Drawing.Point(49, 206);
            this.lab_detail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_detail.Name = "lab_detail";
            this.lab_detail.Size = new System.Drawing.Size(89, 29);
            this.lab_detail.TabIndex = 5;
            this.lab_detail.Text = "Detail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(49, 272);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sunrise: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(49, 330);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "Sunset: ";
            // 
            // lab_sunrise
            // 
            this.lab_sunrise.AutoSize = true;
            this.lab_sunrise.BackColor = System.Drawing.Color.Transparent;
            this.lab_sunrise.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_sunrise.ForeColor = System.Drawing.Color.White;
            this.lab_sunrise.Location = new System.Drawing.Point(168, 272);
            this.lab_sunrise.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_sunrise.Name = "lab_sunrise";
            this.lab_sunrise.Size = new System.Drawing.Size(0, 29);
            this.lab_sunrise.TabIndex = 8;
            // 
            // lab_sunset
            // 
            this.lab_sunset.AutoSize = true;
            this.lab_sunset.BackColor = System.Drawing.Color.Transparent;
            this.lab_sunset.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_sunset.ForeColor = System.Drawing.Color.White;
            this.lab_sunset.Location = new System.Drawing.Point(168, 330);
            this.lab_sunset.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_sunset.Name = "lab_sunset";
            this.lab_sunset.Size = new System.Drawing.Size(0, 29);
            this.lab_sunset.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(340, 146);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(229, 29);
            this.label8.TabIndex = 10;
            this.label8.Text = "Kecepatan angin";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(340, 206);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 29);
            this.label9.TabIndex = 11;
            this.label9.Text = "Tekanan :";
            // 
            // lab_windspeed
            // 
            this.lab_windspeed.AutoSize = true;
            this.lab_windspeed.BackColor = System.Drawing.Color.Transparent;
            this.lab_windspeed.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_windspeed.ForeColor = System.Drawing.Color.White;
            this.lab_windspeed.Location = new System.Drawing.Point(512, 146);
            this.lab_windspeed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_windspeed.Name = "lab_windspeed";
            this.lab_windspeed.Size = new System.Drawing.Size(0, 29);
            this.lab_windspeed.TabIndex = 12;
            // 
            // lab_pressure
            // 
            this.lab_pressure.AutoSize = true;
            this.lab_pressure.BackColor = System.Drawing.Color.Transparent;
            this.lab_pressure.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_pressure.ForeColor = System.Drawing.Color.White;
            this.lab_pressure.Location = new System.Drawing.Point(504, 206);
            this.lab_pressure.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_pressure.Name = "lab_pressure";
            this.lab_pressure.Size = new System.Drawing.Size(0, 29);
            this.lab_pressure.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1124, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 49);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Texcari
            // 
            this.Texcari.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.Texcari.Location = new System.Drawing.Point(203, 70);
            this.Texcari.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Texcari.Name = "Texcari";
            this.Texcari.Size = new System.Drawing.Size(366, 36);
            this.Texcari.TabIndex = 17;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.Texcari);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lab_pressure);
            this.Controls.Add(this.lab_windspeed);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lab_sunset);
            this.Controls.Add(this.lab_sunrise);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lab_detail);
            this.Controls.Add(this.lab_condtion);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label lab_condtion;
        private System.Windows.Forms.Label lab_detail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lab_sunrise;
        private System.Windows.Forms.Label lab_sunset;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lab_windspeed;
        private System.Windows.Forms.Label lab_pressure;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Texcari;
    }
}

