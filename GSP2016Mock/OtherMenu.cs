using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GSP2016Mock
{
    public partial class OtherMenu : Form
    {
        public OtherMenu()
        {
            InitializeComponent();
        }

        private void OtherMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            // TOP画面表示
            Form f = new Menu();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
