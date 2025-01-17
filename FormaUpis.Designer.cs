namespace StudentskaSluzbaWF
{
    partial class FormaUpis
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
            label1 = new Label();
            TBImePrezime = new TextBox();
            label2 = new Label();
            label3 = new Label();
            TBImeRoditelja = new TextBox();
            label4 = new Label();
            TBOpstinaRodjenja = new TextBox();
            label5 = new Label();
            label6 = new Label();
            TBDrzavljanstvo = new TextBox();
            label7 = new Label();
            label9 = new Label();
            TBJMBG = new TextBox();
            button1 = new Button();
            button2 = new Button();
            CBDrzava = new ComboBox();
            label8 = new Label();
            CBDan = new ComboBox();
            CBMesec = new ComboBox();
            CBGodina = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(126, 9);
            label1.Name = "label1";
            label1.Size = new Size(222, 32);
            label1.TabIndex = 0;
            label1.Text = "Dobrodošli na upis!";
            // 
            // TBImePrezime
            // 
            TBImePrezime.Font = new Font("Microsoft Sans Serif", 14.25F);
            TBImePrezime.Location = new Point(31, 106);
            TBImePrezime.Name = "TBImePrezime";
            TBImePrezime.Size = new Size(212, 29);
            TBImePrezime.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F);
            label2.Location = new Point(249, 108);
            label2.Name = "label2";
            label2.Size = new Size(126, 25);
            label2.TabIndex = 2;
            label2.Text = "lme i prezime";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F);
            label3.Location = new Point(249, 147);
            label3.Name = "label3";
            label3.Size = new Size(201, 25);
            label3.TabIndex = 4;
            label3.Text = "lme i prezime roditelja";
            // 
            // TBImeRoditelja
            // 
            TBImeRoditelja.Font = new Font("Microsoft Sans Serif", 14.25F);
            TBImeRoditelja.Location = new Point(31, 145);
            TBImeRoditelja.Name = "TBImeRoditelja";
            TBImeRoditelja.Size = new Size(212, 29);
            TBImeRoditelja.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F);
            label4.Location = new Point(249, 258);
            label4.Name = "label4";
            label4.Size = new Size(152, 25);
            label4.TabIndex = 8;
            label4.Text = "Opština rodjenja";
            // 
            // TBOpstinaRodjenja
            // 
            TBOpstinaRodjenja.Font = new Font("Microsoft Sans Serif", 14.25F);
            TBOpstinaRodjenja.Location = new Point(31, 256);
            TBOpstinaRodjenja.Name = "TBOpstinaRodjenja";
            TBOpstinaRodjenja.Size = new Size(212, 29);
            TBOpstinaRodjenja.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F);
            label5.Location = new Point(249, 182);
            label5.Name = "label5";
            label5.Size = new Size(143, 25);
            label5.TabIndex = 6;
            label5.Text = "Datum rodjenja";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F);
            label6.Location = new Point(249, 293);
            label6.Name = "label6";
            label6.Size = new Size(125, 25);
            label6.TabIndex = 12;
            label6.Text = "Državljanstvo";
            // 
            // TBDrzavljanstvo
            // 
            TBDrzavljanstvo.Font = new Font("Microsoft Sans Serif", 14.25F);
            TBDrzavljanstvo.Location = new Point(31, 291);
            TBDrzavljanstvo.Name = "TBDrzavljanstvo";
            TBDrzavljanstvo.Size = new Size(212, 29);
            TBDrzavljanstvo.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F);
            label7.Location = new Point(249, 220);
            label7.Name = "label7";
            label7.Size = new Size(145, 25);
            label7.TabIndex = 10;
            label7.Text = "Država rodjenja";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F);
            label9.Location = new Point(249, 328);
            label9.Name = "label9";
            label9.Size = new Size(60, 25);
            label9.TabIndex = 14;
            label9.Text = "JMBG";
            // 
            // TBJMBG
            // 
            TBJMBG.Font = new Font("Microsoft Sans Serif", 14.25F);
            TBJMBG.Location = new Point(31, 326);
            TBJMBG.Name = "TBJMBG";
            TBJMBG.Size = new Size(212, 29);
            TBJMBG.TabIndex = 13;
            // 
            // button1
            // 
            button1.Location = new Point(126, 407);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 17;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(293, 407);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 18;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // CBDrzava
            // 
            CBDrzava.DropDownStyle = ComboBoxStyle.DropDownList;
            CBDrzava.Font = new Font("Microsoft Sans Serif", 14.25F);
            CBDrzava.FormattingEnabled = true;
            CBDrzava.Items.AddRange(new object[] { "Afganistan", "Albanija", "Alžir", "Andora", "Angola", "Antigva i Barbuda", "Argentina", "Armenija", "Australija", "Austrija", "Azerbejdžan", "Bahami", "Bahrein", "Bangladeš", "Barbados", "Belgija", "Beliz", "Belorusija", "Benin", "Bocvana", "Bolivija", "Bosna i Hercegovina", "Brazil", "Brunej", "Bugarska", "Burkina Faso", "Burundi", "Crna Gora", "Centralnoafrička Republika", "Čad", "Češka", "Čile", "Danska", "Dominika", "Dominikanska Republika", "Džibuti", "Egipat", "Ekvador", "Ekvatorska Gvineja", "Eritreja", "Estonija", "Esvatini", "Etiopija", "Fidži", "Filipini", "Finska", "Francuska", "Gabon", "Gambija", "Gana", "Grčka", "Grenada", "Gruzija", "Gvajana", "Gvatemala", "Gvineja", "Gvinej Bisao", "Haiti", "Holandija", "Honduras", "Hrvatska", "Indija", "Indonezija", "Irak", "Iran", "Irska", "Island", "Italija", "Istočni Timor", "Izrael", "Jamajka", "Japan", "Jemen", "Jordan", "Jugoslavija", "Južna Koreja", "Južni Sudan", "Južnoafrička Republika", "Kambodža", "Kamerun", "Kanada", "Katar", "Kazahstan", "Kenija", "Kirgistan", "Kiribati", "Kolumbija", "Komori", "Kongo", "Kostarika", "Kuba", "Kuvajt", "Laos", "Lesoto", "Letonija", "Liban", "Liberija", "Libija", "Lihtenštajn", "Litvanija", "Luksemburg", "Madagaskar", "Mađarska", "Makedonija", "Malavi", "Maldivi", "Malezija", "Mali", "Malta", "Maroko", "Maršalska Ostrva", "Mauricijus", "Mauritanija", "Meksik", "Mianmar", "Mikronezija", "Moldavija", "Monako", "Mongolija", "Mozambik", "Namibija", "Nauru", "Nemačka", "Nepal", "Niger", "Nigerija", "Nikaragva", "Niue", "Norveška", "Nova Gvineja", "Novi Zeland", "Obala Slonovače", "Oman", "Pakistan", "Palau", "Panam", "Papua Nova Gvineja", "Paragvaj", "Peru", "Poljska", "Portugal", "Ruanda", "Rumunija", "Rusija", "Sait Kitts i Nevis", "Saint Lucia", "Saint Vincent i Grenadini", "Salvador", "Samoa", "San Marino", "Sao Tome i Principe", "Saudijska Arabija", "Sejšeli", "Senegal", "Severna Koreja", "Severna Makedonija", "Sijera Leone", "Singapur", "Sirija", "Sjedinjene Američke Države", "Slovačka", "Slovenija", "Solomonova Ostrva", "Somalija", "Srbija", "Srednjoafrička Republika", "Sudan", "Surinam", "Svazilend", "Savezna Federativna Republika Jugoslavija", "Španija", "Šri Lanka", "Švedska", "Švajcarska", "Tadžikistan", "Tajland", "Tanzanija", "Tog", "Tonga", "Trinidad i Tobago", "Tunis", "Turkmenistan", "Turska", "Tuvalu", "Uganda", "Ujedinjeni Arapski Emirati", "Ukrajina", "Urugvaj", "Uzbekistan", "Vanuatu", "Vatikan", "Venecuela", "Velika Britanija", "Vijetnam", "Zambija", "Zimbabve", "Crna Gora", "Jugoslavija", "Palestina", "Sovjetski Savez", "Čehoslovačka", "Zair", "Zapadna Nemačka", "Istočna Nemačka", "Rodezija", "Republika Kongo", "Sijera Leone", "Tanganjika" });
            CBDrzava.Location = new Point(31, 218);
            CBDrzava.Name = "CBDrzava";
            CBDrzava.Size = new Size(212, 32);
            CBDrzava.TabIndex = 19;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(75, 62);
            label8.Name = "label8";
            label8.Size = new Size(331, 25);
            label8.TabIndex = 24;
            label8.Text = "Molimo vas da popunite vaše podatke";
            // 
            // CBDan
            // 
            CBDan.DropDownStyle = ComboBoxStyle.DropDownList;
            CBDan.Font = new Font("Microsoft Sans Serif", 14.25F);
            CBDan.FormattingEnabled = true;
            CBDan.Items.AddRange(new object[] { "1.", "2.", "3.", "4.", "5.", "6.", "7.", "8.", "9.", "10.", "11.", "12.", "13.", "14.", "15.", "16.", "17.", "18.", "19.", "20.", "21.", "22.", "23.", "24.", "25.", "26.", "27.", "28.", "29.", "30.", "31." });
            CBDan.Location = new Point(31, 180);
            CBDan.Name = "CBDan";
            CBDan.Size = new Size(59, 32);
            CBDan.TabIndex = 26;
            // 
            // CBMesec
            // 
            CBMesec.DropDownStyle = ComboBoxStyle.DropDownList;
            CBMesec.Font = new Font("Microsoft Sans Serif", 14.25F);
            CBMesec.FormattingEnabled = true;
            CBMesec.Items.AddRange(new object[] { "1.", "2.", "3.", "4.", "5.", "6.", "7.", "8.", "9.", "10.", "11.", "12." });
            CBMesec.Location = new Point(96, 180);
            CBMesec.Name = "CBMesec";
            CBMesec.Size = new Size(61, 32);
            CBMesec.TabIndex = 27;
            // 
            // CBGodina
            // 
            CBGodina.DropDownStyle = ComboBoxStyle.DropDownList;
            CBGodina.Font = new Font("Microsoft Sans Serif", 14.25F);
            CBGodina.FormattingEnabled = true;
            CBGodina.Items.AddRange(new object[] { "2005.", "2004.", "2003.", "2002.", "2001.", "2000.", "1999.", "1998.", "1997.", "1996.", "1995.", "1994.", "1993.", "1992.", "1991.", "1990.", "1989.", "1988.", "1987.", "1986.", "1985.", "1984.", "1983.", "1982.", "1981.", "1980.", "1979.", "1978.", "1977.", "1976.", "1975.", "1974.", "1973.", "1972.", "1971.", "1970.", "1969.", "1968.", "1967.", "1966.", "1965.", "1964.", "1963.", "1962.", "1961.", "1960.", "1959.", "1958.", "1957.", "1956.", "1955.", "1954.", "1953.", "1952.", "1951.", "1950.", "1949.", "1948.", "1947.", "1946.", "1945.", "1944." });
            CBGodina.Location = new Point(163, 180);
            CBGodina.Name = "CBGodina";
            CBGodina.Size = new Size(80, 32);
            CBGodina.TabIndex = 28;
            // 
            // FormaUpis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 476);
            Controls.Add(CBGodina);
            Controls.Add(CBMesec);
            Controls.Add(CBDan);
            Controls.Add(label8);
            Controls.Add(CBDrzava);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label9);
            Controls.Add(TBJMBG);
            Controls.Add(label6);
            Controls.Add(TBDrzavljanstvo);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(TBOpstinaRodjenja);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(TBImeRoditelja);
            Controls.Add(label2);
            Controls.Add(TBImePrezime);
            Controls.Add(label1);
            Location = new Point(130, 231);
            Name = "FormaUpis";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox TBImePrezime;
        private Label label2;
        private Label label3;
        private TextBox TBImeRoditelja;
        private Label label4;
        private TextBox TBOpstinaRodjenja;
        private Label label5;
        private Label label6;
        private TextBox TBDrzavljanstvo;
        private Label label7;
        private Label label9;
        private TextBox TBJMBG;
        private Button button1;
        private Button button2;
        private ComboBox CBDrzava;
        private Label label8;
        private ComboBox CBDan;
        private ComboBox CBMesec;
        private ComboBox CBGodina;
    }
}