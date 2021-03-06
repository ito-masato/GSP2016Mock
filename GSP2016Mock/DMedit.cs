﻿using System;
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
    public partial class DMedit : Form
    {
        public DMedit()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // 戻る
            this.Visible = false;
            Form f = new LayInsatsu();
            f.Show();
        }

        private void DMedit_Load(object sender, EventArgs e)
        {
            // 姓名(カナ)
            label1.Text = global::GSP2016Mock.Properties.Settings.Default.CUST_SEI_KANA;
            label2.Text = global::GSP2016Mock.Properties.Settings.Default.CUST_MEI_KANA;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //メッセージボックスを表示する
            MessageBox.Show("注文一覧画面を表示",
                "ダミー",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // 砂時計を表示する  
                Cursor.Current = Cursors.WaitCursor;

                Form f = new Settlement();
                f.Show();
                this.Visible = false;
            }
            finally
            {
                // 元に戻す  
                Cursor.Current = Cursors.Default;
            }
        }

        private void DMedit_FormClosing(object sender, FormClosingEventArgs e)
        {
            // TOP画面表示
            Form f = new Menu();
            f.Show();
        }
    }
}
