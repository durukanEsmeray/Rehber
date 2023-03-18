using Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class BLL
    {
        DatabaseLogicLayer.DLL dll;

        public BLL()
        {
            dll = new DatabaseLogicLayer.DLL();
        }

        public int SistemKontrol(string kullaniciAdi, string sifre)
        {
            if (!string.IsNullOrEmpty(kullaniciAdi) && !string.IsNullOrEmpty(sifre))
            {
                return dll.SistemKontrol(new Entities.Kullanici()
                {
                    KullaniciAdi = kullaniciAdi,
                    Sifre = sifre
                });
            }
            else
            {
                return -1;
            }
        }

        public int KayitEkle(string Isim, string Soyisim, string TelefonNumarasiI, string TelefonNumarasiII, string TelefonNumarasiIII, string EmailAdres, string WebAdres, string Adres, string Aciklama)
        {
            if (!string.IsNullOrEmpty(Isim) && !string.IsNullOrEmpty(Soyisim) && !string.IsNullOrEmpty(TelefonNumarasiI))
            {
                return dll.KayitEkle(new Entities.Rehber()
                {
                    ID = Guid.NewGuid(),
                    Isim = Isim,
                    Soyisim = Soyisim,
                    TelefonNumarasiI = TelefonNumarasiI,
                    TelefonNumarasiII = TelefonNumarasiII,
                    TelefonNumarasiIII = TelefonNumarasiIII,
                    EmailAdres = EmailAdres,
                    WebAdres = WebAdres,
                    Adres = Adres,
                    Aciklama = Aciklama
                });
            }
            else
            {
                return -1; //eksik parametre hatası
            }
        }

        public int KayitDuzenle(Guid ID, string Isim, string Soyisim, string TelefonNumarasiI, string TelefonNumarasiII, string TelefonNumarasiIII, string EmailAdres, string WebAdres, string Adres, string Aciklama)
        {
            if (ID != Guid.Empty)
            {
                return dll.KayitDuzenle(new Entities.Rehber()
                {
                    ID = ID,
                    Isim = Isim,
                    Soyisim = Soyisim,
                    TelefonNumarasiI = TelefonNumarasiI,
                    TelefonNumarasiII = TelefonNumarasiII,
                    TelefonNumarasiIII = TelefonNumarasiIII,
                    WebAdres = WebAdres,
                    Aciklama = Aciklama,
                    Adres = Adres,
                    EmailAdres = EmailAdres
                });
            }
            else
            {
                return -1;
            }
        }

        public int KayitSil(Guid ID)
        {
            if (ID != Guid.Empty)
            {
                return dll.KayitSil(ID);
            }
            else
            {
                return -1;
            }
        }

        public List<Rehber> KayitListe()
        {
            List<Rehber> RehberListesi = new List<Rehber>();
            try
            {
                SqlDataReader reader = dll.KayitListe();
                while (reader.Read())
                {
                    RehberListesi.Add(new Rehber()
                    {
                        ID = reader.IsDBNull(0) ? Guid.Empty : reader.GetGuid(0),
                        Isim = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                        Soyisim = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                        TelefonNumarasiI = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                        TelefonNumarasiII = reader.IsDBNull(4) ? string.Empty : reader.GetString(4),
                        TelefonNumarasiIII = reader.IsDBNull(5) ? string.Empty : reader.GetString(5),
                        EmailAdres = reader.IsDBNull(6) ? string.Empty : reader.GetString(6),
                        WebAdres = reader.IsDBNull(7) ? string.Empty : reader.GetString(7),
                        Adres = reader.IsDBNull(8) ? string.Empty : reader.GetString(8),
                        Aciklama = reader.IsDBNull(9) ? string.Empty : reader.GetString(9)
                    });
                }
                reader.Close();
            }
            catch (Exception ex)
            {


            }
            finally
            {
                dll.BaglantiAyarla();
            }
            return RehberListesi;
        }

        public Rehber KayitListeID(Guid ID)
        {
            Rehber RehberKayit = new Rehber();
            try
            {
                SqlDataReader reader = dll.KayitListeID(ID);
                while (reader.Read())
                {
                    RehberKayit = new Rehber()
                    {
                        ID = reader.IsDBNull(0) ? Guid.Empty : reader.GetGuid(0),
                        Isim = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                        Soyisim = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                        TelefonNumarasiI = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                        TelefonNumarasiII = reader.IsDBNull(4) ? string.Empty : reader.GetString(4),
                        TelefonNumarasiIII = reader.IsDBNull(5) ? string.Empty : reader.GetString(5),
                        EmailAdres = reader.IsDBNull(6) ? string.Empty : reader.GetString(6),
                        WebAdres = reader.IsDBNull(7) ? string.Empty : reader.GetString(7),
                        Adres = reader.IsDBNull(8) ? string.Empty : reader.GetString(8),
                        Aciklama = reader.IsDBNull(9) ? string.Empty : reader.GetString(9)
                    };
                }
                reader.Close();
            }
            catch (Exception ex)
            {


            }
            finally
            {
                dll.BaglantiAyarla();
            }
            return RehberKayit;
        }
    }
}
