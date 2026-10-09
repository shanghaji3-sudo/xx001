using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace 串口通信
{
    public partial class 串口调试助手 : Form
    {
        public 串口调试助手()
        {
            InitializeComponent();

            serialPort.DataReceived += SerialPort_DataReceived;
        }

        #region 初始化
        private void 串口调试助手_Load(object sender, EventArgs e)
        {
            lb_message.Text = "串口未打开";
            lb_message.ForeColor = Color.Red;

            // 串口
            string[] sport = SerialPort.GetPortNames();
            cmb_port.Items.Clear();
            cmb_port.Items.AddRange(sport);
            if (cmb_port.Items.Count > 0)
            {
                cmb_port.SelectedIndex = 0;
            }

            // 波特率
            string[] bps = { "1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200", "230400", "460800", "921600" };
            cmb_bps.Items.Clear();
            cmb_bps.Items.AddRange(bps);
            cmb_bps.SelectedItem = "9600";

            // 校验方式
            string[] check = { "None", "Odd", "Even", "Mark", "Space" };
            cmb_check.Items.Clear();
            cmb_check.Items.AddRange(check);
            cmb_check.SelectedItem = "None";

            // 数据位
            string[] databit = { "5", "6", "7", "8" };
            cmb_databit.Items.Clear();
            cmb_databit.Items.AddRange(databit);
            cmb_databit.SelectedItem = "8";

            // 停止位
            string[] stopbit = { "One", "OnePointFive", "Two" };
            cmb_stopbit.Items.Clear();
            cmb_stopbit.Items.AddRange(stopbit);
            cmb_stopbit.SelectedItem = "One";
        }
        #endregion

        SerialPort serialPort = new SerialPort();
        #region 打开串口
        private void btn_open_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort.Encoding = System.Text.Encoding.UTF8;
                serialPort.PortName = cmb_port.Text;
                serialPort.BaudRate = int.Parse(cmb_bps.Text);
                serialPort.Parity = (Parity)Enum.Parse(typeof(Parity), cmb_check.Text);
                serialPort.DataBits = int.Parse(cmb_databit.Text);
                serialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cmb_stopbit.Text);
                serialPort.Open();
                if (serialPort.IsOpen)
                {
                    lb_message.Text = "串口已打开";
                    lb_message.ForeColor = Color.Green;
                }
                btn_open.Enabled = false;
                cmb_port.Enabled = false;
                cmb_bps.Enabled = false;
                cmb_check.Enabled = false;
                cmb_databit.Enabled = false;
                cmb_stopbit.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("打开串口失败："+ex.Message);
            }
        }

        #endregion

        #region 关闭串口
        private void btn_close_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
                lb_message.Text = "串口未打开";
                lb_message.ForeColor = Color.Red;
                btn_open.Enabled = true; 
                cmb_port.Enabled = true;
                cmb_bps.Enabled = true;
                cmb_check.Enabled = true;
                cmb_databit.Enabled = true;
                cmb_stopbit.Enabled = true;
            }
        }
        #endregion


        #region 接收数据
        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data = serialPort.ReadExisting();

            this.Invoke(new Action(() =>
            {
                txt_rev.AppendText(data);
                txt_rev.SelectionStart = txt_rev.TextLength; txt_rev.ScrollToCaret();
            }));
        }
        #endregion

        #region 发送数据
        private void btn_send_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Write(txt_send.Text);
            }
            else
            {
                MessageBox.Show("请先打开串口");
            }
        }


        #endregion

        #region 清空
        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_rev.Text=string.Empty;
        }
        #endregion

        private void 串口调试助手_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort.IsOpen)
            { 
                serialPort.Close(); 
            }

        }
    }
}
