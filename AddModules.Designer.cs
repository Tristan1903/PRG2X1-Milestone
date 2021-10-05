
namespace PRG2X1_Milestone
{
    partial class AddModules
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddModules));
            this.txtMID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMdesc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMName = new System.Windows.Forms.TextBox();
            this.lblMname = new System.Windows.Forms.Label();
            this.txtMlink = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMID
            // 
            this.txtMID.Location = new System.Drawing.Point(247, 134);
            this.txtMID.Name = "txtMID";
            this.txtMID.Size = new System.Drawing.Size(100, 23);
            this.txtMID.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(247, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Module Code";
            // 
            // btnMdesc
            // 
            this.btnMdesc.Location = new System.Drawing.Point(250, 239);
            this.btnMdesc.Name = "btnMdesc";
            this.btnMdesc.Size = new System.Drawing.Size(100, 23);
            this.btnMdesc.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(250, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Module Description";
            // 
            // btnMName
            // 
            this.btnMName.Location = new System.Drawing.Point(250, 186);
            this.btnMName.Name = "btnMName";
            this.btnMName.Size = new System.Drawing.Size(100, 23);
            this.btnMName.TabIndex = 7;
            // 
            // lblMname
            // 
            this.lblMname.AutoSize = true;
            this.lblMname.BackColor = System.Drawing.Color.Transparent;
            this.lblMname.ForeColor = System.Drawing.Color.White;
            this.lblMname.Location = new System.Drawing.Point(250, 167);
            this.lblMname.Name = "lblMname";
            this.lblMname.Size = new System.Drawing.Size(83, 15);
            this.lblMname.TabIndex = 6;
            this.lblMname.Text = "Module Name";
            // 
            // txtMlink
            // 
            this.txtMlink.Location = new System.Drawing.Point(250, 293);
            this.txtMlink.Name = "txtMlink";
            this.txtMlink.Size = new System.Drawing.Size(100, 23);
            this.txtMlink.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(250, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Link";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(250, 366);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 54);
            this.button2.TabIndex = 21;
            this.button2.Text = "Add to Database";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // AddModules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(594, 518);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtMlink);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnMdesc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnMName);
            this.Controls.Add(this.lblMname);
            this.Name = "AddModules";
            this.Text = "AddModules";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox btnMdesc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox btnMName;
        private System.Windows.Forms.Label lblMname;
        private System.Windows.Forms.TextBox txtMlink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}