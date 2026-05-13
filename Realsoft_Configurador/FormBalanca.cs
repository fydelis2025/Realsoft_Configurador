using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Realsoft_Class;
using Realsoft_DLL;
using System.IO.Ports;
using System.IO;

namespace Realsoft_Configurador
{
    public partial class FormBalanca : Form
    {
        public FormBalanca()
        {
            InitializeComponent();
        }

        private void FormBalanca_Load(object sender, EventArgs e)
        {
            try
            {
                clstPorts.Items.Clear();

                String[] portas = SerialPort.GetPortNames();

                for (int i = 0; i<= portas.Length -1; i++)
                {
                    clstPorts.Items.Add(portas[i]);
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void megasoftButton1_Click(object sender, EventArgs e)
        {
            try
            {

                if (ChFilizola.Checked == true)
                {
                   // Filizola.ObtemPesoBalanca(0, 0);

                    //double valor = Filizola.ObtemPesoBalanca(0, 1);

                    //LbPeso.Text = valor.ToString();
                }
                else if (ChToledo.Checked == true)
                {
                    int porta = int.Parse(clstPorts.SelectedItem.ToString().Replace("Com","").Replace("COM",""));
                    double valor = Realsoft_BalancaToledo.ObtemInformacao(porta);

                    LbPeso.Text = valor.ToString();

                }
                else if (ChAplicacao.Checked == true)
                {
                    OpenPorta(clstPorts.SelectedItem.ToString());

                    
                }
                else
                {
                    Class1.Open(int.Parse(clstPorts.SelectedItem.ToString().Replace("Com", "").Replace("COM", "")), 4800, "Even", 1, 17);

                    float Peso = Class1.Get();

                    Close();

                    Class1.Test(int.Parse(clstPorts.SelectedItem.ToString().Replace("Com", "").Replace("COM", "")), 4800, "Even", 1, 17);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        SerialPort _serialPort = new SerialPort();
        void OpenPorta(string porta)
        {
            

            if (porta != "")
            {


                try
                {
                    _serialPort.PortName = porta;
                    _serialPort.BaudRate = 2400;
                    _serialPort.Parity = Parity.None;
                    _serialPort.DataBits = 8;
                    _serialPort.StopBits = StopBits.One;
                    _serialPort.ReadTimeout = 500;
                    _serialPort.WriteTimeout = 500;
                    _serialPort.Open();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    Pede();
                }



            }

        }
        public void Pede()
        {
            try
            {

                _serialPort.Write(Convert.ToString((char)5));
                
                System.Threading.Thread.Sleep(250);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Recebe();
            }
            
        }

        private String retornovalor = "0";
       public void Recebe()
        {
            try
            {
                string ret = "";
                string ret1 = "";
                string ret2 = "";


                byte[] data = new byte[_serialPort.BytesToRead];
                _serialPort.Read(data, 0, data.Length);

                string EntradaStr = "";
                foreach (byte b in data)
                {
                    if (b <= 57)
                    {
                        if (b >= 48)
                        {
                            char Letra = Convert.ToChar(b);
                            EntradaStr = EntradaStr + Convert.ToString(Letra);
                        }
                    }
                }

                if (EntradaStr.Length > 4)
                {
                    ret = EntradaStr.Insert(EntradaStr.Length - 3, ".");

                }
                else
                {
                    retornovalor = "0";
                }

                _serialPort.Close();

                StreamWriter St = new StreamWriter("peso.txt");
				 St.Write(EntradaStr);
				 St.Close();


                if (EntradaStr != "")
                {

                     StreamReader rd = new StreamReader("peso.txt");
					 String __ret = rd.ReadLine();
					 rd.Close();

                     String result = __ret.Substring(0, 5);


                    string valor = result.Insert(result.Length - 3, ".");


                    retornovalor = valor.Replace(".", ",");
                    
                    LbPeso.Text = retornovalor.ToString();
                    
                }
                else
                {
                    MessageBox.Show("balanca zerada");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

       private void megasoftButton2_Click(object sender, EventArgs e)
       {
           
       }

       private void label1_Click(object sender, EventArgs e)
       {

       }

    }


}
