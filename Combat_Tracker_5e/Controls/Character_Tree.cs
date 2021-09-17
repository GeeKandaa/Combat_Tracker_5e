using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Combat_Tracker_5e
{
    class Character_Tree : TreeView
    {
        TreeNode PlayerNode = new();
        TreeNode NpcNode = new();
        public Character_Tree() 
        {
            PlayerNode.Text = "Players";
            NpcNode.Text = "NPCs";
            this.Nodes.Add(PlayerNode);
            this.Nodes.Add(NpcNode);

            
        }

        protected override void OnDrawNode(DrawTreeNodeEventArgs e)
        {
            base.OnDrawNode(e);
            ExpandAll();
        }

        public void Cleanup()
        {
            this.Nodes.Clear();
        }

    }
}
