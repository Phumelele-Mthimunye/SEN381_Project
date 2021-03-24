
namespace PremierServiceSolutions_V1._0._0.CallAgent
{
    partial class PhoneCall
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
            this.pnlNavBar = new System.Windows.Forms.Panel();
            this.fpnlChatContent = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.pnlCallInput = new System.Windows.Forms.Panel();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlNavBar
            // 
            this.pnlNavBar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlNavBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNavBar.Location = new System.Drawing.Point(0, 0);
            this.pnlNavBar.Name = "pnlNavBar";
            this.pnlNavBar.Size = new System.Drawing.Size(423, 39);
            this.pnlNavBar.TabIndex = 0;
            // 
            // fpnlChatContent
            // 
            this.fpnlChatContent.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.fpnlChatContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fpnlChatContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fpnlChatContent.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fpnlChatContent.Location = new System.Drawing.Point(0, 39);
            this.fpnlChatContent.Name = "fpnlChatContent";
            this.fpnlChatContent.Size = new System.Drawing.Size(423, 590);
            this.fpnlChatContent.TabIndex = 1;
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.pnlCallInput);
            this.pnlFooter.Controls.Add(this.btnCancel);
            this.pnlFooter.Controls.Add(this.btnSend);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 590);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(423, 39);
            this.pnlFooter.TabIndex = 2;
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCancel.Location = new System.Drawing.Point(0, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(77, 39);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSend
            // 
            this.btnSend.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSend.Location = new System.Drawing.Point(311, 0);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(112, 39);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // pnlCallInput
            // 
            this.pnlCallInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCallInput.Location = new System.Drawing.Point(77, 0);
            this.pnlCallInput.Name = "pnlCallInput";
            this.pnlCallInput.Size = new System.Drawing.Size(234, 39);
            this.pnlCallInput.TabIndex = 2;
            // 
            // PhoneCall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 629);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.fpnlChatContent);
            this.Controls.Add(this.pnlNavBar);
            this.Name = "PhoneCall";
            this.Text = "PhoneCall";
            this.Load += new System.EventHandler(this.PhoneCall_Load);
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNavBar;
        private System.Windows.Forms.FlowLayoutPanel fpnlChatContent;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Panel pnlCallInput;
    }
}