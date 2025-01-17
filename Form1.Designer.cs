namespace StudentskaSluzbaWF
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
            button1 = new Button();
            label1 = new Label();
            button3 = new Button();
            comboBox1 = new ComboBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.AutoSize = true;
            button1.Location = new Point(130, 231);
            button1.Name = "button1";
            button1.Size = new Size(150, 36);
            button1.TabIndex = 0;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(130, 51);
            label1.Name = "label1";
            label1.Size = new Size(352, 32);
            label1.TabIndex = 1;
            label1.Text = "Dobrodošli u studentsku službu";
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button3.AutoSize = true;
            button3.Location = new Point(299, 231);
            button3.Name = "button3";
            button3.Size = new Size(195, 36);
            button3.TabIndex = 4;
            button3.Text = "Izadji iz programa";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.ItemHeight = 25;
            comboBox1.Items.AddRange(new object[] { "Želim da se upišem na fakultet", "Imena i indeksi upisanih studenata", "Promena podataka upisanog studenta", "Želim da vidim sve podatke upisanog studenta", "Lista ispita po smerovima", "Želim da odaberem predmete za slušanje", "Želim da polažem ispit", "Želim da upišem višu godinu", "Želim da se ispišem sa fakulteta", "Želim da napustim program" });
            comboBox1.Location = new Point(43, 146);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(405, 33);
            comboBox1.TabIndex = 14;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(454, 143);
            label2.Name = "label2";
            label2.Size = new Size(123, 36);
            label2.TabIndex = 15;
            label2.Text = "Izvolite?";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(599, 385);
            Controls.Add(comboBox1);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(label2);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StudentskaSluzbaWF6._1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Button button3;
        public ComboBox comboBox1;
        private Label label2;
    }
}
