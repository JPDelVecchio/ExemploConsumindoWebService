using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsumindoSOAP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            Servico2.wsConsultaSQL servico = new Servico2.wsConsultaSQL();
            
            String res = servico.AutenticaAcessoAuth("jlima","190581");
            String res1 = servico.AutenticaAcesso().GetHashCode().ToString();
            */
            /*
            MessageBox.Show("Retorno Acesso Totvs: " +  res + "token:" + res1);
            */
           String res4 = textBox1.Text;
           res4 = res4.Replace("-", "");
           String cep = res4;
            correio.AtendeClienteService corr = new correio.AtendeClienteService();

            String end = corr.consultaCEP(cep).end;
            String bairro = corr.consultaCEP(cep).bairro;
            String cidade = corr.consultaCEP(cep).cidade;

            MessageBox.Show("Cidade: " + cidade + "\n" +
                            "Bairro: " + bairro + "\n" +
                            "End: " + end);
           

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
