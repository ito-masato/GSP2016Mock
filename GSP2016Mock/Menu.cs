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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Button1の背景画像を設定
            //button1.BackgroundImage = Image.FromFile("C:\\Users\\ito_ma\\Documents\\Visual Studio 2012\\Projects\\GSP2016Mock\\insatsu.jpg");
            //Button1のPaintイベントハンドラを追加
            //button1.Paint += new PaintEventHandler(button1_Paint);

            
        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {
            Button btn = (Button)sender;
            //ボタンの背景画像をボタンの大きさに合わせて描画
            e.Graphics.DrawImage(btn.BackgroundImage, btn.ClientRectangle);

            //ボタンのTextを描画する準備
            StringFormat sf = new StringFormat();
            //文字列を真ん中に描画
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;
            //&がアンダーラインになるようにする
            sf.HotkeyPrefix = System.Drawing.Text.HotkeyPrefix.Show;
            //Brushの作成
            Brush brsh = new SolidBrush(btn.ForeColor);
            //文字列を描画
            e.Graphics.DrawString(btn.Text, btn.Font, brsh, btn.ClientRectangle, sf);
            brsh.Dispose();
        }

        /// <summary>
        /// 印刷タイプ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            // 写真フラグOFF
            //global::GSP2016Mock.Properties.Settings.Default.Photo_flg = false;

            try
            {
                // 砂時計を表示する  
                Cursor.Current = Cursors.WaitCursor;  

                Form f = new OrderInfo();
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
        /// 写真タイプ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            //メッセージボックスを表示する
            /*MessageBox.Show("写真タイプの作成画面へ\r\n作成中",
                "ダミー",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            */

            // 写真フラグON
            //global::GSP2016Mock.Properties.Settings.Default.Photo_flg = true;

            try
            {
                // 砂時計を表示する  
                Cursor.Current = Cursors.WaitCursor;

                Form f = new OrderInfo();
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
        /// 既製はがき
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            //メッセージボックスを表示する
            MessageBox.Show("既製はがきアプリを起動",
                "ダミー",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        /// <summary>
        /// 注文一覧画面を表示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            //メッセージボックスを表示する
            MessageBox.Show("注文一覧画面を表示",
                "ダミー",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        /// <summary>
        /// その他メニュー
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                // 砂時計を表示する  
                Cursor.Current = Cursors.WaitCursor;

                Form f = new OtherMenu();
                f.Show();
                this.Visible = false;
            }
            finally
            {
                // 元に戻す  
                Cursor.Current = Cursors.Default;
            }
        }


        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            // ×で閉じてもプロセスが残ってしまうときがあるので強制終了
            System.Environment.Exit(0);
        }


    }
}
