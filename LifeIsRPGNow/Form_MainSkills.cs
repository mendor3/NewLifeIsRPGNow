using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LifeIsRPGNow
{
    public partial class Form_MainSkills : Form
    {
        public Form_MainSkills()
        {
            InitializeComponent();
        }

        private void place_single_skillgroup(string id, Point locIcon, string iconText, Point locName, string nameText, Point locLevel, string levelText, 
            Point locBar, int barValue, int barMax, Point locPanel, string[,] taskText, int taskNumb)
        {
            PictureBox icon = new PictureBox();
            Label name = new Label();
            Label level = new Label();
            ProgressBar levelBar = new ProgressBar();
            Panel panel = new Panel();

            Label taskName = new Label();
            Label taskStat1 = new Label();
            Label taskStat2 = new Label();  
            Label taskStat3 = new Label();
            Button taskBtn = new Button();


            icon.SizeMode = PictureBoxSizeMode.StretchImage;
            icon.BorderStyle = BorderStyle.FixedSingle;
            icon.Location = locIcon; //40; 20
            icon.Name = "lbl_icon" + id;
            icon.Size = new System.Drawing.Size(220, 220);
            icon.TabIndex = 0;
            icon.ImageLocation = iconText;

            icon.Enabled = true;
            icon.Visible = true;

            this.Controls.Add(icon);
            icon.Select();
            icon.Show();


            name.AutoSize = true;
            name.Location = locName; //40; 240
            name.Name = "lbl_name" + id;
            name.TabIndex = 0;
            name.Font = new Font("Microsoft Sans Serif", 20, FontStyle.Bold);
            name.Text = nameText;

            name.Enabled = true;
            name.Visible = true;

            this.Controls.Add(name);
            name.Select();
            name.Show();



            level.AutoSize = true;
            level.Location = locLevel; //80; 150
            level.Name = "lbl_level" + id;
            level.TabIndex = 0;
            level.Font = new Font("Microsoft Sans Serif", 40, FontStyle.Bold);
            level.Text = levelText;

            level.Enabled = true;
            level.Visible = true;

            this.Controls.Add(level);
            level.BringToFront();
            level.Select();
            level.Show();



            levelBar.Location = locBar; //30; 210
            levelBar.Name = "prgsbar_" + id;
            levelBar.Size = new System.Drawing.Size(200, 25);
            levelBar.TabIndex = 0;
            levelBar.Maximum = barMax;
            levelBar.Value = barValue;

            levelBar.Enabled = true;
            levelBar.Visible = true;

            this.Controls.Add(levelBar);
            levelBar.BringToFront();
            levelBar.Select();
            levelBar.Show();



            for(int i = 0; i < taskNumb; i++)
            {
                taskName.AutoSize = true;
                taskName.Location = new Point(5, 15); //5 ; 15
                taskName.Name = "lbl_taskname_" + id;
                taskName.TabIndex = 0;
                taskName.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                taskName.Text = taskText[i,0];
                taskName.MaximumSize = new Size(200, 50);

                taskName.Enabled = true;
                taskName.Visible = true;
                panel.Controls.Add(taskName);



                taskStat1.AutoSize = true;
                taskStat1.Location = new Point(5, 65); //15 ; 65
                taskStat1.Name = "lbl_taskstat1_" + id;
                taskStat1.TabIndex = 0;
                taskStat1.Font = new Font("Microsoft Sans Serif", 10);
                taskStat1.Text = taskText[i, 1];
                taskStat1.ForeColor = Color.Green;

                taskStat1.Enabled = true;
                taskStat1.Visible = true;
                panel.Controls.Add(taskStat1);


                taskStat2.AutoSize = true;
                taskStat2.Location = new Point(60, 65); //90 ; 65
                taskStat2.Name = "lbl_taskstat2_" + id;
                taskStat2.TabIndex = 0;
                taskStat2.Font = new Font("Microsoft Sans Serif", 10);
                taskStat2.Text = taskText[i, 2];
                taskStat2.ForeColor = Color.Blue;

                taskStat2.Enabled = true;
                taskStat2.Visible = true;
                panel.Controls.Add(taskStat2);


                taskStat3.AutoSize = true;
                taskStat3.Location = new Point(115, 65); //165 ; 65
                taskStat3.Name = "lbl_taskstat3_" + id;
                taskStat3.TabIndex = 0;
                taskStat3.Font = new Font("Microsoft Sans Serif", 10);
                taskStat3.Text = taskText[i, 3];
                taskStat3.ForeColor = Color.Red;

                taskStat3.Enabled = true;
                taskStat3.Visible = true;
                panel.Controls.Add(taskStat3);


                taskBtn.Location = new Point(200, 35);
                taskBtn.Name = "btn_task_" + id;
                taskBtn.TabIndex = 0;
                taskBtn.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
                taskBtn.Text = "Done";
                taskBtn.Size = new Size(75, 35);

                taskBtn.Enabled = true;
                taskBtn.Visible = true;
                panel.Controls.Add(taskBtn);


            }



            panel.Location = locPanel; //10; 280
            panel.Name = "panel_" + id;
            panel.Size = new System.Drawing.Size(280, 380);
            panel.TabIndex = 0;
            panel.BorderStyle = BorderStyle.FixedSingle;

            panel.Enabled = true;
            panel.Visible = true;

            this.Controls.Add(panel);
            panel.BringToFront();
            panel.Select();
            panel.Show();
        }


        private void btn_skg_add_Click(object sender, EventArgs e)
        {
            string[,] tasky = new string[1,4];
            tasky[0, 0] = "Chleba z máslem, Chleba z máslem ze salámem, Chleba z másel ze sýrem a ze salámem";
            tasky[0, 1] = "Stat +1";
            tasky[0, 2] = "Stat +4";
            tasky[0, 3] = "Stat +2";

            place_single_skillgroup("2", new Point(40, 20), "", new Point(60, 240), "Poo Poo", new Point(100, 150), "12", new Point(50, 210), 50, 100, new Point(10, 280), tasky, 1); 
        }

        private void Form_MainSkills_Load(object sender, EventArgs e)
        {

        }
    }
}
