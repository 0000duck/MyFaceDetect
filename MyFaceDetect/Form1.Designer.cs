namespace MyFaceDetect
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.grab_button = new System.Windows.Forms.Button();
            this.save_button = new System.Windows.Forms.Button();
            this.picName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.train_button = new System.Windows.Forms.Button();
            this.grabBox = new System.Windows.Forms.PictureBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grabBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // grab_button
            // 
            this.grab_button.Location = new System.Drawing.Point(632, 293);
            this.grab_button.Name = "grab_button";
            this.grab_button.Size = new System.Drawing.Size(75, 23);
            this.grab_button.TabIndex = 2;
            this.grab_button.Text = "截取";
            this.grab_button.UseVisualStyleBackColor = true;
            this.grab_button.Click += new System.EventHandler(this.grab_button_Click);
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(774, 293);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(75, 23);
            this.save_button.TabIndex = 3;
            this.save_button.Text = "保存";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // picName
            // 
            this.picName.Location = new System.Drawing.Point(710, 264);
            this.picName.Name = "picName";
            this.picName.Size = new System.Drawing.Size(139, 21);
            this.picName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10F);
            this.label1.Location = new System.Drawing.Point(630, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "输入姓名:";
            // 
            // train_button
            // 
            this.train_button.Location = new System.Drawing.Point(633, 372);
            this.train_button.Name = "train_button";
            this.train_button.Size = new System.Drawing.Size(75, 23);
            this.train_button.TabIndex = 6;
            this.train_button.Text = "训练识别器";
            this.train_button.UseVisualStyleBackColor = true;
            this.train_button.Click += new System.EventHandler(this.train_button_Click);
            // 
            // grabBox
            // 
            this.grabBox.Location = new System.Drawing.Point(632, 12);
            this.grabBox.Name = "grabBox";
            this.grabBox.Size = new System.Drawing.Size(249, 213);
            this.grabBox.TabIndex = 1;
            this.grabBox.TabStop = false;
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::MyFaceDetect.Properties.Resources.girl2;
            this.pictureBox.Location = new System.Drawing.Point(22, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(572, 380);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 486);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.train_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picName);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.grab_button);
            this.Controls.Add(this.grabBox);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grabBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.PictureBox grabBox;
        private System.Windows.Forms.Button grab_button;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.TextBox picName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button train_button;
        private System.Windows.Forms.Label label2;
    }
}

