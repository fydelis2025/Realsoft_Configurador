using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Realsoft_Configurador
{
    public class Realsoft_Elgin
    {
        [DllImport("Elgin.dll", CharSet = CharSet.Ansi, SetLastError = true, ExactSpelling = true)]

        public static extern short Elgin_NumeroSerie(String NumeroSerie);
    }
}
