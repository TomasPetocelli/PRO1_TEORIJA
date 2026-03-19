namespace VnosPodatkov
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxIme = new TextBox();
            textBoxPriimek = new TextBox();
            textBoxPovprecnaOcena = new TextBox();
            dtpDatum = new DateTimePicker();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 69);
            label1.Name = "label1";
            label1.Size = new Size(44, 28);
            label1.TabIndex = 0;
            label1.Text = "Ime";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 127);
            label2.Name = "label2";
            label2.Size = new Size(77, 28);
            label2.TabIndex = 1;
            label2.Text = "Priimek";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 193);
            label3.Name = "label3";
            label3.Size = new Size(135, 28);
            label3.TabIndex = 2;
            label3.Text = "Datum rojstva";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(75, 274);
            label4.Name = "label4";
            label4.Size = new Size(163, 28);
            label4.TabIndex = 3;
            label4.Text = "Povprecna Ocena";
            // 
            // textBoxIme
            // 
            textBoxIme.Location = new Point(280, 63);
            textBoxIme.Name = "textBoxIme";
            textBoxIme.Size = new Size(283, 34);
            textBoxIme.TabIndex = 4;
            // 
            // textBoxPriimek
            // 
            textBoxPriimek.Location = new Point(280, 124);
            textBoxPriimek.Name = "textBoxPriimek";
            textBoxPriimek.Size = new Size(283, 34);
            textBoxPriimek.TabIndex = 5;
            // 
            // textBoxPovprecnaOcena
            // 
            textBoxPovprecnaOcena.Location = new Point(280, 268);
            textBoxPovprecnaOcena.Name = "textBoxPovprecnaOcena";
            textBoxPovprecnaOcena.Size = new Size(283, 34);
            textBoxPovprecnaOcena.TabIndex = 7;
            // 
            // dtpDatum
            // 
            dtpDatum.Location = new Point(280, 193);
            dtpDatum.Name = "dtpDatum";
            dtpDatum.Size = new Size(283, 34);
            dtpDatum.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(75, 363);
            button1.Name = "button1";
            button1.Size = new Size(163, 41);
            button1.TabIndex = 10;
            button1.Text = "Vnesi";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 630);
            Controls.Add(button1);
            Controls.Add(dtpDatum);
            Controls.Add(textBoxPovprecnaOcena);
            Controls.Add(textBoxPriimek);
            Controls.Add(textBoxIme);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxIme;
        private TextBox textBoxPriimek;
        private TextBox textBoxPovprecnaOcena;
        private DateTimePicker dtpDatum;
        private Button button1;
    }
}
