using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Realsoft_DLL;

namespace Realsoft_Configurador
{
    public class __BalancaToledo
    {
        String Porta = Realsoft_INI.GetIniString(Realsoft_INI.nomeArquivoINI(), "BALANCA", "PORTACOMUNICACAO", "xxxx");
        private static SerialPort _porta = new SerialPort(Realsoft_INI.GetIniString(Realsoft_INI.nomeArquivoINI(), "BALANCA", "PORTACOMUNICACAO", ""), 0, Parity.None);
        private static String ReceberDados = "";
        private static String status = Convert.ToString(Convert.ToChar(5));
        
        private static int TaxaComunicacao = int.Parse(Realsoft_INI.GetIniString(Realsoft_INI.nomeArquivoINI(), "BALANCA", "TAXACOMUNICACAO", "xxxx"));
        private static int Ajuste = int.Parse(Realsoft_INI.GetIniString(Realsoft_INI.nomeArquivoINI(), "BALANCA", "AJUSTE", "xxxx"));

        public static void AbrePorta()
        {
            if (!_porta.IsOpen)
            {

                _porta.Open();
            }
        }

        public static void FechaPorta()
        {
            try
            {
                if (_porta.IsOpen)
                {
                    _porta.Close();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static double LerPorta()
        {
            double Peso = 0;

            String _Mensagem = "";

            try
            {
                AbrePorta();

                //System.Threading.Thread.Sleep(250);

                _porta.WriteLine(status);

                System.Threading.Thread.Sleep(100);

                String _Dados = ReceberDados;
                _Mensagem += _Dados + Environment.NewLine;
                _Dados = _Dados.Trim();
                _Dados = _Dados.Substring(1);
                _Dados = _Dados.Substring(0, _Dados.Length - 1);
         
                Peso = Double.Parse(_Dados);

                return Peso;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return Peso;
        }

        private static void RecebendoDados(System.Object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            ReceberDados = _porta.ReadExisting();
        }

        public static String Leitura()
        {
            return ReceberDados;
        }

        public static double _ObtemInformacao(int Balanca, int Campo)
        {
            try
            {
                
                Double Valor = 0;

                SerialPort _comunicacao = new SerialPort("COM4", TaxaComunicacao);

                System.Threading.Thread.Sleep(Ajuste);

                Valor = LerPorta() / 100;

                FechaPorta();

                return Valor;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }




    }
}
