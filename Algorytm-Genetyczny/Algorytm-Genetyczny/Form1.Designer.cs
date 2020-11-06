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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIleOsobnikow)).BeginInit();
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
            this.btnLosujPopulacje.Location = new System.Drawing.Point(273, 50);
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
            this.labelIloscOsobnikow.Location = new System.Drawing.Point(274, 21);
            this.labelIloscOsobnikow.Name = "labelIloscOsobnikow";
            this.labelIloscOsobnikow.Size = new System.Drawing.Size(109, 26);
            this.labelIloscOsobnikow.TabIndex = 3;
            this.labelIloscOsobnikow.Text = "Ile ma byc osobnikow\r\nw populacji?";
            // 
            // numericUpDownIleOsobnikow
            // 
            this.numericUpDownIleOsobnikow.Location = new System.Drawing.Point(389, 24);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 445);
            this.Controls.Add(this.numericUpDownIleOsobnikow);
            this.Controls.Add(this.labelIloscOsobnikow);
            this.Controls.Add(this.btnLosujPopulacje);
            this.Controls.Add(this.textBoxWidokOsobnikow);
            this.Name = "Form1";
            this.Text = "Algorytm genetyczny";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIleOsobnikow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxWidokOsobnikow;
        private System.Windows.Forms.Button btnLosujPopulacje;
        private System.Windows.Forms.Label labelIloscOsobnikow;
        private System.Windows.Forms.NumericUpDown numericUpDownIleOsobnikow;
    }
}

