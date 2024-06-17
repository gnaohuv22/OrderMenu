namespace WinFormsApp2
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
            btnCalc.Click += btnCalc_Click;
            btnExit.Click += btnExit_Click;
            cbxFood60.CheckedChanged += cbxFood60_CheckedChanged;
            cbxFood70.CheckedChanged += cbxFood70_CheckedChanged;
            cbxFood80.CheckedChanged += cbxFood80_CheckedChanged;
            nudFood1.Enabled = false;
            nudFood2.Enabled = false;
            nudFood3.Enabled = false;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int priceFood1 = 70;
            int priceFood2 = 60;
            int priceFood3 = 80;

            int priceAdd1 = 20;
            int priceAdd2 = 30;

            int totalFood = (cbxFood70.Checked ? priceFood1 : 0) * (int)nudFood1.Value +
                (cbxFood60.Checked ? priceFood2 : 0) * (int)nudFood2.Value +
                (cbxFood80.Checked ? priceFood3 : 0) * (int)nudFood3.Value;

            int totalAdd = (cbxAdd20.Checked ? priceAdd1 : 0) + (cbxAdd30.Checked ? priceAdd2 : 0);

            lbCash.Text = (totalFood + totalAdd).ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxFood70_CheckedChanged(object sender, EventArgs e)
        {
            nudFood1.Enabled = cbxFood70.Checked;
        }

        private void cbxFood60_CheckedChanged(object sender, EventArgs e)
        {
            nudFood2.Enabled = cbxFood60.Checked;
        }

        private void cbxFood80_CheckedChanged(object sender, EventArgs e)
        {
            nudFood3.Enabled = cbxFood80.Checked;
        }
    }
}
