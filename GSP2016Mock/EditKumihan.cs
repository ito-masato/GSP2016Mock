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
    public partial class EditKumihan : Form
    {
        public EditKumihan()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // 戻る
            this.Visible = false;
            Form f = new SctCmt();
            f.Show();
        }

        /// <summary>
        /// 次へ or OKボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == "次へ")
            {
                try
                {
                    // 砂時計を表示する  
                    Cursor.Current = Cursors.WaitCursor;

                    Form f = new LayInsatsu();
                    f.Show();
                    this.Visible = false;
                }
                finally
                {
                    // 元に戻す  
                    Cursor.Current = Cursors.Default;
                }
            }
            else if (button5.Text == "OK")
            {
                // ボタンを出す
                button1.Visible = true;
                button2.Visible = true;
                comboBox1.Visible = true;
                pictureBox1.Visible = true;

                // 編集画面を消す
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                button3.Visible = false;

                // おしゃれ年賀の場合
                if (global::GSP2016Mock.Properties.Settings.Default.Oshare_flg)
                {
                    pictureBox5.Visible = true;
                    pictureBox6.Visible = false;
                }

                // OK→次へ
                button5.Text = "次へ";
   
            }
        }

        private void EditKumihan_Load(object sender, EventArgs e)
        {
            // 姓名(カナ)
            label1.Text = global::GSP2016Mock.Properties.Settings.Default.CUST_SEI_KANA;
            label2.Text = global::GSP2016Mock.Properties.Settings.Default.CUST_MEI_KANA;

            // おしゃれ年賀の場合
            if (global::GSP2016Mock.Properties.Settings.Default.Oshare_flg)
            {
                pictureBox5.Visible = true;
                comboBox1.SelectedIndex = 2;
            }
            else
            {
                // コンボボックス初期値
                comboBox1.SelectedIndex = 0;
            }
        }

        private void EditKumihan_FormClosing(object sender, FormClosingEventArgs e)
        {
            // TOP画面表示
            Form f = new Menu();
            f.Show();
        }

        /// <summary>
        /// 編集ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            // おしゃれ年賀の場合
            if(global::GSP2016Mock.Properties.Settings.Default.Oshare_flg){
                pictureBox6.Visible = true;
                pictureBox5.Visible = false;
            }

            // 不要ボタンを消す
            button1.Visible = false;
            button2.Visible = false;
            comboBox1.Visible = false;
            pictureBox1.Visible = false;
            pictureBox4.Visible = false;

            // 編集画面を出す
            pictureBox3.Visible = true;
            button3.Visible = true;

            // 次へ→OK
            if (button5.Text == "次へ")
            {
                button5.Text = "OK";
            }
        }

        /// <summary>
        /// 右揃えボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            // 編集結果の表示
            pictureBox4.Visible = true;

            //メッセージボックスを表示する
            MessageBox.Show("選択要素の位置関係を保持したまま揃える",
                "ダミー",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
