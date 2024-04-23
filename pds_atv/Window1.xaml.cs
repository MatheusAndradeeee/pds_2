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

namespace pds_atv
{
    /// <summary>
    /// Lógica interna para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Alunos alunos = new Alunos();
            alunos.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Escolas escolas = new Escolas();
            escolas.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Turmas turmas = new Turmas();
            turmas.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Cursos cursos = new Cursos();
            cursos.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Relatorios relatorios = new Relatorios();
            relatorios.Show();
        }
    }
}
