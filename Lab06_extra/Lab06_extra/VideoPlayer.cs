﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab06_extra {
    public partial class VideoPlayer : Form {
        public VideoPlayer() {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e) {
            String s = "Hôm nay là ngày " +
            DateTime.Now.ToString("dd/MM/yyyy");
            s = s + " - Bây giờ là " +
            DateTime.Now.ToString("hh:mm:ss tt");
            toolStripStatusLabel1.Text = s;
            this.Text = this.Text.Substring(1, this.Text.Length - 1) +
            this.Text.Substring(0, 1);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e) {
            //Tạo hộp thoại mở file
            OpenFileDialog dlg = new OpenFileDialog();
            //lọc hiện thị các loại file
            dlg.Filter = "All files | *.*| AVI file| *.avi | MPEG File | *.mpeg | Wav File | *.Wav | Midi File | *.midi | Mp4 File | *.mp4";
            //hien thi openDialog
            if (dlg.ShowDialog() == DialogResult.OK)
                axWindowsMediaPlayer1.URL = dlg.FileName; //Lấy tên file cần mở
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
