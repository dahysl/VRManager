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

namespace LoginTest
{
    public partial class Register : Form
    {


        public Register()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }


        private void btnClose_Click(object sender, EventArgs e)
        {

        }


        private void btnRegister_Click(object sender, EventArgs e)
        {

        }


        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void txtMobile_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox_Enter(object sender, EventArgs e)
        {

        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            Insert();
            //User user = new User();
            //user.UserID = txtID.Text.Trim();
            //user.UserName = txtUsername.Text.Trim();
            //user.PhoneNum = txtMobile.Text.Trim();
            //user.Password = txtPassword.Text.Trim();
            //user.Email = txtEmail.Text.Trim();            
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMobile_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            Welcome welcome = new Welcome();
            welcome.Owner = this;
            welcome.Show();
        }

        public void Insert()
        {
            try
            {
                SqlConnection connection = new SqlConnection();
                connection.ConnectionString = @"Server=10.10.14.80\MSSQLSERVER, 1433; database=vrManagementSys;uid=dev;pwd=1";
                connection.Open();

                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "User_Insert";
                command.Parameters.AddWithValue("@UserID", txtID.Text);
                command.Parameters.AddWithValue("@UserName", txtUsername.Text);
                command.Parameters.AddWithValue("@Password", txtPassword.Text);
                command.Parameters.AddWithValue("@PhoneNum", txtMobile.Text);
                command.Parameters.AddWithValue("@Email", txtEmail.Text);

                MessageBox.Show("회원가입 완료", "Information");


                //SqlParameter parameter = new SqlParameter("@UserID", SqlDbType.NVarChar);
                //parameter.Value = txtID.Text.Trim();
                //command.Parameters.Add(parameter);

                //parameter = new SqlParameter("@UserName", SqlDbType.NVarChar);
                //parameter.Value = txtUsername.Text.Trim();
                //command.Parameters.Add(parameter);

                //parameter = new SqlParameter("@Password", SqlDbType.NVarChar);
                //parameter.Value = txtPassword.Text.Trim();
                //command.Parameters.Add(parameter);

                //parameter = new SqlParameter("@PhoneNum", SqlDbType.NVarChar);
                //parameter.Value = txtMobile.Text.Trim();
                //command.Parameters.Add(parameter);

                //parameter = new SqlParameter("@Email", SqlDbType.NVarChar);
                //parameter.Value = txtEmail.Text.Trim();
                //command.Parameters.Add(parameter);

                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        //public static SqlCommand CreateCommand(string commandText, SqlConnection connection)
        //{
        //    SqlCommand command = new SqlCommand();
        //    command.Connection = connection;
        //    command.CommandType = CommandType.StoredProcedure;
        //    command.CommandText = "User_Insert";    //저장 프로시저명
        //    return command;
        //}

        //public static SqlConnection CreateAndOpenConnection()
        //{
        //    SqlConnection connection = new SqlConnection();
        //    connection.ConnectionString = @"server=10.10.14.80\MSSQLSERVER, 1433; database=vrManagementSys;uid=dev;pwd=1";
        //    connection.Open();
        //    return connection;
        //}
    }
}
