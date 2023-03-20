namespace TelefonRehberi
{
    public partial class Form1 : Form
    {
        BusinessLogicLayer.BLL bll;
        public Form1()
        {
            InitializeComponent();
            bll = new BusinessLogicLayer.BLL();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            int ReturnValues = bll.SistemKontrol(txtKullaniciAdi.Text, txtSifre.Text);
            if (ReturnValues > 0)
            {
                AnaForm AF = new AnaForm();
                AF.Show();
            }
            else
            {
                MessageBox.Show("Hatalý kullanýcý veya þifre giriþi", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}