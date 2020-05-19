using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nodes
{
    class Node
    {
        public string name { get; }
        List<Connection> connectedTo = new List<Connection>();

        public Node(string name_, List<Connection> ConnectedNodes = null)
        {

            name = name_;

            if (ConnectedNodes != null)
            {
                foreach (Connection connection in ConnectedNodes)
                {
                    // "if (connection.node != this)" -> probably unnecessary
                    if (connection.node != this) connectedTo.Add(connection);
                }
            }

        }

        public void AddConnection(Node node, int weight)
        {
            if (node != this) connectedTo.Add(new Connection(node, weight));
        }

        public void FindShortestPathTo(Node ThisNode)
        {
            //stopped here
        }

        public override string ToString()
        {

            string returnstring = name;
            returnstring += "(";
            foreach (Connection connection in connectedTo)
            {
                returnstring += connection.ToString();
            }
            returnstring += ")";

            return returnstring;

        }

    }
}
