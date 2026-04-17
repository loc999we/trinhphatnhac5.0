using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trinhphatnhac5._0
{
    public class DoublyLinkedList<T>
    {
        private Node<T> head;
        private Node<T> tail;
        private int size;

        public DoublyLinkedList()
        {
            head = null;
            tail = null;
            size = 0;
        }

        public int Count => size;
        public bool IsEmpty() => head == null;
        public Node<T> GetFirst() => head;
        public Node<T> GetLast() => tail;

        // Phương thức thêm Node mới vào cuối danh sách khi add Folder
        public void Insert(T newsong) // Nhận vào kiểu T
        {
            Node<T> newnode = new Node<T>(newsong);
            if (head == null)
            {
                head = newnode;
                tail = newnode;
            }
            else
            {
                //Nút cuối cũ trỏ tới nút mới, nút mới trỏ ngược lại
                tail.flink = newnode;
                newnode.blink = tail;
                tail = newnode;
            }
            size++;
        }

        // Lấy Node tại một vị trí index cụ thể
        public Node<T> GetNodeAt(int index)
        {
            if (index < 0 || index >= size) return null; // Kiểm tra index có hợp lệ không
            Node<T> current;

            //Nếu index nằm ở nửa đầu danh sách thì duyệt từ head
            if (index < size / 2)
            {
                current = head;
                for (int i = 0; i < index; i++)
                {
                    current = current.flink;
                }
            }
            //Nếu index nằm ở nửa sau danh sách thì duyệt ngược từ đuôi
            else
            {
                current = tail;
                for (int i = size - 1; i > index; i--)
                {
                    current = current.blink;
                }
            }
            return current;
        }
        // Phương thức xóa node cụ thể
        public void Remove(Node<T> node)
        {
            if (node == null || head == null) return;
            // Nếu xóa nút đầu
            if (node == head)
            {
                head = node.flink;
            }
            // Nếu xóa nút cuối
            if (node == tail)
            {
                tail = node.blink;
            }
            // Liên kết lại các nút xung quanh
            if (node.flink != null)
            {
                node.flink.blink = node.blink;
            }
            // Dọn dẹp nút bị xóa
            node.flink = null;
            node.blink = null;

            size--;
            // Reset nếu danh sách trống
            if (size == 0)
            {
                head = null;
                tail = null;
            }
        }
        public void Clear()
        {
            // Duyệt và xóa từ đầu danh sách cho đến khi trống rỗng
            while (head != null)
            {
                Remove(head);
            }
        }

        // Hàm Bubble Sort sắp xếp bài theo chữ cái
        public void BubbleSort(Comparison<T> compare)
        {
            if (head == null || head.flink == null) return;
            bool swapped;
            do
            {
                swapped = false;
                Node<T> cur = head;
                while (cur.flink != null)
                {
                    // Sử dụng hàm so sánh được từ form vào
                    if (compare(cur.element, cur.flink.element) > 0)
                    {
                        //Hoán đổi dữ liệu bài hát
                        T temp = cur.element;
                        cur.element = cur.flink.element;
                        cur.flink.element = temp;
                        swapped = true;
                    }
                    cur = cur.flink;
                }
            } while (swapped);

        }
    }
}
