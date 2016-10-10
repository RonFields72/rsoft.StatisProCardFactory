namespace rsoft.StatisProCardFactory
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbLeagueInfo = new System.Windows.Forms.GroupBox();
            this.ddlLeague = new System.Windows.Forms.ComboBox();
            this.ddlYear = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbTeamInfo = new System.Windows.Forms.GroupBox();
            this.tbLosses = new System.Windows.Forms.TextBox();
            this.tbWins = new System.Windows.Forms.TextBox();
            this.tbManager = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ddlTeam = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbCardProcessing = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbMinimumAB = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.gbLeagueInfo.SuspendLayout();
            this.gbTeamInfo.SuspendLayout();
            this.gbCardProcessing.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(40, 911);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(107, 23);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Statis-Pro Card Factory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(13, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(566, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Complete the data inputs below and click Upload to process the player/pitcher/fie" +
    "lding data necessary to create cards.";
            // 
            // gbLeagueInfo
            // 
            this.gbLeagueInfo.Controls.Add(this.ddlLeague);
            this.gbLeagueInfo.Controls.Add(this.ddlYear);
            this.gbLeagueInfo.Controls.Add(this.label4);
            this.gbLeagueInfo.Controls.Add(this.label3);
            this.gbLeagueInfo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gbLeagueInfo.Location = new System.Drawing.Point(18, 73);
            this.gbLeagueInfo.Name = "gbLeagueInfo";
            this.gbLeagueInfo.Size = new System.Drawing.Size(560, 99);
            this.gbLeagueInfo.TabIndex = 3;
            this.gbLeagueInfo.TabStop = false;
            this.gbLeagueInfo.Text = "League Information";
            // 
            // ddlLeague
            // 
            this.ddlLeague.CausesValidation = false;
            this.ddlLeague.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlLeague.FormattingEnabled = true;
            this.ddlLeague.Location = new System.Drawing.Point(57, 60);
            this.ddlLeague.Name = "ddlLeague";
            this.ddlLeague.Size = new System.Drawing.Size(135, 21);
            this.ddlLeague.TabIndex = 3;
            // 
            // ddlYear
            // 
            this.ddlYear.CausesValidation = false;
            this.ddlYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlYear.FormattingEnabled = true;
            this.ddlYear.Location = new System.Drawing.Point(57, 30);
            this.ddlYear.Name = "ddlYear";
            this.ddlYear.Size = new System.Drawing.Size(135, 21);
            this.ddlYear.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "League:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Year:";
            // 
            // gbTeamInfo
            // 
            this.gbTeamInfo.Controls.Add(this.tbLosses);
            this.gbTeamInfo.Controls.Add(this.tbWins);
            this.gbTeamInfo.Controls.Add(this.tbManager);
            this.gbTeamInfo.Controls.Add(this.label8);
            this.gbTeamInfo.Controls.Add(this.ddlTeam);
            this.gbTeamInfo.Controls.Add(this.label7);
            this.gbTeamInfo.Controls.Add(this.label6);
            this.gbTeamInfo.Controls.Add(this.label5);
            this.gbTeamInfo.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gbTeamInfo.Location = new System.Drawing.Point(19, 188);
            this.gbTeamInfo.Name = "gbTeamInfo";
            this.gbTeamInfo.Size = new System.Drawing.Size(560, 139);
            this.gbTeamInfo.TabIndex = 4;
            this.gbTeamInfo.TabStop = false;
            this.gbTeamInfo.Text = "Team Information";
            // 
            // tbLosses
            // 
            this.tbLosses.Location = new System.Drawing.Point(69, 101);
            this.tbLosses.Name = "tbLosses";
            this.tbLosses.Size = new System.Drawing.Size(59, 20);
            this.tbLosses.TabIndex = 8;
            this.tbLosses.TextChanged += new System.EventHandler(this.tbLosses_TextChanged);
            // 
            // tbWins
            // 
            this.tbWins.Location = new System.Drawing.Point(69, 75);
            this.tbWins.MaxLength = 3;
            this.tbWins.Name = "tbWins";
            this.tbWins.Size = new System.Drawing.Size(59, 20);
            this.tbWins.TabIndex = 7;
            this.tbWins.TextChanged += new System.EventHandler(this.tbWins_TextChanged);
            // 
            // tbManager
            // 
            this.tbManager.Location = new System.Drawing.Point(69, 49);
            this.tbManager.Name = "tbManager";
            this.tbManager.Size = new System.Drawing.Size(207, 20);
            this.tbManager.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Losses:";
            // 
            // ddlTeam
            // 
            this.ddlTeam.CausesValidation = false;
            this.ddlTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlTeam.FormattingEnabled = true;
            this.ddlTeam.Location = new System.Drawing.Point(69, 22);
            this.ddlTeam.Name = "ddlTeam";
            this.ddlTeam.Size = new System.Drawing.Size(207, 21);
            this.ddlTeam.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Wins:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Manager:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Team:";
            // 
            // gbCardProcessing
            // 
            this.gbCardProcessing.Controls.Add(this.textBox2);
            this.gbCardProcessing.Controls.Add(this.tbMinimumAB);
            this.gbCardProcessing.Controls.Add(this.label10);
            this.gbCardProcessing.Controls.Add(this.label9);
            this.gbCardProcessing.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gbCardProcessing.Location = new System.Drawing.Point(18, 346);
            this.gbCardProcessing.Name = "gbCardProcessing";
            this.gbCardProcessing.Size = new System.Drawing.Size(560, 197);
            this.gbCardProcessing.TabIndex = 5;
            this.gbCardProcessing.TabStop = false;
            this.gbCardProcessing.Text = "Card Processing Configuration";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Minimum # of AB:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Minimum # of IP:";
            // 
            // tbMinimumAB
            // 
            this.tbMinimumAB.Location = new System.Drawing.Point(106, 20);
            this.tbMinimumAB.Name = "tbMinimumAB";
            this.tbMinimumAB.Size = new System.Drawing.Size(100, 20);
            this.tbMinimumAB.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(106, 46);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 985);
            this.Controls.Add(this.gbCardProcessing);
            this.Controls.Add(this.gbTeamInfo);
            this.Controls.Add(this.gbLeagueInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreate);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbLeagueInfo.ResumeLayout(false);
            this.gbLeagueInfo.PerformLayout();
            this.gbTeamInfo.ResumeLayout(false);
            this.gbTeamInfo.PerformLayout();
            this.gbCardProcessing.ResumeLayout(false);
            this.gbCardProcessing.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbLeagueInfo;
        private System.Windows.Forms.ComboBox ddlLeague;
        private System.Windows.Forms.ComboBox ddlYear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbTeamInfo;
        private System.Windows.Forms.TextBox tbLosses;
        private System.Windows.Forms.TextBox tbWins;
        private System.Windows.Forms.TextBox tbManager;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ddlTeam;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbCardProcessing;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox tbMinimumAB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}

