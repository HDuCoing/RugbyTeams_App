
namespace RugbyApp
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.time_And_Date = new System.Windows.Forms.Label();
            this.load = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.players = new System.Windows.Forms.Button();
            this.teams = new System.Windows.Forms.Button();
            this.credit = new System.Windows.Forms.Label();
            this.myOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.mySaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.time_And_Date);
            this.panel1.Controls.Add(this.load);
            this.panel1.Controls.Add(this.save);
            this.panel1.Controls.Add(this.players);
            this.panel1.Controls.Add(this.teams);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(161, 692);
            this.panel1.TabIndex = 0;
            // 
            // time_And_Date
            // 
            this.time_And_Date.AutoSize = true;
            this.time_And_Date.Location = new System.Drawing.Point(9, 668);
            this.time_And_Date.Name = "time_And_Date";
            this.time_And_Date.Size = new System.Drawing.Size(30, 13);
            this.time_And_Date.TabIndex = 4;
            this.time_And_Date.Text = "Time";
            this.time_And_Date.Click += new System.EventHandler(this.time_And_Date_Click);
            // 
            // load
            // 
            this.load.Location = new System.Drawing.Point(3, 135);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(107, 31);
            this.load.TabIndex = 3;
            this.load.Text = "Load Data Archive";
            this.load.UseVisualStyleBackColor = true;
            this.load.Click += new System.EventHandler(this.loadData_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(3, 97);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(107, 32);
            this.save.TabIndex = 2;
            this.save.Text = "Save Data Archive";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.saveData_Click);
            // 
            // players
            // 
            this.players.Location = new System.Drawing.Point(3, 61);
            this.players.Name = "players";
            this.players.Size = new System.Drawing.Size(107, 30);
            this.players.TabIndex = 1;
            this.players.Text = "Players";
            this.players.UseVisualStyleBackColor = true;
            this.players.Click += new System.EventHandler(this.players_Click);
            // 
            // teams
            // 
            this.teams.Location = new System.Drawing.Point(3, 24);
            this.teams.Name = "teams";
            this.teams.Size = new System.Drawing.Size(107, 31);
            this.teams.TabIndex = 0;
            this.teams.Text = "Teams";
            this.teams.UseVisualStyleBackColor = true;
            this.teams.Click += new System.EventHandler(this.teams_Click);
            // 
            // credit
            // 
            this.credit.AutoSize = true;
            this.credit.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.credit.Location = new System.Drawing.Point(168, 671);
            this.credit.Name = "credit";
            this.credit.Size = new System.Drawing.Size(180, 13);
            this.credit.TabIndex = 4;
            this.credit.Text = "2021 Rugby League - Holly DuCoing";
            // 
            // myOpenFileDialog
            // 
            this.myOpenFileDialog.FileName = "myOpenFileDialog";
            this.myOpenFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.myOpenFileDialogue_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(940, 693);
            this.Controls.Add(this.credit);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button teams;
        private System.Windows.Forms.Button load;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button players;
        private System.Windows.Forms.Label credit;
        private System.Windows.Forms.Label time_And_Date;
        private System.Windows.Forms.OpenFileDialog myOpenFileDialog;
        private System.Windows.Forms.SaveFileDialog mySaveFileDialog;
    }
}

