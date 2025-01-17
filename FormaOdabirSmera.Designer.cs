namespace StudentskaSluzbaWF6._1
{
    partial class FormaOdabirSmera
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
            label11 = new Label();
            CBSmer = new ComboBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(369, 127);
            label11.Name = "label11";
            label11.Size = new Size(60, 30);
            label11.TabIndex = 25;
            label11.Text = "Smer";
            // 
            // CBSmer
            // 
            CBSmer.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CBSmer.FormattingEnabled = true;
            CBSmer.Items.AddRange(new object[] { "Informacioni sistemi i tehnologije", "Menadžment", "Operacioni menadžment", "Menadžment kvaliteta i standardizacija" });
            CBSmer.Location = new Point(12, 127);
            CBSmer.Name = "CBSmer";
            CBSmer.Size = new Size(351, 33);
            CBSmer.TabIndex = 24;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(130, 30);
            label1.Name = "label1";
            label1.Size = new Size(179, 32);
            label1.TabIndex = 26;
            label1.Text = "Odaberite smer";
            // 
            // button1
            // 
            button1.Location = new Point(108, 215);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 27;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(251, 215);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 28;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // FormaOdabirSmera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 283);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(label11);
            Controls.Add(CBSmer);
            Name = "FormaOdabirSmera";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label11;
        private ComboBox CBSmer;
        private Label label1;
        private Button button1;
        private Button button2;
    }
}