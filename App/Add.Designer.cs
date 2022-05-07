namespace App
{
    partial class Add
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
            this.save = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.yearB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.var = new System.Windows.Forms.ComboBox();
            this.img = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.calibr = new System.Windows.Forms.ComboBox();
            this.describe = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // save
            // 
            this.save.BackgroundImage = global::App.Properties.Resources.bg;
            this.save.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Bold);
            this.save.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.save.Location = new System.Drawing.Point(62, 389);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(313, 49);
            this.save.TabIndex = 0;
            this.save.Text = "Применить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(110, 33);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 1;
            // 
            // yearB
            // 
            this.yearB.Location = new System.Drawing.Point(110, 104);
            this.yearB.Name = "yearB";
            this.yearB.Size = new System.Drawing.Size(98, 20);
            this.yearB.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(14, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Название:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(14, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Калибр:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(14, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Год выпуска:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(15, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Тип:";
            // 
            // var
            // 
            this.var.FormattingEnabled = true;
            this.var.Items.AddRange(new object[] {
            "Автомат",
            "Пистолет"});
            this.var.Location = new System.Drawing.Point(111, 142);
            this.var.Name = "var";
            this.var.Size = new System.Drawing.Size(98, 21);
            this.var.TabIndex = 6;
            // 
            // img
            // 
            this.img.BackgroundImage = global::App.Properties.Resources.bg;
            this.img.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.img.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.img.Location = new System.Drawing.Point(232, 28);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(165, 44);
            this.img.TabIndex = 7;
            this.img.Text = "Изображениие";
            this.img.UseVisualStyleBackColor = true;
            this.img.Click += new System.EventHandler(this.img_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(232, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // calibr
            // 
            this.calibr.FormattingEnabled = true;
            this.calibr.Items.AddRange(new object[] {
            "5",
            "7"});
            this.calibr.Location = new System.Drawing.Point(110, 68);
            this.calibr.Name = "calibr";
            this.calibr.Size = new System.Drawing.Size(100, 21);
            this.calibr.TabIndex = 9;
            // 
            // describe
            // 
            this.describe.Location = new System.Drawing.Point(111, 193);
            this.describe.Name = "describe";
            this.describe.Size = new System.Drawing.Size(286, 96);
            this.describe.TabIndex = 10;
            this.describe.Text = "";
            this.describe.TextChanged += new System.EventHandler(this.describe_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(18, 224);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Описание:";
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::App.Properties.Resources.bground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(431, 450);
            this.Controls.Add(this.describe);
            this.Controls.Add(this.calibr);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.img);
            this.Controls.Add(this.var);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yearB);
            this.Controls.Add(this.name);
            this.Controls.Add(this.save);
            this.Name = "Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button save;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox yearB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox var;
        private System.Windows.Forms.Button img;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox calibr;
        private System.Windows.Forms.RichTextBox describe;
        private System.Windows.Forms.Label label5;
    }
}