﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewConfig;

namespace YinRan2020
{
    public partial class YiLiuGang_Item : UserControl
    {
        
        public string JiGang_Name = "";
        public YiLiuGang_Item()
        {
            InitializeComponent();
            init_view();
        }

        public void Set_Title(string name)
        {
            label_mengcheng.Text = name;
            JiGang_Name = name;
            
            // 显示标签的名字,必须设置!
            myLabel_wendu.Device_Name = name;     // 温度标签
            myLabel_div10_shuiwei.Device_Name = name;  // 水位显示
            myLabel_time_gongyi.Device_Name = name;    // 运行时时间显示
            myLabel_time_zong.Device_Name = name;      // 总时长显示

            myLabel_Red_Yellow_start.Device_Name = name;      // 启动显示 
        }

        private void label_mengcheng_Click(object sender, EventArgs e)
        {

        }

        private void init_view()
        {
            // 模拟量
            ViewCaoZuo.Object_Position(0.01, 0.01, 0.5, 0.5, pictureBox1, this.Controls);   // 机缸图片

            ViewCaoZuo.Object_Position(0.53, 0.01, 0.4, 0.1, label1, this.Controls);        // 机缸标题

            ViewCaoZuo.Object_Position(0.53, 0.13, 0.45, 0.12, label_mengcheng, this.Controls);  // 机缸名称

            ViewCaoZuo.Object_Position(0.01, 0.53, 0.3, 0.12, label_wendu, this.Controls);  // 温度标签

            ViewCaoZuo.Object_Position(0.3, 0.53, 0.3, 0.12, myLabel_wendu, this.Controls); // 温度显示

            ViewCaoZuo.Object_Position(0.01, 0.65, 0.3, 0.12, label_jigangshuiwei, this.Controls); // 水位标签

            ViewCaoZuo.Object_Position(0.3, 0.65, 0.3, 0.12, myLabel_div10_shuiwei, this.Controls);// 水位显示

            ViewCaoZuo.Object_Position(0.01, 0.77, 0.3, 0.12, label_duanshi, this.Controls);       // 工艺时长标签

            ViewCaoZuo.Object_Position(0.3, 0.77, 0.3, 0.12, myLabel_time_gongyi, this.Controls);  // 工艺运行时长显示

            ViewCaoZuo.Object_Position(0.01, 0.89, 0.3, 0.12, label_zongyunxingshijian, this.Controls);  // 总时长标签

            ViewCaoZuo.Object_Position(0.3, 0.89, 0.3, 0.12, myLabel_time_zong, this.Controls);          // 总时长显示

            // 开关量
            ViewCaoZuo.Object_Position(0.6, 0.3, 0.1, 0.1, myLabel_Red_Yellow_start, this.Controls);     //启动
        }

        private void YiLiuGang_Item_Resize(object sender, EventArgs e)
        {
            init_view();
        }
    }
}
