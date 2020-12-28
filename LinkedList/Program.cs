using System;

namespace LinkedList {
    class Program {
        static void Main(string[] args) {
            SinglyLinkedList singlyLinkedList = new SinglyLinkedList();
            singlyLinkedList.InsertLast(new Node(1));
            singlyLinkedList.InsertLast(new Node(2));
            singlyLinkedList.InsertLast(new Node(3));
            singlyLinkedList.DisplayList();
        }
    }
}
