using BussinesLogic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public delegate void NotValidEvent(string errorMessage);
    public delegate void WarningEvent(string errorMessage);

    public abstract class Model
    {

        public DBConnection connection;
        public NotValidEvent notValid;

        public Model()
        {
            connection = new DBConnection();
        }

        public Model(NotValidEvent notValid)
        {
            connection = new DBConnection();
            this.notValid = notValid;
        }

        public abstract bool GetByID(long Id);

        public abstract bool Save();

        public abstract bool Delete();

        public abstract bool Check();
    }

    public static class Helper
    {
        public static string SanitizeString(object a)
        {
            return (a.Equals(System.DBNull.Value)) ? String.Empty : a.ToString();
        }

        public static Decimal SantitizeDecimal(object a)
        {
            decimal res;
            decimal.TryParse(a.ToString(), out res);
            return res;
        }

        public static int SantitizeInt(object a)
        {
            int res;
            int.TryParse(a.ToString(), out res);
            return res;
        }

        public static long SantitizeLong(object a)
        {
            long res;
            long.TryParse(a.ToString(), out res);
            return res;
        }

        public static double SantitizeDouble(object a)
        {
            double res;
            double.TryParse(a.ToString(), out res);
            return res;
        }

        public static DateTime SantitizeDateTime(object a)
        {
            DateTime res;
            DateTime.TryParse(a.ToString(), out res);
            return res;
        }
    }

    public class NArtikujt : Model
    {
        public long ID { get; set; }
        public string Emri { get; set; }
        public Njesia Njesi { get; set; }

        public NArtikujt()
        {
        }

        public NArtikujt(long ID)
        {
            GetByID(ID);
        }

        public NArtikujt(string emri)
        {
            GetByName(emri);
        }

        public NArtikujt(NotValidEvent notValid) : base(notValid)
        {

        }

        public override string ToString()
        {
            return this.Emri;
        }

        public NArtikujt(NotValidEvent notValid, long ID) : base(notValid)
        {
            GetByID(ID);
        }

        override
        public bool GetByID(long id)
        {
            try
            {
                string getNArtikujt = "SELECT * FROM NArtikujt WHERE ID = " + id;
                MapThis(Map(connection.Read(getNArtikujt).Rows[0]));
            }
            catch (Exception e)
            {
                notValid.Invoke(e.Message);
                return false;
            }
            return true;
        }

        public bool GetByName(string name)
        {
            try
            {
                string getNArtikujt = "SELECT * FROM NArtikujt WHERE Emri = '" + name +"'";
                MapThis(Map(connection.Read(getNArtikujt).Rows[0]));
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        override
        public bool Save()
        {
            try
            {
                if (this.ID == 0)
                {
                    this.connection.UpdateInsert("INSERT INTO NArtikujt (Emri, Njesia) VALUES ('" + this.Emri + "', '" + this.Njesi.ID + "')");
                    long insertedArtikullID = Helper.SantitizeLong(this.connection.Read("select max(ID) as maxid from NArtikujt").Rows[0][0]);
                    this.connection.UpdateInsert("INSERT INTO Magazina (NArtikullID, Sasia, Njesia) VALUES ('" + insertedArtikullID + "', '" + 0 + "', '" + this.Njesi.ID + "')");
                }
                else
                {
                    this.connection.UpdateInsert("UPDATE NArtikujt SET Emri = '" + this.Emri + "', Njesia = '" + this.Njesi.ID + "' WHERE ID=" + this.ID);
                    this.connection.UpdateInsert("UPDATE Magazina SET Njesia = '" + this.Njesi.ID + "' WHERE NArtikullID=" + this.ID);
                }
            }
            catch (Exception e)
            {
                notValid.Invoke(e.Message);
                return false;
            }
            return true;
        }

        override
        public bool Delete()
        {
            try
            {
                if (this.ID != 0)
                {
                    this.connection.UpdateInsert("DELETE NArtikujt.* FROM NArtikujt WHERE ID = " + this.ID);
                }
            }
            catch (Exception e)
            {
                notValid.Invoke(e.Message);
                return false;
            }
            return true;
        }

        override
        public bool Check()
        {
            throw new NotImplementedException();
        }

        public static NArtikujt Map(DataRow Row)
        {
            NArtikujt artikull = new NArtikujt();

            artikull.ID = Helper.SantitizeLong(Row["ID"]);
            artikull.Emri = Helper.SanitizeString(Row["Emri"]);
            artikull.Njesi = new Njesia(Helper.SantitizeLong(Row["Njesia"]));
            return artikull;
        }

        private void MapThis(NArtikujt artikulli)
        {
            this.ID = artikulli.ID;
            this.Emri = artikulli.Emri;
            this.Njesi = artikulli.Njesi;
        }

    }

    public class Klienti : Model
    {
        public long ID { get; set; }
        public string Emri { get; set; }
        public Klienti()
        {

        }

        public Klienti(long ID)
        {
            GetByID(ID);
        }

        public Klienti(string name)
        {
            GetByName(name);
        }

        public Klienti(NotValidEvent notValid) : base(notValid)
        {

        }

        public override string ToString()
        {
            return this.Emri;
        }

        public Klienti(NotValidEvent notValid, long ID) : base(notValid)
        {
            GetByID(ID);
        }

        public override bool GetByID(long Id)
        {
            try
            {
                string getNArtikujt = "SELECT * FROM Klientet WHERE ID = " + Id;
                MapThis(Map(connection.Read(getNArtikujt).Rows[0]));
            }
            catch (Exception e)
            {
                notValid.Invoke(e.Message);
                return false;
            }
            return true;
        }

        public bool GetByName(string Name)
        {
            try
            {
                string getNArtikujt = "SELECT * FROM Klientet WHERE Emri = '" + Name+"'";
                MapThis(Map(connection.Read(getNArtikujt).Rows[0]));
            }
            catch (Exception e)
            {
                notValid.Invoke(e.Message);
                return false;
            }
            return true;
        }

        public override bool Save()
        {
            try
            {
                if (this.ID == 0)
                {
                    this.connection.UpdateInsert("INSERT INTO Klientet (Emri) VALUES ('" + this.Emri + "')");
                }
                else
                {
                    this.connection.UpdateInsert("UPDATE Klientet SET Emri = '" + this.Emri + "' WHERE ID=" + this.ID);
                }
            }
            catch (Exception e)
            {
                notValid.Invoke(e.Message);
                return false;
            }
            return true;
        }

        public override bool Delete()
        {
            try
            {
                if (this.ID != 0)
                {
                    this.connection.UpdateInsert("DELETE Klientet.* FROM Njesia WHERE ID = " + this.ID);
                }
            }
            catch (Exception e)
            {
                notValid.Invoke(e.Message);
                return false;
            }
            return true;
        }

        public override bool Check()
        {
            throw new NotImplementedException();
        }

        public static Klienti Map(DataRow Row)
        {
            Klienti klienti = new Klienti();
            klienti.ID = Helper.SantitizeLong(Row["ID"]);
            klienti.Emri = Helper.SanitizeString(Row["Emri"]);
            return klienti;
        }

        private void MapThis(Klienti klienti)
        {
            this.ID = klienti.ID;
            this.Emri = klienti.Emri;
        }
    }

    public class Punetori : Model
    {
        public long ID { get; set; }
        public string Emri { get; set; }
        public string Mbiemri { get; set; }

        public Punetori()
        {

        }

        public Punetori(long ID)
        {
            GetByID(ID);
        }

        public override string ToString()
        {
            return this.Emri + " " + this.Mbiemri;
        }

        public Punetori(NotValidEvent notValid) : base(notValid)
        {

        }

        public Punetori(NotValidEvent notValid, long ID) : base(notValid)
        {
            GetByID(ID);
        }

        public override bool GetByID(long Id)
        {
            try
            {
                string getNArtikujt = "SELECT * FROM Punetoret WHERE ID = " + Id;
                MapThis(Map(connection.Read(getNArtikujt).Rows[0]));
            }
            catch (Exception e)
            {
                notValid.Invoke(e.Message);
                return false;
            }
            return true;
        }

        public override bool Save()
        {
            try
            {
                if (this.ID == 0)
                {
                    this.connection.UpdateInsert("INSERT INTO Punetoret (Emri, Mbiemri) VALUES ('" + this.Emri + "', '" + this.Mbiemri + "')");
                }
                else
                {
                    this.connection.UpdateInsert("UPDATE Punetoret SET Emri = '" + this.Emri + "', Mbiemri = '" + this.Mbiemri + "' WHERE ID=" + this.ID);
                }
            }
            catch (Exception e)
            {
                notValid.Invoke(e.Message);
                return false;
            }
            return true;
        }

        public override bool Delete()
        {
            try
            {
                if (this.ID != 0)
                {
                    this.connection.UpdateInsert("DELETE Punetoret.* FROM Punetoret WHERE ID = " + this.ID);
                }
            }
            catch (Exception e)
            {
                notValid.Invoke(e.Message);
                return false;
            }
            return true;
        }

        public override bool Check()
        {
            throw new NotImplementedException();
        }

        public static Punetori Map(DataRow row)
        {
            Punetori pn = new Punetori();
            pn.ID = Helper.SantitizeLong(row["ID"]);
            pn.Emri = Helper.SanitizeString(row["Emri"]);
            pn.Mbiemri = Helper.SanitizeString(row["Mbiemri"]);
            return pn;
        }

        private void MapThis(Punetori pn)
        {
            this.ID = pn.ID;
            this.Emri = pn.Emri;
            this.Mbiemri = pn.Mbiemri;
        }
    }

    public class Njesia : Model
    {
        public long ID { get; set; }
        public string Njesi { get; set; }

        public Njesia()
        {

        }

        public Njesia(long ID)
        {
            GetByID(ID);
        }

        public override string ToString()
        {
            return this.Njesi;
        }

        public Njesia(NotValidEvent notValid) : base(notValid)
        {

        }

        public Njesia(NotValidEvent notValid, long ID) : base(notValid)
        {
            GetByID(ID);
        }

        public override bool GetByID(long Id)
        {
            try
            {
                string getNArtikujt = "SELECT * FROM Njesia WHERE ID = " + Id;
                MapThis(Map(connection.Read(getNArtikujt).Rows[0]));
            }
            catch (Exception e)
            {
                notValid.Invoke(e.Message);
                return false;
            }
            return true;
        }

        public override bool Save()
        {
            try
            {
                if (this.ID == 0)
                {
                    this.connection.UpdateInsert("INSERT INTO Njesia (Njesia) VALUES ('" + this.Njesi + "')");
                }
                else
                {
                    this.connection.UpdateInsert("UPDATE Njesia SET Emri = '" + this.Njesi + "' WHERE ID=" + this.ID);
                }
            }
            catch (Exception e)
            {
                notValid.Invoke(e.Message);
                return false;
            }
            return true;
        }

        public override bool Delete()
        {
            try
            {
                if (this.ID != 0)
                {
                    this.connection.UpdateInsert("DELETE Njesia.* FROM Njesia WHERE ID = " + this.ID);
                }
            }
            catch (Exception e)
            {
                notValid.Invoke(e.Message);
                return false;
            }
            return true;
        }

        public override bool Check()
        {
            throw new NotImplementedException();
        }

        public static Njesia Map(DataRow row)
        {
            Njesia njesia = new Njesia();
            njesia.ID = Helper.SantitizeLong(row["ID"]);
            njesia.Njesi = Helper.SanitizeString(row["Njesia"]);
            return njesia;
        }

        private void MapThis(Njesia njesia)
        {
            this.ID = njesia.ID;
            this.Njesi = njesia.Njesi;
        }
    }

    public class Magazina
    {
        public NArtikujt NArtikull { get; set; }
        public double Sasia { get; set; }
        public Njesia Njesi { get; set; }
        private static DBConnection connection = new DBConnection();
        private static NotValidEvent notValid;

        public Magazina(NotValidEvent _notValid, long ID)
        {
            connection = new DBConnection();
            notValid = _notValid;
            GetByID(ID);
        }

        public Magazina()
        {
            connection = new DBConnection();
        }

        public bool GetByID(long Id)
        {
            try
            {
                string getNArtikujt = "SELECT * FROM Magazina WHERE NArtikullID = " + Id;
                Map(connection.Read(getNArtikujt));
            }
            catch (Exception e)
            {
                notValid.Invoke(e.Message);
                return false;
            }
            return true;
        }

        public static Magazina GetMagazina(long Id)
        {
            try
            {
                string getNArtikujt = "SELECT * FROM Magazina WHERE NArtikullID = " + Id;
                var dt = connection.Read(getNArtikujt);
                var mgz = _Map(dt);
                return mgz;
            }
            catch (Exception e)
            {
                //notValid.Invoke(e.Message);
                return null;
            }
        }


        public static bool Push(NArtikujt artikulli, double sasia)
        {
            bool check = true;
            try
            {
                var magazina = Magazina.GetMagazina(artikulli.ID);

                if (artikulli == null)
                {
                    check = false;
                }
                else
                {
                    connection.UpdateInsert("UPDATE Magazina SET Sasia = '" + (magazina.Sasia + sasia) + "' WHERE NArtikullID=" + magazina.NArtikull.ID);
                    check = true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
            return check;
        }

        public static bool Pull(NArtikujt artikulli, double sasia, NotValidEvent _notValid)
        {
            bool check = true;
            try
            {
                Magazina magazina = new Magazina(_notValid, artikulli.ID);

                if (artikulli == null)
                {
                    _notValid.Invoke("Error ne Magazine");
                    check = false;
                }
                else if (magazina.Sasia < sasia)
                {
                    _notValid.Invoke("Nuk ka mjaftueshem " + artikulli.Emri + " ne magazine !");
                    check = false;
                }
                else if (magazina.Sasia >= sasia)
                {
                    connection.UpdateInsert("UPDATE Magazina SET Sasia = '" + (magazina.Sasia - sasia) + "' WHERE NArtikullID=" + magazina.NArtikull.ID);
                    check = true;
                }
            }
            catch (Exception e)
            {
                _notValid.Invoke(e.Message);
                return false;
            }
            return check;
        }

        public static OleDbCommand SaveMagazina(NArtikujt artikulli, double sasia)
        {
            var mgz = Magazina.GetMagazina(artikulli.ID);
            return new OleDbCommand("UPDATE Magazina SET Sasia = '" + (mgz.Sasia - sasia) + "' WHERE NArtikullID=" + mgz.NArtikull.ID);
        }

        public static OleDbCommand AddMagazina(NArtikujt artikulli, double sasia)
        {
            var mgz = Magazina.GetMagazina(artikulli.ID);
            return new OleDbCommand("UPDATE Magazina SET Sasia = '" + (mgz.Sasia + sasia) + "' WHERE NArtikullID=" + mgz.NArtikull.ID);
        }

        private void Map(DataTable table)
        {
            if (table.Rows.Count > 0)
            {
                this.NArtikull = new NArtikujt(notValid, Helper.SantitizeLong(table.Rows[0]["NArtikullID"]));
                this.Njesi = new Njesia(notValid, Helper.SantitizeLong(table.Rows[0]["Njesia"]));
                this.Sasia = Helper.SantitizeDouble(table.Rows[0]["Sasia"]);
            }
            else
            {
                notValid.Invoke("Njesia nuk ekziston!");
            }
        }

        private static Magazina _Map (DataTable table)
        {
            if (table.Rows.Count > 0)
            {
                return new Magazina()
                {

                    NArtikull = new NArtikujt(notValid, Helper.SantitizeLong(table.Rows[0]["NArtikullID"])),
                    Njesi = new Njesia(notValid, Helper.SantitizeLong(table.Rows[0]["Njesia"])),
                    Sasia = Helper.SantitizeDouble(table.Rows[0]["Sasia"]),
                };
            }
            else
            {
                notValid.Invoke("Njesia nuk ekziston!");
                return null;
            }
        }
    }

    public class FatureDalje : Model
    {
        public long NoFature { get; set; }
        public DateTime Date { get; set; }
        public Klienti Klienti { get; set; }
        public Punetori Puntori { get; set; }

        public FatureDalje() : base ()
        {

        }

        public FatureDalje(NotValidEvent notValid) : base(notValid)
        {

        }

        public FatureDalje(long ID)
        {
            GetByID(ID);
        }

        override
        public bool GetByID(long id)
        {
            try
            {
                string getNArtikujt = "SELECT * FROM Fature_Dalje WHERE ID = " + id;
                Map(connection.Read(getNArtikujt));
            }
            catch (Exception e)
            {
                notValid.Invoke(e.Message);
                return false;
            }
            return true;
        }
        override
        public bool Save()
        {
            try
            {
                this.connection.UpdateInsert("INSERT INTO Fature_Dalje (NoFature, Data, KlientiID, PunetorID) " +
                    "VALUES (" +
                    "'" + this.NoFature + "', " +
                    "'" + this.Date + "', " +
                    "'" + this.Klienti.ID + "', " +
                    "'" + this.Puntori.ID + "'" +
                    ")"
                    );
            }
            catch (Exception e)
            {
                notValid.Invoke(e.Message);
                return false;
            }
            return true;
        }

        public static OleDbCommand SaveFatureDalje(FatureDalje fatureDalje)
        {
            return new OleDbCommand("INSERT INTO Fature_Dalje (NoFature, Data, KlientiID, PunetorID) " +
                    "VALUES (" +
                    "'" + fatureDalje.NoFature + "', " +
                    "'" + fatureDalje.Date + "', " +
                    "'" + fatureDalje.Klienti.ID + "', " +
                    "'" + fatureDalje.Puntori.ID + "'" +
                    ")"
                    );
        }

        private string GenereateFatureNo()
        {
            var timeNow = DateTime.Now;
            return timeNow.Year.ToString().Substring(2, 2) + timeNow.Month.ToString() + timeNow.Day.ToString() + timeNow.Minute.ToString() + new Random().Next(1000, 9999);
        }

        override
        public bool Delete()
        {
            return true;
        }

        override
        public bool Check()
        {
            throw new NotImplementedException();
        }

        private void Map(DataTable table)
        {
            if (table.Rows.Count > 0)
            {
                this.NoFature = Helper.SantitizeLong(table.Rows[0]["NoFature"]);
                this.Date = Helper.SantitizeDateTime(table.Rows[0]["Data"]);
                this.Klienti = new Klienti(notValid, Helper.SantitizeLong(table.Rows[0]["KlientiID"]));
                this.Puntori = new Punetori(notValid, Helper.SantitizeLong(table.Rows[0]["PunetorID"]));
            }
            else
            {
                notValid.Invoke("Artikulli nuk ekziston!");
            }
        }

        public static FatureDalje Map(DataRow row)
        {
            return new FatureDalje()
            {
                NoFature = Helper.SantitizeLong(row["NoFature"]),
                Date = Helper.SantitizeDateTime(row["Data"]),
                Klienti = new Klienti(Helper.SantitizeLong(row["KlientiID"])),
                Puntori = new Punetori(Helper.SantitizeLong(row["PunetorID"])),
            };
        }
    }

    public class ArtikullFature : Model
    {
        public long ID { get; set; }
        public long NoFature { get; set; }
        public NArtikujt NArtikull { get; set; }
        public double Sasia { get; set; }
        public double Cmimi { get; set; }
        public double Vlera { get; set; }
        public NotValidEvent notValid;

        public ArtikullFature(NotValidEvent notValid) : base(notValid)
        {
            this.notValid = notValid;
        }

        public ArtikullFature(NotValidEvent notValid, long ID) : base(notValid)
        {
            this.notValid = notValid;
            //GetByID(ID);
        }


        public override bool Check()
        {
            throw new NotImplementedException();
        }

        public override bool Delete()
        {
            throw new NotImplementedException();
        }

        public override bool GetByID(long Id)
        {
            throw new NotImplementedException();
        }


        public override bool Save()
        {
            try
            {
                if (this.ID == 0)
                {
                    this.connection.UpdateInsert("INSERT INTO ArtikullFature (NoFature, NArtikullID, Sasia, Cmimi) " +
                        "VALUES (" +
                        "'" + this.NoFature + "', " +
                        "'" + this.NArtikull.ID + "', " +
                        "'" + this.Sasia + "', " +
                        "'" + this.Cmimi + "'" +
                        ")"
                        );
                    Magazina.Pull(this.NArtikull, this.Sasia, notValid);
                }
            }
            catch (Exception e)
            {
                notValid.Invoke(e.Message);
                return false;
            }
            return true;
        }

        public static List<OleDbCommand> SaveArtikullFature(ArtikullFature artikullFature)
        {
            return new List<OleDbCommand>()
            {
            new OleDbCommand("INSERT INTO ArtikullFature (NoFature, NArtikullID, Sasia, Cmimi) " +
                        "VALUES (" +
                        "'" + artikullFature.NoFature + "', " +
                        "'" + artikullFature.NArtikull.ID + "', " +
                        "'" + artikullFature.Sasia + "', " +
                        "'" + artikullFature.Cmimi + "'" +
                        ")"
                    ),

            Magazina.SaveMagazina(artikullFature.NArtikull, artikullFature.Sasia)
            };
        }

        private void Map(DataTable table)
        {
            if (table.Rows.Count > 0)
            {
                this.ID = Helper.SantitizeLong(table.Rows[0]["ID"]);
                this.NArtikull = new NArtikujt(notValid, Helper.SantitizeLong(table.Rows[0]["NArtikullID"]));
                this.Sasia = Helper.SantitizeDouble(table.Rows[0]["Sasia"]);
                this.Cmimi = Helper.SantitizeDouble(table.Rows[0]["Cmimi"]);
                this.NoFature = Helper.SantitizeLong(table.Rows[0]["NoFature"]);
                this.Vlera = (Sasia * Cmimi);
            }
            else
            {
                notValid.Invoke("Artikulli nuk ekziston!");
            }
        }
    }

    public static class GetAll
    {
        public static DBConnection connection = new DBConnection();

        public static List<NArtikujt> GetNArtikujt()
        {
            List<NArtikujt> artikujts = new List<NArtikujt>();
            try
            {
                string getNArtikujt = "SELECT * FROM NArtikujt";
                var tb = connection.Read(getNArtikujt);
                foreach (DataRow row in tb.Rows)
                {
                    artikujts.Add(NArtikujt.Map(row));
                }

            }
            catch (Exception e)
            {
            }
            return artikujts;
        }

        public static DataTable GetFaturaByNr(long FaturaNo)
        {
            DataTable tb = new DataTable();
            List<NArtikujt> artikujts = new List<NArtikujt>();
            try
            {
                OleDbCommand Command = new OleDbCommand("GetFaturaByNo");
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.AddWithValue("FaturaNo", SqlDbType.BigInt).Value = FaturaNo;
                tb = connection.ReadSpc(Command);
            }
            catch (Exception e)
            {
            }
            return tb;
        }

        public static DataTable GetSales(DateTime start, DateTime end)
        {
            DataTable tb = new DataTable();
            List<NArtikujt> artikujts = new List<NArtikujt>();
            try
            { 
                OleDbCommand Command = new OleDbCommand("Shitje");
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.AddWithValue("startDate", SqlDbType.DateTime).Value = start.Date.ToString();
                Command.Parameters.AddWithValue("endDate", SqlDbType.DateTime).Value = end.Date.ToString();
                tb = connection.ReadSpc(Command);
            }
            catch (Exception e)
            {
            }
            return tb;
        }

        public static DataTable GetSales(DateTime start, DateTime end, long KlientiID)
        {
            DataTable tb = new DataTable();
            List<NArtikujt> artikujts = new List<NArtikujt>();
            try
            {
                OleDbCommand Command = new OleDbCommand("ShitjePerKliente");
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.AddWithValue("startDate", SqlDbType.DateTime).Value = start.Date.ToString();
                Command.Parameters.AddWithValue("endDate", SqlDbType.DateTime).Value = end.Date.ToString();
                Command.Parameters.AddWithValue("KlientiID", SqlDbType.BigInt).Value = KlientiID;
                tb = connection.ReadSpc(Command);
            }
            catch (Exception e)
            {
            }
            return tb;
        }


        public static DataTable GetShpenzimet(DateTime start, DateTime end)
        {
            DataTable tb = new DataTable();
            List<NArtikujt> artikujts = new List<NArtikujt>();
            try
            {
                OleDbCommand Command = new OleDbCommand("ShpenzimetRaport");
                Command.CommandType = CommandType.StoredProcedure;
                Command.Parameters.AddWithValue("startDate", SqlDbType.DateTime).Value = start.Date.ToString();
                Command.Parameters.AddWithValue("endDate", SqlDbType.DateTime).Value = end.Date.ToString();
                tb = connection.ReadSpc(Command);
            }
            catch (Exception e)
            {
            }
            return tb;
        }


        public static List<Klienti> GetKlientet()
        {
            List<Klienti> klientet = new List<Klienti>();
            try
            {
                string getNArtikujt = "SELECT * FROM Klientet";
                var tb = connection.Read(getNArtikujt);
                foreach (DataRow row in tb.Rows)
                {
                    klientet.Add(Klienti.Map(row));
                }
            }
            catch (Exception e)
            {
            }
            return klientet;
        }

        public static List<Punetori> GetPunetoret()
        {
            List<Punetori> punetoret = new List<Punetori>();
            try
            {
                string getNArtikujt = "SELECT * FROM Punetoret";
                var tb = connection.Read(getNArtikujt);
                foreach (DataRow row in tb.Rows)
                {
                    punetoret.Add(Punetori.Map(row));
                }
            }
            catch (Exception e)
            {
            }
            return punetoret;
        }

        public static List<Njesia> GetNjesite()
        {
            List<Njesia> njesia = new List<Njesia>();
            try
            {
                string getNArtikujt = "SELECT * FROM Njesia";
                var tb = connection.Read(getNArtikujt);
                foreach (DataRow row in tb.Rows)
                {
                    njesia.Add(Njesia.Map(row));
                }
            }
            catch (Exception e)
            {
            }
            return njesia;
        }

        public static List<FatureDalje> GetAllFaturat()
        {
            List<FatureDalje> fatura = new List<FatureDalje>();
            try
            {
                string getNArtikujt = "SELECT * FROM Fature_Dalje";
                var tb = connection.Read(getNArtikujt);
                foreach (DataRow row in tb.Rows)
                {
                    fatura.Add(FatureDalje.Map(row));
                }
            }
            catch (Exception e)
            {
            }
            return fatura;
        }
    }

    public class Fatura
    {
        public FatureDalje fature { get; set; }
        public List<ArtikullFature> artikujt { get; set; }
        public double totali { get; set; }
        private DBConnection conn = new DBConnection();

        //public FatureDalje GetByID(long ID)
        //{
        //    return new FatureDalje();
        //}

        public Fatura()
        {

        }

        public bool Save()
        {
            try
            {
                if (fature != null && artikujt.Count > 0)
                {
                    fature.Save();
                    foreach (var artikull in artikujt)
                    {
                        artikull.Save();
                    }
                }
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public bool _Save()
        {
            List<OleDbCommand> oleDbCommands = new List<OleDbCommand>();

            try
            {
                oleDbCommands.Add(FatureDalje.SaveFatureDalje(this.fature));
                foreach (var artikull in this.artikujt)
                {
                    oleDbCommands.AddRange(ArtikullFature.SaveArtikullFature(artikull));
                }
                
                return conn.UpdateInsert(oleDbCommands);
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }

    public class Shpenzime
    {
        public long ID { get; set; }
        public DateTime Data { get; set; }
        public Punetori punetori { get; set; }
        private DBConnection conn = new DBConnection();

        public bool Save()
        {
            try
            {
                this.conn.UpdateInsert("INSERT INTO Shpenzime (Data, PunetoriID) " +
                    "VALUES (" +
                    "'" + DateTime.Now + "', " +
                    "'" + this.punetori.ID + "'" +
                    ")"
                    );

                this.ID = Helper.SantitizeLong(this.conn.Read("select max(ID) as maxid from Shpenzime").Rows[0][0]);
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
    }

    public class FaturHyrje
    {
        public long FatureID { get; set; }
        public NArtikujt artikulli { get; set; }
        public double Sasia { get; set; }
        public double Cmimi { get; set; }
        public double Vlera { get; set; }
        public long shpenzimeID { get; set; }
        private DBConnection conn = new DBConnection();

        public bool Save()
        {
            bool check = true;
            try
            {
                this.conn.UpdateInsert("INSERT INTO Fatura_Hyrje (NArtikullID, ShpenzimeID, Cmimi, Sasia) VALUES (" +
                    "'" + this.artikulli.ID + "', " +
                    "'"+this.shpenzimeID + "', " +
                    "'"+this.Cmimi+"', " +
                    "'"+this.Sasia+"')");
                Magazina.Push(this.artikulli, this.Sasia);
            }
            catch (Exception e)
            {
                check = false;
            }
            return check;
        }
    }

    public class ShpenzimeExtra
    { 
        public long ExtraID { get; set; }
        public string Emertimi { get; set; }
        public string Pershkrimi { get; set; }
        public double Sasia { get; set; }
        public double Cmimi { get; set; }
        public Njesia njesia { get; set; }
        public long shpenzimeID { get; set; }
        public double Vlera { get; set; }
        private DBConnection conn = new DBConnection();

        public bool Save()
        {
            bool check = true;
            try
            {
                this.conn.UpdateInsert("INSERT INTO Shpenzime_Extra (Emertimi, Pershkrimi, Sasia, Cmimi, Njesia, ShpenzimeID) VALUES (" +
                    "'" + this.Emertimi + "', " +
                    "'" + this.Pershkrimi + "', " +
                    "'" + this.Sasia + "', " +
                    "'"+ this.Cmimi +"', "+
                    "'" + this.njesia.ID + "', " +
                    "'" + this.shpenzimeID + "'" +
                    ")"
                    );
            }
            catch (Exception e)
            {
                check = false;
            }
            return check;
        }
    }

    public class FaturaShpenzime
    {
        public Shpenzime shpenzime;
        public List<ShpenzimeExtra> shpenzimeExtra;
        public List<FaturHyrje> faturaHyrje { get; set; }
        public double Totali { get; set; }

        public bool Save()
        {
            bool check = true;
            try
            {
               if (faturaHyrje != null)
               { 
                    if (shpenzime.Save())
                    {
                        foreach (var fatura in faturaHyrje)
                        {
                            fatura.shpenzimeID = shpenzime.ID;
                            check = fatura.Save();
                        }
                    }
                    else
                    {
                        throw new Exception();
                    }
               }
               if (shpenzimeExtra != null)
               {
                    if (shpenzime.Save())
                    {
                        foreach (var fatura in shpenzimeExtra)
                        {
                            fatura.shpenzimeID = shpenzime.ID;
                            check = fatura.Save();
                        }
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
            }
            catch (Exception e)
            {
                return false;
            }
            return check;
        }

    }
}
