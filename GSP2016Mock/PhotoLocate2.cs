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
    public partial class PhotoLocate2 : Form
    {
        public PhotoLocate2()
        {
            InitializeComponent();
        }

        private void PhotoLocate2_Load(object sender, EventArgs e)
        {
            // 姓名(カナ)
            label1.Text = global::GSP2016Mock.Properties.Settings.Default.CUST_SEI_KANA;
            label2.Text = global::GSP2016Mock.Properties.Settings.Default.CUST_MEI_KANA;

            // おしゃれ年賀の場合
            if (global::GSP2016Mock.Properties.Settings.Default.Oshare_flg)
            {
                pictureBox5.Visible = true;
            }
        }

        private void PhotoLocate2_FormClosing(object sender, FormClosingEventArgs e)
        {
            // TOP画面表示
            Form f = new Menu();
            f.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // 戻る
            this.Visible = false;
            Form f = new PhotoLocate1();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            global::GSP2016Mock.Properties.Settings.Default.image_edit_flg = true;

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

        private void btnplus_Click(object sender, EventArgs e)
        {
            //メッセージボックスを表示する
            MessageBox.Show("画像を拡大",
                "ダミー",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            //メッセージボックスを表示する
            MessageBox.Show("画像を縮小",
                "ダミー",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //メッセージボックスを表示する
            MessageBox.Show("左90度回転",
                "ダミー",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //メッセージボックスを表示する
            MessageBox.Show("右90度回転",
                "ダミー",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //メッセージボックスを表示する
            MessageBox.Show("180度回転",
                "ダミー",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

    }
}
