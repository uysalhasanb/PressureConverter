namespace PressureConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pressureKpa = textBoxPa.Text;
            double kiloPascals = Convert.ToDouble(pressureKpa);
            double bars = Math.Round(kiloPascals * 0.01d, 1);
            double psi = Math.Round(kiloPascals * 0.145d, 1);
            textBoxBar.Text = Convert.ToString(bars);
            textBoxPsi.Text = Convert.ToString(psi);

        }

        private void textBoxPa_Leave(object sender, EventArgs e)
        {
            // Check if textBoxPa contains numeric value

            double kpa;
            bool NumericValue = double.TryParse(textBoxPa.Text, out kpa);
            if (kpa <= 10)
            {
                string message = "Virhellinen painetieto, paine pitää olla yli 10 kPa, anna pelkkiä numeroita. Käytä tarvittaessa desimaalipilkkua (,)";
                string header = "Väärä paine";
                DialogResult kpaErrorMsg;
                kpaErrorMsg = MessageBox.Show(message, header, MessageBoxButtons.RetryCancel);

                // Change button state to enabled
                buttonCalculate.Enabled = true;
            }
            else
            {
                // Change button state to enabled
                buttonCalculate.Enabled = true;
                buttonCalculate.Focus();

            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxPa.Text = string.Empty;
            textBoxPa.Focus();
            textBoxBar.Text = string.Empty;
            textBoxPsi.Text = string.Empty;
            buttonCalculate.Enabled = false;

        }

    }

}
