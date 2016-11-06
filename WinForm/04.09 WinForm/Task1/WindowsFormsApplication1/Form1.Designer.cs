namespace WindowsFormsApplication1
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
            this.Coordinate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Coordinate
            // 
            this.Coordinate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Coordinate.AutoSize = true;
            this.Coordinate.BackColor = System.Drawing.SystemColors.Highlight;
            this.Coordinate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Coordinate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Coordinate.Location = new System.Drawing.Point(0, 0);
            this.Coordinate.MaximumSize = new System.Drawing.Size(300, 20);
            this.Coordinate.MinimumSize = new System.Drawing.Size(300, 20);
            this.Coordinate.Name = "Coordinate";
            this.Coordinate.Size = new System.Drawing.Size(300, 20);
            this.Coordinate.TabIndex = 0;
            this.Coordinate.Text = "0. 0";
            this.Coordinate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Coordinate.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Coordinate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.form_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Coordinate;
    }
}

