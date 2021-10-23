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
        protected string UserChoice;
        protected ErrorProvider errorProviderText;
        private readonly System.ComponentModel.Container components = null;
        private UserChooseStartup()
        {
            Size formSize = new(800, 300);
           
            // Text
            labelPrompt = new();
            labelPrompt.AutoSize = true;
            labelPrompt.Location = new Point(15, 15);
            labelPrompt.Text = "prompt";

            // Buttons
            buttonNew = new();
            buttonNew.Name = "buttonNew";
            buttonNew.Text = "New Party";
            buttonNew.AutoSize = true;
            buttonAuto = new();
            buttonAuto.Name = "buttonAuto";
            buttonAuto.Text = "Load Autosave";
            buttonNew.AutoSize = true;
            buttonLoad = new();
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Text = "Load Party..";
            buttonNew.AutoSize = true;
            buttons = new() { buttonNew, buttonAuto, buttonLoad };

            errorProviderText = new();

            for (int i = 0; i < buttons.Count; i++)
            {
                if (i > 1) buttons[i].DialogResult = DialogResult.None;
                buttons[i].TabIndex = i;
                string Arg = buttons[i].Name;
                buttons[i].Click += new EventHandler((sender, e) => ButtonClick(sender, e, Arg));
                
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

                int leftLocation = (i + 1) * (formSize.Width / (buttons.Count + 2))- ((buttons.Count-1) * margin)/2;
                int topLocation = formSize.Height - ((3*buttons[i].Height)/2);

                buttons[i].Location = new Point(leftLocation+i*margin, topLocation);
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

        private void ButtonClick(object sender, EventArgs e, string buttonName) 
        {
            if (sender is null)
            {
                throw new ArgumentNullException(nameof(sender));
            }

            if (e is null)
            {
                throw new ArgumentNullException(nameof(e));
            }

            UserChoice = buttonName;
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
        public static string Show(Point? spawnLocation)
        {
            using UserChooseStartup form = new();
            form.Text = "Choose Party";
            form.labelPrompt.Text = "Please choose how to start the program.";
            if (spawnLocation == null)
            {
                form.StartPosition = FormStartPosition.CenterParent;
            }

            form.ShowDialog();

            return form.UserChoice;
        }
    }
}
