using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Realsoft_Configurador
{
    public class Realsoft_BalancaToledo
    {
        [DllImport("P05.DLL")]
        public static extern int PegaPeso(int OpcaoEscrita, String Peso, String Diretorio);

        [DllImport("P05.DLL")]
        public static extern Int32 AbrePorta(int Porta, int BaudRate, int DataBits, int Paridade);

        [DllImport("P05.DLL")]
        public static extern int FechaPorta();

        public static void AbrePortaToledo()
        {
            try
            {
                int porta = int.Parse(Realsoft_INI.GetIniString(Realsoft_INI.nomeArquivoINI(), "BALANCA", "PORTACOMUNICACAO", ""));
                int _Rate = int.Parse(Realsoft_INI.GetIniString(Realsoft_INI.nomeArquivoINI(), "BALANCA", "TAXACOMUNICACAO", ""));
                int _Bits = int.Parse(Realsoft_INI.GetIniString(Realsoft_INI.nomeArquivoINI(), "BALANCA", "DATABIT", ""));
                int _Pari = int.Parse(Realsoft_INI.GetIniString(Realsoft_INI.nomeArquivoINI(), "BALANCA", "PARIDADE", ""));

                int retorno =  AbrePorta(porta, _Rate, _Bits, _Pari);


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static Double ObtemInformacao(int porta)
        {
            try
            {
                AbrePorta(porta, 4800, 8, 0);

                String Valorretorno = null;

                double valor = 0;

                int retorno = PegaPeso(1, Valorretorno, "");

                valor = double.Parse(Valorretorno);

                return valor;

                FechaPorta();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void FecharToledo()
        {
            try
            {
                int ret = FechaPorta();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }   


}
