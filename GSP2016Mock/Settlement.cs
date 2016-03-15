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
    public partial class Settlement : Form
    {
        public Settlement()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // 戻る
            this.Visible = false;
            Form f = new DMedit();
            f.Show();
        }

        /// <summary>
        /// A4チェックシート印刷
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //メッセージボックスを表示する
            MessageBox.Show("旧「校正チェックシート印刷」と同等",
                "ダミー",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        /// <summary>
        /// 試し刷り
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            //メッセージボックスを表示する
            MessageBox.Show("旧「試し刷り」と同等",
                "ダミー",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        /// <summary>
        /// 注文内容確定・送信
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            //メッセージボックスを表示する
            DialogResult result = MessageBox.Show("自店仕上げの場合、注文内容を確定します。\r\nセンター仕上げの場合、データを送信します。\r\n宜しいですか？",
                "注文内容確定・送信",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);
        
            //何が選択されたか調べる
            if (result == DialogResult.OK)
            {
                // はがき印刷ボタンを有効
                button6.Enabled = true;
            }
            else if (result == DialogResult.Cancel)
            {
                //「キャンセル」が選択された時
                Console.WriteLine("「キャンセル」が選択されました");
            }

        }

        /// <summary>
        /// 完了
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            // フラグを初期化
            global::GSP2016Mock.Properties.Settings.Default.Photo_flg = false;
            global::GSP2016Mock.Properties.Settings.Default.Oshare_flg = false;

            // TOP画面表示
            this.Visible = false;
            Form f = new Menu();
            f.Show();
        }

        /// <summary>
        /// はがき印刷
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            //メッセージボックスを表示する
            MessageBox.Show("はがき印刷ダイアログを表示",
                "ダミー",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void Settlement_FormClosing(object sender, FormClosingEventArgs e)
        {
            // TOP画面表示
            Form f = new Menu();
            f.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //メッセージボックスを表示する
            DialogResult result = MessageBox.Show("キャンセル処理をしますが宜しいですか？",
                "キャンセル",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question);

            //何が選択されたか調べる
            if (result == DialogResult.Yes)
            {
                // はがき印刷ボタンを有効
                this.Close();
            }
            else if (result == DialogResult.Cancel)
            {
                //「キャンセル」が選択された時
                Console.WriteLine("「キャンセル」が選択されました");
            }
        }
        
        /// <summary>
        /// QRコード印刷
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            //メッセージボックスを表示する
            MessageBox.Show("QRコード印刷ダイアログを表示",
                "ダミー",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void Settlement_Load(object sender, EventArgs e)
        {
            // 姓名(カナ)
            label1.Text = global::GSP2016Mock.Properties.Settings.Default.CUST_SEI_KANA;
            label2.Text = global::GSP2016Mock.Properties.Settings.Default.CUST_MEI_KANA;

            // 写真タイプか印刷タイプかで表示を分ける
            if (global::GSP2016Mock.Properties.Settings.Default.Photo_flg)
            {
                if (global::GSP2016Mock.Properties.Settings.Default.Oshare_flg)
                {
                    pictureBox4.Visible = false;
                    pictureBox5.Visible = true;
                }
                else
                {
                    pictureBox4.Visible = true;
                    pictureBox5.Visible = false;
                }
                pictureBox1.Visible = false;
            }
            else {
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox1.Visible = true;
            }
        }

    }
}
