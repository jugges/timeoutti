using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timeoutti
{
    public partial class RowContent : UserControl
    {
        public RowContent()
        {
            InitializeComponent();
        }
        public bool IsEnabled
        {
            set { enableCheck.Checked = value; }
            get {return enableCheck.Checked; }
        }
        public string BreakGap
        {
            set { breakGapHours.Value = decimal.Parse(value.Split(':')[0]); breakGapMinutes.Value = decimal.Parse(value.Split(':')[1]); }
            get { return breakGapHours.Value + ":" + breakGapMinutes.Value; }
        }
        public int GetBreakGap()
        {
            return (int) (breakGapHours.Value * 60 + breakGapMinutes.Value);
        }
        public string BreakTime
        {
            set { breakTimeMinutes.Value = decimal.Parse(value); }
            get { return breakTimeMinutes.Value.ToString(); }
        }

        public int BreakTimeValue => (int) breakTimeMinutes.Value;
    }
}
