﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using HtmlAgilityPack;

namespace LaPiazzaScan
{
    public partial class frmMain : Form
    {
        private string _pathData = Path.Combine(Application.StartupPath, "datalist.ini");

        public frmMain()
        {
            InitializeComponent();
        }

        private void cmdScan_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            bool first = true;
            string url;
            string nascosto = "";
            bool found;
            string xpath1 = "//div[@class='item_content_in']";
            //string xpath2 = "//div[contains(@class, 'item_title')]";

            // From Web
            var web = new HtmlWeb();
            int curRow = 0;
            lsvResults.Items.Clear();

            for (int i = 1; i <= topPages.Value; i++) {
                if (first) {
                    url = txtUrl.Text;
                } else {
                    url = @"http://annuncilapiazza.it/ricerca/annunci?se=1&search=Cerca&se_cats[0]=80&start=" + (14 * (i - 1));
                }

                first = false;
                var doc = web.Load(url);
                foreach (HtmlNode n in doc.DocumentNode.SelectNodes(xpath1)) {
                    HtmlNode n2 = n.SelectSingleNode("./div[@class='item_desc']");

                    string descr = n2.ChildNodes[1].InnerText.Replace("\t", "");
                    string link = n2.ChildNodes[1].Attributes[0].Value;

                    // determinazione dell'id annuncio
                    int s1 = link.IndexOf("offerte-lavoro&id=");
                    string jobId = link.Substring(s1 + 18, 5);

                    found = DatiAnnuncio.TrovaId(_pathData, jobId, ref nascosto);
                    if (chkMostraTutti.Checked || (nascosto == "NO")) {
                        curRow++;
                        string[] values = { descr, link, jobId };
                        ListViewItem row = lsvResults.Items.Add(new ListViewItem(values));

                        if (nascosto == "SI") {
                            row.BackColor = Color.LightBlue;
                        } else if (curRow % 2 == 0) {
                            row.BackColor = Color.LightGray;
                        } else {
                            row.BackColor = Color.GhostWhite;
                        }
                    }
                }
            }

            // aggiornamento colonna dei già selezionati
            foreach (ListViewItem row in lsvResults.Items) {
                found = DatiAnnuncio.TrovaId(_pathData, row.SubItems[2].Text, ref nascosto);
                row.Checked = found;
            }

            lblTotAnn.Text = "Tot. Annunci: " + curRow.ToString();
            this.Cursor = Cursors.Default;
        }

        private void lsvResults_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem item = lsvResults.SelectedItems[0];
            item.Checked = true;

            string link = @"http://annuncilapiazza.it/ricerca/" + item.SubItems[1].Text;
            string jobId = item.SubItems[2].Text;

            // aggiungere id alla lista degli annunci letti
            string nascosto = "";
            bool found = DatiAnnuncio.TrovaId(_pathData, jobId, ref nascosto);

            if (!found) {
                GeneraEntry(jobId);
            }

            System.Diagnostics.Process.Start(link);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Program.extraData = new DatiAnnuncio();

            if (!File.Exists(_pathData)) {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(_pathData)) {
                    //sw.WriteLine("Hello");
                }
            }
        }

        private void GeneraEntry(string jobId)
        {
            using (StreamWriter sw = File.AppendText(_pathData)) {
                sw.WriteLine("[" + jobId + "]");
                sw.WriteLine("contattato=NO");
                sw.WriteLine("data_contatto=none");
                sw.WriteLine("messaggio=none");
                sw.WriteLine("note=none");
                sw.WriteLine("nascosto=NO");
            }
        }

        private void menuEditItem_Click(object sender, EventArgs e)
        {
            if (lsvResults.SelectedItems.Count > 0) {
                ListViewItem row = lsvResults.SelectedItems[0];
                string jobId = row.SubItems[2].Text;
                frmDatiAnnuncio formDatiExtra = new frmDatiAnnuncio(jobId);
                formDatiExtra.ShowDialog();

                if (!Program.extraData.Annulla) {
                    string nascosto = "";
                    bool found = DatiAnnuncio.TrovaId(_pathData, jobId, ref nascosto);
                    if (!found) {
                        GeneraEntry(jobId);
                    }

                    // scrittura dati
                    FileIni ini = new FileIni();
                    ini.IniFile(_pathData);
                    ini.Write("contattato", Program.extraData.Contattato, jobId);
                    ini.Write("data_contatto", DateTime.Now.ToShortDateString(), jobId);
                    ini.Write("messaggio", Program.extraData.Messaggio, jobId);
                    ini.Write("note", Program.extraData.Annotazioni, jobId);
                    ini.Write("nascosto", Program.extraData.Nascosto, jobId);

                    row.Checked = true;
                    if (Program.extraData.Contattato == "SI")
                        row.BackColor = Color.LightSalmon;

                    if (Program.extraData.Nascosto == "SI")
                        lsvResults.Items.Remove(row);
                }
            }
        }
    }
}
