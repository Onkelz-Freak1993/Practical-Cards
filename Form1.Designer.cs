namespace Practical_Cards
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.CardsTab = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Card = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.CardEnabledChkBox = new System.Windows.Forms.CheckBox();
            this.EnabledIndicator = new System.Windows.Forms.Panel();
            this.CardNameLabel = new System.Windows.Forms.Label();
            this.CardsContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.activateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.editCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duplicateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Card2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Card3 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.CardNameLabel2 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.NewCardTBtn = new System.Windows.Forms.ToolStripButton();
            this.DeleteCardTBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.EditCardTBtn = new System.Windows.Forms.ToolStripButton();
            this.DuplicateCardTBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.RefreshCardsTBtn = new System.Windows.Forms.ToolStripButton();
            this.OpenCardsFolderTBtn = new System.Windows.Forms.ToolStripButton();
            this.SettingsTab = new System.Windows.Forms.TabPage();
            this.ApplicationGroupBox = new System.Windows.Forms.GroupBox();
            this.ShowDebugTabChkBox = new System.Windows.Forms.CheckBox();
            this.CloseToMinimizeChkBox = new System.Windows.Forms.CheckBox();
            this.MinimizeToSysTrayChkBox = new System.Windows.Forms.CheckBox();
            this.StartMinimizedChkBox = new System.Windows.Forms.CheckBox();
            this.StartWithWindowsChkBox = new System.Windows.Forms.CheckBox();
            this.DebugTab = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ShowBlankCardChkBox = new System.Windows.Forms.CheckBox();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.ApplyBtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.CardsTab.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.Card.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.CardsContextMenu.SuspendLayout();
            this.Card2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.Card3.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SettingsTab.SuspendLayout();
            this.ApplicationGroupBox.SuspendLayout();
            this.DebugTab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.CardsTab);
            this.tabControl1.Controls.Add(this.SettingsTab);
            this.tabControl1.Controls.Add(this.DebugTab);
            this.tabControl1.Location = new System.Drawing.Point(9, 9);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(266, 314);
            this.tabControl1.TabIndex = 0;
            // 
            // CardsTab
            // 
            this.CardsTab.Controls.Add(this.flowLayoutPanel1);
            this.CardsTab.Controls.Add(this.toolStrip1);
            this.CardsTab.Location = new System.Drawing.Point(4, 24);
            this.CardsTab.Name = "CardsTab";
            this.CardsTab.Padding = new System.Windows.Forms.Padding(3);
            this.CardsTab.Size = new System.Drawing.Size(258, 286);
            this.CardsTab.TabIndex = 0;
            this.CardsTab.Text = "Cards";
            this.CardsTab.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.Card);
            this.flowLayoutPanel1.Controls.Add(this.Card2);
            this.flowLayoutPanel1.Controls.Add(this.Card3);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 31);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(246, 249);
            this.flowLayoutPanel1.TabIndex = 1;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // Card
            // 
            this.Card.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Card.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Card.Controls.Add(this.panel1);
            this.Card.Controls.Add(this.panel2);
            this.Card.Location = new System.Drawing.Point(0, 3);
            this.Card.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.Card.MaximumSize = new System.Drawing.Size(226, 4096);
            this.Card.MinimumSize = new System.Drawing.Size(226, 100);
            this.Card.Name = "Card";
            this.Card.Size = new System.Drawing.Size(226, 100);
            this.Card.TabIndex = 1;
            this.Card.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 70);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.splitContainer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(224, 25);
            this.panel2.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.CardEnabledChkBox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.EnabledIndicator);
            this.splitContainer1.Panel2.Controls.Add(this.CardNameLabel);
            this.splitContainer1.Size = new System.Drawing.Size(224, 25);
            this.splitContainer1.SplitterDistance = 29;
            this.splitContainer1.TabIndex = 0;
            // 
            // CardEnabledChkBox
            // 
            this.CardEnabledChkBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CardEnabledChkBox.Location = new System.Drawing.Point(0, 0);
            this.CardEnabledChkBox.Name = "CardEnabledChkBox";
            this.CardEnabledChkBox.Padding = new System.Windows.Forms.Padding(6, 2, 0, 0);
            this.CardEnabledChkBox.Size = new System.Drawing.Size(29, 25);
            this.CardEnabledChkBox.TabIndex = 0;
            this.CardEnabledChkBox.UseVisualStyleBackColor = true;
            // 
            // EnabledIndicator
            // 
            this.EnabledIndicator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.EnabledIndicator.Dock = System.Windows.Forms.DockStyle.Right;
            this.EnabledIndicator.Location = new System.Drawing.Point(186, 0);
            this.EnabledIndicator.Name = "EnabledIndicator";
            this.EnabledIndicator.Size = new System.Drawing.Size(5, 25);
            this.EnabledIndicator.TabIndex = 1;
            // 
            // CardNameLabel
            // 
            this.CardNameLabel.AutoEllipsis = true;
            this.CardNameLabel.ContextMenuStrip = this.CardsContextMenu;
            this.CardNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CardNameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CardNameLabel.Location = new System.Drawing.Point(0, 0);
            this.CardNameLabel.Name = "CardNameLabel";
            this.CardNameLabel.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.CardNameLabel.Size = new System.Drawing.Size(191, 25);
            this.CardNameLabel.TabIndex = 0;
            this.CardNameLabel.Text = "Deactivated Card";
            this.CardNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CardsContextMenu
            // 
            this.CardsContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.activateToolStripMenuItem,
            this.toolStripMenuItem1,
            this.editCardToolStripMenuItem,
            this.duplicateToolStripMenuItem,
            this.toolStripMenuItem2,
            this.removeToolStripMenuItem});
            this.CardsContextMenu.Name = "CardsContextMenu";
            this.CardsContextMenu.Size = new System.Drawing.Size(181, 126);
            // 
            // activateToolStripMenuItem
            // 
            this.activateToolStripMenuItem.Name = "activateToolStripMenuItem";
            this.activateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.activateToolStripMenuItem.Text = "Activate";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // editCardToolStripMenuItem
            // 
            this.editCardToolStripMenuItem.Image = global::Practical_Cards.Properties.Resources.document_properties;
            this.editCardToolStripMenuItem.Name = "editCardToolStripMenuItem";
            this.editCardToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editCardToolStripMenuItem.Text = "Edit";
            this.editCardToolStripMenuItem.Click += new System.EventHandler(this.editCardToolStripMenuItem_Click);
            // 
            // duplicateToolStripMenuItem
            // 
            this.duplicateToolStripMenuItem.Image = global::Practical_Cards.Properties.Resources.edit_copy;
            this.duplicateToolStripMenuItem.Name = "duplicateToolStripMenuItem";
            this.duplicateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.duplicateToolStripMenuItem.Text = "Duplicate";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.removeToolStripMenuItem.Image = global::Practical_Cards.Properties.Resources.edit_delete;
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            // 
            // Card2
            // 
            this.Card2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Card2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Card2.Controls.Add(this.panel4);
            this.Card2.Controls.Add(this.panel5);
            this.Card2.Location = new System.Drawing.Point(0, 109);
            this.Card2.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.Card2.MaximumSize = new System.Drawing.Size(226, 4096);
            this.Card2.MinimumSize = new System.Drawing.Size(226, 100);
            this.Card2.Name = "Card2";
            this.Card2.Size = new System.Drawing.Size(226, 100);
            this.Card2.TabIndex = 2;
            this.Card2.Visible = false;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Location = new System.Drawing.Point(0, 28);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(224, 70);
            this.panel4.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel5.Controls.Add(this.splitContainer2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(224, 25);
            this.panel5.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.checkBox1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.panel6);
            this.splitContainer2.Panel2.Controls.Add(this.label1);
            this.splitContainer2.Size = new System.Drawing.Size(224, 25);
            this.splitContainer2.SplitterDistance = 29;
            this.splitContainer2.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox1.Location = new System.Drawing.Point(0, 0);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Padding = new System.Windows.Forms.Padding(6, 2, 0, 0);
            this.checkBox1.Size = new System.Drawing.Size(29, 25);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(186, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(5, 25);
            this.panel6.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.ContextMenuStrip = this.CardsContextMenu;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.label1.Size = new System.Drawing.Size(191, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Activated Card";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Card3
            // 
            this.Card3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Card3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Card3.Controls.Add(this.panel8);
            this.Card3.Controls.Add(this.panel9);
            this.Card3.Location = new System.Drawing.Point(0, 215);
            this.Card3.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.Card3.MaximumSize = new System.Drawing.Size(226, 4096);
            this.Card3.MinimumSize = new System.Drawing.Size(226, 100);
            this.Card3.Name = "Card3";
            this.Card3.Size = new System.Drawing.Size(226, 100);
            this.Card3.TabIndex = 3;
            this.Card3.Visible = false;
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.Location = new System.Drawing.Point(0, 28);
            this.panel8.Margin = new System.Windows.Forms.Padding(0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(224, 70);
            this.panel8.TabIndex = 1;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel9.Controls.Add(this.splitContainer3);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(224, 25);
            this.panel9.TabIndex = 0;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.checkBox2);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.panel10);
            this.splitContainer3.Panel2.Controls.Add(this.CardNameLabel2);
            this.splitContainer3.Size = new System.Drawing.Size(224, 25);
            this.splitContainer3.SplitterDistance = 29;
            this.splitContainer3.TabIndex = 0;
            // 
            // checkBox2
            // 
            this.checkBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox2.Location = new System.Drawing.Point(0, 0);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Padding = new System.Windows.Forms.Padding(6, 2, 0, 0);
            this.checkBox2.Size = new System.Drawing.Size(29, 25);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel10.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel10.Location = new System.Drawing.Point(186, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(5, 25);
            this.panel10.TabIndex = 1;
            // 
            // CardNameLabel2
            // 
            this.CardNameLabel2.AutoEllipsis = true;
            this.CardNameLabel2.ContextMenuStrip = this.CardsContextMenu;
            this.CardNameLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CardNameLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CardNameLabel2.Location = new System.Drawing.Point(0, 0);
            this.CardNameLabel2.Name = "CardNameLabel2";
            this.CardNameLabel2.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.CardNameLabel2.Size = new System.Drawing.Size(191, 25);
            this.CardNameLabel2.TabIndex = 0;
            this.CardNameLabel2.Text = "Activated Card with very long Name";
            this.CardNameLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewCardTBtn,
            this.DeleteCardTBtn,
            this.toolStripSeparator1,
            this.EditCardTBtn,
            this.DuplicateCardTBtn,
            this.toolStripSeparator2,
            this.RefreshCardsTBtn,
            this.OpenCardsFolderTBtn});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(252, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // NewCardTBtn
            // 
            this.NewCardTBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NewCardTBtn.Image = global::Practical_Cards.Properties.Resources.document_new;
            this.NewCardTBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewCardTBtn.Name = "NewCardTBtn";
            this.NewCardTBtn.Size = new System.Drawing.Size(23, 22);
            this.NewCardTBtn.Text = "New Card";
            this.NewCardTBtn.Click += new System.EventHandler(this.NewCardTBtn_Click);
            // 
            // DeleteCardTBtn
            // 
            this.DeleteCardTBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteCardTBtn.Image = global::Practical_Cards.Properties.Resources.edit_delete;
            this.DeleteCardTBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteCardTBtn.Name = "DeleteCardTBtn";
            this.DeleteCardTBtn.Size = new System.Drawing.Size(23, 22);
            this.DeleteCardTBtn.Text = "Delete Card";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // EditCardTBtn
            // 
            this.EditCardTBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EditCardTBtn.Image = global::Practical_Cards.Properties.Resources.document_properties;
            this.EditCardTBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditCardTBtn.Name = "EditCardTBtn";
            this.EditCardTBtn.Size = new System.Drawing.Size(23, 22);
            this.EditCardTBtn.Text = "Edit Card";
            this.EditCardTBtn.Visible = false;
            // 
            // DuplicateCardTBtn
            // 
            this.DuplicateCardTBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DuplicateCardTBtn.Image = global::Practical_Cards.Properties.Resources.edit_copy;
            this.DuplicateCardTBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DuplicateCardTBtn.Name = "DuplicateCardTBtn";
            this.DuplicateCardTBtn.Size = new System.Drawing.Size(23, 22);
            this.DuplicateCardTBtn.Text = "Duplicate Card";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // RefreshCardsTBtn
            // 
            this.RefreshCardsTBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RefreshCardsTBtn.Image = global::Practical_Cards.Properties.Resources.view_refresh;
            this.RefreshCardsTBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshCardsTBtn.Name = "RefreshCardsTBtn";
            this.RefreshCardsTBtn.Size = new System.Drawing.Size(23, 22);
            this.RefreshCardsTBtn.Text = "Refresh Cards";
            this.RefreshCardsTBtn.Click += new System.EventHandler(this.RefreshCardsTBtn_Click);
            // 
            // OpenCardsFolderTBtn
            // 
            this.OpenCardsFolderTBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpenCardsFolderTBtn.Image = global::Practical_Cards.Properties.Resources.folder;
            this.OpenCardsFolderTBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenCardsFolderTBtn.Name = "OpenCardsFolderTBtn";
            this.OpenCardsFolderTBtn.Size = new System.Drawing.Size(23, 22);
            this.OpenCardsFolderTBtn.Text = "Open Cards folder";
            this.OpenCardsFolderTBtn.Click += new System.EventHandler(this.OpenCardsFolderTBtn_Click);
            // 
            // SettingsTab
            // 
            this.SettingsTab.Controls.Add(this.ApplicationGroupBox);
            this.SettingsTab.Location = new System.Drawing.Point(4, 24);
            this.SettingsTab.Name = "SettingsTab";
            this.SettingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.SettingsTab.Size = new System.Drawing.Size(258, 286);
            this.SettingsTab.TabIndex = 1;
            this.SettingsTab.Text = "Settings";
            this.SettingsTab.UseVisualStyleBackColor = true;
            // 
            // ApplicationGroupBox
            // 
            this.ApplicationGroupBox.Controls.Add(this.ShowDebugTabChkBox);
            this.ApplicationGroupBox.Controls.Add(this.CloseToMinimizeChkBox);
            this.ApplicationGroupBox.Controls.Add(this.MinimizeToSysTrayChkBox);
            this.ApplicationGroupBox.Controls.Add(this.StartMinimizedChkBox);
            this.ApplicationGroupBox.Controls.Add(this.StartWithWindowsChkBox);
            this.ApplicationGroupBox.Location = new System.Drawing.Point(6, 6);
            this.ApplicationGroupBox.Name = "ApplicationGroupBox";
            this.ApplicationGroupBox.Size = new System.Drawing.Size(246, 153);
            this.ApplicationGroupBox.TabIndex = 0;
            this.ApplicationGroupBox.TabStop = false;
            this.ApplicationGroupBox.Text = "Application";
            // 
            // ShowDebugTabChkBox
            // 
            this.ShowDebugTabChkBox.AutoSize = true;
            this.ShowDebugTabChkBox.Checked = true;
            this.ShowDebugTabChkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ShowDebugTabChkBox.Location = new System.Drawing.Point(6, 122);
            this.ShowDebugTabChkBox.Name = "ShowDebugTabChkBox";
            this.ShowDebugTabChkBox.Size = new System.Drawing.Size(114, 19);
            this.ShowDebugTabChkBox.TabIndex = 4;
            this.ShowDebugTabChkBox.Text = "Show Debug Tab";
            this.ShowDebugTabChkBox.UseVisualStyleBackColor = true;
            this.ShowDebugTabChkBox.CheckedChanged += new System.EventHandler(this.ShowDebugTabChkBox_CheckedChanged);
            // 
            // CloseToMinimizeChkBox
            // 
            this.CloseToMinimizeChkBox.AutoSize = true;
            this.CloseToMinimizeChkBox.Location = new System.Drawing.Point(6, 97);
            this.CloseToMinimizeChkBox.Name = "CloseToMinimizeChkBox";
            this.CloseToMinimizeChkBox.Size = new System.Drawing.Size(112, 19);
            this.CloseToMinimizeChkBox.TabIndex = 3;
            this.CloseToMinimizeChkBox.Text = "Close minimizes";
            this.CloseToMinimizeChkBox.UseVisualStyleBackColor = true;
            // 
            // MinimizeToSysTrayChkBox
            // 
            this.MinimizeToSysTrayChkBox.AutoSize = true;
            this.MinimizeToSysTrayChkBox.Location = new System.Drawing.Point(6, 72);
            this.MinimizeToSysTrayChkBox.Name = "MinimizeToSysTrayChkBox";
            this.MinimizeToSysTrayChkBox.Size = new System.Drawing.Size(149, 19);
            this.MinimizeToSysTrayChkBox.TabIndex = 2;
            this.MinimizeToSysTrayChkBox.Text = "Minimize to systemtray";
            this.MinimizeToSysTrayChkBox.UseVisualStyleBackColor = true;
            // 
            // StartMinimizedChkBox
            // 
            this.StartMinimizedChkBox.AutoSize = true;
            this.StartMinimizedChkBox.Location = new System.Drawing.Point(6, 47);
            this.StartMinimizedChkBox.Name = "StartMinimizedChkBox";
            this.StartMinimizedChkBox.Size = new System.Drawing.Size(109, 19);
            this.StartMinimizedChkBox.TabIndex = 1;
            this.StartMinimizedChkBox.Text = "Start minimized";
            this.StartMinimizedChkBox.UseVisualStyleBackColor = true;
            // 
            // StartWithWindowsChkBox
            // 
            this.StartWithWindowsChkBox.AutoSize = true;
            this.StartWithWindowsChkBox.Location = new System.Drawing.Point(6, 22);
            this.StartWithWindowsChkBox.Name = "StartWithWindowsChkBox";
            this.StartWithWindowsChkBox.Size = new System.Drawing.Size(128, 19);
            this.StartWithWindowsChkBox.TabIndex = 0;
            this.StartWithWindowsChkBox.Text = "Start with Windows";
            this.StartWithWindowsChkBox.UseVisualStyleBackColor = true;
            // 
            // DebugTab
            // 
            this.DebugTab.Controls.Add(this.groupBox1);
            this.DebugTab.Location = new System.Drawing.Point(4, 24);
            this.DebugTab.Name = "DebugTab";
            this.DebugTab.Size = new System.Drawing.Size(258, 286);
            this.DebugTab.TabIndex = 2;
            this.DebugTab.Text = "Debug";
            this.DebugTab.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ShowBlankCardChkBox);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Visual";
            // 
            // ShowBlankCardChkBox
            // 
            this.ShowBlankCardChkBox.AutoSize = true;
            this.ShowBlankCardChkBox.Location = new System.Drawing.Point(6, 22);
            this.ShowBlankCardChkBox.Name = "ShowBlankCardChkBox";
            this.ShowBlankCardChkBox.Size = new System.Drawing.Size(160, 19);
            this.ShowBlankCardChkBox.TabIndex = 0;
            this.ShowBlankCardChkBox.Text = "Show hidden blank Cards";
            this.ShowBlankCardChkBox.UseVisualStyleBackColor = true;
            this.ShowBlankCardChkBox.CheckedChanged += new System.EventHandler(this.ShowBlankCardChkBox_CheckedChanged);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelBtn.Location = new System.Drawing.Point(200, 329);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(75, 23);
            this.CancelBtn.TabIndex = 1;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // ApplyBtn
            // 
            this.ApplyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ApplyBtn.Location = new System.Drawing.Point(9, 329);
            this.ApplyBtn.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.ApplyBtn.Name = "ApplyBtn";
            this.ApplyBtn.Size = new System.Drawing.Size(75, 23);
            this.ApplyBtn.TabIndex = 2;
            this.ApplyBtn.Text = "Apply";
            this.ApplyBtn.UseVisualStyleBackColor = true;
            this.ApplyBtn.Click += new System.EventHandler(this.ApplyBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.ApplyBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 4096);
            this.MinimumSize = new System.Drawing.Size(300, 400);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Practical Cards";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.CardsTab.ResumeLayout(false);
            this.CardsTab.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.Card.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.CardsContextMenu.ResumeLayout(false);
            this.Card2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.Card3.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.SettingsTab.ResumeLayout(false);
            this.ApplicationGroupBox.ResumeLayout(false);
            this.ApplicationGroupBox.PerformLayout();
            this.DebugTab.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage CardsTab;
        private TabPage SettingsTab;
        private Button CancelBtn;
        private Button ApplyBtn;
        private TabPage DebugTab;
        private ToolStrip toolStrip1;
        private ToolStripButton NewCardTBtn;
        private ToolStripButton DeleteCardTBtn;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton EditCardTBtn;
        private ToolStripButton DuplicateCardTBtn;
        private ToolStripButton RefreshCardsTBtn;
        private ToolStripSeparator toolStripSeparator2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private CheckBox CardEnabledChkBox;
        private Label CardNameLabel;
        protected SplitContainer splitContainer1;
        private Panel panel1;
        private GroupBox groupBox1;
        private CheckBox ShowBlankCardChkBox;
        private Panel EnabledIndicator;
        private ToolStripButton OpenCardsFolderTBtn;
        internal Panel Card;
        private GroupBox ApplicationGroupBox;
        private CheckBox StartWithWindowsChkBox;
        private CheckBox ShowDebugTabChkBox;
        private CheckBox CloseToMinimizeChkBox;
        private CheckBox MinimizeToSysTrayChkBox;
        private CheckBox StartMinimizedChkBox;
        private ContextMenuStrip CardsContextMenu;
        private ToolStripMenuItem activateToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem editCardToolStripMenuItem;
        private ToolStripMenuItem duplicateToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem removeToolStripMenuItem;
        internal Panel Card2;
        private Panel panel4;
        private Panel panel5;
        protected SplitContainer splitContainer2;
        private CheckBox checkBox1;
        private Panel panel6;
        private Label label1;
        internal Panel Card3;
        private Panel panel8;
        private Panel panel9;
        protected SplitContainer splitContainer3;
        private CheckBox checkBox2;
        private Panel panel10;
        private Label CardNameLabel2;
    }
}