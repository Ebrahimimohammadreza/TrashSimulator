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
    public partial class frmServer : Form
    {
        DBManager _db = new DBManager();
        public frmServer()
        {
            InitializeComponent();
        }

        private void frmServer_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        public void SetTrashStatus(Guid trashID, double latitude, double longitude, int Occupied)
        {
            _db.upsert(trashID, latitude, longitude, Occupied);
            if (Occupied >= 80)
            {
                //Trash Check = evacuationQueue.First<Trash>(x => x.ID == trashID);
                bool flag = true;

                foreach (var item in Common.evacuationQueue)
                {
                    if (item.ID == trashID)
                        flag = false;
                }
                if (flag)
                    Common.evacuationQueue.Add(new Trash() { ID = trashID, Lat = latitude, Lon = longitude });
            }

        }

        public Trash GetTeashToEmpty(double emptierLat, double emptierLon)
        {
            Trash trash = CalEvacuation(emptierLat, emptierLon);
            //if (trash != null)
            //{
            //    _db.emptyOrderUPdate(trash.ID, 1);
            //}
            return trash;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _db.getTrash().Tables[0];
        }

        private void frmServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Enabled = false;
        }

        private Trash CalEvacuation(double emptierLat, double emptierLon)
        {
            try
            {
                Trash SelectedTrash = new Trash();
                double minDistance = 99999999999999;
                if (Common.evacuationQueue.Count > 0)
                {
                    foreach (var item in Common.evacuationQueue)
                    {
                        double result = locationManager.getDistance(emptierLat, emptierLon, item.Lat, item.Lon);
                        if (result < minDistance)
                        {
                            minDistance = result;
                            SelectedTrash = item;
                        }
                    }
                    Common.evacuationQueue.Remove(SelectedTrash);
                    return SelectedTrash;
                }
                else

                {
                    return null;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
