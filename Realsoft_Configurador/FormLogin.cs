using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Realsoft_DLL;
using Realsoft_Class;
using System.IO;


namespace Realsoft_Configurador
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void BtOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(TxSenha.Text))
                {
                    throw new Exception("SENHA DO SUPORTE NÃO CONFERE");
                }
                else
                {

                    string senha = Realsoft_Criptografia.Encrypt(TxSenha.Text, Realsoft_Sistema.passPhrase, Realsoft_Sistema.saltValue, Realsoft_Sistema.hashAlgorithm, Realsoft_Sistema._interacao, Realsoft_Sistema._initvector, Realsoft_Sistema.keySize);

                    Realsoft_Geral.logon = Realsoft_Consultas.Consultar_UsuarioOperador(senha);

                    if (Realsoft_Geral.logon != null)
                    {

                        if (!Realsoft_Geral.logon.Descricao.Equals("adiel"))
                        {
                            throw new Exception("SENHA DO SUPORTE INVÁLIDO");
                        }
                        else
                        {
                            this.Hide();

                            Form1 frm = new Form1();
                            frm.ShowDialog();
                        }
                    }
                    else
                    {
                        throw new Exception("SENHA DO SUPORTE INVÁLIDO");
                    }


                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                TxSenha.Focus();
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            StreamWriter st = new StreamWriter("teste.txt");
        }
    }
}
