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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add));
            this.save = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.yearB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.prsvar = new System.Windows.Forms.ComboBox();
            this.img = new System.Windows.Forms.Button();
            this.pi = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.calibr = new System.Windows.Forms.ComboBox();
            this.describe = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.var = new System.Windows.Forms.ComboBox();
            this.back = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
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
            this.name.Location = new System.Drawing.Point(110, 44);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 20);
            this.name.TabIndex = 1;
            // 
            // yearB
            // 
            this.yearB.Location = new System.Drawing.Point(110, 115);
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
            this.label1.Location = new System.Drawing.Point(14, 47);
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
            this.label2.Location = new System.Drawing.Point(14, 82);
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
            this.label3.Location = new System.Drawing.Point(14, 118);
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
            this.label4.Location = new System.Drawing.Point(15, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Тип:";
            // 
            // prsvar
            // 
            this.prsvar.FormattingEnabled = true;
            this.prsvar.Items.AddRange(new object[] {
            "10000",
            "20000",
            "30000",
            "40000",
            "50000",
            "60000",
            "70000",
            "80000"});
            this.prsvar.Location = new System.Drawing.Point(110, 193);
            this.prsvar.Name = "prsvar";
            this.prsvar.Size = new System.Drawing.Size(98, 21);
            this.prsvar.TabIndex = 6;
            this.prsvar.SelectedIndexChanged += new System.EventHandler(this.prsvar_SelectedIndexChanged);
            // 
            // img
            // 
            this.img.BackgroundImage = global::App.Properties.Resources.bg;
            this.img.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold);
            this.img.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.img.Location = new System.Drawing.Point(232, 70);
            this.img.Name = "img";
            this.img.Size = new System.Drawing.Size(165, 44);
            this.img.TabIndex = 7;
            this.img.Text = "Изображениие";
            this.img.UseVisualStyleBackColor = true;
            this.img.Click += new System.EventHandler(this.img_Click);
            // 
            // pi
            // 
            this.pi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pi.InitialImage = null;
            this.pi.Location = new System.Drawing.Point(232, 120);
            this.pi.Name = "pi";
            this.pi.Size = new System.Drawing.Size(165, 93);
            this.pi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pi.TabIndex = 8;
            this.pi.TabStop = false;
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
            this.calibr.Location = new System.Drawing.Point(110, 79);
            this.calibr.Name = "calibr";
            this.calibr.Size = new System.Drawing.Size(100, 21);
            this.calibr.TabIndex = 9;
            // 
            // describe
            // 
            this.describe.Location = new System.Drawing.Point(111, 234);
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
            this.label5.Location = new System.Drawing.Point(18, 265);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Описание:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(15, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Цена:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // var
            // 
            this.var.FormattingEnabled = true;
            this.var.Items.AddRange(new object[] {
            "Автомат",
            "Пистолет"});
            this.var.Location = new System.Drawing.Point(110, 154);
            this.var.Name = "var";
            this.var.Size = new System.Drawing.Size(98, 21);
            this.var.TabIndex = 6;
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.Image = global::App.Properties.Resources.back;
            this.back.Location = new System.Drawing.Point(364, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(49, 47);
            this.back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.back.TabIndex = 12;
            this.back.TabStop = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::App.Properties.Resources.bground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(421, 451);
            this.Controls.Add(this.back);
            this.Controls.Add(this.describe);
            this.Controls.Add(this.calibr);
            this.Controls.Add(this.pi);
            this.Controls.Add(this.img);
            this.Controls.Add(this.var);
            this.Controls.Add(this.prsvar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yearB);
            this.Controls.Add(this.name);
            this.Controls.Add(this.save);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(437, 490);
            this.MinimumSize = new System.Drawing.Size(437, 490);
            this.Name = "Add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить оружие";
            ((System.ComponentModel.ISupportInitialize)(this.pi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
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
        private System.Windows.Forms.ComboBox prsvar;
        private System.Windows.Forms.Button img;
        private System.Windows.Forms.PictureBox pi;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox calibr;
        private System.Windows.Forms.RichTextBox describe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox var;
        private System.Windows.Forms.PictureBox back;
    }
}