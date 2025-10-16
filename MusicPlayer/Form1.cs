using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        Queue<string> q = new Queue<string>();
        string[] Musics = new string[1000]; //music path
        int cout; //number of songs
        string name;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                Player.URL = Musics[ListMusic.SelectedIndex];
                timer1.Start();
            }


            catch (System.IndexOutOfRangeException) {

                MessageBox.Show("Please select a song", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Multiselect = true; //mở thêm nhiều file

            if (open.ShowDialog() == DialogResult.OK) 
            {
                for (int i = 0; i < open.FileNames.LongLength; i++)
                {
                    if (ListMusic.Items.Contains(open.FileNames.GetValue(i)) == false)
                    {
                        var o = open.SafeFileNames.GetValue(i);
                        name = Convert.ToString(o);
                        q.Enqueue(name);
                        Musics[cout] = open.FileNames.GetValue(i).ToString();
                        cout += 1;
                       
                    }
                }
                ListMusic.Items.Clear();
                foreach (string id in q)
                {
                    ListMusic.Items.Add(id);
                }

                if (ListMusic.SelectedIndex < 0)
                {
                    ListMusic.SetSelected(0, true);
                }
            }          
        }

        private void Ltb_Musics_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void previousbtn_Click(object sender, EventArgs e)
        {
            if (ListMusic.SelectedIndex != 0) {

                ListMusic.SetSelected(ListMusic.SelectedIndex - 1, true);
                Player.URL = Musics[ListMusic.SelectedIndex];
            }
            else
            {
                ListMusic.SelectedIndex = ListMusic.Items.Count-1;
                Player.URL = Musics[ListMusic.SelectedIndex];
                timer1.Start();
            }
        }

        private void nextbtn_Click(object sender, EventArgs e)
        {     
            if (ListMusic.SelectedIndex != ListMusic.Items.Count - 1)
            {
                ListMusic.SetSelected(ListMusic.SelectedIndex + 1, true);
                    Player.URL = Musics[ListMusic.SelectedIndex];
                    timer1.Start();                
            }
            else 
            {
                ListMusic.SelectedIndex = 0;
                Player.URL = Musics[ListMusic.SelectedIndex];
                timer1.Start();
            }
        }

        private void startbtn_Click(object sender, EventArgs e)
        {
            ListMusic.SetSelected(0, true);
            Player.URL = Musics[ListMusic.SelectedIndex];
        }

        private void endbtn_Click(object sender, EventArgs e)
        {
            ListMusic.SetSelected(ListMusic.Items.Count - 1, true);
            Player.URL = Musics[ListMusic.SelectedIndex];
        }

        private void lblduration_Click(object sender, EventArgs e)
        {

        }

        private void Timer_Click(object sender, EventArgs e)
        {

        }

        private void lbl_duration_Click(object sender, EventArgs e)
        {

        }

        private void Player_Enter(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = Player.Ctlcontrols.currentPositionString;
            lblduration.Text = Player.currentMedia.durationString;
        }

        private void Player_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            String[] arr = q.ToArray();
            if (e.newState.Equals(WMPLib.WMPPlayState.wmppsReady))
            //tương tự if (e.newState == 8)
            {
                BeginInvoke(new Action(() =>
                {
                    try
                    {
                        ListMusic.SelectedIndex = ListMusic.SelectedIndex + 1;
                    }
                catch (System.ArgumentOutOfRangeException)
                    {
                        ListMusic.SelectedIndex = 0;
                    }
                    Player.URL = Musics[ListMusic.SelectedIndex];
                    timer1.Start();
                }));
            }
        }
    }
}
