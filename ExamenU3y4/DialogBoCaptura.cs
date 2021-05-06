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
    public partial class DialogBoCaptura : Form
    {
        public DialogBoCaptura()
        {
            InitializeComponent();
        }
        public string matriula
        {
            get { return (textBox1.Text); }
        }
        public string nombrealumno
        {
            get { return (textBox2.Text); }
        }
         public string especialidad
        {
            get { return (textBox3.Text); }
        }
        public string semestre
        {
            get { return (textBox4.Text); }
        }
        public string promedio
        {
            get { return (textBox5.Text); }
        }

        private void DialogBoCaptura_Load(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Focus();
        }
    }
}
