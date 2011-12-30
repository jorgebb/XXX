using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlTypes; 
using System.Data.SqlClient;

namespace WindowsApplication24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Abertura da base de dados, execução do stored procedure e carregamento do dataset
            SqlConnection ligacaoBD = null;
            SqlCommand Cmd1 = null;

            ligacaoBD = new SqlConnection("Server=P-CODE003W\SQLEXPRESS;Database=Vending;Trusted_Connection=True;MultipleActiveResultSets=true;");

            ligacaoBD.Open();

            Cmd1 = new SqlCommand("SP_GERA_INV", ligacaoBD);
            Cmd1.CommandType = CommandType.StoredProcedure;

            Cmd1.Ar
            Cmd1.ExecuteNonQuery();
            Cmd1.Dispose();


                }
                catch (Exception Ex)
                {
                    LOG.Append("GeraSAFT() " + Ex.Message, LOG.ERROR);

                    // PARA JÁ
                    Cmd1 = new SqlCommand("ApagaSAFT", ligacaoBD);
                    Cmd1.CommandType = CommandType.StoredProcedure;
                    Cmd1.ExecuteNonQuery();
                    Cmd1.Dispose();
                    //
                }
                //              

        }
    }
}