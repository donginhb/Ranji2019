﻿namespace YinRan2020
{
    partial class YiLiuGang_Item
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label_mengcheng = new System.Windows.Forms.Label();
            this.label_wendu = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.myLabel_wendu = new YinRan2020.MyLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(311, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "机缸名称";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_mengcheng
            // 
            this.label_mengcheng.BackColor = System.Drawing.Color.Blue;
            this.label_mengcheng.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_mengcheng.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_mengcheng.ForeColor = System.Drawing.SystemColors.Control;
            this.label_mengcheng.Location = new System.Drawing.Point(311, 55);
            this.label_mengcheng.Name = "label_mengcheng";
            this.label_mengcheng.Size = new System.Drawing.Size(193, 65);
            this.label_mengcheng.TabIndex = 2;
            this.label_mengcheng.Text = "机缸名称";
            this.label_mengcheng.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_mengcheng.Click += new System.EventHandler(this.label_mengcheng_Click);
            // 
            // label_wendu
            // 
            this.label_wendu.BackColor = System.Drawing.Color.Red;
            this.label_wendu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_wendu.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_wendu.Location = new System.Drawing.Point(19, 164);
            this.label_wendu.Name = "label_wendu";
            this.label_wendu.Size = new System.Drawing.Size(114, 28);
            this.label_wendu.TabIndex = 3;
            this.label_wendu.Text = "机缸温度";
            this.label_wendu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::YinRan2020.Properties.Resources.未标题_1;
            this.pictureBox1.Location = new System.Drawing.Point(19, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(274, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // myLabel_wendu
            // 
            this.myLabel_wendu.AutoSize = true;
            this.myLabel_wendu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.myLabel_wendu.Device_Name = "";
            this.myLabel_wendu.Location = new System.Drawing.Point(139, 164);
            this.myLabel_wendu.Name = "myLabel_wendu";
            this.myLabel_wendu.Size = new System.Drawing.Size(164, 32);
            this.myLabel_wendu.TabIndex = 4;
            this.myLabel_wendu.Value_Name = YinRan2020.MyLabel.value_name.机缸温度;
            // 
            // YiLiuGang_Item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.myLabel_wendu);
            this.Controls.Add(this.label_wendu);
            this.Controls.Add(this.label_mengcheng);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "YiLiuGang_Item";
            this.Size = new System.Drawing.Size(530, 300);
            this.Resize += new System.EventHandler(this.YiLiuGang_Item_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_mengcheng;
        private System.Windows.Forms.Label label_wendu;
        private MyLabel myLabel_wendu;
    }
}