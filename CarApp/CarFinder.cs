using Microsoft.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace CarApp
{
    public partial class CarFinder : Form
    {
        public CarFinder()
        {
            InitializeComponent();

        }

        private async void FindCar_Click(object sender, EventArgs e)
        {
            int i;
            if (int.TryParse(idBox.Text, out i))
            {
                await Request();
            }
            else {
                idBox.BackColor = System.Drawing.ColorTranslator.FromHtml("#FFCC66"); 
            };
            
        }

        public async Task Request()
        {
            string idText = idBox.Text;

            string connectionString = "Server=(localdb)\\mssqllocaldb;Database=carDealer;Trusted_Connection=True;";
            string sqlExpression = $"SELECT * FROM Cars WHERE id IN ({idText})";

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
                        object color = reader["Color"];
                        object type = reader["Type"];
                        object doors = reader["NumDoors"];
                        object EngineVolume = reader["EngineVolume"];
                        object Price = reader["Price"];
                        object Year = reader["Year"];

                        Color_Out.Text = color.ToString();
                        Type_Out.Text = type.ToString();
                        Doors_Out.Text = doors.ToString();
                        Volume_Out.Text = EngineVolume.ToString();
                        Price_Out.Text = Price.ToString();
                        Year_Out.Text = Year.ToString();

                            
                    }
                }
                await reader.CloseAsync();

            }
        }

        private void AddCar_Click(object sender, EventArgs e)
        {
            AddCar newForm = new AddCar();
            newForm.Show();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string idText = idBox.Text;
            object ownerId = 3;

            string connectionString = "Server=(localdb)\\mssqllocaldb;Database=carDealer;Trusted_Connection=True;";
            string sqlExpression = $"SELECT OwnerID FROM Cars WHERE id IN ({idText})";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();

                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = await command.ExecuteReaderAsync();

                if (reader.HasRows) // если есть данные
                {

                    while (await reader.ReadAsync()) // построчно считываем данные
                    {
                        ownerId = reader["OwnerID"];

                    }
                }
                await reader.CloseAsync();

            }


            OwnerPage newForm = new OwnerPage(ownerId.ToString());
            newForm.Show();
        }

        private void idBox_MouseDown(object sender, MouseEventArgs e)
        {
            idBox.BackColor = SystemColors.Window;
        }
    }
}