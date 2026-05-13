using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Realsoft_Class;
using Realsoft_DLL;
using System.Security.Cryptography;
using System.IO;

namespace Realsoft_Configurador
{
    public partial class FormECF : Form
    {
        public FormECF()
        {
            InitializeComponent();
        }

        private void FormECF_Load(object sender, EventArgs e)
        {
            try
            {
                StringBuilder serie = new StringBuilder(21);

                TxCriptografia.Text =  Realsoft_Criptografia.Encrypt("REALSOFT_@@EFEB1730FE92@@", Realsoft_Sistema.passPhrase, Realsoft_Sistema.saltValue, Realsoft_Sistema.hashAlgorithm, Realsoft_Sistema._interacao, Realsoft_Sistema._initvector, Realsoft_Sistema.keySize);

                Realsoft_Geral._AtivaECF = null;

                short retorno =  Realsoft_Elgin.Elgin_NumeroSerie(serie.ToString());

                TxSerie.Text = serie.ToString();
             
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void megasoftButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Realsoft_Geral._AtivaECF == null)
                {
                    if (String.IsNullOrEmpty(TxSerie.Text) & String.IsNullOrEmpty(TxCriptografia.Text))
                    {
                        throw new Exception("FAVOR INFORMAR TODOS OS CAMPOS");
                    }
                    else
                    {

                        Realsoft_Geral._AtivaECF = new Realsoft_AtivarECF();

                        Realsoft_Geral._AtivaECF.Terminal = Realsoft_Sistema.Terminal;
                        Realsoft_Geral._AtivaECF.Serie = TxSerie.Text;
                        Realsoft_Geral._AtivaECF.Modelo = TxModelo.Text;
                        Realsoft_Geral._AtivaECF.Loja = TxLoja.Text;
                        Realsoft_Geral._AtivaECF.Criptografia = "";
                        Realsoft_Geral._AtivaECF.Ativo = ChAtivo.Checked;

                        Realsoft_Consultas.Insere_AtivarECF(Realsoft_Geral._AtivaECF);

                        throw new Exception("ECF CADASTRADO COM SUCESSO");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
