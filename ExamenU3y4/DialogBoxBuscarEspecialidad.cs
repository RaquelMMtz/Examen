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
    public partial class DialogBoxBuscarEspecialidad : Form
    {
        public DialogBoxBuscarEspecialidad()
        {
            InitializeComponent();
        }
        public string especialidad
        {
            get { return (textBox1.Text); }
        }
        private void DialogBoxBuscarEspecialidad_Load(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Focus();
        }
    }
}
