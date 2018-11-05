namespace PipeConnect
{
    partial class Server
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
            this.infoLabel = new System.Windows.Forms.Label();
            this.ContentBox = new System.Windows.Forms.RichTextBox();
            this.RunClientButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.infoLabel.Location = new System.Drawing.Point(193, 27);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(187, 25);
            this.infoLabel.TabIndex = 2;
            this.infoLabel.Text = "来自管道的信息";
            // 
            // ContentBox
            // 
            this.ContentBox.Location = new System.Drawing.Point(140, 73);
            this.ContentBox.Name = "ContentBox";
            this.ContentBox.Size = new System.Drawing.Size(324, 110);
            this.ContentBox.TabIndex = 5;
            this.ContentBox.Text = "";
            // 
            // RunClientButton
            // 
            this.RunClientButton.Location = new System.Drawing.Point(175, 213);
            this.RunClientButton.Name = "RunClientButton";
            this.RunClientButton.Size = new System.Drawing.Size(227, 43);
            this.RunClientButton.TabIndex = 6;
            this.RunClientButton.Text = "刷新";
            this.RunClientButton.UseVisualStyleBackColor = true;
            this.RunClientButton.Click += new System.EventHandler(this.RunClientButton_Click);
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 299);
            this.Controls.Add(this.RunClientButton);
            this.Controls.Add(this.ContentBox);
            this.Controls.Add(this.infoLabel);
            this.Name = "Server";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Server_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.RichTextBox ContentBox;
        private System.Windows.Forms.Button RunClientButton;
    }
}