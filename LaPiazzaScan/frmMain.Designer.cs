﻿namespace LaPiazzaScan
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblUrl = new System.Windows.Forms.Label();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.cmdScan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.topPages = new System.Windows.Forms.NumericUpDown();
            this.lsvResults = new System.Windows.Forms.ListView();
            this.colTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLuogo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colOwner = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLink = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.actionMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuApri = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSep01 = new System.Windows.Forms.ToolStripSeparator();
            this.menuEditItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTotAnn = new System.Windows.Forms.Label();
            this.chkMostraTutti = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.topPages)).BeginInit();
            this.actionMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUrl
            // 
            this.lblUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrl.Location = new System.Drawing.Point(12, 22);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(56, 22);
            this.lblUrl.TabIndex = 0;
            this.lblUrl.Text = "URL";
            // 
            // txtUrl
            // 
            this.txtUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrl.Location = new System.Drawing.Point(83, 21);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(686, 21);
            this.txtUrl.TabIndex = 1;
            this.txtUrl.Text = "https://www.lapiazza.it/ricerca?text&reg=05&cat=1108";
            // 
            // cmdScan
            // 
            this.cmdScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdScan.Location = new System.Drawing.Point(782, 22);
            this.cmdScan.Name = "cmdScan";
            this.cmdScan.Size = new System.Drawing.Size(94, 34);
            this.cmdScan.TabIndex = 2;
            this.cmdScan.Text = "SCAN";
            this.cmdScan.UseVisualStyleBackColor = true;
            this.cmdScan.Click += new System.EventHandler(this.cmdScan_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Top";
            // 
            // topPages
            // 
            this.topPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topPages.Location = new System.Drawing.Point(83, 61);
            this.topPages.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.topPages.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.topPages.Name = "topPages";
            this.topPages.Size = new System.Drawing.Size(36, 21);
            this.topPages.TabIndex = 5;
            this.topPages.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lsvResults
            // 
            this.lsvResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvResults.CheckBoxes = true;
            this.lsvResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTitle,
            this.colLuogo,
            this.colData,
            this.colOwner,
            this.colLink,
            this.colID});
            this.lsvResults.ContextMenuStrip = this.actionMenu;
            this.lsvResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvResults.FullRowSelect = true;
            this.lsvResults.Location = new System.Drawing.Point(15, 98);
            this.lsvResults.Name = "lsvResults";
            this.lsvResults.Size = new System.Drawing.Size(1176, 536);
            this.lsvResults.TabIndex = 5;
            this.lsvResults.UseCompatibleStateImageBehavior = false;
            this.lsvResults.View = System.Windows.Forms.View.Details;
            this.lsvResults.DoubleClick += new System.EventHandler(this.lsvResults_DoubleClick);
            // 
            // colTitle
            // 
            this.colTitle.Text = "Titolo";
            this.colTitle.Width = 500;
            // 
            // colLuogo
            // 
            this.colLuogo.Text = "Luogo";
            this.colLuogo.Width = 100;
            // 
            // colData
            // 
            this.colData.Text = "Data";
            this.colData.Width = 120;
            // 
            // colOwner
            // 
            this.colOwner.Text = "Inserito da";
            this.colOwner.Width = 100;
            // 
            // colLink
            // 
            this.colLink.Text = "Link";
            this.colLink.Width = 300;
            // 
            // colID
            // 
            this.colID.Text = "ID";
            this.colID.Width = 50;
            // 
            // actionMenu
            // 
            this.actionMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuApri,
            this.menuSep01,
            this.menuEditItem});
            this.actionMenu.Name = "actionMenu";
            this.actionMenu.Size = new System.Drawing.Size(152, 54);
            // 
            // menuApri
            // 
            this.menuApri.Name = "menuApri";
            this.menuApri.Size = new System.Drawing.Size(151, 22);
            this.menuApri.Text = "Apri Annuncio";
            this.menuApri.Click += new System.EventHandler(this.menuApri_Click);
            // 
            // menuSep01
            // 
            this.menuSep01.Name = "menuSep01";
            this.menuSep01.Size = new System.Drawing.Size(148, 6);
            // 
            // menuEditItem
            // 
            this.menuEditItem.Name = "menuEditItem";
            this.menuEditItem.Size = new System.Drawing.Size(151, 22);
            this.menuEditItem.Text = "Edit";
            this.menuEditItem.Click += new System.EventHandler(this.menuEditItem_Click);
            // 
            // lblTotAnn
            // 
            this.lblTotAnn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotAnn.Location = new System.Drawing.Point(939, 63);
            this.lblTotAnn.Name = "lblTotAnn";
            this.lblTotAnn.Size = new System.Drawing.Size(146, 22);
            this.lblTotAnn.TabIndex = 6;
            this.lblTotAnn.Text = "Tot. Annunci:";
            // 
            // chkMostraTutti
            // 
            this.chkMostraTutti.AutoSize = true;
            this.chkMostraTutti.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMostraTutti.Location = new System.Drawing.Point(942, 23);
            this.chkMostraTutti.Name = "chkMostraTutti";
            this.chkMostraTutti.Size = new System.Drawing.Size(126, 21);
            this.chkMostraTutti.TabIndex = 7;
            this.chkMostraTutti.Text = "Mostra nascosti";
            this.chkMostraTutti.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 646);
            this.Controls.Add(this.chkMostraTutti);
            this.Controls.Add(this.lblTotAnn);
            this.Controls.Add(this.lsvResults);
            this.Controls.Add(this.topPages);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdScan);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.lblUrl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Text = "LaPiazza scanner (v 2.0)";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.topPages)).EndInit();
            this.actionMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button cmdScan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown topPages;
        private System.Windows.Forms.ListView lsvResults;
        private System.Windows.Forms.ColumnHeader colTitle;
        private System.Windows.Forms.ColumnHeader colLink;
        private System.Windows.Forms.Label lblTotAnn;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.ContextMenuStrip actionMenu;
        private System.Windows.Forms.ToolStripMenuItem menuEditItem;
        private System.Windows.Forms.CheckBox chkMostraTutti;
        private System.Windows.Forms.ColumnHeader colLuogo;
        private System.Windows.Forms.ColumnHeader colData;
        private System.Windows.Forms.ColumnHeader colOwner;
        private System.Windows.Forms.ToolStripMenuItem menuApri;
        private System.Windows.Forms.ToolStripSeparator menuSep01;
    }
}

