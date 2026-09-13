using System.Windows.Forms;
namespace BasicQueueingCashier
{
    public partial class QueuingForm : Form
    {
        private CashierClass cashier;
        private CashierWindowQueueForm cashierWindow;
        private ServingForm servingWindow;
        public QueuingForm()
        {
            InitializeComponent();
            cashier = new CashierClass();

            cashierWindow = new CashierWindowQueueForm();
            cashierWindow.Show();

            servingWindow = new ServingForm();
            servingWindow.Show();
        }
        private void btnCashier_Click(object sender, System.EventArgs e)
        {
            lblQueue.Text = cashier.CashierGeneratedNumber("P - ");

            CashierClass.getNumberInQueue = lblQueue.Text;

            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);

        }
    }
}
