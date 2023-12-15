namespace prolab2
{
    partial class FormBiletBul
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBiletBul));
            listBox3 = new ListBox();
            listBox2 = new ListBox();
            listBox1 = new ListBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 20;
            listBox3.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            listBox3.Location = new Point(638, 40);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(150, 124);
            listBox3.TabIndex = 1;
            listBox3.SelectedIndexChanged += listBox3_SelectedIndexChanged;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 20;
            listBox2.Items.AddRange(new object[] { "İstanbul", "Kocaeli", "Ankara", "Bilecik", "Eskişehir", "Konya" });
            listBox2.Location = new Point(435, 40);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(150, 124);
            listBox2.TabIndex = 4;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Items.AddRange(new object[] { "İstanbul", "Kocaeli", "Ankara", "Bilecik", "Eskişehir", "Konya" });
            listBox1.Location = new Point(232, 40);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150, 124);
            listBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(638, 7);
            label3.Name = "label3";
            label3.Size = new Size(85, 23);
            label3.TabIndex = 2;
            label3.Text = "Kişi Sayısı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(435, 7);
            label2.Name = "label2";
            label2.Size = new Size(68, 23);
            label2.TabIndex = 1;
            label2.Text = "Nereye:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(232, 7);
            label1.Name = "label1";
            label1.Size = new Size(80, 23);
            label1.TabIndex = 0;
            label1.Text = "Nereden:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(280, 182);
            label4.Name = "label4";
            label4.Size = new Size(149, 23);
            label4.TabIndex = 1;
            label4.Text = "Bilet Tarihi Seçiniz:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(435, 179);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(232, 27);
            dateTimePicker1.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(435, 228);
            button1.Name = "button1";
            button1.Size = new Size(135, 57);
            button1.TabIndex = 3;
            button1.Text = "Sefer Bul";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(226, 234);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // FormBiletBul
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 301);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(listBox3);
            Controls.Add(button1);
            Controls.Add(listBox2);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(listBox1);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "FormBiletBul";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lütfen Bilgi Seçiniz";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox listBox2;
        private ListBox listBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        public ListBox listBox3;
        private PictureBox pictureBox1;
    }
}