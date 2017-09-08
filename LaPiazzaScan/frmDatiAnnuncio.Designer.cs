namespace LaPiazzaScan
{
    partial class frmDatiAnnuncio
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
            this.lblContatto = new System.Windows.Forms.Label();
            this.optSI = new System.Windows.Forms.RadioButton();
            this.optNO = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDataContatto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.cmdSalva = new System.Windows.Forms.Button();
            this.cmdAnnulla = new System.Windows.Forms.Button();
            this.chkNascondi = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblContatto
            // 
            this.lblContatto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContatto.Location = new System.Drawing.Point(32, 27);
            this.lblContatto.Name = "lblContatto";
            this.lblContatto.Size = new System.Drawing.Size(102, 22);
            this.lblContatto.TabIndex = 7;
            this.lblContatto.Text = "Contattato";
            // 
            // optSI
            // 
            this.optSI.AutoSize = true;
            this.optSI.Location = new System.Drawing.Point(196, 27);
            this.optSI.Name = "optSI";
            this.optSI.Size = new System.Drawing.Size(35, 17);
            this.optSI.TabIndex = 8;
            this.optSI.Text = "SI";
            this.optSI.UseVisualStyleBackColor = true;
            // 
            // optNO
            // 
            this.optNO.AutoSize = true;
            this.optNO.Checked = true;
            this.optNO.Location = new System.Drawing.Point(140, 27);
            this.optNO.Name = "optNO";
            this.optNO.Size = new System.Drawing.Size(41, 17);
            this.optNO.TabIndex = 9;
            this.optNO.TabStop = true;
            this.optNO.Text = "NO";
            this.optNO.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Data contatto";
            // 
            // txtDataContatto
            // 
            this.txtDataContatto.Location = new System.Drawing.Point(403, 21);
            this.txtDataContatto.Name = "txtDataContatto";
            this.txtDataContatto.ReadOnly = true;
            this.txtDataContatto.Size = new System.Drawing.Size(120, 20);
            this.txtDataContatto.TabIndex = 11;
            this.txtDataContatto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "Messaggio del contatto";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "Annotazioni";
            // 
            // txtMsg
            // 
            this.txtMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMsg.Location = new System.Drawing.Point(35, 93);
            this.txtMsg.Multiline = true;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(748, 236);
            this.txtMsg.TabIndex = 14;
            // 
            // txtNote
            // 
            this.txtNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.Location = new System.Drawing.Point(35, 373);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(748, 127);
            this.txtNote.TabIndex = 15;
            // 
            // cmdSalva
            // 
            this.cmdSalva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalva.Location = new System.Drawing.Point(444, 516);
            this.cmdSalva.Name = "cmdSalva";
            this.cmdSalva.Size = new System.Drawing.Size(106, 31);
            this.cmdSalva.TabIndex = 16;
            this.cmdSalva.Text = "Salva";
            this.cmdSalva.UseVisualStyleBackColor = true;
            this.cmdSalva.Click += new System.EventHandler(this.cmdSalva_Click);
            // 
            // cmdAnnulla
            // 
            this.cmdAnnulla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAnnulla.Location = new System.Drawing.Point(249, 516);
            this.cmdAnnulla.Name = "cmdAnnulla";
            this.cmdAnnulla.Size = new System.Drawing.Size(106, 31);
            this.cmdAnnulla.TabIndex = 17;
            this.cmdAnnulla.Text = "Annulla";
            this.cmdAnnulla.UseVisualStyleBackColor = true;
            this.cmdAnnulla.Click += new System.EventHandler(this.cmdAnnulla_Click);
            // 
            // chkNascondi
            // 
            this.chkNascondi.AutoSize = true;
            this.chkNascondi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNascondi.Location = new System.Drawing.Point(675, 22);
            this.chkNascondi.Name = "chkNascondi";
            this.chkNascondi.Size = new System.Drawing.Size(86, 21);
            this.chkNascondi.TabIndex = 18;
            this.chkNascondi.Text = "Nascondi";
            this.chkNascondi.UseVisualStyleBackColor = true;
            // 
            // frmDatiAnnuncio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 559);
            this.Controls.Add(this.chkNascondi);
            this.Controls.Add(this.cmdAnnulla);
            this.Controls.Add(this.cmdSalva);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDataContatto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.optNO);
            this.Controls.Add(this.optSI);
            this.Controls.Add(this.lblContatto);
            this.Name = "frmDatiAnnuncio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dati Extra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblContatto;
        private System.Windows.Forms.RadioButton optSI;
        private System.Windows.Forms.RadioButton optNO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDataContatto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Button cmdSalva;
        private System.Windows.Forms.Button cmdAnnulla;
        private System.Windows.Forms.CheckBox chkNascondi;
    }
}