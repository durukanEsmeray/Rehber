using BusinessLogicLayer;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelefonRehberi
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            BusinessLogicLayer.BLL BLL = new BusinessLogicLayer.BLL();
            int ReturnValues = BLL.KayitEkle(txtYeniIsim.Text, txtYeniSoyisim.Text, txtYeniTelI.Text, txtYeniTelII.Text, txtYeniTelIII.Text, txtYeniEmailAdres.Text, txtYeniWebAdres.Text, txtYeniAdres.Text, txtYeniAciklama.Text);
            if (ReturnValues > 0)
            {
                ListeDoldur();
                MessageBox.Show("Yeni kayıt eklendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            ListeDoldur();
        }

        private void ListeDoldur() // database den rehber tablosundaki kayıtlarımızı, rehber tipinde bize verecek. Bizde onu listbox a vereceğiz. 
        {
            BusinessLogicLayer.BLL BLL = new BusinessLogicLayer.BLL();
            List<Rehber> RehberListesi = BLL.KayitListe();
            if (RehberListesi != null && RehberListesi.Count > 0)
            {
                lstListe.DataSource = RehberListesi;
            }
        }

        private void lstListe_DoubleClick(object sender, EventArgs e)
        {
            ListBox LST = (ListBox)sender;
            Rehber SecilenKayit = (Rehber)LST.SelectedItem;
            if (SecilenKayit != null)
            {
                txtGuncelIsim.Text = SecilenKayit.Isim;
                txtGuncelSoyisim.Text = SecilenKayit.Soyisim;
                txtGuncelEmailAdres.Text = SecilenKayit.EmailAdres;
                txtGuncelTelI.Text = SecilenKayit.TelefonNumarasiI;
                txtGuncelTelII.Text = SecilenKayit.TelefonNumarasiII;
                txtGuncelTelIII.Text = SecilenKayit.TelefonNumarasiIII;
                txtGuncelWebAdres.Text = SecilenKayit.WebAdres;
                txtGuncelAdres.Text = SecilenKayit.Adres;
                txtGuncelAciklama.Text = SecilenKayit.Aciklama;
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            Guid ID = ((Rehber)lstListe.SelectedItem).ID;
            BusinessLogicLayer.BLL BLL = new BusinessLogicLayer.BLL();
            int ReturnValues = BLL.KayitDuzenle(ID, txtGuncelIsim.Text, txtGuncelSoyisim.Text, txtGuncelTelI.Text, txtGuncelTelII.Text, txtGuncelTelIII.Text, txtGuncelEmailAdres.Text, txtGuncelWebAdres.Text, txtGuncelAdres.Text, txtGuncelAciklama.Text);
            if (ReturnValues > 0)
            {
                ListeDoldur();
                MessageBox.Show("Kaydınız güncellenmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Guid ID = ((Rehber)lstListe.SelectedItem).ID;
            BusinessLogicLayer.BLL BLL = new BusinessLogicLayer.BLL();
            int ReturnValues = BLL.KayitSil(ID);
            if(ReturnValues > 0)
            {
                ListeDoldur();
                MessageBox.Show("Kaydınız silinmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
