namespace LaptopsGUI
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
            valasztek_lb = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            richTextBox = new RichTextBox();
            listBox2 = new ListBox();
            SuspendLayout();
            // 
            // valasztek_lb
            // 
            valasztek_lb.AutoSize = true;
            valasztek_lb.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            valasztek_lb.Location = new Point(36, 9);
            valasztek_lb.Name = "valasztek_lb";
            valasztek_lb.Size = new Size(0, 25);
            valasztek_lb.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(165, 49);
            label2.Name = "label2";
            label2.Size = new Size(118, 21);
            label2.TabIndex = 1;
            label2.Text = "Konfigurációk";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(541, 49);
            label3.Name = "label3";
            label3.Size = new Size(137, 21);
            label3.TabIndex = 2;
            label3.Text = "Részletes adatok";
            // 
            // button1
            // 
            button1.Location = new Point(496, 373);
            button1.Name = "button1";
            button1.Size = new Size(225, 40);
            button1.TabIndex = 3;
            button1.Text = "Kilépés";
            button1.UseVisualStyleBackColor = true;
            // 
            // richTextBox
            // 
            richTextBox.Location = new Point(470, 79);
            richTextBox.Name = "richTextBox";
            richTextBox.Size = new Size(260, 256);
            richTextBox.TabIndex = 5;
            richTextBox.Text = "";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(23, 79);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(381, 349);
            listBox2.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(listBox2);
            Controls.Add(richTextBox);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(valasztek_lb);
            Name = "Form1";
            Text = "Laptop ajánlat";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label valasztek_lb;
        private Label label2;
        private Label label3;
        private Button button1;
        private ListBox listBox1;
        private RichTextBox richTextBox;
        private ListBox listBox2;
    }
}
