using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
namespace FormatDrives
{
    public partial class Form1 : Form
    {
        [DllImport("shell32.dll")]
        static extern uint SHFormatDrive(IntPtr hwnd, uint drive, uint fmtID, uint options);
        uint selectedDrive;
        DriveInfo[] allDrives = DriveInfo.GetDrives();
        public Form1()
        {
            InitializeComponent();
            foreach(DriveInfo d in allDrives)
            {
                string fullName = d.Name;
                DrivesBox.Items.Add(fullName.Substring(0, 2));
            }
            DriveSizeBox.Enabled = false;
            DriveFormatBox.Enabled = false;
            FormatDriveButton.Enabled = false;
        }
        private void DrivesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedDrive = Convert.ToUInt32(DrivesBox.SelectedItem.ToString()[0] - 'A');
            if (allDrives[DrivesBox.SelectedIndex].IsReady) {
                DriveSizeBox.Enabled = true;
                double size = Math.Truncate(100 * allDrives[DrivesBox.SelectedIndex].TotalSize / 1024.0 / 1024.0 / 1024.0) / 100;
                DriveSizeBox.Text = Convert.ToString(size) + " ГБ";
                DriveSizeBox.Enabled = false;
                DriveFormatBox.Enabled = true;
                DriveFormatBox.Text = allDrives[DrivesBox.SelectedIndex].DriveFormat;
                DriveFormatBox.Enabled = false;
                FormatDriveButton.Enabled = true;
            }
            else
            {
                MessageBox.Show("It is Not ready");
            }
        }

        private void FormatDriveButton_Click(object sender, EventArgs e)
        {
            
            DialogResult dialog = MessageBox.Show("Are You Sure?\n AllFiles will be deleted from this Drive.");
            if(dialog == DialogResult.OK)
            {
                SHFormatDrive(this.Handle, selectedDrive, 0, 0);
            }
            else
            {
                FormatDriveButton.Enabled = false;
            }
        }
    }
}
