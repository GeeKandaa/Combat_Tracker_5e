using System.Windows.Forms;

namespace Combat_Tracker_5e
{
    class Character_Tree : TreeView
    {
        TreeNode PlayerNode = new();
        TreeNode NpcNode = new();
        TreeNode ActiveNode;
        public Character_Tree() 
        {
            PlayerNode.Text = "Players";
            NpcNode.Text = "NPCs";
            this.Nodes.Add(PlayerNode);
            this.Nodes.Add(NpcNode);

            
        }
        public void Populate_Players()
        {
            PlayerNode.Nodes.Clear();
            foreach (string name in Manager.Instance.Party_List())
            {
                PlayerNode.Nodes.Add(name);
            }
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

        protected override void OnBeforeCheck(TreeViewCancelEventArgs e)
        {
            base.OnBeforeCheck(e);
            if (!(e.Node==ActiveNode)) e.Cancel = true;
        }
    }
}
