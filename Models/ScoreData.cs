namespace WebAPI.Models
{
    public class ConsoleInfo
    {
        public long id { get; set; }
        public string SportCode { get; set; } = "1000";
        public string Sport { get; set; } = "Generic";
        public string ConsoleModel { get; set; } = "";
        public string FirmwareVersion { get; set; } = "";
    }
    public class ScoreData
    {
        public ScoreData() {
            id = 1;
            Pd = 1;
            Hs = Gs = 0;
            Hpo = Gpo = false;
            Htol = Gtol = 3;
        }
        public long id { get; set; }
        public int Pd { get; set; }
        public int Hs { get; set; }
        public int Gs { get; set; }
        public bool Hpo { get; set; }
        public bool Gpo { get; set; }
        public int Htol { get; set; }
        public int Gtol { get; set; }
        /*
        public string asJson() {
            return "{\"id\":" + id + ",\"Pd\":" + Pd + ",\"Hs\":" + Hs + ",\"Gs\":" + Gs + 
                ",\"Hpo\":\"" + Hpo + "\",\"Gpo\":\"" + Gpo + "\",\"Htol\":\"" + Htol + "\",\"Gtol\":\"" + Gtol + "\"}";
        }
        */
    }
    // This class is a superset of all the ScoreData derived classes. We use this as the database storage type
    // so that every class will have all its fields represented in the database. Consumers of *ScoreData classes
    // can ignore the extra fields, and do not need to set values in any unused fields.
    public class DbScoreData : ScoreData
    {
        public DbScoreData() : base() {
            BO = 0;
            Dn = 0;
            Dt = 0;
            Hto = Gto = false;
            Fl = false;
            Hb = Gb = false;
            Hf = Gf = 0;
            Hpn = Gpn = false;
        }
        // Football-specific fields
        public int BO { get; set; }
        public int Dn { get; set; }
        public int Dt { get; set; }
        public bool Hto { get; set; }
        public bool Gto { get; set; }
        public bool Fl { get; set; }
        // Basketball-specific fields
        public bool Hb { get; set; }
        public bool Gb { get; set; }
        public int Hf { get; set; }
        public int Gf { get; set; }
        // Hockey-specific fields
        public bool Hpn { get; set; }
        public bool Gpn { get; set; }
        // public string HpnTx { get; set; }
        // public string GpnTx { get; set; }

    }
    public class FootballScoreData : ScoreData
    {
        public FootballScoreData() : base() {
            BO = 0;
            Dn = 0;
            Dt = 0;
            Hto = Gto = false;
            Fl = false;
        }
        public int BO { get; set; }
        public int Dn { get; set; }
        public int Dt { get; set; }
        public bool Hto { get; set; }
        public bool Gto { get; set; }
        public bool Fl { get; set; }
        /*
        public new string asJson() {
            return "{\"id\":" + id + ",\"Pd\":" + Pd + ",\"Hs\":" + Hs + ",\"Gs\":" + Gs + 
                ",\"Hpo\":\"" + Hpo + "\",\"Gpo\":\"" + Gpo + "\",\"Htol\":\"" + Htol + "\",\"Gtol\":\"" + Gtol + 
                "\",\"BO\":" + BO + ",\"Dn\":" + Dn + ",\"Dt\":" + Dt + ",\"Hto\":\"" + Hto + 
                "\",\"Gto\":\"" + Gto + "\",\"Fl\":\"" + Fl + "\"}";
        }
        */
    }

    public class BasketballScoreData : ScoreData {
        public BasketballScoreData() : base() {
            Hb = Gb = false;
            Hf = Gf = 0;
        }
        public BasketballScoreData(ScoreData _base) {
            id = _base.id;
            Pd = _base.Pd;
            Hs = _base.Hs;
            Gs = _base.Gs;
            Htol = _base.Htol;
            Gtol = _base.Gtol;
            Hpo = _base.Hpo;
            Gpo = _base.Gpo;
        }
        public bool Hb { get; set; }
        public bool Gb { get; set; }
        public int Hf { get; set; }
        public int Gf { get; set; }
        /*
        public new string asJson() {
            return "{\"id\":" + id + ",\"Pd\":" + Pd + ",\"Hs\":" + Hs + ",\"Gs\":" + Gs + 
                ",\"Hpo\":\"" + Hpo + "\",\"Gpo\":\"" + Gpo + "\",\"Htol\":\"" + Htol + "\",\"Gtol\":\"" + Gtol + 
                "\",\"Hb\":" + Hb + ",\"Gb\":" + Gb + ",\"Hf\":" + Hf + ",\"Gf\":" + Gf + "\"}";
        }
        */
    }
    public class HockeyScoreData : ScoreData {
        public HockeyScoreData() : base() {
            Hpn = Gpn = false;
        }
        public bool Hpn { get; set; }
        public bool Gpn { get; set; }
    }
    public class SoccerScoreData : ScoreData {
        public SoccerScoreData() : base() {
        }
    }
}