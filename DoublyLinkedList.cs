using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trinhphatnhac5._0
{
    public class DoublyLinkedList
    {
        private Node head;
        private Node tail;
        private int size;

        public DoublyLinkedList()
        {
            head = null;
            tail = null;
            size = 0;
        }
        public int Count => size;  // Lấy số lượng phần tử hiện có
        public bool IsEmpty() => head == null;  // Kiểm tra danh sách rỗng
        public Node GetFirst() => head;  // Lấy bài hát đầu tiên
        public Node GetLast() => tail;  // Lấy bài hát cuối cùng

        // Phương thức thêm Node mới vào cuối danh sách (O(1))
        public void Insert(object newElement)
        {
            Node newNode = new Node(newElement);
            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.flink = newNode;
                newNode.blink = tail;
                tail = newNode;
            }
            size++;
        }
        // Lấy Node tại một vị trí index cụ thể
        public Node GetNodeAt(int index)
        {
            if (index < 0 || index >= size) return null;

            Node current = head;
            for (int i = 0; i < index; i++)
            {
                current = current.flink;
            }
            return current;
        }

        // Xóa một Node cụ thể
        public void Remove(Node nodeToRemove)
        {
            if (nodeToRemove == null || head == null) return;

            // Nếu xóa nút đầu
            if (nodeToRemove == head)
            {
                head = nodeToRemove.flink;
            }

            // Nếu xóa nút cuối
            if (nodeToRemove == tail)
            {
                tail = nodeToRemove.blink;
            }

            // Liên kết lại các nút xung quanh
            if (nodeToRemove.flink != null)
            {
                nodeToRemove.flink.blink = nodeToRemove.blink;
            }

            if (nodeToRemove.blink != null)
            {
                nodeToRemove.blink.flink = nodeToRemove.flink;
            }

            size--;
            
            // Nếu sau khi xóa mà danh sách trống
            if (size == 0)
            {
                head = null;
                tail = null;
            }
        }
    }
}
