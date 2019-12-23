﻿using System;
using System.Windows.Forms;
using Mp3Cutter.Extensibility.Dto;

namespace Mp3Cutter.WinForms.UI
{
    public partial class Form1 : Form
    {
        private const string Mp3Extension = ".mp3";
        private const string InvalidFileMessage = "Hibás típusú file!";
        private const string SuccessFileMessage = "File sikeresen megvágva!";

        private Mp3Cutter.Service.Mp3Cutter mp3Cutter;

        public Form1()
        {
            InitializeComponent();
            mp3Cutter = new Service.Mp3Cutter();
        }

        private void btnFileSelection_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtMp3FileName.Text = openFileDialog1.FileName;
            }
        }

        private void btnExecution_Click(object sender, EventArgs e)
        {
            if (!IsFileNameValid())
            {
                MessageBox.Show(InvalidFileMessage, "Hiba!!");
            }

            var mp3Input = CreateInput();

            var mp3Output = mp3Cutter.ExecuteCut(mp3Input);

            txtMp3FileName.Text = mp3Output.Mp3OutputFileName;

            MessageBox.Show(SuccessFileMessage, "Ok");
        }

        private Mp3InputDto CreateInput()
        {
            int beginHours = Int32.Parse(txtBeginHour.Text);
            int beginMinutes = Int32.Parse(txtBeginMinute.Text);
            int beginSeconds = Int32.Parse(txtBeginSecond.Text);

            int endHours = Int32.Parse(txtEndHour.Text);
            int endMinutes = Int32.Parse(txtEndMinute.Text);
            int endSeconds = Int32.Parse(txtEndSecond.Text);

            var mp3Input = new Mp3InputDto();

            mp3Input.BeginCut = beginHours * 3600 + beginMinutes * 60 + beginSeconds;
            mp3Input.EndCut = endHours * 3600 + endMinutes * 60 + endSeconds;
            mp3Input.Mp3Path = txtMp3FileName.Text;

            return mp3Input;
        }

        private bool IsFileNameValid()
        {
            return txtMp3FileName.Text.ToLower().EndsWith(Mp3Extension);
        }
    }
}