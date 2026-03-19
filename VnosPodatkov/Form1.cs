namespace VnosPodatkov {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e) {
            Student a = new Student();
            a.Ime = textBoxIme.Text;
            a.Priimek = textBoxPriimek.Text;
            a.DatumRojstva = dtpDatum.Value;
            try {
                a.Povprecje = double.Parse(textBoxPovprecnaOcena.Text);

                MessageBox.Show("Vnesen studnet\n" + a.Izpis());
            } catch (Exception ex){
                textBoxPovprecnaOcena.Text = " ";
                textBoxPovprecnaOcena.Focus();
            }//Konec try-catch
        }//Konec button1_Click
    }
}
