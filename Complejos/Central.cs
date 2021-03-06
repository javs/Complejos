﻿using System;
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
        private List<Complejo> resultados_raiz;
        private List<Complejo> resultados_raiz_primitiva;

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
                        basicoResultado.Text =
                            interprete.OperacionBasica(basicoOpA.Text, basicoOp.Text, basicoOpB.Text).ToString();

                        break;
                    case 1:
                        resultados_raiz = interprete.OperacionRaiz(raizOp.Text, raizGrado.Text);

                        raizSeleccionar.Items.Clear();

                        for (int i = 0; i < resultados_raiz.Count; ++i)
                            raizSeleccionar.Items.Add(i);

                        if (raizSeleccionar.Items.Count > 0)
                            raizSeleccionar.SelectedIndex = 0;

                        break;
                    case 2:
                        potenciaResultado.Text =
                            interprete.OperacionPotencia(potenciaOp.Text, potenciaGrado.Text).ToString();

                        break;
                    case 3:
                        resultados_raiz_primitiva = interprete.OperacionRaizPrimitiva(primitivaGrado.Text);

                        primitivaSeleccionar.Items.Clear();

                        for (int i = 0; i < resultados_raiz_primitiva.Count; ++i)
                        {
                            if (resultados_raiz_primitiva[i] != null)
                                primitivaSeleccionar.Items.Add(i);
                        }

                        if (primitivaSeleccionar.Items.Count > 0)
                            primitivaSeleccionar.SelectedIndex = 0;

                        break;
                    case 4:
                        fasoresResultado.Text =
                            interprete.OperacionSumaDeFasores(fasoresOpA.Text, fasoresOpB.Text).ToString();

                        break;
                }
            }
            catch (Exception ex)
            {
                // Ajusta el contenido para que entre, el resto se ve en el tooltip

                string mensaje = ex.Message;

                const string continuacion = " ...";
                int sub_length = ex.Message.Length - continuacion.Length;

                while (TextRenderer.MeasureText(mensaje, lEstado.Font).Width > lEstado.Width)
                {
                    mensaje = ex.Message.Substring(0, sub_length) + continuacion;
                    --sub_length;
                }
                
                lEstado.Text = mensaje;
                tEstado.SetToolTip(lEstado, ex.Message);
            }
        }

        private void Operacion_TextChanged(object sender, EventArgs e)
        {
            lEstado.Text = "";
            tEstado.RemoveAll();
        }

        private void Operacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
                Igual_Click(sender, new EventArgs());
        }

        private void raizSeleccionar_SelectedIndexChanged(object sender, EventArgs e)
        {
            Operacion_TextChanged(sender, e);

            raizResultado.Text = resultados_raiz[raizSeleccionar.SelectedIndex].ToString();
        }

        private void primitivaSeleccionar_SelectedIndexChanged(object sender, EventArgs e)
        {
            Operacion_TextChanged(sender, e);

            int valor = int.Parse(primitivaSeleccionar.SelectedItem.ToString());

            primitivaResultado.Text =
                resultados_raiz_primitiva[valor].ToString();
        }
    }
}
