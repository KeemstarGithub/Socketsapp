namespace WindowsFormsApp1
{
    partial class clientLogin
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
            this.joinButton = new System.Windows.Forms.Button();
            this.ipAddressField = new System.Windows.Forms.TextBox();
            this.connectPortField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // joinButton
            // 
            this.joinButton.Location = new System.Drawing.Point(101, 164);
            this.joinButton.Name = "joinButton";
            this.joinButton.Size = new System.Drawing.Size(75, 23);
            this.joinButton.TabIndex = 0;
            this.joinButton.Text = "Join";
            this.joinButton.UseVisualStyleBackColor = true;
            this.joinButton.Click += new System.EventHandler(this.joinButton_Click);
            // 
            // ipAddressField
            // 
            this.ipAddressField.Location = new System.Drawing.Point(92, 102);
            this.ipAddressField.Name = "ipAddressField";
            this.ipAddressField.Size = new System.Drawing.Size(100, 20);
            this.ipAddressField.TabIndex = 1;
            this.ipAddressField.TextChanged += new System.EventHandler(this.ipAddressField_TextChanged);
            // 
            // connectPortField
            // 
            this.connectPortField.Location = new System.Drawing.Point(92, 138);
            this.connectPortField.Name = "connectPortField";
            this.connectPortField.Size = new System.Drawing.Size(100, 20);
            this.connectPortField.TabIndex = 2;
            this.connectPortField.TextChanged += new System.EventHandler(this.connectPortField_TextChanged);
          
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "IP ADDRESS:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "PORT:";
            // 
            // clientLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 230);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.connectPortField);
            this.Controls.Add(this.ipAddressField);
            this.Controls.Add(this.joinButton);
            this.Name = "clientLogin";
            this.Text = "Chat Connect";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button joinButton;
        private System.Windows.Forms.TextBox ipAddressField;
        private System.Windows.Forms.TextBox connectPortField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

