using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trinhphatnhac5._0
{
    public class Song
    {
        public string Name { get; set; } // Thuộc tính lưu trữ tên của bài hát
        public string Path { get; set; } // Thuộc tính lưu trữ đường dẫn đầy đủ
        public int STT { get; set; } // Thuộc tính stt
        public override string ToString()
        {
            return STT > 0 ? $"{STT}. {Name}" : Name; //Hiện ra số thứ tự và tên trên TrackList
        }
    }
}
