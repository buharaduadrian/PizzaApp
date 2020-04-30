namespace PizzaApp
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblVorname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtVorname = new System.Windows.Forms.MaskedTextBox();
            this.txtName = new System.Windows.Forms.MaskedTextBox();
            this.txtAdresse = new System.Windows.Forms.MaskedTextBox();
            this.txtPLZ = new System.Windows.Forms.MaskedTextBox();
            this.txtOrt = new System.Windows.Forms.MaskedTextBox();
            this.chkSpeichern = new System.Windows.Forms.CheckBox();
            this.cmdOK = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.cmdLieferungOderAbholung = new System.Windows.Forms.Label();
            this.optLieferung = new System.Windows.Forms.RadioButton();
            this.optAbholung = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbZahlungsMethode = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblVorname
            // 
            this.lblVorname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVorname.Location = new System.Drawing.Point(16, 41);
            this.lblVorname.Name = "lblVorname";
            this.lblVorname.Size = new System.Drawing.Size(60, 20);
            this.lblVorname.TabIndex = 0;
            this.lblVorname.Text = "Vorname";
            // 
            // lblName
            // 
            this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblName.Location = new System.Drawing.Point(16, 71);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(60, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(16, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Adresse";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(16, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "PLZ";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Location = new System.Drawing.Point(16, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ort";
            // 
            // txtVorname
            // 
            this.txtVorname.Location = new System.Drawing.Point(81, 41);
            this.txtVorname.Name = "txtVorname";
            this.txtVorname.Size = new System.Drawing.Size(166, 20);
            this.txtVorname.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(81, 71);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(166, 20);
            this.txtName.TabIndex = 6;
            // 
            // txtAdresse
            // 
            this.txtAdresse.Location = new System.Drawing.Point(81, 102);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(297, 20);
            this.txtAdresse.TabIndex = 7;
            // 
            // txtPLZ
            // 
            this.txtPLZ.Location = new System.Drawing.Point(81, 132);
            this.txtPLZ.Name = "txtPLZ";
            this.txtPLZ.Size = new System.Drawing.Size(73, 20);
            this.txtPLZ.TabIndex = 8;
            // 
            // txtOrt
            // 
            this.txtOrt.Location = new System.Drawing.Point(81, 162);
            this.txtOrt.Name = "txtOrt";
            this.txtOrt.Size = new System.Drawing.Size(112, 20);
            this.txtOrt.TabIndex = 9;
            // 
            // chkSpeichern
            // 
            this.chkSpeichern.AutoSize = true;
            this.chkSpeichern.Location = new System.Drawing.Point(81, 220);
            this.chkSpeichern.Name = "chkSpeichern";
            this.chkSpeichern.Size = new System.Drawing.Size(265, 17);
            this.chkSpeichern.TabIndex = 10;
            this.chkSpeichern.Text = "Speichern Sie die Daten zur späteren Verwendung";
            this.chkSpeichern.UseVisualStyleBackColor = true;
            // 
            // cmdOK
            // 
            this.cmdOK.Location = new System.Drawing.Point(81, 306);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(90, 30);
            this.cmdOK.TabIndex = 11;
            this.cmdOK.Text = "OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.Location = new System.Drawing.Point(201, 306);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(90, 30);
            this.cmdCancel.TabIndex = 12;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            // 
            // cmdLieferungOderAbholung
            // 
            this.cmdLieferungOderAbholung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cmdLieferungOderAbholung.Location = new System.Drawing.Point(81, 252);
            this.cmdLieferungOderAbholung.Name = "cmdLieferungOderAbholung";
            this.cmdLieferungOderAbholung.Size = new System.Drawing.Size(141, 18);
            this.cmdLieferungOderAbholung.TabIndex = 13;
            this.cmdLieferungOderAbholung.Text = "Lieferung oder Abholung?";
            // 
            // optLieferung
            // 
            this.optLieferung.AutoSize = true;
            this.optLieferung.Checked = true;
            this.optLieferung.Location = new System.Drawing.Point(237, 253);
            this.optLieferung.Name = "optLieferung";
            this.optLieferung.Size = new System.Drawing.Size(69, 17);
            this.optLieferung.TabIndex = 14;
            this.optLieferung.TabStop = true;
            this.optLieferung.Text = "Lieferung";
            this.optLieferung.UseVisualStyleBackColor = true;
            this.optLieferung.CheckedChanged += new System.EventHandler(this.Lieferung_CheckedChanged);
            // 
            // optAbholung
            // 
            this.optAbholung.AutoSize = true;
            this.optAbholung.Location = new System.Drawing.Point(237, 277);
            this.optAbholung.Name = "optAbholung";
            this.optAbholung.Size = new System.Drawing.Size(70, 17);
            this.optAbholung.TabIndex = 15;
            this.optAbholung.Text = "Abholung";
            this.optAbholung.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(16, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Zahlung";
            // 
            // cmbZahlungsMethode
            // 
            this.cmbZahlungsMethode.FormattingEnabled = true;
            this.cmbZahlungsMethode.Items.AddRange(new object[] {
            "Bar",
            "EC",
            "PayPal"});
            this.cmbZahlungsMethode.Location = new System.Drawing.Point(83, 192);
            this.cmbZahlungsMethode.Name = "cmbZahlungsMethode";
            this.cmbZahlungsMethode.Size = new System.Drawing.Size(121, 21);
            this.cmbZahlungsMethode.TabIndex = 17;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 352);
            this.Controls.Add(this.cmbZahlungsMethode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.optAbholung);
            this.Controls.Add(this.optLieferung);
            this.Controls.Add(this.cmdLieferungOderAbholung);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.chkSpeichern);
            this.Controls.Add(this.txtOrt);
            this.Controls.Add(this.txtPLZ);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtVorname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblVorname);
            this.Name = "Form4";
            this.Text = "Kunde Formular";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVorname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtVorname;
        private System.Windows.Forms.MaskedTextBox txtName;
        private System.Windows.Forms.MaskedTextBox txtAdresse;
        private System.Windows.Forms.MaskedTextBox txtPLZ;
        private System.Windows.Forms.MaskedTextBox txtOrt;
        private System.Windows.Forms.CheckBox chkSpeichern;
        private System.Windows.Forms.Button cmdOK;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.Label cmdLieferungOderAbholung;
        private System.Windows.Forms.RadioButton optLieferung;
        private System.Windows.Forms.RadioButton optAbholung;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbZahlungsMethode;
    }
}