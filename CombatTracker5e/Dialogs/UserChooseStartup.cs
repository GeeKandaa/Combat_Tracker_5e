using CombatTracker5e.Controller;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CombatTracker5e.Dialog
{
    class UserChooseStartup : Form
    {
        protected Button buttonAuto;
        protected Button buttonNew;
        protected Button buttonLoad;
        protected List<Button> buttons;
        protected Label labelPrompt;
        protected Result UserChoice = new();
        protected ErrorProvider errorProviderText;
        private readonly System.ComponentModel.Container components = null;
        private UserChooseStartup()
        {
            Size formSize = new(700, 300);

            // Text
            labelPrompt = new();
            labelPrompt.AutoSize = true;
            labelPrompt.Location = new Point(15, 15);
            labelPrompt.Text = "prompt";

            // Buttons
            buttonNew = new();
            buttonNew.Name = "buttonNew";
            buttonNew.Text = "New Party";
            buttonNew.Click += new EventHandler((sender, e) => NewButtonClick(sender, e, "New"));
            buttonAuto = new();
            buttonAuto.Name = "buttonAuto";
            buttonAuto.Text = "Load Autosave";
            buttonAuto.Click += new EventHandler((sender, e) => AutoButtonClick(sender, e, "Auto"));
            buttonLoad = new();
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Text = "Load Party..";
            buttonLoad.Click += new EventHandler((sender, e) => LoadButtonClick(sender, e, "Load"));
            buttons = new() { buttonNew, buttonAuto, buttonLoad };

            errorProviderText = new();

            for (int i = 0; i < buttons.Count; i++)
            {
                if (i > 1) buttons[i].DialogResult = DialogResult.None;
                buttons[i].TabIndex = i;
            }

            Name = "UserChooseStartupDialog";
            Text = "title";
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = formSize;

            for (int i = 0; i < buttons.Count; i++)
            {
                int margin = 50;
                buttons[i].Size = new Size(formSize.Width / (buttons.Count + 2), 50);

                int leftLocation = (i + 1) * (formSize.Width / (buttons.Count + 2)) - ((buttons.Count - 1) * margin) / 2;
                int topLocation = formSize.Height - ((3 * buttons[i].Height) / 2);

                buttons[i].Location = new Point(leftLocation + i * margin, topLocation);
            }

            Controls.AddRange
            (
                new Control[]
                {
                    labelPrompt,
                    buttonNew,
                    buttonAuto,
                    buttonLoad
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

            using (OpenFileDialog dialog = new())
            {
                dialog.InitialDirectory = BaseController.Instance.AutoSaveDirectory;
                dialog.Filter = "Text files (*.txt)|*.txt";
                dialog.RestoreDirectory = true;

                if(dialog.ShowDialog() == DialogResult.OK)
                {
                    UserChoice.action = buttonName;
                    UserChoice.path = dialog.FileName;
                    this.Close();
                }
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
            UserChoice.path = null;
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
        public static Result Show(Point? spawnLocation)
        {
            using UserChooseStartup form = new();
            form.Text = "Choose Party";
            string autofile = BaseController.Instance.AutoSaveFile;
            form.labelPrompt.Text = $"Please choose how to start the program:\n\n The current autosaved file is located at:\n  {autofile}";
            if (spawnLocation == null)
            {
                form.StartPosition = FormStartPosition.CenterParent;
            }

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
