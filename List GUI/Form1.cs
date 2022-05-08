namespace List_GUI
{
    public partial class Form1 : Form
    {
        List<String> my_friends = new List<string>();
        BindingSource bs = new BindingSource();
        public Form1()
        {
            InitializeComponent();
            bs.DataSource = my_friends;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstbx_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_add_one_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                my_friends.Add(textBox1.Text);
                lstbx.DataSource = bs;
                bs.ResetBindings(false);
                lbl_num_friends.Text = "You have " + my_friends.Count + " friends";
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Type in a name");
            }
        }

        private void btn_a_to_z_Click(object sender, EventArgs e)
        {
            my_friends.Sort();
            bs.ResetBindings(false);
        }

        private void btn_z_to_a_Click(object sender, EventArgs e)
        {
            my_friends.Sort();
            my_friends.Reverse();
            bs.ResetBindings(false);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            my_friends.Clear();
            bs.ResetBindings(false);
            lbl_num_friends.Text = "You have 0 friends :(";
        }

        private void lbl_num_friends_Click(object sender, EventArgs e)
        {

        }
    }
}