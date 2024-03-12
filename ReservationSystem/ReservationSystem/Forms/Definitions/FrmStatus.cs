using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReservationSystem.Entities;

namespace ReservationSystem.Forms.Definitions
{
    public partial class FrmStatus : Form
    {
        public FrmStatus()
        {
            InitializeComponent();
        }

        HotelDbEntities db = new HotelDbEntities();

        private void FrmStatus_Load(object sender, EventArgs e)
        {
            grdStatus.DataSource = db.Statuses.ToList();
        }
    }
}
