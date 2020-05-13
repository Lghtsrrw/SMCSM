using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SMCSM
{
    public partial class AddStockIn : Form
    {
        public AddStockIn()
        {
            InitializeComponent();
        }
        #region Dev's Method

        #endregion
        private void AddStockIn_Load(object sender, EventArgs e)
        {
            lblStockDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }
    }
}
