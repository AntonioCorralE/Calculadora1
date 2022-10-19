using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int intResultado = 0;
            intResultado = int.Parse(this.txtNumero1.Text) + int.Parse(this.txtNumero2.Text);
            MessageBox.Show("La sumna es " + intResultado.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int intResultado = 0;
            intResultado = int.Parse(this.txtNumero1.Text) - int.Parse(this.txtNumero2.Text);
            MessageBox.Show("La super resta es " + intResultado.ToString());

        }

        private void bMultiplicar_Click(object sender, EventArgs e)
        {
            int intResultado = 0;
            intResultado = int.Parse(this.txtNumero1.Text) * int.Parse(this.txtNumero2.Text);
            MessageBox.Show("La multiplicacion es " + intResultado.ToString());
        }
    }
}
