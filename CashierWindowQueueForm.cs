using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;


namespace BasicQueueingCashier
{
   
    public partial class CashierWindowQueueForm : Form
    {
        private System.Windows.Forms.Timer timer;
        public CashierWindowQueueForm()
        {
            InitializeComponent();
            timer1= new System.Windows.Forms.Timer();
            timer1.Interval = (1 * 1000);
            timer1.Tick += new EventHandler(timer1_tick);
            timer1.Start();

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
     
        }

        public void DisplayCashierQueue(IEnumerable CashierList)
        {
            listCashierQueue.Items.Clear();
            foreach (Object obj in CashierList)
            {
                listCashierQueue.Items.Add(obj.ToString());
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (CashierClass.CashierQueue.Count > 0)
            {
                string served = CashierClass.CashierQueue.Dequeue();
                DisplayCashierQueue(CashierClass.CashierQueue);
            }
            else
            {
                MessageBox.Show("There are no more numbers in the queue.");
            }
        }

        private void timer1_tick(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

     
    }
}

