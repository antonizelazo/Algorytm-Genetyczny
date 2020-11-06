namespace Algorytm_Genetyczny
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxWidokOsobnikow = new System.Windows.Forms.TextBox();
            this.btnLosujPopulacje = new System.Windows.Forms.Button();
            this.labelIloscOsobnikow = new System.Windows.Forms.Label();
            this.numericUpDownIleOsobnikow = new System.Windows.Forms.NumericUpDown();
            this.btnSortujPopulacje = new System.Windows.Forms.Button();
            this.labelOcenaOsobnikow = new System.Windows.Forms.Label();
            this.listBoxOcenaOsobnikow = new System.Windows.Forms.ListBox();
            this.labelRestrykcyjna = new System.Windows.Forms.Label();
            this.labelNaturnalna = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownStandard = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIleOsobnikow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStandard)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxWidokOsobnikow
            // 
            this.textBoxWidokOsobnikow.Location = new System.Drawing.Point(12, 12);
            this.textBoxWidokOsobnikow.Multiline = true;
            this.textBoxWidokOsobnikow.Name = "textBoxWidokOsobnikow";
            this.textBoxWidokOsobnikow.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxWidokOsobnikow.Size = new System.Drawing.Size(255, 422);
            this.textBoxWidokOsobnikow.TabIndex = 0;
            this.textBoxWidokOsobnikow.Text = "1\r\n2\r\n3\r\n4\r\n5\r\n6\r\n7\r\n8\r\n9\r\n10\r\n11\r\n12\r\n13\r\n14\r\n15\r\n16\r\n17\r\n18\r\n19\r\n20\r\n21\r\n22\r\n23" +
    "\r\n24\r\n25\r\n26\r\n27\r\n28\r\n29\r\n30\r\n31\r\n32";
            // 
            // btnLosujPopulacje
            // 
            this.btnLosujPopulacje.Location = new System.Drawing.Point(273, 38);
            this.btnLosujPopulacje.Name = "btnLosujPopulacje";
            this.btnLosujPopulacje.Size = new System.Drawing.Size(197, 23);
            this.btnLosujPopulacje.TabIndex = 1;
            this.btnLosujPopulacje.Text = "Losuj populacje";
            this.btnLosujPopulacje.UseVisualStyleBackColor = true;
            this.btnLosujPopulacje.Click += new System.EventHandler(this.btnLosujPopulacje_Click);
            // 
            // labelIloscOsobnikow
            // 
            this.labelIloscOsobnikow.AutoSize = true;
            this.labelIloscOsobnikow.Location = new System.Drawing.Point(270, 12);
            this.labelIloscOsobnikow.Name = "labelIloscOsobnikow";
            this.labelIloscOsobnikow.Size = new System.Drawing.Size(109, 26);
            this.labelIloscOsobnikow.TabIndex = 3;
            this.labelIloscOsobnikow.Text = "Ile ma byc osobnikow\r\nw populacji?";
            // 
            // numericUpDownIleOsobnikow
            // 
            this.numericUpDownIleOsobnikow.Location = new System.Drawing.Point(389, 12);
            this.numericUpDownIleOsobnikow.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDownIleOsobnikow.Name = "numericUpDownIleOsobnikow";
            this.numericUpDownIleOsobnikow.Size = new System.Drawing.Size(81, 20);
            this.numericUpDownIleOsobnikow.TabIndex = 4;
            this.numericUpDownIleOsobnikow.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownIleOsobnikow.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // btnSortujPopulacje
            // 
            this.btnSortujPopulacje.Enabled = false;
            this.btnSortujPopulacje.Location = new System.Drawing.Point(273, 296);
            this.btnSortujPopulacje.Name = "btnSortujPopulacje";
            this.btnSortujPopulacje.Size = new System.Drawing.Size(197, 23);
            this.btnSortujPopulacje.TabIndex = 5;
            this.btnSortujPopulacje.Text = "Sortuj Populacje";
            this.btnSortujPopulacje.UseVisualStyleBackColor = true;
            this.btnSortujPopulacje.Click += new System.EventHandler(this.btnSortujPopulacje_Click);
            // 
            // labelOcenaOsobnikow
            // 
            this.labelOcenaOsobnikow.AutoSize = true;
            this.labelOcenaOsobnikow.Location = new System.Drawing.Point(270, 78);
            this.labelOcenaOsobnikow.Name = "labelOcenaOsobnikow";
            this.labelOcenaOsobnikow.Size = new System.Drawing.Size(73, 26);
            this.labelOcenaOsobnikow.TabIndex = 6;
            this.labelOcenaOsobnikow.Text = "Jak ocewniać\r\nosobników?";
            // 
            // listBoxOcenaOsobnikow
            // 
            this.listBoxOcenaOsobnikow.Enabled = false;
            this.listBoxOcenaOsobnikow.FormattingEnabled = true;
            this.listBoxOcenaOsobnikow.Location = new System.Drawing.Point(350, 78);
            this.listBoxOcenaOsobnikow.Name = "listBoxOcenaOsobnikow";
            this.listBoxOcenaOsobnikow.Size = new System.Drawing.Size(120, 30);
            this.listBoxOcenaOsobnikow.TabIndex = 7;
            this.listBoxOcenaOsobnikow.SelectedIndexChanged += new System.EventHandler(this.listBoxOcenaOsobnikow_SelectedIndexChanged);
            // 
            // labelRestrykcyjna
            // 
            this.labelRestrykcyjna.AutoSize = true;
            this.labelRestrykcyjna.Location = new System.Drawing.Point(270, 121);
            this.labelRestrykcyjna.Name = "labelRestrykcyjna";
            this.labelRestrykcyjna.Size = new System.Drawing.Size(174, 26);
            this.labelRestrykcyjna.TabIndex = 8;
            this.labelRestrykcyjna.Text = "     metoda Restrykcyjna\r\n-wybierane będą najlepsze osobniki";
            // 
            // labelNaturnalna
            // 
            this.labelNaturnalna.AutoSize = true;
            this.labelNaturnalna.Location = new System.Drawing.Point(270, 158);
            this.labelNaturnalna.Name = "labelNaturnalna";
            this.labelNaturnalna.Size = new System.Drawing.Size(192, 65);
            this.labelNaturnalna.TabIndex = 9;
            this.labelNaturnalna.Text = "     metoda Naturalna\r\n-wybrane będą osobniki które wypadną\r\nnajlepiej w rankingu" +
    "\r\n-ranking bierze pod uwagę obniżone\r\nstandardy populacji";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 52);
            this.label1.TabIndex = 10;
            this.label1.Text = "standardy osobników\r\npopulacji (w %):\r\nim niższe wym większa szansa że słabszy\r\no" +
    "sobnik przetrwa kosztem silniejszego";
            // 
            // numericUpDownStandard
            // 
            this.numericUpDownStandard.Location = new System.Drawing.Point(389, 241);
            this.numericUpDownStandard.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownStandard.Name = "numericUpDownStandard";
            this.numericUpDownStandard.Size = new System.Drawing.Size(81, 20);
            this.numericUpDownStandard.TabIndex = 11;
            this.numericUpDownStandard.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownStandard.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 445);
            this.Controls.Add(this.numericUpDownStandard);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelNaturnalna);
            this.Controls.Add(this.labelRestrykcyjna);
            this.Controls.Add(this.listBoxOcenaOsobnikow);
            this.Controls.Add(this.labelOcenaOsobnikow);
            this.Controls.Add(this.btnSortujPopulacje);
            this.Controls.Add(this.numericUpDownIleOsobnikow);
            this.Controls.Add(this.labelIloscOsobnikow);
            this.Controls.Add(this.btnLosujPopulacje);
            this.Controls.Add(this.textBoxWidokOsobnikow);
            this.Name = "Form1";
            this.Text = "Algorytm genetyczny";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIleOsobnikow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStandard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxWidokOsobnikow;
        private System.Windows.Forms.Button btnLosujPopulacje;
        private System.Windows.Forms.Label labelIloscOsobnikow;
        private System.Windows.Forms.NumericUpDown numericUpDownIleOsobnikow;
        private System.Windows.Forms.Button btnSortujPopulacje;
        private System.Windows.Forms.Label labelOcenaOsobnikow;
        private System.Windows.Forms.ListBox listBoxOcenaOsobnikow;
        private System.Windows.Forms.Label labelRestrykcyjna;
        private System.Windows.Forms.Label labelNaturnalna;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownStandard;
    }
}

