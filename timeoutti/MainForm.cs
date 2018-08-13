using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace Timeoutti
{
    public partial class MainForm : Form
    {
        private Stopwatch stopwatch = new Stopwatch();
        private bool breakDone = true;

        public MainForm()
        {
            InitializeComponent();
        }

        private void NotifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (Visible)
                Hide();
            else
                Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            stopwatch.Start();
            Thread.Sleep(1000);
            update.Start();
            LoadBreaks();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
        }

        private void LoadBreaks()
        {
            int countrows=0;
            string readLine;
            StreamReader reader = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "\\breaks.txt");
            int totalrows = int.Parse(reader.ReadLine());
            for (; countrows < totalrows; countrows++)
            {
                SettingsForm.rows.Add(new RowContent());
            }
            for (int i = 0; i < countrows; i++)
            {
                readLine = reader.ReadLine();
                SettingsForm.rows[i].IsEnabled = bool.Parse(readLine.Substring(readLine.IndexOf('<') + 1, readLine.IndexOf('>') - 1));
                SettingsForm.rows[i].BreakGap = readLine.Substring(readLine.IndexOf('(') + 1, readLine.IndexOf(')') - (readLine.IndexOf('(') + 1));
                SettingsForm.rows[i].BreakTime = readLine.Substring(readLine.LastIndexOf('(') + 1, readLine.LastIndexOf(')') - (readLine.LastIndexOf('(') + 1));
            }
            reader.Close();
        }

        private void StartBreak(string currentTime, int breakTime)
        {
            stopwatch.Stop();
            update.Stop();
            timeLabel.Hide();

            breakPanel.Show();
            breakDone = false;
            finishBreakBtn.Text = "Skip Break";
            finishBreakBtn.BackColor = Color.Gray;
            currentTimeLbl.Text = "Time: "+currentTime;
            breakTimeLbl.Text = "Break Time: "+breakTime+" (minutes)";

            progressBar.Value = 0;
            progressBar.Maximum = breakTime * 60;
            progressBarValueChanger.Start();
        }

        private void StopBreak()
        {
            breakPanel.Hide();

            stopwatch.Start();
            update.Start();
            timeLabel.Show();
        }

        private void update_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = stopwatch.Elapsed.ToString(@"hh\:mm");

            for (int i = 0; i < SettingsForm.rows.Count; i++)
            {
                if (SettingsForm.rows[i].IsEnabled)
                    if (stopwatch.Elapsed.Minutes % SettingsForm.rows[i].GetBreakGap() == 0)
                    {
                        StartBreak(timeLabel.Text, SettingsForm.rows[i].BreakTimeValue);
                        break;
                    }
            }
        }

        private void finishBreakBtn_Click(object sender, EventArgs e)
        {
            if (breakDone)
                StopBreak();
            else
            {
                if (MessageBox.Show("Are you sure you want to skip this break?", "Alert", MessageBoxButtons.YesNo,MessageBoxIcon.Information)==DialogResult.Yes)
                    StopBreak();
            }
        }

        private void progressBarValueChanger_Tick(object sender, EventArgs e)
        {
            try
            {
                progressBar.Value += 1;
            }
            catch
            {
                breakDone = true;
                finishBreakBtn.BackColor = Color.LightGreen;
                finishBreakBtn.Text = "Finish Break";
                progressBarValueChanger.Stop();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.ApplicationExitCall)
            {
                Hide();
                e.Cancel = true;
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
