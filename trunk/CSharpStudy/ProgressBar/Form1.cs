using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Reflection;
using System.Threading.Tasks;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private static ManualResetEvent Event = new ManualResetEvent(true);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // RunWorkerAsyncが呼び出された時に発生
            backgroundWorkerRun.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);

            // BackgroundWorkerでの処理が完了した時に発生
            backgroundWorkerRun.RunWorkerCompleted +=
                new RunWorkerCompletedEventHandler(backgroundWorker1_RunWorkerCompleted);

            backgroundWorkerRun.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker1_ProgressChanged);

            // キャンセルされることを許可
            backgroundWorkerRun.WorkerSupportsCancellation = true;
        }

        void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = (BackgroundWorker)sender;

            //for (int i = 1; (i <= 20); i++)
            //{
            //    if ((worker.CancellationPending == true))
            //    {
            //        e.Cancel = true;
            //        break;
            //    }
            //    else
            //    {
            //        // Perform a time consuming operation and report progress.
            //        System.Threading.Thread.Sleep(500);
            //        worker.ReportProgress((i * 100 / 20));
            //    }
            //}
            var list = new List<string>();
            for (int i = 0; i < 10; i++)
            {
                list.Add("Yahoo" + i);
                list.Add("Google" + i);
                list.Add("Micrisoft" + i);
            }

            int j = 0;
            Parallel.ForEach(
                list,
                new ParallelOptions { MaxDegreeOfParallelism = 5 },
                (elem, loopState) =>
                {
                    if ((worker.CancellationPending == true))
                    {
                        e.Cancel = true;
                        loopState.Break();
                    }

                    Thread.Sleep(500);
                    worker.ReportProgress((j * 100 / list.Count));
                    j++;
                    Event.WaitOne();
                }
            );
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if ((e.Cancelled == true))
            {
                this.toolStripStatusLabel1.Text = "Canceled!";
            }

            else if (!(e.Error == null))
            {
                this.toolStripStatusLabel1.Text = ("Error: " + e.Error.Message);
            }

            else
            {
                this.toolStripProgressBar1.Value = 100;
                this.toolStripStatusLabel1.Text = "Done!";
            }
            button1.Enabled = true;
            button2.Enabled = true;
        }
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.toolStripStatusLabel1.Text = (e.ProgressPercentage.ToString() + "%");
            this.toolStripProgressBar1.Value = e.ProgressPercentage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            if (!backgroundWorkerRun.IsBusy)
            {
                // バックグラウンド処理を開始
                backgroundWorkerRun.RunWorkerAsync();
            }
            button1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text.ToString().CompareTo("Cancel") == 0)
            {
                Event.Reset();
                button2.Text = "Resume";
            }
            else if (button2.Text.ToString().CompareTo("Cancel") != 0)
            {
                Event.Set();
                button2.Text = "Cancel";
            }

            // 処理をキャンセルします
            //backgroundWorkerRun.CancelAsync();
            //if (backgroundWorkerRun.IsBusy)
            //{
            //    button2.Enabled = false;
            //}
        }
    }
}