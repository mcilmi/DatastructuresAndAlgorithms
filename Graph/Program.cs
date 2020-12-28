using System;
using System.Collections.Generic;

namespace Graph {
    class Program {
        static void Main(string[] args) {
            Graph myGraph = new Graph();
            Vertex vertex1 = new Vertex("A");
            Vertex vertex2 = new Vertex("B");
            Vertex vertex3 = new Vertex("C");
            Vertex vertex4 = new Vertex("D");

            vertex1.AddEdge(1);
            vertex1.AddEdge(3);

            vertex2.AddEdge(2);

            vertex3.AddEdge(0);
            vertex3.AddEdge(3);

            myGraph.InsertVertex(vertex1);
            myGraph.InsertVertex(vertex2);
            myGraph.InsertVertex(vertex3);
            myGraph.InsertVertex(vertex4);
            myGraph.DisplayVertices();
        }
    }
}
