using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseLogicLayer
{
    public class DLL
    {
        SqlConnection con; // C# ile sql aarasındaki bağlantıyı sağlamak
        SqlCommand cmd; // SqlConnection ile sağlanan bağlantı üzerinden t-sql sorgularımızı sql server a göndermemize ve çalıştırmamıza yarıyor.
        SqlDataReader reader; // Sql tarafından çekmiş olduğumuz datamızı C# tarafında karşıladığımız bir nesnemiz.
        int ReturnValues; // bu int değişkenini ise ; etkilenen kayıt sayılarını, yani; insert-update-delete işlemlerimde etkilenen kayıt sayılarımı sql tarafından C# tarafına aktarılınca bu değişiklikleri tutabilmek için 

        public DLL()
        {
            // oluşturmuş olduğum nesneleri örnekleyip DatabaseLogicLayer katmanıma yazıyor olacağım.
            con = new SqlConnection("data source=.; initial catalog =TelefonRehberi; user Id = sa; password=123456;");
        }

        public void BaglantiAyarla()
        {
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
            else
                con.Close();
        }

        public int KayitEkle(Rehber R)
        {
            try
            {
                cmd = new SqlCommand("insert into Rehber (ID, Isim, Soyisim, TelefonNumarasiI, TelefonNumarasiII,TelefonNumarasiIII,EmailAdres,WebAdres,Adres,Aciklama) values (@ID, @Isim, @Soyisim, @TelefonNumarasiI, @TelefonNumarasiII,@TelefonNumarasiIII,@EmailAdres,@WebAdres,@Adres,@Aciklama)", con);
                cmd.Parameters.Add("@ID", SqlDbType.UniqueIdentifier).Value = R.ID;
                cmd.Parameters.Add("@Isim", SqlDbType.NVarChar).Value = R.Isim;
                cmd.Parameters.Add("@Soyisim", SqlDbType.NVarChar).Value = R.Soyisim;
                cmd.Parameters.Add("@TelefonNumarasiI", SqlDbType.NVarChar).Value = R.TelefonNumarasiI;
                cmd.Parameters.Add("@TelefonNumarasiII", SqlDbType.NVarChar).Value = R.TelefonNumarasiII;
                cmd.Parameters.Add("@TelefonNumarasiIII", SqlDbType.NVarChar).Value = R.TelefonNumarasiIII;
                cmd.Parameters.Add("@EmailAdres", SqlDbType.NVarChar).Value = R.EmailAdres;
                cmd.Parameters.Add("@WebAdres", SqlDbType.NVarChar).Value = R.WebAdres;
                cmd.Parameters.Add("@Adres", SqlDbType.NVarChar).Value = R.Adres;
                cmd.Parameters.Add("@Aciklama", SqlDbType.NVarChar).Value = R.Aciklama;
                BaglantiAyarla(); // C# ile sql arasındaki bağlantıyı açıyorum.
                ReturnValues = cmd.ExecuteNonQuery(); // Hazırlamış olduğum insert sorgusunu sql server a göndereceğim.


                // cmd.Parameters.Add aslında bir koleksiyon. Kendi içerisinde parametreler almakta. Almış olduğu parametreler, insert tarafında vermiş olduğum @ID, @Isim. ,,, değerlerinin C# tarafında ki nesne içerisindeki değer karşılıkları. 
                // Yani @ID parametresine SqlDbType ı UniqueIdentifier yani C# tarafında bunun karşılığı Guid.Value dedikten sonra R nesnesi içerisindeki ID değerimi atıyorum. 
                // Kod çalıştığı zaman aslında Values tarafında yani @ID den @Aciklama ya kadar olan kısım da değerleri dinamik olarak R üzerindeki vermiş olduğum field larım oluyor.
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                BaglantiAyarla();
            }
            return ReturnValues;
        }
    }
}
