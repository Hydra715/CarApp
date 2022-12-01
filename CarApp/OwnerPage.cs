using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarApp
{
    public partial class OwnerPage : Form
    {
        public OwnerPage(string id)
        {
            ID = id;
            InitializeComponent();
        }

        private async void OwnerPage_Load(object sender, EventArgs e)
        {
            await GetOwner();
        }

        public async Task GetOwner()
        {

            string connectionString = "Server=(localdb)\\mssqllocaldb;Database=carDealer;Trusted_Connection=True;";
            string sqlExpression = $"SELECT * FROM Owners WHERE id IN ({this.ID})";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();

                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = await command.ExecuteReaderAsync();

                if (reader.HasRows) // если есть данные
                {
                    // выводим названия столбцов

                    while (await reader.ReadAsync()) // построчно считываем данные
                    {
                        object FirstName = reader["First_Name"];
                        object SecondName = reader["Second_Name"];


                        FirstName_In.Text =  SecondName.ToString();
                        LastName_In.Text = FirstName.ToString();

                    }
                }
                await reader.CloseAsync();
            }
        }
    }
}
