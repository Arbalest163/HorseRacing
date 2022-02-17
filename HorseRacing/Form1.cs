using DancingBar;
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

namespace HorseRacing
{
    public partial class Form1 : Form
    {
        private CancellationTokenSource? _cancellationTokenSource;
        private IEnumerable<Control> _listProgressBar;

        public Form1()
        {
            InitializeComponent();
            _listProgressBar = this.Controls.OfType<Control>().Where(p => p is CustomProgressBar);
        }

        private async void buttonRun_Click(object sender, EventArgs e)
        {
            buttonRun.Enabled = false;
            _cancellationTokenSource = new CancellationTokenSource();
            await RunDanceAsync(_cancellationTokenSource.Token);
            buttonRun.Enabled = true;
        }

        private async Task RunDanceAsync(CancellationToken cancellationToken = default)
        {
            var listTask = new List<Task>();

            foreach (CustomProgressBar item in _listProgressBar)
            {
                var rnd = new Random();
                int speed = rnd.Next(40, 101);
                listTask.Add(ChangeProgressBar(item, speed, cancellationToken));
            }
            await Task.WhenAll(listTask);
            foreach(CustomProgressBar item in _listProgressBar)
            {
                item.Value = 0;
            }

        }
        private async Task ChangeProgressBar(CustomProgressBar progressBar, int speed, CancellationToken cancellationToken)
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                progressBar.Value += speed;
                if (progressBar.Value == progressBar.MaxValue)
                {
                    _cancellationTokenSource?.Cancel();
                    MessageBox.Show($"Победил {progressBar.Name}");
                    break;
                }
                await Task.Delay(500);
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            _cancellationTokenSource?.Cancel();
        }
    }
}

