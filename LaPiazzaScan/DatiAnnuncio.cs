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
        public bool Annulla;

        public static bool TrovaId(string pathIni, string jobId, ref string nascosto)
        {
            bool res = false;
            FileIni mydata = new FileIni();
            
            mydata.IniFile(pathIni);
            res = mydata.KeyExists("nascosto", jobId);
            if (res)
                nascosto = mydata.Read("nascosto", jobId);
            else
                nascosto = "NO";

            mydata = null;
            return res;
        }
    }
}
