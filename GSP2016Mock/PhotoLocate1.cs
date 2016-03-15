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
    public partial class PhotoLocate1 : Form
    {
        public PhotoLocate1()
        {
            InitializeComponent();
        }

        private void PhotoLocate1_Load(object sender, EventArgs e)
        {
            // 姓名(カナ)
            label1.Text = global::GSP2016Mock.Properties.Settings.Default.CUST_SEI_KANA;
            label2.Text = global::GSP2016Mock.Properties.Settings.Default.CUST_MEI_KANA;

            // ハピネスの場合
            if (global::GSP2016Mock.Properties.Settings.Default.Oshare_flg)
            {
                pictureBox4.Visible = true;
            }
        }

        private void PhotoLocate1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // TOP画面表示
            Form f = new Menu();
            f.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // 戻る
            this.Visible = false;
            Form f = new PhotoEdit();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            global::GSP2016Mock.Properties.Settings.Default.image_edit_flg = false;

            try
            {
                // 砂時計を表示する  
                Cursor.Current = Cursors.WaitCursor;

                Form f = new CustInfo();
                f.Show();
                this.Visible = false;
            }
            finally
            {
                // 元に戻す  
                Cursor.Current = Cursors.Default;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // 砂時計を表示する  
                Cursor.Current = Cursors.WaitCursor;

                Form f = new PhotoLocate2();
                f.Show();
                this.Visible = false;
            }
            finally
            {
                // 元に戻す  
                Cursor.Current = Cursors.Default;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {

            if (global::GSP2016Mock.Properties.Settings.Default.Oshare_flg)
            {
                pictureBox5.Visible = true;
                pictureBox4.Visible = false;
            }
            else
            {
                pictureBox3.Visible = true;
            }
            button1.Visible = true;
            button5.Enabled = true;

        }


    }
}
