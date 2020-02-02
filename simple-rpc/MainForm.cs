using DiscordRPC;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Runtime.Remoting;
using System.Windows.Forms;
using DiscordRPC.Message;

namespace simple_rpc
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void configbtn_Click(object sender, System.EventArgs e)
        {
            new ConfigForm().Show();
        }

        private void startbtn_Click(object sender, EventArgs e)
        {
            string dir = Directory.GetCurrentDirectory();
            string data = File.ReadAllText(dir + "\\data.txt");
            RpcData rpcData = JsonConvert.DeserializeObject<RpcData>(data);
            DiscordRpcClient client;



            try
            {
                Label console = new Label();
                console.Parent = this;
                console.BorderStyle = BorderStyle.Fixed3D;
                console.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                console.Location = new System.Drawing.Point(12, 64);
                console.Name = "console";
                console.Size = new System.Drawing.Size(776, 222);
                console.TabIndex = 3;
                console.Text = "";
                client = new DiscordRpcClient(rpcData.id);
                client.OnReady += (s, err) =>
                    {
                        console.Text = console.Text += "\n Démarré pour " + err.User.Username + "#" + err.User.Discriminator;
                    };
                client.OnPresenceUpdate += (s, err) => {  };
                client.Initialize();
                client.SetPresence(new RichPresence()
                {
                    Details = rpcData.fl,
                    State = rpcData.sl,
                    Assets = new Assets()
                    {
                        LargeImageKey = rpcData.gin,
                        LargeImageText = rpcData.git,
                        SmallImageKey = rpcData.pin,
                        SmallImageText = rpcData.pit,
                    }
                });
            }
            catch (Exception error)
            {
                string title = "Erreur";
                string message = "Une erreur est survenue :\n" + error;
                MessageBox.Show(message, title, MessageBoxButtons.OK ,MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

    



       
    
