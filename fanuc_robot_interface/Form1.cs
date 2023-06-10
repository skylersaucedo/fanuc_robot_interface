using System.Diagnostics;
using System;
using System.IO.Ports;

namespace fanuc_robot_interface
{
    public partial class Form1 : Form
    {

        SerialPort port;
        String[] ports;

        bool isConnectedToFeather = false;
        bool isConnectedToLaser = false;
        bool isConnectedToCams = false;

        public Form1()
        {
            InitializeComponent();

            btnToggleLight.Enabled = false;

            getAvailableComPorts();

            foreach (string port in ports)
            {
                cmbxCOMS.Items.Add(port);
                Console.WriteLine(port);
                if (ports[0] != null)
                {
                    cmbxCOMS.SelectedItem = ports[0];
                }
            }

        }

        public void getAvailableComPorts()
        {
            //
            ports = SerialPort.GetPortNames();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            var errors = "NA";

            try
            {
                // process start python script here
                ProcessStartInfo psi = new ProcessStartInfo();

                psi.FileName = @"C:\Users\sauce\miniconda3\envs\pytorch-gpu\python.exe"; //pytorch with opencv path

                Console.WriteLine("spooling up camera");
                string pythonScriptPath = @"C:\Users\sauce\OneDrive\Desktop\arducam\ArduCAM_USB_Camera_Shield-master\Windows\Python\Streaming_demo\ArduCam_Py_Demo.py";
                string configPath = @"C:\Users\sauce\OneDrive\Desktop\AR1820_MIPI_4Lane_RAW10_8b_4912x3684_80MHz_2fps.cfg"; // config path
                psi.Arguments = $"\"{pythonScriptPath}\" \"{configPath}";

                // process config

                psi.UseShellExecute = false;
                psi.CreateNoWindow = true;
                psi.RedirectStandardOutput = true;
                psi.RedirectStandardError = true;

                // execute process and get output

                Console.WriteLine("whats up");
                lblConnectToCam.Text = "CONNECTED!";


                using( var p = System.Diagnostics.Process.Start(psi))
                {
                    errors = p.StandardError.ReadToEnd();
                }
            }

            //catch (System.Exception e)
            //{
            //    MessageBox.Show("Error: " + e.Message);
            //    Environment.Exit(1);
            //}

            catch
            {
                MessageBox.Show("you have an error");
            }

            MessageBox.Show("all done.");
            MessageBox.Show("errors" + errors.ToString());

        }

        public void btnConnectToLaser_Click(object sender, EventArgs e)
        {
            //
            MessageBox.Show("connecting to laser");

            // simulate connection

            lblLaserVal.Text = "CONNECTED!";

            // make random values 




        }

        private void lblLaserVal_Click(object sender, EventArgs e)
        {
            //oops.
        }

        private void btnToggleLight_Click(object sender, EventArgs e)
        {
            //turn lights on


        }

        public void connectToFeather()
        {
            string selectedPort = cmbxCOMS.GetItemText(cmbxCOMS.SelectedItem);
            port = new SerialPort(selectedPort, 9600, Parity.None, 8, StopBits.One);
            port.Open();
            isConnectedToFeather = true;
        }

        private void btnConnectToFeather_Click(object sender, EventArgs e)
        {

            try
            {
                // add serial connection code here.

                connectToFeather();

                MessageBox.Show("connected to lights!");

                btnToggleLight.Enabled = true;
                lblConnectToLights.Text = "CONNECTED!";
            }

            catch (Exception m)
            {
                MessageBox.Show("unable to connect to lights..." + m.Message);
            }

            finally
            {
                //yep
            }

        }

        private void btnConnectToRobot_Click(object sender, EventArgs e)
        {
            // add connection code from RoboDK. 

            MessageBox.Show("connected to robot!");

            lblRobotStatus.Text = "CONNECTED!";
        }
    }
}