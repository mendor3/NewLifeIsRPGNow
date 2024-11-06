namespace LifeIsRPGNow
{
    partial class Form_skillgroup
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_skg_delete = new System.Windows.Forms.Button();
            this.btn_skg_edit = new System.Windows.Forms.Button();
            this.btn_skg_add = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_skg_delete);
            this.panel1.Controls.Add(this.btn_skg_edit);
            this.panel1.Controls.Add(this.btn_skg_add);
            this.panel1.Location = new System.Drawing.Point(-8, 800);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1600, 60);
            this.panel1.TabIndex = 0;
            // 
            // btn_skg_delete
            // 
            this.btn_skg_delete.Location = new System.Drawing.Point(1503, 18);
            this.btn_skg_delete.Name = "btn_skg_delete";
            this.btn_skg_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_skg_delete.TabIndex = 2;
            this.btn_skg_delete.Text = "delete";
            this.btn_skg_delete.UseVisualStyleBackColor = true;
            this.btn_skg_delete.Click += new System.EventHandler(this.btn_skg_del_Click);
            // 
            // btn_skg_edit
            // 
            this.btn_skg_edit.Location = new System.Drawing.Point(763, 19);
            this.btn_skg_edit.Name = "btn_skg_edit";
            this.btn_skg_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_skg_edit.TabIndex = 1;
            this.btn_skg_edit.Text = "edit";
            this.btn_skg_edit.UseVisualStyleBackColor = true;
            this.btn_skg_edit.Click += new System.EventHandler(this.btn_skg_edit_Click);
            // 
            // btn_skg_add
            // 
            this.btn_skg_add.Location = new System.Drawing.Point(21, 18);
            this.btn_skg_add.Name = "btn_skg_add";
            this.btn_skg_add.Size = new System.Drawing.Size(75, 23);
            this.btn_skg_add.TabIndex = 0;
            this.btn_skg_add.Text = "Add";
            this.btn_skg_add.UseVisualStyleBackColor = true;
            this.btn_skg_add.Click += new System.EventHandler(this.btn_skg_add_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1158, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_skillgroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.panel1);
            this.Name = "Form_skillgroup";
            this.Text = "Form_skillgroup";
            this.Load += new System.EventHandler(this.Form_skillgroup_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_skg_delete;
        private System.Windows.Forms.Button btn_skg_edit;
        private System.Windows.Forms.Button btn_skg_add;
        private System.Windows.Forms.Button button1;
    }
}

