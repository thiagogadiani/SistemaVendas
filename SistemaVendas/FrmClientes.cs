using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SistemaVendas {
    public partial class FrmClientes : Form {
        private List<Cliente> clientes => DadosSistema.Clientes;

        public FrmClientes() {
            InitializeComponent();

            dgvClientes.AllowUserToAddRows = false;

            dgvClientes.DataSource = null;
            dgvClientes.DataSource = clientes.ToList();

            txtCodigo.Text = GerarProximoCodigo().ToString();
        }

        private int GerarProximoCodigo() {
            if (clientes.Count == 0)
                return 1;

            return clientes.Max(c => c.Codigo) + 1;
        }

        private bool ValidarCpf(string cpf) {
            // Remove pontos e traço
            cpf = cpf.Replace(".", "").Replace("-", "");

            // O CPF precisa ter exatamente 11 números
            if (cpf.Length != 11)
                return false;

            // Verifica se todos os números são iguais
            if (cpf.Distinct().Count() == 1)
                return false;

            // Verifica se todos os caracteres são números
            if (!cpf.All(char.IsDigit))
                return false;

            // Calcula o primeiro dígito verificador
            int soma = 0;

            for (int i = 0; i < 9; i++) {
                soma += int.Parse(cpf[i].ToString()) * (10 - i);
            }

            int resto = soma % 11;
            int primeiroDigito = resto < 2 ? 0 : 11 - resto;

            if (primeiroDigito != int.Parse(cpf[9].ToString()))
                return false;

            // Calcula o segundo dígito verificador
            soma = 0;

            for (int i = 0; i < 10; i++) {
                soma += int.Parse(cpf[i].ToString()) * (11 - i);
            }

            resto = soma % 11;
            int segundoDigito = resto < 2 ? 0 : 11 - resto;

            if (segundoDigito != int.Parse(cpf[10].ToString()))
                return false;

            return true;
        }

        private string LimparCpf(string cpf) {
            return new string(cpf.Where(char.IsDigit).ToArray());
        }

        private bool ValidarTelefone(string telefone) {
            string numeros = new string(telefone.Where(char.IsDigit).ToArray());

            // Telefone deve ter 10 ou 11 dígitos:
            // 10 = (11) 9999-9999
            // 11 = (11) 99999-9999
            if (numeros.Length != 10 && numeros.Length != 11)
                return false;

            // Verifica se o DDD possui 2 dígitos
            string ddd = numeros.Substring(0, 2);

            if (!int.TryParse(ddd, out int numeroDdd))
                return false;

            // DDDs brasileiros válidos: 11 a 99
            if (numeroDdd < 11 || numeroDdd > 99)
                return false;

            return true;
        }
        private bool ValidarEmail(string email) {
            try {
                var endereco = new System.Net.Mail.MailAddress(email);
                return endereco.Address == email;
            }
            catch {
                return false;
            }
        }

        private bool ValidarNome(string nome) {
            return nome.All(c => char.IsLetter(c) || char.IsWhiteSpace(c));
        }

        private void button2_Click(object sender, EventArgs e) {
            if (dgvClientes.CurrentRow == null) {
                MessageBox.Show("Selecione um cliente para editar.");
                return;
            }

            // Pega o código original do cliente selecionado
            if (!int.TryParse(
                dgvClientes.CurrentRow.Cells["Codigo"].Value?.ToString(),
                out int codigoOriginal)) {
                MessageBox.Show("Não foi possível identificar o cliente selecionado.");
                return;
            }

            // Procura o cliente diretamente na lista principal
            int indiceCliente = clientes.FindIndex(c => c.Codigo == codigoOriginal);

            if (indiceCliente == -1) {
                MessageBox.Show("Cliente não encontrado.");
                return;
            }

            Cliente cliente = clientes[indiceCliente];

            // Valida o novo código
            if (!int.TryParse(txtCodigo.Text, out int codigo)) {
                MessageBox.Show("Informe um código válido.");
                return;
            }

            // Verifica código duplicado
            bool codigoDuplicado = false;

            for (int i = 0; i < clientes.Count; i++) {
                if (i != indiceCliente && clientes[i].Codigo == codigo) {
                    codigoDuplicado = true;
                    break;
                }
            }

            if (codigoDuplicado) {
                MessageBox.Show("Já existe outro cliente com esse código.");
                return;
            }

            // Valida nome
            if (string.IsNullOrWhiteSpace(txtNome.Text)) {
                MessageBox.Show("Informe o nome do cliente.");
                return;
            }

            // Valida CPF
            if (string.IsNullOrWhiteSpace(txtCpf.Text)) {
                MessageBox.Show("Informe o CPF do cliente.");
                return;
            }

            if (!ValidarCpf(txtCpf.Text)) {
                MessageBox.Show("Informe um CPF válido.");
                return;
            }

            string cpfDigitado = LimparCpf(txtCpf.Text);

            // Verifica CPF duplicado
            bool cpfDuplicado = false;

            for (int i = 0; i < clientes.Count; i++) {
                if (i != indiceCliente &&
                    LimparCpf(clientes[i].Cpf) == cpfDigitado) {
                    cpfDuplicado = true;
                    break;
                }
            }

            if (cpfDuplicado) {
                MessageBox.Show("Já existe outro cliente cadastrado com esse CPF.");
                return;
            }

            // Valida telefone
            if (string.IsNullOrWhiteSpace(txtTelefone.Text)) {
                MessageBox.Show("Informe o telefone do cliente.");
                return;
            }

            if (!ValidarTelefone(txtTelefone.Text)) {
                MessageBox.Show("Informe um telefone válido com DDD.");
                return;
            }

            // Valida e-mail
            if (string.IsNullOrWhiteSpace(txtEmail.Text)) {
                MessageBox.Show("Informe o e-mail do cliente.");
                txtEmail.Focus();
                return;
            }

            if (!ValidarEmail(txtEmail.Text)) {
                MessageBox.Show("Informe um e-mail válido.");
                txtEmail.Focus();
                return;
            }

            // Atualiza os dados do cliente
            cliente.Codigo = codigo;
            cliente.Nome = txtNome.Text;
            cliente.Cpf = txtCpf.Text;
            cliente.Telefone = txtTelefone.Text;
            cliente.Email = txtEmail.Text;

            // Salva o cliente atualizado na lista
            clientes[indiceCliente] = cliente;

            // Atualiza o DataGridView
            dgvClientes.DataSource = null;
            dgvClientes.DataSource = clientes.ToList();

            MessageBox.Show("Cliente alterado com sucesso!");
        }

        private void btnCadastrar_Click(object sender, EventArgs e) {
            if (!int.TryParse(txtCodigo.Text, out int codigo)) {
                MessageBox.Show("Informe um código válido.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNome.Text)) {
                MessageBox.Show("Informe o nome do cliente.");
                txtNome.Focus();
                return;
            }

            if (!ValidarNome(txtNome.Text)) {
                MessageBox.Show("O nome deve conter apenas letras.");
                txtNome.Focus();
                return;
            }


            if (string.IsNullOrWhiteSpace(txtTelefone.Text)) {
                MessageBox.Show("Informe o telefone do cliente.");
                return;
            }

            if (!ValidarTelefone(txtTelefone.Text)) {
                MessageBox.Show("Informe um telefone válido com DDD.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCpf.Text)) {
                MessageBox.Show("Informe o CPF do cliente.");
                return;
            }

            if (!ValidarCpf(txtCpf.Text)) {
                MessageBox.Show("Informe um CPF válido.");
                return;
            }

            string cpfDigitado = LimparCpf(txtCpf.Text);

            if (clientes.Any(c => LimparCpf(c.Cpf) == cpfDigitado)) {
                MessageBox.Show("Já existe um cliente cadastrado com esse CPF.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTelefone.Text)) {
                MessageBox.Show("Informe o telefone do cliente.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text)) {
                MessageBox.Show("Informe o e-mail do cliente.");
                return;
            }

            if (!ValidarEmail(txtEmail.Text)) {
                MessageBox.Show("Informe um e-mail válido.");
                txtEmail.Focus();
                return;
            }


            if (clientes.Any(c => c.Codigo == codigo)) {
                MessageBox.Show("Já existe um cliente com esse código.");
                return;
            }

            Cliente cliente = new Cliente {
                Codigo = codigo,
                Nome = txtNome.Text,
                Cpf = txtCpf.Text,
                Telefone = txtTelefone.Text,
                Email = txtEmail.Text
            };

            clientes.Add(cliente);

            dgvClientes.DataSource = null;
            dgvClientes.DataSource = clientes;

            MessageBox.Show("Cliente cadastrado com sucesso!");

            txtCodigo.Text = GerarProximoCodigo().ToString();
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e) {

            if (e.RowIndex < 0)
                return;

            Cliente cliente = (Cliente)dgvClientes.Rows[e.RowIndex].DataBoundItem;

            txtCodigo.Text = cliente.Codigo.ToString();
            txtNome.Text = cliente.Nome;
            txtCpf.Text = cliente.Cpf;
            txtTelefone.Text = cliente.Telefone;
            txtEmail.Text = cliente.Email;

        }

        private void btnExcluir_Click(object sender, EventArgs e) {
            if (dgvClientes.CurrentRow == null) {
                MessageBox.Show("Selecione um cliente para excluir.");
                return;
            }

            Cliente cliente = (Cliente)dgvClientes.CurrentRow.DataBoundItem;

            DialogResult resultado = MessageBox.Show(
                $"Deseja realmente excluir o cliente '{cliente.Nome}'?",
                "Confirmar exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes) {
                clientes.Remove(cliente);

                dgvClientes.DataSource = null;
                dgvClientes.DataSource = clientes;

                MessageBox.Show("Cliente excluído com sucesso!");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e) {
            txtCodigo.Text = GerarProximoCodigo().ToString();
            txtNome.Clear();
            txtCpf.Clear();
            txtTelefone.Clear();
            txtEmail.Clear();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e) {

        }

        private void txtCpf_TextChanged(object sender, EventArgs e) {
            string cpf = txtCpf.Text;

            // Remove tudo que não for número
            cpf = new string(cpf.Where(char.IsDigit).ToArray());

            // Limita a 11 números
            if (cpf.Length > 11)
                cpf = cpf.Substring(0, 11);

            // Aplica a máscara
            if (cpf.Length <= 3) {
                txtCpf.Text = cpf;
            }
            else if (cpf.Length <= 6) {
                txtCpf.Text = cpf.Insert(3, ".");
            }
            else if (cpf.Length <= 9) {
                cpf = cpf.Insert(3, ".");
                cpf = cpf.Insert(7, ".");
                txtCpf.Text = cpf;
            }
            else {
                cpf = cpf.Insert(3, ".");
                cpf = cpf.Insert(7, ".");
                cpf = cpf.Insert(11, "-");
                txtCpf.Text = cpf;
            }

            // Coloca o cursor no final
            txtCpf.SelectionStart = txtCpf.Text.Length;
        }
        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e) {
            MessageBox.Show("Clique detectado!");
        }
    }
}
