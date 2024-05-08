namespace chatApp
{
    partial class Chatapp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            msgs_box = new ListBox();
            btn_send = new Button();
            btn_sendToGrp = new Button();
            btn_join = new Button();
            txt_name = new TextBox();
            txt_grpmsg = new TextBox();
            txt_msg = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            TypingNotification = new Label();
            SuspendLayout();
            // 
            // msgs_box
            // 
            msgs_box.FormattingEnabled = true;
            msgs_box.ItemHeight = 15;
            msgs_box.Location = new Point(12, 201);
            msgs_box.Name = "msgs_box";
            msgs_box.Size = new Size(776, 229);
            msgs_box.TabIndex = 0;
            // 
            // btn_send
            // 
            btn_send.Location = new Point(281, 82);
            btn_send.Name = "btn_send";
            btn_send.Size = new Size(75, 23);
            btn_send.TabIndex = 1;
            btn_send.Text = "Send";
            btn_send.UseVisualStyleBackColor = true;
            btn_send.Click += btn_send_Click;
            // 
            // btn_sendToGrp
            // 
            btn_sendToGrp.Location = new Point(109, 162);
            btn_sendToGrp.Name = "btn_sendToGrp";
            btn_sendToGrp.Size = new Size(120, 23);
            btn_sendToGrp.TabIndex = 2;
            btn_sendToGrp.Text = "Send to group";
            btn_sendToGrp.UseVisualStyleBackColor = true;
            btn_sendToGrp.Click += btn_sendToGrp_Click;
            // 
            // btn_join
            // 
            btn_join.Location = new Point(281, 113);
            btn_join.Name = "btn_join";
            btn_join.Size = new Size(75, 23);
            btn_join.TabIndex = 3;
            btn_join.Text = "Join group";
            btn_join.UseVisualStyleBackColor = true;
            btn_join.Click += btn_join_Click;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(95, 51);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(162, 23);
            txt_name.TabIndex = 4;
            // 
            // txt_grpmsg
            // 
            txt_grpmsg.Location = new Point(95, 113);
            txt_grpmsg.Name = "txt_grpmsg";
            txt_grpmsg.Size = new Size(162, 23);
            txt_grpmsg.TabIndex = 5;
            // 
            // txt_msg
            // 
            txt_msg.Location = new Point(95, 83);
            txt_msg.Name = "txt_msg";
            txt_msg.Size = new Size(162, 23);
            txt_msg.TabIndex = 6;
            txt_msg.Enter += txt_msg_Enter;
            txt_msg.Leave += txt_msg_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 54);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 7;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 86);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 8;
            label2.Text = "Message";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 117);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 9;
            label3.Text = "Group";
            // 
            // TypingNotification
            // 
            TypingNotification.AutoSize = true;
            TypingNotification.Location = new Point(41, 389);
            TypingNotification.Name = "TypingNotification";
            TypingNotification.Size = new Size(0, 15);
            TypingNotification.TabIndex = 10;
            // 
            // Chatapp
            // 
            AccessibleName = "";
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TypingNotification);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_msg);
            Controls.Add(txt_grpmsg);
            Controls.Add(txt_name);
            Controls.Add(btn_join);
            Controls.Add(btn_sendToGrp);
            Controls.Add(btn_send);
            Controls.Add(msgs_box);
            Name = "Chatapp";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox msgs_box;
        private Button btn_send;
        private Button btn_sendToGrp;
        private Button btn_join;
        private TextBox txt_name;
        private TextBox txt_grpmsg;
        private TextBox txt_msg;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label TypingNotification;
    }
}
