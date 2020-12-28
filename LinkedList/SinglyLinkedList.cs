using System;

namespace LinkedList {
    public class SinglyLinkedList {
        private Node head;

        public SinglyLinkedList() {

        }

        public bool IsEmpty() {
            return this.head == null;
        }

        public void InsertFirst(int data) {
            if (IsEmpty()) {
                this.head = new Node(data);
                return;
            }
            Node newNode = new Node(data, this.head.next);
            this.head = newNode;
        }

        public Node DeleteFirst() {
            Node tmp = this.head;
            this.head = this.head.next;
            return tmp;
        }

        public void InsertLast(Node node) {

            if (IsEmpty()) {
                InsertFirst(node.data);
                return;
            }
            Node current = this.head;
            while(current.next != null) {
                current = current.next;
            }
            current.next = node;
        }

        public void DisplayList() {
            Node current = this.head;
            while(current != null) {
                current.DisplayNode();
                current = current.next;
            }
            Console.WriteLine();
        }
    }
}
