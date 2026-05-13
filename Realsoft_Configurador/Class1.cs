using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Realsoft_Configurador
{
    public class Class1
    {
        [DllImport(@"DllToledo.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public static extern int Open(int ComNumber, int Baud, string Parity, int StopBits, int TriggerLength);

        [DllImport(@"DllToledo.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public static extern float Get();

        [DllImport(@"DllToledo.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public static extern float Close();

        [DllImport(@"DllToledo.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi)]
        public static extern int Test(int ComNumber, int Baud, string Parity, int StopBits, int TriggerLength);
    }
}
