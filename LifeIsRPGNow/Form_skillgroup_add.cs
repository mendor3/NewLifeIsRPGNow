using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace LifeIsRPGNow
{
    public partial class Form_skillgroup_add : Form
    {
        SkillGroup skillgroup;
        Form_skillgroup mainForm = System.Windows.Forms.Application.OpenForms.OfType<Form_skillgroup>().FirstOrDefault();
        OpenFileDialog openFileDialog = new OpenFileDialog();
        string picName;

        public Form_skillgroup_add()
        {
            InitializeComponent();
            autofillId();
        }

        private void Form_skillgroup_add_Load(object sender, EventArgs e)
        {

        }

        /* Vytvoří SG přidá jí do txt file a zavolá funkci z hlavní */
        private void btn_addgroup_Click(object sender, EventArgs e)
        {
            skillgroup = new SkillGroup(int.Parse(txtb_id.Text), txtb_name.Text, txtb_codename.Text, int.Parse(txtb_grouplevel.Text), picName);
            save_to_file();
            mainForm.load_new_skillgroup(skillgroup);
            this.Close();
        }

        /* Uloží data do basic txt souboru a rozdělí groupy pomocí '-' a pak rozdělí jednotlivý data pomocí '/' */
        private void save_to_file()
        {
            string file, path;

            file = txtb_id.Text + "/" + txtb_name.Text + "/" + txtb_codename.Text + "/" + txtb_grouplevel.Text + "/" + picName + "-" + Environment.NewLine;
            
            path = "C:\\LifeisRPGTest\\skill_group_data.txt";

            File.Copy(openFileDialog.FileName, picName);

            File.AppendAllText(path, file);
        }

        private void autofillId()
        {
            txtb_id.Text = (mainForm.arraySkillGroup.Count + 1).ToString();
        }

        /* Vezme název a odstraní diakritiku, velká písmena a mezery */
        private void txtb_name_TextChanged(object sender, EventArgs e)
        {
            byte[] tempBytes;
            tempBytes = System.Text.Encoding.GetEncoding("ISO-8859-8").GetBytes(txtb_name.Text);
            txtb_codename.Text = Regex.Replace(System.Text.Encoding.UTF8.GetString(tempBytes).ToLower(), @"\s", "");

        }

        /* otevře file explorer a po zvolení obrázku ho načte do pictureboxu a uloží jeho cestu */
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog.FileName;
            picName = @"C:\\LifeisRPGTest\\Icons\\SkillGroupIcon_" + txtb_codename.Text + ".png";
        }

        private void txtb_grouplevel_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtb_codename_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lbl_id_Click(object sender, EventArgs e)
        {

        }

        private void txtb_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_canceladd_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
