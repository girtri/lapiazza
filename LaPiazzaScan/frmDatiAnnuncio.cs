using System;
using System.Windows.Forms;
using System.IO;

namespace LaPiazzaScan
{
    public partial class frmDatiAnnuncio : Form
    {
        public frmDatiAnnuncio(string jobId)
        {
            InitializeComponent();
            
            // carica dati
            string pathData = Path.Combine(Application.StartupPath, "datalist.ini");
            string nascosto = "";
            bool found = DatiAnnuncio.TrovaId(pathData, jobId, ref nascosto);

            if (found) {
                FileIni ini = new FileIni();
                ini.IniFile(pathData);

                optSI.Checked = (ini.Read("contattato", jobId) == "SI");
                chkNascondi.Checked = (ini.Read("nascosto", jobId) == "SI");
                txtDataContatto.Text = ini.Read("data_contatto", jobId);
                txtMsg.Text = parseRead(ini.Read("messaggio", jobId));
                txtNote.Text = parseRead(ini.Read("note", jobId));
            }
        }

        private void cmdSalva_Click(object sender, EventArgs e)
        {
            if (optSI.Checked)
                Program.extraData.Contattato = "SI";
            else
                Program.extraData.Contattato = "NO";

            if (chkNascondi.Checked)
                Program.extraData.Nascosto = "SI";
            else
                Program.extraData.Nascosto = "NO";

            Program.extraData.DataContatto = txtDataContatto.Text;
            Program.extraData.Messaggio = parseWrite(txtMsg.Text);
            Program.extraData.Annotazioni = parseWrite(txtNote.Text);
            Program.extraData.Annulla = false;
            this.Close();
        }

        private void cmdAnnulla_Click(object sender, EventArgs e)
        {
            Program.extraData.Annulla = true;
            this.Close();
        }

        private string parseRead(string data)
        {
            string res;
            res = data.Replace("|n", "\r\n");
            return res;
        }

        private string parseWrite(string data)
        {
            string res;
            res = data.Replace("\r\n", "|n");
            return res;
        }
    }
}
