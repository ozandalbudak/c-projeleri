using System.Windows.Forms;
using UI.AdamAsmaca;

namespace UI
{
    public partial class WFMain : Form
    {
        #region Properties
        #endregion

        #region Methods
        public WFMain()
        {
            InitializeComponent();
        }
        #endregion

        #region Events
        private void WFMain_Load(object sender, System.EventArgs e)
        {
            comboBoxOperant.SelectedIndex = 0;
        }

        private void btnStartGame_Click(object sender, System.EventArgs e)
        {
            WFGamePlay wfGame = null;
            switch (comboBoxOperant.SelectedIndex)
            {
                case 0:
                    wfGame = new WFGamePlay();
                    break;
                case 1:
                    wfGame = new WFGamePlay("+");
                    break;
                case 2:
                    wfGame = new WFGamePlay("-");
                    break;
                case 3:
                    wfGame = new WFGamePlay("*");
                    break;
                case 4:
                    wfGame = new WFGamePlay("/");
                    break;
                default:
                    wfGame = new WFGamePlay();
                    break;
            }
            this.Hide();
            wfGame.Show();
        }
        private void btnExit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        private void btnCont_Click(object sender, System.EventArgs e)
        {
            WFScoreList skorListesi = new WFScoreList();
            skorListesi.ShowDialog();
        }
    }
}
