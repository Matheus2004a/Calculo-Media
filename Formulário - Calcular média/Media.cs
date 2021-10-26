using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Media : Form
    {
        public Media()
        {
            InitializeComponent();
        }

        private void btn_CalcMedia_Click(object sender, EventArgs e)
        {
            decimal nota1, nota2, nota3, media;

            if (txt_BoxNota1.Text == "")
            {
                MessageBox.Show("Nota 1 é obrigatória ser preenchida", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_BoxNota1.Focus();
                return;
            }
            if (txt_BoxNota2.Text == "")
            {
                MessageBox.Show("Nota 2 é obrigatória ser preenchida", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_BoxNota2.Focus();
                return;
            }
            if (txt_BoxNota3.Text == "")
            {
                MessageBox.Show("Nota 3 é obrigatória ser preenchida", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_BoxNota3.Focus();
                return;
            }

            nota1 = Convert.ToDecimal(txt_BoxNota1.Text);
            nota2 = Convert.ToDecimal(txt_BoxNota2.Text);
            nota3 = Convert.ToDecimal(txt_BoxNota3.Text);

            media = (nota1 + nota2 + nota3) / 3;

            MessageBox.Show("Sua média é: " + string.Format("{0:n2}", media));
        }

        private void btn_Limpar_Click_1(object sender, EventArgs e)
        {
            txt_BoxNota1.Clear();
            txt_BoxNota2.Clear();
            txt_BoxNota3.Clear();
            txt_BoxNota1.Focus();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Confirma a saída do formulário?", "Mensagem", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes){
                e.Cancel = false;
            }
            else{
                e.Cancel = true;
            }
        }

        private void txt_BoxNota1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_BoxNota2.Focus();
            }
        }

        private void txt_BoxNota2_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txt_BoxNota3.Focus();
            }
        }

        private void txt_BoxNota1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)  //8=backspace,44=virgula
            {
                e.Handled = true;
            }
        }

        private void txt_BoxNota2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)  //8=backspace,44=virgula
            {
                e.Handled = true;
            }
        }

        private void txt_BoxNota3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != (char)44)  //8=backspace,44=virgula
            {
                e.Handled = true;
            }
        }
    }
}
