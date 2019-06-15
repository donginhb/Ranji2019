﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using ViewConfig;

namespace YinRan2020
{
    public partial class QiLiuGang : UserControl
    {
        public string JiGang_Name = "";
        public QiLiuGang()
        {
            InitializeComponent();
            init_view();
        }
        public void Set_Title(string name)
        {
            label_mengcheng.Text = name;
            JiGang_Name = name;
        }

        private void QiLiuGang_Resize(object sender, EventArgs e)
        {
            init_view();


        }

        private void init_view()
        {
            ViewCaoZuo.Object_Position(0.01, 0.01, 0.5, 0.5, pictureBox1, this.Controls);

            ViewCaoZuo.Object_Position(0.53, 0.01, 0.4, 0.1, label1, this.Controls);        // 机缸标题

            ViewCaoZuo.Object_Position(0.53, 0.13, 0.45, 0.12, label_mengcheng, this.Controls);  // 机缸名称
        }
    }
}
