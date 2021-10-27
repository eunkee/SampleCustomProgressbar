using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleCustomProgressbar
{
    public partial class Form1 : Form
    {
        private readonly int PROGRESSBAR_MINIMUM = 0;
        private readonly int PROGRESSBAR_MAXIMUM = 100;
        private readonly int PROGRESSBAR_STEP = 1;
        private readonly int AUTO_STEP_INTERVAL = 100;

        private CancellationTokenSource cts = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar1.Minimum = PROGRESSBAR_MINIMUM;
            progressBar1.Maximum = PROGRESSBAR_MAXIMUM;
            progressBar1.Step = PROGRESSBAR_STEP;
        }

        private void SetProgressPercentage(int percent)
        {
            progressBar1.Invoke(new Action(() =>
            {
                progressBar1.Value = percent;
                progressBar1.Text = $"{percent}%";
            }));
        }

        #region Button Component

        private void ButtonIncrease_Click(object sender, EventArgs e)
        {
            ButtonStop_Click(sender, e);
            cts = new CancellationTokenSource();
            CancellationToken token = cts.Token;
            int currentValue = progressBar1.Value;
            if (currentValue < PROGRESSBAR_MAXIMUM)
            {
                var task1 = Task.Run(() =>
                {
                    try
                    {
                        while (currentValue < PROGRESSBAR_MAXIMUM)
                        {
                            currentValue += PROGRESSBAR_STEP;
                            SetProgressPercentage(currentValue);
                            Task.Delay(AUTO_STEP_INTERVAL, cts.Token).Wait();
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                });
            }
        }

        private void ButtonDecrease_Click(object sender, EventArgs e)
        {
            ButtonStop_Click(sender, e);
            cts = new CancellationTokenSource();
            CancellationToken token = cts.Token;
            int currentValue = progressBar1.Value;
            if (currentValue > PROGRESSBAR_MINIMUM)
            {
                var task1 = Task.Run(() =>
                {
                    try
                    {
                        while (currentValue > PROGRESSBAR_MINIMUM)
                        {
                            currentValue -= PROGRESSBAR_STEP;
                            SetProgressPercentage(currentValue);
                            Task.Delay(AUTO_STEP_INTERVAL, cts.Token).Wait();
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                    }
                });
            }
        }

        private void ButtonStop_Click(object sender, EventArgs e)
        {
            if (cts != null)
            {
                cts.Cancel();
                cts = null;
            }
        }

        private void ButtonPlus_Click(object sender, EventArgs e)
        {
            ButtonStop_Click(sender, e);
            int currentValue = progressBar1.Value;
            if (currentValue < PROGRESSBAR_MAXIMUM)
            {
                SetProgressPercentage(currentValue + PROGRESSBAR_STEP);
            }
        }

        private void ButtonMinus_Click(object sender, EventArgs e)
        {
            ButtonStop_Click(sender, e);
            int currentValue = progressBar1.Value;
            if (currentValue > PROGRESSBAR_MINIMUM)
            {
                SetProgressPercentage(currentValue - PROGRESSBAR_STEP);
            }
        }

        #endregion Button Component
    }
}
