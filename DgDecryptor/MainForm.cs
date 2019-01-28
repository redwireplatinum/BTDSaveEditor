using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using Newtonsoft.Json.Linq;

namespace DgDecryptor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void select_path_Click(object sender, EventArgs e)
        {
            OpenFileDialog open_dialog = new OpenFileDialog();
            open_dialog.Title = "Browse";
            if (open_dialog.ShowDialog() != DialogResult.OK) return;

            if(open_dialog.CheckFileExists) pathBox.Text = open_dialog.FileName;

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AboutBox box = new AboutBox();
            box.Show();
        }

        private void encrypt_Click(object sender, EventArgs e)
        {


            if (pathBox.Text.Length < 1)
            {
                feedback.ForeColor = Color.Red;
                feedback.Text = "Error: Enter A Path";
                return;
            }

            FileInfo f = new FileInfo(pathBox.Text);

            if (!f.Exists)
            {
                feedback.ForeColor = Color.Red;
                feedback.Text = "Error: File Not Found";
                return;
            }

            SaveFileDialog save_dialog = new SaveFileDialog();
            save_dialog.Title = "Save";

            if (save_dialog.ShowDialog() != DialogResult.OK) return;

            byte[] encoded_bytes = File.ReadAllBytes(f.FullName);
            string encoded_str = Encoding.ASCII.GetString(encoded_bytes);



            JObject decoded = JObject.Parse(encoded_str);

            if (decoded == null) {
                feedback.ForeColor = Color.Red;
                feedback.Text = "Error: File does not contain JSON";
                return;
            }
            

            if (flag_bypass.Checked)
            {
                bool didBypass = false;
                int bypasses = 0;

                if (decoded["HigherVersionProfile"] != null && ((string)decoded["HigherVersionProfile"]).Length > 0)
                {
                    JObject HigherVersionProfile = JObject.Parse(decoded["HigherVersionProfile"] + "");

                    foreach (JProperty hvProp in HigherVersionProfile.Properties())
                    {
                        if (decoded[hvProp.Name] != null)
                        {
                            HigherVersionProfile[hvProp.Name] = decoded[hvProp.Name];
                        }
                    }

                    bypasses++;

                }

                if (decoded["DetectedHacks"] != null)
                {
                    decoded["DetectedHacks"] = 0;
                    bypasses++;

                }
                if (decoded["DateTime"] != null)
                {
                    decoded["DateTime"] = DateTimeOffset.UtcNow.ToUnixTimeSeconds();

                    bypasses++;
                }

                flag_bypass.Text = "Battles Bypass [" + bypasses + "/3]";
            }
            
            byte[] encoded = DgUtil.nk_encrypt(decoded);

            if (encoded == null)
            {
                feedback.ForeColor = Color.Red;
                feedback.Text = "Error: Not a valid file";
                return;
            }

            File.WriteAllBytes(save_dialog.FileName, encoded);

            feedback.ForeColor = Color.Green;
            feedback.Text = "Success: Saved File";
        }

        private void decrypt_Click(object sender, EventArgs e)
        {

            if (pathBox.Text.Length < 1)
            {
                feedback.ForeColor = Color.Red;
                feedback.Text = "Error: Enter A Path";
                return;
            }

            FileInfo f = new FileInfo(pathBox.Text);

            if (!f.Exists)
            {
                feedback.ForeColor = Color.Red;
                feedback.Text = "Error: File Not Found";
                return;
            }

            SaveFileDialog save_dialog = new SaveFileDialog();
            save_dialog.Title = "Save";

            if (save_dialog.ShowDialog() != DialogResult.OK) return;

            byte[] encoded = File.ReadAllBytes(f.FullName);

            JObject decoded = DgUtil.nk_decrypt(encoded);

            if (decoded == null)
            {
                feedback.ForeColor = Color.Red;
                feedback.Text = "Error: Not a valid file";
                return;
            }

            byte[] newBytes = Encoding.ASCII.GetBytes(decoded.ToString());

            File.WriteAllBytes(save_dialog.FileName, newBytes);

            feedback.ForeColor = Color.Green;
            feedback.Text = "Success: Saved File";
        }

        private void flag_bypass_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void hvp_bypass_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Move;
        }

        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            pathBox.Text = files[0];

        }
    }
}
