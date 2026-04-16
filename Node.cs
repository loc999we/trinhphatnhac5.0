using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trinhphatnhac5._0
{
    public class Node
    {
        public object element; // Dữ liệu lưu vào nút
        public Node flink, blink; // Liên kết trỏ đến nút sau và trước
        public Node()
        {
            //Khởi tạo nút header
            element = null;
            flink = blink = null;
        }
        public Node(object element)
        {
            this.element = element; // Gán dữ liệu bài vào nút
            this.flink = null; // Mặc định chưa có liên kết trước và sau
            this.blink = null;
        }
    }
}
