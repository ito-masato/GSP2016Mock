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
    public partial class PhotoEdit : Form
    {
        public PhotoEdit()
        {
            InitializeComponent();
        }

        private void PhotoEdit_Load(object sender, EventArgs e)
        {
            // 姓名(カナ)
            label1.Text = global::GSP2016Mock.Properties.Settings.Default.CUST_SEI_KANA;
            label2.Text = global::GSP2016Mock.Properties.Settings.Default.CUST_MEI_KANA;
        }

        private void PhotoEdit_FormClosing(object sender, FormClosingEventArgs e)
        {
            // TOP画面表示
            Form f = new Menu();
            f.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                // 砂時計を表示する  
                Cursor.Current = Cursors.WaitCursor;

                Form f = new PhotoLocate1();
                f.Show();
                this.Visible = false;
            }
            finally
            {
                // 元に戻す  
                Cursor.Current = Cursors.Default;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // 戻る
            this.Visible = false;
            Form f = new PhotoSelect();
            f.Show();
        }
    }
}
