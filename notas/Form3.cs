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
    public partial class Form3 : Form
    {
        double pcorte = 0, scorte = 0, tcorte = 0, final = 0, lab = 0;
        int ind = 0,aux=0;
        public Form3()
        {
            InitializeComponent();
            label1.Text = "Indique el tipo de materia . . .";
            label2.Text = "Seleccione el tipo de materia en el menu \n'Tipo de materia'";
            laboratorio.Enabled = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            tercer_corte.Enabled = false;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            MessageBox.Show("Instrucciones:\n\n- Indique primero el tipo de materia en el menu 'Tipo de materia'. \n- Para la separación decimal no olvide usar coma ( , ).\n- Física y Química se toman como materias teóricas.\n- Los laboratorios de física y química están inmersos en cada corte.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void materiasTeoricasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            nota_ne.Text = "";
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            ind = 0;
            laboratorio.Enabled = false;
            tercer_corte.Enabled = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            label1.Text = "Materias teoricas";
            label2.Text = "En los siguientes cuadros ingrese las notas correspondientes \na 1 y 2 corte. El resultado será la nota que ud necesita.";

        }

        private void materiasConLaboratorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            nota_ne.Text = "";
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            ind = 1;
            laboratorio.Enabled = true;
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            label1.Text = "Materias con laboratorio";
            label2.Text = "En los siguientes cuadros ingrese las notas correspondientes \na 1 y 2 corte. y según corresponda a su elección la del tercer \ncorte o laboratorio.";

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (ind == 0)
            {
                pcorte = Convert.ToDouble(textBox1.Text);
                scorte = Convert.ToDouble(textBox2.Text);
                final = (3 - (pcorte * 0.3 + scorte * 0.3)) / 0.4;
                nota_ne.Text = Convert.ToString(final);
                if (final <= 5 && final >= 0)
                {
                    nota_ne.ForeColor = System.Drawing.Color.Black;
                    MessageBox.Show("Usted puede aprobar la materia");
                }
                else
                {
                    nota_ne.ForeColor = System.Drawing.Color.Red;
                    MessageBox.Show("Usted no puede aprobar la materia o en su defecto ingreso un valor erroneo.\nRevise las comas o los valores entre 0.0 y 5.0");
                }


            }
            if (ind == 1)
            {
                if(radioButton1.Checked){
                    tercer_corte.Enabled = true;
                    textBox3.Enabled = true;
                    laboratorio.Enabled = false;
                    textBox4.Enabled = false;
                    pcorte = Convert.ToDouble(textBox1.Text);
                    scorte = Convert.ToDouble(textBox2.Text);
                    tcorte = Convert.ToDouble(textBox3.Text);
                    final = (3 - (pcorte * 0.21 + scorte * 0.21 + tcorte * 0.28)) / 0.3;
                    nota_ne.Text = Convert.ToString(final);
                    if (final <= 5 && final >= 0)
                    {
                        nota_ne.ForeColor = System.Drawing.Color.Black;
                        MessageBox.Show("Usted puede aprobar la materia");
                    }
                    else
                    {
                        nota_ne.ForeColor = System.Drawing.Color.Red;
                        MessageBox.Show("Usted no puede aprobar la materia o en su defecto ingreso un valor erroneo.\nRevise las comas o los valores entre 0.0 y 5.0");
                    }
                }
                if(radioButton2.Checked){
                    tercer_corte.Enabled = false;
                    textBox3.Enabled = false;
                    laboratorio.Enabled = true;
                    textBox4.Enabled = true;
                    pcorte = Convert.ToDouble(textBox1.Text);
                    scorte = Convert.ToDouble(textBox2.Text);
                    lab = Convert.ToDouble(textBox4.Text);
                    final = (3 - (pcorte * 0.21 + scorte * 0.21 + lab * 0.3)) / 0.28;
                    nota_ne.Text = Convert.ToString(final);
                    if (final <= 5 && final >= 0)
                    {
                        nota_ne.ForeColor = System.Drawing.Color.Black;
                        MessageBox.Show("Usted puede aprobar la materia");
                    }
                    else
                    {
                        nota_ne.ForeColor = System.Drawing.Color.Red;
                        MessageBox.Show("Usted no puede aprobar la materia o en su defecto ingreso un valor erroneo.\nRevise las comas o los valores entre 0.0 y 5.0");
                    }
                }

            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(aux==0){
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                nota_ne.Text = "";
                textBox3.Enabled = true;
                tercer_corte.Enabled = true;
                textBox4.Enabled = false;
                laboratorio.Enabled = false;
                aux = 1;
            }
            else{
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                nota_ne.Text = "";
                textBox3.Enabled = false;
                tercer_corte.Enabled = false;
                textBox4.Enabled = true;
                laboratorio.Enabled = true;
                aux = 0;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
