using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritmos
{
    public partial class FormEmpleado : Form
    {
        private string nombreCompleto;
        public FormEmpleado(string nombreCompleto)
        {
            InitializeComponent();
            this.nombreCompleto = nombreCompleto;
        }

        private void FormEmpleado_Load(object sender, EventArgs e)
        {
            lblLogin.Text = nombreCompleto;
        }
    }
}
