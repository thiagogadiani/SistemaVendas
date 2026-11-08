using System;
using System.Drawing;
using System.Windows.Forms;

namespace SistemaVendas
{
    internal static class TemaSistema
    {
        internal static readonly Color Fundo = Color.FromArgb(245, 247, 250);
        internal static readonly Color Azul = Color.FromArgb(37, 99, 235);
        internal static readonly Color AzulEscuro = Color.FromArgb(20, 35, 62);
        internal static readonly Color Texto = Color.FromArgb(35, 45, 60);
        internal static readonly Color Cinza = Color.FromArgb(225, 231, 239);
        internal static readonly Color Verde = Color.FromArgb(22, 163, 74);
        internal static readonly Color Vermelho = Color.FromArgb(220, 53, 69);

        internal static void Aplicar(Form form)
        {
            form.BackColor = Fundo;
            form.ForeColor = Texto;
            form.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.AutoScaleMode = AutoScaleMode.Font;

            AplicarNosControles(form);
        }

        private static void AplicarNosControles(Control pai)
        {
            foreach (Control controle in pai.Controls)
            {
                if (controle is Label label)
                {
                    label.ForeColor = Texto;
                    label.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
                    if (label.Name.Contains("Titulo", StringComparison.OrdinalIgnoreCase))
                    {
                        label.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
                        label.ForeColor = AzulEscuro;
                    }
                }
                else if (controle is Button botao)
                {
                    botao.FlatStyle = FlatStyle.Flat;
                    botao.FlatAppearance.BorderSize = 0;
                    botao.BackColor = Azul;
                    botao.ForeColor = Color.White;
                    botao.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
                    botao.Cursor = Cursors.Hand;
                    botao.Height = Math.Max(botao.Height, 38);
                }
                else if (controle is TextBox caixa)
                {
                    caixa.Font = new Font("Segoe UI", 10F);
                    caixa.BorderStyle = BorderStyle.FixedSingle;
                    caixa.BackColor = caixa.ReadOnly ? Color.FromArgb(235, 239, 245) : Color.White;
                }
                else if (controle is ComboBox combo)
                {
                    combo.Font = new Font("Segoe UI", 10F);
                    combo.FlatStyle = FlatStyle.Flat;
                    combo.BackColor = Color.White;
                }
                else if (controle is DataGridView grade)
                {
                    grade.BackgroundColor = Color.White;
                    grade.BorderStyle = BorderStyle.None;
                    grade.GridColor = Cinza;
                    grade.EnableHeadersVisualStyles = false;
                    grade.ColumnHeadersDefaultCellStyle.BackColor = AzulEscuro;
                    grade.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                    grade.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
                    grade.ColumnHeadersHeight = 40;
                    grade.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F);
                    grade.DefaultCellStyle.ForeColor = Texto;
                    grade.DefaultCellStyle.BackColor = Color.White;
                    grade.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
                    grade.DefaultCellStyle.SelectionForeColor = Texto;
                    grade.RowTemplate.Height = 34;
                    grade.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
                    grade.BorderStyle = BorderStyle.FixedSingle;
                }

                if (controle.HasChildren)
                    AplicarNosControles(controle);
            }
        }

        internal static void AplicarPainelPrincipal(
            Form form, Label titulo, Button produtos, Button clientes,
            Button vendas, Button estoque, Button relatorios, Button sair)
        {
            form.SuspendLayout();
            form.Controls.Clear();
            form.BackColor = Fundo;
            form.ClientSize = new Size(1180, 760);
            form.MinimumSize = new Size(1000, 680);
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Font = new Font("Segoe UI", 10F);
            form.Text = "Sistema de Vendas";

            var menu = new Panel
            {
                BackColor = AzulEscuro,
                Dock = DockStyle.Left,
                Width = 245,
                Padding = new Padding(18, 24, 18, 18)
            };

            var marca = new Label
            {
                Text = "SISTEMA\\nDE VENDAS",
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 19F, FontStyle.Bold),
                Location = new Point(22, 25),
                Size = new Size(200, 75)
            };
            menu.Controls.Add(marca);

            var legendaMenu = new Label
            {
                Text = "MENU PRINCIPAL",
                ForeColor = Color.FromArgb(160, 175, 198),
                Font = new Font("Segoe UI", 8.5F, FontStyle.Bold),
                Location = new Point(24, 125),
                Size = new Size(190, 25)
            };
            menu.Controls.Add(legendaMenu);

            Button[] botoes = { produtos, clientes, vendas, estoque, relatorios, sair };
            string[] textos = { "  Produtos", "  Clientes", "  Vendas", "  Estoque", "  Relatórios", "  Sair do sistema" };

            for (int i = 0; i < botoes.Length; i++)
            {
                Button botao = botoes[i];
                botao.Parent?.Controls.Remove(botao);
                botao.Text = textos[i];
                botao.TextAlign = ContentAlignment.MiddleLeft;
                botao.Location = new Point(12, 165 + i * 62);
                botao.Size = new Size(205, 48);
                botao.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                botao.BackColor = i == 5 ? Color.FromArgb(153, 48, 58) : AzulEscuro;
                botao.ForeColor = Color.White;
                botao.FlatStyle = FlatStyle.Flat;
                botao.FlatAppearance.BorderSize = 0;
                botao.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                botao.Cursor = Cursors.Hand;
                menu.Controls.Add(botao);
            }

            var area = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Fundo,
                Padding = new Padding(34, 28, 34, 28)
            };

            titulo.AutoSize = false;
            titulo.Text = "Visão geral";
            titulo.Location = new Point(34, 25);
            titulo.Size = new Size(600, 42);
            titulo.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            titulo.ForeColor = AzulEscuro;
            area.Controls.Add(titulo);

            var subtitulo = new Label
            {
                Text = "Bem-vindo ao painel de gerenciamento do seu negócio.",
                Location = new Point(37, 72),
                Size = new Size(700, 28),
                ForeColor = Color.FromArgb(105, 117, 135),
                Font = new Font("Segoe UI", 10F)
            };
            area.Controls.Add(subtitulo);

            var linha = new Panel
            {
                BackColor = Cinza,
                Location = new Point(35, 115),
                Size = new Size(850, 1),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
            };
            area.Controls.Add(linha);

            AdicionarCard(area, "CADASTROS", "Clientes e produtos", "Gerencie os dados básicos do sistema.", 35, 155);
            AdicionarCard(area, "OPERAÇÃO", "Vendas e estoque", "Registre vendas e acompanhe produtos.", 465, 155);
            AdicionarCard(area, "ACOMPANHAMENTO", "Relatórios", "Consulte o histórico das movimentações.", 35, 345);

            var rodape = new Label
            {
                Text = "SistemaVendas  •  Aplicação de gerenciamento comercial",
                AutoSize = true,
                ForeColor = Color.FromArgb(130, 140, 155),
                Font = new Font("Segoe UI", 8.5F),
                Anchor = AnchorStyles.Bottom | AnchorStyles.Left,
                Location = new Point(37, 650)
            };
            area.Controls.Add(rodape);

            form.Controls.Add(area);
            form.Controls.Add(menu);
            form.ResumeLayout(true);
        }

        private static void AdicionarCard(Control area, string categoria, string titulo, string descricao, int x, int y)
        {
            var card = new Panel
            {
                BackColor = Color.White,
                Location = new Point(x, y),
                Size = new Size(390, 145),
                BorderStyle = BorderStyle.FixedSingle,
                Anchor = AnchorStyles.Top | AnchorStyles.Left
            };

            card.Controls.Add(new Label
            {
                Text = categoria,
                Location = new Point(20, 16),
                Size = new Size(340, 20),
                ForeColor = Azul,
                Font = new Font("Segoe UI", 8.5F, FontStyle.Bold)
            });
            card.Controls.Add(new Label
            {
                Text = titulo,
                Location = new Point(20, 43),
                Size = new Size(340, 30),
                ForeColor = AzulEscuro,
                Font = new Font("Segoe UI", 15F, FontStyle.Bold)
            });
            card.Controls.Add(new Label
            {
                Text = descricao,
                Location = new Point(20, 82),
                Size = new Size(345, 38),
                ForeColor = Color.FromArgb(105, 117, 135),
                Font = new Font("Segoe UI", 9.5F)
            });

            area.Controls.Add(card);
        }
    }
}
