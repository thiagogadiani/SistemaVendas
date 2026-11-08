using System;
using System.Windows.Forms;

namespace SistemaVendas {
    public partial class FrmLogin : Form {
        public FrmLogin() {
            InitializeComponent();
            TemaSistema.Aplicar(this);
        }

        private void btnEntrar_Click(object sender, EventArgs e) {
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;

            if (usuario == "admin" && senha == "1234") {
                FrmPrincipal principal = new FrmPrincipal();

                principal.Show();

                this.Hide();
            }
            else {
                MessageBox.Show(
                    "Usuário ou senha inválidos!",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }
}