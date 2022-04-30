namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Yes_Click(object sender, EventArgs e)
        {
            twitch_link.Visible = false;
            lbl_message.Text = "Awesome! Now please hire me";
        }
        private void btn_No_Click(object sender, EventArgs e)
        {
            //somehow center this better but not sure how at the moment
            lbl_message.Text = "Why Not? Check It Out";
            twitch_link.Visible = true;
        }

        private void lbl_Click(object sender, EventArgs e)
        {

        }

        private void twitch_link_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}