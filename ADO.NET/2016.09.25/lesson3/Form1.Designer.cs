namespace AnimalsApplication
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ListOfAnimals = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSplitButton();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListOfAnimal = new System.Windows.Forms.CheckedListBox();
            this.Add = new System.Windows.Forms.Button();
            this.Remove = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Param = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LabBreed = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.LabAge = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioMale = new System.Windows.Forms.RadioButton();
            this.radioFemale = new System.Windows.Forms.RadioButton();
            this.LabSex = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.LabAlias = new System.Windows.Forms.Label();
            this.RadDog = new System.Windows.Forms.RadioButton();
            this.RadFish = new System.Windows.Forms.RadioButton();
            this.RadChicken = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ageOfAnimal = new System.Windows.Forms.NumericUpDown();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.numberOfFood = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.toEat = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.ListOfAnimals.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.Param.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ageOfAnimal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfFood)).BeginInit();
            this.SuspendLayout();
            // 
            // ListOfAnimals
            // 
            this.ListOfAnimals.Controls.Add(this.statusStrip1);
            this.ListOfAnimals.Controls.Add(this.ListOfAnimal);
            this.ListOfAnimals.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.ListOfAnimals.Dock = System.Windows.Forms.DockStyle.Left;
            this.ListOfAnimals.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ListOfAnimals.Location = new System.Drawing.Point(0, 0);
            this.ListOfAnimals.Name = "ListOfAnimals";
            this.ListOfAnimals.Size = new System.Drawing.Size(506, 434);
            this.ListOfAnimals.TabIndex = 0;
            this.ListOfAnimals.TabStop = false;
            this.ListOfAnimals.Text = "List of animals:";
            this.ListOfAnimals.UseCompatibleTextRendering = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripSplitButton1});
            this.statusStrip1.Location = new System.Drawing.Point(3, 409);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(500, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            this.toolTip1.SetToolTip(this.statusStrip1, "Save our changing");
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem});
            this.toolStripSplitButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton1.Image")));
            this.toolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(54, 20);
            this.toolStripSplitButton1.Text = "Menu";
            this.toolStripSplitButton1.ToolTipText = "Menu";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // ListOfAnimal
            // 
            this.ListOfAnimal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListOfAnimal.FormattingEnabled = true;
            this.ListOfAnimal.Location = new System.Drawing.Point(3, 16);
            this.ListOfAnimal.Name = "ListOfAnimal";
            this.ListOfAnimal.Size = new System.Drawing.Size(500, 415);
            this.ListOfAnimal.TabIndex = 2;
            this.toolTip1.SetToolTip(this.ListOfAnimal, "Show list of animals, which was added");
            // 
            // Add
            // 
            this.Add.Dock = System.Windows.Forms.DockStyle.Top;
            this.Add.Location = new System.Drawing.Point(506, 0);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(252, 23);
            this.Add.TabIndex = 1;
            this.Add.Text = "Add";
            this.toolTip1.SetToolTip(this.Add, "Add new animal to list");
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Remove
            // 
            this.Remove.Dock = System.Windows.Forms.DockStyle.Top;
            this.Remove.Location = new System.Drawing.Point(506, 23);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(252, 23);
            this.Remove.TabIndex = 2;
            this.Remove.Text = "Remove";
            this.toolTip1.SetToolTip(this.Remove, "Remove selected animal of list");
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // Edit
            // 
            this.Edit.Dock = System.Windows.Forms.DockStyle.Top;
            this.Edit.Location = new System.Drawing.Point(506, 46);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(252, 23);
            this.Edit.TabIndex = 3;
            this.Edit.Text = "Edit";
            this.toolTip1.SetToolTip(this.Edit, "Edit all cheked animals of list");
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Param
            // 
            this.Param.Controls.Add(this.progressBar1);
            this.Param.Controls.Add(this.toEat);
            this.Param.Controls.Add(this.label1);
            this.Param.Controls.Add(this.numberOfFood);
            this.Param.Controls.Add(this.groupBox6);
            this.Param.Controls.Add(this.groupBox5);
            this.Param.Controls.Add(this.groupBox4);
            this.Param.Controls.Add(this.groupBox3);
            this.Param.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Param.Location = new System.Drawing.Point(506, 115);
            this.Param.Name = "Param";
            this.Param.Size = new System.Drawing.Size(252, 319);
            this.Param.TabIndex = 4;
            this.Param.TabStop = false;
            this.Param.Text = "Param";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBox1);
            this.groupBox6.Controls.Add(this.LabBreed);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox6.Location = new System.Drawing.Point(3, 142);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(246, 45);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(38, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 20);
            this.textBox1.TabIndex = 2;
            this.toolTip1.SetToolTip(this.textBox1, "Enter breed\'s animal");
            // 
            // LabBreed
            // 
            this.LabBreed.AutoSize = true;
            this.LabBreed.Dock = System.Windows.Forms.DockStyle.Left;
            this.LabBreed.Location = new System.Drawing.Point(3, 16);
            this.LabBreed.Name = "LabBreed";
            this.LabBreed.Size = new System.Drawing.Size(35, 13);
            this.LabBreed.TabIndex = 1;
            this.LabBreed.Text = "Breed";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.ageOfAnimal);
            this.groupBox5.Controls.Add(this.LabAge);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Location = new System.Drawing.Point(3, 105);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(246, 37);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            // 
            // LabAge
            // 
            this.LabAge.AutoSize = true;
            this.LabAge.Dock = System.Windows.Forms.DockStyle.Left;
            this.LabAge.Location = new System.Drawing.Point(3, 16);
            this.LabAge.Name = "LabAge";
            this.LabAge.Size = new System.Drawing.Size(26, 13);
            this.LabAge.TabIndex = 1;
            this.LabAge.Text = "Age";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Controls.Add(this.LabSex);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(3, 54);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(246, 51);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioMale);
            this.groupBox2.Controls.Add(this.radioFemale);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(28, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 32);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox2, "Choose sex of animals");
            // 
            // radioMale
            // 
            this.radioMale.AutoSize = true;
            this.radioMale.Checked = true;
            this.radioMale.Location = new System.Drawing.Point(44, 12);
            this.radioMale.Name = "radioMale";
            this.radioMale.Size = new System.Drawing.Size(34, 17);
            this.radioMale.TabIndex = 0;
            this.radioMale.TabStop = true;
            this.radioMale.Text = "M";
            this.radioMale.UseVisualStyleBackColor = true;
            // 
            // radioFemale
            // 
            this.radioFemale.AutoSize = true;
            this.radioFemale.Location = new System.Drawing.Point(6, 12);
            this.radioFemale.Name = "radioFemale";
            this.radioFemale.Size = new System.Drawing.Size(31, 17);
            this.radioFemale.TabIndex = 0;
            this.radioFemale.Text = "F";
            this.radioFemale.UseVisualStyleBackColor = true;
            // 
            // LabSex
            // 
            this.LabSex.AutoSize = true;
            this.LabSex.Dock = System.Windows.Forms.DockStyle.Left;
            this.LabSex.Location = new System.Drawing.Point(3, 16);
            this.LabSex.Name = "LabSex";
            this.LabSex.Size = new System.Drawing.Size(25, 13);
            this.LabSex.TabIndex = 1;
            this.LabSex.Text = "Sex";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox5);
            this.groupBox3.Controls.Add(this.LabAlias);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(3, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(246, 38);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Visible = false;
            // 
            // textBox5
            // 
            this.textBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox5.Location = new System.Drawing.Point(32, 16);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(211, 20);
            this.textBox5.TabIndex = 0;
            this.toolTip1.SetToolTip(this.textBox5, "Alias of dog");
            // 
            // LabAlias
            // 
            this.LabAlias.AutoSize = true;
            this.LabAlias.Dock = System.Windows.Forms.DockStyle.Left;
            this.LabAlias.Location = new System.Drawing.Point(3, 16);
            this.LabAlias.Name = "LabAlias";
            this.LabAlias.Size = new System.Drawing.Size(29, 13);
            this.LabAlias.TabIndex = 1;
            this.LabAlias.Text = "Alias";
            // 
            // RadDog
            // 
            this.RadDog.AutoSize = true;
            this.RadDog.Location = new System.Drawing.Point(76, 19);
            this.RadDog.Name = "RadDog";
            this.RadDog.Size = new System.Drawing.Size(45, 17);
            this.RadDog.TabIndex = 0;
            this.RadDog.Text = "Dog";
            this.RadDog.UseVisualStyleBackColor = true;
            this.RadDog.CheckedChanged += new System.EventHandler(this.Rad_CheckedChanged);
            // 
            // RadFish
            // 
            this.RadFish.AutoSize = true;
            this.RadFish.Location = new System.Drawing.Point(127, 19);
            this.RadFish.Name = "RadFish";
            this.RadFish.Size = new System.Drawing.Size(44, 17);
            this.RadFish.TabIndex = 0;
            this.RadFish.Text = "Fish";
            this.RadFish.UseVisualStyleBackColor = true;
            this.RadFish.CheckedChanged += new System.EventHandler(this.Rad_CheckedChanged);
            // 
            // RadChicken
            // 
            this.RadChicken.AutoSize = true;
            this.RadChicken.Checked = true;
            this.RadChicken.Location = new System.Drawing.Point(6, 19);
            this.RadChicken.Name = "RadChicken";
            this.RadChicken.Size = new System.Drawing.Size(64, 17);
            this.RadChicken.TabIndex = 0;
            this.RadChicken.TabStop = true;
            this.RadChicken.Text = "Chicken";
            this.RadChicken.UseVisualStyleBackColor = true;
            this.RadChicken.CheckedChanged += new System.EventHandler(this.Rad_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RadChicken);
            this.groupBox1.Controls.Add(this.RadFish);
            this.groupBox1.Controls.Add(this.RadDog);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(506, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 46);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox1, "Choose what  kind of animals we want to do something");
            // 
            // ageOfAnimal
            // 
            this.ageOfAnimal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ageOfAnimal.Location = new System.Drawing.Point(29, 16);
            this.ageOfAnimal.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.ageOfAnimal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ageOfAnimal.Name = "ageOfAnimal";
            this.ageOfAnimal.Size = new System.Drawing.Size(214, 20);
            this.ageOfAnimal.TabIndex = 8;
            this.toolTip1.SetToolTip(this.ageOfAnimal, "Enter animal\'s age");
            this.ageOfAnimal.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numberOfFood
            // 
            this.numberOfFood.Location = new System.Drawing.Point(97, 234);
            this.numberOfFood.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numberOfFood.Name = "numberOfFood";
            this.numberOfFood.Size = new System.Drawing.Size(143, 20);
            this.numberOfFood.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Numbers of food";
            // 
            // toEat
            // 
            this.toEat.Location = new System.Drawing.Point(9, 261);
            this.toEat.Name = "toEat";
            this.toEat.Size = new System.Drawing.Size(231, 24);
            this.toEat.TabIndex = 10;
            this.toEat.Text = "To eat";
            this.toEat.UseVisualStyleBackColor = true;
            this.toEat.Click += new System.EventHandler(this.toEat_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(9, 291);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(231, 23);
            this.progressBar1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 434);
            this.Controls.Add(this.Param);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.ListOfAnimals);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ListOfAnimals.ResumeLayout(false);
            this.ListOfAnimals.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.Param.ResumeLayout(false);
            this.Param.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ageOfAnimal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfFood)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ListOfAnimals;
        private System.Windows.Forms.RadioButton RadFish;
        private System.Windows.Forms.RadioButton RadChicken;
        private System.Windows.Forms.RadioButton RadDog;
        private System.Windows.Forms.CheckedListBox ListOfAnimal;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.GroupBox Param;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LabAlias;
        private System.Windows.Forms.Label LabBreed;
        private System.Windows.Forms.Label LabAge;
        private System.Windows.Forms.Label LabSex;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioMale;
        private System.Windows.Forms.RadioButton radioFemale;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown ageOfAnimal;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numberOfFood;
        private System.Windows.Forms.Button toEat;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

