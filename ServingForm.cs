using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BasicQueueingCashier
{
    public partial class ServingForm : Form
    {
        private System.Windows.Forms.Timer servingTimer;
        public ServingForm()
        {
            InitializeComponent();
            servingTimer = new System.Windows.Forms.Timer();
            servingTimer.Interval = (1 * 1000);
            servingTimer.Tick += new EventHandler(servingTimer_Tick);
            servingTimer.Start();
        }
        private void UpdateNowServing()
        {
            if (CashierClass.CashierQueue != null && CashierClass.CashierQueue.Count > 0
                && CashierClass.CashierQueue.Contains(CashierClass.CashierQueue.Peek()))
            {
                label2.Text = CashierClass.CashierQueue.Peek();
            }
        }
        private void servingTimer_Tick(object sender, EventArgs e)
        {
            UpdateNowServing();
        }
    }
}
