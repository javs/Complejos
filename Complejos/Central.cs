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
            basicoOp.SelectedIndex = 0;
        }

        private void Igual_Click(object sender, EventArgs e)
        {
            try
            {
                lEstado.Text = "";

                switch (tabs.SelectedIndex)
                {
                    case 0:
                        Resultado.Text =
                            interprete.OperacionBasica(basicoOpA.Text, basicoOp.Text, basicoOpB.Text);
                        break;
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                }
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
