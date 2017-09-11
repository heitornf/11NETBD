using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            context db = new context();
            Loja loj = new Loja();
            loj.Endereco = tbend.Text;
            db.Loja.Add(loj);
            db.SaveChanges();
            AtualizaListas();
        }
        private void AtualizaListas()
        {
            listBox1.Items.Clear();
            cbloj.Items.Clear();
            listBox2.Items.Clear();
            context db = new context();
            var lojas = new List<Loja>();
            lojas = db.Loja.ToList();

            foreach (var loja in lojas)
            {
                listBox1.Items.Add(loja.ToString());
                cbloj.Items.Add(loja);
            }

            var clientes = new List<Cliente>();
            clientes = db.Cliente.ToList();
            foreach (var cliente in clientes)
            {
                listBox2.Items.Add("Id: " + cliente.Id + " Idade: " + cliente.Idade + " Profissao: " + cliente.Profissao + " Loja: " + cliente.Loja.Endereco);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            context db = new context();
            Cliente cli = new Cliente();
            cli.Idade = Int32.Parse(tbidade.Text);
            cli.Profissao = tbprof.Text;
            cli.LojaId = ((Loja)cbloj.SelectedItem).Id;
            db.Cliente.Add(cli);
            db.SaveChanges();
            AtualizaListas();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AtualizaListas();
        }
    }
}
