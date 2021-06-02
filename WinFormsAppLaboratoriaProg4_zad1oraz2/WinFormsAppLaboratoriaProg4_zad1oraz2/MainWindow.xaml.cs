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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WinFormsAppLaboratoriaProg4_zad1oraz2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Student> ListaStudentow { get; set; }
        public MainWindow()
        {
            ListaStudentow = new List<Student>()
            {
                new Student() {imie= "Jan", nazwisko = "Kowalski", nrIndeksu = 1234, wydzial= "KIS"},
                new Student() {imie= "Anna", nazwisko = "Nowak", nrIndeksu = 4321, wydzial= "KIS"},
                new Student() {imie= "Michał", nazwisko = "Jacek", nrIndeksu = 34562, wydzial= "KIS"}
            };

            InitializeComponent();

            dgStudent.Columns.Add(new DataGridTextColumn() { Header = "Imię", Binding = new Binding("imie")} );
            dgStudent.Columns.Add(new DataGridTextColumn() { Header = "Nazwisko", Binding = new Binding("nazwisko")} );
            dgStudent.Columns.Add(new DataGridTextColumn() { Header = "Nr Indeksu", Binding = new Binding("nrIndeksu") });
            dgStudent.Columns.Add(new DataGridTextColumn() { Header = "Wydział", Binding = new Binding("wydzial")});

            dgStudent.AutoGenerateColumns = false;
            dgStudent.ItemsSource = ListaStudentow;
        }

        private void btnAddStudent_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new StudentWindow();
            if (dialog.ShowDialog() == true)
            {
                ListaStudentow.Add(dialog.student);
                dgStudent.Items.Refresh();
            }
        }

        private void btnRemoveStudent_Click(object sender, RoutedEventArgs e)
        {
            if(dgStudent.SelectedItem is Student)
            {
                ListaStudentow.Remove((Student)dgStudent.SelectedItem);
                dgStudent.Items.Refresh();
            }
        }

        private void btnEditStudent_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new StudentWindow((Student)dgStudent.SelectedItem);
            if (dialog.ShowDialog() == true)
            {
                ListaStudentow.RemoveAt(dgStudent.SelectedIndex);
                ListaStudentow.Add(dialog.student);
                dgStudent.Items.Refresh();
            }
        }
    }
}
