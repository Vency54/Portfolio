namespace Atividade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                Aluno a = new Aluno();

                a.Nome = txtNome.Text;
                a.Email = txtEmail.Text;
                a.RG = txtRG.Text;
                a.CPF = txtCPF.Text;
                a.Prontuario = txtProntuario.Text;

                a.Incluir();

                MessageBox.Show("Aluno incluído com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCPF.Clear();
            txtProntuario.Clear();
            txtRG.Clear();
            txtNome.Clear();
            txtEmail.Clear();
            txtProntuario.Clear();
        }

        private void Consultar_Click(object sender, EventArgs e)
        {
            {
                Aluno a = new Aluno();
                a.Prontuario = txtProntuario.Text;

                if (a.Consultar())
                {
                    // Preenche os campos do formulário
                    txtNome.Text = a.Nome;
                    txtCPF.Text = a.CPF;
                    txtRG.Text = a.RG;
                    txtEmail.Text = a.Email;
                }
                else
                {
                    MessageBox.Show("Aluno não encontrado!");
                }
            }
        }

        private void Alterar_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    Aluno aluno = new Aluno();

                    // Preenche a classe com os valores do formulário
                    aluno.Prontuario = txtProntuario.Text;
                    aluno.Nome = txtNome.Text;
                    aluno.CPF = txtCPF.Text;
                    aluno.RG = txtRG.Text;
                    aluno.Email = txtEmail.Text;

                    // Chama o método que altera no banco
                    aluno.Alterar();

                    MessageBox.Show("Aluno alterado com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao alterar: " + ex.Message);
                }
            }
        }

        private void Excluir_Click(object sender, EventArgs e)
        {
            try
            {
                // Criar objeto aluno
                Aluno aluno = new Aluno();

                // Prontuário vem do campo do formulário
                aluno.Prontuario = txtProntuario.Text;

                // Chamar método de exclusão
                aluno.Excluir();

                MessageBox.Show("Aluno excluído com sucesso!");

                // Opcional: limpar o formulário após excluir
                txtProntuario.Clear();
                txtNome.Clear();
                txtCPF.Clear();
                txtRG.Clear();
                txtEmail.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
