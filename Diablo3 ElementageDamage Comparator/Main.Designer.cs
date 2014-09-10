namespace Diablo3_ElementageDamage_Comparator
{
    partial class Main
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.ui_CurrentElementalDamage = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.ui_ItemSkillDamage = new System.Windows.Forms.TextBox();
            this.ui_ItemEliteDamage = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ui_DPSAddition = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ui_ItemElementalDamage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ui_Result = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alwaysOnTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.thisAppOnGoogleCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ui_CurrentEliteDamage = new System.Windows.Forms.TextBox();
            this.ui_CurrentSkillDamage = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.visitWebappVersionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current %ElementalDamage :";
            // 
            // ui_CurrentElementalDamage
            // 
            this.ui_CurrentElementalDamage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ui_CurrentElementalDamage.Location = new System.Drawing.Point(172, 38);
            this.ui_CurrentElementalDamage.Name = "ui_CurrentElementalDamage";
            this.ui_CurrentElementalDamage.Size = new System.Drawing.Size(239, 20);
            this.ui_CurrentElementalDamage.TabIndex = 1;
            this.ui_CurrentElementalDamage.Text = "0";
            this.ui_CurrentElementalDamage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ui_CurrentElementalDamage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.onMouseClick);
            this.ui_CurrentElementalDamage.TextChanged += new System.EventHandler(this.onTextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.ui_ItemSkillDamage);
            this.groupBox1.Controls.Add(this.ui_ItemEliteDamage);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.ui_DPSAddition);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ui_ItemElementalDamage);
            this.groupBox1.Location = new System.Drawing.Point(12, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 142);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New item";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(405, 80);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(15, 13);
            this.label15.TabIndex = 19;
            this.label15.Text = "%";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(405, 54);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(15, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "%";
            // 
            // ui_ItemSkillDamage
            // 
            this.ui_ItemSkillDamage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ui_ItemSkillDamage.Location = new System.Drawing.Point(160, 77);
            this.ui_ItemSkillDamage.Name = "ui_ItemSkillDamage";
            this.ui_ItemSkillDamage.Size = new System.Drawing.Size(239, 20);
            this.ui_ItemSkillDamage.TabIndex = 17;
            this.ui_ItemSkillDamage.Text = "0";
            this.ui_ItemSkillDamage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ui_ItemSkillDamage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.onMouseClick);
            this.ui_ItemSkillDamage.TextChanged += new System.EventHandler(this.onTextChanged);
            // 
            // ui_ItemEliteDamage
            // 
            this.ui_ItemEliteDamage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ui_ItemEliteDamage.Location = new System.Drawing.Point(160, 51);
            this.ui_ItemEliteDamage.Name = "ui_ItemEliteDamage";
            this.ui_ItemEliteDamage.Size = new System.Drawing.Size(239, 20);
            this.ui_ItemEliteDamage.TabIndex = 16;
            this.ui_ItemEliteDamage.Text = "0";
            this.ui_ItemEliteDamage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ui_ItemEliteDamage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.onMouseClick);
            this.ui_ItemEliteDamage.TextChanged += new System.EventHandler(this.onTextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(51, 80);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "Item %SkillDamage :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(50, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Item %EliteDamage :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Item %ElementalDamage :";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(405, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "%";
            // 
            // ui_DPSAddition
            // 
            this.ui_DPSAddition.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ui_DPSAddition.Location = new System.Drawing.Point(160, 104);
            this.ui_DPSAddition.Name = "ui_DPSAddition";
            this.ui_DPSAddition.Size = new System.Drawing.Size(239, 20);
            this.ui_DPSAddition.TabIndex = 6;
            this.ui_DPSAddition.Text = "-0.0";
            this.ui_DPSAddition.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ui_DPSAddition.MouseClick += new System.Windows.Forms.MouseEventHandler(this.onMouseClick);
            this.ui_DPSAddition.TextChanged += new System.EventHandler(this.onTextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "DPS Addition :";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(405, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "%";
            // 
            // ui_ItemElementalDamage
            // 
            this.ui_ItemElementalDamage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ui_ItemElementalDamage.Location = new System.Drawing.Point(160, 25);
            this.ui_ItemElementalDamage.Name = "ui_ItemElementalDamage";
            this.ui_ItemElementalDamage.Size = new System.Drawing.Size(239, 20);
            this.ui_ItemElementalDamage.TabIndex = 4;
            this.ui_ItemElementalDamage.Text = "0";
            this.ui_ItemElementalDamage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ui_ItemElementalDamage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.onMouseClick);
            this.ui_ItemElementalDamage.TextChanged += new System.EventHandler(this.onTextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(417, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "%";
            // 
            // ui_Result
            // 
            this.ui_Result.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ui_Result.BackColor = System.Drawing.SystemColors.Control;
            this.ui_Result.ForeColor = System.Drawing.Color.Black;
            this.ui_Result.Location = new System.Drawing.Point(12, 268);
            this.ui_Result.Name = "ui_Result";
            this.ui_Result.Size = new System.Drawing.Size(431, 13);
            this.ui_Result.TabIndex = 4;
            this.ui_Result.Text = "The new item is better/worth/equals than your current item";
            this.ui_Result.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(455, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alwaysOnTopToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // alwaysOnTopToolStripMenuItem
            // 
            this.alwaysOnTopToolStripMenuItem.CheckOnClick = true;
            this.alwaysOnTopToolStripMenuItem.Name = "alwaysOnTopToolStripMenuItem";
            this.alwaysOnTopToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.alwaysOnTopToolStripMenuItem.Text = "&Always On Top";
            this.alwaysOnTopToolStripMenuItem.Click += new System.EventHandler(this.alwaysOnTopToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visitWebappVersionToolStripMenuItem,
            this.thisAppOnGoogleCodeToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem1.Text = "?";
            // 
            // thisAppOnGoogleCodeToolStripMenuItem
            // 
            this.thisAppOnGoogleCodeToolStripMenuItem.Name = "thisAppOnGoogleCodeToolStripMenuItem";
            this.thisAppOnGoogleCodeToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.thisAppOnGoogleCodeToolStripMenuItem.Text = "This app on Google Code..";
            this.thisAppOnGoogleCodeToolStripMenuItem.Click += new System.EventHandler(this.thisAppOnGoogleCodeToolStripMenuItem_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(402, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 8;
            this.label8.Text = "v0.2";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Current %EliteDamage :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Current %SkillDamage :";
            // 
            // ui_CurrentEliteDamage
            // 
            this.ui_CurrentEliteDamage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ui_CurrentEliteDamage.Location = new System.Drawing.Point(172, 65);
            this.ui_CurrentEliteDamage.Name = "ui_CurrentEliteDamage";
            this.ui_CurrentEliteDamage.Size = new System.Drawing.Size(239, 20);
            this.ui_CurrentEliteDamage.TabIndex = 11;
            this.ui_CurrentEliteDamage.Text = "0";
            this.ui_CurrentEliteDamage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ui_CurrentEliteDamage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.onMouseClick);
            this.ui_CurrentEliteDamage.TextChanged += new System.EventHandler(this.onTextChanged);
            // 
            // ui_CurrentSkillDamage
            // 
            this.ui_CurrentSkillDamage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ui_CurrentSkillDamage.Location = new System.Drawing.Point(172, 90);
            this.ui_CurrentSkillDamage.Name = "ui_CurrentSkillDamage";
            this.ui_CurrentSkillDamage.Size = new System.Drawing.Size(239, 20);
            this.ui_CurrentSkillDamage.TabIndex = 12;
            this.ui_CurrentSkillDamage.Text = "0";
            this.ui_CurrentSkillDamage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ui_CurrentSkillDamage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.onMouseClick);
            this.ui_CurrentSkillDamage.TextChanged += new System.EventHandler(this.onTextChanged);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(417, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "%";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(417, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "%";
            // 
            // visitWebappVersionToolStripMenuItem
            // 
            this.visitWebappVersionToolStripMenuItem.Name = "visitWebappVersionToolStripMenuItem";
            this.visitWebappVersionToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.visitWebappVersionToolStripMenuItem.Text = "WebApp version..";
            this.visitWebappVersionToolStripMenuItem.Click += new System.EventHandler(this.visitWebappVersionToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 294);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ui_CurrentSkillDamage);
            this.Controls.Add(this.ui_CurrentEliteDamage);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ui_Result);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ui_CurrentElementalDamage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diablo III %ElementageDamage Comparator - by NQuenault";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ui_CurrentElementalDamage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ui_DPSAddition;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ui_ItemElementalDamage;
        private System.Windows.Forms.Label ui_Result;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alwaysOnTopToolStripMenuItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ui_CurrentEliteDamage;
        private System.Windows.Forms.TextBox ui_CurrentSkillDamage;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox ui_ItemSkillDamage;
        private System.Windows.Forms.TextBox ui_ItemEliteDamage;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem thisAppOnGoogleCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visitWebappVersionToolStripMenuItem;
    }
}

