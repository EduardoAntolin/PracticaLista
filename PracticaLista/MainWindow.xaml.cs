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

namespace PracticaLista
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<Alumno> alumnos = new List<Alumno>();


        public MainWindow()
        {
            InitializeComponent();
            alumnos.Add(new Alumno("Jose Perez" , "178293", "Lic. Ing. Produccion Multimedia"));
            alumnos.Add(new Alumno("Perlita Soto", "113223", "Lic. Ing. Biomedica"));
            alumnos.Add(new Alumno("Pancho Correos", "231492", "Lic. Ing. Mecatronica"));
            alumnos.Add(new Alumno("Elsa Bandija", "172233", "Lic. Ing. Renovables"));

            foreach(Alumno alumno in alumnos)
            {
                lstAlumnos.Items.Add(
                    new ListBoxItem()
                    {
                        Content = alumno.Nombre
                    }
                                     );
            }

        }

        private void lstAlumnos_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lblNombre.Text = alumnos[lstAlumnos.SelectedIndex].Nombre;
            lblMatricula.Text = alumnos[lstAlumnos.SelectedIndex].Matricula;
            lblCarrera.Text = alumnos[lstAlumnos.SelectedIndex].Carrera;
        }
    }
}
