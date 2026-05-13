using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Security.Permissions;

namespace Realsoft_Configurador
{
    public class CriaRegistro
    {
        Random CriaChaveRegistro = new Random();
        
        

        private int _ChaveRegistro;
        private int _ChaveRegistro1;
        private int _SoftwareAutorizado = 0;
        private bool _Autorizado = false;
        public static string IRetorno;
        public static string IRetorno1;
        public static DateTime _DataRegistro;
        public static DateTime _ValidadeSoftware;
        RegistryKey _criarreg = Registry.LocalMachine.OpenSubKey("Software", RegistryKeyPermissionCheck.Default);

        public virtual void CriarRegistroSoftware()
        {
            try
            {
                _criarreg = _criarreg.CreateSubKey("Realsoft");


                _ChaveRegistro = CriaChaveRegistro.Next(0, 999999999);
                _ChaveRegistro1 = CriaChaveRegistro.Next(0, 999999999);

                decimal peso = decimal.Truncate(decimal.Multiply(decimal.Parse(_ChaveRegistro.ToString()), decimal.Parse(_ChaveRegistro1.ToString())));

                _criarreg.SetValue("ChaveRegistro", peso.ToString().TrimStart('0'));

                _criarreg.SetValue("DataRegistro", DateTime.Now);

                _criarreg.SetValue("ValidoAte", DateTime.Now.AddDays(90));

                _criarreg.SetValue("SoftwareAutorizado", _SoftwareAutorizado.ToString());

                //_criarreg.SetValue("DataAutorizado", DateTime.Now);

                _criarreg.SetValue("Autorizado", _Autorizado);

                _criarreg.Close();
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public virtual void LerRegistroSoftware()
        {
            try
            {
                RegistryKey _criarreg = Registry.LocalMachine.OpenSubKey("Software", RegistryKeyPermissionCheck.Default);

                IRetorno = _criarreg.OpenSubKey("Realsoft", true).GetValue("ChaveRegistro").ToString();

                _DataRegistro = DateTime.Parse(_criarreg.OpenSubKey("Realsoft", true).GetValue("DataRegistro").ToString());

                IRetorno1 = _criarreg.OpenSubKey("Realsoft", true).GetValue("SoftwareAutorizado").ToString();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public virtual void ValidadeSoftware()
        {
            try
            {
                RegistryKey _criarreg = Registry.LocalMachine.OpenSubKey("Software", RegistryKeyPermissionCheck.Default);

                _ValidadeSoftware = DateTime.Parse(_criarreg.OpenSubKey("Realsoft", true).GetValue("ValidoAte").ToString());
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
