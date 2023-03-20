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
    }
}
