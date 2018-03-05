namespace WindowsFormsApp6
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.selectButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deselectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.openAnotherPA = new System.Windows.Forms.Button();
            this.hideButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.loadButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.q4 = new System.Windows.Forms.PictureBox();
            this.offsetsLabel = new System.Windows.Forms.Label();
            this.offsetsTextBox = new System.Windows.Forms.TextBox();
            this.pointerLabel = new System.Windows.Forms.Label();
            this.q3 = new System.Windows.Forms.PictureBox();
            this.pointerTextBox = new System.Windows.Forms.TextBox();
            this.temporaryRadioButton = new System.Windows.Forms.RadioButton();
            this.permanentRadioButton = new System.Windows.Forms.RadioButton();
            this.processLabel = new System.Windows.Forms.Label();
            this.processTextBox = new System.Windows.Forms.TextBox();
            this.modulLabel = new System.Windows.Forms.Label();
            this.q2 = new System.Windows.Forms.PictureBox();
            this.q1 = new System.Windows.Forms.PictureBox();
            this.modulTextBox = new System.Windows.Forms.TextBox();
            this.useButton = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.process1 = new System.Diagnostics.Process();
            this.contextMenuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.q3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.q2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.q1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectButton
            // 
            this.selectButton.Enabled = false;
            this.selectButton.Location = new System.Drawing.Point(6, 293);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(119, 54);
            this.selectButton.TabIndex = 1;
            this.selectButton.Text = "Select";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.BackColor = System.Drawing.Color.White;
            this.listView1.CheckBoxes = true;
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.Location = new System.Drawing.Point(6, 6);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(318, 281);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.SmallIcon;
            this.listView1.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listView1_ColumnWidthChanging);
            this.listView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.listView1_KeyPress);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAllToolStripMenuItem,
            this.deselectAllToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(158, 52);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // deselectAllToolStripMenuItem
            // 
            this.deselectAllToolStripMenuItem.Name = "deselectAllToolStripMenuItem";
            this.deselectAllToolStripMenuItem.Size = new System.Drawing.Size(157, 24);
            this.deselectAllToolStripMenuItem.Text = "Deselect All";
            this.deselectAllToolStripMenuItem.Click += new System.EventHandler(this.deselectAllToolStripMenuItem_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(131, 293);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(80, 54);
            this.refreshButton.TabIndex = 2;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(345, 451);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.openAnotherPA);
            this.tabPage1.Controls.Add(this.hideButton);
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Controls.Add(this.selectButton);
            this.tabPage1.Controls.Add(this.refreshButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(337, 422);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Process Select";
            // 
            // openAnotherPA
            // 
            this.openAnotherPA.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openAnotherPA.Location = new System.Drawing.Point(6, 353);
            this.openAnotherPA.Name = "openAnotherPA";
            this.openAnotherPA.Size = new System.Drawing.Size(318, 55);
            this.openAnotherPA.TabIndex = 8;
            this.openAnotherPA.Text = "Open Another Pointer Access";
            this.openAnotherPA.UseVisualStyleBackColor = true;
            this.openAnotherPA.Click += new System.EventHandler(this.openAnotherPA_Click);
            // 
            // hideButton
            // 
            this.hideButton.Location = new System.Drawing.Point(244, 293);
            this.hideButton.Name = "hideButton";
            this.hideButton.Size = new System.Drawing.Size(80, 54);
            this.hideButton.TabIndex = 7;
            this.hideButton.Text = "Hide";
            this.hideButton.UseVisualStyleBackColor = true;
            this.hideButton.Click += new System.EventHandler(this.hideButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(337, 422);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Settings";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.useButton);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 404);
            this.panel1.TabIndex = 19;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Controls.Add(this.linkLabel2);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Location = new System.Drawing.Point(20, 249);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 122);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Alert";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(1, 85);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(189, 21);
            this.checkBox3.TabIndex = 35;
            this.checkBox3.Text = "open current the process";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(146, 55);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(44, 17);
            this.linkLabel2.TabIndex = 34;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "TEST";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(1, 54);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(149, 21);
            this.checkBox2.TabIndex = 32;
            this.checkBox2.Text = "show message box";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "frenzy",
            "new year",
            "capisci",
            "jingle bells",
            "nice cut",
            "system fault"});
            this.comboBox1.Location = new System.Drawing.Point(71, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(115, 24);
            this.comboBox1.TabIndex = 30;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(1, 24);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(64, 21);
            this.checkBox1.TabIndex = 31;
            this.checkBox1.Text = "notify";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.loadButton);
            this.panel3.Controls.Add(this.saveButton);
            this.panel3.Location = new System.Drawing.Point(204, 10);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(117, 118);
            this.panel3.TabIndex = 23;
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(3, 4);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(106, 48);
            this.loadButton.TabIndex = 14;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(3, 58);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(106, 55);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.q4);
            this.panel2.Controls.Add(this.offsetsLabel);
            this.panel2.Controls.Add(this.offsetsTextBox);
            this.panel2.Controls.Add(this.pointerLabel);
            this.panel2.Controls.Add(this.q3);
            this.panel2.Controls.Add(this.pointerTextBox);
            this.panel2.Controls.Add(this.temporaryRadioButton);
            this.panel2.Controls.Add(this.permanentRadioButton);
            this.panel2.Controls.Add(this.processLabel);
            this.panel2.Controls.Add(this.processTextBox);
            this.panel2.Controls.Add(this.modulLabel);
            this.panel2.Controls.Add(this.q2);
            this.panel2.Controls.Add(this.q1);
            this.panel2.Controls.Add(this.modulTextBox);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(191, 183);
            this.panel2.TabIndex = 22;
            // 
            // q4
            // 
            this.q4.Image = ((System.Drawing.Image)(resources.GetObject("q4.Image")));
            this.q4.Location = new System.Drawing.Point(6, 150);
            this.q4.Name = "q4";
            this.q4.Size = new System.Drawing.Size(12, 12);
            this.q4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.q4.TabIndex = 29;
            this.q4.TabStop = false;
            this.q4.Click += new System.EventHandler(this.q4_Click);
            // 
            // offsetsLabel
            // 
            this.offsetsLabel.AutoSize = true;
            this.offsetsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.offsetsLabel.Location = new System.Drawing.Point(24, 150);
            this.offsetsLabel.Name = "offsetsLabel";
            this.offsetsLabel.Size = new System.Drawing.Size(54, 17);
            this.offsetsLabel.TabIndex = 28;
            this.offsetsLabel.Text = "offsets:";
            // 
            // offsetsTextBox
            // 
            this.offsetsTextBox.Location = new System.Drawing.Point(93, 147);
            this.offsetsTextBox.Name = "offsetsTextBox";
            this.offsetsTextBox.Size = new System.Drawing.Size(94, 22);
            this.offsetsTextBox.TabIndex = 27;
            // 
            // pointerLabel
            // 
            this.pointerLabel.AutoSize = true;
            this.pointerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointerLabel.Location = new System.Drawing.Point(24, 94);
            this.pointerLabel.Name = "pointerLabel";
            this.pointerLabel.Size = new System.Drawing.Size(60, 17);
            this.pointerLabel.TabIndex = 23;
            this.pointerLabel.Text = "pointer: ";
            // 
            // q3
            // 
            this.q3.Image = ((System.Drawing.Image)(resources.GetObject("q3.Image")));
            this.q3.Location = new System.Drawing.Point(6, 122);
            this.q3.Name = "q3";
            this.q3.Size = new System.Drawing.Size(12, 12);
            this.q3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.q3.TabIndex = 24;
            this.q3.TabStop = false;
            this.q3.Click += new System.EventHandler(this.q3_Click);
            // 
            // pointerTextBox
            // 
            this.pointerTextBox.Location = new System.Drawing.Point(93, 91);
            this.pointerTextBox.Name = "pointerTextBox";
            this.pointerTextBox.Size = new System.Drawing.Size(94, 22);
            this.pointerTextBox.TabIndex = 22;
            this.pointerTextBox.Text = "0x";
            // 
            // temporaryRadioButton
            // 
            this.temporaryRadioButton.AutoSize = true;
            this.temporaryRadioButton.Location = new System.Drawing.Point(5, 7);
            this.temporaryRadioButton.Name = "temporaryRadioButton";
            this.temporaryRadioButton.Size = new System.Drawing.Size(168, 21);
            this.temporaryRadioButton.TabIndex = 20;
            this.temporaryRadioButton.Text = "use temporary pointer";
            this.temporaryRadioButton.UseVisualStyleBackColor = true;
            // 
            // permanentRadioButton
            // 
            this.permanentRadioButton.AutoSize = true;
            this.permanentRadioButton.Checked = true;
            this.permanentRadioButton.Location = new System.Drawing.Point(5, 29);
            this.permanentRadioButton.Name = "permanentRadioButton";
            this.permanentRadioButton.Size = new System.Drawing.Size(172, 21);
            this.permanentRadioButton.TabIndex = 21;
            this.permanentRadioButton.TabStop = true;
            this.permanentRadioButton.Text = "use permanent pointer";
            this.permanentRadioButton.UseVisualStyleBackColor = true;
            // 
            // processLabel
            // 
            this.processLabel.AutoSize = true;
            this.processLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.processLabel.Location = new System.Drawing.Point(24, 66);
            this.processLabel.Name = "processLabel";
            this.processLabel.Size = new System.Drawing.Size(66, 17);
            this.processLabel.TabIndex = 12;
            this.processLabel.Text = "process: ";
            // 
            // processTextBox
            // 
            this.processTextBox.Location = new System.Drawing.Point(93, 63);
            this.processTextBox.Name = "processTextBox";
            this.processTextBox.Size = new System.Drawing.Size(94, 22);
            this.processTextBox.TabIndex = 3;
            this.processTextBox.Text = "explorer";
            // 
            // modulLabel
            // 
            this.modulLabel.AutoSize = true;
            this.modulLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modulLabel.Location = new System.Drawing.Point(24, 122);
            this.modulLabel.Name = "modulLabel";
            this.modulLabel.Size = new System.Drawing.Size(54, 17);
            this.modulLabel.TabIndex = 13;
            this.modulLabel.Text = "modul: ";
            // 
            // q2
            // 
            this.q2.Image = ((System.Drawing.Image)(resources.GetObject("q2.Image")));
            this.q2.Location = new System.Drawing.Point(6, 94);
            this.q2.Name = "q2";
            this.q2.Size = new System.Drawing.Size(12, 12);
            this.q2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.q2.TabIndex = 16;
            this.q2.TabStop = false;
            this.q2.Click += new System.EventHandler(this.q2_Click);
            // 
            // q1
            // 
            this.q1.Image = ((System.Drawing.Image)(resources.GetObject("q1.Image")));
            this.q1.Location = new System.Drawing.Point(6, 66);
            this.q1.Name = "q1";
            this.q1.Size = new System.Drawing.Size(12, 12);
            this.q1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.q1.TabIndex = 15;
            this.q1.TabStop = false;
            this.q1.Click += new System.EventHandler(this.q1_Click);
            // 
            // modulTextBox
            // 
            this.modulTextBox.Location = new System.Drawing.Point(93, 119);
            this.modulTextBox.Name = "modulTextBox";
            this.modulTextBox.Size = new System.Drawing.Size(94, 22);
            this.modulTextBox.TabIndex = 4;
            this.modulTextBox.Text = "explorer.exe";
            // 
            // useButton
            // 
            this.useButton.Enabled = false;
            this.useButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.useButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.useButton.Location = new System.Drawing.Point(207, 134);
            this.useButton.Name = "useButton";
            this.useButton.Size = new System.Drawing.Size(106, 82);
            this.useButton.TabIndex = 18;
            this.useButton.Text = "USE";
            this.useButton.UseVisualStyleBackColor = true;
            this.useButton.Click += new System.EventHandler(this.useButton_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Transparent;
            this.tabPage3.Controls.Add(this.textBox2);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(337, 422);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Help";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(34, 343);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(274, 58);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "p.esy.es/pointeralert.html\r\nridvanaltun@outlook.com\r\nhttps://github.com/ridvanalt" +
    "un";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(16, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 309);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tips";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(6, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(295, 66);
            this.label4.TabIndex = 5;
            this.label4.Text = "It is a pointer alert system. If the pointer shows up itself it alerts you how wh" +
    "at you want. ";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(6, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(295, 89);
            this.label5.TabIndex = 9;
            this.label5.Text = "You can look at your computer\'s PIDs from task manager. Follow this steps:\r\n\r\nTas" +
    "k Manager -> Details";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip2;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Passive";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(155, 76);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.stopToolStripMenuItem.Text = "Start / Stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Status:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 480);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "0 process selected,";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 457);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(351, 25);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 21;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(57, 20);
            this.toolStripStatusLabel1.Text = "Status:";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(133, 20);
            this.toolStripStatusLabel2.Text = "0 process selected,";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLabel3.ForeColor = System.Drawing.Color.Red;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(67, 20);
            this.toolStripStatusLabel3.Text = "PASSIVE";
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(125, 150);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 482);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Pointer Access";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.q4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.q3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.q2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.q1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deselectAllToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button hideButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox processTextBox;
        private System.Windows.Forms.TextBox modulTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Label modulLabel;
        private System.Windows.Forms.Label processLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox q2;
        private System.Windows.Forms.PictureBox q1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button useButton;
        private System.Windows.Forms.RadioButton temporaryRadioButton;
        private System.Windows.Forms.RadioButton permanentRadioButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label pointerLabel;
        private System.Windows.Forms.PictureBox q3;
        private System.Windows.Forms.TextBox pointerTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button openAnotherPA;
        private System.Windows.Forms.PictureBox q4;
        private System.Windows.Forms.Label offsetsLabel;
        private System.Windows.Forms.TextBox offsetsTextBox;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

