// Trong file: UI/Admin/Child_AdminMainDashboard/FormChat.Designer.cs
namespace Internet_Cafe_Manager_App.UI.Admin.Child_AdminMainDashboard
{
    partial class FormChat
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.splitContainerMain = new System.Windows.Forms.SplitContainer();
            this.panelSessionList = new System.Windows.Forms.Panel();
            this.flowLayoutPanelSessions = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelChatArea = new System.Windows.Forms.Panel();
            this.flowLayoutPanelMessages = new System.Windows.Forms.FlowLayoutPanel();
            this.panelInput = new System.Windows.Forms.Panel();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblChattingWith = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
            this.splitContainerMain.Panel1.SuspendLayout();
            this.splitContainerMain.Panel2.SuspendLayout();
            this.splitContainerMain.SuspendLayout();
            this.panelSessionList.SuspendLayout();
            this.panelChatArea.SuspendLayout();
            this.panelInput.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerMain
            // 
            this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            this.splitContainerMain.Panel1.Controls.Add(this.panelSessionList);
            // 
            // splitContainerMain.Panel2
            // 
            this.splitContainerMain.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.splitContainerMain.Panel2.Controls.Add(this.panelChatArea);
            this.splitContainerMain.Panel2.Controls.Add(this.panelInput);
            this.splitContainerMain.Panel2.Controls.Add(this.panelTop);
            this.splitContainerMain.Size = new System.Drawing.Size(800, 450);
            this.splitContainerMain.SplitterDistance = 220;
            this.splitContainerMain.TabIndex = 0;
            // 
            // panelSessionList
            // 
            this.panelSessionList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelSessionList.Controls.Add(this.flowLayoutPanelSessions);
            this.panelSessionList.Controls.Add(this.label1);
            this.panelSessionList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSessionList.Location = new System.Drawing.Point(0, 0);
            this.panelSessionList.Name = "panelSessionList";
            this.panelSessionList.Size = new System.Drawing.Size(220, 450);
            this.panelSessionList.TabIndex = 0;
            // 
            // flowLayoutPanelSessions
            // 
            this.flowLayoutPanelSessions.AutoScroll = true;
            this.flowLayoutPanelSessions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelSessions.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelSessions.Location = new System.Drawing.Point(0, 40);
            this.flowLayoutPanelSessions.Name = "flowLayoutPanelSessions";
            this.flowLayoutPanelSessions.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanelSessions.Size = new System.Drawing.Size(220, 410);
            this.flowLayoutPanelSessions.TabIndex = 1;
            this.flowLayoutPanelSessions.WrapContents = false;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Các cuộc hội thoại";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelChatArea
            // 
            this.panelChatArea.Controls.Add(this.flowLayoutPanelMessages);
            this.panelChatArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChatArea.Location = new System.Drawing.Point(0, 40);
            this.panelChatArea.Name = "panelChatArea";
            this.panelChatArea.Size = new System.Drawing.Size(576, 360);
            this.panelChatArea.TabIndex = 2;
            // 
            // flowLayoutPanelMessages
            // 
            this.flowLayoutPanelMessages.AutoScroll = true;
            this.flowLayoutPanelMessages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(43)))), ((int)(((byte)(80)))));
            this.flowLayoutPanelMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelMessages.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelMessages.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelMessages.Name = "flowLayoutPanelMessages";
            this.flowLayoutPanelMessages.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanelMessages.Size = new System.Drawing.Size(576, 360);
            this.flowLayoutPanelMessages.TabIndex = 0;
            this.flowLayoutPanelMessages.WrapContents = false;
            // 
            // panelInput
            // 
            this.panelInput.Controls.Add(this.btnSend);
            this.panelInput.Controls.Add(this.txtMessage);
            this.panelInput.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelInput.Location = new System.Drawing.Point(0, 400);
            this.panelInput.Name = "panelInput";
            this.panelInput.Padding = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.panelInput.Size = new System.Drawing.Size(576, 50);
            this.panelInput.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(138)))), ((int)(((byte)(114)))));
            this.btnSend.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(456, 5);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(110, 35);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Gửi";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(53)))), ((int)(((byte)(90)))));
            this.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMessage.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtMessage.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtMessage.Location = new System.Drawing.Point(10, 5);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(556, 35);
            this.txtMessage.TabIndex = 0;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.lblChattingWith);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(576, 40);
            this.panelTop.TabIndex = 0;
            // 
            // lblChattingWith
            // 
            this.lblChattingWith.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblChattingWith.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.lblChattingWith.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblChattingWith.Location = new System.Drawing.Point(0, 0);
            this.lblChattingWith.Name = "lblChattingWith";
            this.lblChattingWith.Size = new System.Drawing.Size(576, 40);
            this.lblChattingWith.TabIndex = 0;
            this.lblChattingWith.Text = "Chọn một cuộc trò chuyện";
            this.lblChattingWith.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormChat
            // 
            this.AcceptButton = this.btnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainerMain);
            this.Name = "FormChat";
            this.Text = "Quản lý Chat";
            this.Load += new System.EventHandler(this.FormChat_Load);
            this.splitContainerMain.Panel1.ResumeLayout(false);
            this.splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
            this.splitContainerMain.ResumeLayout(false);
            this.panelSessionList.ResumeLayout(false);
            this.panelChatArea.ResumeLayout(false);
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.Panel panelSessionList;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSessions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelChatArea;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMessages;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblChattingWith;
    }
}