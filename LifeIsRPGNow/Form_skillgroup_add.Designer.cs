namespace LifeIsRPGNow
{
    partial class Form_skillgroup_add
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_skillgroup_add));
            this.txtb_id = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtb_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtb_codename = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtb_grouplevel = new System.Windows.Forms.TextBox();
            this.btn_addgroup = new System.Windows.Forms.Button();
            this.btn_canceladd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtb_id
            // 
            this.txtb_id.Location = new System.Drawing.Point(12, 30);
            this.txtb_id.Name = "txtb_id";
            this.txtb_id.ReadOnly = true;
            this.txtb_id.Size = new System.Drawing.Size(100, 22);
            this.txtb_id.TabIndex = 2;
            this.txtb_id.TextChanged += new System.EventHandler(this.txtb_id_TextChanged);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(9, 9);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(18, 16);
            this.lbl_id.TabIndex = 1;
            this.lbl_id.Text = "id";
            this.lbl_id.Click += new System.EventHandler(this.lbl_id_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtb_name
            // 
            this.txtb_name.Location = new System.Drawing.Point(12, 81);
            this.txtb_name.Name = "txtb_name";
            this.txtb_name.Size = new System.Drawing.Size(100, 22);
            this.txtb_name.TabIndex = 0;
            this.txtb_name.TextChanged += new System.EventHandler(this.txtb_name_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "code name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtb_codename
            // 
            this.txtb_codename.Location = new System.Drawing.Point(12, 136);
            this.txtb_codename.Name = "txtb_codename";
            this.txtb_codename.ReadOnly = true;
            this.txtb_codename.Size = new System.Drawing.Size(100, 22);
            this.txtb_codename.TabIndex = 4;
            this.txtb_codename.TextChanged += new System.EventHandler(this.txtb_codename_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "group level";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtb_grouplevel
            // 
            this.txtb_grouplevel.Location = new System.Drawing.Point(12, 196);
            this.txtb_grouplevel.Name = "txtb_grouplevel";
            this.txtb_grouplevel.Size = new System.Drawing.Size(100, 22);
            this.txtb_grouplevel.TabIndex = 6;
            this.txtb_grouplevel.TextChanged += new System.EventHandler(this.txtb_grouplevel_TextChanged);
            // 
            // btn_addgroup
            // 
            this.btn_addgroup.Location = new System.Drawing.Point(21, 275);
            this.btn_addgroup.Name = "btn_addgroup";
            this.btn_addgroup.Size = new System.Drawing.Size(136, 40);
            this.btn_addgroup.TabIndex = 10;
            this.btn_addgroup.Text = "btn_addgroup";
            this.btn_addgroup.UseVisualStyleBackColor = true;
            this.btn_addgroup.Click += new System.EventHandler(this.btn_addgroup_Click);
            // 
            // btn_canceladd
            // 
            this.btn_canceladd.Location = new System.Drawing.Point(278, 275);
            this.btn_canceladd.Name = "btn_canceladd";
            this.btn_canceladd.Size = new System.Drawing.Size(136, 40);
            this.btn_canceladd.TabIndex = 11;
            this.btn_canceladd.Text = "btn_canceladd";
            this.btn_canceladd.UseVisualStyleBackColor = true;
            this.btn_canceladd.Click += new System.EventHandler(this.btn_canceladd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(191, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form_skillgroup_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 398);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_canceladd);
            this.Controls.Add(this.btn_addgroup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtb_grouplevel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtb_codename);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtb_name);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.txtb_id);
            this.Name = "Form_skillgroup_add";
            this.Text = "Form_skillgroup_add";
            this.Load += new System.EventHandler(this.Form_skillgroup_add_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtb_id;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtb_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtb_codename;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtb_grouplevel;
        private System.Windows.Forms.Button btn_addgroup;
        private System.Windows.Forms.Button btn_canceladd;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}