using CombatTracker5e.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CombatTracker5e.Dialogs
{
    public class UserChooseOrder : Form
    {
        private readonly System.ComponentModel.Container components = null;
        protected Button[] Buttons;
        protected Label label;
        protected Result UserChoice = new();
        public UserChooseOrder()
        {
            Size = new Size(650, 300);

            label = new();
            label.AutoSize = true;
            label.Text = "Some players have the same initiative!\n Who will go first?";
            label.Location = new Point(15, 15);
            Controls.Add(label);
            ControlBox = false;

            Text = "Initiative";
            AutoSize = true;
        }

        private static void ButtonClick(object sender, EventArgs e, ref Stack<int> outputOrder, ref List<int> inputOrder, Form self)
        {
            Button btn = (Button)sender;
            outputOrder.Push(Convert.ToInt32(btn.Name));
            inputOrder.Remove(Convert.ToInt32(btn.Name));
            self.Close();
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

        public static List<int> Show(List<int> inputList)
        {
            Stack<int> newOrderStack = Show(inputList, new Stack<int>());
            List<int> newOrderList = new();
            while (newOrderStack.Count != 0)
            {
                newOrderList.Add(newOrderStack.Pop());
            }
            return newOrderList;
        }

        private static Stack<int> Show(List<int> inputList, Stack<int> outputList=null)
        {
            using UserChooseOrder form = new();
            form.StartPosition = FormStartPosition.CenterParent;

            form.Buttons = new Button[inputList.Count];
            int btnSizeMaxWidth = 0;
            int btnSizeMaxHeight = 0;
            for (int i=0; i<inputList.Count;i++)
            {
                int j = inputList[i];
                Button btn = new();
                btn.AutoSize = true;
                string character = Combatents.Instance.AllCombatents[j].Name;
                btn.Name = j.ToString();
                btn.Text = Combatents.Instance.AllCombatents[j].Name;
                btn.Click += new EventHandler((sender, e) => ButtonClick(sender,e,ref outputList, ref inputList, form));
                btn.Visible = true;
                form.Buttons[i]=btn;
                form.Controls.Add(btn);
                if (btnSizeMaxWidth < btn.Width) btnSizeMaxWidth = btn.Width;
                if (btnSizeMaxHeight < btn.Height) btnSizeMaxHeight = btn.Height;
            }
            
            double widthSeperator = form.ClientRectangle.Width / (double)btnSizeMaxWidth;
            int numColumn = (int)Math.Floor(widthSeperator) - 1;
            if (numColumn > form.Buttons.Length) numColumn = form.Buttons.Length;
            widthSeperator = (form.ClientRectangle.Width / (numColumn!=0?numColumn:1))/(numColumn+1);

            int numRow = (int)Math.Ceiling(form.Buttons.Length / (double)numColumn);
            double heightSeperator = (double)((form.ClientRectangle.Bottom - form.label.Bottom)/2) / numRow;


            for (int i = 0; i < form.Buttons.Length; i++)
            {
                form.Buttons[i].AutoSize = false;
                form.Buttons[i].Width = btnSizeMaxWidth;
                form.Buttons[i].Height = btnSizeMaxHeight;
                form.Buttons[i].Left = (int)widthSeperator * ((i%numColumn)+1) + btnSizeMaxWidth * ((i%numColumn)+1) - btnSizeMaxWidth;
            }
            for (int i = 0; i < form.Buttons.Length; i++)
            {
                form.Buttons[i].Top = form.label.Top + (int)heightSeperator * ((int)Math.Floor(i/(double)numColumn)+1) + form.Buttons[i].Height * ((int)Math.Floor(i / (double)numColumn) + 1);
            }

            form.ShowDialog();

            if (inputList.Count != 1)
            {
                outputList = Show(inputList, outputList);
            }
            else
            {
                outputList.Push(inputList[0]);
            }
            return outputList;
            
        }
        public class Result
        {
            public List<int> outputOrder;
            public List<int> inputOrder;
        }
    }
    
}
