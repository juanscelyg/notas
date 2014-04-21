using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace notas
{
    public partial class Form2 : Form
    {
        double pcorte = 0, scorte = 0, tcorte = 0, final = 0, lab = 0;
        int ind = 0;
        public Form2()
        {
            InitializeComponent();
            label6.Text = "Indique tipo de materia";
            MessageBox.Show("Instrucciones:\n\n- Indique primero el tipo de materia en el menu 'Tipo de materia'. \n- Para la separación decimal no olvide usar coma ( , ).\n- Física y Química se toman como materias teóricas.\n- Los laboratorios de física y química están inmersos en cada corte.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void materiasTeóricasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label6.Text = "Materia Teórica";
            nota_final.ForeColor = System.Drawing.Color.Black;
            primer_corte.Text = "";
            segundo_corte.Text = "";
            tercer_corte.Text = "";
            laboratorio.Text = "";
            nota_final.Text = "";
            laboratorio.Enabled = false;
            ind = 0;
        }

        private void materiasConLaboratorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label6.Text = "Materia con laboratorio";
            nota_final.ForeColor = System.Drawing.Color.Black;
            primer_corte.Text = "";
            segundo_corte.Text = "";
            tercer_corte.Text = "";
            laboratorio.Text = "";
            nota_final.Text = "";
            laboratorio.Enabled = true;
            ind = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pcorte = Convert.ToDouble(primer_corte.Text);
            scorte = Convert.ToDouble(segundo_corte.Text);
            tcorte = Convert.ToDouble(tercer_corte.Text);
            nota_final.ForeColor = System.Drawing.Color.Black;
            if (ind == 0)
            {
                final = (pcorte * 0.3) + (scorte * 0.3) + (tcorte * 0.4);
                nota_final.Text = Convert.ToString(final);
            }
            if (ind == 1)
            {
                lab = Convert.ToDouble(laboratorio.Text);
                final = (pcorte * 0.21) + (scorte * 0.21) + (tcorte * 0.28) + (lab * 0.3);
                nota_final.Text = Convert.ToString(final);
            }
            if (final <= 5 && final >= 0)
            {
                if (final < 2.95)
                {
                    nota_final.ForeColor = System.Drawing.Color.Red;
                    MessageBox.Show("Usted pierde esta materia.");
                }
                else
                {
                    MessageBox.Show("Usted aprueba esta materia.");
                }
            }
            else
            {
                MessageBox.Show("Usted ingreso un valor erroneo.\nRevise las comas o los valores entre 0.0 y 5.0");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

    }
}
