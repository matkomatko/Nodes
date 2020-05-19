using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nodes
{

    class Program
    {

        static void Main(string[] args)
        {

            Node A = new Node("A");
            Node B = new Node("B");
            Node C = new Node("C");
            Node D = new Node("D");
            Node E = new Node("E", new List<Connection>() { new Connection(new Node("F"), 100) });

            A.AddConnection(B, 1);
            B.AddConnection(C, 2);
            C.AddConnection(A, 3);
            D.AddConnection(E, 4);
            E.AddConnection(A, 5);

            List<Node> Graph = new List<Node>() { A, B, C, D, E };

            foreach (Node item in Graph)
            {
                Console.WriteLine(item.ToString());
            }





        }
    }
}
