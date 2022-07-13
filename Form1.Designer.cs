namespace MinecraftServerInfoGrabber
{
    partial class Form1
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.buttonGroupBoxCheck = new System.Windows.Forms.Button();
            this.buttonGroupBoxReset = new System.Windows.Forms.Button();
            this.labelGroupBoxPort = new System.Windows.Forms.Label();
            this.textBoxGroupBoxPort = new System.Windows.Forms.TextBox();
            this.labelGroupBoxAddress = new System.Windows.Forms.Label();
            this.textBoxGroupBoxAddress = new System.Windows.Forms.TextBox();
            this.labelServerRunningStatus = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.ColumnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.ColumnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.groupBoxApi = new System.Windows.Forms.GroupBox();
            this.comboBoxApi = new System.Windows.Forms.ComboBox();
            this.groupBox.SuspendLayout();
            this.groupBoxApi.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.buttonGroupBoxCheck);
            this.groupBox.Controls.Add(this.buttonGroupBoxReset);
            this.groupBox.Controls.Add(this.labelGroupBoxPort);
            this.groupBox.Controls.Add(this.textBoxGroupBoxPort);
            this.groupBox.Controls.Add(this.labelGroupBoxAddress);
            this.groupBox.Controls.Add(this.textBoxGroupBoxAddress);
            this.groupBox.Location = new System.Drawing.Point(12, 305);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(340, 94);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "확인할 서버";
            // 
            // buttonGroupBoxCheck
            // 
            this.buttonGroupBoxCheck.Location = new System.Drawing.Point(6, 61);
            this.buttonGroupBoxCheck.Name = "buttonGroupBoxCheck";
            this.buttonGroupBoxCheck.Size = new System.Drawing.Size(204, 27);
            this.buttonGroupBoxCheck.TabIndex = 5;
            this.buttonGroupBoxCheck.Text = "확인하기";
            this.buttonGroupBoxCheck.UseVisualStyleBackColor = true;
            this.buttonGroupBoxCheck.Click += new System.EventHandler(this.buttonGroupBoxCheck_Click);
            // 
            // buttonGroupBoxReset
            // 
            this.buttonGroupBoxReset.Location = new System.Drawing.Point(231, 61);
            this.buttonGroupBoxReset.Name = "buttonGroupBoxReset";
            this.buttonGroupBoxReset.Size = new System.Drawing.Size(103, 27);
            this.buttonGroupBoxReset.TabIndex = 4;
            this.buttonGroupBoxReset.Text = "초기화";
            this.buttonGroupBoxReset.UseVisualStyleBackColor = true;
            this.buttonGroupBoxReset.Click += new System.EventHandler(this.buttonGroupBoxReset_Click);
            // 
            // labelGroupBoxPort
            // 
            this.labelGroupBoxPort.AutoSize = true;
            this.labelGroupBoxPort.Location = new System.Drawing.Point(231, 17);
            this.labelGroupBoxPort.Name = "labelGroupBoxPort";
            this.labelGroupBoxPort.Size = new System.Drawing.Size(57, 12);
            this.labelGroupBoxPort.TabIndex = 3;
            this.labelGroupBoxPort.Text = "서버 포트";
            // 
            // textBoxGroupBoxPort
            // 
            this.textBoxGroupBoxPort.Location = new System.Drawing.Point(231, 33);
            this.textBoxGroupBoxPort.Name = "textBoxGroupBoxPort";
            this.textBoxGroupBoxPort.Size = new System.Drawing.Size(103, 21);
            this.textBoxGroupBoxPort.TabIndex = 2;
            this.textBoxGroupBoxPort.Text = "25565";
            // 
            // labelGroupBoxAddress
            // 
            this.labelGroupBoxAddress.AutoSize = true;
            this.labelGroupBoxAddress.Location = new System.Drawing.Point(6, 18);
            this.labelGroupBoxAddress.Name = "labelGroupBoxAddress";
            this.labelGroupBoxAddress.Size = new System.Drawing.Size(57, 12);
            this.labelGroupBoxAddress.TabIndex = 1;
            this.labelGroupBoxAddress.Text = "서버 주소";
            // 
            // textBoxGroupBoxAddress
            // 
            this.textBoxGroupBoxAddress.Location = new System.Drawing.Point(6, 33);
            this.textBoxGroupBoxAddress.Name = "textBoxGroupBoxAddress";
            this.textBoxGroupBoxAddress.Size = new System.Drawing.Size(204, 21);
            this.textBoxGroupBoxAddress.TabIndex = 0;
            // 
            // labelServerRunningStatus
            // 
            this.labelServerRunningStatus.Font = new System.Drawing.Font("굴림", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (129)));
            this.labelServerRunningStatus.Location = new System.Drawing.Point(12, 9);
            this.labelServerRunningStatus.Name = "labelServerRunningStatus";
            this.labelServerRunningStatus.Size = new System.Drawing.Size(340, 48);
            this.labelServerRunningStatus.TabIndex = 1;
            this.labelServerRunningStatus.Text = "서버가 닫혀있음";
            this.labelServerRunningStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {this.columnHeader1, this.ColumnHeader2, this.ColumnHeader3});
            this.listView.GridLines = true;
            this.listView.Location = new System.Drawing.Point(12, 60);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(340, 191);
            this.listView.TabIndex = 2;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 0;
            // 
            // ColumnHeader2
            // 
            this.ColumnHeader2.Text = "정보";
            this.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ColumnHeader2.Width = 110;
            // 
            // ColumnHeader3
            // 
            this.ColumnHeader3.Text = "데이터";
            this.ColumnHeader3.Width = 600;
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(2, 410);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(301, 12);
            this.labelAuthor.TabIndex = 7;
            this.labelAuthor.Text = "Made By WhiteFaceHair (whitefacehair@gmail.com)";
            // 
            // groupBoxApi
            // 
            this.groupBoxApi.Controls.Add(this.comboBoxApi);
            this.groupBoxApi.Location = new System.Drawing.Point(12, 257);
            this.groupBoxApi.Name = "groupBoxApi";
            this.groupBoxApi.Size = new System.Drawing.Size(340, 42);
            this.groupBoxApi.TabIndex = 8;
            this.groupBoxApi.TabStop = false;
            this.groupBoxApi.Text = "사용할 API";
            // 
            // comboBoxApi
            // 
            this.comboBoxApi.FormattingEnabled = true;
            this.comboBoxApi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboBoxApi.Items.AddRange(new object[] {"Minecraft Server Status API", "MineTools"});
            this.comboBoxApi.Location = new System.Drawing.Point(6, 16);
            this.comboBoxApi.Name = "comboBoxApi";
            this.comboBoxApi.Size = new System.Drawing.Size(328, 20);
            this.comboBoxApi.TabIndex = 0;
            this.comboBoxApi.Text = "옆의 화살표를 눌러 선택하세요";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(364, 426);
            this.Controls.Add(this.groupBoxApi);
            this.Controls.Add(this.labelAuthor);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.labelServerRunningStatus);
            this.Controls.Add(this.groupBox);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "스갤 서버 열렸나 확인하는 거";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.groupBoxApi.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ComboBox comboBoxApi;

        private System.Windows.Forms.GroupBox groupBoxApi;

        private System.Windows.Forms.Label labelAuthor;

        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader ColumnHeader2;
        private System.Windows.Forms.ColumnHeader ColumnHeader3;

        private System.Windows.Forms.ListView listView;

        private System.Windows.Forms.Label labelGroupBoxPort;
        private System.Windows.Forms.TextBox textBoxGroupBoxPort;
        private System.Windows.Forms.Button buttonGroupBoxReset;
        private System.Windows.Forms.Button buttonGroupBoxCheck;
        private System.Windows.Forms.Label labelServerRunningStatus;

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.TextBox textBoxGroupBoxAddress;
        private System.Windows.Forms.Label labelGroupBoxAddress;

        #endregion
    }
}