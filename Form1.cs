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

        // Method for the Laske button 
        private void button1_Click(object sender, EventArgs e)
        {
            string pressureKpa = textBoxPa.Text;
            double kiloPascals = Convert.ToDouble(pressureKpa);
            double bars = Math.Round(kiloPascals * 0.01d, 1);
            double psi = Math.Round(kiloPascals * 0.145d, 1);
            textBoxBar.Text = Convert.ToString(bars);
            textBoxPsi.Text = Convert.ToString(psi);

        }
        // A method to enable Laske button
        private void textBoxPa_Leave(object sender, EventArgs e)
        {
            // Check if textBoxPa contains numeric value

            // Define a variable for parsed value 

            double kpa;

            // store success or failure to a varible and set parsed value
            bool NumericValue = double.TryParse(textBoxPa.Text, out kpa);

            // Sanity check if value is reasonable
            if (kpa <= 10)
            {
                // Generate an error message 
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

        // A method to clear the UI and set focus back to kPa field
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
