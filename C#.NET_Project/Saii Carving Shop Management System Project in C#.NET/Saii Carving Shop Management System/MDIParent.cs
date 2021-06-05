using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Saii_Carving_Shop_Management_System
{
    public partial class MDIParent : Form
    {
        private int childFormNumber = 0;

        public MDIParent()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void viewAllCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Customer obj = new Add_Customer();
            obj.MdiParent = this; 
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();
        }

        private void addStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Update_Stock obj = new Add_Update_Stock();
            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();

        }

        private void addMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_New_Material obj = new Add_New_Material();
            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();

        }

        private void viewAllCustomerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            View_All_Customer obj = new View_All_Customer();
            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();

            
        }

        private void viewAllMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View_All_Material obj = new View_All_Material();
            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();

        }

        private void viewAllStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View_All_stock obj = new View_All_stock();
            obj.MdiParent = this;
            obj.WindowState = FormWindowState.Maximized;
            obj.Show();


        }


        
    } 
}
