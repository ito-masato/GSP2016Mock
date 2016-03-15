using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CMyGroupBox;

namespace GSP2016Mock
{
    public partial class OrderInfo : Form
    {
        public OrderInfo()
        {
            InitializeComponent();
        }

        private void Insatsu1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // TOP画面表示
            Form f = new Menu();
            f.Show();
        }

        private void Insatsu1_Load(object sender, EventArgs e)
        {
            // 写真タイプのときはボタン表記変更
            if (global::GSP2016Mock.Properties.Settings.Default.Photo_flg)
            {
                button1.Text = "登録→画像選択へ";
            }
            else
            {
                button1.Text = "登録→差出人入力";
            }
        }

        private void Insatsu1_Paint(object sender, PaintEventArgs e)
        {            
            //Penオブジェクトの作成(幅5の黒色)
            Pen AquaPen = new Pen(Color.DeepSkyBlue, 5);
            
            Graphics tbxRect = e.Graphics;

            // 袋番号、昨年番号、クーポンコード
            tbxRect.DrawRectangle(AquaPen, 250, 7, 100, 31);
            tbxRect.DrawRectangle(AquaPen, 460, 7, 200, 31);
            tbxRect.DrawRectangle(AquaPen, 460, 50, 200, 31);

            // お客様姓名、電話番号
            tbxRect.DrawRectangle(AquaPen, 62, 127, 147, 31);
            tbxRect.DrawRectangle(AquaPen, 215, 127, 147, 31);
            tbxRect.DrawRectangle(AquaPen, 487, 127, 347, 31);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.TextLength == 7)
            {
                label5.Text = "○○円引きクーポン";
                label5.Visible = true;
            }
            else
            {
                label5.Visible = false;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

            if (textBox7.TextLength == 5)
            {

                if (textBox7.Text.IndexOf("jp") == 0 || textBox7.Text.IndexOf("sh") == 0)
                {
                    global::GSP2016Mock.Properties.Settings.Default.Photo_flg = true;
                }
                else
                {
                    global::GSP2016Mock.Properties.Settings.Default.Photo_flg = false;
                }

                // 写真タイプの場合
                if (global::GSP2016Mock.Properties.Settings.Default.Photo_flg)
                {
                    if (textBox7.Text.IndexOf("sh") == 0)
                    {
                        pictureBox7.Visible = true;
                        global::GSP2016Mock.Properties.Settings.Default.Oshare_flg = true;
                    }
                    else
                    {
                        pictureBox6.Visible = true;
                    }
                }
                // 印刷タイプの場合
                else
                {
                    pictureBox4.Visible = true;
                }

            }
            else
            {
                pictureBox4.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
            }
        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
            if (textBox7.TextLength == 5)
            {
                comboBox1.SelectedIndex = 0;
                comboBox2.SelectedIndex = 0;
            }
            else
            {
                //メッセージボックスを表示する
                MessageBox.Show("タイプ番号を入力してください。",
                    "タイプ番号",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.TextLength > 0)
            {
                global::GSP2016Mock.Properties.Settings.Default.LastOrderNum = textBox2.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 印刷タイプなら差出人情報入力へ
            if (global::GSP2016Mock.Properties.Settings.Default.Photo_flg == false)
            {
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
            // 写真タイプなら画像選択画面へ
            else
            {
                try
                {
                    // 砂時計を表示する  
                    Cursor.Current = Cursors.WaitCursor;

                    Form f = new PhotoSelect();
                    f.Show();
                    this.Visible = false;
                }
                finally
                {
                    // 元に戻す  
                    Cursor.Current = Cursors.Default;
                }
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            global::GSP2016Mock.Properties.Settings.Default.CUST_SEI_KANA = textBox4.Text;
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            global::GSP2016Mock.Properties.Settings.Default.CUST_MEI_KANA = textBox5.Text;
        }

        /// <summary>
        /// QRコード印刷
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            //メッセージボックスを表示する
            MessageBox.Show("QRコードの印刷ダイアログ表示",
                "ダミー",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            //0～9と、バックスペース以外の時は、イベントをキャンセルする
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox1.Text = "Checked!";
                var hoge = checkBox1.Checked;

            }
            else {
                checkBox1.Text = "No Checked!";
            }
        }
    }
}
