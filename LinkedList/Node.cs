using System;

namespace LinkedList {
    public class Node {
        public int data;
        public Node next;

        public Node(int data, Node next = null) {
            this.data = data;
            this.next = next;
        }
        public void DisplayNode() {
            Console.Write($"{this.data} -->");
        }
    }
}
