namespace Snake
{
    partial class settings
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
            this.headImage = new System.Windows.Forms.Label();
            this.bodyImage = new System.Windows.Forms.Label();
            this.headImageCB = new System.Windows.Forms.ComboBox();
            this.bodyImageCB = new System.Windows.Forms.ComboBox();
            this.rewardImage = new System.Windows.Forms.Label();
            this.rewardImageCB = new System.Windows.Forms.ComboBox();
            this.applyBTN = new System.Windows.Forms.Button();
            this.closeBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // headImage
            // 
            this.headImage.AutoSize = true;
            this.headImage.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headImage.Location = new System.Drawing.Point(12, 26);
            this.headImage.Name = "headImage";
            this.headImage.Size = new System.Drawing.Size(133, 18);
            this.headImage.TabIndex = 0;
            this.headImage.Text = "Snake Head Image:";
            // 
            // bodyImage
            // 
            this.bodyImage.AutoSize = true;
            this.bodyImage.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bodyImage.Location = new System.Drawing.Point(12, 90);
            this.bodyImage.Name = "bodyImage";
            this.bodyImage.Size = new System.Drawing.Size(132, 18);
            this.bodyImage.TabIndex = 1;
            this.bodyImage.Text = "Snake Body Image:";
            // 
            // headImageCB
            // 
            this.headImageCB.FormattingEnabled = true;
            this.headImageCB.Location = new System.Drawing.Point(197, 27);
            this.headImageCB.Name = "headImageCB";
            this.headImageCB.Size = new System.Drawing.Size(121, 21);
            this.headImageCB.TabIndex = 2;
            // 
            // bodyImageCB
            // 
            this.bodyImageCB.FormattingEnabled = true;
            this.bodyImageCB.Location = new System.Drawing.Point(197, 91);
            this.bodyImageCB.Name = "bodyImageCB";
            this.bodyImageCB.Size = new System.Drawing.Size(121, 21);
            this.bodyImageCB.TabIndex = 3;
            // 
            // rewardImage
            // 
            this.rewardImage.AutoSize = true;
            this.rewardImage.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rewardImage.Location = new System.Drawing.Point(12, 154);
            this.rewardImage.Name = "rewardImage";
            this.rewardImage.Size = new System.Drawing.Size(104, 18);
            this.rewardImage.TabIndex = 4;
            this.rewardImage.Text = "Reward Image:";
            // 
            // rewardImageCB
            // 
            this.rewardImageCB.FormattingEnabled = true;
            this.rewardImageCB.Location = new System.Drawing.Point(197, 155);
            this.rewardImageCB.Name = "rewardImageCB";
            this.rewardImageCB.Size = new System.Drawing.Size(121, 21);
            this.rewardImageCB.TabIndex = 5;
            // 
            // applyBTN
            // 
            this.applyBTN.Location = new System.Drawing.Point(70, 226);
            this.applyBTN.Name = "applyBTN";
            this.applyBTN.Size = new System.Drawing.Size(75, 23);
            this.applyBTN.TabIndex = 6;
            this.applyBTN.Text = "Apply";
            this.applyBTN.UseVisualStyleBackColor = true;
            this.applyBTN.Click += new System.EventHandler(this.applyBTN_Click);
            // 
            // closeBTN
            // 
            this.closeBTN.Location = new System.Drawing.Point(211, 224);
            this.closeBTN.Name = "closeBTN";
            this.closeBTN.Size = new System.Drawing.Size(75, 23);
            this.closeBTN.TabIndex = 7;
            this.closeBTN.Text = "Close";
            this.closeBTN.UseVisualStyleBackColor = true;
            this.closeBTN.Click += new System.EventHandler(this.closeBTN_Click);
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 261);
            this.Controls.Add(this.closeBTN);
            this.Controls.Add(this.applyBTN);
            this.Controls.Add(this.rewardImageCB);
            this.Controls.Add(this.rewardImage);
            this.Controls.Add(this.bodyImageCB);
            this.Controls.Add(this.headImageCB);
            this.Controls.Add(this.bodyImage);
            this.Controls.Add(this.headImage);
            this.Name = "settings";
            this.Text = "settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headImage;
        private System.Windows.Forms.Label bodyImage;
        private System.Windows.Forms.ComboBox headImageCB;
        private System.Windows.Forms.ComboBox bodyImageCB;
        private System.Windows.Forms.Label rewardImage;
        private System.Windows.Forms.ComboBox rewardImageCB;
        private System.Windows.Forms.Button applyBTN;
        private System.Windows.Forms.Button closeBTN;
    }
}