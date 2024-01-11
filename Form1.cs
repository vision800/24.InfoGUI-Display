namespace _24.InfoGUI_Display
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //getting the info the user
            string name= txtName.Text;
            string surname= txtSurname.Text;
            string year = txtYear.Text;

            lblInfo.Text = $"Welcome, {name} {surname}";

            MessageBox.Show($"Welcome, {name} {surname}");
        }
    }
}