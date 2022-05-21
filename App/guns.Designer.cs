namespace App
{
    partial class guns
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
            this.txt = new System.Windows.Forms.RichTextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.pic = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // txt
            // 
            this.txt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txt.Location = new System.Drawing.Point(254, 392);
            this.txt.Name = "txt";
            this.txt.ReadOnly = true;
            this.txt.Size = new System.Drawing.Size(488, 200);
            this.txt.TabIndex = 3;
            this.txt.Text = "";
            this.txt.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // txt1
            // 
            this.txt1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt1.Font = new System.Drawing.Font("Segoe Script", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txt1.Location = new System.Drawing.Point(219, 339);
            this.txt1.Name = "txt1";
            this.txt1.ReadOnly = true;
            this.txt1.Size = new System.Drawing.Size(551, 47);
            this.txt1.TabIndex = 4;
            this.txt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt1.TextChanged += new System.EventHandler(this.txt1_TextChanged);
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.Transparent;
            this.pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pic.Image = global::App.Properties.Resources.ak47;
            this.pic.Location = new System.Drawing.Point(372, 149);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(260, 184);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic.TabIndex = 1;
            this.pic.TabStop = false;
            this.pic.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::App.Properties.Resources.bg;
            this.button1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(864, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 49);
            this.button1.TabIndex = 5;
            this.button1.Text = "Favourite";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // guns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::App.Properties.Resources.bground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 711);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.pic);
            this.Name = "guns";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поподробнее об оружии";
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.RichTextBox txt;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Button button1;
    }
}