namespace CloudFootball
{
    partial class FormEpl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEpl));
            this.cbx_HomeTeam = new System.Windows.Forms.ComboBox();
            this.cbx_AwayTeam = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Predict = new System.Windows.Forms.Button();
            this.pbx_AwayTeam = new System.Windows.Forms.PictureBox();
            this.pbx_HomeTeam = new System.Windows.Forms.PictureBox();
            this.pbx_bplLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_AwayTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_HomeTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_bplLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // cbx_HomeTeam
            // 
            this.cbx_HomeTeam.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbx_HomeTeam.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_HomeTeam.FormattingEnabled = true;
            this.cbx_HomeTeam.Items.AddRange(new object[] {
            "Leicester City",
            "Arsenal",
            "Tottenham Hotspur",
            "Manchester City",
            "Manchester United",
            "Southampton",
            "West Ham United",
            "Liverpool",
            "Stoke City",
            "Chelsea",
            "Everton",
            "Swansea City",
            "Watford",
            "West Bromwich Albion",
            "Crystal Palace",
            "AFC Bournemouth",
            "Sunderland",
            "Newcastle United",
            "Norwich City",
            "Aston Villa"});
            this.cbx_HomeTeam.Location = new System.Drawing.Point(1362, 96);
            this.cbx_HomeTeam.Name = "cbx_HomeTeam";
            this.cbx_HomeTeam.Size = new System.Drawing.Size(422, 39);
            this.cbx_HomeTeam.TabIndex = 0;
            this.cbx_HomeTeam.SelectedIndexChanged += new System.EventHandler(this.cbx_HomeTeam_SelectedIndexChanged);
            // 
            // cbx_AwayTeam
            // 
            this.cbx_AwayTeam.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbx_AwayTeam.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbx_AwayTeam.FormattingEnabled = true;
            this.cbx_AwayTeam.Items.AddRange(new object[] {
            "Leicester City",
            "Arsenal",
            "Tottenham Hotspur",
            "Manchester City",
            "Manchester United",
            "Southampton",
            "West Ham United",
            "Liverpool",
            "Stoke City",
            "Chelsea",
            "Everton",
            "Swansea City",
            "Watford",
            "West Bromwich Albion",
            "Crystal Palace",
            "AFC Bournemouth",
            "Sunderland",
            "Newcastle United",
            "Norwich City",
            "Aston Villa"});
            this.cbx_AwayTeam.Location = new System.Drawing.Point(2132, 100);
            this.cbx_AwayTeam.Name = "cbx_AwayTeam";
            this.cbx_AwayTeam.Size = new System.Drawing.Size(422, 39);
            this.cbx_AwayTeam.TabIndex = 1;
            this.cbx_AwayTeam.SelectedIndexChanged += new System.EventHandler(this.cbx_AwayTeam_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1456, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Home Team";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2257, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Away Team";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1941, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "VS";
            // 
            // btn_Predict
            // 
            this.btn_Predict.Location = new System.Drawing.Point(1888, 431);
            this.btn_Predict.Name = "btn_Predict";
            this.btn_Predict.Size = new System.Drawing.Size(189, 62);
            this.btn_Predict.TabIndex = 5;
            this.btn_Predict.Text = "Predict";
            this.btn_Predict.UseVisualStyleBackColor = true;
            this.btn_Predict.Click += new System.EventHandler(this.btn_Predict_Click);
            // 
            // pbx_AwayTeam
            // 
            this.pbx_AwayTeam.Location = new System.Drawing.Point(2241, 187);
            this.pbx_AwayTeam.Name = "pbx_AwayTeam";
            this.pbx_AwayTeam.Size = new System.Drawing.Size(221, 182);
            this.pbx_AwayTeam.TabIndex = 6;
            this.pbx_AwayTeam.TabStop = false;
            // 
            // pbx_HomeTeam
            // 
            this.pbx_HomeTeam.Location = new System.Drawing.Point(1462, 172);
            this.pbx_HomeTeam.Name = "pbx_HomeTeam";
            this.pbx_HomeTeam.Size = new System.Drawing.Size(221, 182);
            this.pbx_HomeTeam.TabIndex = 7;
            this.pbx_HomeTeam.TabStop = false;
            // 
            // pbx_bplLogo
            // 
            this.pbx_bplLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbx_bplLogo.Image")));
            this.pbx_bplLogo.Location = new System.Drawing.Point(25, 32);
            this.pbx_bplLogo.Name = "pbx_bplLogo";
            this.pbx_bplLogo.Size = new System.Drawing.Size(1228, 934);
            this.pbx_bplLogo.TabIndex = 8;
            this.pbx_bplLogo.TabStop = false;
            // 
            // FormEpl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3824, 2037);
            this.Controls.Add(this.pbx_bplLogo);
            this.Controls.Add(this.pbx_HomeTeam);
            this.Controls.Add(this.pbx_AwayTeam);
            this.Controls.Add(this.btn_Predict);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_AwayTeam);
            this.Controls.Add(this.cbx_HomeTeam);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormEpl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EPL Results Predictor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pbx_AwayTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_HomeTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_bplLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_HomeTeam;
        private System.Windows.Forms.ComboBox cbx_AwayTeam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Predict;
        private System.Windows.Forms.PictureBox pbx_AwayTeam;
        private System.Windows.Forms.PictureBox pbx_HomeTeam;
        private System.Windows.Forms.PictureBox pbx_bplLogo;
    }
}

