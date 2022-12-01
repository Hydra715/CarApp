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
    public partial class CarTypeList : Form
    {

        public string Chosen
        {
            get {
                return CarType.SelectedItem.ToString() ?? "";
            }
        }


        public CarTypeList()
        {
            InitializeComponent();
        }

        private void CarTypeList_Load(object sender, EventArgs e)
        {
            string[] types = { "Sedan", "Hatchback", "LiftBack", "Roadster", "Trailer", "Truck", "Van" };
            CarType.Items.AddRange(types);
            CarType.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
