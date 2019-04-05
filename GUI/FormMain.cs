using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sCThuattoanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkCyan;
            this.menuStrip1.BackgroundImage = global::GUI.Properties.Resources.landscape_art_moon_127187_1366x768;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.sCThuattoanToolStripMenuItem,
            this.attackToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1203, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 23);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // sCThuattoanToolStripMenuItem
            // 
            this.sCThuattoanToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sCThuattoanToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.sCThuattoanToolStripMenuItem.Name = "sCThuattoanToolStripMenuItem";
            this.sCThuattoanToolStripMenuItem.Size = new System.Drawing.Size(137, 23);
            this.sCThuattoanToolStripMenuItem.Text = "SC_Thuattoan";
            this.sCThuattoanToolStripMenuItem.Click += new System.EventHandler(this.sCThuattoanToolStripMenuItem_Click);
            // 
            // attackToolStripMenuItem
            // 
            this.attackToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attackToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Window;
            this.attackToolStripMenuItem.Name = "attackToolStripMenuItem";
            this.attackToolStripMenuItem.Size = new System.Drawing.Size(75, 23);
            this.attackToolStripMenuItem.Text = "Attack";
            this.attackToolStripMenuItem.Click += new System.EventHandler(this.attackToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1203, 555);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Attack_05";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        
        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormFile fe = new FormFile();
            fe.MdiParent = this;
            fe.Show();
        }

        private void sCThuattoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSC fs = new FormSC();
            fs.MdiParent = this;
            fs.Show();
        }

        private void attackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAttack fa = new FormAttack();
            fa.MdiParent = this;
            fa.Show();
        }
    }
}
