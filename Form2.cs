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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            axAcroPDF1.LoadFile("Instructivo.pdf");
            axAcroPDF2.LoadFile("LST2.pdf");
            axAcroPDF3.LoadFile("LST1.pdf");
            axAcroPDF4.LoadFile("Ejemplos.pdf");
        }
    }
}
