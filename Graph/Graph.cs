using LinkedList;
using System;
using System.Collections.Generic;

namespace Graph {
    public class Graph {
        List<Vertex> vertices = new List<Vertex>();

        public void AddVertex(string name) {
            this.vertices.Add(new Vertex(name));
        }

        public void DisplayVertices() {

            foreach (Vertex vertex in vertices) {
                Node current = vertex.edges.head;
                Console.Write($"{vertex.name}");
                while(current != null) {
                    Console.Write($" --> {vertices[current.data].name}");
                    current = current.next;
                }
                Console.WriteLine();
            }
        }

        public void AddEdge(string sourceName, string targetName) {
            int sourceIdx = vertices.FindIndex(vertex => vertex.name.ToLower() == sourceName.ToLower());
            int targetIdx = vertices.FindIndex(vertex => vertex.name.ToLower() == targetName.ToLower());
            if (targetIdx > -1) vertices[sourceIdx].AddEdge(targetIdx);
        }

    }
}
