using CombatTracker5e.Controller;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CombatTracker5e.Dialogs
{
    class UserChooseStartup : Form
    {
        protected Button ButtonAuto;
        protected Button ButtonNew;
        protected Button ButtonLoad;
        protected List<Button> Buttons;
        protected Label LabelPrompt;
        protected Result UserChoice = new();
        private readonly System.ComponentModel.Container components = null;
        private UserChooseStartup()
        {
            Size FormSize = new(700, 300);

            // Text
            LabelPrompt = new();
            LabelPrompt.AutoSize = true;
            LabelPrompt.Location = new Point(15, 15);
            LabelPrompt.Text = "prompt";

            // Buttons
            ButtonNew = new();
            ButtonNew.Name = "buttonNew";
            ButtonNew.Text = "New Party";
            ButtonNew.Click += new EventHandler((sender, e) => NewButtonClick(sender, e, "New"));
            
            ButtonAuto = new();
            ButtonAuto.Name = "buttonAuto";
            ButtonAuto.Text = "Load Autosave";
            ButtonAuto.Click += new EventHandler((sender, e) => AutoButtonClick(sender, e, "Auto"));
            
            ButtonLoad = new();
            ButtonLoad.Name = "buttonLoad";
            ButtonLoad.Text = "Load Party..";
            ButtonLoad.Click += new EventHandler((sender, e) => LoadButtonClick(sender, e, "Load"));
            Buttons = new() { ButtonNew, ButtonAuto, ButtonLoad };

            for (int i = 0; i < Buttons.Count; i++)
            {
                if (i > 1) Buttons[i].DialogResult = DialogResult.None;
                Buttons[i].TabIndex = i;
            }

            Name = "UserChooseStartupDialog";
            Text = "title";
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = FormSize;

            for (int i = 0; i < Buttons.Count; i++)
            {
                int margin = 50;
                Buttons[i].Size = new Size(FormSize.Width / (Buttons.Count + 2), 50);

                int leftLocation = (i + 1) * (FormSize.Width / (Buttons.Count + 2)) - ((Buttons.Count - 1) * margin) / 2;
                int topLocation = FormSize.Height - ((3 * Buttons[i].Height) / 2);

                Buttons[i].Location = new Point(leftLocation + i * margin, topLocation);
            }

            Controls.AddRange
            (
                new Control[]
                {
                    LabelPrompt,
                    ButtonNew,
                    ButtonAuto,
                    ButtonLoad
                }
            );
        }

        private void LoadButtonClick(object sender, EventArgs e, string buttonName)
        {
            if (sender is null)
            {
                throw new ArgumentNullException(nameof(sender));
            }

            if (e is null)
            {
                throw new ArgumentNullException(nameof(e));
            }

            using OpenFileDialog dialog = new();
            string path = Dialogs.Load.Show();
            if (path != string.Empty)
            {
                UserChoice.action = buttonName;
                UserChoice.path = path;
                this.Close();
            }
        }
        private void AutoButtonClick(object sender, EventArgs e, string buttonName)
        {
            if (sender is null)
            {
                throw new ArgumentNullException(nameof(sender));
            }

            if (e is null)
            {
                throw new ArgumentNullException(nameof(e));
            }

            UserChoice.action = buttonName;
            UserChoice.path = BaseController.Instance.AutoSaveFile;
            this.Close();
        }
        private void NewButtonClick(object sender, EventArgs e, string buttonName)
        {
            if (sender is null)
            {
                throw new ArgumentNullException(nameof(sender));
            }

            if (e is null)
            {
                throw new ArgumentNullException(nameof(e));
            }

            UserChoice.action = buttonName;
            UserChoice.path = "Player";
            this.Close();
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
        public static new Result Show()
        {
            using UserChooseStartup form = new();
            form.Text = "Choose Party";
            string autofile = BaseController.Instance.AutoSaveFile;
            form.LabelPrompt.Text = $"Please choose how to start the program:\n\n The current autosaved file is located at:\n  {autofile}";
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();

            return form.UserChoice;
        }
        public class Result
        {
            public string action;
            public string path;
        }
    }
}
