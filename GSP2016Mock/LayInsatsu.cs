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
    public partial class LayInsatsu : Form
    {
        public LayInsatsu()
        {
            InitializeComponent();
        }

        private void LayInsatsu_Load(object sender, EventArgs e)
        {
            // 姓名(カナ)
            label1.Text = global::GSP2016Mock.Properties.Settings.Default.CUST_SEI_KANA;
            label2.Text = global::GSP2016Mock.Properties.Settings.Default.CUST_MEI_KANA;

            // 写真タイプの場合
            if (global::GSP2016Mock.Properties.Settings.Default.Photo_flg)
            {
                pictureBox3.Visible = true;

                // おしゃれ年賀の場合
                if(global::GSP2016Mock.Properties.Settings.Default.Oshare_flg)
                {
                    pictureBox4.Visible = true;
                    pictureBox3.Visible = false;
                }
            }
            

        }

        private void button7_Click(object sender, EventArgs e)
        {
            // 戻る
            this.Visible = false;
            Form f = new EditKumihan();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                // 砂時計を表示する  
                Cursor.Current = Cursors.WaitCursor;

                Form f = new DMedit();
                f.Show();
                this.Visible = false;
            }
            finally
            {
                // 元に戻す  
                Cursor.Current = Cursors.Default;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }
    }
}
