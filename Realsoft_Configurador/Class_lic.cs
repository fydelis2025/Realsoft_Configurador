using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;


namespace RealsoftLicenca
{
    public class Extencao
    {
        
        internal struct CommandList
        {
            /// <summary>
            /// Holds the names of the commands.
            /// </summary>
            public ArrayList Captions;
            /// <summary>
            /// Holds the commands.
            /// </summary>
            public ArrayList Commands;
        }
        /// <summary>Properties of the file association.</summary>
        internal struct FileType
        {
            /// <summary>
            /// Holds the command names and the commands.
            /// </summary>
            public CommandList Commands;
            /// <summary>
            /// Holds the extension of the file type.
            /// </summary>
            public string Extension;
            /// <summary>
            /// Holds the proper name of the file type.
            /// </summary>
            public string ProperName;
            /// <summary>
            /// Holds the full name of the file type.
            /// </summary>
            public string FullName;
            /// <summary>
            /// Holds the name of the content type of the file type.
            /// </summary>
            public string ContentType;
            /// <summary>
            /// Holds the path to the resource with the icon of this file type.
            /// </summary>
            public string IconPath;
            /// <summary>
            /// Holds the icon index in the resource file.
            /// </summary>
            public short IconIndex;
        }

        public class FileAssociation
        {
            /// <summary>Initializes an instance of the FileAssociation class.</summary>
            public FileAssociation()
            {
                FileInfo = new FileType();
                FileInfo.Commands.Captions = new ArrayList();
                FileInfo.Commands.Commands = new ArrayList();
            }
            /// <summary>Gets or sets the proper name of the file type.</summary>
            /// <value>A String representing the proper name of the file type.</value>
            public string ProperName
            {
                get
                {
                    return FileInfo.ProperName;
                }
                set
                {
                    FileInfo.ProperName = value;
                }
            }
            /// <summary>Gets or sets the full name of the file type.</summary>
            /// <value>A String representing the full name of the file type.</value>
            public string FullName
            {
                get
                {
                    return FileInfo.FullName;
                }
                set
                {
                    FileInfo.FullName = value;
                }
            }
            /// <summary>Gets or sets the content type of the file type.</summary>
            /// <value>A String representing the content type of the file type.</value>
            public string ContentType
            {
                get
                {
                    return FileInfo.ContentType;
                }
                set
                {
                    FileInfo.ContentType = value;
                }
            }
            /// <summary>Gets or sets the extension of the file type.</summary>
            /// <value>A String representing the extension of the file type.</value>
            /// <remarks>If the extension doesn't start with a dot ("."), a dot is automatically added.</remarks>
            public string Extension
            {
                get
                {
                    return FileInfo.Extension;
                }
                set
                {
                    if (value.Substring(0, 1) != ".")
                        value = "." + value;
                    FileInfo.Extension = value;
                }
            }
            /// <summary>Gets or sets the index of the icon of the file type.</summary>
            /// <value>A short representing the index of the icon of the file type.</value>
            public short IconIndex
            {
                get
                {
                    return FileInfo.IconIndex;
                }
                set
                {
                    FileInfo.IconIndex = value;
                }
            }
            /// <summary>Gets or sets the path of the resource that contains the icon for the file type.</summary>
            /// <value>A String representing the path of the resource that contains the icon for the file type.</value>
            /// <remarks>This resource can be an executable or a DLL.</remarks>
            public string IconPath
            {
                get
                {
                    return FileInfo.IconPath;
                }
                set
                {
                    FileInfo.IconPath = value;
                }
            }
            /// <summary>Adds a new command to the command list.</summary>
            /// <param name="Caption">The name of the command.</param>
            /// <param name="Command">The command to execute.</param>
            /// <exceptions cref="ArgumentNullException">Caption -or- Command is null (VB.NET: Nothing).</exceptions>
            public void AddCommand(string Caption, string Command)
            {
                if (Caption == null || Command == null)
                    throw new ArgumentNullException();
                FileInfo.Commands.Captions.Add(Caption);
                FileInfo.Commands.Commands.Add(Command);
            }
            /// <summary>Creates the file association.</summary>
            /// <exceptions cref="ArgumentNullException">Extension -or- ProperName is null (VB.NET: Nothing).</exceptions>
            /// <exceptions cref="ArgumentException">Extension -or- ProperName is empty.</exceptions>
            /// <exceptions cref="SecurityException">The user does not have registry write access.</exceptions>
            public void Create()
            {
                // remove the extension to avoid incompatibilities [such as DDE links]
                try
                {
                    //Remove();
                }
                catch (ArgumentException) { } // the extension doesn't exist
                // create the exception
                if (Extension == "" || ProperName == "")
                    throw new ArgumentException();
                int cnt;
                try
                {
                    //RegistryPermission f = new RegistryPermission(RegistryPermissionAccess.Write | RegistryPermissionAccess.Read, @"HKEY_CLASSES_ROOT\AppID\{03fd7135-36bc-46ab-b773-3cfd08b2da52}");

                    RegistryKey RegKey = Registry.ClassesRoot.CreateSubKey(Extension, RegistryKeyPermissionCheck.Default);
                    RegKey.SetValue("", ProperName);
                    if (ContentType != null && ContentType != "")
                        RegKey.SetValue("Content Type", ContentType);
                    RegKey.Close();
                    RegKey = Registry.ClassesRoot.CreateSubKey(ProperName);
                    RegKey.SetValue("", FullName);
                    RegKey.Close();
                    if (IconPath != "")
                    {
                        RegKey = Registry.ClassesRoot.CreateSubKey(ProperName + "\\" + "DefaultIcon");
                        RegKey.SetValue("", IconPath + "," + IconIndex.ToString());
                        RegKey.Close();
                    }
                    for (cnt = 0; cnt < FileInfo.Commands.Captions.Count; cnt++)
                    {
                        RegKey = Registry.ClassesRoot.CreateSubKey(ProperName + "\\" + "Shell" + "\\" + (String)FileInfo.Commands.Captions[cnt]);
                        RegKey = RegKey.CreateSubKey("Command");
                        RegKey.SetValue("", FileInfo.Commands.Commands[cnt]);
                        RegKey.Close();
                    }
                }
                catch
                {
                    throw new SecurityException();
                }
            }
            /// <summary>Removes the file association.</summary>
            /// <exceptions cref="ArgumentNullException">Extension -or- ProperName is null (VB.NET: Nothing).</exceptions>
            /// <exceptions cref="ArgumentException">Extension -or- ProperName is empty -or- the specified extension doesn't exist.</exceptions>
            /// <exceptions cref="SecurityException">The user does not have registry delete access.</exceptions>
            public void Remove()
            {
                if (Extension == null || ProperName == null)
                    throw new ArgumentNullException();
                if (Extension == "" || ProperName == "")
                    throw new ArgumentException();
                Registry.ClassesRoot.DeleteSubKeyTree(Extension);
                Registry.ClassesRoot.DeleteSubKeyTree(ProperName);
            }
            /// <summary>Holds the properties of the file type.</summary>
            private FileType FileInfo;
        }



        public String LerArquivoLicenca(string Licenca)
        {
            string Valor = "";

            System.IO.StreamReader LerArquivo = new System.IO.StreamReader(AbrirArquivoLicenca());
            string Linha = LerArquivo.ReadLine();

            while (Linha != null)
            {
                if (Linha.Trim().Length > 0)
                {
                    if (Linha.IndexOf("=") > -1)
                    {
                        if (Licenca.ToString().ToUpper().Equals(Linha.Substring(0, Linha.IndexOf("="))))
                        {
                            Valor = Linha.Substring(Linha.IndexOf("=") + 1);
                        }
                    }
                }
                Linha = LerArquivo.ReadLine();
            }
            LerArquivo.Close();
            return Valor;
        }

        public System.IO.Stream AbrirArquivoLicenca()
        {
            if (!System.IO.File.Exists("Licenca.realsoft"))
            {
                System.IO.File.Create("Licenca.realsoft").Close();

                RealsoftLicenca.Extencao.FileAssociation AssociaLicenca = new FileAssociation();

                AssociaLicenca.Extension = "Realsoft";
                AssociaLicenca.ContentType = "application/Realsoft";
                AssociaLicenca.FullName = "Realsoft!";
                AssociaLicenca.ProperName = "Realsoft";
                AssociaLicenca.AddCommand("open", "Realsoft_Configurador.exe %1");
                AssociaLicenca.IconPath = Environment.CurrentDirectory + "\\logomarca.ico";
                AssociaLicenca.Create();

                //Registro reg = new Registro();

                //reg.CriarRegistroSoftware();

                Random Chave = new Random();

                int numero = Chave.Next(999999999);
                int numero1 = Chave.Next(999999999);


            }

            return System.IO.File.Open("Licenca.realsoft", System.IO.FileMode.Open);
        }

        public bool ExisteArquivoLicenca(string Campo)
        {
            bool Existe = false;


            string Linha = "";
            System.IO.StreamReader LerArquivo = new System.IO.StreamReader(AbrirArquivoLicenca());
            Linha = LerArquivo.ReadLine();
            while ((Linha != null))
            {
                if (Linha.Trim().Length > 0)
                {
                    if (Linha.IndexOf("=") > -1)
                    {
                        if (Campo.ToString().ToUpper().Equals(Linha.Substring(0, Linha.IndexOf("="))))
                        {
                            Existe = true;
                        }
                    }
                }
                Linha = LerArquivo.ReadLine();
            }
            LerArquivo.Close();
            return Existe;
        }
    }
}
