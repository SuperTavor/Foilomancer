using SharpAdbClient;
using SharpAdbClient.DeviceCommands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FoilomancerGUI
{
    public partial class packForm : Form
    {
       

        public packForm()
        {
            InitializeComponent();

        }

        private void packMenutitleLabel_Click(object sender, EventArgs e)
        {

        }

        private void chooseFileBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = "YKW1M Split APKs (*.apk)|*.apk";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = openFileDialog.FileName;
                    string selectedFileName = Path.GetFileName(selectedFilePath);
                    splitApkName.Text = selectedFileName + " selected.";
                }
            }
        }


        private void modNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void packModTitleLabel_Click(object sender, EventArgs e)
        {

        }

        private void modVersionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private async void packModBtn_Click(object sender, EventArgs e)
        {
            int readyForChecks = 0;
            if (string.IsNullOrEmpty(modNameTextBox.Text))
            {
                MessageBox.Show("Please fill out your mod name.");
            }
            else
            {
                readyForChecks += 1;
                if(readyForChecks == 2)
                {
                    await RunBatchScriptAsync();
                }
                
            }
            if (string.IsNullOrEmpty(modVersionTextBox.Text))
            {
                MessageBox.Show("Please fill out your mod version.");
            }
            else
            {
                readyForChecks += 1;
                if (readyForChecks == 2)
                {
                    await RunBatchScriptAsync();
                }
            }
            
        }

        private async Task RunBatchScriptAsync()
        {
            string currentDirectory = Environment.CurrentDirectory;
            string subdirectory = "tools"; 

            string command = "checkDevices.bat";
            string batchFilePath = Path.Combine(currentDirectory, subdirectory, command);

            ProcessStartInfo processStartInfo = new ProcessStartInfo
            {
                FileName = batchFilePath,
                WorkingDirectory = Path.Combine(currentDirectory, subdirectory),
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            Process process = new Process { StartInfo = processStartInfo };
            process.Start();

            string output = await process.StandardOutput.ReadToEndAsync();
            string error = await process.StandardError.ReadToEndAsync();

            process.WaitForExit();
            output = output.Trim();
            if (output == "No devices")
            {
                output = "A device with Yo-Kai Watch 1 For Smartphone is required for packing your mod, so Foilomancer can extract critical files from your copy. Please make sure you have an Android device connected via USB with USB Debugging enabled. If you don't know what any of this means, Please check the How to use menu.";
            }
            else
            {
                MessageBox.Show("Found device");
                await extractFromDevice();
            }
            
        }

        private async Task extractFromDevice()
        {
            string currentDirectory = Environment.CurrentDirectory;
            string subdirectory = "tools";
            string extractYkw1mBatchName = "extractFromDevice.bat";
            string scriptFilePath = Path.Combine(currentDirectory, subdirectory, extractYkw1mBatchName);

            ProcessStartInfo extractStartInfo = new ProcessStartInfo
            {
                FileName = scriptFilePath,
                WorkingDirectory = Path.Combine(currentDirectory, subdirectory),
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            Process processA = new Process { StartInfo = extractStartInfo };
            processA.Start();
            
            string outputA = await processA.StandardOutput.ReadToEndAsync();
            string errorA = await processA.StandardError.ReadToEndAsync();

            processA.WaitForExit();
            MessageBox.Show(outputA);
        }
    }
}


    

