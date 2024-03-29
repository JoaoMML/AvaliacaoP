﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AvaliacaoPratica.BDados
{
    public class BancoDeDados
    {
        private static string connectionString;

        static BancoDeDados()
        {
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        }

        public SqlCommand ObterConexao()
        {
            SqlConnection conexao = new SqlConnection(connectionString);
            conexao.Open();
            SqlCommand command = new SqlCommand();
            command.Connection = conexao;
            return command;
        }
    }
}