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

namespace PracticaUsuarios {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void cbTipoUsuario_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            panelConfiguracion.Children.Clear();
            var indexSeleccionado = cbTipoUsuario.SelectedIndex;
            if (indexSeleccionado == 0) {
                panelConfiguracion.Children.Add(new ControlAlumno());
            }
            else if (indexSeleccionado == 1) {
                panelConfiguracion.Children.Add(new ControlMaestro());
            }
        }

        private void btnGuardarUsuario_Click(object sender, RoutedEventArgs e) {
            var indexSeleccionado = cbTipoUsuario.SelectedIndex;
            if (indexSeleccionado == 0) {
                var controlAlumno = (ControlAlumno)panelConfiguracion.Children[0];
                if (controlAlumno.txtNombreAlumno.Text == "") {
                    controlAlumno.lblNombreAlumno.Foreground = Brushes.Red;
                }
                else {
                    controlAlumno.lblNombreAlumno.Foreground = Brushes.Black;
                }
                if (controlAlumno.txtDireccionAlumno.Text == "") {
                    controlAlumno.lblDireccionAlumno.Foreground = Brushes.Red;
                }
                else {
                    controlAlumno.lblDireccionAlumno.Foreground = Brushes.Black;
                }
                if (controlAlumno.cbCarreraAlumno.Text == "") {
                    controlAlumno.lblCarreraAlumno.Foreground = Brushes.Red;
                }
                else {
                    controlAlumno.lblCarreraAlumno.Foreground = Brushes.Black;
                }
                if (controlAlumno.txtPreparatoriaAlumno.Text == "") {
                    controlAlumno.lblPreparatoriaAlumno.Foreground = Brushes.Red;
                }
                else {
                    controlAlumno.lblPreparatoriaAlumno.Foreground = Brushes.Black;
                }
            }
            else if (indexSeleccionado == 1) {
                var controlMaestro = (ControlMaestro)panelConfiguracion.Children[0];
                if (controlMaestro.txtNombreMaestro.Text == "") {
                    controlMaestro.lblNombreMaestro.Foreground = Brushes.Red;
                }
                else {
                    controlMaestro.lblNombreMaestro.Foreground = Brushes.Black;
                }
                if (controlMaestro.txtTelefonoMaestro.Text == "") {
                    controlMaestro.lblTelefonoMaestro.Foreground = Brushes.Red;
                }
                else {
                    controlMaestro.lblTelefonoMaestro.Foreground = Brushes.Black;
                }
                if (controlMaestro.txtCedulaMaestro.Text == "") {
                    controlMaestro.lblCedulaMaestro.Foreground = Brushes.Red;
                }
                else {
                    controlMaestro.lblCedulaMaestro.Foreground = Brushes.Black;
                }
                if (controlMaestro.txtCarreraMaestro.Text == "") {
                    controlMaestro.lblCarreraMaestro.Foreground = Brushes.Red;
                }
                else {
                    controlMaestro.lblCarreraMaestro.Foreground = Brushes.Black;
                }
            }
        }
    }
}
