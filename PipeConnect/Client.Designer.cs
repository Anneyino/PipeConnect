namespace PipeConnect
{
    partial class Client
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
            this.ContentBox = new System.Windows.Forms.TextBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.SendButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ContentBox
            // 
            this.ContentBox.Location = new System.Drawing.Point(83, 84);
            this.ContentBox.Name = "ContentBox";
            this.ContentBox.Size = new System.Drawing.Size(211, 25);
            this.ContentBox.TabIndex = 4;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.infoLabel.Location = new System.Drawing.Point(131, 44);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(112, 25);
            this.infoLabel.TabIndex = 5;
            this.infoLabel.Text = "管道信息";
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(120, 125);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(123, 31);
            this.SendButton.TabIndex = 6;
            this.SendButton.Text = "发送至服务端";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 185);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.ContentBox);
            this.Name = "Client";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Client_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ContentBox;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Button SendButton;
    }
}