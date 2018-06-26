namespace NeuralNet
{
    partial class NeuralDemo
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
            this.pictureCard = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTrain = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.openImage = new System.Windows.Forms.OpenFileDialog();
            this.txtOutput1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblEpoch = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCardName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtOutput4 = new System.Windows.Forms.Label();
            this.txtOutput3 = new System.Windows.Forms.Label();
            this.txtOutput2 = new System.Windows.Forms.Label();
            this.pictureClassify = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCard)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClassify)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureCard
            // 
            this.pictureCard.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureCard.Location = new System.Drawing.Point(25, 121);
            this.pictureCard.Name = "pictureCard";
            this.pictureCard.Size = new System.Drawing.Size(472, 470);
            this.pictureCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureCard.TabIndex = 0;
            this.pictureCard.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(497, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "NEURAL NETWORKS DEMO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(543, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "USING BACKPROPAGATION";
            // 
            // btnTrain
            // 
            this.btnTrain.Location = new System.Drawing.Point(7, 43);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(141, 45);
            this.btnTrain.TabIndex = 3;
            this.btnTrain.Text = "TRAIN";
            this.btnTrain.UseVisualStyleBackColor = true;
            this.btnTrain.Click += new System.EventHandler(this.btnTrain_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(154, 94);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(141, 45);
            this.btnLoad.TabIndex = 5;
            this.btnLoad.Text = "LOAD WEIGHTS";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Location = new System.Drawing.Point(154, 43);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(141, 45);
            this.btnLoadImage.TabIndex = 6;
            this.btnLoadImage.Text = "LOAD IMAGE";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // openImage
            // 
            this.openImage.FileName = "openFileDialog1";
            this.openImage.FileOk += new System.ComponentModel.CancelEventHandler(this.openImage_FileOk);
            // 
            // txtOutput1
            // 
            this.txtOutput1.AutoSize = true;
            this.txtOutput1.Location = new System.Drawing.Point(23, 177);
            this.txtOutput1.Name = "txtOutput1";
            this.txtOutput1.Size = new System.Drawing.Size(59, 17);
            this.txtOutput1.TabIndex = 7;
            this.txtOutput1.Text = "Output1";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(7, 94);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(141, 45);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "SAVE WEIGHTS";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblEpoch);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblCardName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.groupBox1.Location = new System.Drawing.Point(503, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 170);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Training Info";
            // 
            // lblEpoch
            // 
            this.lblEpoch.AutoSize = true;
            this.lblEpoch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblEpoch.Location = new System.Drawing.Point(112, 109);
            this.lblEpoch.Name = "lblEpoch";
            this.lblEpoch.Size = new System.Drawing.Size(76, 20);
            this.lblEpoch.TabIndex = 3;
            this.lblEpoch.Text = "<Epoch>";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Epoch:";
            // 
            // lblCardName
            // 
            this.lblCardName.AutoSize = true;
            this.lblCardName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCardName.Location = new System.Drawing.Point(36, 72);
            this.lblCardName.Name = "lblCardName";
            this.lblCardName.Size = new System.Drawing.Size(73, 20);
            this.lblCardName.TabIndex = 1;
            this.lblCardName.Text = "<Name>";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtOutput4);
            this.groupBox2.Controls.Add(this.txtOutput3);
            this.groupBox2.Controls.Add(this.txtOutput2);
            this.groupBox2.Controls.Add(this.btnLoad);
            this.groupBox2.Controls.Add(this.btnTrain);
            this.groupBox2.Controls.Add(this.txtOutput1);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.btnLoadImage);
            this.groupBox2.Location = new System.Drawing.Point(503, 297);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(306, 294);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // txtOutput4
            // 
            this.txtOutput4.AutoSize = true;
            this.txtOutput4.Location = new System.Drawing.Point(24, 244);
            this.txtOutput4.Name = "txtOutput4";
            this.txtOutput4.Size = new System.Drawing.Size(59, 17);
            this.txtOutput4.TabIndex = 11;
            this.txtOutput4.Text = "Output4";
            // 
            // txtOutput3
            // 
            this.txtOutput3.AutoSize = true;
            this.txtOutput3.Location = new System.Drawing.Point(23, 220);
            this.txtOutput3.Name = "txtOutput3";
            this.txtOutput3.Size = new System.Drawing.Size(59, 17);
            this.txtOutput3.TabIndex = 10;
            this.txtOutput3.Text = "Output3";
            // 
            // txtOutput2
            // 
            this.txtOutput2.AutoSize = true;
            this.txtOutput2.Location = new System.Drawing.Point(23, 199);
            this.txtOutput2.Name = "txtOutput2";
            this.txtOutput2.Size = new System.Drawing.Size(59, 17);
            this.txtOutput2.TabIndex = 9;
            this.txtOutput2.Text = "Output2";
            // 
            // pictureClassify
            // 
            this.pictureClassify.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureClassify.Location = new System.Drawing.Point(815, 121);
            this.pictureClassify.Name = "pictureClassify";
            this.pictureClassify.Size = new System.Drawing.Size(472, 470);
            this.pictureClassify.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureClassify.TabIndex = 11;
            this.pictureClassify.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label5.Location = new System.Drawing.Point(158, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 29);
            this.label5.TabIndex = 12;
            this.label5.Text = "TRAINED IMAGE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label6.Location = new System.Drawing.Point(966, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(208, 29);
            this.label6.TabIndex = 13;
            this.label6.Text = "CLASSIFY IMAGE";
            // 
            // NeuralDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 603);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureClassify);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureCard);
            this.Name = "NeuralDemo";
            this.Text = "Card Classification";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NeuralDemo_FormClosing);
            this.Load += new System.EventHandler(this.NeuralDemo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureCard)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClassify)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureCard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.OpenFileDialog openImage;
        private System.Windows.Forms.Label txtOutput1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCardName;
        private System.Windows.Forms.PictureBox pictureClassify;
        private System.Windows.Forms.Label txtOutput4;
        private System.Windows.Forms.Label txtOutput3;
        private System.Windows.Forms.Label txtOutput2;
        private System.Windows.Forms.Label lblEpoch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

