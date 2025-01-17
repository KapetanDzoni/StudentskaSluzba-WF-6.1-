using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskaSluzbaWF
{
    public class Ispit
    {

        private string naziv;
        public string Naziv
        {
            get { return naziv; }
            set { naziv = value; }
        }

        private int espb;

        public int ESPB
        {
            get { return espb; }
            set { espb = value; }
        }
        private int godina;
        public int Godina
        {
            get { return godina; }
            set { godina = value; }
        }

        public Ispit(string naziv1, int e, int god)
        {

            naziv = naziv1;
            espb = e;
            godina = god;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Ispit other = (Ispit)obj;
            return Naziv == other.Naziv && ESPB == other.ESPB && Godina == other.Godina;
        }

        public Ispit() { }
        // iz nekog razloga sam imao problem u jednom momentu sa cuvanjem baze ukoliko nije sadrzao neparametrizovani konstruktor, zato je tu
    }
}
