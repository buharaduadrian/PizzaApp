namespace PizzaApp
{
    partial class UserControl3
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvWarenKorb = new System.Windows.Forms.DataGridView();
            this.picBoxGetränke = new System.Windows.Forms.PictureBox();
            this.picBoxEisUndDesserts = new System.Windows.Forms.PictureBox();
            this.lblNochEinWunsch = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdGetränke = new System.Windows.Forms.Button();
            this.cmdEisUndDesserts = new System.Windows.Forms.Button();
            this.cmbGetränke = new System.Windows.Forms.ComboBox();
            this.numGetränke = new System.Windows.Forms.NumericUpDown();
            this.cmbEisUndDesserts = new System.Windows.Forms.ComboBox();
            this.numEisUndD = new System.Windows.Forms.NumericUpDown();
            this.lblA = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblZuZahlen = new System.Windows.Forms.Label();
            this.lblZahlung = new System.Windows.Forms.Label();
            this.cmdItemLöschen = new System.Windows.Forms.Button();
            this.cmdFortfahren = new System.Windows.Forms.Button();
            this.cmdNeueBestellung = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWarenKorb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGetränke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEisUndDesserts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGetränke)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEisUndD)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvWarenKorb
            // 
            this.dgvWarenKorb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWarenKorb.Location = new System.Drawing.Point(37, 30);
            this.dgvWarenKorb.Name = "dgvWarenKorb";
            this.dgvWarenKorb.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWarenKorb.Size = new System.Drawing.Size(565, 250);
            this.dgvWarenKorb.TabIndex = 0;
            // 
            // picBoxGetränke
            // 
            this.picBoxGetränke.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxGetränke.Location = new System.Drawing.Point(422, 314);
            this.picBoxGetränke.Name = "picBoxGetränke";
            this.picBoxGetränke.Size = new System.Drawing.Size(180, 90);
            this.picBoxGetränke.TabIndex = 2;
            this.picBoxGetränke.TabStop = false;
            // 
            // picBoxEisUndDesserts
            // 
            this.picBoxEisUndDesserts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxEisUndDesserts.Location = new System.Drawing.Point(37, 314);
            this.picBoxEisUndDesserts.Name = "picBoxEisUndDesserts";
            this.picBoxEisUndDesserts.Size = new System.Drawing.Size(180, 90);
            this.picBoxEisUndDesserts.TabIndex = 1;
            this.picBoxEisUndDesserts.TabStop = false;
            // 
            // lblNochEinWunsch
            // 
            this.lblNochEinWunsch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNochEinWunsch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNochEinWunsch.ForeColor = System.Drawing.Color.Red;
            this.lblNochEinWunsch.Location = new System.Drawing.Point(37, 289);
            this.lblNochEinWunsch.Name = "lblNochEinWunsch";
            this.lblNochEinWunsch.Size = new System.Drawing.Size(210, 22);
            this.lblNochEinWunsch.TabIndex = 3;
            this.lblNochEinWunsch.Text = "Noch ein Wunsch? Getränke?";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(422, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Eis oder Dessert?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 484);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 5;
            // 
            // cmdGetränke
            // 
            this.cmdGetränke.Location = new System.Drawing.Point(77, 469);
            this.cmdGetränke.Name = "cmdGetränke";
            this.cmdGetränke.Size = new System.Drawing.Size(98, 23);
            this.cmdGetränke.TabIndex = 6;
            this.cmdGetränke.Text = "Getränke wählen";
            this.cmdGetränke.UseVisualStyleBackColor = true;
            this.cmdGetränke.Click += new System.EventHandler(this.cmdGetränke_Click);
            // 
            // cmdEisUndDesserts
            // 
            this.cmdEisUndDesserts.Location = new System.Drawing.Point(446, 469);
            this.cmdEisUndDesserts.Name = "cmdEisUndDesserts";
            this.cmdEisUndDesserts.Size = new System.Drawing.Size(134, 23);
            this.cmdEisUndDesserts.TabIndex = 7;
            this.cmdEisUndDesserts.Text = "Eis oder Dessert wählen";
            this.cmdEisUndDesserts.UseVisualStyleBackColor = true;
            this.cmdEisUndDesserts.Click += new System.EventHandler(this.cmdEisUndDesserts_Click);
            // 
            // cmbGetränke
            // 
            this.cmbGetränke.FormattingEnabled = true;
            this.cmbGetränke.Location = new System.Drawing.Point(37, 411);
            this.cmbGetränke.Name = "cmbGetränke";
            this.cmbGetränke.Size = new System.Drawing.Size(180, 21);
            this.cmbGetränke.TabIndex = 8;
            // 
            // numGetränke
            // 
            this.numGetränke.Location = new System.Drawing.Point(119, 439);
            this.numGetränke.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numGetränke.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numGetränke.Name = "numGetränke";
            this.numGetränke.Size = new System.Drawing.Size(98, 20);
            this.numGetränke.TabIndex = 9;
            this.numGetränke.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmbEisUndDesserts
            // 
            this.cmbEisUndDesserts.FormattingEnabled = true;
            this.cmbEisUndDesserts.Location = new System.Drawing.Point(422, 411);
            this.cmbEisUndDesserts.Name = "cmbEisUndDesserts";
            this.cmbEisUndDesserts.Size = new System.Drawing.Size(278, 21);
            this.cmbEisUndDesserts.TabIndex = 10;
            // 
            // numEisUndD
            // 
            this.numEisUndD.Location = new System.Drawing.Point(514, 439);
            this.numEisUndD.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numEisUndD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numEisUndD.Name = "numEisUndD";
            this.numEisUndD.Size = new System.Drawing.Size(88, 20);
            this.numEisUndD.TabIndex = 11;
            this.numEisUndD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblA
            // 
            this.lblA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblA.Location = new System.Drawing.Point(60, 439);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(53, 20);
            this.lblA.TabIndex = 12;
            this.lblA.Text = "Menge ×";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(446, 440);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Menge ×";
            // 
            // lblZuZahlen
            // 
            this.lblZuZahlen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblZuZahlen.Location = new System.Drawing.Point(609, 30);
            this.lblZuZahlen.Name = "lblZuZahlen";
            this.lblZuZahlen.Size = new System.Drawing.Size(91, 19);
            this.lblZuZahlen.TabIndex = 14;
            this.lblZuZahlen.Text = "Gesamtzahlung:";
            // 
            // lblZahlung
            // 
            this.lblZahlung.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblZahlung.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZahlung.Location = new System.Drawing.Point(609, 53);
            this.lblZahlung.Name = "lblZahlung";
            this.lblZahlung.Size = new System.Drawing.Size(91, 32);
            this.lblZahlung.TabIndex = 15;
            // 
            // cmdItemLöschen
            // 
            this.cmdItemLöschen.Location = new System.Drawing.Point(609, 109);
            this.cmdItemLöschen.Name = "cmdItemLöschen";
            this.cmdItemLöschen.Size = new System.Drawing.Size(91, 23);
            this.cmdItemLöschen.TabIndex = 16;
            this.cmdItemLöschen.Text = "Item(s) löschen";
            this.cmdItemLöschen.UseVisualStyleBackColor = true;
            this.cmdItemLöschen.Click += new System.EventHandler(this.cmdItemLöschen_Click);
            // 
            // cmdFortfahren
            // 
            this.cmdFortfahren.Location = new System.Drawing.Point(609, 139);
            this.cmdFortfahren.Name = "cmdFortfahren";
            this.cmdFortfahren.Size = new System.Drawing.Size(91, 23);
            this.cmdFortfahren.TabIndex = 17;
            this.cmdFortfahren.Text = "Fortfaren";
            this.cmdFortfahren.UseVisualStyleBackColor = true;
            this.cmdFortfahren.Click += new System.EventHandler(this.cmdFortfahren_Click);
            // 
            // cmdNeueBestellung
            // 
            this.cmdNeueBestellung.Location = new System.Drawing.Point(609, 169);
            this.cmdNeueBestellung.Name = "cmdNeueBestellung";
            this.cmdNeueBestellung.Size = new System.Drawing.Size(91, 35);
            this.cmdNeueBestellung.TabIndex = 18;
            this.cmdNeueBestellung.Text = "Neue Bestellung";
            this.cmdNeueBestellung.UseVisualStyleBackColor = true;
            this.cmdNeueBestellung.Click += new System.EventHandler(this.cmdNeueBestellung_Click);
            // 
            // UserControl3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.cmdNeueBestellung);
            this.Controls.Add(this.cmdFortfahren);
            this.Controls.Add(this.cmdItemLöschen);
            this.Controls.Add(this.lblZahlung);
            this.Controls.Add(this.lblZuZahlen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.numEisUndD);
            this.Controls.Add(this.cmbEisUndDesserts);
            this.Controls.Add(this.numGetränke);
            this.Controls.Add(this.cmbGetränke);
            this.Controls.Add(this.cmdEisUndDesserts);
            this.Controls.Add(this.cmdGetränke);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNochEinWunsch);
            this.Controls.Add(this.picBoxGetränke);
            this.Controls.Add(this.picBoxEisUndDesserts);
            this.Controls.Add(this.dgvWarenKorb);
            this.Name = "UserControl3";
            this.Size = new System.Drawing.Size(800, 500);
            this.Load += new System.EventHandler(this.UserControl3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWarenKorb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGetränke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEisUndDesserts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGetränke)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEisUndD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvWarenKorb;
        private System.Windows.Forms.PictureBox picBoxEisUndDesserts;
        private System.Windows.Forms.PictureBox picBoxGetränke;
        private System.Windows.Forms.Label lblNochEinWunsch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdGetränke;
        private System.Windows.Forms.Button cmdEisUndDesserts;
        private System.Windows.Forms.ComboBox cmbGetränke;
        private System.Windows.Forms.NumericUpDown numGetränke;
        private System.Windows.Forms.ComboBox cmbEisUndDesserts;
        private System.Windows.Forms.NumericUpDown numEisUndD;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblZuZahlen;
        private System.Windows.Forms.Label lblZahlung;
        private System.Windows.Forms.Button cmdItemLöschen;
        private System.Windows.Forms.Button cmdFortfahren;
        private System.Windows.Forms.Button cmdNeueBestellung;
    }
}
