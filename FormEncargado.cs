using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algoritmos
{
    public partial class FormEncargado : Form
    {
        private string nombreCompleto;
        public FormEncargado(string nombreCompleto)
        {
            InitializeComponent();
            this.nombreCompleto = nombreCompleto;
        }

        private void FormEncargado_Load(object sender, EventArgs e)
        {
            lblLogin.Text = nombreCompleto;
        }
    }
}
