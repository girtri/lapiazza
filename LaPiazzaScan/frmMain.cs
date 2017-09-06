using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace LaPiazzaScan
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void cmdScan_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            bool first = true;
            string url;
            string xpath1 = "//div[@class='item_content_in']";
            //string xpath2 = "//div[contains(@class, 'item_title')]";

            // From Web
            var web = new HtmlWeb();
            int curRow = 0;

            for (int i = 1; i <= topPages.Value; i++) {
                if (first) {
                    url = txtUrl.Text;
                } else {
                    url = @"http://annuncilapiazza.it/ricerca/annunci?se=1&search=Cerca&se_cats[0]=80&start=" + (14 * (i - 1));
                }

                first = false;
                var doc = web.Load(url);
                foreach (HtmlNode n in doc.DocumentNode.SelectNodes(xpath1))
                {
                    HtmlNode n2 = n.SelectSingleNode("./div[@class='item_desc']");
                    curRow++;

                    string descr = n2.ChildNodes[1].InnerText.Replace("\t", "");
                    string link = n2.ChildNodes[1].Attributes[0].Value;

                    // determinazione dell'id annuncio
                    int s1 = link.IndexOf("offerte-lavoro&id=");
                    string jobId = link.Substring(s1 + 18, 5);

                    string[] values = { descr, link, jobId };
                    ListViewItem row = lsvResults.Items.Add(new ListViewItem(values));
                    if (curRow % 2 == 0) {
                        row.BackColor = Color.LightGray;
                    } else {
                        row.BackColor = Color.GhostWhite;
                    }
                }
            }

            lblTotAnn.Text = "Tot. Annunci: " + curRow.ToString();
            this.Cursor = Cursors.Default;
        }

        private void lsvResults_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem item = lsvResults.SelectedItems[0];
            item.Checked = true;
            string link = @"http://annuncilapiazza.it/ricerca/" + item.SubItems[1].Text;
            System.Diagnostics.Process.Start(link);
        }
    }
}
