using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CriacaoComponentes
{
    public partial class Form1 : Form
    {
        private bool rendered = false;
        private List<Produto> listProdutos = new List<Produto>();
        public Form1()
        {
            InitializeComponent();
            dataGridView.AutoGenerateColumns = true;
            dataGridView.DataSource = listProdutos;
        }

        private void btnCriar_Click(object sender, EventArgs e)
        {
            if (!rendered)
            {
                this.Render();
            }
            else
            {
                MessageBox.Show("Ta Fazido Meu Faraó!!");
            }
        }

        private void Render()
        {
            /*dataGridView.AutoGenerateColumns = true;
            dataGridView.DataSource = listProdutos;*/

            Label lblQuantidade = new Label();
            lblQuantidade.Name = "lblQuant";
            lblQuantidade.Text = "Quantidade:";
            lblQuantidade.Location = new Point(89, 174);
            lblQuantidade.Width = 90;
            lblQuantidade.Font = new System.Drawing.Font("Old English Text MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Controls.Add(lblQuantidade);

            Label lblDescricao = new Label()
            {
                Name = "lblDescricao",
                Text = "Descrição:",
                Location = new Point(89, 214),
                Width = 90,
                Font = new System.Drawing.Font("Old English Text MT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)))
        };
            this.Controls.Add(lblDescricao);

            TextBox txtQuantidade = new TextBox()
            {
                Name = "txtQuantidade",
                Location = new Point(209, 180),
                Width = 65
            };
            this.Controls.Add(txtQuantidade);

            TextBox txtDescricao = new TextBox()
            {
                Name = "txtDescricao",
                Location = new Point(209, 220),
                Width = 65
            };
            this.Controls.Add(txtDescricao);

            Button btnSalvar = new Button()
            {
                Name = "btnSalvar",
                Text = "Salvar",
                Location = new Point(337, 180),
                Size = new Size(86,60)
            };

            btnSalvar.Click += (s, e) =>
            {
                String nome = txtNome.Text;
                double preco = Double.Parse(txtPreco.Text);
                int quantidade = int.Parse(txtQuantidade.Text);
                String descricao = txtDescricao.Text;

                Produto p = new Produto(nome, preco, descricao, quantidade);

                listProdutos.Add(p);
                dataGridView.DataSource = null;
                dataGridView.DataSource = listProdutos;

                MessageBox.Show("Criado Com Sucesso!");
            };
            this.Controls.Add(btnSalvar);
            this.rendered = true;
        }
    }
}
