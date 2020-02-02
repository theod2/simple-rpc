using Newtonsoft.Json;
using System.IO;
using System.Windows.Forms;

namespace simple_rpc
{
    public partial class ConfigForm : Form
    {
        public ConfigForm()
        {
            InitializeComponent();
            string dir = Directory.GetCurrentDirectory();
            string data = File.ReadAllText(dir + "\\data.txt");
            RpcData rpcData = JsonConvert.DeserializeObject<RpcData>(data);
            IdBox.Text = rpcData.id;
            GIN.Text = rpcData.gin;
            GIT.Text = rpcData.git;
            PIN.Text = rpcData.pin;
            PIT.Text = rpcData.pit;
            firstline.Text = rpcData.fl;
            secondline.Text = rpcData.sl;
        }

        private void submit_Click(object sender, System.EventArgs e)
        {
                 

            RpcData rpcData = new RpcData();
            rpcData.id = IdBox.Text;
            rpcData.gin = GIN.Text;
            rpcData.git = GIT.Text;
            rpcData.pin = PIN.Text;
            rpcData.pit = PIT.Text;
            rpcData.fl = firstline.Text;
            rpcData.sl = secondline.Text;
            string jsonData = JsonConvert.SerializeObject(rpcData);
            string dir = Directory.GetCurrentDirectory();
            File.WriteAllText(dir + "\\data.txt", jsonData);
        }
    }
}