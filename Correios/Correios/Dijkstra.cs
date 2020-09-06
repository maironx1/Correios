using Correios.Interface;
using CorreiosData;
using CorreiosData.Classes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Correios
{
    public class Dijkstra : IMaisCurto
    {
        private class Weight
        {
            public Node From { get; }
            public int Value { get; }

            public Weight(Node @from, int value)
            {
                From = @from;
                Value = value;
            }
        }

        class VisitingData
        {
            readonly List<Node> _visiteds =
                new List<Node>();

            readonly Dictionary<Node, Weight> _weights =
                new Dictionary<Node, Weight>();

            readonly List<Node> _scheduled =
                new List<Node>();

            public void RegisterVisitTo(Node node)
            {
                if (!_visiteds.Contains(node))
                    _visiteds.Add((node));
            }

            public bool WasVisited(Node node)
            {
                return _visiteds.Contains(node);
            }

            public void UpdateWeight(Node node, Weight newWeight)
            {
                if (!_weights.ContainsKey(node))
                {
                    _weights.Add(node, newWeight);
                }
                else
                {
                    _weights[node] = newWeight;
                }
            }

            public Weight QueryWeight(Node node)
            {
                Weight result;
                if (!_weights.ContainsKey(node))
                {
                    result = new Weight(null, int.MaxValue);
                    _weights.Add(node, result);
                }
                else
                {
                    result = _weights[node];
                }
                return result;
            }

            public void ScheduleVisitTo(Node node)
            {
                _scheduled.Add(node);
            }

            public bool HasScheduledVisits => _scheduled.Count > 0;

            public Node GetNodeToVisit()
            {
                var ordered = from n in _scheduled
                              orderby QueryWeight(n).Value
                              select n;

                var result = ordered.First();
                _scheduled.Remove(result);
                return result;
            }

            public bool HasComputedPathToOrigin(Node node)
            {
                return QueryWeight(node).From != null;
            }

            public IEnumerable<Node> ComputedPathToOrigin(Node node)
            {
                var n = node;
                while (n != null)
                {
                    yield return n;
                    n = QueryWeight(n).From;
                }
            }
        }

        public Node[] BuscaMaisCurto(Node @from, Node to)
        {
            var control = new VisitingData();

            control.UpdateWeight(@from, new Weight(null, 0));
            control.ScheduleVisitTo(@from);

            while (control.HasScheduledVisits)
            {
                var visitingNode = control.GetNodeToVisit();
                var visitingNodeWeight = control.QueryWeight(visitingNode);
                control.RegisterVisitTo(visitingNode);

                foreach (var neighborhoodInfo in visitingNode.Neighbors)
                {
                    if (!control.WasVisited(neighborhoodInfo.Node))
                    {
                        control.ScheduleVisitTo(neighborhoodInfo.Node);
                    }

                    var neighborWeight = control.QueryWeight(neighborhoodInfo.Node);

                    var probableWeight = (visitingNodeWeight.Value + neighborhoodInfo.WeightToNode);
                    if (neighborWeight.Value > probableWeight)
                    {
                        control.UpdateWeight(neighborhoodInfo.Node, new Weight(visitingNode, probableWeight));
                    }
                }
            }
            return control.HasComputedPathToOrigin(to)
                ? control.ComputedPathToOrigin(to).Reverse().ToArray()
                : null;
        }

        public List<string> BuscaResultado(string[] trechoLines, string[] encomendaLines)
        {
            var nodes = Nodes.GetNodes(trechoLines);
            var trechos = Trechos.ReadFromList(encomendaLines);
            var resultado = new List<string>();
            foreach (Trecho trecho in trechos)
            {
                var node1 = (from n in nodes where n.Label == trecho.Origem.Label select n).First();
                var node2 = (from n in nodes where n.Label == trecho.Destino.Label select n).First();
                var result = BuscaMaisCurto(node1, node2);
                string line = "";
                int dist = 0;
                for (int i = 0; i < result.Length; i++)
                {
                    var node = result[i];
                    line += node.Label + " ";
                    if (i > 0)
                    {
                        var edge = (from ed in node.Edges
                                    where ed.Node2 == node && ed.Node1 == result[i - 1]
                                    select ed).First();
                        dist += edge.Value;
                    }
                }
                resultado.Add(line + dist);
            }
            return resultado;
        }
    }
}
