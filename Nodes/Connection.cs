using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nodes
{
    class Connection
    {
        public Node node { get; set; }
        public int weight { get; set; }

        public Connection(Node GivenNode, int weight_)
        {
            node = GivenNode;
            weight = weight_;
        }

        public override string ToString()
        {
            return weight + node.name;
        }
    }
}
