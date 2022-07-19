namespace DemoUserControl_JakeKantor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Remove Controls To Start Form
            Controls.Remove(userControl11);
            Controls.Remove(userControl21);
        }


        // Button 1 (UC1)
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Remove UC1")
            {
                button1.Text = "Add UC1";
                Controls.Remove(userControl11);
            }
            else if (button1.Text == "Add UC1")
            {
                button1.Text = "Remove UC1";
                Controls.Add(userControl11);
            }
        }

        // Button 2 (UC2)
        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "Add UC2")
            {
                button2.Text = "Remove UC2";
                Controls.Add(userControl21);

            }
            else if (button2.Text == "Remove UC2")
            {
                button2.Text = "Add UC2";
                Controls.Remove(userControl21);
            }
        }
    }
}