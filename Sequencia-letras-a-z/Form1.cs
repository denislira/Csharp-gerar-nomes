using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Sequencia_letras_a_z
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char Inicio = Char.Parse("a");
char Fim = Char.Parse("z");
string str = "";

for (char i = Inicio; i <= Fim; i++)
str = str + i.ToString() +  " ";

listBox1.Items.Add(str);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            string[] letras = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            //ArrayList listaDeNomes = new ArrayList();

            for (int i = 0; i < letras.Count(); i++)
               {

                   string Gera1 = letras[i].ToString();
                   listBox1.Items.Add(Gera1);
               }
                
            //aa até zz
           for (int i = 0; i < letras.Count(); i++)
            {
                for (int ai = 0; ai < letras.Count(); ai++)
                {
                    string Gera1 = letras[ai].ToString();
                    string Gera2 = letras[i].ToString() + Gera1;
                    listBox1.Items.Add(Gera2);
                }
            }

            //aaa até zzz
           for (int i = 0; i < letras.Count(); i++)
           {
               for (int ai = 0; ai < letras.Count(); ai++)
               {
                   for (int ei = 0; ei < letras.Count(); ei++)
                   {

                       string Gera1 = letras[ei].ToString();
                       string Gera2 = letras[ai].ToString() + Gera1;
                       string Gera3 = letras[i].ToString() + Gera2;
                       listBox1.Items.Add(Gera3);
                   }
               }

           }

        }//FIM botão1 - 3 caracteres

        private void button3_Click(object sender, EventArgs e)
        {
            string[] letras = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
           
            //aaaa até zzzz
            for (int i = 0; i < letras.Count(); i++)
            {
                for (int ai = 0; ai < letras.Count(); ai++)
                {
                    for (int bi = 0; bi < letras.Count(); bi++)
                    {
                        for (int ci = 0; ci < letras.Count(); ci++)
                        {
                            string Gera1 = letras[ci].ToString();
                            string Gera2 = letras[bi].ToString() + Gera1;
                            string Gera3 = letras[ai].ToString() + Gera2;
                            string Gera4 = letras[i].ToString() + Gera3;
                            listBox2.Items.Add(Gera4);
                        }
                    }
                }

            }



        }//FIM botão2 - 4 caracteres







    }
}
