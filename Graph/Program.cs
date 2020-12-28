using System;
using System.Collections.Generic;

namespace Graph {
    class Program {
        static void Main(string[] args) {
            Graph myGraph = new Graph();
            
            // Add Vertices
            myGraph.AddVertex("Muqdisho");
            myGraph.AddVertex("Kismaayo");
            myGraph.AddVertex("Beledweyne");
            myGraph.AddVertex("Laascaanood");
            myGraph.AddVertex("Marka");
            myGraph.AddVertex("Afgooye");

            // Add Edges
            myGraph.AddEdge("Muqdisho", "Kismaayo");
            myGraph.AddEdge("Muqdisho", "Beledweyne");
            myGraph.AddEdge("Kismaayo", "Marka");
            myGraph.AddEdge("Beledweyne", "Marka");
            myGraph.AddEdge("Marka", "Afgooye");
            myGraph.AddEdge("Afgooye", "Muqdisho");
            myGraph.AddEdge("Afgooye", "Marka");

            myGraph.DisplayVertices();
        }
    }
}
