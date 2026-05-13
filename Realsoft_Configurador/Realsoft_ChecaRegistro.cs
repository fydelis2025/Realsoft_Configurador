using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Realsoft_Configurador
{
    public class Realsoft_ChecaRegistro
    {
        public static string Realsoft_ChecarRetorno(String Chave)
        {
            String __chave = null;

            string[] arg = new string[] { "2015RSEFEB1730FE92BR", "2015RSEFEB1740FE93BR", "2015RSEFEB1750FE94BR" };

            for (int i = 0; i <= arg.Length -1; i++ )
            {
                if(Chave == arg[i])
                {
                    __chave = arg[i];
                }
            }
            return __chave;
        }
    }
}
