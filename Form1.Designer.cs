namespace purplematcha
{
    partial class Table
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
            this.Gridview = new System.Windows.Forms.DataGridView();
            this.Name = new System.Windows.Forms.TextBox();
            this.Age = new System.Windows.Forms.TextBox();
            this.isSingleCheckBox = new System.Windows.Forms.CheckBox();
            this.addButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Gridview)).BeginInit();
            this.SuspendLayout();
            // 
            // Gridview
            // 
            this.Gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gridview.Location = new System.Drawing.Point(48, 12);
            this.Gridview.Name = "Gridview";
            this.Gridview.Size = new System.Drawing.Size(661, 150);
            this.Gridview.TabIndex = 0;
            this.Gridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(245, 201);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(198, 20);
            this.Name.TabIndex = 1;
            this.Name.TextChanged += new System.EventHandler(this.Name_TextChanged);
            // 
            // Age
            // 
            this.Age.Location = new System.Drawing.Point(245, 245);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(69, 20);
            this.Age.TabIndex = 2;
            // 
            // isSingleCheckBox
            // 
            this.isSingleCheckBox.AutoSize = true;
            this.isSingleCheckBox.Location = new System.Drawing.Point(245, 295);
            this.isSingleCheckBox.Name = "isSingleCheckBox";
            this.isSingleCheckBox.Size = new System.Drawing.Size(15, 14);
            this.isSingleCheckBox.TabIndex = 3;
            this.isSingleCheckBox.UseVisualStyleBackColor = true;
            this.isSingleCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(131, 327);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(129, 46);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "AddStudetButton";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(293, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 47);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.isSingleCheckBox);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.Gridview);
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Gridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Gridview;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.TextBox Age;
        private System.Windows.Forms.CheckBox isSingleCheckBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button button1;
    }
}

