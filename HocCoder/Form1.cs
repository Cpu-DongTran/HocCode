namespace HocCoder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region Classs //Gom Nhóm
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
            public string GhiChuGui { get; set; }

        }
        private void BtnThemNoiDung_Click(object sender, EventArgs e)
        {
            TieuDeNoiDungGui TieuNoi = new TieuDeNoiDungGui();//tạo new class để làm nơi chứa data
            TieuNoi.TieuDeGui = TxtTieuDeGui.Text;//gắn giá trị cho class
            TieuNoi.NoiDungGui = TxtNoiDungGui.Text;//gắn giá trị cho class
            TieuNoi.GhiChuGui = TxtGhiChuGui.Text;
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
            XoaNoiDungGui(TxtNoiDungGui.Text);//Gọi lại hàm xóa và truyền NoiDung cần xóa
        }
        public void XoaNoiDungGui(string NoiDungXoa)//khởi tạo hàm xóa
        {
            var Noidung = ListTieuDeGui.Where(x => x.NoiDungGui == NoiDungXoa).FirstOrDefault();//lọc ra Noi Dung cần xóa trên danh sách
            ListTieuDeGui.Remove(Noidung);//xóa NoiDung tìm được ra khỏi danh sách
            LoadDataNoiDung();//Load lại data trên lưới
        }
        public void LoadDataNoiDung()// Ham load lai data
        {
            DGVTieuDeNoiDungGui.DataSource = null;//làm trống data trên lưới
            DGVTieuDeNoiDungGui.DataSource = ListTieuDeGui;//nạp lại data
        }

        private void DGVDanhSachMailPassGui_CellClick(object sender, DataGridViewCellEventArgs e)//Click DataGridView Chuột Phải - properties - events - CellClick
        {
            int rowNumber = DGVDanhSachMailPassGui.CurrentCell.RowIndex;//lấy data dòng chọn trên lưới
            TxtEmail.Text = (string)DGVDanhSachMailPassGui.Rows[rowNumber].Cells[0].Value;//gắn dữ liệu lấy ra từ dòng chọn ra ngoài giao diện
            TxtPass.Text = (string)DGVDanhSachMailPassGui.Rows[rowNumber].Cells[1].Value;//gắn dữ liệu lấy ra từ dòng chọn ra ngoài giao diện
        }

        private void DGVTieuDeNoiDungGui_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGVTieuDeNoiDungGui_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowNumber = DGVTieuDeNoiDungGui.CurrentCell.RowIndex;
            TxtTieuDeGui.Text = (string)DGVTieuDeNoiDungGui.Rows[rowNumber].Cells[0].Value;
            TxtNoiDungGui.Text = (string)DGVTieuDeNoiDungGui.Rows[rowNumber].Cells[1].Value;
        }

        private void BtnXoaHetMailGui_Click(object sender, EventArgs e)
        {
            ListMailGui = new List<DanhSachMailPassGui>();
            LoadDataEmail();

        }

        private void BtnThemNhieu_Click(object sender, EventArgs e)
        {
            var data = TxtDanhSachMailPassGui.Text;
            var chuoi = data.Split('\n');
            foreach (var emailPass in chuoi)
            {
                var chuoiDaCat = emailPass.Split('|');
                DanhSachMailPassGui Mail = new DanhSachMailPassGui();//tạo new class để làm nơi chứa data
                Mail.EmailGui = chuoiDaCat[0];//gắn giá trị cho class
                Mail.PasswordGui = chuoiDaCat[1];//gắn giá trị cho class
                ListMailGui.Add(Mail);//add vào danh sách đã được khởi tạo
                DGVDanhSachMailPassGui.DataSource = null;//làm trống data trên lưới
                DGVDanhSachMailPassGui.DataSource = ListMailGui;//nạp lại data

            }
        }

        private void BtnThemNDNhieu_Click(object sender, EventArgs e)
        {
            var data = TxtTieuDeGui.Text;
            var chuoi = data.Split('\n');
            foreach (var TieuDeNoiDung in chuoi)
            {
                var chuoiDaCat = TieuDeNoiDung.Split('|');
               
                TieuDeNoiDungGui TieuNoi = new TieuDeNoiDungGui();//tạo new class để làm nơi chứa data
                TieuNoi.TieuDeGui = chuoiDaCat[0];//gắn giá trị cho class
                TieuNoi.NoiDungGui = chuoiDaCat[1];//gắn giá trị cho class
                if (chuoiDaCat.Count() <= 1)//đếm số lượng kiểm tra đúng điều kiện cho vào, không thì bỏ qua
                {
                    TieuNoi.GhiChuGui = chuoiDaCat[2];
                }
               
                ListTieuDeGui.Add(TieuNoi);//add vào danh sách đã được khởi tạo
                DGVTieuDeNoiDungGui.DataSource = null;//làm trống data trên lưới
                DGVTieuDeNoiDungGui.DataSource = ListTieuDeGui;//nạp lại data
            }
        }
    }
}