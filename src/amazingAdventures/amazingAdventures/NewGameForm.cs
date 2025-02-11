﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace amazingAdventures
{
    public partial class NewGameForm : Form
    {
        private static readonly NewGameForm _instance = new NewGameForm();
        public static NewGameForm NewGame => _instance;
        static NewGameForm() { }

        public NewGameForm()
        {
            InitializeComponent();
        }
        private void cancelGameBtn_Click(object sender, EventArgs e)
        {
            Hide();
        }
        private void createGameBtn_Click(object sender, EventArgs e)
        {
            createGame();
        }
        private void createGame()
        {
            DataAccess.GameCreation(Main.M.Username, gameNameInput.Text);
            if (DataAccess.Message == "gameAlreadyCreated") // If game is created already offer to remove it and create the one the player tried to create
            {
                DialogResult result = MessageBox.Show("You have already created a game.\nWould you like to delete it and create a new one?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (result == DialogResult.Yes)
                {
                    DataAccess.GameClose(Main.M.Username);
                    DataAccess.GameCreation(Main.M.Username, gameNameInput.Text);
                    LobbyForm.Lobby.viewPlayersOnline(); ;
                    Hide();
                }
                else if (result == DialogResult.No)
                {
                    Hide();
                }
            }

            LobbyForm.Lobby.viewPlayersOnline(); ;
            Hide();
        }
    }
}
