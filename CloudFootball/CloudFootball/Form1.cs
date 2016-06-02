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
                cbx_HomeTeam.ResetText();
                cbx_AwayTeam.ResetText();
                return;
            }
            MessageBox.Show(cbx_HomeTeam.Text + " vs " + cbx_AwayTeam.Text);
                        
        }

        private void cbx_HomeTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_HomeTeam.Text.Equals(cbx_AwayTeam.Text))
            {
                MessageBox.Show(Resources.DifferentHomeAwayTeams, Resources.Error);
                cbx_HomeTeam.ResetText();
            }

            switch (cbx_HomeTeam.Text)
            {
                case "Leicester City":
                    pbx_HomeTeam.Image = Image.FromFile(FilePath + "\\LC_icon.ico");
                    break;
                case "Arsenal":
                    pbx_HomeTeam.Image = Image.FromFile(FilePath + "\\Arsenal_icon.ico");
                    break;
                case "Tottenham Hotspur":
                    pbx_HomeTeam.Image = Image.FromFile(FilePath + "\\TH_icon.ico");
                    break;
                case "Manchester City":
                    pbx_HomeTeam.Image = Image.FromFile(FilePath + "\\MC_icon.ico");
                    break;
                case "Manchester United":
                    pbx_HomeTeam.Image = Image.FromFile(FilePath + "\\MU_icon.ico");
                    break;
                case "Southampton":
                    pbx_HomeTeam.Image = Image.FromFile(FilePath + "\\Southampton_icon.ico");
                    break;
                case "West Ham United":
                    pbx_HomeTeam.Image = Image.FromFile(FilePath + "\\WHU_icon.ico");
                    break;
                case "Liverpool":
                    pbx_HomeTeam.Image = Image.FromFile(FilePath + "\\Liverpool_icon.ico");
                    break;
                case "Stoke City":
                    pbx_HomeTeam.Image = Image.FromFile(FilePath + "\\SC_icon.ico");
                    break;
                case "Chelsea":
                    pbx_HomeTeam.Image = Image.FromFile(FilePath + "\\Chelsea_icon.ico");
                    break;
                case "Everton":
                    pbx_HomeTeam.Image = Image.FromFile(FilePath + "\\Everton_icon.ico");
                    break;
                case "Swansea City":
                    pbx_HomeTeam.Image = Image.FromFile(FilePath + "\\Swansea_icon.ico");
                    break;
                case "Watford":
                    pbx_HomeTeam.Image = Image.FromFile(FilePath + "\\Watford_icon.ico");
                    break;
                case "West Bromwich Albion":
                    pbx_HomeTeam.Image = Image.FromFile(FilePath + "\\WBA_icon.ico");
                    break;
                case "Crystal Palace":
                    pbx_HomeTeam.Image = Image.FromFile(FilePath + "\\CP_icon.ico");
                    break;
                case "AFC Bournemouth":
                    pbx_HomeTeam.Image = Image.FromFile(FilePath + "\\AFCB_icon.ico");
                    break;
                case "Sunderland":
                    pbx_HomeTeam.Image = Image.FromFile(FilePath + "\\Sunderland_icon.ico");
                    break;
                case "Newcastle United":
                    pbx_HomeTeam.Image = Image.FromFile(FilePath + "\\NU_icon.ico");
                    break;
                case "Norwich City":
                    pbx_HomeTeam.Image = Image.FromFile(FilePath + "\\NC_icon.ico");
                    break;
                case "Aston Villa":
                    pbx_HomeTeam.Image = Image.FromFile(FilePath + "\\AV_icon.ico");
                    break;
            }
            pbx_HomeTeam.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void cbx_AwayTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_HomeTeam.Text.Equals(cbx_AwayTeam.Text))
            {
                MessageBox.Show(Resources.DifferentHomeAwayTeams, Resources.Error);
                cbx_AwayTeam.ResetText();
            }

            switch (cbx_AwayTeam.Text)
            {
                case "Leicester City":
                    pbx_AwayTeam.Image = Image.FromFile(FilePath + "\\LC_icon.ico");
                    break;
                case "Arsenal":
                    pbx_AwayTeam.Image = Image.FromFile(FilePath + "\\Arsenal_icon.ico");
                    break;
                case "Tottenham Hotspur":
                    pbx_AwayTeam.Image = Image.FromFile(FilePath + "\\TH_icon.ico");
                    break;
                case "Manchester City":
                    pbx_AwayTeam.Image = Image.FromFile(FilePath + "\\MC_icon.ico");
                    break;
                case "Manchester United":
                    pbx_AwayTeam.Image = Image.FromFile(FilePath + "\\MU_icon.ico");
                    break;
                case "Southampton":
                    pbx_AwayTeam.Image = Image.FromFile(FilePath + "\\Southampton_icon.ico");
                    break;
                case "West Ham United":
                    pbx_AwayTeam.Image = Image.FromFile(FilePath + "\\WHU_icon.ico");
                    break;
                case "Liverpool":
                    pbx_AwayTeam.Image = Image.FromFile(FilePath + "\\Liverpool_icon.ico");
                    break;
                case "Stoke City":
                    pbx_AwayTeam.Image = Image.FromFile(FilePath + "\\SC_icon.ico");
                    break;
                case "Chelsea":
                    pbx_AwayTeam.Image = Image.FromFile(FilePath + "\\Chelsea_icon.ico");
                    break;
                case "Everton":
                    pbx_AwayTeam.Image = Image.FromFile(FilePath + "\\Everton_icon.ico");
                    break;
                case "Swansea City":
                    pbx_AwayTeam.Image = Image.FromFile(FilePath + "\\Swansea_icon.ico");
                    break;
                case "Watford":
                    pbx_AwayTeam.Image = Image.FromFile(FilePath + "\\Watford_icon.ico");
                    break;
                case "West Bromwich Albion":
                    pbx_AwayTeam.Image = Image.FromFile(FilePath + "\\WBA_icon.ico");
                    break;
                case "Crystal Palace":
                    pbx_AwayTeam.Image = Image.FromFile(FilePath + "\\CP_icon.ico");
                    break;
                case "AFC Bournemouth":
                    pbx_AwayTeam.Image = Image.FromFile(FilePath + "\\AFCB_icon.ico");
                    break;
                case "Sunderland":
                    pbx_AwayTeam.Image = Image.FromFile(FilePath + "\\Sunderland_icon.ico");
                    break;
                case "Newcastle United":
                    pbx_AwayTeam.Image = Image.FromFile(FilePath + "\\NU_icon.ico");
                    break;
                case "Norwich City":
                    pbx_AwayTeam.Image = Image.FromFile(FilePath + "\\NC_icon.ico");
                    break;
                case "Aston Villa":
                    pbx_AwayTeam.Image = Image.FromFile(FilePath + "\\AV_icon.ico");
                    break;
            }
            pbx_AwayTeam.SizeMode = PictureBoxSizeMode.StretchImage;

        }    
    }
}
