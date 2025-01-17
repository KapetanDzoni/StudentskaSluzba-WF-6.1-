using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Channels;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;



namespace StudentskaSluzbaWF
{
    internal static class Fajl_metoda_koje_rade_sa_studentom
    {

        public static string bazaIspitaISIT = "bazaIspitaISIT.xml";
        public static string lokacijaBazeIspitaISIT = Path.Combine(Directory.GetCurrentDirectory(), bazaIspitaISIT);

        public static List<Ispit> listaIspitaIsit = UpisIIspisIzBaze.ucitajBazuIspita(lokacijaBazeIspitaISIT);





        public static string bazaIspitaMenadzment = "bazaIspitaMenadzment.xml";
        public static string lokacijaBazeIspitaMenadzment = Path.Combine(Directory.GetCurrentDirectory(), bazaIspitaMenadzment);

        public static List<Ispit> listaIspitaMenadzment = UpisIIspisIzBaze.ucitajBazuIspita(lokacijaBazeIspitaMenadzment);





        public static string bazaIspitaOperacioniMenadzment = "bazaIspitaOperacioniMenadzment.xml";
        public static string lokacijaBazeIspitaOperacioniMenadzment = Path.Combine(Directory.GetCurrentDirectory(), bazaIspitaOperacioniMenadzment);

        public static List<Ispit> listaIspitaOperacioniMenadzment = UpisIIspisIzBaze.ucitajBazuIspita(lokacijaBazeIspitaOperacioniMenadzment);

        public static string bazaIspitaMenadzmentKvaliteta = "bazaIspitaMenadzmentKvaliteta.xml";
        public static string lokacijaBazeIspitaMenadzmentKvaliteta = Path.Combine(Directory.GetCurrentDirectory(), bazaIspitaMenadzmentKvaliteta);

        public static List<Ispit> listaIspitaMenadzmentKvaliteta = UpisIIspisIzBaze.ucitajBazuIspita(lokacijaBazeIspitaMenadzmentKvaliteta);



        static string nazivBazeStudenata = "bazaStudenata.xml";
        public static string lokacijaBazeStudenata = Path.Combine(Directory.GetCurrentDirectory(), nazivBazeStudenata);


        public static List<Student> listaUpisanihStudenata = UpisIIspisIzBaze.ucitajBazuStudenata(lokacijaBazeStudenata);


        public static bool upisiStudenta(Student s)
        {

            if (Validacije_podataka.proveraDaLiSuSviPodaciStudentaPopunjeni(s))
            {

                listaUpisanihStudenata.Add(s);
                UpisIIspisIzBaze.sacuvajUBazuStudenata(listaUpisanihStudenata, lokacijaBazeStudenata);
                listaUpisanihStudenata = UpisIIspisIzBaze.ucitajBazuStudenata(lokacijaBazeStudenata);
                MessageBox.Show("Čestitamo na upisu!");
                return true;
            }
            return false;
        }

        public static bool daLiJeStudentVecPolozioIspit(Student s, Ispit i)
        {
            foreach (PolozeniIspit p in s.listaPolozenihIspita)
            {
                if (p.Ispit.Naziv.Equals(i.Naziv))
                {
                    return true;
                }
            }
            return false;

        }

        public static string izracunajProsekStudenta(Student s)
        {

            int brojac = 0;
            int zbir = 0;
            double rezultat;
            foreach (PolozeniIspit PI in s.listaPolozenihIspita)
            {
                if (PI.Ocena > 5)
                {
                    zbir += PI.Ocena;
                    brojac++;
                }

            }
            if (brojac > 0)
            {

                rezultat = (double)zbir / brojac;
                return Math.Round(rezultat, 2).ToString();

            }

            return "Nema položenih ispita";

        }

        public static int daLiStudentIspunjavaUslovZaUpisViseGodine(Student s)
        {
            int zbir = 0;

            foreach (PolozeniIspit Pi in s.listaPolozenihIspita)
            {
                zbir += Pi.Ispit.ESPB;
            }
            if (zbir > 125) return 4;
            if (zbir > 81) return 3;
            if (zbir > 36) return 2;
            return 1;



        }

        public static int brojOstvarenihESPBBodova(Student s)
        {
            int zbir = 0;

            foreach (PolozeniIspit Pi in s.listaPolozenihIspita)
            {
                zbir += Pi.Ispit.ESPB;
            }

            return zbir;

        }


    }
}

