namespace Procurement.Views
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.lnkEmployees = new System.Windows.Forms.LinkLabel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lnkProjects = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lnkEmployees
            // 
            this.lnkEmployees.AutoSize = true;
            this.lnkEmployees.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkEmployees.Location = new System.Drawing.Point(135, 168);
            this.lnkEmployees.Name = "lnkEmployees";
            this.lnkEmployees.Size = new System.Drawing.Size(185, 17);
            this.lnkEmployees.TabIndex = 1;
            this.lnkEmployees.TabStop = true;
            this.lnkEmployees.Text = "Employees and Permissions";
            this.lnkEmployees.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkEmployees_LinkClicked);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Table.bmp");
            this.imageList1.Images.SetKeyName(1, "User group.bmp");
            // 
            // label2
            // 
            this.label2.ImageKey = "Table.bmp";
            this.label2.ImageList = this.imageList1;
            this.label2.Location = new System.Drawing.Point(75, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 43);
            this.label2.TabIndex = 5;
            // 
            // lnkProjects
            // 
            this.lnkProjects.AutoSize = true;
            this.lnkProjects.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkProjects.Location = new System.Drawing.Point(135, 102);
            this.lnkProjects.Name = "lnkProjects";
            this.lnkProjects.Size = new System.Drawing.Size(129, 17);
            this.lnkProjects.TabIndex = 6;
            this.lnkProjects.TabStop = true;
            this.lnkProjects.Text = "Projects and BOMs";
            this.lnkProjects.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkProjects_LinkClicked);
            // 
            // label3
            // 
            this.label3.ImageKey = "User group.bmp";
            this.label3.ImageList = this.imageList1;
            this.label3.Location = new System.Drawing.Point(75, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 43);
            this.label3.TabIndex = 7;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lnkProjects);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lnkEmployees);
            this.Name = "FrmMain";
            this.Text = "Procurement";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel lnkEmployees;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lnkProjects;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}