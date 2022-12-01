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
    public partial class AddCar : Form
    {
        public AddCar()
        {
            InitializeComponent();
        }



        public async Task Write()
        {

            string connectionString = "Server=(localdb)\\mssqllocaldb;Database=carDealer;Trusted_Connection=True;";

            string CarColor = Color_Write.Text;
            string CarType = Type_Write.Text;
            string CarDoors = Doors_Write.Text;
            string CarVolume = Volume_Write.Text;
            string CarPrice = Price_Write.Text;
            string CarYear = Year_Write.Text;

            string sqlExpression = $"INSERT INTO Cars (Color, Type, NumDoors, EngineVolume, Price, Year) VALUES ('{CarColor}', '{CarType}', {CarDoors}, {CarVolume}, {CarPrice}, {CarYear})";
            //string sqlExpression = $"INSERT INTO Cars (Color, Type, NumDoors, EngineVolume, Price, Year) VALUES ('Red', 'Red', 1, 1, 1, 1)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();

                SqlCommand command = new SqlCommand(sqlExpression, connection);
                await command.ExecuteNonQueryAsync();

            }
        }

        private async void Write_Car_Click(object sender, EventArgs e)
        {
            await Write();
            this.Close();
        }

        private void Color_Write_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private async void Type_Write_MouseClick(object sender, MouseEventArgs e)
        {
            using (CarTypeList newForm = new CarTypeList())
            {
                if (newForm.ShowDialog() == DialogResult.OK)
                {
                    Type_Write.Text = newForm.Chosen;
                }
            }         
            
        }
    }
}
