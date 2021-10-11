
namespace PRG2X1_Milestone
{
    partial class Display
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Display));
            this.btnsrh = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnStudents = new System.Windows.Forms.Button();
            this.btnModules = new System.Windows.Forms.Button();
            this.Btnadd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnsrh
            // 
            this.btnsrh.Location = new System.Drawing.Point(12, 470);
            this.btnsrh.Name = "btnsrh";
            this.btnsrh.Size = new System.Drawing.Size(75, 23);
            this.btnsrh.TabIndex = 0;
            this.btnsrh.Text = "Search";
            this.btnsrh.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.Location = new System.Drawing.Point(102, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(959, 481);
            this.dataGridView1.TabIndex = 1;
            // 
            // btnStudents
            // 
            this.btnStudents.Location = new System.Drawing.Point(12, 12);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(75, 23);
            this.btnStudents.TabIndex = 2;
            this.btnStudents.Text = "Students";
            this.btnStudents.UseVisualStyleBackColor = true;
            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click);
            // 
            // btnModules
            // 
            this.btnModules.Location = new System.Drawing.Point(12, 41);
            this.btnModules.Name = "btnModules";
            this.btnModules.Size = new System.Drawing.Size(75, 23);
            this.btnModules.TabIndex = 3;
            this.btnModules.Text = "Modules";
            this.btnModules.UseVisualStyleBackColor = true;
            this.btnModules.Click += new System.EventHandler(this.btnModules_Click);
            // 
            // Btnadd
            // 
            this.Btnadd.Location = new System.Drawing.Point(12, 70);
            this.Btnadd.Name = "Btnadd";
            this.Btnadd.Size = new System.Drawing.Size(75, 23);
            this.Btnadd.TabIndex = 4;
            this.Btnadd.Text = "Add";
            this.Btnadd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(12, 412);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1073, 504);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.Btnadd);
            this.Controls.Add(this.btnModules);
            this.Controls.Add(this.btnStudents);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnsrh);
            this.Name = "Display";
            this.Text = "Display";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnsrh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.Button btnModules;
        private System.Windows.Forms.Button Btnadd;
        private System.Windows.Forms.Button btnUpdate;
    }
}