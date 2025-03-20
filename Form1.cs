using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoTabuada
{
    public partial class Tabuada : Form
    {
        public Tabuada()
        {
            InitializeComponent();

            this.MaximizeBox = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            lstResultado.Items.Clear();

            if (!int.TryParse(txtNumInicial.Text, out int NumInicial) ||
                !int.TryParse(txtNumFinal.Text, out int NumFinal))
            {
                MessageBox.Show("Por favor, insira somente números inteiros.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (NumInicial <= 0 || NumFinal <= 0 || NumInicial >= 100 || NumFinal >= 100)
            {
                MessageBox.Show("Os números devem ser maiores que 0 e menores que 100.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (NumInicial > NumFinal)
            {
                MessageBox.Show("O número inicial deve ser menor que o número final.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //Cálculo e exibição da tabuada utilizando for
            for (int i = NumInicial; i <= NumFinal; i++)
            {
                lstResultado.Items.Add($"Tabuada de {i}:");
                for (int j = 1; j <= 10; j++)
                {
                    lstResultado.Items.Add($"{i} x {j} = {i * j}");
                }
                lstResultado.Items.Add("");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lstResultado.Items.Clear();

            txtNumInicial.Clear();
            txtNumFinal.Clear();

            txtNumInicial.Focus();
        }

        private void txtNumInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtNumFinal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtNumInicial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtNumFinal.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void txtNumFinal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCalcular.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void btnCalcular_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCalcular.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void btnLimpar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                btnLimpar.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void Tabuada_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                btnLimpar.PerformClick();
                e.Handled = true;
            }
        }

        private void lstResultado_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.DrawFocusRectangle();

            if (e.Index >= 0)
            {
                string text = lstResultado.Items[e.Index].ToString();

                Font font = text.StartsWith("Tabuada de")
                ? new Font(e.Font, FontStyle.Bold)
            : e.Font;

                e.Graphics.DrawString(text, font, new SolidBrush(e.ForeColor), e.Bounds);
            }
        }

    }
}
