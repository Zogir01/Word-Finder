using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Pipes;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Word_Finder
{
    public class PythonProcess
    {
        private Process process;
        private ProgressBar progressBar;
        private Label label;

        public PythonProcess(ProgressBar progressBar, Label label)
        {
            this.progressBar = progressBar;
            this.label = label;
            this.process = new Process();

            Thread progressBarThread = new Thread(generateProgressBar);
            Thread outputDataThread = new Thread(receiveDataFromPython);

            outputDataThread.Start();
            progressBarThread.Start();
        }
        public void start(EventHandler onExit = null)
        {
            var psi = new ProcessStartInfo
            {
                FileName = "python.exe",
                Arguments = "main.py",
                UseShellExecute = false,
                CreateNoWindow = true,
                RedirectStandardOutput = false, // I'm using pipes to catch the data from python
                RedirectStandardError = false // method with RedirectStandardOutput/Error is also good
            };

            process.StartInfo = psi;
            process.EnableRaisingEvents = true;

            if(onExit != null ) {
                process.Exited += onExit;
            }

            process.Start();
        }
        public void stop()
        {
            process.Kill();
        }

        private void receiveDataFromPython()
        {
            //read data from pipeClient where python script send output data
            NamedPipeClientStream pipeClient = new NamedPipeClientStream(".", "OutputData", PipeDirection.InOut);

            // waiting for connection from python
            pipeClient.Connect(); 

            StreamReader sr = new StreamReader(pipeClient);
            while (pipeClient.IsConnected)
            {
                try
                {
                    string OutputData = sr.ReadLine();
                    if (!string.IsNullOrEmpty(OutputData))
                    {
                        label.Invoke(new Action(() => label.Text = OutputData));
                    }
                }
                catch (EndOfStreamException)
                {
                    break;
                }
            }
        }
        private void generateProgressBar()
        {
            progressBar.Invoke(new Action(() => progressBar.Minimum = 0));

            //read data from pipeClient where python script send info about progress
            NamedPipeClientStream pipeClient = new NamedPipeClientStream(".", "ProgressBarInfo", PipeDirection.InOut);

            // waiting for connection from python
            pipeClient.Connect(); 

            StreamReader sr = new StreamReader(pipeClient);

            string imgs_length = sr.ReadLine();
            if (!string.IsNullOrEmpty(imgs_length))
            {
                progressBar.Invoke(new Action(() => progressBar.Maximum = int.Parse(imgs_length)));
            }

            while (pipeClient.IsConnected)
            {
                try
                {
                    string imgs_counter = sr.ReadLine();
                    if (!string.IsNullOrEmpty(imgs_counter))
                    {
                        progressBar.Invoke(new Action(() => progressBar.Value = int.Parse(imgs_counter)));
                    }
                }
                catch (EndOfStreamException)
                {
                    progressBar.Invoke(new Action(() => progressBar.Value = 0));
                    break;
                }
            }
        }
    }
}
