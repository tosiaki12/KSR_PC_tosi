namespace Serial_kawana_2020
{
    partial class serial
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
            this.components = new System.ComponentModel.Container();
            this.タブコントロール = new System.Windows.Forms.TabControl();
            this.テキスト送受信タブ = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.試験送信ボタン = new System.Windows.Forms.Button();
            this.命令化チェックボックス = new System.Windows.Forms.CheckBox();
            this.状態グリッド = new System.Windows.Forms.DataGridView();
            this.名前 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.状態 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.標準 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.portGroupBox = new System.Windows.Forms.GroupBox();
            this.接続ボタン = new System.Windows.Forms.Button();
            this.ポートコンボボックス = new System.Windows.Forms.ComboBox();
            this.通信ログラベル = new System.Windows.Forms.Label();
            this.送信テキストボックス = new System.Windows.Forms.TextBox();
            this.送信ボタン = new System.Windows.Forms.Button();
            this.通信ログボックス = new System.Windows.Forms.TextBox();
            this.制御タブ = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.操作ボタンボックス = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.出力切断ボタン = new System.Windows.Forms.Button();
            this.操作状態ラベル = new System.Windows.Forms.Label();
            this.左旋回ボタン = new System.Windows.Forms.Button();
            this.後退ボタン = new System.Windows.Forms.Button();
            this.右旋回ボタン = new System.Windows.Forms.Button();
            this.前進ボタン = new System.Windows.Forms.Button();
            this.停止ボタン = new System.Windows.Forms.Button();
            this.命令文一覧タブ = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.ピン管理タブ = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.確認タイマー = new System.Windows.Forms.Timer(this.components);
            this.シリアルポート = new System.IO.Ports.SerialPort(this.components);
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.タブコントロール.SuspendLayout();
            this.テキスト送受信タブ.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.状態グリッド)).BeginInit();
            this.portGroupBox.SuspendLayout();
            this.制御タブ.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.操作ボタンボックス.SuspendLayout();
            this.命令文一覧タブ.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // タブコントロール
            // 
            this.タブコントロール.Controls.Add(this.テキスト送受信タブ);
            this.タブコントロール.Controls.Add(this.制御タブ);
            this.タブコントロール.Controls.Add(this.命令文一覧タブ);
            this.タブコントロール.Controls.Add(this.ピン管理タブ);
            this.タブコントロール.Controls.Add(this.tabPage1);
            this.タブコントロール.Dock = System.Windows.Forms.DockStyle.Fill;
            this.タブコントロール.Location = new System.Drawing.Point(0, 0);
            this.タブコントロール.Name = "タブコントロール";
            this.タブコントロール.SelectedIndex = 0;
            this.タブコントロール.Size = new System.Drawing.Size(784, 461);
            this.タブコントロール.TabIndex = 0;
            // 
            // テキスト送受信タブ
            // 
            this.テキスト送受信タブ.BackColor = System.Drawing.SystemColors.Control;
            this.テキスト送受信タブ.Controls.Add(this.splitContainer1);
            this.テキスト送受信タブ.Location = new System.Drawing.Point(4, 22);
            this.テキスト送受信タブ.Name = "テキスト送受信タブ";
            this.テキスト送受信タブ.Padding = new System.Windows.Forms.Padding(3);
            this.テキスト送受信タブ.Size = new System.Drawing.Size(776, 435);
            this.テキスト送受信タブ.TabIndex = 0;
            this.テキスト送受信タブ.Text = "テキスト送受信";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Panel1.Controls.Add(this.状態グリッド);
            this.splitContainer1.Panel1.Controls.Add(this.portGroupBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.通信ログラベル);
            this.splitContainer1.Panel2.Controls.Add(this.送信テキストボックス);
            this.splitContainer1.Panel2.Controls.Add(this.送信ボタン);
            this.splitContainer1.Panel2.Controls.Add(this.通信ログボックス);
            this.splitContainer1.Size = new System.Drawing.Size(770, 429);
            this.splitContainer1.SplitterDistance = 248;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel1.Controls.Add(this.試験送信ボタン);
            this.flowLayoutPanel1.Controls.Add(this.命令化チェックボックス);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(5, 177);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(237, 102);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // 試験送信ボタン
            // 
            this.試験送信ボタン.Location = new System.Drawing.Point(3, 3);
            this.試験送信ボタン.Name = "試験送信ボタン";
            this.試験送信ボタン.Size = new System.Drawing.Size(75, 23);
            this.試験送信ボタン.TabIndex = 0;
            this.試験送信ボタン.Text = "試験";
            this.試験送信ボタン.UseVisualStyleBackColor = true;
            this.試験送信ボタン.Click += new System.EventHandler(this.試験送信ボタン_Click);
            // 
            // 命令化チェックボックス
            // 
            this.命令化チェックボックス.AutoSize = true;
            this.命令化チェックボックス.Dock = System.Windows.Forms.DockStyle.Fill;
            this.命令化チェックボックス.Location = new System.Drawing.Point(88, 7);
            this.命令化チェックボックス.Margin = new System.Windows.Forms.Padding(7);
            this.命令化チェックボックス.Name = "命令化チェックボックス";
            this.命令化チェックボックス.Size = new System.Drawing.Size(98, 16);
            this.命令化チェックボックス.TabIndex = 1;
            this.命令化チェックボックス.Text = "命令として送信";
            this.命令化チェックボックス.UseVisualStyleBackColor = true;
            // 
            // 状態グリッド
            // 
            this.状態グリッド.ColumnHeadersHeight = 24;
            this.状態グリッド.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.状態グリッド.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.名前,
            this.状態,
            this.標準});
            this.状態グリッド.Location = new System.Drawing.Point(3, 285);
            this.状態グリッド.Name = "状態グリッド";
            this.状態グリッド.RowHeadersWidth = 10;
            this.状態グリッド.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.状態グリッド.RowTemplate.Height = 21;
            this.状態グリッド.Size = new System.Drawing.Size(239, 139);
            this.状態グリッド.TabIndex = 6;
            this.状態グリッド.TabStop = false;
            // 
            // 名前
            // 
            this.名前.DividerWidth = 1;
            this.名前.HeaderText = "名前";
            this.名前.Name = "名前";
            this.名前.ReadOnly = true;
            this.名前.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.名前.Width = 80;
            // 
            // 状態
            // 
            this.状態.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.状態.HeaderText = "状態";
            this.状態.Name = "状態";
            this.状態.ReadOnly = true;
            this.状態.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.状態.Width = 120;
            // 
            // 標準
            // 
            this.標準.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.標準.HeaderText = "標準";
            this.標準.Name = "標準";
            this.標準.ReadOnly = true;
            this.標準.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.標準.Width = 120;
            // 
            // portGroupBox
            // 
            this.portGroupBox.Controls.Add(this.接続ボタン);
            this.portGroupBox.Controls.Add(this.ポートコンボボックス);
            this.portGroupBox.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.portGroupBox.Location = new System.Drawing.Point(0, 3);
            this.portGroupBox.Name = "portGroupBox";
            this.portGroupBox.Size = new System.Drawing.Size(245, 168);
            this.portGroupBox.TabIndex = 0;
            this.portGroupBox.TabStop = false;
            this.portGroupBox.Text = "ポート：";
            // 
            // 接続ボタン
            // 
            this.接続ボタン.Location = new System.Drawing.Point(61, 76);
            this.接続ボタン.Name = "接続ボタン";
            this.接続ボタン.Size = new System.Drawing.Size(117, 70);
            this.接続ボタン.TabIndex = 1;
            this.接続ボタン.Text = "接続";
            this.接続ボタン.UseVisualStyleBackColor = true;
            this.接続ボタン.Click += new System.EventHandler(this.接続ボタン_Click);
            // 
            // ポートコンボボックス
            // 
            this.ポートコンボボックス.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ポートコンボボックス.FormattingEnabled = true;
            this.ポートコンボボックス.Location = new System.Drawing.Point(41, 26);
            this.ポートコンボボックス.Name = "ポートコンボボックス";
            this.ポートコンボボックス.Size = new System.Drawing.Size(164, 24);
            this.ポートコンボボックス.TabIndex = 0;
            // 
            // 通信ログラベル
            // 
            this.通信ログラベル.BackColor = System.Drawing.Color.Gainsboro;
            this.通信ログラベル.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.通信ログラベル.Location = new System.Drawing.Point(3, 3);
            this.通信ログラベル.Name = "通信ログラベル";
            this.通信ログラベル.Size = new System.Drawing.Size(540, 23);
            this.通信ログラベル.TabIndex = 3;
            this.通信ログラベル.Text = "通信ログ";
            // 
            // 送信テキストボックス
            // 
            this.送信テキストボックス.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.送信テキストボックス.Location = new System.Drawing.Point(111, 322);
            this.送信テキストボックス.Multiline = true;
            this.送信テキストボックス.Name = "送信テキストボックス";
            this.送信テキストボックス.Size = new System.Drawing.Size(402, 102);
            this.送信テキストボックス.TabIndex = 2;
            this.送信テキストボックス.TextChanged += new System.EventHandler(this.送信テキストボックス_TextChanged);
            // 
            // 送信ボタン
            // 
            this.送信ボタン.BackColor = System.Drawing.Color.DarkRed;
            this.送信ボタン.Font = new System.Drawing.Font("Meiryo UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.送信ボタン.Location = new System.Drawing.Point(3, 322);
            this.送信ボタン.Name = "送信ボタン";
            this.送信ボタン.Size = new System.Drawing.Size(102, 102);
            this.送信ボタン.TabIndex = 1;
            this.送信ボタン.Text = "送\r\n信";
            this.送信ボタン.UseVisualStyleBackColor = false;
            this.送信ボタン.Click += new System.EventHandler(this.送信ボタン_Click);
            // 
            // 通信ログボックス
            // 
            this.通信ログボックス.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.通信ログボックス.Location = new System.Drawing.Point(3, 29);
            this.通信ログボックス.Multiline = true;
            this.通信ログボックス.Name = "通信ログボックス";
            this.通信ログボックス.ReadOnly = true;
            this.通信ログボックス.Size = new System.Drawing.Size(510, 287);
            this.通信ログボックス.TabIndex = 0;
            // 
            // 制御タブ
            // 
            this.制御タブ.Controls.Add(this.splitContainer2);
            this.制御タブ.Location = new System.Drawing.Point(4, 22);
            this.制御タブ.Name = "制御タブ";
            this.制御タブ.Padding = new System.Windows.Forms.Padding(3);
            this.制御タブ.Size = new System.Drawing.Size(776, 435);
            this.制御タブ.TabIndex = 1;
            this.制御タブ.Text = "制御";
            this.制御タブ.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer2.Panel2.Controls.Add(this.label3);
            this.splitContainer2.Panel2.Controls.Add(this.label2);
            this.splitContainer2.Panel2.Controls.Add(this.操作ボタンボックス);
            this.splitContainer2.Size = new System.Drawing.Size(770, 429);
            this.splitContainer2.SplitterDistance = 382;
            this.splitContainer2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.label3.Location = new System.Drawing.Point(96, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(279, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "未実装";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "状態：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // 操作ボタンボックス
            // 
            this.操作ボタンボックス.BackColor = System.Drawing.SystemColors.Control;
            this.操作ボタンボックス.Controls.Add(this.label1);
            this.操作ボタンボックス.Controls.Add(this.出力切断ボタン);
            this.操作ボタンボックス.Controls.Add(this.操作状態ラベル);
            this.操作ボタンボックス.Controls.Add(this.左旋回ボタン);
            this.操作ボタンボックス.Controls.Add(this.後退ボタン);
            this.操作ボタンボックス.Controls.Add(this.右旋回ボタン);
            this.操作ボタンボックス.Controls.Add(this.前進ボタン);
            this.操作ボタンボックス.Controls.Add(this.停止ボタン);
            this.操作ボタンボックス.Location = new System.Drawing.Point(5, 58);
            this.操作ボタンボックス.Name = "操作ボタンボックス";
            this.操作ボタンボックス.Size = new System.Drawing.Size(376, 366);
            this.操作ボタンボックス.TabIndex = 0;
            this.操作ボタンボックス.TabStop = false;
            this.操作ボタンボックス.Text = "操作ボタン";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "速度";
            // 
            // 出力切断ボタン
            // 
            this.出力切断ボタン.BackColor = System.Drawing.Color.Firebrick;
            this.出力切断ボタン.Font = new System.Drawing.Font("MS UI Gothic", 30F, System.Drawing.FontStyle.Bold);
            this.出力切断ボタン.Location = new System.Drawing.Point(28, 18);
            this.出力切断ボタン.Name = "出力切断ボタン";
            this.出力切断ボタン.Size = new System.Drawing.Size(110, 110);
            this.出力切断ボタン.TabIndex = 6;
            this.出力切断ボタン.Text = "切\r\n断";
            this.出力切断ボタン.UseVisualStyleBackColor = false;
            this.出力切断ボタン.Click += new System.EventHandler(this.出力切断ボタン_Click);
            // 
            // 操作状態ラベル
            // 
            this.操作状態ラベル.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.操作状態ラベル.Location = new System.Drawing.Point(260, 21);
            this.操作状態ラベル.Name = "操作状態ラベル";
            this.操作状態ラベル.Size = new System.Drawing.Size(110, 110);
            this.操作状態ラベル.TabIndex = 5;
            this.操作状態ラベル.Text = "無";
            this.操作状態ラベル.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // 左旋回ボタン
            // 
            this.左旋回ボタン.Font = new System.Drawing.Font("MS UI Gothic", 25F);
            this.左旋回ボタン.Location = new System.Drawing.Point(28, 134);
            this.左旋回ボタン.Name = "左旋回ボタン";
            this.左旋回ボタン.Size = new System.Drawing.Size(110, 110);
            this.左旋回ボタン.TabIndex = 3;
            this.左旋回ボタン.Text = "左\r\n旋\r\n回";
            this.左旋回ボタン.UseVisualStyleBackColor = true;
            this.左旋回ボタン.Click += new System.EventHandler(this.操作ボタンs_Click);
            // 
            // 後退ボタン
            // 
            this.後退ボタン.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.後退ボタン.Font = new System.Drawing.Font("MS UI Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.後退ボタン.ForeColor = System.Drawing.SystemColors.ControlText;
            this.後退ボタン.Location = new System.Drawing.Point(144, 250);
            this.後退ボタン.Name = "後退ボタン";
            this.後退ボタン.Size = new System.Drawing.Size(110, 110);
            this.後退ボタン.TabIndex = 4;
            this.後退ボタン.Text = "後\r\n退";
            this.後退ボタン.UseVisualStyleBackColor = true;
            this.後退ボタン.Click += new System.EventHandler(this.操作ボタンs_Click);
            // 
            // 右旋回ボタン
            // 
            this.右旋回ボタン.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.右旋回ボタン.Font = new System.Drawing.Font("MS UI Gothic", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.右旋回ボタン.Location = new System.Drawing.Point(260, 134);
            this.右旋回ボタン.Name = "右旋回ボタン";
            this.右旋回ボタン.Size = new System.Drawing.Size(110, 110);
            this.右旋回ボタン.TabIndex = 2;
            this.右旋回ボタン.Text = "右\r\n旋\r\n回";
            this.右旋回ボタン.UseVisualStyleBackColor = true;
            this.右旋回ボタン.Click += new System.EventHandler(this.操作ボタンs_Click);
            // 
            // 前進ボタン
            // 
            this.前進ボタン.Font = new System.Drawing.Font("MS UI Gothic", 30F, System.Drawing.FontStyle.Bold);
            this.前進ボタン.Location = new System.Drawing.Point(144, 18);
            this.前進ボタン.Name = "前進ボタン";
            this.前進ボタン.Size = new System.Drawing.Size(110, 110);
            this.前進ボタン.TabIndex = 1;
            this.前進ボタン.Text = "前\r\n進";
            this.前進ボタン.UseVisualStyleBackColor = true;
            this.前進ボタン.Click += new System.EventHandler(this.操作ボタンs_Click);
            // 
            // 停止ボタン
            // 
            this.停止ボタン.Font = new System.Drawing.Font("MS UI Gothic", 30F);
            this.停止ボタン.ForeColor = System.Drawing.SystemColors.ControlText;
            this.停止ボタン.Location = new System.Drawing.Point(144, 134);
            this.停止ボタン.Name = "停止ボタン";
            this.停止ボタン.Size = new System.Drawing.Size(110, 110);
            this.停止ボタン.TabIndex = 0;
            this.停止ボタン.Text = "停\r\n止";
            this.停止ボタン.UseVisualStyleBackColor = true;
            this.停止ボタン.Click += new System.EventHandler(this.操作ボタンs_Click);
            // 
            // 命令文一覧タブ
            // 
            this.命令文一覧タブ.Controls.Add(this.listBox1);
            this.命令文一覧タブ.Location = new System.Drawing.Point(4, 22);
            this.命令文一覧タブ.Name = "命令文一覧タブ";
            this.命令文一覧タブ.Padding = new System.Windows.Forms.Padding(3);
            this.命令文一覧タブ.Size = new System.Drawing.Size(776, 435);
            this.命令文一覧タブ.TabIndex = 3;
            this.命令文一覧タブ.Text = "命令文一覧";
            this.命令文一覧タブ.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Items.AddRange(new object[] {
            "echo"});
            this.listBox1.Location = new System.Drawing.Point(-4, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(420, 136);
            this.listBox1.TabIndex = 0;
            // 
            // ピン管理タブ
            // 
            this.ピン管理タブ.Location = new System.Drawing.Point(4, 22);
            this.ピン管理タブ.Name = "ピン管理タブ";
            this.ピン管理タブ.Padding = new System.Windows.Forms.Padding(3);
            this.ピン管理タブ.Size = new System.Drawing.Size(776, 435);
            this.ピン管理タブ.TabIndex = 4;
            this.ピン管理タブ.Text = "ピン管理";
            this.ピン管理タブ.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(776, 435);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "イルミネーション制御";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(3, 3);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.flowLayoutPanel3);
            this.splitContainer3.Size = new System.Drawing.Size(770, 429);
            this.splitContainer3.SplitterDistance = 211;
            this.splitContainer3.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Controls.Add(this.button4, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.button3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox4, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox3, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(762, 206);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button4.Location = new System.Drawing.Point(82, 158);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(69, 43);
            this.button4.TabIndex = 14;
            this.button4.Text = "送信";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button3.Location = new System.Drawing.Point(82, 107);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(69, 43);
            this.button3.TabIndex = 13;
            this.button3.Text = "送信";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button2.Location = new System.Drawing.Point(82, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(69, 43);
            this.button2.TabIndex = 12;
            this.button2.Text = "送信";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox4
            // 
            this.textBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox4.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox4.Location = new System.Drawing.Point(159, 158);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(598, 39);
            this.textBox4.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox3.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox3.Location = new System.Drawing.Point(159, 107);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(598, 39);
            this.textBox3.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox2.Location = new System.Drawing.Point(159, 56);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(598, 39);
            this.textBox2.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.LightGray;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(5, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 49);
            this.label5.TabIndex = 1;
            this.label5.Text = "1";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.LightGray;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(5, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 49);
            this.label4.TabIndex = 0;
            this.label4.Text = "3";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.LightGray;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(5, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 49);
            this.label6.TabIndex = 2;
            this.label6.Text = "2";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.LightGray;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(5, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 49);
            this.label7.TabIndex = 3;
            this.label7.Text = "4";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox1.Location = new System.Drawing.Point(159, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(598, 39);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(82, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 43);
            this.button1.TabIndex = 11;
            this.button1.Text = "送信";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // 確認タイマー
            // 
            this.確認タイマー.Enabled = true;
            this.確認タイマー.Interval = 5000;
            this.確認タイマー.Tick += new System.EventHandler(this.確認タイマー_Tick);
            // 
            // シリアルポート
            // 
            this.シリアルポート.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.シリアルポート_DataReceived);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button7.Location = new System.Drawing.Point(321, 138);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(153, 61);
            this.button7.TabIndex = 2;
            this.button7.Text = "消灯";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button6.Location = new System.Drawing.Point(162, 138);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(153, 61);
            this.button6.TabIndex = 1;
            this.button6.Text = "停止";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button5.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button5.Location = new System.Drawing.Point(3, 138);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(153, 61);
            this.button5.TabIndex = 0;
            this.button5.Text = "点灯";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BackColor = System.Drawing.Color.Gainsboro;
            this.flowLayoutPanel3.Controls.Add(this.textBox5);
            this.flowLayoutPanel3.Controls.Add(this.button5);
            this.flowLayoutPanel3.Controls.Add(this.button6);
            this.flowLayoutPanel3.Controls.Add(this.button7);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(770, 214);
            this.flowLayoutPanel3.TabIndex = 0;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox5.Location = new System.Drawing.Point(3, 3);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox5.Size = new System.Drawing.Size(759, 129);
            this.textBox5.TabIndex = 3;
            // 
            // serial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.タブコントロール);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "serial";
            this.Text = "シリアル通信2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.serial_FormClosed);
            this.Load += new System.EventHandler(this.serial_Load);
            this.タブコントロール.ResumeLayout(false);
            this.テキスト送受信タブ.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.状態グリッド)).EndInit();
            this.portGroupBox.ResumeLayout(false);
            this.制御タブ.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.操作ボタンボックス.ResumeLayout(false);
            this.操作ボタンボックス.PerformLayout();
            this.命令文一覧タブ.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl タブコントロール;
        private System.Windows.Forms.TabPage テキスト送受信タブ;
        private System.Windows.Forms.TabPage 制御タブ;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox portGroupBox;
        private System.Windows.Forms.ComboBox ポートコンボボックス;
        private System.Windows.Forms.Button 接続ボタン;
        private System.Windows.Forms.TextBox 通信ログボックス;
        private System.Windows.Forms.Button 送信ボタン;
        private System.Windows.Forms.TextBox 送信テキストボックス;
        private System.Windows.Forms.Label 通信ログラベル;
        private System.Windows.Forms.Timer 確認タイマー;
        private System.Windows.Forms.DataGridView 状態グリッド;
        private System.Windows.Forms.DataGridViewTextBoxColumn 名前;
        private System.Windows.Forms.DataGridViewTextBoxColumn 状態;
        private System.Windows.Forms.DataGridViewTextBoxColumn 標準;
        private System.IO.Ports.SerialPort シリアルポート;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button 試験送信ボタン;
        private System.Windows.Forms.CheckBox 命令化チェックボックス;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button 右旋回ボタン;
        private System.Windows.Forms.Button 左旋回ボタン;
        private System.Windows.Forms.Button 前進ボタン;
        private System.Windows.Forms.Button 後退ボタン;
        private System.Windows.Forms.Button 停止ボタン;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox 操作ボタンボックス;
        private System.Windows.Forms.Button 出力切断ボタン;
        private System.Windows.Forms.Label 操作状態ラベル;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage 命令文一覧タブ;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TabPage ピン管理タブ;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}