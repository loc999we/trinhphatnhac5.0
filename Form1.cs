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
using Guna.UI2.WinForms;
using trinhphatnhac5._0.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace trinhphatnhac5._0
{
    public partial class Form1 : Form
    {
        // Cập nhật list box khi dùng clear()
        private void UpdateTrackListUI()
        {
            TrackList.Items.Clear();
            Node<Song> temp = Playlist.GetFirst();
            while (temp != null)
            {
                TrackList.Items.Add(temp.element);
                temp = temp.flink;
            }
        // Giữ cho STT hiển thị đúng
            for (int i = 0; i < TrackList.Items.Count; i++)
                TrackList.Items[i] = TrackList.Items[i];
        }
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
            // 1. Duyệt qua LinkedList để cập nhật thuộc tính STT bên trong mỗi đối tượng Song
            // Chúng ta bắt đầu từ Node đầu tiên
            Node<Song> temp = Playlist.GetFirst();
            int count = 1;

            while (temp != null)
            {
                if (temp.element != null)
                {
                    temp.element.STT = count; // Gán số thứ tự mới
                    count++;
                }
                temp = temp.flink; // Nhảy sang Node kế tiếp (Duyệt danh sách liên kết)
            }

            // 2. Ép ListBox nạp lại giao diện
            // ListBox không tự biết dữ liệu bên trong Song đã đổi, nên ta cần "refresh" nó
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

        private DoublyLinkedList<Song> Playlist = new DoublyLinkedList<Song>();
        private Node<Song> currentNode = null; // Node đang phát hiện tại
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
                    Song newSong = new Song ();
                    // Gán giá trị đường dẫn
                    newSong.Name = openfiledialog.SafeFileNames[i];
                    newSong.Path = openfiledialog.FileNames[i];
                    Playlist.Insert(newSong); // Thêm vào LinkedList
                    // Thêm bài hát vào list box
                    this.TrackList.Items.Add(newSong);
                }
                RefreshSTT(); // Cập nhật STT
            }
        }

        private void TrackList_Click(object sender, EventArgs e)
        {
            // Kiểm tra dòng nào được chọn không
            if (TrackList.SelectedIndex != -1)
            {
                //Tìm Node tương ứng trong LinkedList
                currentNode = Playlist.GetNodeAt(TrackList.SelectedIndex);
                if (currentNode != null)
                {
                    // Lấy dữ liệu bài hát từ Node 
                    Song selectedSong = currentNode.element;
                    //Cập nhật Player và Giao diện
                    axWindowsMediaPlayer1.URL = selectedSong.Path;
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    UpdateSongImage(selectedSong.Path);
                    UpdateSongTitle(selectedSong.Name, true);
                }
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            // Kiểm tra null
            if (Playlist.IsEmpty())
            {
                return;
            }
            // Xác định Node phía trước
            if (currentNode == null || currentNode.blink == null)
            {
                // Nếu chưa chọn bài nào hay bài đầu tiên thì về bài cuối cùng
                currentNode = Playlist.GetLast();
            }
            else
            {
                // Sử dụng blink để lùi lại 1 Node
                currentNode = currentNode.blink;
            }

            // Cập nhật nhạc và giao diện từ Node hiện tại
            if (currentNode != null)
            {
                Song prevSong = currentNode.element; // Lấy dữ liệu bài hát từ Node

                // Phát nhạc bằng đường dẫn từ đối tượng Song
                axWindowsMediaPlayer1.URL = prevSong.Path;
                axWindowsMediaPlayer1.Ctlcontrols.play();

                // Đồng bộ giao diện ListBox
                TrackList.SelectedItem = prevSong;
                // Cập nhật các thành phần hiển thị khác
                UpdateSongImage(prevSong.Path);
                UpdateSongTitle(prevSong.Name, true);
                this.Text = "Đang phát: " + prevSong.Name;
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            // Kiểm tra null
            if (Playlist.IsEmpty())
            {
                MessageBox.Show("Danh sách phát đang trống!");
                return;
            }

            //Xác định Node tiếp theo
            if (isShuffle)
            {
                // Chế độ ngẫu nhiên
                Random rand = new Random();
                int randomIndex = rand.Next(0, TrackList.Items.Count);
                currentNode = Playlist.GetNodeAt(randomIndex);
            }
            else
            {
                // Chế độ tuần tự
                if (currentNode == null || currentNode.flink == null)
                {
                    currentNode = Playlist.GetFirst();
                }
                else
                {
                    currentNode = currentNode.flink;
                }
            }
            // Cập nhật nhạc và giao diện
            if (currentNode != null)
            {
                Song nextSong = currentNode.element;

                axWindowsMediaPlayer1.URL = nextSong.Path;
                axWindowsMediaPlayer1.Ctlcontrols.play();

                TrackList.SelectedItem = nextSong;
                UpdateSongImage(nextSong.Path);
                UpdateSongTitle(nextSong.Name, true);
                this.Text = "Đang phát: " + nextSong.Name;
            }
        }
        private void btnPlay(object sender, EventArgs e)
        {
            // Kiểm tra danh sách trống
            if (Playlist.IsEmpty())
            {
                MessageBox.Show("Danh sách trống, vui lòng chọn file nhạc!");
                return;
            }

            // Phát, tạm dừng
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
            }
            else if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                // Nếu đang tạm dừng thì tiếp tục phát bài đó
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
            else
            {
                // Nếu người dùng chưa chọn dòng nào trên UI, mặc định chọn dòng đầu tiên
                if (TrackList.SelectedIndex == -1)
                {
                    TrackList.SelectedIndex = 0;
                }
                // Cập nhật currentNode dựa trên lựa chọn hiện tại của ListBox
                currentNode = Playlist.GetNodeAt(TrackList.SelectedIndex);
                if (currentNode != null)
                {
                    Song selectedSong = currentNode.element;

                    // Kiểm tra nếu bài hát mới khác với bài đang nạp trong Player
                    if (axWindowsMediaPlayer1.URL != selectedSong.Path)
                    {
                        axWindowsMediaPlayer1.URL = selectedSong.Path;
                    }
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    // Cập nhật giao diện
                    UpdateSongImage(selectedSong.Path);
                    UpdateSongTitle(selectedSong.Name, true);
                    this.Text = "Đang phát: " + selectedSong.Name;
                }
            }
        }
        private void TrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.currentPosition = TrackBar1.Value; // di chuyển thanh nhạc
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (TrackList.SelectedIndex != -1)
            {
                DialogResult confirm = MessageBox.Show("Bạn có muốn xóa bài hát này khỏi danh sách?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    // Lấy vị trí đang chọn
                    int currentIndex = TrackList.SelectedIndex;

                    // Tìm Node tương ứng trong LinkedList (Quan trọng!)
                    Node<Song> nodeToDelete = Playlist.GetNodeAt(currentIndex);

                    if (nodeToDelete != null)
                    {
                        //Nếu bài đang xóa chính là bài đang phát (currentNode)
                        if (currentNode == nodeToDelete)
                        {
                            axWindowsMediaPlayer1.Ctlcontrols.stop();
                            axWindowsMediaPlayer1.URL = "";
                            currentNode = null; // Reset con trỏ về rỗng

                            labeCurrentTime.Text = "00:00";
                            label3.Text = "00:00";
                            TrackBar1.Value = 0;
                            labelSongTitle.Text = "";
                        }

                        // Xóa bài hát khỏi LinkedList 
                        Playlist.Remove(nodeToDelete);

                        // Xóa bài hát khỏi ListBox 
                        TrackList.Items.RemoveAt(currentIndex);

                        //Cập nhật lại số thứ tự hiển thị
                        RefreshSTT();
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một bài hát để xóa!");
            }
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
        private void btnClear_Click(object sender, EventArgs e)
        {
            //  Kiểm tra danh sách 
            if (TrackList.Items.Count == 0) return;

            // Xác nhận từ người dùng
            DialogResult result = MessageBox.Show("Bạn có muốn xóa toàn bộ danh sách phát?", "Xác nhận Clear",
                                                  MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                // Đồng bộ trình phát, dừng nhạc và xóa URL 
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                axWindowsMediaPlayer1.URL = "";

                // Xóa dữ liệu gốc
                Playlist.Clear(); // Xóa trong LinkedList
                currentNode = null; // Reset con trỏ đang phát

                // Đồng bộ giao diện
                TrackList.Items.Clear(); // Xóa danh sách hiển thị

                // Reset các nhãn thời gian và tiêu đề
                labelSongTitle.Text = "Chưa có bài hát";
                labeCurrentTime.Text = "00:00";
                label3.Text = "00:00";
                TrackBar1.Value = 0;

                // Reset ảnh bìa về ảnh mặc định
                guna2PictureBox1.Image = Properties.Resources.Lauriel_AOV;
                // Cập nhật tiêu đề Form
                this.Text = "Trình phát nhạc";
            }
        }
        bool isSorted = false;
        private void btnSort_Click(object sender, EventArgs e)
        {
            if (!isSorted)
            {
                // Sắp xếp từ a đên z
                Playlist.BubbleSort((s1, s2) => string.Compare((s1 as Song).Name, (s2 as Song).Name));
                btnSort.Text = "Trả về ban đầu";
            }
            else
            {
                // Sắp xếp theo STT (Về ban đầu)
                Playlist.BubbleSort((s1, s2) => (s1 as Song).STT.CompareTo((s2 as Song).STT));
                btnSort.Text = "Sắp xếp A-Z";
            }
            isSorted = !isSorted;
            UpdateTrackListUI();
            RefreshSTT();
        }
        bool isShuffle = false;
        private void btnShuffle_Click(object sender, EventArgs e)
        {
            isShuffle = !isShuffle; // Đảo trạng thái mỗi khi bấm
            if (isShuffle)
            {
                btnShuffle.BackColor = Color.HotPink; // Đổi màu 
            }
            else
            {
                btnShuffle.BackColor = default; // Trả về màu cũ
            }
        }
        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 8)
            {
                // Kiểm tra an toàn trước khi gọi Invoke
                if (!this.IsDisposed)
                {
                    this.BeginInvoke(new MethodInvoker(delegate
                    {
                        // Gọi nút Next để nó tự chọn bài tiếp theo (có tính cả Shuffle)
                        btnNext_Click(null, null);
                    }));
                }
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
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
