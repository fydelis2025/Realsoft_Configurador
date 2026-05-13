using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Realsoft_Configurador
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = Realsoft_Criptografia.Encrypt(textBox1.Text, Realsoft_Sistema.passPhrase, Realsoft_Sistema.saltValue, Realsoft_Sistema.hashAlgorithm, Realsoft_Sistema._interacao, Realsoft_Sistema._initvector, Realsoft_Sistema.keySize);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = Realsoft_Criptografia.Decrypt(textBox1.Text, Realsoft_Sistema.passPhrase, Realsoft_Sistema.saltValue, Realsoft_Sistema.hashAlgorithm, Realsoft_Sistema._interacao, Realsoft_Sistema._initvector, Realsoft_Sistema.keySize);
        }
    }
}
