using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using Label = System.Windows.Forms.Label;



namespace LifeIsRPGNow
{
    public partial class Form_skillgroup : Form
    {

        public List<SkillGroup> arraySkillGroup = new List<SkillGroup>(); //List Skill Group viditelný pro všechny

        public Form_skillgroup()
        {
            InitializeComponent();
        }

        /* Načte textfile se skill group datama a rozdělí je tak aby je mohl uložit do listu SkillGroup objektů */
        private void Form_skillgroup_Load(object sender, EventArgs e)
        {
            string path = "C:\\LifeisRPGTest\\skill_group_data.txt";
            string text = File.ReadAllText(path);
            //text = Regex.Replace(text, @"\s", "");

            string[] textGroups = text.Split('-');
            for (int i = 0; i < (textGroups.Length - 1); i++ )
            {
                string[] textSingle = textGroups[i].Split('/');
                SkillGroup newsg = new SkillGroup( int.Parse(textSingle[0]), textSingle[1], textSingle[2], int.Parse(textSingle[3]), textSingle[4]);
                arraySkillGroup.Add(newsg);
            }

            place_skillgroup();
        }

        private void btn_skg_add_Click(object sender, EventArgs e)
        {
            Form_skillgroup_add f1 = new Form_skillgroup_add();
            f1.Show();          
        }

        private void btn_skg_del_Click(object sender, EventArgs e)
        {
            FormSkillgroupDelete f1 = new FormSkillgroupDelete();
            f1.Show();
        }

        private void btn_skg_edit_Click(object sender, EventArgs e)
        {
            FormSkillgroupEdit f1 = new FormSkillgroupEdit(); 
            f1.Show();
        }

        /* Smaže SkillGroup, změní pořadí v Listu a jejich id a pak přepíše txt file aby se id schodovalo*/
        public void deleteSkillgroup(string name)
        {
            string line = null;
            string file = "";
            string path = "C:\\LifeisRPGTest\\skill_group_data.txt";

            SkillGroup delSG = arraySkillGroup.First(item => item.GetName() == name);


            List<SkillGroup> middle;

            arraySkillGroup.RemoveAll(p => p.GetName() == name);

            middle = new List<SkillGroup>(arraySkillGroup);

            arraySkillGroup.Clear();

            int count = 1;

            foreach (SkillGroup sg in middle)
            {
                sg.SetId(count++);
                arraySkillGroup.Add(sg);
                line = sg.GetId() + "/" + sg.GetName() + "/" + sg.GetCodeName() + "/" + sg.GetGroupLevel() + "/" + sg.GetPicture() + "-" + Environment.NewLine;
                file = file + line;
            }

            File.WriteAllText(path, file);

            File.Delete(delSG.GetPicture());


            this.Controls.Clear();
            this.InitializeComponent();
            place_skillgroup();
        }
        /* Položí jednotliví SkillGroupy do okna a zařídí jejich pozici aby bylo 5 nahoře a 5 dole a TODO pak další stránka */
        private void place_skillgroup()
        {
            double pages = (double) arraySkillGroup.Count / 10;
            pages = Math.Ceiling(pages);

            for(int j = 0; j < pages; j++)
            {
                for (int i = 0; i < arraySkillGroup.Count; i++)
                {
                    int pageId = (arraySkillGroup[i].GetId() - (j * 10));

                    int offsetX = 0;
                    int offsetY = 0;

                    if (pageId > 5)
                    {
                        offsetY = 250;
                        offsetX = 220 * (pageId - 6);
                    }
                    else
                    {
                        offsetX = 220 * (pageId - 1);
                        offsetY = 0;
                    }

                    Point locIcon = new Point(20 + offsetX, 20 + offsetY);
                    Point locName = new Point(15 + offsetX, 225 + offsetY);
                    Point locLevel = new Point(85 + offsetX, 150 + offsetY);

                    place_single_skillgroup(arraySkillGroup[i].GetId().ToString(), locIcon, arraySkillGroup[i].GetPicture(),
                        locName, arraySkillGroup[i].GetName(), locLevel, arraySkillGroup[i].GetGroupLevel().ToString());

                }
            }
        }

        /* Položí jednu SkillGroupu  */
        private void place_single_skillgroup(string id,Point locIcon, string iconText, Point locName, string nameText, Point locLevel, string levelText)
        {
            PictureBox icon = new PictureBox();
            Label name = new Label();
            Label level = new Label();


            icon.SizeMode = PictureBoxSizeMode.StretchImage;
            icon.Location = locIcon;
            icon.Name = "lbl_icon" + id;
            icon.Size = new System.Drawing.Size(200, 200);
            icon.TabIndex = 0;
            icon.ImageLocation = iconText;

            icon.Enabled = true;
            icon.Visible = true;

            this.Controls.Add(icon);
            icon.Select();
            icon.Show();



            name.AutoSize = true;
            name.Location = locName;
            name.Name = "lbl_name" + id;
            name.Size = new System.Drawing.Size(207, 32);
            name.TabIndex = 0;
            name.Font = new Font("Microsoft Sans Serif", 16, FontStyle.Bold);
            name.Text = nameText;

            name.Enabled = true;
            name.Visible = true;

            this.Controls.Add(name);
            name.Select();
            name.Show();



            level.AutoSize = true;
            level.Location = locLevel;
            level.Name = "lbl_level" + id;
            level.Size = new System.Drawing.Size(64, 69);
            level.TabIndex = 0;
            level.Font = new Font("Microsoft Sans Serif", 36, FontStyle.Bold);
            level.Text = levelText;

            level.Enabled = true;
            level.Visible = true;

            this.Controls.Add(level);
            level.BringToFront();
            level.Select();
            level.Show();
        }

        /* Přidá novou SkillGroupu do listu a reloadne form */
        public void load_new_skillgroup(SkillGroup skillgroup)
        {
            arraySkillGroup.Add(skillgroup);

            this.Controls.Clear();
            this.InitializeComponent();

            place_skillgroup();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_MainSkills f1 = new Form_MainSkills();
            f1.Show();
        }
    }
}
