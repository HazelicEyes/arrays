using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[4];
            vetor[0] = 7;
            vetor[1] = 3;
            vetor[2] = 5;
            vetor[3] = 1;
            int valor = vetor[1];
            System.Array.Sort(vetor);
            for (int index = 0; index < 4; index++)
                MessageBox.Show(vetor[index].ToString(), "Array");

            /* declarar e instanciar vetor
             * atribuicao de valores de acordo com cada indice
             * declara variavel valor para acesssar o vetor
             * system array sort para ordenar   o vetor
             * for - percorre o vetor em cada indice
             * condição - para index menor que 4 ele sexibe uma mnsg com o vetor na messagebox */
        }

        private void btnVetorTextos_Click(object sender, EventArgs e)
        {
            string[] semana = new string[7];
            semana[0] = "Domigno";
            semana[1] = "Segunda";
            semana[2] = "Terça";
            semana[3] = "Quarta";
            semana[4] = "Quinta";
            semana[5] = "Sexta";
            semana[6] = "Sabado";

            string valor = semana[1];
            for (int index = 0; index < 7; index++)
                MessageBox.Show(semana[index].ToString(), "Array");

            /* declarar instancia e valor 
             * atribuição de valores de acordo com cada indice, 
             * no caso so dias da semana (string)
             * delcara variavel valor para acessar o vetor 
             * por se tratar de uma string nao precisa ordenare
             * comando for - percorre o vetor em cada indice
             * condicao para index menor que 7, ele exibe mensagem com o vetro na messagebox */
        }
    }
}
