using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Realsoft_Configurador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            try
            {
                if (System.IO.File.Exists("AjusteConfig.ini"))
                {

                   
                }
                else
                {
                    throw new Exception("Arquivo configuração não existe, ou está corrompido");
                }


            }
            catch (OverflowException ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //_erro.appendNovaLinha(ex.Message);
            }
            
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            try
            {                
                //Configurador _config = new Configurador();

                //PropertyConfig.SelectedObject = _config;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {

                Configurador _config = new Configurador();

                PropertyConfig.SelectedObject = _config;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtBalanca_Click(object sender, EventArgs e)
        {
            FormBalanca balanca = new FormBalanca();
            balanca.ShowDialog();
        }

        private void BtECF_Click(object sender, EventArgs e)
        {
            FormECF ecf = new FormECF();
            ecf.ShowDialog();
        }

        private void BtRegistro_Click(object sender, EventArgs e)
        {
            Form2 registro = new Form2();
            registro.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form3 p = new Form3();
            p.ShowDialog();
        }

        private void BtUsuario_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.ShowDialog();
        }

        private void PropertyConfig_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            try
            {
                if (e.ChangedItem.Label.Equals("MARCABAL"))
                {
                    Realsoft_INI.gravaarquivoini("BALANCA", "MARCA", e.ChangedItem.Value.ToString().ToUpper());
                    throw new Exception("CONFIGURAÇÃO ATUALIZADA PARA: " + e.ChangedItem.Value.ToString().ToUpper());
                }
                else if (e.ChangedItem.Label.Equals("MODELOBAL"))
                {
                    Realsoft_INI.gravaarquivoini("BALANCA", "MODELO", e.ChangedItem.Value.ToString().ToUpper());
                    throw new Exception("CONFIGURAÇÃO ATUALIZADA PARA: " + e.ChangedItem.Value.ToString().ToUpper());
                }
                else if (e.ChangedItem.Label.Equals("PORTABAL"))
                {
                    Realsoft_INI.gravaarquivoini("BALANCA", "PORTACOMUNICACAO", e.ChangedItem.Value.ToString().ToUpper());
                    throw new Exception("CONFIGURAÇÃO ATUALIZADA PARA: " + e.ChangedItem.Value.ToString().ToUpper());
                }
                else if (e.ChangedItem.Label.Equals("TAXABAL"))
                {
                    Realsoft_INI.gravaarquivoini("BALANCA", "TAXACOMUNICACAO", e.ChangedItem.Value.ToString().ToUpper());
                    throw new Exception("CONFIGURAÇÃO ATUALIZADA PARA: " + e.ChangedItem.Value.ToString().ToUpper());
                }
                else if (e.ChangedItem.Label.Equals("AJUSTEBAL"))
                {
                    Realsoft_INI.gravaarquivoini("BALANCA", "AJUSTE", e.ChangedItem.Value.ToString().ToUpper());
                    throw new Exception("CONFIGURAÇÃO ATUALIZADA PARA: " + e.ChangedItem.Value.ToString().ToUpper());
                }
                else if (e.ChangedItem.Label.Equals("SKIN"))
                {
                    Realsoft_INI.gravaarquivoini("GERAL", "SKYN", e.ChangedItem.Value.ToString().ToUpper());
                    throw new Exception("CONFIGURAÇÃO ATUALIZADA PARA: " + e.ChangedItem.Value.ToString().ToUpper());
                }
                else if (e.ChangedItem.Label.Equals("EMPRESA"))
                {
                    Realsoft_INI.gravaarquivoini("GERAL", "EMPRESA", e.ChangedItem.Value.ToString().ToUpper());
                    throw new Exception("CONFIGURAÇÃO ATUALIZADA PARA: " + e.ChangedItem.Value.ToString().ToUpper());
                }
                else if (e.ChangedItem.Label.Equals("TERMINAL"))
                {
                    Realsoft_INI.gravaarquivoini("GERAL", "TERMINAL", e.ChangedItem.Value.ToString().ToUpper());
                    throw new Exception("CONFIGURAÇÃO ATUALIZADA PARA: " + e.ChangedItem.Value.ToString().ToUpper());
                }
                else if (e.ChangedItem.Label.Equals("ECF"))
                {
                    Realsoft_INI.gravaarquivoini("GERAL", "ECF", e.ChangedItem.Value.ToString().ToUpper());
                    throw new Exception("CONFIGURAÇÃO ATUALIZADA PARA: " + e.ChangedItem.Value.ToString().ToUpper());
                }
                else if (e.ChangedItem.Label.Equals("INICIOCODIGOETIQUETA"))
                {
                    Realsoft_INI.gravaarquivoini("GERAL", "INICIOCODIGOETIQUETA", e.ChangedItem.Value.ToString().ToUpper());
                    throw new Exception("CONFIGURAÇÃO ATUALIZADA PARA: " + e.ChangedItem.Value.ToString().ToUpper());
                }
                else if (e.ChangedItem.Label.Equals("FINALCODIGOETIQUETA"))
                {
                    Realsoft_INI.gravaarquivoini("GERAL", "FINALCODIGOETIQUETA", e.ChangedItem.Value.ToString().ToUpper());
                    throw new Exception("CONFIGURAÇÃO ATUALIZADA PARA: " + e.ChangedItem.Value.ToString().ToUpper());
                }
                else if (e.ChangedItem.Label.Equals("INICIOVALORETIQUETA"))
                {
                    Realsoft_INI.gravaarquivoini("GERAL", "INICIOVALORETIQUETA", e.ChangedItem.Value.ToString().ToUpper());
                    throw new Exception("CONFIGURAÇÃO ATUALIZADA PARA: " + e.ChangedItem.Value.ToString().ToUpper());
                }
                else if (e.ChangedItem.Label.Equals("FINALVALORETIQUETA"))
                {
                    Realsoft_INI.gravaarquivoini("GERAL", "FINALVALORETIQUETA", e.ChangedItem.Value.ToString().ToUpper());
                    throw new Exception("CONFIGURAÇÃO ATUALIZADA PARA: " + e.ChangedItem.Value.ToString().ToUpper());
                }
                else if (e.ChangedItem.Label.Equals("ARREDONDAMENTO"))
                {
                    Realsoft_INI.gravaarquivoini("GERAL", "ARREDONDAMENTO", e.ChangedItem.Value.ToString());
                    throw new Exception("CONFIGURAÇÃO ATUALIZADA PARA: " + e.ChangedItem.Value.ToString().ToUpper());
                }
                else if (e.ChangedItem.Label.Equals("CAMINHO PUBLICIDADE"))
                {
                    Realsoft_INI.gravaarquivoini("GERAL", "CaminhoPublicidade", e.ChangedItem.Value.ToString().ToUpper());
                    throw new Exception("CONFIGURAÇÃO ATUALIZADA PARA: " + e.ChangedItem.Value.ToString().ToUpper());
                }
                else if (e.ChangedItem.Label.Equals("IPSERVIDOR"))
                {
                    Realsoft_INI.gravaarquivoini("GERAL", "IPSERVIDOR", e.ChangedItem.Value.ToString().ToUpper());
                    throw new Exception("CONFIGURAÇÃO ATUALIZADA PARA: " + e.ChangedItem.Value.ToString().ToUpper());
                }
                else if (e.ChangedItem.Label.Equals("PORTACONEXAO"))
                {
                    Realsoft_INI.gravaarquivoini("GERAL", "PORTACONEXAO", e.ChangedItem.Value.ToString().ToUpper());
                    throw new Exception("CONFIGURAÇÃO ATUALIZADA PARA: " + e.ChangedItem.Value.ToString().ToUpper());
                }
                else if (e.ChangedItem.Label.Equals("HABILITARMODULOPREVENDA"))
                {
                    Realsoft_INI.gravaarquivoini("GERAL", "HABILITARMODULOPREVENDA", e.ChangedItem.Value.ToString());
                    throw new Exception("CONFIGURAÇÃO ATUALIZADA PARA: " + e.ChangedItem.Value.ToString().ToUpper());
                }
                else if (e.ChangedItem.Label.Equals("SOLICITARSENHAABERTURAGAVETA"))
                {
                    Realsoft_INI.gravaarquivoini("GERAL", "SOLICITARSENHAABERTURAGAVETA", e.ChangedItem.Value.ToString());
                    throw new Exception("CONFIGURAÇÃO ATUALIZADA PARA: " + e.ChangedItem.Value.ToString().ToUpper());
                }
                else if (e.ChangedItem.Label.Equals("CLIENTESERVIDOR"))
                {
                    Realsoft_INI.gravaarquivoini("GERAL", "CLIENTESERVIDOR", e.ChangedItem.Value.ToString());
                    throw new Exception("CONFIGURAÇÃO ATUALIZADA PARA: " + e.ChangedItem.Value.ToString().ToUpper());
                }
                else if (e.ChangedItem.Label.Equals("HABILITARNFCE"))
                {
                    Realsoft_INI.gravaarquivoini("GERAL", "HABILITARNFCE", e.ChangedItem.Value.ToString());
                    throw new Exception("CONFIGURAÇÃO ATUALIZADA PARA: " + e.ChangedItem.Value.ToString().ToUpper());
                }
                else if (e.ChangedItem.Label.Equals("BALANCAPORPESO"))
                {
                    Realsoft_INI.gravaarquivoini("GERAL", "BALANCAPORPESO", e.ChangedItem.Value.ToString());
                    throw new Exception("CONFIGURAÇÃO ATUALIZADA PARA: " + e.ChangedItem.Value.ToString().ToUpper());
                }
                else if (e.ChangedItem.Label.Equals("NOME BANCO"))
                {

                }
                else if (e.ChangedItem.Label.Equals("USUARIO BANCO"))
                {

                }
                else if (e.ChangedItem.Label.Equals("SENHA BANCO"))
                {

                }
                else if (e.ChangedItem.Label.Equals("ENDERECO RETAGUARDA"))
                {
                    Realsoft_INI.gravaarquivoini("SERVIDOR", "SQL", Realsoft_Criptografia.Encrypt(e.ChangedItem.Value.ToString(), Realsoft_Sistema.passPhrase, Realsoft_Sistema.saltValue, Realsoft_Sistema.hashAlgorithm, Realsoft_Sistema._interacao, Realsoft_Sistema._initvector, Realsoft_Sistema.keySize));
                    throw new Exception("CONFIGURAÇÃO ATUALIZADA PARA: " + e.ChangedItem.Value.ToString().ToUpper());
                }
                else if (e.ChangedItem.Label.Equals("ENDERECO CAIXA"))
                {
                    Realsoft_INI.gravaarquivoini("CONEXAO", "MYSQL", Realsoft_Criptografia.Encrypt(e.ChangedItem.Value.ToString(), Realsoft_Sistema.passPhrase, Realsoft_Sistema.saltValue, Realsoft_Sistema.hashAlgorithm, Realsoft_Sistema._interacao, Realsoft_Sistema._initvector, Realsoft_Sistema.keySize));
                    throw new Exception("CONFIGURAÇÃO ATUALIZADA PARA: " + e.ChangedItem.Value.ToString().ToUpper());
                }
                else if (e.ChangedItem.Label.Equals("MARCAIMPRESSORA"))
                {
                    Realsoft_INI.gravaarquivoini("IMPRESSORA", "MARCAIMPRESSORA", e.ChangedItem.Value.ToString());
                    throw new Exception("CONFIGURAÇÃO ATUALIZADA PARA: " + e.ChangedItem.Value.ToString().ToUpper());
                }
                else if (e.ChangedItem.Label.Equals("MODOIMPRESSAO"))
                {
                    Realsoft_INI.gravaarquivoini("IMPRESSORA", "MODOIMPRESSAO", e.ChangedItem.Value.ToString());
                    throw new Exception("CONFIGURAÇÃO ATUALIZADA PARA: " + e.ChangedItem.Value.ToString().ToUpper());
                }
                else if (e.ChangedItem.Label.Equals("PORTACOMUNICACAO"))
                {
                    Realsoft_INI.gravaarquivoini("IMPRESSORA", "PORTACOMUNICACAO", e.ChangedItem.Value.ToString().ToUpper());
                    throw new Exception("CONFIGURAÇÃO ATUALIZADA PARA: " + e.ChangedItem.Value.ToString().ToUpper());
                }
                else if (e.ChangedItem.Label.Equals("EMPRESATEF"))
                {
                    Realsoft_INI.gravaarquivoini("CONFIGURACAOTEF", "LOJA", e.ChangedItem.Value.ToString().ToUpper());
                    throw new Exception("CONFIGURAÇÃO ATUALIZADA PARA: " + e.ChangedItem.Value.ToString().ToUpper());
                }
                else if (e.ChangedItem.Label.Equals("FILIALTEF"))
                {
                    Realsoft_INI.gravaarquivoini("CONFIGURACAOTEF", "FILIAL", e.ChangedItem.Value.ToString().ToUpper());
                    throw new Exception("CONFIGURAÇÃO ATUALIZADA PARA: " + e.ChangedItem.Value.ToString().ToUpper());
                }
                else if (e.ChangedItem.Label.Equals("PDVTEF"))
                {
                    Realsoft_INI.gravaarquivoini("CONFIGURACAOTEF", "ECF", e.ChangedItem.Value.ToString().ToUpper());
                    throw new Exception("CONFIGURAÇÃO ATUALIZADA PARA: " + e.ChangedItem.Value.ToString().ToUpper());
                }
                else if (e.ChangedItem.Label.Equals("PORTA PINPAD"))
                {
                    Realsoft_INI.gravaarquivoini("CONFIGURACAOTEF", "PORTAPINPAD", e.ChangedItem.Value.ToString().ToUpper());
                    throw new Exception("CONFIGURAÇÃO ATUALIZADA PARA: " + e.ChangedItem.Value.ToString().ToUpper());
                }
                else if (e.ChangedItem.Label.Equals("IP TEF"))
                {
                    Realsoft_INI.gravaarquivoini("CONFIGURACAOTEF", "IP", e.ChangedItem.Value.ToString().ToUpper());
                    throw new Exception("CONFIGURAÇÃO ATUALIZADA PARA: " + e.ChangedItem.Value.ToString().ToUpper());
                }
                else if (e.ChangedItem.Label.Equals("CONFIGURACAO TEF"))
                {
                    Realsoft_INI.gravaarquivoini("CONFIGURACAOTEF", "CONFIGURATEF", e.ChangedItem.Value.ToString().ToUpper());
                    throw new Exception("CONFIGURAÇÃO ATUALIZADA PARA: " + e.ChangedItem.Value.ToString().ToUpper());

                }
                else if (e.ChangedItem.Label.Equals("PADRAO TEF"))
                {
                    Realsoft_INI.gravaarquivoini("CONFIGURACAOTEF", "PADRAOTEF", e.ChangedItem.Value.ToString().ToUpper());
                    throw new Exception("CONFIGURAÇÃO ATUALIZADA PARA: " + e.ChangedItem.Value.ToString().ToUpper());
                }
                
                else
                {
                    throw new Exception("NENHUMA CONFIGURAÇÃO A SER ATUALIZADA");
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Form6 banco = new Form6();
            banco.ShowDialog();
        }
        
    }
}