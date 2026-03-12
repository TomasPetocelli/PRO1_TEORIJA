namespace Okna
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
            textBoxDeljenec = new TextBox();
            textBoxDelitelj = new TextBox();
            textBoxKolicnik = new TextBox();
            buttonIzracunaj = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 46);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "Deljenec";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 108);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 1;
            label2.Text = "Delitelj";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 164);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 2;
            label3.Text = "Kolicnik";
            // 
            // textBoxDeljenec
            // 
            textBoxDeljenec.Location = new Point(129, 39);
            textBoxDeljenec.Name = "textBoxDeljenec";
            textBoxDeljenec.Size = new Size(125, 27);
            textBoxDeljenec.TabIndex = 3;
            // 
            // textBoxDelitelj
            // 
            textBoxDelitelj.Location = new Point(129, 101);
            textBoxDelitelj.Name = "textBoxDelitelj";
            textBoxDelitelj.Size = new Size(125, 27);
            textBoxDelitelj.TabIndex = 4;
            // 
            // textBoxKolicnik
            // 
            textBoxKolicnik.Location = new Point(129, 157);
            textBoxKolicnik.Name = "textBoxKolicnik";
            textBoxKolicnik.Size = new Size(125, 27);
            textBoxKolicnik.TabIndex = 5;
            // 
            // buttonIzracunaj
            // 
            buttonIzracunaj.Location = new Point(38, 248);
            buttonIzracunaj.Name = "buttonIzracunaj";
            buttonIzracunaj.Size = new Size(317, 29);
            buttonIzracunaj.TabIndex = 6;
            buttonIzracunaj.Text = "IZRACUNAJ";
            buttonIzracunaj.UseVisualStyleBackColor = true;
            buttonIzracunaj.Click += Izracunaj;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 445);
            Controls.Add(buttonIzracunaj);
            Controls.Add(textBoxKolicnik);
            Controls.Add(textBoxDelitelj);
            Controls.Add(textBoxDeljenec);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Enostaven kalkulator";
            Click += Izracunaj;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxDeljenec;
        private TextBox textBoxDelitelj;
        private TextBox textBoxKolicnik;
        private Button buttonIzracunaj;
    }
}
