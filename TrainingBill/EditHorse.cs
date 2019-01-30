using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainingBill
{
    public partial class EditHorse : Form
    {
        Horse horse;
        Database db= new Database();
        MonthlyRollup parent;
        public EditHorse(MonthlyRollup _parent)
        {
            InitializeComponent();
            horse = new Horse();
            parent = _parent;
        }
        public EditHorse(Horse _horse, MonthlyRollup _parent)
        {
            InitializeComponent();
            horse = _horse;
            parent = _parent;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            

        }

        private void EditHorse_Load(object sender, EventArgs e)
        {
            cbHorse.DataSource =db.getHorses();
            cbOwner.DataSource = db.getOwners();
            if (horse.Name == null || horse.Owner == null)
            {
                cbHorse.Text = "";
                cbOwner.Text = "";
            }
            else
            {
                cbHorse.Text = horse.Name;
                cbOwner.Text = horse.Owner;
            }
            }
    }
}
