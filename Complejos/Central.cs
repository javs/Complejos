using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Complejos
{
    public partial class Central : Form
    {
        private Interprete interprete = new Interprete();

        public Central()
        {
            InitializeComponent();
            lEstado.Text = "";
        }

        private void Igual_Click(object sender, EventArgs e)
        {
            try
            {
                lEstado.Text = "";
                Resultado.Text = interprete.Operacion(Operacion.Text);
            }
            catch (Exception ex)
            {
                lEstado.Text = ex.Message;
            }
        }

        private void Operacion_TextChanged(object sender, EventArgs e)
        {
            lEstado.Text = "";
        }

        private void Operacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                Igual_Click(sender, new EventArgs());
        }
    }
}
