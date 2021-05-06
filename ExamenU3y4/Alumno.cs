using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ExamenU3y4
{
    class Alumno
    {
        public string Matricula;
        public string NombreAlumno;
        public string Especialidad;
        public int Semestre;
        public double Promedio;
        public string  matricula
        {
            set { value = matricula; }
            get { return (Matricula); }
        }
        public string nombrealumno
        {
            set { value = nombrealumno; }
            get { return (NombreAlumno); }
        }
        public string especialidad
        {
            set { value = especialidad; }
            get { return (Especialidad); }
        }
        public int semestre
        {
            set { value = semestre; }
            get { return (Semestre); }
        }
        public double promedio
        {
            set { value = promedio; }
            get { return (Promedio); }
        }
        public Alumno()
        {
            Matricula = "";
            NombreAlumno = "";
            Especialidad = "";
            Semestre = 0;
            Promedio = 0;
        }
        public Alumno[] AgregarDatos(Alumno[] A, int i)
        {
            DialogBoCaptura captura = new DialogBoCaptura();
            if (captura.ShowDialog() == DialogResult.OK)
            {
                A[i].Matricula = captura.matriula;
                A[i].NombreAlumno = captura.nombrealumno;
                A[i].Especialidad = captura.especialidad;
                A[i].Semestre = int.Parse(captura.semestre);
                A[i].Promedio = double.Parse(captura.promedio);
                MessageBox.Show("Los datos se almacenaron en el arreglo", "Arreglos",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return (A);
        }
        public void MostrarTodos(Alumno[] A, ListView caja)
        {
            caja.Items.Clear();
            for (int i = 0; i < 30; i++)
            {
                if (A[i].Matricula != "")
                {
                    ListViewItem lista = new ListViewItem(A[i].Matricula.ToString());
                    lista.SubItems.Add(A[i].NombreAlumno);
                    lista.SubItems.Add(A[i].Especialidad);
                    lista.SubItems.Add(A[i].Semestre.ToString());
                    lista.SubItems.Add(A[i].Promedio.ToString());


                    caja.Items.Add(lista);
                }
            }
        }
        public void MostrarNombreEspecialidad(Alumno[] A, ListView caja)
        {
            caja.Items.Clear();
            bool sw = true;
            DialogBoxBuscarEspecialidad busca = new DialogBoxBuscarEspecialidad();
            if (busca.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i].Especialidad.ToUpper() == busca.especialidad.ToUpper())
                    {
                        sw = false;
                        ListViewItem lista = new ListViewItem(A[i].Matricula.ToString());
                        lista.SubItems.Add(A[i].NombreAlumno);
                        lista.SubItems.Add(A[i].Especialidad);
                        lista.SubItems.Add(A[i].Semestre.ToString());
                        lista.SubItems.Add(A[i].Promedio.ToString());

                        caja.Items.Add(lista);
                    }
                }
                if (sw == true)
                {
                    MessageBox.Show("No se encontro el nombre del producto", "Arreglo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }
        public void MostrarSemestre(Alumno[] A, ListView caja)
        {
            caja.Items.Clear();
            bool sw = true;
           DialogBoxBuscarSemestre busca = new DialogBoxBuscarSemestre();
            if (busca.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i].Semestre == int.Parse(busca.semestre))
                    {
                        sw = false;
                        ListViewItem lista = new ListViewItem(A[i].Matricula.ToString());
                        lista.SubItems.Add(A[i].NombreAlumno);
                        lista.SubItems.Add(A[i].Especialidad);
                        lista.SubItems.Add(A[i].Semestre.ToString());
                        lista.SubItems.Add(A[i].Promedio.ToString());

                        caja.Items.Add(lista);
                    }
                }
                if (sw == true)
                {
                    MessageBox.Show("No se encontro el precio del producto", "Arreglo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }
    }
}
