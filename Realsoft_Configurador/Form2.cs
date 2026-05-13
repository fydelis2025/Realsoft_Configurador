using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Net.Mail;
using System.Management;
using System.IO;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;
using Realsoft_Class;
using Microsoft.VisualBasic;

namespace Realsoft_Configurador
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Shown(object sender, EventArgs e)
        {
            try
            {



            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //_erro.appendNovaLinha(ex.Message);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {

                if (!File.Exists(Environment.CurrentDirectory + "\\Licenca.realsoft"))
                {
                    String __chave = __serial__();

                    LbSenha.Text = String.Format(@"{0:00000\.000000\.000000}", __chave);

                    TxValidacao.Text = seriehd();
                }
                else
                {
                    if (File.Exists(Environment.CurrentDirectory + "\\Licenca.realsoft"))
                    {

                        LbStatus.Text = "Sistema ja está licenciado";

                        TxValidacao.Enabled = false;
                        TxRazaoSocial.Enabled = false;
                        TxCNPJ.Enabled = false;
                        TxEmail.Enabled = false;
                        LbSenha.Enabled = false;
                        TxTelefone.Enabled = false;
                        TxFantasia.Enabled = false;
                        BtCadastrar.Enabled = false;

                            
                    }
                    else
                    {
                        throw new Exception("LICENÇA AINDA NÃO GERADA, FAVOR VERIFIQUE");
                    }
                

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string __serial__()
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            var result = new string(
                Enumerable.Repeat(chars, 15)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());

            return result;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void BtFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string seriehd()
        {
            String Serial = null;

            String SerialHD = null;

            var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");

            foreach (ManagementObject wmi_HD in searcher.Get())
            {
                
                if(Serial == null)
                {
                    Serial = wmi_HD.GetPropertyValue("SerialNumber").ToString();
                    SerialHD = Serial;
                }
                else
                {
                    
                    Serial = null;
                }
            }

            return SerialHD;

        }
        private void BtFechar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtEmail_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter escrita = new StreamWriter("Licenca.Realsoft");
                String Chave = Realsoft_VerificaAtivacao.ChecaHD();

                Realsoft_Registro _regis = new Realsoft_Registro();

                _regis.RazaoSocial = TxRazaoSocial.Text;
                _regis.FAntasia = TxFantasia.Text;
                _regis.CNPJ = TxCNPJ.Text;
                _regis.Telefone = TxTelefone.Text;
                _regis.DataAtual = DateTime.Now;
                _regis.DataValidade = DateTime.Now.AddDays(360);
                _regis.ChaveValidacao = TxValidacao.Text;
                _regis.Senha = LbSenha.Text;
                _regis.Ativo = true;

                Realsoft_Consultas.Insere_RegistroSistema(_regis);

                if (!File.Exists(Environment.CurrentDirectory + "\\Realsoft_Chave.realsoft"))
                {
                    
                    String Cript = Realsoft_Criptografia.Encrypt(Chave, Realsoft_Sistema.passPhrase, Realsoft_Sistema.saltValue, Realsoft_Sistema.hashAlgorithm, Realsoft_Sistema._interacao, Realsoft_Sistema._initvector, Realsoft_Sistema.keySize);

                    Bitmap img;

                    QRCodeEncoder encoder = new QRCodeEncoder();

                    img = encoder.Encode(Cript);
                    img.Save(Environment.CurrentDirectory + "\\Realsoft_Chave.realsoft");
                }

                string retornachave = Interaction.InputBox("POR FAVOR INFORME O NUMERO DE SÉRIE DO SISTEMA", "SERIAL", "", 200, 200);

                if (string.IsNullOrWhiteSpace(retornachave))
                {
                    MessageBox.Show("CHAVE INVÁLIDA, FAVOR VERIFIQUE", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    escrita.Close();
                    
                }
                else
                {

                    string retorno = Realsoft_ChecaRegistro.Realsoft_ChecarRetorno(retornachave);

                    if (retorno != null)
                    {
                        String Cript = Realsoft_Criptografia.Encrypt(retornachave, Realsoft_Sistema.passPhrase, Realsoft_Sistema.saltValue, Realsoft_Sistema.hashAlgorithm, Realsoft_Sistema._interacao, Realsoft_Sistema._initvector, Realsoft_Sistema.keySize);

                        escrita.Write(Cript);
                        escrita.Close();

                        Realsoft_Consultas.Update_RegistroDLL(retornachave, Chave);

                        RealsoftLicenca.Extencao ex = new RealsoftLicenca.Extencao();
                        ex.AbrirArquivoLicenca();

                        MessageBox.Show("REGISTRO EFETUADO COM SUCESSO", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);

                        System.Diagnostics.Process.Start("shutdown", "-r -t 00");
                    }
                    else
                    {
                        escrita.Close();
                        throw new Exception("CHAVE INVÁLIDA, SISTEMA NÃO LIBERADO");
                    }
                }

                //RealsoftLicenca.Extencao ext = new RealsoftLicenca.Extencao();
                //ext.AbrirArquivoLicenca();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                
            }
        }

        
    }
}
