using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bitrate_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_InsertFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog(); //opens dialog box and filters files that have .json extension 
                dlg.DefaultExt = ".json";
                dlg.Filter = "JSON Files (*.json)|*.json";
                DialogResult result = dlg.ShowDialog();

                if (result == DialogResult.OK) //If a .json file is selected the condition is valid
                {
                    string fileName = dlg.FileName;
                    var jsonData = "";

                    using (var reader = new StreamReader(fileName)) //reads the data from the JSON file
                    {
                        jsonData = reader.ReadToEnd();
                    }
                    var parsedJsonData = JsonConvert.DeserializeObject<Data>(jsonData); //deserializing and parsing the JSON file so it can be manipulated 

                    if (parsedJsonData != null)
                    {
                        DisplayData(parsedJsonData);
                        long txResult = CalculateBitRate(parsedJsonData.NIC[0].Tx); //Calculating transmitted bytes/second
                        long rxResult = CalculateBitRate(parsedJsonData.NIC[0].Rx); //Calculating recieved bytes/second

                        rtb_Bitrate.Text = "Tx: " + txResult.ToString() + " MB/s\n"
                                         + "Rx: " + rxResult.ToString() + " MB/s\n"; //Result is provided in the appropriate textBox 

                        if (rtb_Bitrate.Text != "")
                        {
                            BitrateOutputWriter(txResult.ToString(), rxResult.ToString()); //Creates a output json file
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DisplayData(Data data) //Function that fills the textbox with the data that is parsed from the JSON file
        {
            for (int i = 0; i < data.NIC.Count; i++)
            {
                rtb_ParsedData.Text = "Device: " + data.Device 
                    + "\nModel:" + data.Model 
                    + "\nNIC:" 
                    + "\nDescription: " + data.NIC[i].Description 
                    + "\nMAC: " + data.NIC[i].MAC 
                    + "\nTimesamp: " + data.NIC[i].Timestamp
                    + "\nRx: " + data.NIC[i].Rx 
                    + "\nTx: " + data.NIC[i].Tx;
            }
        }

        private long CalculateBitRate(long number) //Function that calculates Rx/Tx by multiplying Rx/Tx with the polling rate
        {
            long pollingRate = 2; //2 represents the polling rate of 2Hz
            return (number * pollingRate) / 1000000; //returning the bitrate in MB/s form
        }

        private void BitrateOutputWriter(string tx, string rx) //creates a new json file which contains the Tx and Rx speeds
        {
            JsonOutput result = new JsonOutput();
            result.TxResult = tx + " MB/s";
            result.RxResult = rx + " MB/s";

            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Output.json");
            string json = JsonConvert.SerializeObject(result, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }
    }
}
