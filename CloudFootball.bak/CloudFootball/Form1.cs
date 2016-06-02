using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using CloudFootball.Properties;

namespace CloudFootball
{
    public partial class FormEpl : Form
    {
        //public string FilePath = Directory.GetCurrentDirectory() + "\\res";
        public string FilePath = Directory.GetCurrentDirectory();
        public FormEpl()
        {
            InitializeComponent();
            MaximumSize = new Size(1000, 480);
            pbx_bplLogo.Image = Image.FromFile(FilePath + "\\Bpl_icon.ico");
            pbx_bplLogo.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public sealed override Size MaximumSize
        {
            get { return base.MaximumSize; }
            set { base.MaximumSize = value; }
        }

        private void btn_Predict_Click(object sender, EventArgs e)
        {
            if (cbx_HomeTeam.Text.Equals(cbx_AwayTeam.Text))
            {
                MessageBox.Show(Resources.DifferentHomeAwayTeams, Resources.Error);
                cbx_AwayTeam.ResetText();
                return;
            }
            MessageBox.Show(cbx_HomeTeam.Text + " vs " + cbx_AwayTeam.Text);
                        
        }

        private void cbx_HomeTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_HomeTeam.Text.Equals("Manchester United"))
            {
                pbx_HomeTeam.Image = Image.FromFile(FilePath + "\\ManU_icon.ico");
                pbx_HomeTeam.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            /*            
                Leicester City
                Arsenal
                Tottenham Hotspur
                Manchester City
                Manchester United
                Southampton
                West Ham United
                Liverpool
                Stoke City
                Chelsea         
                Everton
                Swansea City
                Watford
                West Bromwich Albion
                Crystal Palace
                AFC Bournemouth
                Sunderland
                Newcastle United
                Norwich City
                Aston Villa
             */

        }

        private void cbx_AwayTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_HomeTeam.Text.Equals(cbx_AwayTeam.Text))
            {
                MessageBox.Show(Resources.DifferentHomeAwayTeams, Resources.Error);
                cbx_AwayTeam.ResetText();
            }
            if (cbx_AwayTeam.Text.Equals("Manchester United"))
            {
                pbx_AwayTeam.Image = Image.FromFile(FilePath + "\\ManU_icon.ico");
                pbx_AwayTeam.SizeMode = PictureBoxSizeMode.StretchImage;
            }                
        }    
    }
}
