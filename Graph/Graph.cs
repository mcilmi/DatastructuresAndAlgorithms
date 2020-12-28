using System;
using System.Collections.Generic;

namespace Graph {
    public class Graph {
        List<Vertex> vertices = new List<Vertex>();

        public void InsertVertex(Vertex v) {
            this.vertices.Add(v);
        }

        public void DisplayVertices() {

            foreach (Vertex vertex in vertices) {
                Console.Write($"V = {vertex.name}, Edges = ");
                vertex.DisplayEdges();
                Console.WriteLine();
            }
        }

    }
}
