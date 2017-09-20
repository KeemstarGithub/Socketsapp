namespace WindowsFormsApp1
{
    partial class clientConnected
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
            this.userMessageField = new System.Windows.Forms.TextBox();
            this.chatViewList = new System.Windows.Forms.ListView();
            this.chatColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // userMessageField
            // 
            this.userMessageField.Location = new System.Drawing.Point(-3, 335);
            this.userMessageField.Name = "userMessageField";
            this.userMessageField.Size = new System.Drawing.Size(351, 20);
            this.userMessageField.TabIndex = 0;
            this.userMessageField.TextChanged += new System.EventHandler(this.userMessageField_TextChanged);
            this.userMessageField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.enterKeypressDetection);
            // 
            // chatViewList
            // 
            this.chatViewList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chatColumn});
            this.chatViewList.Location = new System.Drawing.Point(-3, 0);
            this.chatViewList.Name = "chatViewList";
            this.chatViewList.Size = new System.Drawing.Size(351, 329);
            this.chatViewList.TabIndex = 1;
            this.chatViewList.UseCompatibleStateImageBehavior = false;
            this.chatViewList.View = System.Windows.Forms.View.Details;
            this.chatViewList.SelectedIndexChanged += new System.EventHandler(this.chatView);
            // 
            // chatColumn
            // 
            this.chatColumn.Text = "";
            this.chatColumn.Width = 346;
            // 
            // clientConnected
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 355);
            this.Controls.Add(this.chatViewList);
            this.Controls.Add(this.userMessageField);
            this.Name = "clientConnected";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.clientConnected_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userMessageField;
        private System.Windows.Forms.ListView chatViewList;
        private System.Windows.Forms.ColumnHeader chatColumn;
    }
}