﻿namespace EntityTextureCreator
{
    partial class NewTexture
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
            this.rBut16 = new System.Windows.Forms.RadioButton();
            this.lblSize = new System.Windows.Forms.Label();
            this.rBut32 = new System.Windows.Forms.RadioButton();
            this.butCreate = new System.Windows.Forms.Button();
            this.rBut162 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // rBut16
            // 
            this.rBut16.AutoSize = true;
            this.rBut16.Checked = true;
            this.rBut16.Location = new System.Drawing.Point(121, 48);
            this.rBut16.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rBut16.Name = "rBut16";
            this.rBut16.Size = new System.Drawing.Size(59, 19);
            this.rBut16.TabIndex = 0;
            this.rBut16.TabStop = true;
            this.rBut16.Text = "64x32";
            this.rBut16.UseVisualStyleBackColor = true;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(118, 29);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(31, 15);
            this.lblSize.TabIndex = 1;
            this.lblSize.Text = "Size";
            // 
            // rBut32
            // 
            this.rBut32.AutoSize = true;
            this.rBut32.Location = new System.Drawing.Point(121, 97);
            this.rBut32.Name = "rBut32";
            this.rBut32.Size = new System.Drawing.Size(66, 19);
            this.rBut32.TabIndex = 2;
            this.rBut32.Text = "128x64";
            this.rBut32.UseVisualStyleBackColor = true;
            // 
            // butCreate
            // 
            this.butCreate.Location = new System.Drawing.Point(121, 146);
            this.butCreate.Name = "butCreate";
            this.butCreate.Size = new System.Drawing.Size(75, 23);
            this.butCreate.TabIndex = 3;
            this.butCreate.Text = "Create";
            this.butCreate.UseVisualStyleBackColor = true;
            this.butCreate.Click += new System.EventHandler(this.butCreate_Click);
            // 
            // rBut162
            // 
            this.rBut162.AutoSize = true;
            this.rBut162.Location = new System.Drawing.Point(121, 72);
            this.rBut162.Name = "rBut162";
            this.rBut162.Size = new System.Drawing.Size(59, 19);
            this.rBut162.TabIndex = 4;
            this.rBut162.TabStop = true;
            this.rBut162.Text = "64x64";
            this.rBut162.UseVisualStyleBackColor = true;
            // 
            // NewTexture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 199);
            this.Controls.Add(this.rBut162);
            this.Controls.Add(this.butCreate);
            this.Controls.Add(this.rBut32);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.rBut16);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "NewTexture";
            this.Text = "NewTexture";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rBut16;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.RadioButton rBut32;
        private System.Windows.Forms.Button butCreate;
        private System.Windows.Forms.RadioButton rBut162;
    }
}