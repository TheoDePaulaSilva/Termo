namespace Termo
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
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            richTextBox3 = new RichTextBox();
            richTextBox4 = new RichTextBox();
            richTextBox5 = new RichTextBox();
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(334, 12);
            richTextBox1.Multiline = false;
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(128, 53);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // richTextBox2
            // 
            richTextBox2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox2.Location = new Point(334, 71);
            richTextBox2.Multiline = false;
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(128, 53);
            richTextBox2.TabIndex = 1;
            richTextBox2.Text = "";
            // 
            // richTextBox3
            // 
            richTextBox3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox3.Location = new Point(334, 130);
            richTextBox3.Multiline = false;
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(128, 53);
            richTextBox3.TabIndex = 2;
            richTextBox3.Text = "";
            // 
            // richTextBox4
            // 
            richTextBox4.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox4.Location = new Point(334, 189);
            richTextBox4.Multiline = false;
            richTextBox4.Name = "richTextBox4";
            richTextBox4.Size = new Size(128, 53);
            richTextBox4.TabIndex = 3;
            richTextBox4.Text = "";
            // 
            // richTextBox5
            // 
            richTextBox5.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richTextBox5.Location = new Point(334, 248);
            richTextBox5.Multiline = false;
            richTextBox5.Name = "richTextBox5";
            richTextBox5.Size = new Size(128, 53);
            richTextBox5.TabIndex = 4;
            richTextBox5.Text = "";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(334, 352);
            button1.Name = "button1";
            button1.Size = new Size(128, 59);
            button1.TabIndex = 5;
            button1.Text = "Testar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 304);
            label1.Name = "label1";
            label1.Size = new Size(155, 45);
            label1.TabIndex = 6;
            label1.Text = "               ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(richTextBox5);
            Controls.Add(richTextBox4);
            Controls.Add(richTextBox3);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private RichTextBox richTextBox3;
        private RichTextBox richTextBox4;
        private RichTextBox richTextBox5;
        private Button button1;
        private Label label1;
    }
}
