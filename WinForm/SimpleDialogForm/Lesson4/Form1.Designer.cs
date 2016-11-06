namespace Lesson4
{
    partial class Form1
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
            this.listOfProduct = new System.Windows.Forms.ListBox();
            this.Add = new System.Windows.Forms.Button();
            this.AddAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listOfProduct
            // 
            this.listOfProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listOfProduct.FormattingEnabled = true;
            this.listOfProduct.Location = new System.Drawing.Point(0, 0);
            this.listOfProduct.Name = "listOfProduct";
            this.listOfProduct.Size = new System.Drawing.Size(284, 262);
            this.listOfProduct.TabIndex = 0;
            // 
            // Add
            // 
            this.Add.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Add.Location = new System.Drawing.Point(0, 238);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(284, 24);
            this.Add.TabIndex = 1;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // AddAll
            // 
            this.AddAll.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AddAll.Location = new System.Drawing.Point(0, 215);
            this.AddAll.Name = "AddAll";
            this.AddAll.Size = new System.Drawing.Size(284, 23);
            this.AddAll.TabIndex = 2;
            this.AddAll.Text = "AddAll";
            this.AddAll.UseVisualStyleBackColor = true;
            this.AddAll.Click += new System.EventHandler(this.AddAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.AddAll);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.listOfProduct);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox listOfProduct;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button AddAll;
    }
}

