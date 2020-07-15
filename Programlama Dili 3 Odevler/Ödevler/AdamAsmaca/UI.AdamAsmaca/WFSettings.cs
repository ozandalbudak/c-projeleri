using MODEL.AdamAsmaca;
using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Windows.Forms;

namespace UI.AdamAsmaca
{
    public partial class WFSettings : Form
    {
        Keyword keyword = null;
        public WFSettings()
        {
            InitializeComponent();
        }

        #region Methods
        private void LoadData()
        {
            lstWordList.Items.Clear();
            keyword = Program.KEYWORD;
            lstWordList.Items.AddRange(keyword.GetAllWord());
        }
        private void WFSettings_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void lstWordList_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtWord.Text = lstWordList.SelectedItem.ToString();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            foreach (string item in lstWordList.Items)
            {
                if (item == txtWord.Text)
                {
                    MessageBox.Show("Bu kelime zaten mevcut!");
                    return;
                }
            }
            if (keyword.AddWord(txtWord.Text.ToUpper()))
            {
                MessageBox.Show("Kayıt Eklendi.");
            }
            else
            {
                MessageBox.Show("Kayıt Eklenemedi.");
                return;
            }
            LoadData();
            txtWord.Text = "";

        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (keyword.RemoveWord(lstWordList.SelectedIndex+1))
            {
                MessageBox.Show("Kayıt Silindi.");
            }
            else
            {
                MessageBox.Show("Kayıt Silinemedi.");
                return;
            }
            LoadData();
            txtWord.Text = "";
        }
        #endregion


    }
}
