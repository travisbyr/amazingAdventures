﻿using System;
using System.Windows.Forms;

namespace amazingAdventures
{
    public partial class PlayerSettingsForm : Form
    {
        private static readonly PlayerSettingsForm _instance = new PlayerSettingsForm();
        public static PlayerSettingsForm PlayerSettings => _instance;
        static PlayerSettingsForm() { }

        public PlayerSettingsForm()
        {
            InitializeComponent();
        }
        private void closeBtn_Click(object sender, EventArgs e)
        {
            Hide();
            LobbyForm.Lobby.Show();
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you would like to save your details?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if (String.IsNullOrEmpty(settingsEmail.Text) == false)
                {
                    DataAccess.ChangeEmail(Main.M.Username, settingsEmail.Text);
                }
                if (String.IsNullOrEmpty(settingsPassword.Text) == false)
                {
                    DataAccess.ChangePassword(Main.M.Username, settingsPassword.Text);
                }
                MessageBox.Show("Details have been successfully changed", "Details Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Hide();
                LobbyForm.Lobby.Show();
            }
        }
        private void deleteAccountBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you would like to delete your account", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                DataAccess.DeletePlayer(Main.M.Username);
                Hide();
                LoginForm.Login.Show();

            }
        }
    }
}
