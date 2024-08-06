using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exer1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Box = new System.Windows.Forms.GroupBox();
            this.Renda = new System.Windows.Forms.Label();
            this.txtRenda = new System.Windows.Forms.TextBox();
            this.agua = new System.Windows.Forms.Label();
            this.ENERGIA = new System.Windows.Forms.Label();
            this.txtEnergia = new System.Windows.Forms.TextBox();
            this.txtAgua = new System.Windows.Forms.TextBox();
            this.tfi = new System.Windows.Forms.Label();
            this.txtTFI = new System.Windows.Forms.TextBox();
            this.OutrosGastos = new System.Windows.Forms.Label();
            this.alm = new System.Windows.Forms.Label();
            this.txtAlm = new System.Windows.Forms.TextBox();
            this.txtOutrosGastos = new System.Windows.Forms.TextBox();
            this.Calcular = new System.Windows.Forms.Button();
            this.NovoCalculo = new System.Windows.Forms.Button();
            this.Fechar = new System.Windows.Forms.Button();
            this.TotalGastos = new System.Windows.Forms.Label();
            this.Saldo = new System.Windows.Forms.Label();
            this.lblGastos = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.Label();
            this.Box.SuspendLayout();
            this.SuspendLayout();
            // 
            // Box
            // 
            this.Box.Controls.Add(this.txtOutrosGastos);
            this.Box.Controls.Add(this.txtAlm);
            this.Box.Controls.Add(this.alm);
            this.Box.Controls.Add(this.OutrosGastos);
            this.Box.Controls.Add(this.txtTFI);
            this.Box.Controls.Add(this.tfi);
            this.Box.Controls.Add(this.txtAgua);
            this.Box.Controls.Add(this.agua);
            this.Box.Controls.Add(this.txtEnergia);
            this.Box.Controls.Add(this.ENERGIA);
            this.Box.Location = new System.Drawing.Point(346, 119);
            this.Box.Name = "Box";
            this.Box.Size = new System.Drawing.Size(312, 239);
            this.Box.TabIndex = 0;
            this.Box.TabStop = false;
            this.Box.Text = "Gastos";
            this.Box.Enter += new System.EventHandler(this.Box_Enter);
            // 
            // Renda
            // 
            this.Renda.AutoSize = true;
            this.Renda.Location = new System.Drawing.Point(344, 95);
            this.Renda.Name = "Renda";
            this.Renda.Size = new System.Drawing.Size(77, 13);
            this.Renda.TabIndex = 1;
            this.Renda.Text = "Renda familiar:";
            this.Renda.Click += new System.EventHandler(this.Renda_Click);
            // 
            // txtRenda
            // 
            this.txtRenda.Location = new System.Drawing.Point(427, 92);
            this.txtRenda.Name = "txtRenda";
            this.txtRenda.Size = new System.Drawing.Size(145, 20);
            this.txtRenda.TabIndex = 2;
            this.txtRenda.TextChanged += new System.EventHandler(this.txtRenda_TextChanged);
            // 
            // agua
            // 
            this.agua.AutoSize = true;
            this.agua.Location = new System.Drawing.Point(6, 83);
            this.agua.Name = "agua";
            this.agua.Size = new System.Drawing.Size(35, 13);
            this.agua.TabIndex = 3;
            this.agua.Text = "Água:";
            this.agua.Click += new System.EventHandler(this.agua_Click);
            // 
            // ENERGIA
            // 
            this.ENERGIA.AutoSize = true;
            this.ENERGIA.Location = new System.Drawing.Point(6, 42);
            this.ENERGIA.Name = "ENERGIA";
            this.ENERGIA.Size = new System.Drawing.Size(84, 13);
            this.ENERGIA.TabIndex = 4;
            this.ENERGIA.Text = "Energia Elétrica:";
            this.ENERGIA.Click += new System.EventHandler(this.ENERGIA_Click);
            // 
            // txtEnergia
            // 
            this.txtEnergia.Location = new System.Drawing.Point(113, 39);
            this.txtEnergia.Name = "txtEnergia";
            this.txtEnergia.Size = new System.Drawing.Size(150, 20);
            this.txtEnergia.TabIndex = 4;
            this.txtEnergia.TextChanged += new System.EventHandler(this.txtEnergia_TextChanged);
            // 
            // txtAgua
            // 
            this.txtAgua.Location = new System.Drawing.Point(113, 80);
            this.txtAgua.Name = "txtAgua";
            this.txtAgua.Size = new System.Drawing.Size(150, 20);
            this.txtAgua.TabIndex = 5;
            this.txtAgua.TextChanged += new System.EventHandler(this.txtAgua_TextChanged);
            // 
            // tfi
            // 
            this.tfi.AutoSize = true;
            this.tfi.Location = new System.Drawing.Point(6, 122);
            this.tfi.Name = "tfi";
            this.tfi.Size = new System.Drawing.Size(106, 13);
            this.tfi.TabIndex = 6;
            this.tfi.Text = "TV / Fone / Internet:";
            this.tfi.Click += new System.EventHandler(this.tfi_Click);
            // 
            // txtTFI
            // 
            this.txtTFI.Location = new System.Drawing.Point(113, 119);
            this.txtTFI.Name = "txtTFI";
            this.txtTFI.Size = new System.Drawing.Size(150, 20);
            this.txtTFI.TabIndex = 7;
            this.txtTFI.TextChanged += new System.EventHandler(this.txtTFI_TextChanged);
            // 
            // OutrosGastos
            // 
            this.OutrosGastos.AutoSize = true;
            this.OutrosGastos.Location = new System.Drawing.Point(6, 195);
            this.OutrosGastos.Name = "OutrosGastos";
            this.OutrosGastos.Size = new System.Drawing.Size(75, 13);
            this.OutrosGastos.TabIndex = 8;
            this.OutrosGastos.Text = "Outros gastos:";
            this.OutrosGastos.Click += new System.EventHandler(this.OutrosGastos_Click);
            // 
            // alm
            // 
            this.alm.AutoSize = true;
            this.alm.Location = new System.Drawing.Point(6, 157);
            this.alm.Name = "alm";
            this.alm.Size = new System.Drawing.Size(68, 13);
            this.alm.TabIndex = 9;
            this.alm.Text = "Alimentação:";
            this.alm.Click += new System.EventHandler(this.alm_Click);
            // 
            // txtAlm
            // 
            this.txtAlm.Location = new System.Drawing.Point(113, 154);
            this.txtAlm.Name = "txtAlm";
            this.txtAlm.Size = new System.Drawing.Size(150, 20);
            this.txtAlm.TabIndex = 10;
            this.txtAlm.TextChanged += new System.EventHandler(this.txtAlm_TextChanged);
            // 
            // txtOutrosGastos
            // 
            this.txtOutrosGastos.Location = new System.Drawing.Point(113, 192);
            this.txtOutrosGastos.Name = "txtOutrosGastos";
            this.txtOutrosGastos.Size = new System.Drawing.Size(150, 20);
            this.txtOutrosGastos.TabIndex = 11;
            this.txtOutrosGastos.TextChanged += new System.EventHandler(this.txtOutrosGastos_TextChanged);
            // 
            // Calcular
            // 
            this.Calcular.Location = new System.Drawing.Point(345, 398);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(75, 38);
            this.Calcular.TabIndex = 3;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // NovoCalculo
            // 
            this.NovoCalculo.Location = new System.Drawing.Point(452, 398);
            this.NovoCalculo.Name = "NovoCalculo";
            this.NovoCalculo.Size = new System.Drawing.Size(99, 38);
            this.NovoCalculo.TabIndex = 4;
            this.NovoCalculo.Text = "Novo Cálculo";
            this.NovoCalculo.UseVisualStyleBackColor = true;
            this.NovoCalculo.Click += new System.EventHandler(this.NovoCalculo_Click);
            // 
            // Fechar
            // 
            this.Fechar.Location = new System.Drawing.Point(583, 398);
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(75, 38);
            this.Fechar.TabIndex = 5;
            this.Fechar.Text = "Fechar";
            this.Fechar.UseVisualStyleBackColor = true;
            this.Fechar.Click += new System.EventHandler(this.Fechar_Click);
            // 
            // TotalGastos
            // 
            this.TotalGastos.AutoSize = true;
            this.TotalGastos.Location = new System.Drawing.Point(342, 474);
            this.TotalGastos.Name = "TotalGastos";
            this.TotalGastos.Size = new System.Drawing.Size(88, 13);
            this.TotalGastos.TabIndex = 6;
            this.TotalGastos.Text = "Total dos gastos:";
            this.TotalGastos.Click += new System.EventHandler(this.TotalGastos_Click);
            // 
            // Saldo
            // 
            this.Saldo.AutoSize = true;
            this.Saldo.Location = new System.Drawing.Point(342, 517);
            this.Saldo.Name = "Saldo";
            this.Saldo.Size = new System.Drawing.Size(34, 13);
            this.Saldo.TabIndex = 7;
            this.Saldo.Text = "Saldo";
            this.Saldo.Click += new System.EventHandler(this.Saldo_Click);
            // 
            // lblGastos
            // 
            this.lblGastos.AutoSize = true;
            this.lblGastos.Location = new System.Drawing.Point(572, 474);
            this.lblGastos.Name = "lblGastos";
            this.lblGastos.Size = new System.Drawing.Size(0, 13);
            this.lblGastos.TabIndex = 9;
            this.lblGastos.Click += new System.EventHandler(this.lblGastos_Click);
            // 
            // txtSaldo
            // 
            this.txtSaldo.AutoSize = true;
            this.txtSaldo.Location = new System.Drawing.Point(572, 517);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(0, 13);
            this.txtSaldo.TabIndex = 10;
            this.txtSaldo.Click += new System.EventHandler(this.txtSaldo_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(944, 657);
            this.Controls.Add(this.txtSaldo);
            this.Controls.Add(this.lblGastos);
            this.Controls.Add(this.Saldo);
            this.Controls.Add(this.TotalGastos);
            this.Controls.Add(this.Fechar);
            this.Controls.Add(this.NovoCalculo);
            this.Controls.Add(this.Calcular);
            this.Controls.Add(this.txtRenda);
            this.Controls.Add(this.Renda);
            this.Controls.Add(this.Box);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Box.ResumeLayout(false);
            this.Box.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Box_Enter(object sender, EventArgs e)
        {

        }

        private void Renda_Click(object sender, EventArgs e)
        {

        }

        private void txtRenda_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEnergia_TextChanged(object sender, EventArgs e)
        {

        }

        private void ENERGIA_Click(object sender, EventArgs e)
        {

        }

        private void agua_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAgua_TextChanged(object sender, EventArgs e)
        {

        }

        private void tfi_Click(object sender, EventArgs e)
        {

        }

        private void txtTFI_TextChanged(object sender, EventArgs e)
        {

        }

        private void alm_Click(object sender, EventArgs e)
        {

        }

        private void txtAlm_TextChanged(object sender, EventArgs e)
        {

        }

        private void OutrosGastos_Click(object sender, EventArgs e)
        {

        }

        private void txtOutrosGastos_TextChanged(object sender, EventArgs e)
        {

        }

        private void TotalGastos_Click(object sender, EventArgs e)
        {

        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(txtRenda.Text);
            int n2 = int.Parse(txtEnergia.Text);
            int n3 = int.Parse(txtAgua.Text);
            int n4 = int.Parse(txtTFI.Text);
            int n5 = int.Parse(txtAlm.Text);
            int n6 = int.Parse(txtOutrosGastos.Text);

            int resultado1 = n1 - n2 - n3 - n4 - n5 - n6;
            int resultado2 = n2 + n3 + n4 + n5 + n6;

            txtSaldo.Text = resultado1.ToString();
            lblGastos.Text = resultado2.ToString();
        }

        private void NovoCalculo_Click(object sender, EventArgs e)
        {
            txtRenda.Clear();
            txtEnergia.Clear();
            txtAgua.Clear();
            txtTFI.Clear();

            txtOutrosGastos.Clear();

            txtSaldo.Text = "0";
            lblGastos.Text = "0";

        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Saldo_Click(object sender, EventArgs e)
        {

        }

        private void lblGastos_Click(object sender, EventArgs e)
        {

        }

        private void txtSaldo_Click(object sender, EventArgs e)
        {

        }
    }
}
