using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trinhphatnhac5._0
{
    public class Node<T>
    {
            public T element; // Bài hát node lưu trữ
            public Node<T> flink, blink; // Dùng để trỏ bài tiếp theo, ngược lại

            public Node(T element)
            {
                this.element = element; // Gán dữ liệu bài vào nút
                this.flink = null; // Mặc định chưa có liên kết nút trước và sau
                this.blink = null;
            }
        
    }
}
