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
        public bool Annulla;

        public static bool TrovaId(string pathIni, string jobId)
        {
            bool res = false;
            FileIni mydata = new FileIni();
            
            mydata.IniFile(pathIni);
            res = mydata.KeyExists("contattato", jobId);
            mydata = null;
            return res;
        }
    }
}
