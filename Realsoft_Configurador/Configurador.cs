using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using Realsoft_Class;
using Realsoft_DLL;
using System.Collections;

namespace Realsoft_Configurador
{
   public class Configurador
    {
       private string _Skin = Realsoft_INI.GetIniString(Realsoft_INI.nomeArquivoINI(), "GERAL", "skin", "xxxxxx");       
       [Description("Skin")]
       [Category("Geral")]
       [DisplayName("SKIN")]
       public string Skin
       {
           get
           {
               return this._Skin;
           }
           set
           {
               this._Skin = value;
           }
       }

       private int _Empresa = int.Parse( Realsoft_INI.GetIniString(Realsoft_INI.nomeArquivoINI(), "GERAL", "EMPRESA", "xxxxxx"));
       [Description("EMPRESA")]
       [Category("Geral")]
       [DisplayName("EMPRESA")]
       public int Empresa
       {
           get
           {
               return this._Empresa;
           }
           set
           {
               this._Empresa = value;
           }
       }

       private int _Terminal = int.Parse(Realsoft_INI.GetIniString(Realsoft_INI.nomeArquivoINI(), "GERAL", "TERMINAL", "xxxxxx"));
       [Description("Skin")]
       [Category("Geral")]
       [DisplayName("TERMINAL")]
       public int Terminal
       {
           get
           {
               return this._Terminal;
           }
           set
           {
               this._Terminal = value;
           }
       }

       private int _ECF = int.Parse(Realsoft_INI.GetIniString(Realsoft_INI.nomeArquivoINI(), "GERAL", "ECF", "xxxxxx"));
       [Description("Skin")]
       [Category("Geral")]
       [DisplayName("ECF")]
       public int ECF
       {
           get
           {
               return this._ECF;
           }
           set
           {
               this._ECF = value;
           }
       }

       private int _INICIOCODIGOETIQUETA = int.Parse(Realsoft_INI.GetIniString(Realsoft_INI.nomeArquivoINI(), "GERAL", "INICIOCODIGOETIQUETA", "xxxxxx"));
       [Description("Skin")]
       [Category("Geral")]
       [DisplayName("INICIOCODIGOETIQUETA")]
       public int INICIOCODIGOETIQUETA
       {
           get
           {
               return this._INICIOCODIGOETIQUETA;
           }
           set
           {
               this._INICIOCODIGOETIQUETA = value;
           }
       }

       private int _FINALCODIGOETIQUETA = int.Parse(Realsoft_INI.GetIniString(Realsoft_INI.nomeArquivoINI(), "GERAL", "FINALCODIGOETIQUETA", "xxxxxx"));
       [Description("Skin")]
       [Category("Geral")]
       [DisplayName("FINALCODIGOETIQUETA")]
       public int FINALCODIGOETIQUETA
       {
           get
           {
               return this._FINALCODIGOETIQUETA;
           }
           set
           {
               this._FINALCODIGOETIQUETA = value;
           }
       }

       private int _INICIOVALORETIQUETA = int.Parse(Realsoft_INI.GetIniString(Realsoft_INI.nomeArquivoINI(), "GERAL", "INICIOVALORETIQUETA", "xxxxxx"));
       [Description("Skin")]
       [Category("Geral")]
       [DisplayName("INICIOVALORETIQUETA")]
       public int INICIOVALORETIQUETA
       {
           get
           {
               return this._INICIOVALORETIQUETA;
           }
           set
           {
               this._INICIOVALORETIQUETA = value;
           }
       }

       private int _FINALVALORETIQUETA = int.Parse(Realsoft_INI.GetIniString(Realsoft_INI.nomeArquivoINI(), "GERAL", "FINALVALORETIQUETA", "xxxxxx"));
       [Description("Skin")]
       [Category("Geral")]
       [DisplayName("FINALVALORETIQUETA")]
       public int FINALVALORETIQUETA
       {
           get
           {
               return this._FINALVALORETIQUETA;
           }
           set
           {
               this._FINALVALORETIQUETA = value;
           }
       }

       private Boolean _ARREDONDAMENTO = Boolean.Parse(Realsoft_INI.GetIniString(Realsoft_INI.nomeArquivoINI(), "GERAL", "ARREDONDAMENTO", "xxxxxx"));
       [Description("Skin")]
       [Category("Geral")]
       [DisplayName("ARREDONDAMENTO")]
       public Boolean ARREDONDAMENTO
       {
           get
           {
               return this._ARREDONDAMENTO;
           }
           set
           {
               this._ARREDONDAMENTO = value;
           }
       }

       private string _CaminhoPublicidade = Realsoft_INI.GetIniString(Realsoft_INI.nomeArquivoINI(), "GERAL", "CaminhoPublicidade", "xxxxxx");
       [Description("Skin")]
       [Category("Geral")]
       [DisplayName("CAMINHO PUBLICIDADE")]
       public string CaminhoPublicidade
       {
           get
           {
               return this._CaminhoPublicidade;
           }
           set
           {
               this._CaminhoPublicidade = value;
           }
       }

       private string _IPSERVIDOR = Realsoft_INI.GetIniString(Realsoft_INI.nomeArquivoINI(), "GERAL", "IPSERVIDOR", "xxxxxx");
       [Description("Skin")]
       [Category("Geral")]
       [DisplayName("IPSERVIDOR")]
       public string IPSERVIDOR
       {
           get
           {
               return this._IPSERVIDOR;
           }
           set
           {
               this._IPSERVIDOR = value;
           }
       }

       private string _PORTACONEXAO = Realsoft_INI.GetIniString(Realsoft_INI.nomeArquivoINI(), "GERAL", "PORTACONEXAO", "xxxxxx");
       [Description("Skin")]
       [Category("Geral")]
       [DisplayName("PORTACONEXAO")]
       public string PORTACONEXAO
       {
           get
           {
               return this._PORTACONEXAO;
           }
           set
           {
               this._PORTACONEXAO = value;
           }
       }

       private Boolean _HABILITARMODULOPREVENDA = Boolean.Parse(Realsoft_INI.GetIniString(Realsoft_INI.nomeArquivoINI(), "GERAL", "HABILITARMODULOPREVENDA", "xxxxxx"));
       [Description("Skin")]
       [Category("Geral")]
       [DisplayName("HABILITARMODULOPREVENDA")]
       public Boolean HABILITARMODULOPREVENDA
       {
           get
           {
               return this._HABILITARMODULOPREVENDA;
           }
           set
           {
               this._HABILITARMODULOPREVENDA = value;
           }
       }

       private Boolean _SOLICITARSENHAABERTURAGAVETA = Boolean.Parse(Realsoft_INI.GetIniString(Realsoft_INI.nomeArquivoINI(), "GERAL", "SOLICITARSENHAABERTURAGAVETA", "xxxxxx"));
       [Description("Skin")]
       [Category("Geral")]
       [DisplayName("SOLICITARSENHAABERTURAGAVETA")]
       public Boolean SOLICITARSENHAABERTURAGAVETA
       {
           get
           {
               return this._SOLICITARSENHAABERTURAGAVETA;
           }
           set
           {
               this._SOLICITARSENHAABERTURAGAVETA = value;
           }
       }

       private Boolean _CLIENTESERVIDOR = Boolean.Parse(Realsoft_INI.GetIniString(Realsoft_INI.nomeArquivoINI(), "GERAL", "CLIENTESERVIDOR", "xxxxxx"));
       [Description("Skin")]
       [Category("Geral")]
       [DisplayName("CLIENTESERVIDOR")]
       public Boolean CLIENTESERVIDOR
       {
           get
           {
               return this._CLIENTESERVIDOR;
           }
           set
           {
               this._CLIENTESERVIDOR = value;
           }
       }

       private Boolean _HABILITARNFCE = Boolean.Parse(Realsoft_INI.GetIniString(Realsoft_INI.nomeArquivoINI(), "GERAL", "HABILITARNFCE", "xxxxxx"));
       [Description("Skin")]
       [Category("Geral")]
       [DisplayName("HABILITARNFCE")]
       public Boolean HABILITARNFCE
       {
           get
           {
               return this._HABILITARNFCE;
           }
           set
           {
               this._HABILITARNFCE = value;
           }
       }

       private Boolean _BALANCAPORPESO = Boolean.Parse(Realsoft_INI.GetIniString(Realsoft_INI.nomeArquivoINI(), "GERAL", "BALANCAPORPESO", "xxxxxx"));
       [Description("Skin")]
       [Category("Geral")]
       [DisplayName("BALANCAPORPESO")]
       public Boolean BALANCAPORPESO
       {
           get
           {
               return this._BALANCAPORPESO;
           }
           set
           {
               this._BALANCAPORPESO = value;
           }
       }
       private string _NomeBanco;
       [Description("Conexao")]
       [Category("Conexao")]
       [DisplayName("NOME BANCO")]
       public string NomeBanco
       {
           get
           {
               return this._NomeBanco;
           }
           set
           {
               this._NomeBanco = value;
           }
       }

       private string _UsuarioBanco;
       [Description("Conexao")]
       [Category("Conexao")]
       [DisplayName("USUARIO BANCO")]
       public string UsuarioBanco
       {
           get
           {
               return this._UsuarioBanco;
           }
           set
           {
               this._UsuarioBanco = value;
           }
       }

       private string _SenhaBanco;
       [Description("Conexao")]
       [Category("Conexao")]
       [DisplayName("SENHA BANCO")]
       public string SenhaBanco
       {
           get
           {
               return this._SenhaBanco;
           }
           set
           {
               this._SenhaBanco = value;
           }
       }

       private string _Retaguarda = Realsoft_Criptografia.Decrypt(Realsoft_INI.GetIniString(Realsoft_INI.nomeArquivoINI(), "SERVIDOR", "SQL", ""), Realsoft_Sistema.passPhrase, Realsoft_Sistema.saltValue, Realsoft_Sistema.hashAlgorithm, Realsoft_Sistema._interacao, Realsoft_Sistema._initvector, Realsoft_Sistema.keySize);
       [Description("Conexao")]
       [Category("Conexao")]
       [DisplayName("ENDERECO RETAGUARDA")]
       public string Retaguarda
       {
           get
           {
               return this._Retaguarda;
           }
           set
           {
               this._Retaguarda = value;
           }
       }

       private string _Caixa = Realsoft_Criptografia.Decrypt(Realsoft_INI.GetIniString(Realsoft_INI.nomeArquivoINI(), "CONEXAO", "MYSQL", ""), Realsoft_Sistema.passPhrase, Realsoft_Sistema.saltValue, Realsoft_Sistema.hashAlgorithm, Realsoft_Sistema._interacao, Realsoft_Sistema._initvector, Realsoft_Sistema.keySize);
       [Description("Conexao")]
       [Category("Conexao")]
       [DisplayName("ENDERECO CAIXA")]
       public string Caixa
       {
           get
           {
               return this._Caixa;
           }
           set
           {
               this._Caixa = value;
           }
       }

       private string _MARCAIMPRESSORA = Realsoft_INI.GetIniString(Realsoft_INI.nomeArquivoINI(), "IMPRESSORA", "MARCAIMPRESSORA", "xxxxxx");
       [Description("IMPRESSORA")]
       [Category("IMPRESSORA")]
       [DisplayName("MARCAIMPRESSORA")]
       public string MARCAIMPRESSORA
       {
           get
           {
               return this._MARCAIMPRESSORA;
           }
           set
           {
               this._MARCAIMPRESSORA = value;
           }
       }

       private string _MODOIMPRESSAO = Realsoft_INI.GetIniString(Realsoft_INI.nomeArquivoINI(), "IMPRESSORA", "MODOIMPRESSAO", "xxxxxx");
       [Description("IMPRESSORA")]
       [Category("IMPRESSORA")]
       [DisplayName("MODOIMPRESSAO")]
       public string MODOIMPRESSAO
       {
           get
           {
               return this._MODOIMPRESSAO;
           }
           set
           {
               this._MODOIMPRESSAO = value;
           }
       }

       private string _PORTACOMUNICACAO = Realsoft_INI.GetIniString(Realsoft_INI.nomeArquivoINI(), "IMPRESSORA", "PORTACOMUNICACAO", "xxxxxx");
       [Description("IMPRESSORA")]
       [Category("IMPRESSORA")]
       [DisplayName("PORTACOMUNICACAO")]
       public string PORTACOMUNICACAO
       {
           get
           {
               return this._PORTACOMUNICACAO;
           }
           set
           {
               this._PORTACOMUNICACAO = value;
           }
       }


       private string _EmpresaTEF = Realsoft_INI.GetIniString(Realsoft_INI.nomeArquivoINI(), "CONFIGURACAOTEF", "LOJA", "xxxxxx");
       [Description("ConfiguraçãoTEF")]
       [Category("ConfiguraçãoTEF")]
       [DisplayName("EMPRESATEF")]
       public string EmpresaTEF
       {
           get
           {
               return this._EmpresaTEF;
           }
           set
           {
               this._EmpresaTEF = value;
           }
       }


       private string _Filial = Realsoft_INI.GetIniString(Realsoft_INI.nomeArquivoINI(), "CONFIGURACAOTEF", "FILIAL", "xxxxxx");
       [Description("ConfiguraçãoTEF")]
       [Category("ConfiguraçãoTEF")]
       [DisplayName("FILIALTEF")]
       public string Filial
       {
           get
           {
               return this._Filial;
           }
           set
           {
               this._Filial = value;
           }
       }

       private string _PDV = Realsoft_INI.GetIniString(Realsoft_INI.nomeArquivoINI(), "CONFIGURACAOTEF", "ECF", "xxxxxx");
       [Description("ConfiguraçãoTEF")]
       [Category("ConfiguraçãoTEF")]
       [DisplayName("PDVTEF")]
       public string PDV
       {
           get
           {
               return this._PDV;
           }
           set
           {
               this._PDV = value;
           }
       }

       private string _PortaPinpad = Realsoft_INI.GetIniString(Realsoft_INI.nomeArquivoINI(), "CONFIGURACAOTEF", "PORTAPINPAD", "xxxxxx");
       [Description("ConfiguraçãoTEF")]
       [Category("ConfiguraçãoTEF")]
       [DisplayName("PORTA PINPAD")]
       public string PortaPinpad
       {
           get
           {
               return this._PortaPinpad;
           }
           set
           {
               this._PortaPinpad = value;
           }
       }

       private string _IpTef = Realsoft_INI.GetIniString(Realsoft_INI.nomeArquivoINI(), "CONFIGURACAOTEF", "IP", "xxxxxx");
       [Description("ConfiguraçãoTEF")]
       [Category("ConfiguraçãoTEF")]
       [DisplayName("IP TEF")]
       public string IpTef
       {
           get
           {
               return this._IpTef;
           }
           set
           {
               this._IpTef = value;
           }
       }

       private string _ConfgTef = Realsoft_INI.GetIniString(Realsoft_INI.nomeArquivoINI(), "CONFIGURACAOTEF", "CONFIGURATEF", "xxxxxx");
       [Description("ConfiguraçãoTEF")]
       [Category("ConfiguraçãoTEF")]
       [DisplayName("CONFIGURACAO TEF")]
       public string ConfgTef
       {
           get
           {
               return this._ConfgTef;
           }
           set
           {
               this._ConfgTef = value;
           }
       }

       private string _padraoTEF = Realsoft_INI.GetIniString(Realsoft_INI.nomeArquivoINI(), "CONFIGURACAOTEF", "PADRAOTEF", "xxxxxx");
       [Description("ConfiguraçãoTEF")]
       [Category("ConfiguraçãoTEF")]
       [DisplayName("PADRAO TEF")]
       public string padraoTEF
       {
           get
           {
               return this._padraoTEF;
           }
           set
           {
               this._padraoTEF = value;
           }
       }
       
       private string _Marca = Realsoft_INI.GetIniString(Realsoft_INI.nomeArquivoINI(), "BALANCA", "MARCA", "");
       [Description("Balança")]
       [Category("Balança")]
       [DisplayName("MARCABAL")]
       public string Marca
       {
           get
           {
               return this._Marca;
           }
           set
           {
               this._Marca = value;
           }
       }

       private string _Modelo = Realsoft_INI.GetIniString(Realsoft_INI.nomeArquivoINI(), "BALANCA", "MODELOBALANCA", "");
       [Description("Balança")]
       [Category("Balança")]
       [DisplayName("MODELOBAL")]
       public string Modelo
       {
           get
           {
               return this._Modelo;
           }
           set
           {
               this._Modelo = value;
           }
       }

       private int _TaxaComunicacao = int.Parse(Realsoft_INI.GetIniString(Realsoft_INI.nomeArquivoINI(), "BALANCA", "TAXACOMUNICACAO", ""));
       [Description("Balança")]
       [Category("Balança")]
       [DisplayName("TAXABAL")]
       public int TaxaComunicacao
       {
           get
           {
               return this._TaxaComunicacao;
           }
           set
           {
               this._TaxaComunicacao = value;
           }
       }

       private string _Porta = Realsoft_INI.GetIniString(Realsoft_INI.nomeArquivoINI(), "BALANCA", "PORTACOMUNICACAO", "");
       [Description("Balança")]
       [Category("Balança")]
       [DisplayName("PORTABAL")]
       public string Porta
       {
           get
           {
               return this._Porta;
           }
           set
           {
               this._Porta = value;
           }
       }

       private string _Ajuste = Realsoft_INI.GetIniString(Realsoft_INI.nomeArquivoINI(), "BALANCA", "AJUSTE", "");
       [Description("Balança")]
       [Category("Balança")]
       [DisplayName("AJUSTEBAL")]
       public string Ajuste
       {
           get
           {
               return this._Ajuste;
           }
           set
           {
               this._Ajuste = value;
           }
       }

       private string _ChavePublica = Realsoft_INI.GetIniString(Realsoft_INI.nomeArquivoINI(), "PafEcf", "chavepublica", "xxxxxx");
       [Description("PAFECF")]
       [Category("PAFECF")]
       [DisplayName("Chave Publica")]
       public string ChavePublica
       {
           get
           {
               return this._ChavePublica;
           }
           set
           {
               this._ChavePublica = value;
           }
       }

       private string _ChavePrivada = Realsoft_INI.GetIniString(Realsoft_INI.nomeArquivoINI(), "PafEcf", "chaveprivada", "xxxxxx");
       [Description("PAFECF")]
       [Category("PAFECF")]
       [DisplayName("Chave Privada")]
       public string ChavePrivada
       {
           get
           {
               return this._ChavePrivada;
           }
           set
           {
               this._ChavePrivada = value;
           }
       }

       private ArrayList _EXIBE = ArrayList.Adapter(System.IO.Directory.GetFiles(Environment.CurrentDirectory));
       [Description("Arquivos")]
       [Category("Arquivos")]
       [DisplayName("EXIBE")]
       public ArrayList EXIBE
       {
           get
           {
               return this._EXIBE;
           }
           set
           {
               this._EXIBE = value;
           }
       }

       private System.Drawing.Bitmap _IMG = new System.Drawing.Bitmap(800,600);
       [Description("BACKGROUD")]
       [Category("BACKGROUD")]
       [DisplayName("IMAGEM")]
       public System.Drawing.Bitmap IMG
       {
           get
           {
               return this._IMG;
           }
           set
           {
               this._IMG = value;
           }
       }

       private System.Drawing.Color _Color = new System.Drawing.Color();
       [Description("BACKGROUD")]
       [Category("BACKGROUD")]
       [DisplayName("COLOR")]
       public System.Drawing.Color Color
       {
           get
           {
               return this._Color;
           }
           set
           {
               this._Color = value;
           }
       }

       private System.Drawing.Size _Size = new System.Drawing.Size();
       [Description("BACKGROUD")]
       [Category("BACKGROUD")]
       [DisplayName("SIZE")]
       public System.Drawing.Size Size
       {
           get
           {
               return this._Size;
           }
           set
           {
               this._Size = value;
           }
       }

       private System.Windows.Forms.Form _Form = new System.Windows.Forms.Form();
       [Description("FORM")]
       [Category("FORM")]
       [DisplayName("CRIAR")]
       public System.Windows.Forms.Form Form
       {
           get
           {
               return this._Form;
           }
           set
           {
               this._Form = value;
           }
       }

    }
}
