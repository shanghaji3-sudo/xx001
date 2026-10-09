namespace 串口通信
{
    partial class 串口调试助手
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_open = new System.Windows.Forms.Button();
            this.cmb_stopbit = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_databit = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_check = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_bps = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_port = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_rev = new System.Windows.Forms.TextBox();
            this.txt_send = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_send = new System.Windows.Forms.Button();
            this.lb_message = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_close);
            this.groupBox1.Controls.Add(this.btn_open);
            this.groupBox1.Controls.Add(this.cmb_stopbit);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmb_databit);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmb_check);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmb_bps);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmb_port);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 381);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "串口设置";
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(172, 307);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(148, 43);
            this.btn_close.TabIndex = 11;
            this.btn_close.Text = "关闭串口";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(10, 307);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(148, 43);
            this.btn_open.TabIndex = 10;
            this.btn_open.Text = "打开串口";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // cmb_stopbit
            // 
            this.cmb_stopbit.FormattingEnabled = true;
            this.cmb_stopbit.Location = new System.Drawing.Point(118, 213);
            this.cmb_stopbit.Name = "cmb_stopbit";
            this.cmb_stopbit.Size = new System.Drawing.Size(174, 28);
            this.cmb_stopbit.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "停 止 位：";
            // 
            // cmb_databit
            // 
            this.cmb_databit.FormattingEnabled = true;
            this.cmb_databit.Location = new System.Drawing.Point(118, 168);
            this.cmb_databit.Name = "cmb_databit";
            this.cmb_databit.Size = new System.Drawing.Size(174, 28);
            this.cmb_databit.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "数 据 位：";
            // 
            // cmb_check
            // 
            this.cmb_check.FormattingEnabled = true;
            this.cmb_check.Location = new System.Drawing.Point(118, 123);
            this.cmb_check.Name = "cmb_check";
            this.cmb_check.Size = new System.Drawing.Size(174, 28);
            this.cmb_check.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "校验方式：";
            // 
            // cmb_bps
            // 
            this.cmb_bps.FormattingEnabled = true;
            this.cmb_bps.Location = new System.Drawing.Point(118, 79);
            this.cmb_bps.Name = "cmb_bps";
            this.cmb_bps.Size = new System.Drawing.Size(174, 28);
            this.cmb_bps.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "波 特 率：";
            // 
            // cmb_port
            // 
            this.cmb_port.FormattingEnabled = true;
            this.cmb_port.Location = new System.Drawing.Point(118, 36);
            this.cmb_port.Name = "cmb_port";
            this.cmb_port.Size = new System.Drawing.Size(174, 28);
            this.cmb_port.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "端    口：";
            // 
            // txt_rev
            // 
            this.txt_rev.Location = new System.Drawing.Point(358, 13);
            this.txt_rev.Multiline = true;
            this.txt_rev.Name = "txt_rev";
            this.txt_rev.ReadOnly = true;
            this.txt_rev.Size = new System.Drawing.Size(417, 286);
            this.txt_rev.TabIndex = 1;
            // 
            // txt_send
            // 
            this.txt_send.Location = new System.Drawing.Point(358, 305);
            this.txt_send.Multiline = true;
            this.txt_send.Name = "txt_send";
            this.txt_send.Size = new System.Drawing.Size(220, 89);
            this.txt_send.TabIndex = 2;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(585, 306);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(190, 37);
            this.btn_clear.TabIndex = 3;
            this.btn_clear.Text = "清空";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(585, 357);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(190, 37);
            this.btn_send.TabIndex = 4;
            this.btn_send.Text = "发送";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // lb_message
            // 
            this.lb_message.AutoSize = true;
            this.lb_message.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_message.Location = new System.Drawing.Point(13, 423);
            this.lb_message.Name = "lb_message";
            this.lb_message.Size = new System.Drawing.Size(109, 20);
            this.lb_message.TabIndex = 5;
            this.lb_message.Text = "串口未打开";
            // 
            // 串口调试助手
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_message);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.txt_send);
            this.Controls.Add(this.txt_rev);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "串口调试助手";
            this.Text = "串口调试助手";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.串口调试助手_FormClosing);
            this.Load += new System.EventHandler(this.串口调试助手_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_port;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_stopbit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_databit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_check;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_bps;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.TextBox txt_rev;
        private System.Windows.Forms.TextBox txt_send;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Label lb_message;
    }
}

