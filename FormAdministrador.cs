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
    public partial class FormAdministrador : Form
    {
        private string nombreCompleto;

        public FormAdministrador(string nombreCompleto)
        {
            InitializeComponent();
            this.nombreCompleto = nombreCompleto;
        }

        private void FormAdministrador_Load(object sender, EventArgs e)
        {
            lblLogin.Text = nombreCompleto;
        }
    }
}
