namespace PizzaApp
{
    partial class Form3
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
            this.lblElementName = new System.Windows.Forms.Label();
            this.lblZutaten = new System.Windows.Forms.Label();
            this.txtElementName = new System.Windows.Forms.TextBox();
            this.lstZutaten = new System.Windows.Forms.ListBox();
            this.txtNeueZutat = new System.Windows.Forms.TextBox();
            this.cmdNeueZutat = new System.Windows.Forms.Button();
            this.cmdZutatLöschen = new System.Windows.Forms.Button();
            this.lblGrößeFreddy = new System.Windows.Forms.Label();
            this.lblGrößeMaxi = new System.Windows.Forms.Label();
            this.lblGrößeSupermaxi = new System.Windows.Forms.Label();
            this.lblBurgerUndSalat = new System.Windows.Forms.Label();
            this.txtGrößeFreddy = new System.Windows.Forms.TextBox();
            this.txtGrößeMaxi = new System.Windows.Forms.TextBox();
            this.txtGrößeSupermaxi = new System.Windows.Forms.TextBox();
            this.txtBurgersUndSalat = new System.Windows.Forms.TextBox();
            this.cmdNeuesBild = new System.Windows.Forms.Button();
            this.cmdLöschen = new System.Windows.Forms.Button();
            this.cmdOK = new System.Windows.Forms.Button();
            this.cmdAbbrechen = new System.Windows.Forms.Button();
            this.picBoxElement = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxElement)).BeginInit();
            this.SuspendLayout();
            // 
            // lblElementName
            // 
            this.lblElementName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblElementName.Location = new System.Drawing.Point(13, 45);
            this.lblElementName.Name = "lblElementName";
            this.lblElementName.Size = new System.Drawing.Size(100, 17);
            this.lblElementName.TabIndex = 0;
            this.lblElementName.Text = "Element Name:";
            // 
            // lblZutaten
            // 
            this.lblZutaten.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblZutaten.Location = new System.Drawing.Point(13, 86);
            this.lblZutaten.Name = "lblZutaten";
            this.lblZutaten.Size = new System.Drawing.Size(100, 17);
            this.lblZutaten.TabIndex = 1;
            this.lblZutaten.Text = "Zutaten:";
            // 
            // txtElementName
            // 
            this.txtElementName.Location = new System.Drawing.Point(133, 43);
            this.txtElementName.Name = "txtElementName";
            this.txtElementName.Size = new System.Drawing.Size(150, 20);
            this.txtElementName.TabIndex = 2;
            // 
            // lstZutaten
            // 
            this.lstZutaten.FormattingEnabled = true;
            this.lstZutaten.Location = new System.Drawing.Point(133, 86);
            this.lstZutaten.Name = "lstZutaten";
            this.lstZutaten.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstZutaten.Size = new System.Drawing.Size(150, 95);
            this.lstZutaten.TabIndex = 3;
            // 
            // txtNeueZutat
            // 
            this.txtNeueZutat.Location = new System.Drawing.Point(306, 86);
            this.txtNeueZutat.Name = "txtNeueZutat";
            this.txtNeueZutat.Size = new System.Drawing.Size(100, 20);
            this.txtNeueZutat.TabIndex = 4;
            // 
            // cmdNeueZutat
            // 
            this.cmdNeueZutat.Location = new System.Drawing.Point(306, 129);
            this.cmdNeueZutat.Name = "cmdNeueZutat";
            this.cmdNeueZutat.Size = new System.Drawing.Size(100, 23);
            this.cmdNeueZutat.TabIndex = 5;
            this.cmdNeueZutat.Text = "Neue Zutat";
            this.cmdNeueZutat.UseVisualStyleBackColor = true;
            this.cmdNeueZutat.Click += new System.EventHandler(this.cmdNeueZutat_Click);
            // 
            // cmdZutatLöschen
            // 
            this.cmdZutatLöschen.Location = new System.Drawing.Point(306, 158);
            this.cmdZutatLöschen.Name = "cmdZutatLöschen";
            this.cmdZutatLöschen.Size = new System.Drawing.Size(100, 23);
            this.cmdZutatLöschen.TabIndex = 6;
            this.cmdZutatLöschen.Text = "Zutat löschen";
            this.cmdZutatLöschen.UseVisualStyleBackColor = true;
            this.cmdZutatLöschen.Click += new System.EventHandler(this.cmdZutatLöschen_Click);
            // 
            // lblGrößeFreddy
            // 
            this.lblGrößeFreddy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGrößeFreddy.Location = new System.Drawing.Point(13, 238);
            this.lblGrößeFreddy.Name = "lblGrößeFreddy";
            this.lblGrößeFreddy.Size = new System.Drawing.Size(150, 17);
            this.lblGrößeFreddy.TabIndex = 7;
            this.lblGrößeFreddy.Text = "Preis für Größe Freddy:";
            // 
            // lblGrößeMaxi
            // 
            this.lblGrößeMaxi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGrößeMaxi.Location = new System.Drawing.Point(13, 267);
            this.lblGrößeMaxi.Name = "lblGrößeMaxi";
            this.lblGrößeMaxi.Size = new System.Drawing.Size(150, 17);
            this.lblGrößeMaxi.TabIndex = 8;
            this.lblGrößeMaxi.Text = "Preis für Größe Maxi:";
            // 
            // lblGrößeSupermaxi
            // 
            this.lblGrößeSupermaxi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGrößeSupermaxi.Location = new System.Drawing.Point(13, 296);
            this.lblGrößeSupermaxi.Name = "lblGrößeSupermaxi";
            this.lblGrößeSupermaxi.Size = new System.Drawing.Size(150, 17);
            this.lblGrößeSupermaxi.TabIndex = 9;
            this.lblGrößeSupermaxi.Text = "Preis für Größe Supermaxi:";
            // 
            // lblBurgerUndSalat
            // 
            this.lblBurgerUndSalat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBurgerUndSalat.Location = new System.Drawing.Point(13, 325);
            this.lblBurgerUndSalat.Name = "lblBurgerUndSalat";
            this.lblBurgerUndSalat.Size = new System.Drawing.Size(150, 17);
            this.lblBurgerUndSalat.TabIndex = 10;
            this.lblBurgerUndSalat.Text = "Preis für Burgers & Salat:";
            this.lblBurgerUndSalat.UseMnemonic = false;
            // 
            // txtGrößeFreddy
            // 
            this.txtGrößeFreddy.Location = new System.Drawing.Point(183, 236);
            this.txtGrößeFreddy.Name = "txtGrößeFreddy";
            this.txtGrößeFreddy.Size = new System.Drawing.Size(100, 20);
            this.txtGrößeFreddy.TabIndex = 11;
            // 
            // txtGrößeMaxi
            // 
            this.txtGrößeMaxi.Location = new System.Drawing.Point(183, 265);
            this.txtGrößeMaxi.Name = "txtGrößeMaxi";
            this.txtGrößeMaxi.Size = new System.Drawing.Size(100, 20);
            this.txtGrößeMaxi.TabIndex = 12;
            // 
            // txtGrößeSupermaxi
            // 
            this.txtGrößeSupermaxi.Location = new System.Drawing.Point(183, 294);
            this.txtGrößeSupermaxi.Name = "txtGrößeSupermaxi";
            this.txtGrößeSupermaxi.Size = new System.Drawing.Size(100, 20);
            this.txtGrößeSupermaxi.TabIndex = 13;
            // 
            // txtBurgersUndSalat
            // 
            this.txtBurgersUndSalat.Location = new System.Drawing.Point(183, 323);
            this.txtBurgersUndSalat.Name = "txtBurgersUndSalat";
            this.txtBurgersUndSalat.Size = new System.Drawing.Size(100, 20);
            this.txtBurgersUndSalat.TabIndex = 14;
            // 
            // cmdNeuesBild
            // 
            this.cmdNeuesBild.Location = new System.Drawing.Point(13, 548);
            this.cmdNeuesBild.Name = "cmdNeuesBild";
            this.cmdNeuesBild.Size = new System.Drawing.Size(75, 23);
            this.cmdNeuesBild.TabIndex = 16;
            this.cmdNeuesBild.Text = "Neues Bild";
            this.cmdNeuesBild.UseVisualStyleBackColor = true;
            this.cmdNeuesBild.Click += new System.EventHandler(this.cmdNeuesBild_Click);
            // 
            // cmdLöschen
            // 
            this.cmdLöschen.Location = new System.Drawing.Point(94, 548);
            this.cmdLöschen.Name = "cmdLöschen";
            this.cmdLöschen.Size = new System.Drawing.Size(75, 23);
            this.cmdLöschen.TabIndex = 17;
            this.cmdLöschen.Text = "Löschen";
            this.cmdLöschen.UseVisualStyleBackColor = true;
            this.cmdLöschen.Click += new System.EventHandler(this.cmdLöschen_Click);
            // 
            // cmdOK
            // 
            this.cmdOK.Location = new System.Drawing.Point(63, 619);
            this.cmdOK.Name = "cmdOK";
            this.cmdOK.Size = new System.Drawing.Size(100, 30);
            this.cmdOK.TabIndex = 18;
            this.cmdOK.Text = "OK";
            this.cmdOK.UseVisualStyleBackColor = true;
            this.cmdOK.Click += new System.EventHandler(this.cmdOK_Click);
            // 
            // cmdAbbrechen
            // 
            this.cmdAbbrechen.Location = new System.Drawing.Point(228, 619);
            this.cmdAbbrechen.Name = "cmdAbbrechen";
            this.cmdAbbrechen.Size = new System.Drawing.Size(100, 30);
            this.cmdAbbrechen.TabIndex = 19;
            this.cmdAbbrechen.Text = "Abbrechen";
            this.cmdAbbrechen.UseVisualStyleBackColor = true;
            this.cmdAbbrechen.Click += new System.EventHandler(this.cmdAbbrechen_Click);
            // 
            // picBoxElement
            // 
            this.picBoxElement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxElement.Location = new System.Drawing.Point(13, 366);
            this.picBoxElement.Name = "picBoxElement";
            this.picBoxElement.Size = new System.Drawing.Size(393, 175);
            this.picBoxElement.TabIndex = 15;
            this.picBoxElement.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 661);
            this.Controls.Add(this.cmdAbbrechen);
            this.Controls.Add(this.cmdOK);
            this.Controls.Add(this.cmdLöschen);
            this.Controls.Add(this.cmdNeuesBild);
            this.Controls.Add(this.picBoxElement);
            this.Controls.Add(this.txtBurgersUndSalat);
            this.Controls.Add(this.txtGrößeSupermaxi);
            this.Controls.Add(this.txtGrößeMaxi);
            this.Controls.Add(this.txtGrößeFreddy);
            this.Controls.Add(this.lblBurgerUndSalat);
            this.Controls.Add(this.lblGrößeSupermaxi);
            this.Controls.Add(this.lblGrößeMaxi);
            this.Controls.Add(this.lblGrößeFreddy);
            this.Controls.Add(this.cmdZutatLöschen);
            this.Controls.Add(this.cmdNeueZutat);
            this.Controls.Add(this.txtNeueZutat);
            this.Controls.Add(this.lstZutaten);
            this.Controls.Add(this.txtElementName);
            this.Controls.Add(this.lblZutaten);
            this.Controls.Add(this.lblElementName);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxElement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblElementName;
        private System.Windows.Forms.Label lblZutaten;
        private System.Windows.Forms.TextBox txtElementName;
        private System.Windows.Forms.ListBox lstZutaten;
        private System.Windows.Forms.TextBox txtNeueZutat;
        private System.Windows.Forms.Button cmdNeueZutat;
        private System.Windows.Forms.Button cmdZutatLöschen;
        private System.Windows.Forms.Label lblGrößeFreddy;
        private System.Windows.Forms.Label lblGrößeMaxi;
        private System.Windows.Forms.Label lblGrößeSupermaxi;
        private System.Windows.Forms.Label lblBurgerUndSalat;
        private System.Windows.Forms.TextBox txtGrößeFreddy;
        private System.Windows.Forms.TextBox txtGrößeMaxi;
        private System.Windows.Forms.TextBox txtGrößeSupermaxi;
        private System.Windows.Forms.TextBox txtBurgersUndSalat;
        private System.Windows.Forms.PictureBox picBoxElement;
        private System.Windows.Forms.Button cmdNeuesBild;
        private System.Windows.Forms.Button cmdLöschen;
        private System.Windows.Forms.Button cmdOK;
        private System.Windows.Forms.Button cmdAbbrechen;
    }
}