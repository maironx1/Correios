using Correios;
using Correios.Interface;
using System;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace CorreiosUI
{
    public partial class Main : Form
    {
        private IMaisCurto MaisCurto = new Dijkstra();
        public Main()
        {
            InitializeComponent();
        }

        private void BtnFind_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {                            
                ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                ofd.RestoreDirectory = true;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    if (!ofd.FileName.Contains("trechos"))
                    {
                        MessageBox.Show("Favor selecionar o arquivo trechos.txt", "Selecionar arquivo txt", MessageBoxButtons.OK);
                    }
                    else
                    {
                        //Get the path of specified file
                        TxtTrechos.Text = ofd.FileName;
                    }             
                }
            }
        }

        private void BtnEncomendas_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                ofd.RestoreDirectory = true;
                if (ofd.ShowDialog() == DialogResult.OK)
                {                         
                    if (!ofd.FileName.Contains("encomendas"))
                    {
                        MessageBox.Show("Favor selecionar o arquivo encomendas.txt", "Selecionar arquivo txt", MessageBoxButtons.OK);
                    }
                    else
                    {
                        //Get the path of specified file
                        TxtEncomendas.Text = ofd.FileName;
                    }
                }
            }
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TxtTrechos.Text))
            {
                MessageBox.Show("Favor selecionar arquivo de Trechos", "Selecionar arquivo txt", MessageBoxButtons.OK);                
            }
            else if (String.IsNullOrEmpty(TxtEncomendas.Text))
            {
                MessageBox.Show("Favor selecionar arquivo de Encomendas", "Selecionar arquivo txt", MessageBoxButtons.OK);
            }
            else
            {
                var trechoLines = File.ReadAllLines(TxtTrechos.Text);
                var encomendaLines = File.ReadAllLines(TxtEncomendas.Text);

                var resultado = MaisCurto.BuscaResultado(trechoLines, encomendaLines);
                File.WriteAllLines("rotas.txt", resultado.ToArray());
                Process.Start("notepad.exe", "rotas.txt");
            }
        }
    }
}
