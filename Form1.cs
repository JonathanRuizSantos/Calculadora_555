using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraR1R2C1_555C1C2C3
{
    public partial class Form1 : Form
    {
        double x, y, z, a, b, c, d, f,g,h,i, r, r2, r3;
        Calc555Timer Calc1;
        string men;
      

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void firmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("WFRuizSJ.exe");
        }

        private void btC2T1YT2_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = Calc1.C2T1YT2(x, y, ref r, ref r2);
                Salida2(r, r2);
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void btC2R2_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = Calc1.C2R2(x, y, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void btC2R2NYR1_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = Calc1.C2R2NyR1(c, y, z, a, b, ref r, ref r2, ref r3);
                Salida3(r, r2, r3);
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void btC3R2_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = Calc1.C3R2(x, y, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = Calc1.C3R2NyR1(c, y, z, a, b, ref r, ref r2, ref r3);
                Salida3(r, r2, r3);
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = Calc1.C3R1N(d, y, z, a, f, g, ref r, ref r2, ref r3);
                Salida2(r, r2);
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void resistenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("TablaResistenciasN.png");
        }

        private void btC2R1N_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = Calc1.C2R1N(d, y, z, a, f, g, ref r, ref r2, ref r3);
                Salida2(r, r2);
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            AddFormulario(f);
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            AddFormulario(f);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = Calc1.C3T1YT2(x, y,h,i, ref r, ref r2);
                Salida2(r, r2);
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        string fxyz;
        string s;
        public Form1()
        {
            InitializeComponent();
            Calc1 = new Calc555Timer();
        }
        private void btC1R1N_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = Calc1.C1R1N(d, y, z, a, f, g, ref r, ref r2, ref r3);
                Salida2(r, r2);
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        private void btC1R2_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = Calc1.C1R2(x, y, ref r);
                Salida(r);
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void btC1R2NyR1_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = Calc1.C1R2NyR1(c, y, z, a, b, ref r, ref r2, ref r3);
                Salida3(r, r2, r3);
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        
        

        private void btC1T1yT2_Click(object sender, EventArgs e)
        {
            try
            {
                Entrada();
                men = Calc1.C1T1YT2(x, y, ref r, ref r2);
                Salida2(r, r2);
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        public void Entrada()
        {
            try
            {
                x = double.Parse(tbd1.Text);
                y = double.Parse(tbd2.Text);
                z = double.Parse(tbd3.Text);
                a = double.Parse(tbd4.Text);
                b = double.Parse(tbd5.Text);
                c = double.Parse(tbd6.Text);
                d = double.Parse(tbd7.Text);
                f = double.Parse(tbd8.Text);
                g = double.Parse(tbd9.Text);
                h = double.Parse(tbd10.Text);
                i = double.Parse(tbd11.Text);

            }
            catch
            {
                MessageBox.Show("Error de datos");
            }
        }
        public void Salida(double r)
        {
            lBSalida.Items.Clear();
            lBSalida.Items.Add(r);
            tBmensaje.Text = men;
        }
        public void Salida2(double r, double r2)
        {
            lBSalida.Items.Clear();
            lBSalida.Items.Add(r);
            lBSalida.Items.Add(r2);
            tBmensaje.Text = men;
        }
        public void Salida3(double r, double r2, double r3)
        {
            lBSalida.Items.Clear();
            lBSalida.Items.Add(r);
            lBSalida.Items.Add(r2);
            lBSalida.Items.Add(r3);
            tBmensaje.Text = men;
        }
        public void AddFormulario(Form f)
        {

            if (this.panel1.Controls.Count > 0)
            {
                this.panel1.Controls.RemoveAt(0);
            }

            f.TopLevel = false;
            this.panel1.Controls.Add(f);
            f.Dock = DockStyle.Fill;
            f.Show();
        }
    }
}
