using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrashSimulator
{
    public partial class frmTrash : Form
    {
        public frmTrash()
        {
            InitializeComponent();
        }
        private Guid id;
        private int Capacity = 100;
        public int Occupied = 0;
        private double Longitude = 0;
        private double Latitude =0;

        private frmServer server = new frmServer();

        private void frmTrash_Load(object sender, EventArgs e)
        {
            id = Guid.Parse(this.Tag.ToString());
            Latitude = locationManager.Latitude();
            Longitude = locationManager.Longitude();
            lblTrashID.Text = id.ToString();
            lblLongitude.Text = Longitude.ToString();
            lblLatitude.Text = Latitude.ToString();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblMessage.Text = string.Empty;
            Random rnd = new Random();
            Occupied += rnd.Next(0, Capacity - Occupied > 10 ? 10 : (Capacity - Occupied) + 1);
            lblOccupied.Text = Occupied.ToString();
            progressBar1.Value = Occupied;

            if (Occupied <= 79)
            {
                plnLED.BackColor = Color.Green;
                lblExtra.Text = "Extra Capacity Closed";
                lblExtra.BackColor = Color.AntiqueWhite;
                server.SetTrashStatus(id, Latitude, Longitude, Occupied);
            }
            else if (Occupied >= 80 && Occupied < 100)
            {
                plnLED.BackColor = Color.Yellow;
                lblExtra.Text = "Extra Capacity Opened";
                lblExtra.BackColor = Color.DarkSeaGreen;
                server.SetTrashStatus(id, Latitude, Longitude, Occupied);
                lblMessage.Text = "1";
            }
            else
            {
                plnLED.BackColor = Color.Red;
                lblExtra.Text = "Trash Locked";
                lblExtra.BackColor = Color.Tomato;
                server.SetTrashStatus(id, Latitude, Longitude, Occupied);
                lblMessage.Text = "2";
            }

        }
    }
}
