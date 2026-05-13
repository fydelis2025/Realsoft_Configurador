using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Realsoft_Class;
using System.IO;

namespace Realsoft_Configurador
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BKProgress_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                for (int i = 0; i <= 100; i++)
                {
                    System.Threading.Thread.Sleep(100);
                    BKProgress.ReportProgress(i);

                    
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BKProgress_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            try
            {
                progressBar1.Value = e.ProgressPercentage;
                LbProgresso.Text = e.ProgressPercentage.ToString() + "%";

                if (e.ProgressPercentage == 30)
                {
                    LbAguarde.Text = "Configurando sistema";

                    if (!System.IO.File.Exists("AjusteConfig.ini"))
                    {
                        throw new Exception("ARQUIVO PRINCIPAL DO SISTEMA NÃO ENCONTRADO");
                    }
                }

                if (e.ProgressPercentage == 70)
                {
                    LbAguarde.Text = "Verificando registro"; 
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BKProgress_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                this.Hide();


                if (!File.Exists("Licenca.realsoft"))
                {
                    
                    Form2 reg = new Form2();
                    reg.Show();

                    
                }
                else
                {
                    StreamReader leitura = new StreamReader("Licenca.realsoft");

                    string retorno = leitura.ReadToEnd();
                    leitura.Close();

                    String ChaveHD = Realsoft_VerificaAtivacao.ChecaHD();

                    string senha = Realsoft_Criptografia.Decrypt(retorno, Realsoft_Sistema.passPhrase, Realsoft_Sistema.saltValue, Realsoft_Sistema.hashAlgorithm, Realsoft_Sistema._interacao, Realsoft_Sistema._initvector, Realsoft_Sistema.keySize);

                    Realsoft_Sistema.Chave = Realsoft_Consultas.Consultar_ChaveRegistro(ChaveHD);

                    if (senha == Realsoft_Sistema.Chave)
                    {
                        FormLogin login = new FormLogin();
                        login.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("CHAVE INVÁLIDA, FAVOR ENTRAR EM CONTATO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {

            BKProgress.RunWorkerAsync();
        }
    }
}
