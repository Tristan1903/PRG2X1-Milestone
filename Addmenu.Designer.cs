
namespace PRG2X1_Milestone
{
    partial class Addmenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Addmenu));
            this.btnAModules = new System.Windows.Forms.Button();
            this.btnAStudents = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAModules
            // 
            this.btnAModules.Location = new System.Drawing.Point(210, 117);
            this.btnAModules.Name = "btnAModules";
            this.btnAModules.Size = new System.Drawing.Size(75, 48);
            this.btnAModules.TabIndex = 0;
            this.btnAModules.Text = "Modules";
            this.btnAModules.UseVisualStyleBackColor = true;
            this.btnAModules.Click += new System.EventHandler(this.btnAModules_Click);
            // 
            // btnAStudents
            // 
            this.btnAStudents.Location = new System.Drawing.Point(210, 222);
            this.btnAStudents.Name = "btnAStudents";
            this.btnAStudents.Size = new System.Drawing.Size(75, 47);
            this.btnAStudents.TabIndex = 1;
            this.btnAStudents.Text = "Students";
            this.btnAStudents.UseVisualStyleBackColor = true;
            this.btnAStudents.Click += new System.EventHandler(this.btnAStudents_Click);
            // 
            // Addmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(478, 408);
            this.Controls.Add(this.btnAStudents);
            this.Controls.Add(this.btnAModules);
            this.Name = "Addmenu";
            this.Text = "Addmenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAModules;
        private System.Windows.Forms.Button btnAStudents;
    }
}