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
    public partial class CustInfo : Form
    {
        public CustInfo()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CustInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            // TOP画面表示
            Form f = new Menu();
            f.Show();
        }

        private void CustInfo_Load(object sender, EventArgs e)
        {
            // コンボボックスの初期値
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
            comboBox5.SelectedIndex = 0;
            comboBox6.SelectedIndex = 0;
            comboBox7.SelectedIndex = 0;
            comboBox8.SelectedIndex = 0;

            // 姓名(カナ)
            label1.Text = global::GSP2016Mock.Properties.Settings.Default.CUST_SEI_KANA;
            label2.Text = global::GSP2016Mock.Properties.Settings.Default.CUST_MEI_KANA;

            // 昨年注文番号が入っていれば差出人情報を補完
            if(global::GSP2016Mock.Properties.Settings.Default.LastOrderNum != ""){
                tbPOST.Text = "1046027";

                tbADD11.Text = "東京都中央区晴海一丁目8番10号";
                tbADD12.Text = "晴海アイランド トリトンスクエア オフィスタワーＸ棟27階";

                tbSEI1.Text = "守山";
                tbMEI1.Text = "幸市";
                tbMEI2.Text = "智美";
                tbMEI3.Text = "裕太";
                tbMEI4.Text = "花子";

                tbTEL11.Text = "03";
                tbTEL12.Text = "1234";
                tbTEL13.Text = "5678";

                tbMAIL1.Text = "hogehoge@plazacreate.co.jp";
                    
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // TOP画面表示
            Form f = new Menu();
            f.Show();
        }

        /// <summary>
        /// 戻る
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button7_Click(object sender, EventArgs e)
        {
            if (global::GSP2016Mock.Properties.Settings.Default.Photo_flg)
            {
                // 戻る
                this.Visible = false;
                if (global::GSP2016Mock.Properties.Settings.Default.image_edit_flg)
                {
                    Form f = new PhotoLocate2();
                    f.Show();
                }
                else {
                    Form f = new PhotoLocate1();
                    f.Show();
                }
            }
            else
            {
                // 戻る
                this.Visible = false;
                Form f = new OrderInfo();
                f.Show();
            }
        }

        /// <summary>
        /// 次へ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                // 砂時計を表示する  
                Cursor.Current = Cursors.WaitCursor;

                Form f = new SctCmt();
                f.Show();
                this.Visible = false;
            }
            finally
            {
                // 元に戻す  
                Cursor.Current = Cursors.Default;
            }
        }

        /// <summary>
        /// 全てクリア
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button8_Click(object sender, EventArgs e)
        {
            tbPOST.Text = "";

            tbADD11.Text = "";
            tbADD12.Text = "";

            tbSEI1.Text = "";
            tbMEI1.Text = "";
            tbMEI2.Text = "";
            tbMEI3.Text = "";
            tbMEI4.Text = "";
            tbMEI5.Text = "";

            tbAGE1.Text = "";
            tbAGE2.Text = "";
            tbAGE3.Text = "";
            tbAGE4.Text = "";
            tbAGE5.Text = "";

            tbTEL11.Text = "";
            tbTEL12.Text = "";
            tbTEL13.Text = "";

            tbMAIL1.Text = "";
            tbMAIL2.Text = "";
        }

        /// <summary>
        /// 郵便番号検索(ダミー)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            tbADD11.Text = "東京都中央区晴海一丁目8番10号";
            tbADD12.Text = "晴海アイランド トリトンスクエア オフィスタワーＸ棟27階";
            tbADD13.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //メッセージボックスを表示する
            MessageBox.Show("名前6以降を展開",
                "ダミー",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //メッセージボックスを表示する
            MessageBox.Show("TELを展開",
                "ダミー",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //メッセージボックスを表示する
            MessageBox.Show("住所2を展開",
                "ダミー",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
