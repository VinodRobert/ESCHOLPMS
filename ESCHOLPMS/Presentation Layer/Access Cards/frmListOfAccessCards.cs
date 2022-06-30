using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 

namespace ESCHOLPMS 
{
    public partial class frmListOfAccessCards : Form
    {
        AccessCard ac = new AccessCard();
        public frmListOfAccessCards()
        {
            InitializeComponent();
        }

        private void frmListOfAccessCards_Load(object sender, EventArgs e)
        {
            int costCentreID = GlobalVariables.costCentreID;
            DataSet ds = ac.ListOfAccessCard(costCentreID);
            gridAccessCards.DataSource = ds.Tables[0];
            gridAccessCards.Refresh();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
