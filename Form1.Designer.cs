namespace Dierentuin
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
            this.dgvAnimalView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lsbAddAnimal = new System.Windows.Forms.ListBox();
            this.btnAddMonkey = new System.Windows.Forms.Button();
            this.btnFeedEverything = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimalView)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAnimalView
            // 
            this.dgvAnimalView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnimalView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvAnimalView.Location = new System.Drawing.Point(12, 12);
            this.dgvAnimalView.Name = "dgvAnimalView";
            this.dgvAnimalView.Size = new System.Drawing.Size(244, 147);
            this.dgvAnimalView.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Energy";
            this.Column2.Name = "Column2";
            // 
            // lsbAddAnimal
            // 
            this.lsbAddAnimal.FormattingEnabled = true;
            this.lsbAddAnimal.Location = new System.Drawing.Point(262, 12);
            this.lsbAddAnimal.Name = "lsbAddAnimal";
            this.lsbAddAnimal.Size = new System.Drawing.Size(120, 121);
            this.lsbAddAnimal.TabIndex = 1;
            // 
            // btnAddMonkey
            // 
            this.btnAddMonkey.Location = new System.Drawing.Point(262, 136);
            this.btnAddMonkey.Name = "btnAddMonkey";
            this.btnAddMonkey.Size = new System.Drawing.Size(120, 23);
            this.btnAddMonkey.TabIndex = 2;
            this.btnAddMonkey.Tag = "Monkey";
            this.btnAddMonkey.Text = "Add Animal";
            this.btnAddMonkey.UseVisualStyleBackColor = true;
            this.btnAddMonkey.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnFeedEverything
            // 
            this.btnFeedEverything.Location = new System.Drawing.Point(388, 12);
            this.btnFeedEverything.Name = "btnFeedEverything";
            this.btnFeedEverything.Size = new System.Drawing.Size(92, 23);
            this.btnFeedEverything.TabIndex = 6;
            this.btnFeedEverything.Text = "Feed";
            this.btnFeedEverything.UseVisualStyleBackColor = true;
            this.btnFeedEverything.Click += new System.EventHandler(this.btnFeed_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 178);
            this.Controls.Add(this.btnFeedEverything);
            this.Controls.Add(this.btnAddMonkey);
            this.Controls.Add(this.lsbAddAnimal);
            this.Controls.Add(this.dgvAnimalView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnimalView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAnimalView;
        private System.Windows.Forms.ListBox lsbAddAnimal;
        private System.Windows.Forms.Button btnAddMonkey;
        private System.Windows.Forms.Button btnFeedEverything;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}

