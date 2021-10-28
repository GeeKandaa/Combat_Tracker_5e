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
        public Base()
        {
            InitializeComponent();
            BaseController.Instance.EnsureAutosaveFileIsValid();

            Panel displayPanel = new();
            displayPanel.Dock = DockStyle.Left;
            displayPanel.Width = (int)Math.Floor(Width*0.6);

            combatentDisplay = new();
            displayPanel.Controls.Add(combatentDisplay);
            Controls.Add(displayPanel);

            displayPanel = new();
            displayPanel.Dock = DockStyle.Right;
            displayPanel.Width = (int)Math.Floor(Width * 0.4);

            Button btn = new();
            btn.Name = "btn_Player_New";
            btn.Text = "Add Player";
            btn.Click += HandleButtonClick;
            displayPanel.Controls.Add(btn);

            btn = new();
            btn.Name = "btn_NPC_New";
            btn.Text = "Add NPC";
            btn.Click += HandleButtonClick;
            displayPanel.Controls.Add(btn);

            btn = new();
            btn.Name = "btn_LoadDialog_Load";
            btn.Text = "Load Party";
            btn.Click += HandleButtonClick;
            displayPanel.Controls.Add(btn);

            btn = new();
            btn.Name = "btn_SaveDialog_Save";
            btn.Text = "Save Party";
            btn.Click += HandleButtonClick;
            displayPanel.Controls.Add(btn);

            btn = new();
            btn.Name = "btn_Combat";
            btn.Text = "Start Combat";
            btn.Click += HandleButtonClick;
            displayPanel.Controls.Add(btn);

            btn = new();
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
            UserChooseStartup.Result res = UserChooseStartup.Show();
            if (res.action == null) Application.Exit();
            else
            {
                BaseController.Instance.RegisterDisplay(combatentDisplay);
                BaseController.Instance.HandleAction(res.action, res.path);
            }
            
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
    }
}
