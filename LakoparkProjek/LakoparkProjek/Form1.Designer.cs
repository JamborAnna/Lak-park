namespace LakoparkProjek
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
            this.balraButton = new System.Windows.Forms.Button();
            this.jobraButton = new System.Windows.Forms.Button();
            this.LakotelepKep = new System.Windows.Forms.PictureBox();
            this.kepPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.LakotelepKep)).BeginInit();
            this.SuspendLayout();
            // 
            // balraButton
            // 
            this.balraButton.BackgroundImage = global::LakoparkProjek.Properties.Resources.balnyil;
            this.balraButton.Location = new System.Drawing.Point(326, 341);
            this.balraButton.Name = "balraButton";
            this.balraButton.Size = new System.Drawing.Size(89, 59);
            this.balraButton.TabIndex = 1;
            this.balraButton.UseVisualStyleBackColor = true;
            // 
            // jobraButton
            // 
            this.jobraButton.BackgroundImage = global::LakoparkProjek.Properties.Resources.jobbnyil;
            this.jobraButton.Location = new System.Drawing.Point(430, 341);
            this.jobraButton.Name = "jobraButton";
            this.jobraButton.Size = new System.Drawing.Size(93, 59);
            this.jobraButton.TabIndex = 0;
            this.jobraButton.UseVisualStyleBackColor = true;
            // 
            // LakotelepKep
            // 
            this.LakotelepKep.Location = new System.Drawing.Point(12, 12);
            this.LakotelepKep.Name = "LakotelepKep";
            this.LakotelepKep.Size = new System.Drawing.Size(108, 144);
            this.LakotelepKep.TabIndex = 2;
            this.LakotelepKep.TabStop = false;
            // 
            // kepPanel
            // 
            this.kepPanel.Location = new System.Drawing.Point(141, 12);
            this.kepPanel.Name = "kepPanel";
            this.kepPanel.Size = new System.Drawing.Size(581, 323);
            this.kepPanel.TabIndex = 3;
            this.kepPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.kepPanel_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kepPanel);
            this.Controls.Add(this.LakotelepKep);
            this.Controls.Add(this.balraButton);
            this.Controls.Add(this.jobraButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.LakotelepKep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button jobraButton;
        private System.Windows.Forms.Button balraButton;
        private System.Windows.Forms.PictureBox LakotelepKep;
        private System.Windows.Forms.Panel kepPanel;
    }
}

