namespace Okna
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Izracunaj(object sender, EventArgs e)
        {
            double deljenec = double.Parse(textBoxDeljenec.Text);
            double delitej = double.Parse(textBoxDelitelj.Text);
            double kolicnik = deljenec / delitej;

            textBoxKolicnik.Text = kolicnik+"";
        }
    }
}
