
namespace View
{
    partial class CollectionView
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
            this.imagePanel = new System.Windows.Forms.Panel();
            this.btnLoadImages = new System.Windows.Forms.Button();
            this.imagePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // imagePanel
            // 
            this.imagePanel.Controls.Add(this.btnLoadImages);
            this.imagePanel.Location = new System.Drawing.Point(12, 12);
            this.imagePanel.Name = "imagePanel";
            this.imagePanel.Size = new System.Drawing.Size(1052, 626);
            this.imagePanel.TabIndex = 0;
            // 
            // btnLoadImages
            // 
            this.btnLoadImages.BackColor = System.Drawing.Color.Coral;
            this.btnLoadImages.FlatAppearance.BorderSize = 0;
            this.btnLoadImages.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoadImages.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadImages.Location = new System.Drawing.Point(3, 3);
            this.btnLoadImages.Name = "btnLoadImages";
            this.btnLoadImages.Size = new System.Drawing.Size(1046, 50);
            this.btnLoadImages.TabIndex = 0;
            this.btnLoadImages.Text = "Load Images";
            this.btnLoadImages.UseVisualStyleBackColor = false;
            this.btnLoadImages.Click += new System.EventHandler(this.btnLoadImages_Click);
            // 
            // CollectionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1076, 650);
            this.Controls.Add(this.imagePanel);
            this.Name = "CollectionView";
            this.Text = "CollectionView";
            this.imagePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel imagePanel;
        private System.Windows.Forms.Button btnLoadImages;
    }
}