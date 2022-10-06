namespace Oefening3
{
    public partial class currencyConvertor : Form
    {
        public currencyConvertor()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double i = double.Parse(tbAmount.Text);

            if (cbConvertFrom.SelectedItem == "€ - EUR" && 
                cbConvertTo.SelectedItem == "$ - USD")
            {
                double convert = (double)(i * 0.9827);
                tbConverted.Text = convert + " USD";
            }
            else if (cbConvertFrom.SelectedItem == "¥ - JPY" &&
                cbConvertTo.SelectedItem == "$ - USD")
            {
                double convert = (double)(i * 0.0069);
                tbConverted.Text = convert + " USD";
            }
            else if (cbConvertFrom.SelectedItem == "£ - GBP" &&
                cbConvertTo.SelectedItem == "$ - USD")
            {
                double convert = (double)(i * 1.1325);
                tbConverted.Text = convert + " USD";
            }
            else if (cbConvertFrom.SelectedItem == "Fr - CHF" &&
                cbConvertTo.SelectedItem == "$ - USD")
            {
                double convert = (double)(i * 1.0079);
                tbConverted.Text = convert + " USD";
            }
            else if (cbConvertFrom.SelectedItem == "₹ - INR" &&
                cbConvertTo.SelectedItem == "$ - USD")
            {
                double convert = (double)(i * 0.0123);
                tbConverted.Text = convert + " USD";
            }
        }
    }
}