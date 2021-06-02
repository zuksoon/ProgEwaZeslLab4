using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppLaboratoriaProg4_zad1oraz2
{
    public class Student
    {
        public string imie { get; set; }
        public string nazwisko { get; set; }
        public int nrIndeksu { get; set; }
        public string wydzial { get; set; }

        public Student(string imie, string nazwisko, int nrIndexu, string wydzial)
        {

            this.imie = imie;
            this.nazwisko = nazwisko;
            this.nrIndeksu = nrIndexu;
            this.wydzial = wydzial;
        }
        public Student()     
        {
            this.imie = "";
            this.nazwisko = "";
            this.nrIndeksu = 0;
            this.wydzial = "";
        }
    }
}
