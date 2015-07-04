namespace min_lan
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.memoryLabel = new System.Windows.Forms.Label();
            this.button512 = new System.Windows.Forms.Button();
            this.button1024 = new System.Windows.Forms.Button();
            this.button2048 = new System.Windows.Forms.Button();
            this.button3072 = new System.Windows.Forms.Button();
            this.button4096 = new System.Windows.Forms.Button();
            this.button6144 = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            this.SuspendLayout();
            // 
            // memoryLabel
            // 
            this.memoryLabel.AutoSize = true;
            this.memoryLabel.BackColor = System.Drawing.Color.Transparent;
            this.memoryLabel.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.memoryLabel.ForeColor = System.Drawing.Color.White;
            this.memoryLabel.Location = new System.Drawing.Point(203, 9);
            this.memoryLabel.Name = "memoryLabel";
            this.memoryLabel.Size = new System.Drawing.Size(413, 37);
            this.memoryLabel.TabIndex = 7;
            this.memoryLabel.Text = "Выбор выделения памяти";
            // 
            // button512
            // 
            this.button512.BackColor = System.Drawing.SystemColors.Window;
            this.button512.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button512.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button512.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(127)))), ((int)(((byte)(191)))));
            this.button512.Location = new System.Drawing.Point(15, 49);
            this.button512.Name = "button512";
            this.button512.Size = new System.Drawing.Size(128, 40);
            this.button512.TabIndex = 8;
            this.button512.Text = "512";
            this.button512.UseVisualStyleBackColor = false;
            this.button512.Click += new System.EventHandler(this.button_Click);
            // 
            // button1024
            // 
            this.button1024.BackColor = System.Drawing.SystemColors.Window;
            this.button1024.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1024.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1024.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(127)))), ((int)(((byte)(191)))));
            this.button1024.Location = new System.Drawing.Point(149, 49);
            this.button1024.Name = "button1024";
            this.button1024.Size = new System.Drawing.Size(128, 40);
            this.button1024.TabIndex = 9;
            this.button1024.Text = "1024";
            this.button1024.UseVisualStyleBackColor = false;
            this.button1024.Click += new System.EventHandler(this.button_Click);
            // 
            // button2048
            // 
            this.button2048.BackColor = System.Drawing.SystemColors.Window;
            this.button2048.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2048.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2048.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(127)))), ((int)(((byte)(191)))));
            this.button2048.Location = new System.Drawing.Point(283, 49);
            this.button2048.Name = "button2048";
            this.button2048.Size = new System.Drawing.Size(128, 40);
            this.button2048.TabIndex = 10;
            this.button2048.Text = "2048";
            this.button2048.UseVisualStyleBackColor = false;
            this.button2048.Click += new System.EventHandler(this.button_Click);
            // 
            // button3072
            // 
            this.button3072.BackColor = System.Drawing.SystemColors.Window;
            this.button3072.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3072.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3072.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(127)))), ((int)(((byte)(191)))));
            this.button3072.Location = new System.Drawing.Point(417, 49);
            this.button3072.Name = "button3072";
            this.button3072.Size = new System.Drawing.Size(128, 40);
            this.button3072.TabIndex = 11;
            this.button3072.Text = "3072";
            this.button3072.UseVisualStyleBackColor = false;
            this.button3072.Click += new System.EventHandler(this.button_Click);
            // 
            // button4096
            // 
            this.button4096.BackColor = System.Drawing.SystemColors.Window;
            this.button4096.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4096.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4096.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(127)))), ((int)(((byte)(191)))));
            this.button4096.Location = new System.Drawing.Point(551, 49);
            this.button4096.Name = "button4096";
            this.button4096.Size = new System.Drawing.Size(128, 40);
            this.button4096.TabIndex = 12;
            this.button4096.Text = "4096";
            this.button4096.UseVisualStyleBackColor = false;
            this.button4096.Click += new System.EventHandler(this.button_Click);
            // 
            // button6144
            // 
            this.button6144.BackColor = System.Drawing.SystemColors.Window;
            this.button6144.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6144.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6144.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(127)))), ((int)(((byte)(191)))));
            this.button6144.Location = new System.Drawing.Point(685, 49);
            this.button6144.Name = "button6144";
            this.button6144.Size = new System.Drawing.Size(128, 40);
            this.button6144.TabIndex = 13;
            this.button6144.Text = "6144";
            this.button6144.UseVisualStyleBackColor = false;
            this.button6144.Click += new System.EventHandler(this.button_Click);
            // 
            // closeButton
            // 
            this.closeButton.Image = global::min_lan.Properties.Resources.close;
            this.closeButton.Location = new System.Drawing.Point(783, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(46, 30);
            this.closeButton.TabIndex = 14;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.pictureBox1_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(127)))), ((int)(((byte)(191)))));
            this.ClientSize = new System.Drawing.Size(828, 101);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.button6144);
            this.Controls.Add(this.button4096);
            this.Controls.Add(this.button3072);
            this.Controls.Add(this.button2048);
            this.Controls.Add(this.button1024);
            this.Controls.Add(this.button512);
            this.Controls.Add(this.memoryLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Память";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MoveVindow);
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label memoryLabel;
        private System.Windows.Forms.Button button512;
        private System.Windows.Forms.Button button1024;
        private System.Windows.Forms.Button button2048;
        private System.Windows.Forms.Button button3072;
        private System.Windows.Forms.Button button4096;
        private System.Windows.Forms.Button button6144;
        private System.Windows.Forms.PictureBox closeButton;
    }
}