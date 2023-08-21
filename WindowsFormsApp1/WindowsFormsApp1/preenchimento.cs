using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class preenchimento : Form
    {
        public preenchimento()
        {
            InitializeComponent();
        }
        preenchimento preenchido = new preenchimento();
        private void preenchimento_Load(object sender, EventArgs e)
        {
            

                string nome = txtnome.Text;
                long cpf = long.Parse(txtcpf.Text);
                long rg = long.Parse(txtrg.Text);
                double salario = double.Parse(txtsal.Text);
                double gratificacao = double.Parse(txtgrat.Text);
                double comissao = double.Parse(txtcom.Text);
                double meta = double.Parse(txtmeta.Text);





            private string btnenviar_Click(string nome, long cpf, long rg, double salario, double comissao,
           double gratificacao, double meta)
            {
                return $"O funcionário de nome: {nome}, com o salário de: {salario}, possui gratificação de: {gratificacao}, com comissão de: {comissao}, uma meta de: {meta} ";
            }
        }
    }
}
