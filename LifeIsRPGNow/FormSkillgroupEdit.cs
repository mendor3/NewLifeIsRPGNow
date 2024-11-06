using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace LifeIsRPGNow
{
    public partial class FormSkillgroupEdit : Form
    {
        SkillGroup newSG;
        Form_skillgroup mainForm = System.Windows.Forms.Application.OpenForms.OfType<Form_skillgroup>().FirstOrDefault();
        List<String> skillGroups = new List<String>();
        OpenFileDialog openFileDialog = new OpenFileDialog();
        string picName;
        SkillGroup chosenSG;

        public FormSkillgroupEdit()
        {
            InitializeComponent();
            populateGroupList();
            comboBox1.DataSource = skillGroups;
            loadSkillGroup();
        }

        private void FormSkillgroupEdit_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void populateGroupList()
        {
            foreach (SkillGroup n in mainForm.arraySkillGroup)
            {
                skillGroups.Add(n.GetName());
            }
        }

        /* Načte existující údaje SG do textboxů a picboxu */
        private void loadSkillGroup()
        {
            chosenSG = mainForm.arraySkillGroup.First(item => item.GetName() == comboBox1.Text);

            txtb_name.Text = chosenSG.GetName();
            txtb_id.Text = chosenSG.GetId().ToString();
            pictureBox1.ImageLocation = chosenSG.GetPicture();
            picName = chosenSG.GetPicture();
        }

        /* vytvoří finální SG, vytvoří nový obrázek, smaže starou SG, dosadí nové id, uloží SG do txt filu a zavolá funkci z form */
        private void btn_editgroup_Click(object sender, EventArgs e)
        {
            picName = @"C:\\LifeisRPGTest\\Icons\\SkillGroupIcon_" + txtb_codename.Text + ".png";
            newSG = new SkillGroup(chosenSG.GetId(), txtb_name.Text, txtb_codename.Text, chosenSG.GetGroupLevel(), picName);

            File.Copy(pictureBox1.ImageLocation, picName);

            mainForm.deleteSkillgroup(chosenSG.GetName());
            newSG.SetId(mainForm.arraySkillGroup.Count + 1);

            save_to_file();
            mainForm.load_new_skillgroup(newSG);
            this.Close();
        }

        /* Uloží data do basic txt souboru a rozdělí groupy pomocí '-' a pak rozdělí jednotlivý data pomocí '/' */
        private void save_to_file()
        {
            string file, path;

            file = newSG.GetId() + "/" + txtb_name.Text + "/" + txtb_codename.Text + "/" + newSG.GetGroupLevel() + "/" + picName + "-" + Environment.NewLine;

            path = "C:\\LifeisRPGTest\\skill_group_data.txt";


            File.AppendAllText(path, file);
        }

        /* otevře file explorer a po zvolení obrázku ho načte do pictureboxu a uloží jeho cestu */
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog.FileName;
            picName = @"C:\\LifeisRPGTest\\Icons\\SkillGroupIcon_" + txtb_codename.Text + ".png";
        }

        /* Vezme název a odstraní diakritiku, velká písmena a mezery */
        private void txtb_name_TextChanged(object sender, EventArgs e)
        {
            byte[] tempBytes;
            tempBytes = System.Text.Encoding.GetEncoding("ISO-8859-8").GetBytes(txtb_name.Text);
            txtb_codename.Text = Regex.Replace(System.Text.Encoding.UTF8.GetString(tempBytes).ToLower(), @"\s", "");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadSkillGroup();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
