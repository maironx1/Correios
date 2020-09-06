using CorreiosData.Classes;
using System;
using System.Collections.Generic;
using System.IO;

namespace CorreiosData
{
    public class Nodes
    {
        private static readonly List<Node> _nodes = new List<Node>();
        public static List<Node> GetNodes(string txtName = "trechos.txt")
        {
            if (_nodes.Count < 1)
            {
                ReadNodesFromTxt(txtName);
            }
            return _nodes;
        }
        public static List<Node> GetNodes(string[] nodes)
        {
            if (_nodes.Count < 1)
            {
                ReadNodesFromList(nodes);
            }
            return _nodes;
        }

        private static void ReadNodesFromTxt(string txtName)
        {
            if (!File.Exists(txtName))
            {
                throw new FileNotFoundException("Arquivo não encontrado - " + txtName);
            }
            var txt = File.ReadAllLines(txtName);
            ReadNodesFromList(txt);
        }

        public static void ReadNodesFromList(string[] nodeList)
        {
            try
            {
                for(int i = 0;i< nodeList.Length;i++) 
                {
                    var nodeLine = nodeList[i];
                    var split = nodeLine.Split(" ");
                    if (split.Length != 3)
                    {
                        _nodes.Clear();
                        throw new Exception("Linha " + (i + 1) + " mal formada");
                    }
                    int distance = int.Parse(split[2]);
                    var node1 = new Node(split[0]);
                    var node2 = new Node(split[1]);
                    var node1Index = _nodes.IndexOf(node1);
                    var node2Index = _nodes.IndexOf(node2);
                    if (node1Index < 0)
                    {
                        node1Index = _nodes.Count;
                        _nodes.Add(node1);
                    }
                    else
                    {
                        node1 = _nodes[node1Index];
                    }
                    if (node2Index < 0)
                    {
                        node2Index = _nodes.Count;
                        _nodes.Add(node2);
                    }
                    else
                    {
                        node2 = _nodes[node2Index];
                    }
                    node1 = _nodes[node1Index];
                    node2 = _nodes[node2Index];
                    node1.ConnectTo(node2, distance);
                }
            } 
            catch (Exception ex)
            {
                _nodes.Clear();
                throw new Exception("Erro ao converter arquivo txt em Node: " + ex.Message);
            }
        }
    }
}
