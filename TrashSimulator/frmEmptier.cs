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
    public partial class frmEmptier : Form
    {
        private frmServer server = new frmServer();
        private DBManager _db = new DBManager();
        public double Lon = locationManager.Latitude();
        public double Lat = locationManager.Longitude();

        public frmEmptier()
        {
            InitializeComponent();
        }

        private void frmEmptier_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            lblLongitude.Text = Lon.ToString();
            lblLatitude.Text = Lat.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                timer1.Enabled = false;
                Trash trash = server.GetTeashToEmpty(Lat,Lon);
                if (trash != null)
                {
                    lblTrashID.Text = trash.ID.ToString();
                    for (int i = 1; i <= this.Parent.Parent.Controls.Count; i++)
                    {
                        if (this.Parent.Controls[i].Tag != null && this.Parent.Controls[i].Tag.Equals(trash.ID.ToString()))
                        {
                            ((frmTrash)this.Parent.Controls[i]).Occupied = 0;
                            ((frmTrash)this.Parent.Controls[i]).lblMessage.Text = "Trash is Clear";
                        }
                    }
                    //_db.emptyOrderUPdate(trash.ID, 0);
                    Random rnd = new Random();
                    timer1.Interval = rnd.Next(10000, 20000);
                }
                else
                {
                    lblTrashID.Text = "No Trash To Empty";
                    timer1.Interval = 1000;
                }
                lblInterval.Text = timer1.Interval.ToString();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                timer1.Enabled = true;
            }
        }

        private void frmEmptier_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Dispose();
        }
    }
}
