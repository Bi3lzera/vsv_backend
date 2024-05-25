using MySql.Data.MySqlClient;
using System.Data;

namespace vsv_back.src.sql
{
          public class SQL
          {
                    public bool isvalidconnection = false;
                    private static string[] serverConfigs = new string[4];

                    public bool validateconnection()
                    {
                              MySqlConnection connection = new MySqlConnection(Connection_String());

                              try
                              {
                                        connection.Open();
                                        connection.Close();
                                        isvalidconnection = true;
                                        return true;
                              } catch
                              {
                                        isvalidconnection = false;
                                        return false;
                              }
                    }

                    public string Connection_String()
                    {
                              string server = "localhost";
                              string port = "3306";
                              string uid = "root";
                              string pwd = "biel123";

                              if (serverConfigs[0] != null && serverConfigs[1] != null && serverConfigs[2] != null && serverConfigs[3] != null)
                              {
                                        string Connection_String = "Persist Security Info=false;server=" + server + ";port=" + port + ";uid=" + uid + ";pwd=" + pwd + ";";
                                        return Connection_String;
                              } else
                              {
                                        return "notconfigurated";
                              }
                    }

                    public void InsertInTable(string SQL_Command)
                    {
                              if (Connection_String() == "notconfigurated")
                              {
                                        return;
                              }

                              MySqlConnection connection = new MySqlConnection(Connection_String());
                              MySqlCommand command = new MySqlCommand(SQL_Command, connection);

                              try
                              {
                                        connection.Open();
                                        command.ExecuteNonQuery();
                              } catch (MySqlException ex)
                              {
                                        if (isvalidconnection)
                                        {
                                                  Console.WriteLine("Não foi possível estabelecer uma conexão com o banco de dados. Dados não serão armazenados e não será possível consultar informações." + ex.ToString());
                                        }
                              }
                    }

                    public DataTable GetTable(string SQL_Command)
                    {
                              if (Connection_String() == "notconfigurated")
                              {
                                        Console.WriteLine("Connection String NOT CONFIGURATED");
                                        return null;
                              }

                              MySqlConnection connection = new MySqlConnection(Connection_String());
                              MySqlDataAdapter DataAdapter = new MySqlDataAdapter();
                              MySqlCommand command = new MySqlCommand(SQL_Command, connection);

                              try
                              {
                                        connection.Open();
                                        DataAdapter.SelectCommand = command;
                                        DataTable DataTable = new DataTable();
                                        DataAdapter.Fill(DataTable);
                                        return DataTable;

                              } catch (MySqlException ex)
                              {
                                        if (isvalidconnection)
                                        {
                                                  Console.WriteLine("Não foi possível estabelecer uma conexão com o banco de dados. Dados não serão armazenados e não será possível consultar informações." + ex.ToString());
                                        }
                                        return null;
                              }
                    }

                    //Getters e Setters que configura a conexão com o Banco de Dados SQL
                    public static string server
                    {
                              get { return serverConfigs[0]; }
                              set { serverConfigs[0] = value; }
                    }
                    public static string port
                    {
                              get { return serverConfigs[1]; }
                              set { serverConfigs[1] = value; }
                    }
                    public static string uid
                    {
                              get { return serverConfigs[2]; }
                              set { serverConfigs[2] = value; }
                    }
                    public static string pwd
                    {
                              get { return serverConfigs[3]; }
                              set { serverConfigs[3] = value; }
                    }
          }
}