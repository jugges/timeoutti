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

namespace Timeoutti
{
    public partial class SettingsForm : Form
    {
        int countrows = 0;
        public static List<RowContent> rows = new List<RowContent>();

        public SettingsForm()
        {
            InitializeComponent();
            LoadBreaks();
        }

        public void AddBreak()
        {
            rows.Add(new RowContent());
            tableLayoutPanel1.Controls.Add(rows[countrows]);
            tableLayoutPanel1.SetRow(rows[countrows], countrows);
            countrows++;
        }

        public void RemoveBreak()
        {
            tableLayoutPanel1.Controls.Remove(rows[--countrows]);
            rows.Remove(rows[countrows]);
        }

        public void ApplyBreaks()
        {
            StreamWriter writer = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\breaks.txt");
            writer.WriteLine(countrows);
            for (int i = 0; i < countrows; i++)
            {
                writer.WriteLine("<{0}>({1})({2})", rows[i].IsEnabled, rows[i].BreakGap, rows[i].BreakTime);
            }
            writer.Close();

        }

        private void LoadBreaks()
        {
            StreamReader reader = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "\\breaks.txt");
            int totalrows = int.Parse(reader.ReadLine());
            reader.Close();
            for (; countrows < totalrows; countrows++)
            {
                tableLayoutPanel1.Controls.Add(rows[countrows]);
                tableLayoutPanel1.SetRow(rows[countrows], countrows);
            }
        }

        private void NewBreakButton_Click(object sender, EventArgs e)
        {
            AddBreak();
        }

        private void ApplyBreaksButton_Click(object sender, EventArgs e)
        {
            ApplyBreaks();
        }

        private void RemoveLatestBreakButton_Click(object sender, EventArgs e)
        {
            RemoveBreak();
        }
    }
}
