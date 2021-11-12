using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;

namespace invoiceLottery
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        private void Form1_Load(object sender, EventArgs e)
        {
            //comboBox加入可選擇的年份及月份
            string[] years = { "109", "110", "111" };
            string[] months = { "01~02", "03~04", "05~06", "07~08", "09~10", "11~12" };
            foreach (string year in years)
                yearComboBox.Items.Add(year);
            foreach (string month in months)
                monthComboBox.Items.Add(month);
            //讀取可用的webcam
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (filterInfoCollection != null)
            {
                foreach (FilterInfo filter in filterInfoCollection)
                    cameraComboBox.Items.Add(filter.Name);
                cameraComboBox.SelectedIndex = 0;
                cameraComboBox.Enabled = true;
                cameraStartButton.Enabled = true;
            }
            else
            {
                cameraComboBox.Text = "無視訊鏡頭";
            }
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            //將資料新增至list並顯示出來
            invoiceListBox.Items.Add(yearComboBox.Text + "年" + monthComboBox.Text + "月\n發票號碼:" + inputTextBox.Text);
            inputTextBox.Clear();
        }

        private void cameraStartButton_Click(object sender, EventArgs e)
        {
            //開始或結束偵測按鈕
            if (videoCaptureDevice == null)
            {
                videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cameraComboBox.SelectedIndex].MonikerString);
                videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
                videoCaptureDevice.Start();
                timer1.Start();
                cameraStartButton.Text = "結束偵測";
            }
            else
            {
                    videoCaptureDevice.Stop();
                    videoCaptureDevice=null;
                    timer1.Stop();
                    cameraStartButton.Text = "開始偵測";
            }

        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
           //更新畫面
            cameraPictureBox.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //離開時把相機跟timer關掉
            if (videoCaptureDevice != null)
            {
                videoCaptureDevice.Stop();
                videoCaptureDevice = null;
                timer1.Stop();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //偵測QRCode
            if (cameraPictureBox.Image != null)
            {
                BarcodeReader reader = new BarcodeReader();
                Result result = reader.Decode((Bitmap)cameraPictureBox.Image);
                if (result != null && result.ToString() != textBox1.Text)
                {
                    //把結果更新到textbox上
                    textBox1.Text = result.ToString();
                    // if (videoCaptureDevice.IsRunning)
                    //videoCaptureDevice.Stop();
                    //timer1.Stop();
                }
            }
        }
    }
}
