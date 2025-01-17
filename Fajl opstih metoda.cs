using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Channels;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;



namespace StudentskaSluzbaWF
{
    internal static class Fajl_opstih_metoda
    {

        public static bool daLiSuSviPodaciPopunjeni(Student student)
        {
            {


                if (string.IsNullOrEmpty(student.ImeIPrezime))
                {
                    //MessageBox.Show("Ime i prezime nije popunjeno");
                    return false;
                }

                if (string.IsNullOrEmpty(student.ImeRoditelja))
                {
                    //MessageBox.Show("Ime roditelja nije popunjeno");
                    return false;
                }

                if (string.IsNullOrEmpty(student.OpstinaRodjenja))
                {
                    // MessageBox.Show("Ime roditelja nije popunjeno");
                    return false;
                }
                if (string.IsNullOrEmpty(student.DatumRodjenja))
                {
                    // MessageBox.Show("DatumRodjenja nije popunjen");
                    return false;
                }
                if (string.IsNullOrEmpty(student.DrzavaRodjenja))
                {
                    // MessageBox.Show("DrzavaRodjenja nije popunjen");
                    return false;
                }
                if (string.IsNullOrEmpty(student.Jmbg))
                {
                    //MessageBox.Show("Jmbg nije popunjen");
                    return false;
                }
                if (string.IsNullOrEmpty(student.Drzavljanstvo))
                {
                    //  MessageBox.Show("Drzavljanstvo nije popunjeno");
                    return false;
                }
                if (string.IsNullOrEmpty(student.VrstaStudija))
                {
                    //  MessageBox.Show("VrstaStudija nije odabrana");
                    return false;
                }

                if (string.IsNullOrEmpty(student.Smer))
                {

                    //  MessageBox.Show("Smer nije odabran");
                    return false;
                }
                if (string.IsNullOrEmpty(student.BrojIndeksa))
                {
                    MessageBox.Show("Broj indeksa nije popunjen");
                    return false;
                }

                return true;
            }
        }
        public static string pripremaSvihIspitaZaPrikaz(Ispit ispit)
        {

            return ispit.Naziv;
        }

        public static string pripremaPodatkaZaPrikaz(Student student)
        {

            return student.ImeIPrezime + "  " + student.BrojIndeksa;


        }

        public static bool daLiBrojIndeksaSmeDaSeKoristi(string indeks)
        {
            foreach (Student s in Fajl_metoda_koje_rade_sa_studentom.listaUpisanihStudenata)
            {
                if (indeks.Equals(s.BrojIndeksa))
                {

                    return false;
                }
            }
            return true;
        }

        public static Ispit pronadjiIspitPoImenu(string naziv)
        {
            Ispit i1;

            foreach (Ispit i in Fajl_metoda_koje_rade_sa_studentom.listaIspitaIsit)
            {
                //MessageBox.Show("TRAZI SE ISPIT :" + naziv+"\nPOREDIM SA :"+i.Naziv);
                if (i.Naziv.Equals(naziv))
                {
                    i1 = i;
                    //MessageBox.Show("Ispit je pronadjen po imenu");
                    return i1;
                }
            }

            return null;

        }

        public static void PrikaziSveElemente(object obj)
        {
            if (obj != null)
            {
                Type type = obj.GetType();
                PropertyInfo[] properties = type.GetProperties();
                FieldInfo[] fields = type.GetFields();

                string prikaz = "Elementi objekta:\n";

                foreach (PropertyInfo property in properties)
                {
                    prikaz += $"{property.Name}: {property.GetValue(obj)}\n";
                }

                foreach (FieldInfo field in fields)
                {
                    prikaz += $"{field.Name}: {field.GetValue(obj)}\n";
                }

                MessageBox.Show(prikaz, "Prikaz svih elemenata");

            }
            else
            {
                MessageBox.Show("Prosledjeni objekat je null");
            }

        }

    }
}


