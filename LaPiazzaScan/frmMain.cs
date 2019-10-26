using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Configuration;
using HtmlAgilityPack;

namespace LaPiazzaScan
{
    public partial class frmMain : Form
    {
        private string _pathData = Path.Combine(Application.StartupPath, "datalist.ini");
        const int colJobID = 5;

        public frmMain()
        {
            InitializeComponent();
        }

        private void cmdScan_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            bool first = true;
            string url, baseUrl;
            DatiAnnuncio annuncio = new DatiAnnuncio();
            bool found;
            string xpath1 = "//div[@class='colonna-annunci col']/div[contains(@class,'row no-gutters annuncio')]"; // "//div[@class='item_content_in']";

            // From Web
            var web = new HtmlWeb();
            int curRow = 0;
            lsvResults.Items.Clear();
            baseUrl = txtUrl.Text; // kttps://www.lapiazza.it/ricerca?text&reg=05&cat=1108

            for (int i = 1; i <= topPages.Value; i++) {
                if (first) {
                    url = baseUrl;
                } else {
                    url = baseUrl + "&page=" + i;
                }

                first = false;
                var doc = web.Load(url);

                try {
                    HtmlNodeCollection annunci = doc.DocumentNode.SelectNodes(xpath1);

                    foreach (HtmlNode n in annunci) {
                        HtmlNode title = n.SelectSingleNode("./div/div[@class='row no-gutters mb-auto']/a");
                        string descr = title.InnerText; //  n2.ChildNodes[1].InnerText.Replace("\t", "");
                        string jobId = title.Attributes["href"].Value;
                        string link = "www.lapiazza.it" + jobId;

                        // extra info: Luogo
                        string luogo = n.SelectSingleNode("./div/p[@class='icon-right order-0']").InnerText.Replace("\n","").Trim();

                        // extra info: Data e Inserzionista
                        HtmlNode info = n.SelectSingleNode("./div/p[@class='color-brown-grey order-2 order-md-1']");
                        string dataOra = info.SelectSingleNode("./span[@class='mr-2 d-none d-md-inline']").InnerText.Replace("\n","").Trim();
                        string owner = info.SelectSingleNode("./span[@class='fs12md']").InnerText.Replace("Inserzionista: ", "");

                        found = DatiAnnuncio.TrovaId(_pathData, jobId, ref annuncio);

                        if (chkMostraTutti.Checked || (annuncio.Nascosto == "NO")) {
                            curRow++;
                            string[] values = { descr, luogo, dataOra, owner, link, jobId };
                            ListViewItem row = lsvResults.Items.Add(new ListViewItem(values));

                            if (annuncio.Contattato == "SI") {
                                row.BackColor = Color.LightSalmon;
                            } else if (annuncio.Nascosto == "SI") {
                                row.BackColor = Color.LightBlue;
                            } else if (annuncio.Evidenzia == "SI") {
                                row.BackColor = Color.Yellow;
                            } else if (curRow % 2 == 0) {
                                row.BackColor = Color.LightGray;
                            } else {
                                row.BackColor = Color.GhostWhite;
                            }
                        }
                    }
                } catch (Exception err) {
                    MessageBox.Show(err.Message);
                    MessageBox.Show("la pagina: " + i + " non contiene annunci");
                }
            }

            // aggiornamento colonna dei già selezionati
            foreach (ListViewItem row in lsvResults.Items) {
                found = DatiAnnuncio.TrovaId(_pathData, row.SubItems[colJobID].Text, ref annuncio);
                row.Checked = found;
            }

            lblTotAnn.Text = "Tot. Annunci: " + curRow.ToString();
            this.Cursor = Cursors.Default;
        }

        private void lsvResults_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem item = lsvResults.SelectedItems[0];
            item.Checked = true;

            string link = @"https://www.lapiazza.it" + item.SubItems[colJobID].Text;
            string jobId = item.SubItems[colJobID].Text;

            // aggiungere id alla lista degli annunci letti
            DatiAnnuncio annuncio = new DatiAnnuncio();
            bool found = DatiAnnuncio.TrovaId(_pathData, jobId, ref annuncio);

            if (!found) {
                GeneraEntry(jobId);
            }

            System.Diagnostics.Process.Start(link);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Program.extraData = new DatiAnnuncio();
            topPages.Value = Convert.ToDecimal(ConfigurationManager.AppSettings["topPages"]);

            if (!File.Exists(_pathData)) {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(_pathData)) {
                    //sw.WriteLine("Hello");
                }
            }
        }

        /*
        private string LeggiJobId(string link)
        {
            int s1 = link.IndexOf("offerte-lavoro&id=");
            string linkPart = link.Substring(s1 + 18);
            string res = string.Empty;

            foreach(char c in linkPart){
                if (c == ':')
                    break;
                else
                    res += c;
            }

            return res;
        }
        */

        private void GeneraEntry(string jobId)
        {
            using (StreamWriter sw = File.AppendText(_pathData)) {
                sw.WriteLine("[" + jobId + "]");
                sw.WriteLine("contattato=NO");
                sw.WriteLine("data_contatto=nessuna");
                sw.WriteLine("messaggio=nessuno");
                sw.WriteLine("note=nessuna");
                sw.WriteLine("evidenzia=NO");
                sw.WriteLine("nascosto=NO");
            }
        }

        private void menuEditItem_Click(object sender, EventArgs e)
        {
            if (lsvResults.SelectedItems.Count > 0) {
                ListViewItem row = lsvResults.SelectedItems[0];
                string jobId = row.SubItems[colJobID].Text;
                frmDatiAnnuncio formDatiExtra = new frmDatiAnnuncio(jobId);
                formDatiExtra.ShowDialog();

                if (!Program.extraData.Annulla) {
                    DatiAnnuncio annuncio = new DatiAnnuncio();
                    bool found = DatiAnnuncio.TrovaId(_pathData, jobId, ref annuncio);
                    if (!found) {
                        GeneraEntry(jobId);
                    }

                    // scrittura dati
                    FileIni ini = new FileIni();
                    ini.IniFile(_pathData);
                    ini.Write("contattato", Program.extraData.Contattato, jobId);
                    if (Program.extraData.Contattato == "SI")
                        ini.Write("data_contatto", DateTime.Now.ToShortDateString(), jobId);
                    ini.Write("messaggio", Program.extraData.Messaggio, jobId);
                    ini.Write("note", Program.extraData.Annotazioni, jobId);
                    ini.Write("nascosto", Program.extraData.Nascosto, jobId);
                    ini.Write("evidenzia", Program.extraData.Evidenzia, jobId);

                    row.Checked = true;

                    if (Program.extraData.Nascosto == "SI") {
                        lsvResults.Items.Remove(row);
                    } else {
                        if (Program.extraData.Contattato == "SI")
                            row.BackColor = Color.LightSalmon;
                        else if (Program.extraData.Evidenzia == "SI")
                            row.BackColor = Color.Yellow;
                        else
                            row.BackColor = Color.GhostWhite;
                    }
                }
            }
        }
    }
}
