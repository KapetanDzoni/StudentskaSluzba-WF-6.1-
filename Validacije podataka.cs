using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace StudentskaSluzbaWF
{
    // ovde se nalaze metode koje proveravaju da li su uneseni podaci validni
    internal static class Validacije_podataka
    {
        public static bool ProveraUnosJMBG3(string broj)
        {
            // Provera da li je JMBG null ili prazan
            if (string.IsNullOrWhiteSpace(broj))
            {
                MessageBox.Show("Niste uneli svoj JMBG");
                return false;
            }

            // Provera dužine JMBG-a
            if (broj.Length != 13)
            {
                MessageBox.Show("JMBG nema 13 cifara");
                return false;
            }

            // Provera da li JMBG sadrži samo cifre
            if (!broj.All(char.IsDigit))
            {
                MessageBox.Show("JMBG mora sadržati samo cifre");
                return false;
            }
            if (broj.Equals("1111111111111"))
            {
                MessageBox.Show("Uneti JMBG je kontrolni i nije prihvatljiv");
                return false;
            }

            // Razlikovanje cifara
            int a = int.Parse(broj[0].ToString());
            int b = int.Parse(broj[1].ToString());
            int v = int.Parse(broj[2].ToString());
            int g = int.Parse(broj[3].ToString());
            int d = int.Parse(broj[4].ToString());
            int đ = int.Parse(broj[5].ToString());
            int e = int.Parse(broj[6].ToString());
            int ž = int.Parse(broj[7].ToString());
            int z = int.Parse(broj[8].ToString());
            int i = int.Parse(broj[9].ToString());
            int j = int.Parse(broj[10].ToString());
            int k = int.Parse(broj[11].ToString());
            int l = int.Parse(broj[12].ToString());

            // Provera kontrolne cifre
            int zbir = 7 * (a + e) +
                       6 * (b + ž) +
                       5 * (v + z) +
                       4 * (g + i) +
                       3 * (d + j) +
                       2 * (đ + k);

            int kontrolna = (11 - (zbir % 11)) % 10;

           

            if (l == kontrolna)
            {
                return true;
            }

            MessageBox.Show("Uneti JMBG nije tačan");
            return false;
        }

        public static bool proveraImenaIPrezimena2(string ime)
        {
            if (string.IsNullOrEmpty(ime))
            {
                MessageBox.Show("\nNiste uneli svoje ime i prezime");
                return false;
            }

            string[] deli = ime.Split(' ');


            if (deli.Length < 2)
            {
                MessageBox.Show("\nMorate uneti i ime i prezime ");
                return false;
            }


            string imeStudenta = deli[0];


            if (imeStudenta.Length < 3)
            {       //Duzina imena je :"+ imeStudenta.Length+
                MessageBox.Show("\nIme mora biti sačinjeno od makar 3 slova");
                return false;
            }

            if (char.IsLower(imeStudenta[0]))
            {
                MessageBox.Show("\nIme i prezime se piše velikim slovom");
                return false;

            }


            foreach (char karakter in imeStudenta)
            {
                if (!char.IsLetter(karakter))
                {
                    MessageBox.Show("\nVaše ime mora  sadržati slova, ne prihvatamo brojeve u imenima i prezimenima");
                    MessageBox.Show("Ako u Vasem imenu stoji broj upišite ga rimskim ciframa");

                    return false;
                }
            }






            string prezimeStudenta = deli[1];



            if ((prezimeStudenta.Length <= 2))
            {
                MessageBox.Show("\nPrezime mora biti sačinjeno od makar 3 slova");
                return false;
            }
            if (char.IsLower(prezimeStudenta[0]))
            {
                MessageBox.Show("\nIme i prezime se piše velikim slovom");
                return false;

            }
            foreach (char karakter2 in prezimeStudenta)
            {
                if (!char.IsLetter(karakter2))
                {

                    MessageBox.Show("\nVaše prezime mora sadržati samo slova, ne prihvatamo brojeve u imenima i prezimenima");
                    MessageBox.Show("Ako u Vasem prezimenu stoji broj upišite ga rimskim ciframa");
                    return false;
                }
            }



            return true;
        } // RADI

        public static bool proveraImenaRoditelja(string ime)
        {
            if (string.IsNullOrEmpty(ime))
            {
                MessageBox.Show("\nNiste uneli  ime i prezime roditelja");
                return false;
            }

            string[] deli = ime.Split(' ');


            if (deli.Length < 2)
            {
                MessageBox.Show("\nMorate uneti i ime i prezime roditelja ");
                return false;
            }


            string imeStudenta = deli[0];


            if (imeStudenta.Length < 3)
            {       //Duzina imena je :"+ imeStudenta.Length+
                MessageBox.Show("\nIme mora biti sačinjeno od makar 3 slova");
                return false;
            }

            if (char.IsLower(imeStudenta[0]))
            {
                MessageBox.Show("\nIme i prezime roditelja se piše velikim slovom");
                return false;

            }


            foreach (char karakter in imeStudenta)
            {
                if (!char.IsLetter(karakter))
                {
                    MessageBox.Show("\nVaše ime mora  sadržati slova, ne prihvatamo brojeve u imenima i prezimenima");
                    MessageBox.Show("Ako u Vasem imenu stoji broj upišite ga rimskim ciframa");

                    return false;
                }
            }






            string prezimeStudenta = deli[1];



            if ((prezimeStudenta.Length <= 2))
            {
                MessageBox.Show("\nPrezime roditelja mora biti sačinjeno od makar 3 slova");
                return false;
            }
            if (char.IsLower(prezimeStudenta[0]))
            {
                MessageBox.Show("\nIme i prezime roditelja se piše velikim slovom");
                return false;

            }
            foreach (char karakter2 in prezimeStudenta)
            {
                if (!char.IsLetter(karakter2))
                {

                    MessageBox.Show("\nVaše prezime mora sadržati samo slova, ne prihvatamo brojeve u imenima i prezimenima");
                    MessageBox.Show("Ako u Vasem prezimenu stoji broj upišite ga rimskim ciframa");
                    return false;
                }
            }



            return true;
        } // RADI

        public static bool proveraDatumaRodjenja(string dan, string mesec, string godina)
        {
            string UnetiDatum = dan + mesec + godina;
          
            if (dan == null)
            {
                MessageBox.Show("\nNiste uneli dan svog rodjenja ");
                return false;
            }

            if (mesec == null)
            {
                MessageBox.Show("\nNiste uneli dan svog rodjenja ");
                return false;
            }
            if (godina == null)
            {
                MessageBox.Show("\nNiste uneli dan svog rodjenja ");
                return false;
            }

            DateTime DTdatum;

            if (!DateTime.TryParse(UnetiDatum, out DTdatum)) 
            {
                MessageBox.Show("Uneti datum nije prihvaćen");
                return false;
            }
            return true;

        } // RADI

        public static bool proveraMestaRodjenja(string mesto)
        {
            

            if (mesto==null)
            {
                MessageBox.Show("\nNiste opštinu u kojoj ste rodjeni ");
                return false;

            }
            if (char.IsLower(mesto[0]))
            {
                MessageBox.Show("Mesto rodjenja se piše velikim slovom");
                return false;
            }
            if (mesto.Length==1)
            {
                MessageBox.Show("Ne prihvatamo mesta rodjenja sačinjena od jednog slova");
                return false;
            }

            string[] delovi = mesto.Split(' ');

            for (int i = 0; i < delovi.Length; i++)
            {
                foreach (char c in delovi[i])
                {
                    if (!char.IsLetter(c))
                    {
                        MessageBox.Show("Ne prihvatamo mesta rodjenja koja imaju brojeve u sebi");

                        return false;
                    }
                }
            }

            return true;
        } 
        public static bool proveraDrzavljanstva(string unos)
        {
            //  MessageBox.Show("Umeto" + unos);
            if(unos == null)
            {
                MessageBox.Show("\nNiste uneli svoje državljanstvo ");
                return false;
            }
            if (unos.Length < 3)
            {
                MessageBox.Show("\nPrekratak naziv državljanstva");

                return false;
            }
            foreach (char c in unos)
            {

                if (char.IsNumber(c))
                {
                    string message ="Ne prihvatamo brojeve u državljanstvima";

                    
                    MessageBox.Show(message);
                   // MessageBox.Show(c.ToString());
                    return false;
                }
            }

            return true;
        } //Radi
        public static bool proveraUnosJMBG(string broj)
        {

            if (broj  == null)
            {
                MessageBox.Show("Niste uneli svoj JMBG");
                return false;
            }
            if (broj == "")
            {
                MessageBox.Show("Niste uneli svoj JMBG");
                return false;
            }


            if (broj.ToString().Length != 13)
            {
                MessageBox.Show("\nJMBG nema 13 cifara");
                return false;
            }

            foreach(Char c in broj)
            {
                if (!char.IsNumber(c))
                {
                    MessageBox.Show("\nJMBG mora sadržati samo cifre");
                    return false;
                }
            }
            if (broj.Equals("1111111111111")|| broj.Equals("2222222222222") ||broj.Equals("3333333333333") ||broj.Equals("4444444444444")
                || broj.Equals("5555555555555")|| broj.Equals("6666666666666")||broj.Equals("7777777777777") || broj.Equals("8888888888888") 
                || broj.Equals("9999999999999") )
            {
                MessageBox.Show("Sve cifre JMBGa su iste. Iako ovi brojevi mogu biti validni, nisu prihvatljivi");
                return false;
            }
            

            int a = int.Parse(broj[0].ToString());
            int b = int.Parse(broj[1].ToString());
            int v = int.Parse(broj[2].ToString());
            int g = int.Parse(broj[3].ToString());
            int d = int.Parse(broj[4].ToString());
            int đ = int.Parse(broj[5].ToString());
            int e = int.Parse(broj[6].ToString());
            int ž = int.Parse(broj[7].ToString());
            int z = int.Parse(broj[8].ToString());
            int i = int.Parse(broj[9].ToString());
            int j = int.Parse(broj[10].ToString());
            int k = int.Parse(broj[11].ToString());
            int l = int.Parse(broj[12].ToString());

            

            int kontrolna = 11 - ((7 * (a + e) + 6 * (b + ž) + 5 * (v + z) + 4 * (g + i) + 3 * (d + j) + 2 * (đ + k)) % 11);

            if (l == kontrolna)
            {
                return true;
            }

            MessageBox.Show("\nUneti JMBG nije tačan");
            return false;
        }// Radi

        public static bool ProveraUnosJMBG2(string broj)
        {
            // Provera da li je JMBG null ili prazan
            if (string.IsNullOrWhiteSpace(broj))
            {
                MessageBox.Show("Niste uneli svoj JMBG");
                return false;
            }

            // Provera dužine JMBG-a
            if (broj.Length != 13)
            {
                MessageBox.Show("JMBG nema 13 cifara");
                return false;
            }

            // Provera da li JMBG sadrži samo cifre
            if (!broj.All(char.IsDigit))
            {
                MessageBox.Show("JMBG mora sadržati samo cifre");
                return false;
            }

            // Razlikovanje cifara
            int a = int.Parse(broj[0].ToString());
            int b = int.Parse(broj[1].ToString());
            int v = int.Parse(broj[2].ToString());
            int g = int.Parse(broj[3].ToString());
            int d = int.Parse(broj[4].ToString());
            int đ = int.Parse(broj[5].ToString());
            int e = int.Parse(broj[6].ToString());
            int ž = int.Parse(broj[7].ToString());
            int z = int.Parse(broj[8].ToString());
            int i = int.Parse(broj[9].ToString());
            int j = int.Parse(broj[10].ToString());
            int k = int.Parse(broj[11].ToString());
            int l = int.Parse(broj[12].ToString());

            // Provera datuma rođenja
            int dan = a * 10 + b;
            int mesec = v * 10 + g;
            int godina = d * 100 + đ * 10 + e;

            

           

            // Provera kontrolne cifre
            int kontrolna = (11 - ((7 * (a + e) + 6 * (b + ž) + 5 * (v + z) + 4 * (g + i) + 3 * (d + j) + 2 * (đ + k)) % 11)) % 10;

            if (l == kontrolna)
            {
                return true;
            }

            MessageBox.Show("Uneti JMBG nije tačan");
            return false;
        }

        public static bool proveraVrsteStudija(string vrstaStudija)
        {
            if (vrstaStudija == null || vrstaStudija.Length==-0)
            {
                MessageBox.Show("Molim vas odaberite vrstu studija");
                return false;
            }
            return true;
        }

        
        public static bool proveraDaLiSuSviPodaciStudentaPopunjeni(Student student)
        {
            {

                if (string.IsNullOrEmpty(student.ImeIPrezime) ||
                    string.IsNullOrEmpty(student.ImeRoditelja) ||
                    string.IsNullOrEmpty(student.OpstinaRodjenja) ||
                    string.IsNullOrEmpty(student.DatumRodjenja) ||
                    string.IsNullOrEmpty(student.DrzavaRodjenja) ||
                    string.IsNullOrEmpty(student.Jmbg) ||
                    string.IsNullOrEmpty(student.Drzavljanstvo) ||
                    string.IsNullOrEmpty(student.VrstaStudija) ||
                    string.IsNullOrEmpty(student.Smer) ||
                    string.IsNullOrEmpty(student.BrojIndeksa) ||
                    string.IsNullOrEmpty(student.DatumUpisa)
                    )
                {

                    return false;
                }


                return true;
            }
        }

    
        public static bool proveraFormataIndeksa(string brojIndeksa)
        {
            int trenutnaGodina = DateTime.Now.Year;
            string[] delovi = brojIndeksa.Split('/');
            if (delovi.Length != 2)
            {
                MessageBox.Show("\nIndeks mora biti u odgovarajucem formatu,recimo 0009/2017");
                return false;
            }
            if (!int.TryParse(delovi[0], out var cetvorocifreniBroj) || cetvorocifreniBroj < 0 || cetvorocifreniBroj > 9999)
            {
                MessageBox.Show("\nIndeks mora biti u odgovarajucem formatu,recimo 0009/2017");
                MessageBox.Show("\nPrvi deo mora biti pozitivan četvorocifreni broj");
                return false;
            }
            if (!int.TryParse(delovi[1], out var godina) || godina < 1999 || godina > trenutnaGodina)
            {
                MessageBox.Show("\nIndeks mora biti u odgovarajucem formatu,recimo 0009/2017");
                MessageBox.Show("Godina upisa mora biti izmedju od 1999. i tekuce godine");
                MessageBox.Show("\nTrenutna godina je :" + trenutnaGodina);
                
                return false;
            }
            // Console.WriteLine("Uspešno ste uneli broj indeksa!\nBroj vašeg indeksa je :" + brojIndeksa);
            return true;
        } //RADI

        public static bool daLiJeStudentPronadjen(Student student)
        {
            if (student == null)
            {
                Console.WriteLine("         Nismo pronašli takvog studenta");
                return false;
            }
            else
            {
                Console.WriteLine("\n           Student je pronadjen\n");
            }
            return true;
        }//RADI
        
       

       

        
        
    }
}
