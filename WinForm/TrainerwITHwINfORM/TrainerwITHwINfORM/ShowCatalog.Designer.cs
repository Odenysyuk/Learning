namespace TrainerwITHwINfORM
{
    partial class ShowCatalog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.tPath = new System.Windows.Forms.TextBox();
            this.bOpenFolder = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bOpenFolder);
            this.panel1.Controls.Add(this.tPath);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(699, 26);
            this.panel1.TabIndex = 0;
            // 
            // tPath
            // 
            this.tPath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tPath.Enabled = false;
            this.tPath.Location = new System.Drawing.Point(0, 3);
            this.tPath.Name = "tPath";
            this.tPath.Size = new System.Drawing.Size(545, 20);
            this.tPath.TabIndex = 0;
            // 
            // bOpenFolder
            // 
            this.bOpenFolder.Dock = System.Windows.Forms.DockStyle.Right;
            this.bOpenFolder.Location = new System.Drawing.Point(551, 0);
            this.bOpenFolder.Name = "bOpenFolder";
            this.bOpenFolder.Size = new System.Drawing.Size(148, 26);
            this.bOpenFolder.TabIndex = 1;
            this.bOpenFolder.Text = "Open folder";
            this.bOpenFolder.UseVisualStyleBackColor = true;
            this.bOpenFolder.Click += new System.EventHandler(this.bOpenFolder_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(258, 551);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.treeView1);
            this.panel3.Location = new System.Drawing.Point(264, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(435, 548);
            this.panel3.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(258, 551);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(435, 548);
            this.treeView1.TabIndex = 0;
            // 
            // ShowCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 577);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ShowCatalog";
            this.Text = "Catalog";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bOpenFolder;
        private System.Windows.Forms.TextBox tPath;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TreeView treeView1;
    }
}

