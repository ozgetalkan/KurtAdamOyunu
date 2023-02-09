namespace KurtAdamOyunu
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtWeapon = new System.Windows.Forms.TextBox();
            this.cmbRace = new System.Windows.Forms.ComboBox();
            this.cmbBranch = new System.Windows.Forms.ComboBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.pcbWolfMan = new System.Windows.Forms.PictureBox();
            this.lblHealth = new System.Windows.Forms.Label();
            this.btnAttack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbWolfMan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(158, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Irk:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(123, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Branş:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(131, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Silah:";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(209, 44);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(207, 31);
            this.txtUserName.TabIndex = 1;
            // 
            // txtWeapon
            // 
            this.txtWeapon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeapon.Location = new System.Drawing.Point(209, 194);
            this.txtWeapon.Name = "txtWeapon";
            this.txtWeapon.Size = new System.Drawing.Size(207, 31);
            this.txtWeapon.TabIndex = 1;
            // 
            // cmbRace
            // 
            this.cmbRace.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRace.FormattingEnabled = true;
            this.cmbRace.Items.AddRange(new object[] {
            "Human",
            "Monster"});
            this.cmbRace.Location = new System.Drawing.Point(209, 93);
            this.cmbRace.Name = "cmbRace";
            this.cmbRace.Size = new System.Drawing.Size(206, 33);
            this.cmbRace.TabIndex = 2;
            // 
            // cmbBranch
            // 
            this.cmbBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBranch.FormattingEnabled = true;
            this.cmbBranch.Items.AddRange(new object[] {
            "Warrior",
            "Mage",
            "Archer",
            "Assasin"});
            this.cmbBranch.Location = new System.Drawing.Point(209, 143);
            this.cmbBranch.Name = "cmbBranch";
            this.cmbBranch.Size = new System.Drawing.Size(206, 33);
            this.cmbBranch.TabIndex = 2;
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Location = new System.Drawing.Point(521, 93);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(160, 73);
            this.btnSelect.TabIndex = 3;
            this.btnSelect.Text = "Seç";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // pcbWolfMan
            // 
            this.pcbWolfMan.Image = global::KurtAdamOyunu.Properties.Resources.png_clipart_gray_wolf_werewolf_the_apocalypse_art_scott_mccall_werewolf_legendary_creature_cat_like_mammal_thumbnail;
            this.pcbWolfMan.Location = new System.Drawing.Point(512, 349);
            this.pcbWolfMan.Name = "pcbWolfMan";
            this.pcbWolfMan.Size = new System.Drawing.Size(228, 201);
            this.pcbWolfMan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbWolfMan.TabIndex = 4;
            this.pcbWolfMan.TabStop = false;
            this.pcbWolfMan.Visible = false;
            // 
            // lblHealth
            // 
            this.lblHealth.BackColor = System.Drawing.Color.Red;
            this.lblHealth.Location = new System.Drawing.Point(472, 312);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(300, 23);
            this.lblHealth.TabIndex = 5;
            this.lblHealth.Visible = false;
            // 
            // btnAttack
            // 
            this.btnAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttack.Location = new System.Drawing.Point(222, 411);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(164, 100);
            this.btnAttack.TabIndex = 6;
            this.btnAttack.Text = "Saldır";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Visible = false;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 620);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.lblHealth);
            this.Controls.Add(this.pcbWolfMan);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.cmbBranch);
            this.Controls.Add(this.cmbRace);
            this.Controls.Add(this.txtWeapon);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pcbWolfMan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtWeapon;
        private System.Windows.Forms.ComboBox cmbRace;
        private System.Windows.Forms.ComboBox cmbBranch;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.PictureBox pcbWolfMan;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.Button btnAttack;
    }
}

