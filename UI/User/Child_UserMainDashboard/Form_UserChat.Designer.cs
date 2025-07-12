// Trong file: UI/User/Child_UserMainDashboard/Form_UserChat.Designer.cs
namespace Internet_Cafe_Manager_App.UI.User.Child_UserMainDashboard
{
    partial class Form_UserChat
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listBoxOnlinePCs = new System.Windows.Forms.ListBox();
            this.labelOnline = new System.Windows.Forms.Label();
            this.panelChatArea = new System.Windows.Forms.Panel();
            this.flowLayoutPanelMessages = new System.Windows.Forms.FlowLayoutPanel();
            this.panelInput = new System.Windows.Forms.Panel();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblChattingWith = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panelChatArea.SuspendLayout();
            this.panelInput.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelMain.Controls.Add(this.splitContainer1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(800, 450);
            this.panelMain.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.splitContainer1.Panel1.Controls.Add(this.listBoxOnlinePCs);
            this.splitContainer1.Panel1.Controls.Add(this.labelOnline);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panelChatArea);
            this.splitContainer1.Panel2.Controls.Add(this.panelInput);
            this.splitContainer1.Panel2.Controls.Add(this.panelTop);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 180;
            this.splitContainer1.TabIndex = 0;
            // 
            // listBoxOnlinePCs
            // 
            this.listBoxOnlinePCs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.listBoxOnlinePCs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxOnlinePCs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxOnlinePCs.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxOnlinePCs.ForeColor = System.Drawing.Color.Gainsboro;
            this.listBoxOnlinePCs.FormattingEnabled = true;
            this.listBoxOnlinePCs.ItemHeight = 23;
            this.listBoxOnlinePCs.Location = new System.Drawing.Point(0, 40);
            this.listBoxOnlinePCs.Name = "listBoxOnlinePCs";
            this.listBoxOnlinePCs.Size = new System.Drawing.Size(180, 410);
            this.listBoxOnlinePCs.TabIndex = 1;
            this.listBoxOnlinePCs.SelectedIndexChanged += new System.EventHandler(this.listBoxOnlinePCs_SelectedIndexChanged);
            // 
            // labelOnline
            // 
            this.labelOnline.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelOnline.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOnline.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelOnline.Location = new System.Drawing.Point(0, 0);
            this.labelOnline.Name = "labelOnline";
            this.labelOnline.Size = new System.Drawing.Size(180, 40);
            this.labelOnline.TabIndex = 0;
            this.labelOnline.Text = "Online";
            this.labelOnline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelChatArea
            // 
            this.panelChatArea.Controls.Add(this.flowLayoutPanelMessages);
            this.panelChatArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChatArea.Location = new System.Drawing.Point(0, 40);
            this.panelChatArea.Name = "panelChatArea";
            this.panelChatArea.Size = new System.Drawing.Size(616, 360);
            this.panelChatArea.TabIndex = 5;
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
            this.flowLayoutPanelMessages.Size = new System.Drawing.Size(616, 360);
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
            this.panelInput.Size = new System.Drawing.Size(616, 50);
            this.panelInput.TabIndex = 4;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnSend.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSend.Location = new System.Drawing.Point(496, 5);
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
            this.txtMessage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtMessage.Location = new System.Drawing.Point(10, 5);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(596, 35);
            this.txtMessage.TabIndex = 0;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.lblChattingWith);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(616, 40);
            this.panelTop.TabIndex = 3;
            // 
            // lblChattingWith
            // 
            this.lblChattingWith.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblChattingWith.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChattingWith.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblChattingWith.Location = new System.Drawing.Point(0, 0);
            this.lblChattingWith.Name = "lblChattingWith";
            this.lblChattingWith.Size = new System.Drawing.Size(616, 40);
            this.lblChattingWith.TabIndex = 0;
            this.lblChattingWith.Text = "Chọn một người để trò chuyện";
            this.lblChattingWith.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_UserChat
            // 
            this.AcceptButton = this.btnSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMain);
            this.Name = "Form_UserChat";
            this.Text = "Chat";
            this.Load += new System.EventHandler(this.Form_UserChat_Load);
            this.panelMain.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panelChatArea.ResumeLayout(false);
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox listBoxOnlinePCs;
        private System.Windows.Forms.Label labelOnline;
        private System.Windows.Forms.Panel panelChatArea;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMessages;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblChattingWith;
    }
}