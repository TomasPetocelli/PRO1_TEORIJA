namespace Minolovec {
    public partial class Form1 : Form {

        Button[,] gumbi = new Button[12, 12];

        public Form1() {
            InitializeComponent();
            LogikaIgre a = new LogikaIgre();
            int velikost = flpanel.Width / 11;
            for (int k = 1; k <= 10; k++) {
                for (int j = 1; j <= 10; j++) {
                    gumbi[k, j] = new Button();
                    gumbi[k, j].Size = new Size(velikost, velikost);

                    if (a.mine[k, j])
                        gumbi[k, j].Text = "*";
                    else
                        gumbi[k, j].Text = a.resitev[k, j] + "";

                    gumbi[k, j].BackColor = SystemColors.Control;
                    gumbi[k, j].ForeColor = SystemColors.Control;
                    //naroci se na klik na tem gumbu
                    gumbi[k, j].Click += new EventHandler(Pokazi);
                    flpanel.Controls.Add(gumbi[k, j]);

                }//Konec for j
            }//Konec for i
        }//Konec Form1

        private void Pokazi(object? sender, EventArgs e) {
            //^^^^ prvi parameter tipa object drugi tipa handler, ni vazno ime 
            Button b = (Button)sender;
            b.BackColor = Color.Black;

            if (b.Text == "*")
                MessageBox.Show("KONEC IGRE");
        }//Konec Pokazi

        private void flpanel_Paint(object sender, PaintEventArgs e) { }
    }//Koenc partial class Form1
}
