using System.Data.SqlClient;

namespace AcessHunter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_criaprocs_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = $"Server={box_servidor.Text};Database={box_bd.Text};User Id={box_usuario.Text};Password={box_senha.Text};TrustServerCertificate=True";
                using (SqlConnection connection = new SqlConnection())
                {
                    connection.ConnectionString = connectionString;
                    if (!Directory.Exists("SQL/"))
                    {
                        Directory.CreateDirectory("SQL/");
                    }


                    var files = Directory.GetFiles("SQL/");
                    if (files.Length > 0)
                    {
                        connection.Open();

                        foreach (string file in files)
                        {
                            if (Path.GetExtension(file) != ".sql")
                            {
                                MessageBox.Show($"O arquivo {file} não é um arquivo .SQL");
                                return;
                            }

                            string nomeProc = Path.GetFileName(file).Split(".")[0];
                            string buscaProc = $"SELECT * FROM SYS.OBJECTS WHERE TYPE = 'P' AND OBJECT_ID = OBJECT_ID('{nomeProc}')";
                            var command = connection.CreateCommand();
                            command.CommandText = buscaProc;
                            using(var dr = command.ExecuteReader())
                            {
                                if (dr.Read())
                                {
                                    dr.Close();

                                    using(var command_delete = connection.CreateCommand())
                                    {
                                        command_delete.CommandText = $"DROP PROCEDURE {nomeProc}";
                                        command_delete.ExecuteNonQuery();
                                    }
                                   
                                }
                            
                            }

                            var criarProc = File.ReadAllText(file);
                            using(var commandCreateProc = connection.CreateCommand())
                            {
                                commandCreateProc.CommandText = criarProc;  
                                commandCreateProc.ExecuteNonQuery();
                                MessageBox.Show($"Procedure {nomeProc} criada com sucesso");
                            }
                        }
                        connection.Close();

                    }
                    else
                    {
                        MessageBox.Show("Não há arquivos .sql para criar no banco de dados");
                    }
                }
            }
            catch (SqlException sqlexception)
            {

                MessageBox.Show("Ocorreu um erro: " + sqlexception.Message);
            }
            
        }



    }
}