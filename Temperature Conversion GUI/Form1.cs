namespace Temperature_Conversion_GUI
{
    public partial class temp_convert : Form
    {
        public temp_convert()
        {
            InitializeComponent();
        }

        private void txtbx_fahrenheight_TextChanged(object sender, EventArgs e)
        {
            float fahrenheight = 0;
            try
            {
                fahrenheight = float.Parse(txtbx_fahrenheight.Text);
            }
            catch
            {
                set_defaults();
                MessageBox.Show("Try Only Numbers");
            }

            float celcius = (5f/9f) * (fahrenheight - 32);
            float kelvin = celcius + 273;

            txtbx_celcius.Text = celcius.ToString();
            txtbx_kelvin.Text = kelvin.ToString();
        }

        private void txtbx_celcius_TextChanged(object sender, EventArgs e)
        {
            float celcius = 0;
            try
            {
                celcius = float.Parse(txtbx_celcius.Text);
            }
            catch
            {
                set_defaults();
                MessageBox.Show("Try Only Numbers");
            }

            float fahrenheight = (celcius / (5f/9f)) + 32;
            float kelvin = celcius + 273;

            txtbx_fahrenheight.Text = fahrenheight.ToString();
            txtbx_kelvin.Text = kelvin.ToString();
        }

        private void txtbx_kelvin_TextChanged(object sender, EventArgs e)
        {
            float kelvin = 0;
            try
            {
                kelvin = float.Parse(txtbx_kelvin.Text);
            }
            catch
            {
                set_defaults();
                MessageBox.Show("Try Only Numbers");
            }

            float fahrenheight = ((kelvin - 273) / (5f/9f)) + 32;
            float celcius = kelvin - 273;

            txtbx_fahrenheight.Text = fahrenheight.ToString();
            txtbx_celcius.Text = celcius.ToString();
        }

        private void set_defaults()
        {
            txtbx_fahrenheight.Text = "32";
            txtbx_celcius.Text = "0";
            txtbx_kelvin.Text = "273";
        }
    }
}