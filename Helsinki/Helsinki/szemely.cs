using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helsinki
{
    class szemely
    {
        int helyezes;
        int sp_szam;
        string sportag;
        string versenyszam;

        public szemely(int helyezes, int sp_szam, string sportag, string versenyszam)
        {
            Helyezes = helyezes;
            Sp_szam = sp_szam;
            Sportag = sportag;
            Versenyszam = versenyszam;
        }

        public int Helyezes { get => helyezes; set => helyezes = value; }
        public int Sp_szam { get => sp_szam; set => sp_szam = value; }
        public string Sportag { get => sportag; set => sportag = value; }
        public string Versenyszam { get => versenyszam; set => versenyszam = value; }
    }
}
