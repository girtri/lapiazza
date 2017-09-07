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
            bool found = DatiAnnuncio.TrovaId(pathData, jobId);

            if (found) {
                FileIni ini = new FileIni();
                ini.IniFile(pathData);

                optSI.Checked = (ini.Read("contattato", jobId) == "SI");
                txtDataContatto.Text = ini.Read("data_contatto", jobId);
                txtMsg.Text = ini.Read("messaggio", jobId);
                txtNote.Text = ini.Read("note", jobId);
            }
        }

        private void cmdSalva_Click(object sender, EventArgs e)
        {
            if (optSI.Checked)
                Program.extraData.Contattato = "SI";
            else
                Program.extraData.Contattato = "NO";
            Program.extraData.DataContatto = txtDataContatto.Text;
            Program.extraData.Messaggio = txtMsg.Text;
            Program.extraData.Annotazioni = txtNote.Text;
            Program.extraData.Annulla = false;
            this.Close();
        }

        private void cmdAnnulla_Click(object sender, EventArgs e)
        {
            Program.extraData.Annulla = true;
            this.Close();
        }
    }
}
