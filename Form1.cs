using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxWMPLib;
using TagLib;
using Guna.UI2.WinForms;
using trinhphatnhac5._0.Properties;

namespace trinhphatnhac5._0
{
    public partial class Form1 : Form
    {
        //Cập nhật tên hiển thị bài hát
        private void UpdateSongTitle(string name, bool isVisible)
        {
            labelSongTitle.Text = name;
        }
        private void UpdateSongImage(string filePath)
        {
            // Kiểm tra nếu là file MP4 thì ẩn PictureBox đi
            if (Path.GetExtension(filePath).ToLower() == ".mp4")
            {
                guna2PictureBox1.Visible = false; // Ẩn hoàn toàn control
                return;
            }

            // Nếu không phải MP4, đảm bảo PictureBox được hiện lại
            guna2PictureBox1.Visible = true;

            try
            {
                var file = TagLib.File.Create(filePath);
                if (file.Tag.Pictures.Length > 0)
                {
                    var bin = file.Tag.Pictures[0].Data.Data;
                    using (MemoryStream ms = new MemoryStream(bin))
                    {
                        guna2PictureBox1.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    guna2PictureBox1.Image = Properties.Resources.Lauriel_AOV; // Ảnh mặc định MP3
                }
            }
            catch
            {
                guna2PictureBox1.Image = Properties.Resources.Lauriel_AOV;
            }
        }
        private void RefreshSTT()
        {
            // Duyệt tất cả các bài hát trong ListBox
            for (int i = 0; i < TrackList.Items.Count; i++)
            {
                if (TrackList.Items[i] is Song s)
                {
                    s.STT = i + 1; // Gán số thứ tự 1, 2, 3...
                }
            }
            // Ép ListBox nạp lại dữ liệu để chuyển từ số 0 sang số vừa gán
            for (int i = 0; i < TrackList.Items.Count; i++)
            {
                TrackList.Items[i] = TrackList.Items[i];
            }
        }

        private string FormatTime(double seconds)
        {
            // Chuyển đổi số giây thành đối tượng TimeSpan
            TimeSpan t = TimeSpan.FromSeconds(seconds);

            // Kiểm tra nếu thời gian lớn hơn hoặc bằng 1 giờ
            if (t.Hours > 0)
            {
                return string.Format("{0:D2}:{1:D2}:{2:D2}", t.Hours, t.Minutes, t.Seconds);
            }
            // Trả về định dạng phút:giây
            return string.Format("{0:D2}:{1:D2}", t.Minutes, t.Seconds);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Điều chỉnh âm lượng volumne khớp với WMP
            axWindowsMediaPlayer1.settings.volume = volume.Value;
        }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            // Khởi tạo hộp thoại mở file hệ thống
            OpenFileDialog openfiledialog = new OpenFileDialog(); 
            openfiledialog.Multiselect = true; // Chọn nhiều file cùng lúc

            if (openfiledialog.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < openfiledialog.FileNames.Length; i++)
                {
                    //Tạo đối tượng Song từ dữ liệu chọn được
                    Song newSong = new Song();
                    newSong.Name = openfiledialog.SafeFileNames[i];
                    newSong.Path = openfiledialog.FileNames[i];

                    // Thêm đối tượng vào list box
                    this.TrackList.Items.Add(newSong);
                }
                RefreshSTT(); // Cập nhật hàm thứ tự
            }
        }

        private void TrackList_Click(object sender, EventArgs e)
        {
            // Kiểm tra người dùng có chọn dòng nào không
            if (TrackList.SelectedIndex != -1)
            {
                // Lấy đối tượng Song từ dòng đang được chọn
                // Ép kiểu (cast) Item về lại kiểu Song
                Song selectedSong = (Song)TrackList.SelectedItem;

                // Gán đường dẫn vào Player từ thuộc tính Path của class Song
                axWindowsMediaPlayer1.URL = selectedSong.Path;

                this.Text = "Đang phát: " + selectedSong.Name; // hiển thị tên trên label
            }
            // Cập nhật ảnh
            if (TrackList.SelectedItem != null)
            {
                Song selectedSong = (Song)TrackList.SelectedItem;
                axWindowsMediaPlayer1.URL = selectedSong.Path;

                // Cập nhật ảnh ngay khi double click vào bài hát
                UpdateSongImage(selectedSong.Path);
                // Cập nhật nhãn tên bài hát
                UpdateSongTitle(selectedSong.Name, true);
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (TrackList.Items.Count > 0)
            {
                if (TrackList.SelectedIndex == -1)
                {
                    TrackList.SelectedIndex = 0;
                }
                else if (TrackList.SelectedIndex > 0)
                {
                    // Giảm vị trí đi 1
                    TrackList.SelectedIndex = TrackList.SelectedIndex - 1;
                }
                else
                {
                    // Nếu đang ở bài đầu thì nhảy xuống bài cuối
                    TrackList.SelectedIndex = TrackList.Items.Count - 1;
                }

                // 1. Lấy đối tượng Song đang được chọn
                if (TrackList.SelectedItem != null)
                {
                    Song selectedSong = (Song)TrackList.SelectedItem;

                    // 2. Phát bài mới bằng đường dẫn lấy từ đối tượng Song
                    axWindowsMediaPlayer1.URL = selectedSong.Path;
                    axWindowsMediaPlayer1.Ctlcontrols.play();

                    UpdateSongImage(selectedSong.Path);
                    UpdateSongTitle(selectedSong.Name, true);
                }
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (TrackList.Items.Count > 0)
            {
                // Nếu chưa chọn bài nào, mặc định chọn bài đầu
                if (TrackList.SelectedIndex == -1)
                {
                    TrackList.SelectedIndex = 0;
                }
                else if (TrackList.SelectedIndex < TrackList.Items.Count - 1)
                {
                    // Tăng vị trí lên 1
                    TrackList.SelectedIndex = TrackList.SelectedIndex + 1;
                }
                else
                {
                    // Nếu là bài cuối thì quay về bài đầu
                    TrackList.SelectedIndex = 0;
                }
                if (TrackList.SelectedItem != null)
                {
                    Song selectedSong = (Song)TrackList.SelectedItem;

                    //Phát bài mới bằng đường dẫn lấy từ đối tượng Song
                    axWindowsMediaPlayer1.URL = selectedSong.Path;
                    axWindowsMediaPlayer1.Ctlcontrols.play();

                    UpdateSongImage(selectedSong.Path);
                    UpdateSongTitle(selectedSong.Name, true);
                }

            }
        }
        private void btnPlay(object sender, EventArgs e)
        {
            if (TrackList.Items.Count == 0)
            {
                MessageBox.Show("Danh sách trống, vui lòng chọn file nhạc!");
                return;
            }

            // Chưa chọn bài nào trong ListBox, mặc định chọn bài đầu tiên
            if (TrackList.SelectedIndex == -1)
            {
                TrackList.SelectedIndex = 0;
            }

            // 3. Xử lý Phát/Dừng
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
            }
            else
            {
                // Lấy đối tượng Song đang được chọn trong ListBox
                if (TrackList.SelectedItem != null)
                {
                    Song selectedSong = (Song)TrackList.SelectedItem;

                    // Kiểm tra nếu là bài mới hoặc vừa mở app
                    // So sánh URL hiện tại của Player với đường dẫn (Path) của bài hát
                    if (string.IsNullOrEmpty(axWindowsMediaPlayer1.URL) || axWindowsMediaPlayer1.URL != selectedSong.Path)
                    {
                        axWindowsMediaPlayer1.URL = selectedSong.Path;
                    }

                    // 3. Chạy nhạc
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
            }
        }
        private void TrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = TrackBar1.Value; // di chuyển thanh nhạc
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn bài nào trong ListBox chưa
            if (TrackList.SelectedIndex != -1)
            {
                // Hỏi xác nhận trước khi xóa
                DialogResult confirm = MessageBox.Show("Bạn có muốn xóa bài hát này khỏi danh sách?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    // Lấy đối tượng Song đang chọn
                    Song selectedSong = (Song)TrackList.SelectedItem;

                    // Nếu bài đang xóa chính là bài đang phát thì dừng phát nhạc
                    if (axWindowsMediaPlayer1.URL == selectedSong.Path)
                    {
                        axWindowsMediaPlayer1.Ctlcontrols.stop();
                        axWindowsMediaPlayer1.URL = ""; // Reset đường dẫn

                        // Reset giao diện về trạng thái chờ
                        labeCurrentTime.Text = "00:00";
                        label3.Text = "00:00";
                        TrackBar1.Value = 0;
                        labelSongTitle.Visible = false;
                        labelSongTitle.Text = "";
                    }

                    //Xóa bài hát khỏi ListBo
                    TrackList.Items.RemoveAt(TrackList.SelectedIndex);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một bài hát trong danh sách để xóa!", "Thông báo");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
         
        }
       
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // Khi bấm nút playing thì nhảy thanh hồng
            indicator.Top = btnPlaying.Top + 11;
            tabControl1.SelectedIndex = 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Thiết kế nút close
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
             this.Close();
        }

        private void btnExplore_Click(object sender, EventArgs e)
        {
            // Khi nhấn nút Explore sẽ hiện thêm nút màu hồng
            indicator.Top = btnExplore.Top + 11;
            tabControl1.SelectedIndex = 1;
        }

        private void volume_Scroll(object sender, ScrollEventArgs e)
        {
            // Gán giá trị của thanh trượt WMP trực tiếp vào âm lượng của trình phát nhạc
            axWindowsMediaPlayer1.settings.volume = volume.Value;

            // Tự động bỏ tắt tiếng (unmute) nếu người dùng đang kéo thanh âm lượng
            if (axWindowsMediaPlayer1.settings.mute == true)
            {
                axWindowsMediaPlayer1.settings.mute = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                // Cập nhật thanh trượt (TrackBar)
                TrackBar1.Maximum = (int)axWindowsMediaPlayer1.currentMedia.duration;
                TrackBar1.Value = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;

                // Cập nhật nhãn thời gian hiện tại
                labeCurrentTime.Text = FormatTime(axWindowsMediaPlayer1.Ctlcontrols.currentPosition);

                // Cập nhật nhãn tổng thời gian bài hát
                label3.Text = FormatTime(axWindowsMediaPlayer1.currentMedia.duration);
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

       
        private void btnVolume_Click(object sender, EventArgs e)
        {

        }

        private void labeCurrentTime_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

    }
}
