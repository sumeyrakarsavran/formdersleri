using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form_Dersleri_1
{
    public partial class frm2 : Form
    {
        public frm2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm3 fr3 = new frm3();
            fr3.Show();
            this.Close();

        }
    }
}
