namespace App
{
    partial class filter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(filter));
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.p2 = new System.Windows.Forms.PictureBox();
            this.p1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.p3 = new System.Windows.Forms.PictureBox();
            this.filtr = new System.Windows.Forms.Button();
            this.choice = new System.Windows.Forms.ComboBox();
            this.choiceCal = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.choiceYear = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pan = new System.Windows.Forms.Panel();
            this.back = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.p2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 0;
            // 
            // p2
            // 
            this.p2.Location = new System.Drawing.Point(0, 0);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(100, 50);
            this.p2.TabIndex = 0;
            this.p2.TabStop = false;
            // 
            // p1
            // 
            this.p1.Location = new System.Drawing.Point(0, 0);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(100, 50);
            this.p1.TabIndex = 0;
            this.p1.TabStop = false;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 0;
            // 
            // p3
            // 
            this.p3.Location = new System.Drawing.Point(0, 0);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(100, 50);
            this.p3.TabIndex = 0;
            this.p3.TabStop = false;
            // 
            // filtr
            // 
            this.filtr.BackgroundImage = global::App.Properties.Resources.bg;
            this.filtr.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.filtr.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.filtr.Location = new System.Drawing.Point(819, 556);
            this.filtr.Name = "filtr";
            this.filtr.Size = new System.Drawing.Size(121, 52);
            this.filtr.TabIndex = 23;
            this.filtr.Text = "Отфильтровать";
            this.filtr.UseVisualStyleBackColor = true;
            this.filtr.Click += new System.EventHandler(this.filtr_Click);
            // 
            // choice
            // 
            this.choice.AutoCompleteCustomSource.AddRange(new string[] {
            "INSAS",
            "ads",
            "Застава"});
            this.choice.FormattingEnabled = true;
            this.choice.Items.AddRange(new object[] {
            "nothing",
            "10000",
            "20000",
            "30000",
            "40000",
            "50000",
            "70000"});
            this.choice.Location = new System.Drawing.Point(819, 495);
            this.choice.Name = "choice";
            this.choice.Size = new System.Drawing.Size(121, 21);
            this.choice.TabIndex = 24;
            this.choice.Text = "nothing";
            this.choice.SelectedIndexChanged += new System.EventHandler(this.choice_SelectedIndexChanged);
            // 
            // choiceCal
            // 
            this.choiceCal.AutoCompleteCustomSource.AddRange(new string[] {
            "5",
            "7"});
            this.choiceCal.ForeColor = System.Drawing.SystemColors.WindowText;
            this.choiceCal.FormattingEnabled = true;
            this.choiceCal.Items.AddRange(new object[] {
            "nothing",
            "7.62",
            "5.56",
            "5.45"});
            this.choiceCal.Location = new System.Drawing.Point(819, 459);
            this.choiceCal.Name = "choiceCal";
            this.choiceCal.Size = new System.Drawing.Size(121, 21);
            this.choiceCal.TabIndex = 25;
            this.choiceCal.Text = "nothing";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(758, 459);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "Калибр:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(770, 495);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 18);
            this.label2.TabIndex = 26;
            this.label2.Text = "Цена:";
            // 
            // choiceYear
            // 
            this.choiceYear.Items.AddRange(new object[] {
            "nothing",
            "1962",
            "1966",
            "1987",
            "1990",
            "2004",
            "2005",
            "2007"});
            this.choiceYear.Location = new System.Drawing.Point(819, 529);
            this.choiceYear.Name = "choiceYear";
            this.choiceYear.Size = new System.Drawing.Size(121, 21);
            this.choiceYear.TabIndex = 27;
            this.choiceYear.Text = "nothing";
            this.choiceYear.SelectedIndexChanged += new System.EventHandler(this.choiceYear_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(785, 529);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 18);
            this.label3.TabIndex = 26;
            this.label3.Text = "Год:";
            // 
            // pan
            // 
            this.pan.AutoScroll = true;
            this.pan.BackColor = System.Drawing.Color.Transparent;
            this.pan.Location = new System.Drawing.Point(-1, -1);
            this.pan.Name = "pan";
            this.pan.Size = new System.Drawing.Size(985, 454);
            this.pan.TabIndex = 28;
            this.pan.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.Image = global::App.Properties.Resources.back;
            this.back.Location = new System.Drawing.Point(12, 652);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(49, 47);
            this.back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.back.TabIndex = 29;
            this.back.TabStop = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // filter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::App.Properties.Resources.bground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 711);
            this.Controls.Add(this.back);
            this.Controls.Add(this.pan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.choiceCal);
            this.Controls.Add(this.choiceYear);
            this.Controls.Add(this.choice);
            this.Controls.Add(this.filtr);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1000, 750);
            this.MinimumSize = new System.Drawing.Size(1000, 750);
            this.Name = "filter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Фильтр";
            this.Load += new System.EventHandler(this.filter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.p2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox p2;
        private System.Windows.Forms.PictureBox p1;
        private System.Windows.Forms.PictureBox p3;
        private System.Windows.Forms.Button filtr;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox choice;
        private System.Windows.Forms.ComboBox choiceCal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox choiceYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pan;
        private System.Windows.Forms.PictureBox back;
    }
}