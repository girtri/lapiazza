using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaPiazzaScan
{
    class DatiAnnuncio
    {
        public string Contattato;
        public string DataContatto;
        public string Messaggio;
        public string Annotazioni;
        public string Nascosto;
        public string Evidenzia;
        public bool Annulla;

        public static bool TrovaId(string pathIni, string jobId, ref DatiAnnuncio annuncio)
        {
            bool res = false;
            FileIni mydata = new FileIni();
            
            mydata.IniFile(pathIni);
            res = mydata.KeyExists("nascosto", jobId);
            if (res) {
                annuncio.Nascosto = mydata.Read("nascosto", jobId);
                annuncio.Evidenzia = mydata.Read("evidenzia", jobId);
                annuncio.Contattato = mydata.Read("contattato", jobId);
            } else {
                annuncio.Nascosto = "NO";
                annuncio.Evidenzia = "NO";
                annuncio.Contattato = "NO";
            }

            mydata = null;
            return res;
        }
    }
}
