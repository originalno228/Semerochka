﻿
namespace WindowsFormsApp2
{
    partial class Продукты
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Продукты));
            this.button2 = new System.Windows.Forms.Button();
            this.Poisk = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.categorys = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.loginLabel = new System.Windows.Forms.Label();
            this.Button_Eng = new System.Windows.Forms.Button();
            this.Button_Ru = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(317, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 71);
            this.button2.TabIndex = 40;
            this.button2.Text = "Enter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Poisk
            // 
            this.Poisk.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Poisk.Location = new System.Drawing.Point(122, 9);
            this.Poisk.Name = "Poisk";
            this.Poisk.Size = new System.Drawing.Size(167, 34);
            this.Poisk.TabIndex = 39;
            this.Poisk.KeyDown += new System.Windows.Forms.KeyEventHandler(this.poisk_KeyDown);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Cursor = System.Windows.Forms.Cursors.No;
            this.label14.Location = new System.Drawing.Point(5, 9);
            this.label14.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(113, 29);
            this.label14.TabIndex = 38;
            this.label14.Text = "Продукт:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.No;
            this.label6.Location = new System.Drawing.Point(5, 43);
            this.label6.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 29);
            this.label6.TabIndex = 49;
            this.label6.Text = "Бюджет:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // price
            // 
            this.price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.price.Location = new System.Drawing.Point(122, 48);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(167, 34);
            this.price.TabIndex = 50;
            this.price.KeyDown += new System.Windows.Forms.KeyEventHandler(this.poisk_KeyDown);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(3, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 453);
            this.panel1.TabIndex = 51;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-6, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 29);
            this.label1.TabIndex = 52;
            this.label1.Text = "тут время лол";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.No;
            this.label2.Location = new System.Drawing.Point(662, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 29);
            this.label2.TabIndex = 53;
            this.label2.Text = "Проект запущен:";
            // 
            // categorys
            // 
            this.categorys.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.categorys.CheckOnClick = true;
            this.categorys.Cursor = System.Windows.Forms.Cursors.Hand;
            this.categorys.FormattingEnabled = true;
            this.categorys.Items.AddRange(new object[] {
            "Фрукты",
            "Овощи",
            "Фастфуд",
            "Соки"});
            this.categorys.Location = new System.Drawing.Point(856, 109);
            this.categorys.Name = "categorys";
            this.categorys.Size = new System.Drawing.Size(149, 120);
            this.categorys.TabIndex = 55;
            this.categorys.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.categorys_ItemCheck);
            this.categorys.SelectedIndexChanged += new System.EventHandler(this.categorys_SelectedIndexChanged);
            this.categorys.SelectedValueChanged += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.No;
            this.label5.Location = new System.Drawing.Point(851, 77);
            this.label5.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 29);
            this.label5.TabIndex = 56;
            this.label5.Text = "Категория:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(494, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(854, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 74);
            this.button1.TabIndex = 58;
            this.button1.Text = "Войти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // loginLabel
            // 
            this.loginLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(888, 393);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(105, 29);
            this.loginLabel.TabIndex = 59;
            this.loginLabel.Text = "Аноним";
            // 
            // Button_Eng
            // 
            this.Button_Eng.Location = new System.Drawing.Point(4, 46);
            this.Button_Eng.Name = "Button_Eng";
            this.Button_Eng.Size = new System.Drawing.Size(75, 41);
            this.Button_Eng.TabIndex = 62;
            this.Button_Eng.Text = "Eng";
            this.Button_Eng.UseVisualStyleBackColor = true;
            this.Button_Eng.Click += new System.EventHandler(this.Button_Eng_Click_1);
            // 
            // Button_Ru
            // 
            this.Button_Ru.Location = new System.Drawing.Point(85, 46);
            this.Button_Ru.Name = "Button_Ru";
            this.Button_Ru.Size = new System.Drawing.Size(75, 41);
            this.Button_Ru.TabIndex = 63;
            this.Button_Ru.Text = "Ru";
            this.Button_Ru.UseVisualStyleBackColor = true;
            this.Button_Ru.Click += new System.EventHandler(this.Button_Ru_Click_1);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.Color.Aquamarine;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.Button_Ru);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Button_Eng);
            this.panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel2.Location = new System.Drawing.Point(844, 420);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(175, 121);
            this.panel2.TabIndex = 64;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(168, 37);
            this.button3.TabIndex = 65;
            this.button3.Text = "Интерфейс";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Продукты
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 546);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.categorys);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.price);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Poisk);
            this.Controls.Add(this.label14);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Продукты";
            this.Text = "Семерочка";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Продукты_FormClosing);
            this.Resize += new System.EventHandler(this.button2_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox Poisk;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox categorys;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Button Button_Eng;
        private System.Windows.Forms.Button Button_Ru;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button button3;
    }
}