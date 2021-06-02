using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Text.RegularExpressions;

namespace WinFormsAppLaboratoriaProg4_zad1oraz2
{
    /// <summary>
    /// Logika interakcji dla klasy StudentWindow.xaml
    /// </summary>
    public partial class StudentWindow : Window
    {
        public Student student;
        
        public StudentWindow(Student student = null)
        {
            InitializeComponent();
            if(student != null)
            {
                tbImie.Text = student.imie;
                tbNazwisko.Text = student.nazwisko;
                tbNrAlbumu.Text = student.nrIndeksu.ToString();
                tbWydzial.Text = student.wydzial;
            }
            this.student = student ?? new Student();
        }

        public StudentWindow()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            if(!Regex.IsMatch(tbImie.Text, @"^\p{Lu}\p{Ll}{1,12}$") ||
               !Regex.IsMatch(tbNazwisko.Text, @"^\p{Lu}\p{Ll}{1,12}$") ||
               !Regex.IsMatch(tbNrAlbumu.Text, @"^[0-9]{4,10}$") ||
               !Regex.IsMatch(tbImie.Text, @"^\p{Lu}\p{Ll}{1,12}$"))
            {
                MessageBox.Show("Podano błędne dane.");
                return;
            }
            student.imie = tbImie.Text;
            student.nazwisko = tbNazwisko.Text;
            student.nrIndeksu = int.Parse(tbNrAlbumu.Text);
            student.wydzial = tbWydzial.Text;

            this.DialogResult = true;
        }
    }
}
