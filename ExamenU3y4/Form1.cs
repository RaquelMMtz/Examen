using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenU3y4
{
    public partial class Alumnos : Form
    {
        public Alumnos()
        {
            InitializeComponent();
        }
        Alumno[] A;
        Alumno x = new Alumno();
        int cont = 0;
        int[] array = new int[30];
        private void Form1_Load(object sender, EventArgs e)
        {
            array = new int[30];
            A = new Alumno[30];
            for (int i = 0; i < 30; i++)
            {
                A[i] = new Alumno();
            }
        }

        private void agregarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            A = x.AgregarDatos(A, cont);
            cont++;
        }

        private void mostrarDatosPorEspecialidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x.MostrarNombreEspecialidad(A, listView1);
        }

        private void mostrarDatosPorSemestreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x.MostrarSemestre(A, listView1);
        }

        private void mostrarTodosLosDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            x.MostrarTodos(A, listView1);
        }
    }
}
