using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace Music
{
    public partial class Form1 : Form
    {
        int i = 1;
        public Form1()
        {
            InitializeComponent();
            lbl_Track_Time_End.Visible = false;
            lbl_Track_Time_Start.Visible = false;
            tb_Volume.Value = 50;
            lbl_volume2.Text = "%50";
            pb_Music.Visible = false;
            pb_Image.Visible = false;
           
        }

        string[] paths, files;

        private void btn_Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ofd.FileNames;
                paths = ofd.FileNames;

                for (int i = 0; i < files.Length; i++)
                {
                    lb_Track_List.Items.Add(files[i]);
                }

            }
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.stop();
            pb_Music.Value = 0;
        }

        private void btn_Pause_Click(object sender, EventArgs e)
        {
            Button a = (Button)sender;

            if (a.Text == "Duraklat")
            {
                player.Ctlcontrols.pause();
                a.Text = "Devam Et";
            }
            else
            {
                player.Ctlcontrols.play();
                a.Text = "Duraklat";
            }
        }

        private void bt_Play_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.play();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (lb_Track_List.SelectedIndex < lb_Track_List.Items.Count - 1)
            {
                lb_Track_List.SelectedIndex = lb_Track_List.SelectedIndex + 1;
            }
        }

        private void btn_Previous_Click(object sender, EventArgs e)
        {
            if (lb_Track_List.SelectedIndex > 0)
            {
                lb_Track_List.SelectedIndex = lb_Track_List.SelectedIndex - 1;
            }
        }



        private void lb_Track_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            player.URL = paths[lb_Track_List.SelectedIndex];

            player.Ctlcontrols.play();
            lbl_Track_Time_End.Visible = true;
            lbl_Track_Time_Start.Visible = true;
            pb_Music.Visible = true;
            pb_Image.Visible = true;
             
            string s = i.ToString();
            i++;
            pb_Image.Image = Image.FromFile($"C://{s}.gif");
            
            if (i > 23)
            {
                i = 1;
            }
            


        }

        private void tb_Volume_Scroll(object sender, EventArgs e)
        {
            player.settings.volume = tb_Volume.Value;
            lbl_volume2.Text = tb_Volume.Value.ToString() + "%";
        }

        private void pb_Music_MouseDown(object sender, MouseEventArgs e)
        {
            player.Ctlcontrols.currentPosition=player.currentMedia.duration*e.X / pb_Music.Width;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                pb_Music.Maximum = (int)player.Ctlcontrols.currentItem.duration;
                pb_Music.Value = (int)player.Ctlcontrols.currentPosition;
            }
            try
            {

                lbl_Track_Time_Start.Text = player.Ctlcontrols.currentPositionString;
                double dk = pb_Music.Maximum / 60;
                double saniye = pb_Music.Maximum % 60;
                if (saniye > 10)
                {
                    if (dk > 0)
                    {
                        lbl_Track_Time_End.Text = "0" + dk.ToString();
                        lbl_Track_Time_End.Text += ":" + saniye.ToString();
                    }
                    else
                    {
                        lbl_Track_Time_End.Text = "00:" + saniye.ToString();
                    }
                }

                else
                {
                    if (dk > 0)
                    {
                        lbl_Track_Time_End.Text = "0" + dk.ToString();
                        lbl_Track_Time_End.Text += ":0" + saniye.ToString();
                    }
                    else
                    {
                        lbl_Track_Time_End.Text = "00:" + saniye.ToString();
                    }
                }


            }
            catch (Exception ex)
            {
                Environment.Exit(0);
                MessageBox.Show(ex.Message);

            }
        }





    }
}
