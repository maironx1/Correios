using CorreiosData.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CorreiosData
{
    public class Trechos
    {
        public static List<Trecho> ReadFromTxt(string txtName)
        {
            if (!File.Exists(txtName))
            {
                throw new FileNotFoundException("Arquivo não encontrado - " + txtName);
            }
            var txt = File.ReadAllLines(txtName);
            return ReadFromList(txt);
        }

        public static List<Trecho> ReadFromList(string[] nodeList)
        {
            var trechos = new List<Trecho>();
            try
            {
                for (int i = 0; i < nodeList.Length; i++)
                {
                    var line = nodeList[i];
                    var split = line.Split(" ");
                    if (split.Length < 2)
                    {
                        throw new Exception("Linha " + (i + 1) + " mal formada");
                    }
                    trechos.Add(new Trecho(new Node(split[0]), new Node(split[1])));
                }
                return trechos;
            }
            catch(Exception ex)
            {
                throw new Exception("Erro ao converter arquivo txt em trechos: " + ex.Message);
            }
        }
    }
}
