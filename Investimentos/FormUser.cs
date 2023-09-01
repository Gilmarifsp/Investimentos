using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Investimentos
{
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();
        }
        private void UpdateListView()
        {
            Connection conn = new Connection();
            SqlCommand sqlcom = new SqlCommand();

            sqlcom.Connection = conn.ReturnConnection();
            sqlcom.CommandText = "SELECT * FROM TB_TB_USER";

            try
            {
                sqlDataReader rd = SqlCon.ExecuteReader();

                //Enquanto for possivel continuar a leitura

                while (rd.Read())
                {
                    int id = (int)rd.["Id"];
                    string name = (string)rd["Name"];
                    string profissao = (string)rd["Profissao"];
                    string email = (string)rd.["Email"];
                    string cpf = (string)rd.["CPF"];

                    ListViewItem item = new ListViewItem(string());
                    ListView.Sub
                }
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txbName.Clear();
            txbJob.Clear();
            txbEmail.Clear();
            mtbCPF.Clear();
            cmbGenero.ResetText();
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            
        }
    }
}
