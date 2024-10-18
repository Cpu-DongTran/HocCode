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
            MessageBox.Show(TxtMailNhan.Text);// lấy thông báo từ text
            MessageBox.Show(TxtTieuDe.Text);// lấy thông báo từ text
            MessageBox.Show(TxtNoiDung.Text);// lấy thông báo từ text
            MessageBox.Show("Thành Công");// lấy thông báo từ text

        }
        public class DanhSachMailPassGui//khởi tạo class
        {
            public string EmailGui { get; set; }//khởi tạo biến
            public string PasswordGui { get; set; }//khởi tạo biến

        }

        private void BtnThemMailGui_Click(object sender, EventArgs e)
        {
            DanhSachMailPassGui Mail = new DanhSachMailPassGui();//tạo new class để làm nơi chứa data
            Mail.EmailGui = TxtEmail.Text;//gắn giá trị cho class
            Mail.PasswordGui = TxtPass.Text;//gắn giá trị cho class
            ListMailGui.Add(Mail);//add vào danh sách đã được khởi tạo
            DGVDanhSachMailPassGui.DataSource = null;//làm trống data trên lưới
            DGVDanhSachMailPassGui.DataSource = ListMailGui;//nạp lại data

        }
        public class TieuDeNoiDungGui//khởi tạo class
        {
            public string TieuDeGui { get; set; }//khởi tạo biến
            public string NoiDungGui { get; set; }//khởi tạo biến

        }
        private void BtnThemNoiDung_Click(object sender, EventArgs e)
        {
            TieuDeNoiDungGui TieuNoi = new TieuDeNoiDungGui();//tạo new class để làm nơi chứa data
            TieuNoi.TieuDeGui = TxtTieuDeGui.Text;//gắn giá trị cho class
            TieuNoi.NoiDungGui = TxtNoiDungGui.Text;//gắn giá trị cho class
            ListTieuDeGui.Add(TieuNoi);//add vào danh sách đã được khởi tạo
            DGVTieuDeNoiDungGui.DataSource = null;//làm trống data trên lưới
            DGVTieuDeNoiDungGui.DataSource = ListTieuDeGui;//nạp lại data

        }

        private void BtnXoaMailGui_Click(object sender, EventArgs e)
        {
            XoaMail(TxtEmail.Text);//Gọi lại hàm xóa và truyền email cần xóa
        }
        public void XoaMail(string emailXoa)//khởi tạo hàm xóa
        {
            var email = ListMailGui.Where(x => x.EmailGui == emailXoa).FirstOrDefault();//lọc ra email cần xóa trên danh sách
            ListMailGui.Remove(email);//xóa email tìm được ra khỏi danh sách
            LoadDataEmail();//Load lại data trên lưới
        }
        public void LoadDataEmail()// Ham load lai data
        {
            DGVDanhSachMailPassGui.DataSource = null;//làm trống data trên lưới
            DGVDanhSachMailPassGui.DataSource = ListMailGui;//nạp lại data
        }

        private void BtnXoaNoiDung_Click(object sender, EventArgs e)
        {
            XoaNoiDung(TxtTieuDeGui.Text);//Gọi lại hàm xóa và truyền nội dung cần xóa
        }
        public void XoaNoiDung(string TieuDeGuiXoa)//khởi tạo hàm xóa
        {
            var TieuDeGui = ListTieuDeGui.Where(x => x.TieuDeGui == TieuDeGuiXoa).FirstOrDefault();//lọc ra email cần xóa trên danh sách
            ListTieuDeGui.Remove(TieuDeGui);//xóa email tìm được ra khỏi danh sách
            LoadDataTieuDe();//Load lại data trên lưới
        } 
        public void LoadDataTieuDe()// Ham load lai data
        {
            DGVTieuDeNoiDungGui.DataSource = null;//làm trống data trên lưới
            DGVTieuDeNoiDungGui.DataSource = ListTieuDeGui;//nạp lại data
        }
    }  
}