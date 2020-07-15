using MODEL.AdamAsmaca;
using System;
using System.Windows.Forms;

namespace UI.AdamAsmaca
{
    public partial class WFScoreList : Form
    {
        Score score = null;
        public WFScoreList()
        {
            InitializeComponent();
            score = Program.SCORE;
        }
    
        private void WFScoreList_Load(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(score.GetScore());
        }
    }
}
