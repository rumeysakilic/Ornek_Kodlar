namespace HesappMakinesi
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
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            Topla = new Button();
            Çıkar = new Button();
            button3 = new Button();
            button4 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(46, 36);
            label1.Name = "label1";
            label1.Size = new Size(71, 30);
            label1.TabIndex = 0;
            label1.Text = "Sayı 1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(46, 101);
            label2.Name = "label2";
            label2.Size = new Size(71, 30);
            label2.TabIndex = 1;
            label2.Text = "Sayı 2";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(148, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(148, 108);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            // 
            // Topla
            // 
            Topla.Location = new Point(12, 168);
            Topla.Name = "Topla";
            Topla.Size = new Size(75, 70);
            Topla.TabIndex = 4;
            Topla.Text = "Topla";
            Topla.UseVisualStyleBackColor = true;
            Topla.Click += Topla_Click;
            // 
            // Çıkar
            // 
            Çıkar.Location = new Point(93, 168);
            Çıkar.Name = "Çıkar";
            Çıkar.Size = new Size(75, 70);
            Çıkar.TabIndex = 5;
            Çıkar.Text = "Çıkar";
            Çıkar.UseVisualStyleBackColor = true;
            Çıkar.Click += Çıkar_Click;
            // 
            // button3
            // 
            button3.Location = new Point(174, 168);
            button3.Name = "button3";
            button3.Size = new Size(75, 70);
            button3.TabIndex = 6;
            button3.Text = "Çarp";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(255, 168);
            button4.Name = "button4";
            button4.Size = new Size(75, 70);
            button4.TabIndex = 7;
            button4.Text = "Böl";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(481, 56);
            label3.Name = "label3";
            label3.Size = new Size(150, 50);
            label3.TabIndex = 8;
            label3.Text = "SONUÇ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(Çıkar);
            Controls.Add(Topla);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Hesap Makinesi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button Topla;
        private Button Çıkar;
        private Button button3;
        private Button button4;
        private Label label3;
    }
}