using AvaliacaoPratica.BDados;
using AvaliacaoPratica.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace AvaliacaoPratica.DAO
{
    public class ProfessorDAO
    {
        public List<ProfessorModel> ObterTodos()
        {
            List<ProfessorModel> professor = new List<ProfessorModel>();
            SqlCommand comando = new BancoDeDados().ObterConexao();
            comando.CommandText = "SELECT Id, Nome FROM dbo.Professor";
            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());

            foreach (DataRow linha in tabela.Rows)
            {
                ProfessorModel aluno = new ProfessorModel()
                {
                    Id = Convert.ToInt32(linha[0].ToString()),
                    Nome = linha[1].ToString(),
                };
                professor.Add(aluno);
            }
            return professor;
        }
        //public int Cadastrar(ProfessorModel aluno)
        //{
        //    SqlCommand comando = new BancoDeDados().ObterConexao();
        //    comando.CommandText = @"INSERT INTO dbo.Aluno (NomeAluno,DataNascimento) OUTPUT
        //    INSERTED.ID VALUES (@NOMEALUNO, @DATANASCIMENTO)";
        //    comando.Parameters.AddWithValue("@NOMEALUNO", aluno.NomeAluno);
        //    comando.Parameters.AddWithValue("@DATANASCIMENTO", aluno.DataNascimento);
        //    int id = Convert.ToInt32(comando.ExecuteScalar().ToString());
        //    return id;
        //}

        //public bool Alterar(ProfessorModel aluno)
        //{
        //    SqlCommand comando = new BancoDadosConexao().ObterConexao();
        //    comando.CommandText = "UPDATE dbo.Aluno SET NomeAluno = @NOMEALUNO, DataNascimento = @DATANASCIMENTO WHERE IDAluno = @IDALUNO";
        //    comando.Parameters.AddWithValue("@NOME", aluno.NomeAluno);
        //    comando.Parameters.AddWithValue("@CODIGO_MATRICULA", aluno.DataNascimento);
        //    return comando.ExecuteNonQuery() == 1;
        //}

        //public bool Excluir(int id)
        //{
        //    SqlCommand comando = new BancoDadosConexao().ObterConexao();
        //    comando.CommandText = "DELETE FROM dbo.Aluno WHERE IDAluno = @IDALUNO";
        //    comando.Parameters.AddWithValue("@IDALUNO", id);
        //    return comando.ExecuteNonQuery() == 1;
        //}

        //public ProfessorModel ObterPeloID(int id)
        //{
        //    ProfessorModel aluno = null;
        //    SqlCommand comando = new BancoDadosConexao().ObterConexao();
        //    comando.CommandText = "SELECT IDAluno,NomeAluno,DataNascimento,IDProfessorResponsavel FROM dbo.Aluno WHERE IDAluno = @IDALUNO";
        //    comando.Parameters.AddWithValue("@IDALUNO", id);
        //    DataTable tabela = new DataTable();
        //    tabela.Load(comando.ExecuteReader());
        //    if (tabela.Rows.Count == 1)
        //    {
        //        aluno = new ProfessorModel();
        //        aluno.ID = id;
        //        aluno.NomeAluno = tabela.Rows[0][0].ToString();
        //        aluno.DataNascimento = Convert.ToDateTime(tabela.Rows[0][1].ToString());
        //        aluno.IDProfessorResposavel = Convert.ToInt32(tabela.Rows[0][2].ToString());
        //    }
        //    return aluno;
        //}
    }
}
