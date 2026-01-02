using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Atividade
{
    public class Aluno
    {
        private string prontuario;
        private string nome;
        private string cpf;
        private string rg;
        private string email;

        public void Incluir()
        {

            string connectionString = "Server=localhost;Database=DbAcademico;Integrated Security=True;TrustServerCertificate=True";

            using (SqlConnection Con = new SqlConnection(connectionString))
            {
                try
                {
                    string sql = "INSERT INTO Alunos (Prontuario, Nome, CPF, RG, Email) VALUES (@Prontuario, @Nome, @CPF, @RG, @Email)";

                    using (SqlCommand comando = new SqlCommand(sql, Con))
                    {

                        comando.Parameters.AddWithValue("@Prontuario", Prontuario);
                        comando.Parameters.AddWithValue("@Nome", Nome);
                        comando.Parameters.AddWithValue("@CPF", CPF);
                        comando.Parameters.AddWithValue("@RG", RG);
                        comando.Parameters.AddWithValue("@Email", Email);

                        Con.Open();

                        int linhasAfetadas = comando.ExecuteNonQuery();

                        if (linhasAfetadas == 0)
                        {

                            throw new Exception("A inclusão não afetou nenhuma linha. Verifique as regras do banco de dados.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Erro ao incluir aluno no Banco de Dados: " + ex.Message, ex);
                }
            }
        }

        public bool Consultar()
        {
            using (SqlConnection Con = new SqlConnection())
            {
                Con.ConnectionString = "Server=localhost;Database=DbAcademico;Integrated Security=True;TrustServerCertificate=True";

                SqlCommand Comando = new SqlCommand();
                Comando.Connection = Con;
                Comando.CommandType = CommandType.Text;
                Comando.CommandText = "SELECT Prontuario, Nome, CPF, RG, Email FROM Alunos WHERE Prontuario = @Prontuario";
                Comando.Parameters.AddWithValue("@Prontuario", Prontuario);

                Con.Open();

                SqlDataReader DR = Comando.ExecuteReader();

                if (!DR.Read())
                    return false;

                this.Nome = DR["Nome"].ToString();
                this.CPF = DR["CPF"].ToString();
                this.RG = DR["RG"].ToString();
                this.Email = DR["Email"].ToString();

                return true;
            }
        }

        public void Alterar()
        {
            SqlConnection Con = new SqlConnection();
            try
            {
                Con.ConnectionString = "Server=localhost;Database=DbAcademico;Integrated Security=True;TrustServerCertificate=True";

                SqlCommand comando = new SqlCommand();
                comando.Connection = Con;
                comando.CommandType = CommandType.Text;

                
                comando.CommandText = "UPDATE Alunos SET Nome = @Nome, CPF = @CPF, RG = @RG, Email = @Email WHERE Prontuario = @Prontuario";
                comando.Parameters.AddWithValue("@Prontuario", Prontuario);
                comando.Parameters.AddWithValue("@Nome", Nome);
                comando.Parameters.AddWithValue("@CPF", CPF);
                comando.Parameters.AddWithValue("@RG", RG);
                comando.Parameters.AddWithValue("@Email", Email);

                
                Con.Open();

                
                int rowsAffected = comando.ExecuteNonQuery();

                if (rowsAffected == 0)
                {
                    throw new Exception("Nenhum aluno encontrado com o prontuário informado.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao alterar dados do aluno: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        public void Excluir()
        {
            SqlConnection Con = new SqlConnection();
            try
            {
                Con.ConnectionString =
                Con.ConnectionString = "Server=localhost;Database=DbAcademico;Integrated Security=True;TrustServerCertificate=True";
                SqlCommand comando = new SqlCommand();
                comando.Connection = Con;
                comando.CommandType = CommandType.Text;

                
                comando.CommandText = "DELETE FROM Alunos WHERE Prontuario = @Prontuario";
                comando.Parameters.AddWithValue("@Prontuario", Prontuario);

                
                Con.Open();

               
                int rowsAffected = comando.ExecuteNonQuery();

                if (rowsAffected == 0)
                {
                    throw new Exception("Nenhum aluno encontrado com o prontuário informado.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao excluir dados do aluno: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }


        public string Prontuario
        {
            get { return prontuario; }
            set
            {
                if (!Validades.ValidaProntuario(value))
                    throw new Exception("Prontuario Inválido!");
                else
                    prontuario = value;
            }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string CPF
        {
            get { return cpf; }
            set {
                if (!Validades.ValidaCPF(value))
                    throw new Exception("CPF Inválido!");
                else
                    cpf = value; }
        }

        public string RG
        {
            get { return rg; }
            set
            {
                if (!Validades.ValidaRG(value))
                    throw new Exception("RG Inválido!");
                else
                    rg = value;
            }
        }


        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    

    }

 }
