
namespace View
{
    partial class DisplayView
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
            this.btnRotateLeft = new System.Windows.Forms.Button();
            this.btnRotateRight = new System.Windows.Forms.Button();
            this.btnFlipVert = new System.Windows.Forms.Button();
            this.btnFlipHorizontal = new System.Windows.Forms.Button();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.btnResize = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // imagePanel
            // 
            this.imagePanel.Location = new System.Drawing.Point(12, 12);
            this.imagePanel.Name = "imagePanel";
            this.imagePanel.Size = new System.Drawing.Size(500, 525);
            this.imagePanel.TabIndex = 0;
            // 
            // btnRotateLeft
            // 
            this.btnRotateLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRotateLeft.BackColor = System.Drawing.Color.Coral;
            this.btnRotateLeft.FlatAppearance.BorderSize = 0;
            this.btnRotateLeft.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRotateLeft.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btnRotateLeft.Location = new System.Drawing.Point(12, 543);
            this.btnRotateLeft.Name = "btnRotateLeft";
            this.btnRotateLeft.Size = new System.Drawing.Size(75, 44);
            this.btnRotateLeft.TabIndex = 1;
            this.btnRotateLeft.Text = "Rotate Left";
            this.btnRotateLeft.UseVisualStyleBackColor = false;
            this.btnRotateLeft.Click += new System.EventHandler(this.btnRotateLeft_Click);
            // 
            // btnRotateRight
            // 
            this.btnRotateRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRotateRight.BackColor = System.Drawing.Color.Coral;
            this.btnRotateRight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRotateRight.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btnRotateRight.Location = new System.Drawing.Point(437, 543);
            this.btnRotateRight.Name = "btnRotateRight";
            this.btnRotateRight.Size = new System.Drawing.Size(75, 44);
            this.btnRotateRight.TabIndex = 2;
            this.btnRotateRight.Text = "Rotate Right";
            this.btnRotateRight.UseVisualStyleBackColor = false;
            this.btnRotateRight.Click += new System.EventHandler(this.btnRotateRight_Click);
            // 
            // btnFlipVert
            // 
            this.btnFlipVert.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnFlipVert.BackColor = System.Drawing.Color.Coral;
            this.btnFlipVert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFlipVert.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btnFlipVert.Location = new System.Drawing.Point(118, 543);
            this.btnFlipVert.Name = "btnFlipVert";
            this.btnFlipVert.Size = new System.Drawing.Size(119, 44);
            this.btnFlipVert.TabIndex = 3;
            this.btnFlipVert.Text = "Flip Vertically";
            this.btnFlipVert.UseVisualStyleBackColor = false;
            this.btnFlipVert.Click += new System.EventHandler(this.btnFlipVert_Click);
            // 
            // btnFlipHorizontal
            // 
            this.btnFlipHorizontal.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnFlipHorizontal.BackColor = System.Drawing.Color.Coral;
            this.btnFlipHorizontal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFlipHorizontal.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btnFlipHorizontal.Location = new System.Drawing.Point(263, 543);
            this.btnFlipHorizontal.Name = "btnFlipHorizontal";
            this.btnFlipHorizontal.Size = new System.Drawing.Size(132, 44);
            this.btnFlipHorizontal.TabIndex = 4;
            this.btnFlipHorizontal.Text = "Flip Horionztally";
            this.btnFlipHorizontal.UseVisualStyleBackColor = false;
            this.btnFlipHorizontal.Click += new System.EventHandler(this.btnFlipHorizontal_Click);
            // 
            // txtWidth
            // 
            this.txtWidth.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtWidth.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.txtWidth.Location = new System.Drawing.Point(243, 595);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 24);
            this.txtWidth.TabIndex = 5;
            this.txtWidth.Text = "0";
            this.txtWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHeight
            // 
            this.txtHeight.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.txtHeight.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.txtHeight.Location = new System.Drawing.Point(83, 597);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 24);
            this.txtHeight.TabIndex = 6;
            this.txtHeight.Text = "0";
            this.txtHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnResize
            // 
            this.btnResize.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnResize.BackColor = System.Drawing.Color.Coral;
            this.btnResize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResize.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btnResize.Location = new System.Drawing.Point(373, 590);
            this.btnResize.Name = "btnResize";
            this.btnResize.Size = new System.Drawing.Size(139, 32);
            this.btnResize.TabIndex = 7;
            this.btnResize.Text = "Resize Image";
            this.btnResize.UseVisualStyleBackColor = false;
            this.btnResize.Click += new System.EventHandler(this.btnResize_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSave.BackColor = System.Drawing.Color.Coral;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btnSave.Location = new System.Drawing.Point(192, 625);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 44);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save Image";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblHeight
            // 
            this.lblHeight.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblHeight.AutoSize = true;
            this.lblHeight.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblHeight.Location = new System.Drawing.Point(22, 598);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(55, 18);
            this.lblHeight.TabIndex = 9;
            this.lblHeight.Text = "Height";
            // 
            // lblWidth
            // 
            this.lblWidth.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblWidth.AutoSize = true;
            this.lblWidth.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblWidth.Location = new System.Drawing.Point(189, 598);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(48, 18);
            this.lblWidth.TabIndex = 10;
            this.lblWidth.Text = "Width";
            // 
            // DisplayView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(524, 681);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.btnFlipHorizontal);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnResize);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.btnFlipVert);
            this.Controls.Add(this.btnRotateRight);
            this.Controls.Add(this.btnRotateLeft);
            this.Controls.Add(this.imagePanel);
            this.Name = "DisplayView";
            this.Text = "DisplayView";
            this.Resize += new System.EventHandler(this.viewResize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel imagePanel;
        private System.Windows.Forms.Button btnRotateLeft;
        private System.Windows.Forms.Button btnRotateRight;
        private System.Windows.Forms.Button btnFlipVert;
        private System.Windows.Forms.Button btnFlipHorizontal;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Button btnResize;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblWidth;
    }
}