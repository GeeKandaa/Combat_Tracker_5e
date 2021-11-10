using System;
using System.Drawing;
using System.Windows.Forms;
using CombatTracker5e.Dialogs;
using CombatTracker5e.View;
using System.Collections.Generic;
using CombatTracker5e.Controller;

namespace CombatTracker5e
{
    public partial class Base : Form
    {
        readonly CombatentDisplay combatentDisplay;
        private string Mode = "Peace";
        private readonly string AutoSaveInfo;

        protected Button buttonAddPlayer;
        protected Button buttonAddNPC;
        protected Button buttonSave;
        protected Button buttonLoad;
        protected Button buttonCombat;
        public Base()
        {
            InitializeComponent();
            AutoSaveInfo = BaseController.Instance.EnsureAutosaveFileIsValid();

            Panel displayPanel = new();
            displayPanel.Dock = DockStyle.Left;
            displayPanel.Width = (int)Math.Floor(Width*0.6);

            combatentDisplay = new();
            displayPanel.Controls.Add(combatentDisplay);
            Controls.Add(displayPanel);

            displayPanel = new();
            displayPanel.Dock = DockStyle.Right;
            displayPanel.Width = (int)Math.Floor(Width * 0.4);

            buttonAddPlayer = new();
            buttonAddPlayer.Name = "btn_Player_New";
            buttonAddPlayer.Text = "Add Player";
            buttonAddPlayer.Click += HandleButtonClick;
            displayPanel.Controls.Add(buttonAddPlayer);

            buttonAddNPC = new();
            buttonAddNPC.Name = "btn_NPC_New";
            buttonAddNPC.Text = "Add NPC";
            buttonAddNPC.Click += HandleButtonClick;
            displayPanel.Controls.Add(buttonAddNPC);

            buttonLoad = new();
            buttonLoad.Name = "btn_LoadDialog_Load";
            buttonLoad.Text = "Load Party";
            buttonLoad.Click += HandleButtonClick;
            displayPanel.Controls.Add(buttonLoad);

            buttonSave = new();
            buttonSave.Name = "btn_SaveDialog_Save";
            buttonSave.Text = "Save Party";
            buttonSave.Click += HandleButtonClick;
            displayPanel.Controls.Add(buttonSave);

            buttonCombat = new();
            buttonCombat.Name = "btn_Combat";
            buttonCombat.Text = "Start Combat";
            buttonCombat.Click += HandleButtonClick;
            displayPanel.Controls.Add(buttonCombat);

            Button btn = new();
            btn.Name = "btn_Char_Flee";
            btn.Text = "Flee";
            btn.Click += HandleButtonClick;
            displayPanel.Controls.Add(btn);

            btn = new();
            btn.Name = "btn_Char_Damage";
            btn.Text = "Damage";
            btn.Click += HandleButtonClick;
            displayPanel.Controls.Add(btn);

            btn = new();
            btn.Name = "btn_Char_Heal";
            btn.Text = "Heal";
            btn.Click += HandleButtonClick;
            displayPanel.Controls.Add(btn);

            btn = new();
            btn.Name = "btn_Char_Stun";
            btn.Text = "Stun";
            btn.Click += HandleButtonClick;
            displayPanel.Controls.Add(btn);

            btn = new();
            btn.Name = "btn_Char_Concentrating";
            btn.Text = "Concentrate";
            btn.Click += HandleButtonClick;
            displayPanel.Controls.Add(btn);

            Controls.Add(displayPanel);

            int btnHeight = (displayPanel.Height-30) / (displayPanel.Controls.Count / 2);
            int btnWidth = (displayPanel.Width-45) / 2;
            for (int i = 0; i < displayPanel.Controls.Count; i++)
            {
                displayPanel.Controls[i].Height = btnHeight;
                displayPanel.Controls[i].Width = btnWidth;
                displayPanel.Controls[i].Location = new Point(((i % 2) * btnWidth)+30, ((int)Math.Floor(i / 2.0)*btnHeight)+15);
            }
        }

        public void SwitchMode() 
        {
            if (Mode == "Peace")
            {
                Mode = "War";
                buttonAddPlayer.Name = "btn_EndTurn";
                buttonAddPlayer.Text = "End Turn";
                buttonAddPlayer.BackColor = Color.PaleTurquoise;
                buttonCombat.Name = "btn_EndCombat";
                buttonCombat.BackColor = Color.LightSalmon;
                buttonCombat.Text = "End Combat";
                buttonAddNPC.Visible = false;
                buttonSave.Visible = false;
                buttonLoad.Visible = false;
            }else if (Mode == "War")
            {
                Mode = "Peace";
                buttonAddPlayer.Name = "btn_Player_New";
                buttonAddPlayer.Text = "Add Player";
                buttonAddPlayer.BackColor = Color.LavenderBlush;
                buttonCombat.Name = "btn_Combat";
                buttonCombat.BackColor = Color.LavenderBlush;
                buttonCombat.Text = "Start Combat";
                buttonAddNPC.Visible = true;
                buttonSave.Visible = true;
                buttonLoad.Visible = true;
            }

    
        }
        private string[] ActionFromString(string cmd)
        {
            string[] commands = cmd.Split('_');
            if (commands.Length > 2)
            {
                switch (commands[1])
                {
                    case "SaveDialog":
                        string savepath = Dialogs.Save.Show();
                        if (savepath != "") return new string[] { commands[2], savepath };
                        return new string[] { "", "" };
                    case "LoadDialog":
                        string loadpath = Dialogs.Load.Show();
                        if(loadpath!="") return new string[] { commands[2], loadpath };
                        return new string[] { "", "" };
                    case "Char":
                        if (combatentDisplay.Rows[0].Cells[1].Value == null) break;
                        return new string[] { commands[2], GetSelectedRows() };
                    case "Player" or "NPC":
                        return new string[] { commands[2], commands[1] };
                }
                return new string[] { "stop", "" };
            }
            return new string[] { commands[1], "" };
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UserChooseStartup.Result res = UserChooseStartup.Show(AutoSaveInfo);
            if (res.action == null) Application.Exit();
            else
            {
                BaseController.Instance.RegisterMain(this);
                BaseController.Instance.RegisterDisplay(combatentDisplay);
                BaseController.Instance.HandleAction(res.action, res.path);
            }
            BaseController.Instance.CanSave = true;
            return;
        }
        private string GetSelectedRows()
        {
            DataGridViewSelectedRowCollection selectedRows = combatentDisplay.SelectedRows;
            int[] orderedRows = new int[selectedRows.Count];
            for (int i=0;i<selectedRows.Count;i++)
            {
               orderedRows[i] += selectedRows[i].Index;
            }
            Array.Sort(orderedRows);
            string selected = "";
            foreach (int i in orderedRows)
            {
                selected += i.ToString() + ',';
            }
            return selected[..(selected.Length-1)];
        }
        private void HandleButtonClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string[] action = ActionFromString(btn.Name);
            if (action[0]!="stop") BaseController.Instance.HandleAction(action[0],action[1]);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (BaseController.Instance.CanSave) BaseController.Instance.HandleAction("Save", BaseController.Instance.AutoSaveFile);
        }
    }
}
