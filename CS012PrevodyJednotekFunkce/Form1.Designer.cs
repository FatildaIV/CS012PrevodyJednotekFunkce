namespace CS012PrevodyJednotekFunkce
{
    partial class PrevodyJednotekFunkceForm
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.JednotkaComboBox = new System.Windows.Forms.ComboBox();
            this.HodnotaTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // JednotkyComboBox
            // 
            this.JednotkaComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.JednotkaComboBox.FormattingEnabled = true;
            this.JednotkaComboBox.Items.AddRange(new object[] {
            "°C",
            "°F",
            "K"});
            this.JednotkaComboBox.Location = new System.Drawing.Point(184, 19);
            this.JednotkaComboBox.Name = "JednotkyComboBox";
            this.JednotkaComboBox.Size = new System.Drawing.Size(134, 37);
            this.JednotkaComboBox.TabIndex = 0;
            this.JednotkaComboBox.TextChanged += new System.EventHandler(this.JednotkyComboBox_TextChanged);
            // 
            // HodnotaTextBox
            // 
            this.HodnotaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.HodnotaTextBox.Location = new System.Drawing.Point(25, 18);
            this.HodnotaTextBox.Name = "HodnotaTextBox";
            this.HodnotaTextBox.Size = new System.Drawing.Size(122, 38);
            this.HodnotaTextBox.TabIndex = 1;
            this.HodnotaTextBox.Enter += new System.EventHandler(this.HodnotaTextBox_Enter);
            // 
            // PrevodyJednotekFunkceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HodnotaTextBox);
            this.Controls.Add(this.JednotkaComboBox);
            this.Name = "PrevodyJednotekFunkceForm";
            this.Text = "Převody stupňů Celsia a Fahrenheita";
            this.Load += new System.EventHandler(this.PrevodyJednotekFunkceForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox JednotkaComboBox;
        private System.Windows.Forms.TextBox HodnotaTextBox;
    }
}

