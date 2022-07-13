using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using MinecraftServerInfoGrabber.grabber;

namespace MinecraftServerInfoGrabber
{
    /**
     * author: WhiteFaceHair
     * e-mail: whitefacehair@gmail.com
     * 
     * Minecraft Server Info Grabber
     */
    
    public partial class Form1 : Form
    {
        public static readonly string API_NONE = "옆의 화살표를 눌러 선택하세요";
        public static readonly string API_MCSRVSTAT = "Minecraft Server Status API";
        public static readonly string API_MINETOOLS = "MineTools";

        public static readonly string LABEL_UPDATE = "서버 정보를 불러오는 중..";
        public static readonly string LABEL_OFFLINE = "서버가 닫혀있습니다";

        private bool _isUpdate = false;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Mb(string message) // 명박 아님 ㅎ
        {
            MessageBox.Show(message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async void UpdateListView()
        {
            if (this._isUpdate)
            {
                return;
            }

            try
            {
                await Task.Run(() =>
                {
                    this._isUpdate = true;
                    this.labelServerRunningStatus.Text = LABEL_UPDATE;
                    this.listView.Items.Clear();

                    var isOnline = true;
                    var selectedApi = this.comboBoxApi.Text;
                    var address = this.textBoxGroupBoxAddress.Text;
                    var port = this.textBoxGroupBoxPort.Text;

                    string serverMotd = "", serverSoftware = "", serverVersion = "";
                    int playerCount = 0, maxPlayerCount = 0;
                    var playerList = new Dictionary<string, string>();


                    // 분명 더 깔끔한 방법이 있을 거임
                    switch (selectedApi)
                    {
                        case "Minecraft Server Status API":
                        {
                            var api = new Mcsrvstat(address, int.Parse(port));
                            if (!api.IsServerRunning())
                            {
                                isOnline = false;
                                break;
                            }

                            serverMotd = api.GetServerMotd();
                            serverSoftware = api.GetServerSoftware();
                            serverVersion = api.GetServerVersion();
                            playerCount = api.GetPlayerCount();
                            maxPlayerCount = api.GetMaxPlayerCount();
                            playerList = api.GetPlayersWithUuid();

                            break;
                        }

                        case "MineTools":
                        {
                            var api = new Minetools(address, int.Parse(port));
                            if (!api.IsServerRunning())
                            {
                                isOnline = false;
                                break;
                            }

                            serverMotd = api.GetServerMotd();
                            serverSoftware = api.GetServerSoftware();
                            serverVersion = api.GetServerVersion();
                            playerCount = api.GetPlayerCount();
                            maxPlayerCount = api.GetMaxPlayerCount();
                            playerList = api.GetPlayersWithUuid();

                            break;
                        }

                        default:
                            this.Mb("올바른 API가 아닙니다.");
                            this._isUpdate = false;

                            this.labelServerRunningStatus.Text = LABEL_OFFLINE;
                            this.labelServerRunningStatus.ForeColor = Color.Red;
                            return;
                    }

                    if (!isOnline)
                    {
                        this.labelServerRunningStatus.Text = LABEL_OFFLINE;
                        this.labelServerRunningStatus.ForeColor = Color.Red;
                    }
                    else
                    {
                        this.labelServerRunningStatus.Text = serverMotd;
                        this.labelServerRunningStatus.ForeColor = Color.Green;

                        var nullItem = new string[] {""};
                        var software = new string[] {"", "구동기", serverSoftware};
                        var version = new string[] {"", "버전", serverVersion};
                        var count = new string[] {"", "접속 인원", playerCount + " / " + maxPlayerCount};

                        this.listView.Items.Add(new ListViewItem(software));
                        this.listView.Items.Add(new ListViewItem(version));
                        this.listView.Items.Add(new ListViewItem(count));
                        this.listView.Items.Add(new ListViewItem(nullItem));
                        this.listView.Items.Add(new ListViewItem(new[] {"", "연결 됨 :"}));

                        foreach (var p in playerList.Keys)
                        {
                            this.listView.Items.Add(new ListViewItem(new string[] {"", p, playerList[p]}));
                        }
                    }

                    this._isUpdate = false;
                });
            }
            catch (Exception e)
            {
                this.labelServerRunningStatus.Text = LABEL_OFFLINE;
                this.labelServerRunningStatus.ForeColor = Color.Red;
                this._isUpdate = false;
                
                this.Mb("오류가 발생했습니다.\n영어가 아닌 도메인을 사용하는 서버는 Minecraft Server Status API를 사용해 확인하십시오.\n(" + e.Message + ")");
            }
        }

        private void buttonGroupBoxCheck_Click(object sender, EventArgs e)
        {
            if (this.comboBoxApi.Text == API_NONE)
            {
                this.Mb("API를 선택해 주십시오.");
                return;
            }

            var address = this.textBoxGroupBoxAddress.Text.Replace(" ", "");
            var port = this.textBoxGroupBoxPort.Text.Replace(" ", "");

            if (address.Length <= 0 || port.Length <= 0)
            {
                this.Mb("서버 주소와 포트를 입력해 주십시오.");
                return;
            }

            if (!int.TryParse(port, out var result))
            {
                this.Mb("올바르지 않은 포트입니다.");
                return;
            }

            this.UpdateListView();
        }

        private void buttonGroupBoxReset_Click(object sender, EventArgs e)
        {
            this.textBoxGroupBoxAddress.Text = "";
            this.textBoxGroupBoxPort.Text = "25565";
        }
    }
}