using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentskaSluzbaWF
{
    public class PolozeniIspit
    {
        private Ispit _ispit;
        private int _ocena;
        private string _datumPolaganja;

        public Ispit Ispit
        {
            get { return _ispit; }
            set { _ispit = value; }
        }


        public int Ocena
        {
            get { return _ocena; }
            set { _ocena = value; }
        }


        public string DatumPolaganja
        {
            get { return _datumPolaganja; }
            set { _datumPolaganja = value; }
        }
        public PolozeniIspit(Ispit ispit, int ocena, string datumPolaganja)
        {
            _ispit = ispit;
            _ocena = ocena;
            _datumPolaganja = datumPolaganja;
        }

      

        public PolozeniIspit() { }// neparametrizovani konstrutor, nesto nije htelo da radi bez toga
    }
}
