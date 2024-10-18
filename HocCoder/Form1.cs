namespace HocCoder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region Classs
        List<DanhSachMailPassGui> ListMailGui = new List<DanhSachMailPassGui>();
        List<TieuDeNoiDungGui> ListTieuDeGui = new List<TieuDeNoiDungGui>();


        #endregion
        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnGui_Click(object sender, EventArgs e)
        {
            MessageBox.Show(TxtMailNhan.Text);
            MessageBox.Show(TxtTieuDe.Text);
            MessageBox.Show(TxtNoiDung.Text);
            MessageBox.Show("Thành Công");

        }
        public class DanhSachMailPassGui
        {
            public string EmailGui { get; set; }
            public string PasswordGui { get; set; }

        }

        private void BtnThemMailGui_Click(object sender, EventArgs e)
        {
            DanhSachMailPassGui Mail = new DanhSachMailPassGui();
            Mail.EmailGui = TxtEmail.Text;
            Mail.PasswordGui = TxtPass.Text;
            ListMailGui.Add(Mail);
            DGVDanhSachMailPassGui.DataSource = null;
            DGVDanhSachMailPassGui.DataSource = ListMailGui;

        }
        public class TieuDeNoiDungGui
        {
            public string TieuDeGui { get; set; }
            public string NoiDungGui { get; set; }

        }
        private void BtnThemNoiDung_Click(object sender, EventArgs e)
        {
            TieuDeNoiDungGui TieuNoi = new TieuDeNoiDungGui();
            TieuNoi.TieuDeGui = TxtTieuDeGui.Text;
            TieuNoi.NoiDungGui = TxtNoiDungGui.Text;
            ListTieuDeGui.Add(TieuNoi);
            DGVTieuDeNoiDungGui.DataSource = null;
            DGVTieuDeNoiDungGui.DataSource = ListTieuDeGui;

        }

        private void BtnXoaMailGui_Click(object sender, EventArgs e)
        {
            XoaMail(TxtEmail.Text);
        }
        public void XoaMail(string emailXoa)
        {
            var email = ListMailGui.Where(x => x.EmailGui == emailXoa).FirstOrDefault();
            ListMailGui.Remove(email);
            LoadDataEmail();
        }
        public void LoadDataEmail()
        {
            DGVDanhSachMailPassGui.DataSource = null;
            DGVDanhSachMailPassGui.DataSource = ListMailGui;
        }

        private void BtnXoaNoiDung_Click(object sender, EventArgs e)
        {
            XoaNoiDung(TxtTieuDeGui.Text);
        }
        public void XoaNoiDung(string TieuDeGuiXoa)
        {
            var TieuDeGui = ListTieuDeGui.Where(x => x.TieuDeGui == TieuDeGuiXoa).FirstOrDefault();
            ListTieuDeGui.Remove(TieuDeGui);
            LoadDataTieuDe();
        } 
        public void LoadDataTieuDe()
        {
            DGVTieuDeNoiDungGui.DataSource = null;
            DGVTieuDeNoiDungGui.DataSource = ListTieuDeGui;
        }
    }  
}