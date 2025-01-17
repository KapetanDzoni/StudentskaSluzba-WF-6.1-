namespace StudentskaSluzbaWF
{
    partial class Form3
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
            label10 = new Label();
            CBVrstaStudija = new ComboBox();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(356, 130);
            label10.Name = "label10";
            label10.Size = new Size(126, 30);
            label10.TabIndex = 24;
            label10.Text = "Vrsta studija";
            // 
            // CBVrstaStudija
            // 
            CBVrstaStudija.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CBVrstaStudija.FormattingEnabled = true;
            CBVrstaStudija.Items.AddRange(new object[] { "Osnovne akademske studije", "Master studije", "Specijalističke studije", "Doktorske studije" });
            CBVrstaStudija.Location = new Point(99, 129);
            CBVrstaStudija.Name = "CBVrstaStudija";
            CBVrstaStudija.Size = new Size(251, 33);
            CBVrstaStudija.TabIndex = 23;
            // 
            // button2
            // 
            button2.Location = new Point(275, 208);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 26;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(146, 208);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 25;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(146, 49);
            label1.Name = "label1";
            label1.Size = new Size(221, 32);
            label1.TabIndex = 27;
            label1.Text = "Odabir vrste studija";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 325);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label10);
            Controls.Add(CBVrstaStudija);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label10;
        private ComboBox CBVrstaStudija;
        private Button button2;
        private Button button1;
        private Label label1;
    }
}