namespace ACTrainer
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.GodMod = new System.Windows.Forms.CheckBox();
            this.gameLabel = new System.Windows.Forms.Label();
            this.IsProcFound = new System.Windows.Forms.Label();
            this.InfiniteJumps = new System.Windows.Forms.CheckBox();
            this.L_health = new System.Windows.Forms.Label();
            this.health = new System.Windows.Forms.TextBox();
            this.L_sheild = new System.Windows.Forms.Label();
            this.sheild = new System.Windows.Forms.TextBox();
            this.IsTwoPistols = new System.Windows.Forms.CheckBox();
            this.L_OnePistolAmmo = new System.Windows.Forms.Label();
            this.L_MainWeaponAmmo = new System.Windows.Forms.Label();
            this.L_TwoPistolAmmo = new System.Windows.Forms.Label();
            this.L_OnePistolStack = new System.Windows.Forms.Label();
            this.L_MainWeaponStack = new System.Windows.Forms.Label();
            this.L_Granades = new System.Windows.Forms.Label();
            this.L_TwoPistolStack = new System.Windows.Forms.Label();
            this.OnePistolAmmo = new System.Windows.Forms.TextBox();
            this.TwoPistolStack = new System.Windows.Forms.TextBox();
            this.Granades = new System.Windows.Forms.TextBox();
            this.MainWeaponStack = new System.Windows.Forms.TextBox();
            this.OnePistolStack = new System.Windows.Forms.TextBox();
            this.TwoPistolAmmo = new System.Windows.Forms.TextBox();
            this.MainWeaponAmmo = new System.Windows.Forms.TextBox();
            this.NoReload = new System.Windows.Forms.CheckBox();
            this.NoRecoil = new System.Windows.Forms.CheckBox();
            this.NoDBS = new System.Windows.Forms.CheckBox();
            this.AimBot = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // GodMod
            // 
            this.GodMod.AutoSize = true;
            this.GodMod.Location = new System.Drawing.Point(29, 74);
            this.GodMod.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.GodMod.Name = "GodMod";
            this.GodMod.Size = new System.Drawing.Size(176, 45);
            this.GodMod.TabIndex = 1;
            this.GodMod.Text = "GodMod";
            this.GodMod.UseVisualStyleBackColor = true;
            this.GodMod.CheckedChanged += new System.EventHandler(this.GodMod_CheckedChanged);
            // 
            // gameLabel
            // 
            this.gameLabel.AutoSize = true;
            this.gameLabel.Location = new System.Drawing.Point(29, 25);
            this.gameLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.gameLabel.Name = "gameLabel";
            this.gameLabel.Size = new System.Drawing.Size(126, 41);
            this.gameLabel.TabIndex = 3;
            this.gameLabel.Text = "Process:";
            // 
            // IsProcFound
            // 
            this.IsProcFound.AutoSize = true;
            this.IsProcFound.Location = new System.Drawing.Point(168, 25);
            this.IsProcFound.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.IsProcFound.Name = "IsProcFound";
            this.IsProcFound.Size = new System.Drawing.Size(0, 41);
            this.IsProcFound.TabIndex = 4;
            // 
            // InfiniteJumps
            // 
            this.InfiniteJumps.AutoSize = true;
            this.InfiniteJumps.Location = new System.Drawing.Point(29, 145);
            this.InfiniteJumps.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.InfiniteJumps.Name = "InfiniteJumps";
            this.InfiniteJumps.Size = new System.Drawing.Size(232, 45);
            this.InfiniteJumps.TabIndex = 5;
            this.InfiniteJumps.Text = "InfiniteJumps";
            this.InfiniteJumps.UseVisualStyleBackColor = true;
            this.InfiniteJumps.CheckedChanged += new System.EventHandler(this.InfiniteJumps_CheckedChanged);
            // 
            // L_health
            // 
            this.L_health.AutoSize = true;
            this.L_health.Location = new System.Drawing.Point(29, 224);
            this.L_health.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.L_health.Name = "L_health";
            this.L_health.Size = new System.Drawing.Size(111, 41);
            this.L_health.TabIndex = 6;
            this.L_health.Text = "Health:";
            // 
            // health
            // 
            this.health.Location = new System.Drawing.Point(155, 216);
            this.health.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.health.Name = "health";
            this.health.Size = new System.Drawing.Size(237, 47);
            this.health.TabIndex = 7;
            this.health.TextChanged += new System.EventHandler(this.health_TextChanged);
            // 
            // L_sheild
            // 
            this.L_sheild.AutoSize = true;
            this.L_sheild.Location = new System.Drawing.Point(29, 306);
            this.L_sheild.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.L_sheild.Name = "L_sheild";
            this.L_sheild.Size = new System.Drawing.Size(99, 41);
            this.L_sheild.TabIndex = 8;
            this.L_sheild.Text = "Sheild";
            // 
            // sheild
            // 
            this.sheild.Location = new System.Drawing.Point(153, 298);
            this.sheild.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.sheild.Name = "sheild";
            this.sheild.Size = new System.Drawing.Size(237, 47);
            this.sheild.TabIndex = 9;
            this.sheild.TextChanged += new System.EventHandler(this.sheild_TextChanged);
            // 
            // IsTwoPistols
            // 
            this.IsTwoPistols.AutoSize = true;
            this.IsTwoPistols.Location = new System.Drawing.Point(29, 385);
            this.IsTwoPistols.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.IsTwoPistols.Name = "IsTwoPistols";
            this.IsTwoPistols.Size = new System.Drawing.Size(216, 45);
            this.IsTwoPistols.TabIndex = 10;
            this.IsTwoPistols.Text = "IsTwoPistols";
            this.IsTwoPistols.UseVisualStyleBackColor = true;
            this.IsTwoPistols.CheckedChanged += new System.EventHandler(this.IsTwoPistols_CheckedChanged);
            // 
            // L_OnePistolAmmo
            // 
            this.L_OnePistolAmmo.AutoSize = true;
            this.L_OnePistolAmmo.Location = new System.Drawing.Point(29, 456);
            this.L_OnePistolAmmo.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.L_OnePistolAmmo.Name = "L_OnePistolAmmo";
            this.L_OnePistolAmmo.Size = new System.Drawing.Size(242, 41);
            this.L_OnePistolAmmo.TabIndex = 11;
            this.L_OnePistolAmmo.Text = "OnePistolAmmo:";
            // 
            // L_MainWeaponAmmo
            // 
            this.L_MainWeaponAmmo.AutoSize = true;
            this.L_MainWeaponAmmo.Location = new System.Drawing.Point(29, 536);
            this.L_MainWeaponAmmo.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.L_MainWeaponAmmo.Name = "L_MainWeaponAmmo";
            this.L_MainWeaponAmmo.Size = new System.Drawing.Size(291, 41);
            this.L_MainWeaponAmmo.TabIndex = 11;
            this.L_MainWeaponAmmo.Text = "MainWeaponAmmo:";
            // 
            // L_TwoPistolAmmo
            // 
            this.L_TwoPistolAmmo.AutoSize = true;
            this.L_TwoPistolAmmo.Location = new System.Drawing.Point(29, 615);
            this.L_TwoPistolAmmo.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.L_TwoPistolAmmo.Name = "L_TwoPistolAmmo";
            this.L_TwoPistolAmmo.Size = new System.Drawing.Size(240, 41);
            this.L_TwoPistolAmmo.TabIndex = 11;
            this.L_TwoPistolAmmo.Text = "TwoPistolAmmo:";
            // 
            // L_OnePistolStack
            // 
            this.L_OnePistolStack.AutoSize = true;
            this.L_OnePistolStack.Location = new System.Drawing.Point(29, 694);
            this.L_OnePistolStack.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.L_OnePistolStack.Name = "L_OnePistolStack";
            this.L_OnePistolStack.Size = new System.Drawing.Size(222, 41);
            this.L_OnePistolStack.TabIndex = 11;
            this.L_OnePistolStack.Text = "OnePistolStack:";
            // 
            // L_MainWeaponStack
            // 
            this.L_MainWeaponStack.AutoSize = true;
            this.L_MainWeaponStack.Location = new System.Drawing.Point(29, 774);
            this.L_MainWeaponStack.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.L_MainWeaponStack.Name = "L_MainWeaponStack";
            this.L_MainWeaponStack.Size = new System.Drawing.Size(271, 41);
            this.L_MainWeaponStack.TabIndex = 11;
            this.L_MainWeaponStack.Text = "MainWeaponStack:";
            // 
            // L_Granades
            // 
            this.L_Granades.AutoSize = true;
            this.L_Granades.Location = new System.Drawing.Point(29, 853);
            this.L_Granades.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.L_Granades.Name = "L_Granades";
            this.L_Granades.Size = new System.Drawing.Size(150, 41);
            this.L_Granades.TabIndex = 11;
            this.L_Granades.Text = "Granades:";
            // 
            // L_TwoPistolStack
            // 
            this.L_TwoPistolStack.AutoSize = true;
            this.L_TwoPistolStack.Location = new System.Drawing.Point(29, 932);
            this.L_TwoPistolStack.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.L_TwoPistolStack.Name = "L_TwoPistolStack";
            this.L_TwoPistolStack.Size = new System.Drawing.Size(220, 41);
            this.L_TwoPistolStack.TabIndex = 11;
            this.L_TwoPistolStack.Text = "TwoPistolStack:";
            // 
            // OnePistolAmmo
            // 
            this.OnePistolAmmo.Location = new System.Drawing.Point(335, 448);
            this.OnePistolAmmo.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.OnePistolAmmo.Name = "OnePistolAmmo";
            this.OnePistolAmmo.Size = new System.Drawing.Size(237, 47);
            this.OnePistolAmmo.TabIndex = 12;
            this.OnePistolAmmo.TextChanged += new System.EventHandler(this.OnePistolAmmo_TextChanged);
            // 
            // TwoPistolStack
            // 
            this.TwoPistolStack.Location = new System.Drawing.Point(335, 924);
            this.TwoPistolStack.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.TwoPistolStack.Name = "TwoPistolStack";
            this.TwoPistolStack.Size = new System.Drawing.Size(237, 47);
            this.TwoPistolStack.TabIndex = 12;
            this.TwoPistolStack.TextChanged += new System.EventHandler(this.TwoPistolStack_TextChanged);
            // 
            // Granades
            // 
            this.Granades.Location = new System.Drawing.Point(335, 845);
            this.Granades.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Granades.Name = "Granades";
            this.Granades.Size = new System.Drawing.Size(237, 47);
            this.Granades.TabIndex = 12;
            this.Granades.TextChanged += new System.EventHandler(this.Granades_TextChanged);
            // 
            // MainWeaponStack
            // 
            this.MainWeaponStack.Location = new System.Drawing.Point(335, 765);
            this.MainWeaponStack.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.MainWeaponStack.Name = "MainWeaponStack";
            this.MainWeaponStack.Size = new System.Drawing.Size(237, 47);
            this.MainWeaponStack.TabIndex = 12;
            this.MainWeaponStack.TextChanged += new System.EventHandler(this.MainWeaponStack_TextChanged);
            // 
            // OnePistolStack
            // 
            this.OnePistolStack.Location = new System.Drawing.Point(335, 686);
            this.OnePistolStack.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.OnePistolStack.Name = "OnePistolStack";
            this.OnePistolStack.Size = new System.Drawing.Size(237, 47);
            this.OnePistolStack.TabIndex = 12;
            this.OnePistolStack.TextChanged += new System.EventHandler(this.OnePistolStack_TextChanged);
            // 
            // TwoPistolAmmo
            // 
            this.TwoPistolAmmo.Location = new System.Drawing.Point(335, 607);
            this.TwoPistolAmmo.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.TwoPistolAmmo.Name = "TwoPistolAmmo";
            this.TwoPistolAmmo.Size = new System.Drawing.Size(237, 47);
            this.TwoPistolAmmo.TabIndex = 12;
            this.TwoPistolAmmo.TextChanged += new System.EventHandler(this.TwoPistolAmmo_TextChanged);
            // 
            // MainWeaponAmmo
            // 
            this.MainWeaponAmmo.Location = new System.Drawing.Point(335, 528);
            this.MainWeaponAmmo.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.MainWeaponAmmo.Name = "MainWeaponAmmo";
            this.MainWeaponAmmo.Size = new System.Drawing.Size(237, 47);
            this.MainWeaponAmmo.TabIndex = 12;
            this.MainWeaponAmmo.TextChanged += new System.EventHandler(this.MainWeaponAmmo_TextChanged);
            // 
            // NoReload
            // 
            this.NoReload.AutoSize = true;
            this.NoReload.Location = new System.Drawing.Point(29, 995);
            this.NoReload.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.NoReload.Name = "NoReload";
            this.NoReload.Size = new System.Drawing.Size(187, 45);
            this.NoReload.TabIndex = 13;
            this.NoReload.Text = "NoReload";
            this.NoReload.UseVisualStyleBackColor = true;
            this.NoReload.CheckedChanged += new System.EventHandler(this.NoReload_CheckedChanged);
            // 
            // NoRecoil
            // 
            this.NoRecoil.AutoSize = true;
            this.NoRecoil.Location = new System.Drawing.Point(793, 74);
            this.NoRecoil.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.NoRecoil.Name = "NoRecoil";
            this.NoRecoil.Size = new System.Drawing.Size(183, 45);
            this.NoRecoil.TabIndex = 14;
            this.NoRecoil.Text = "No Recoil";
            this.NoRecoil.UseVisualStyleBackColor = true;
            this.NoRecoil.CheckedChanged += new System.EventHandler(this.NoRecoil_CheckedChanged);
            // 
            // NoDBS
            // 
            this.NoDBS.AutoSize = true;
            this.NoDBS.Location = new System.Drawing.Point(793, 145);
            this.NoDBS.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.NoDBS.Name = "NoDBS";
            this.NoDBS.Size = new System.Drawing.Size(382, 45);
            this.NoDBS.TabIndex = 15;
            this.NoDBS.Text = "No Delay Between Shots";
            this.NoDBS.UseVisualStyleBackColor = true;
            this.NoDBS.CheckedChanged += new System.EventHandler(this.NoDBS_CheckedChanged);
            // 
            // AimBot
            // 
            this.AimBot.AutoSize = true;
            this.AimBot.Location = new System.Drawing.Point(793, 218);
            this.AimBot.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.AimBot.Name = "AimBot";
            this.AimBot.Size = new System.Drawing.Size(153, 45);
            this.AimBot.TabIndex = 16;
            this.AimBot.Text = "AimBot";
            this.AimBot.UseVisualStyleBackColor = true;
            this.AimBot.CheckedChanged += new System.EventHandler(this.AimBot_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1943, 1230);
            this.Controls.Add(this.AimBot);
            this.Controls.Add(this.NoDBS);
            this.Controls.Add(this.NoRecoil);
            this.Controls.Add(this.NoReload);
            this.Controls.Add(this.MainWeaponAmmo);
            this.Controls.Add(this.TwoPistolAmmo);
            this.Controls.Add(this.OnePistolStack);
            this.Controls.Add(this.MainWeaponStack);
            this.Controls.Add(this.Granades);
            this.Controls.Add(this.TwoPistolStack);
            this.Controls.Add(this.OnePistolAmmo);
            this.Controls.Add(this.L_TwoPistolStack);
            this.Controls.Add(this.L_Granades);
            this.Controls.Add(this.L_MainWeaponStack);
            this.Controls.Add(this.L_OnePistolStack);
            this.Controls.Add(this.L_TwoPistolAmmo);
            this.Controls.Add(this.L_MainWeaponAmmo);
            this.Controls.Add(this.L_OnePistolAmmo);
            this.Controls.Add(this.IsTwoPistols);
            this.Controls.Add(this.sheild);
            this.Controls.Add(this.L_sheild);
            this.Controls.Add(this.health);
            this.Controls.Add(this.L_health);
            this.Controls.Add(this.InfiniteJumps);
            this.Controls.Add(this.IsProcFound);
            this.Controls.Add(this.gameLabel);
            this.Controls.Add(this.GodMod);
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Assault Cube Trainer v.1.0.1";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox GodMod;
        private System.Windows.Forms.Label gameLabel;
        private System.Windows.Forms.Label IsProcFound;
        private System.Windows.Forms.CheckBox InfiniteJumps;
        private System.Windows.Forms.Label L_health;
        private System.Windows.Forms.TextBox health;
        private System.Windows.Forms.Label L_sheild;
        private System.Windows.Forms.TextBox sheild;
        private System.Windows.Forms.CheckBox IsTwoPistols;
        private System.Windows.Forms.Label L_OnePistolAmmo;
        private System.Windows.Forms.Label L_MainWeaponAmmo;
        private System.Windows.Forms.Label L_TwoPistolAmmo;
        private System.Windows.Forms.Label L_OnePistolStack;
        private System.Windows.Forms.Label L_MainWeaponStack;
        private System.Windows.Forms.Label L_Granades;
        private System.Windows.Forms.Label L_TwoPistolStack;
        private System.Windows.Forms.TextBox OnePistolAmmo;
        private System.Windows.Forms.TextBox TwoPistolStack;
        private System.Windows.Forms.TextBox Granades;
        private System.Windows.Forms.TextBox MainWeaponStack;
        private System.Windows.Forms.TextBox OnePistolStack;
        private System.Windows.Forms.TextBox TwoPistolAmmo;
        private System.Windows.Forms.TextBox MainWeaponAmmo;
        private System.Windows.Forms.CheckBox NoReload;
        private System.Windows.Forms.CheckBox NoRecoil;
        private System.Windows.Forms.CheckBox NoDBS;
        private System.Windows.Forms.CheckBox AimBot;
    }
}