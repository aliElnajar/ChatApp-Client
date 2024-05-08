using Microsoft.AspNetCore.SignalR.Client;
namespace chatApp
{
    public partial class Chatapp : Form
    {
        public Chatapp()
        {
            InitializeComponent();
        }
        HubConnection con;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Chat app";
            con = new HubConnectionBuilder().WithUrl("http://localhost:5057/chat").Build();

            con.StartAsync();

            con.On<messdata>("newmessage", (mess) => 
            msgs_box.Invoke(() => msgs_box.Items.Add(mess.username + ": " + mess.messagetxt)));
            con.On<string, string>("newmember", (n, g) => msgs_box.Invoke(() => msgs_box.Items.Add(n + " joined "
                + g)));
            con.On<string, string, string>("groupmessage", (n, m, g) => msgs_box.Invoke(() => msgs_box.Items.Add(n +
                "(" + g + "): " + m)));

            con.On<string>("typingnotification", (notification) => 
            this.TypingNotification.Invoke(() => this.TypingNotification.Text = notification));

        }
        private void btn_join_Click(object sender, EventArgs e)
        {
            string usrname = txt_name.Text;
            string grpname = txt_grpmsg.Text;
            con.InvokeAsync("joingroup", grpname, usrname);

        }





        private void btn_send_Click(object sender, EventArgs e)
        {
            messdata msg = new messdata()
            {
                username = txt_name.Text,
                messagetxt = txt_msg.Text,
                groupname = "All"

            };
            con.InvokeAsync("sendmessage", msg);
            txt_msg.Text = "";
        }

        private void btn_sendToGrp_Click(object sender, EventArgs e)
        {

            string username = txt_name.Text;
            string groupname = txt_grpmsg.Text;
            string messagetxt = txt_msg.Text;
            con.InvokeAsync("sendToGroup", username, messagetxt, groupname);
            txt_msg.Text = "";

        }





        private void txt_msg_Enter(object sender, EventArgs e)
        {
            con.InvokeAsync("personistypingnotification", txt_name.Text);

        }private void txt_msg_Leave(object sender, EventArgs e)
        {
         con.InvokeAsync("personstoppedtypingnotification");
        }
    }
}
