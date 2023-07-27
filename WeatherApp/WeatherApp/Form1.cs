namespace WeatherApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            showTime();
        }

        void showTime()
        {
            var date = DateTime.Now;
            timeLabel.Text = date.ToString("D");
        }

        private void changeLocButton_Click(object sender, EventArgs e)
        {
            var changeLoc = new ChangeLocForm();
            changeLoc.Show();
        }
    }
}