using LinkedList;

namespace Graph {
    public class Vertex {
        public string name;
        public SinglyLinkedList edges; 

        public Vertex(string name) {
            this.name = name;
            edges = new SinglyLinkedList();
        }

        public void AddEdge(int idx) {
            edges.InsertLast(new Node(idx));
        }

        public void DisplayEdges() {
            edges.DisplayList();
        }
    }
}
