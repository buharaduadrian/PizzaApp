namespace PizzaApp
{
    partial class Form2
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
            this.dgvElemente = new System.Windows.Forms.DataGridView();
            this.cmdNeuElement = new System.Windows.Forms.Button();
            this.cmdBearbeiten = new System.Windows.Forms.Button();
            this.cmdSpeichern = new System.Windows.Forms.Button();
            this.cmdLöschen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvElemente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvElemente
            // 
            this.dgvElemente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvElemente.Location = new System.Drawing.Point(12, 12);
            this.dgvElemente.Name = "dgvElemente";
            this.dgvElemente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvElemente.Size = new System.Drawing.Size(776, 369);
            this.dgvElemente.TabIndex = 0;
            // 
            // cmdNeuElement
            // 
            this.cmdNeuElement.Location = new System.Drawing.Point(12, 399);
            this.cmdNeuElement.Name = "cmdNeuElement";
            this.cmdNeuElement.Size = new System.Drawing.Size(100, 30);
            this.cmdNeuElement.TabIndex = 1;
            this.cmdNeuElement.Text = "Neu";
            this.cmdNeuElement.UseVisualStyleBackColor = true;
            this.cmdNeuElement.Click += new System.EventHandler(this.cmdNeuElement_Click);
            // 
            // cmdBearbeiten
            // 
            this.cmdBearbeiten.Location = new System.Drawing.Point(237, 399);
            this.cmdBearbeiten.Name = "cmdBearbeiten";
            this.cmdBearbeiten.Size = new System.Drawing.Size(100, 30);
            this.cmdBearbeiten.TabIndex = 2;
            this.cmdBearbeiten.Text = "Bearbeiten";
            this.cmdBearbeiten.UseVisualStyleBackColor = true;
            this.cmdBearbeiten.Click += new System.EventHandler(this.cmdBearbeiten_Click);
            // 
            // cmdSpeichern
            // 
            this.cmdSpeichern.Location = new System.Drawing.Point(462, 399);
            this.cmdSpeichern.Name = "cmdSpeichern";
            this.cmdSpeichern.Size = new System.Drawing.Size(100, 30);
            this.cmdSpeichern.TabIndex = 3;
            this.cmdSpeichern.Text = "Speichern";
            this.cmdSpeichern.UseVisualStyleBackColor = true;
            this.cmdSpeichern.Click += new System.EventHandler(this.cmdSpeichern_Click);
            // 
            // cmdLöschen
            // 
            this.cmdLöschen.Location = new System.Drawing.Point(687, 399);
            this.cmdLöschen.Name = "cmdLöschen";
            this.cmdLöschen.Size = new System.Drawing.Size(100, 30);
            this.cmdLöschen.TabIndex = 4;
            this.cmdLöschen.Text = "Löschen";
            this.cmdLöschen.UseVisualStyleBackColor = true;
            this.cmdLöschen.Click += new System.EventHandler(this.cmdLöschen_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdLöschen);
            this.Controls.Add(this.cmdSpeichern);
            this.Controls.Add(this.cmdBearbeiten);
            this.Controls.Add(this.cmdNeuElement);
            this.Controls.Add(this.dgvElemente);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvElemente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvElemente;
        private System.Windows.Forms.Button cmdNeuElement;
        private System.Windows.Forms.Button cmdBearbeiten;
        private System.Windows.Forms.Button cmdSpeichern;
        private System.Windows.Forms.Button cmdLöschen;
    }
}