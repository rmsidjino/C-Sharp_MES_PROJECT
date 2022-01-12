﻿
namespace WindowsFormsFlower
{
    partial class frmMain
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
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.timerSliding = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.로그아웃ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.인쇄ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.전체창닫기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.홈ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.checkBoxHide = new System.Windows.Forms.CheckBox();
            this.btnMaterial = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnBOM = new System.Windows.Forms.Button();
            this.btnOrderCheck = new System.Windows.Forms.Button();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.btnIncome = new System.Windows.Forms.Button();
            this.btnSale = new System.Windows.Forms.Button();
            this.btnOutcome = new System.Windows.Forms.Button();
            this.btnContainer = new System.Windows.Forms.Button();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnUser = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ucTabControl1 = new WindowsFormsFlower.ucTabControl();
            this.btnForward = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panelSideMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.ContentPanel.Size = new System.Drawing.Size(68, 175);
            // 
            // timerSliding
            // 
            this.timerSliding.Tick += new System.EventHandler(this.timerSliding_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.로그아웃ToolStripMenuItem,
            this.인쇄ToolStripMenuItem,
            this.전체창닫기ToolStripMenuItem,
            this.홈ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1370, 40);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemAdded += new System.Windows.Forms.ToolStripItemEventHandler(this.menuStrip1_ItemAdded);
            // 
            // 로그아웃ToolStripMenuItem
            // 
            this.로그아웃ToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.로그아웃ToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.로그아웃ToolStripMenuItem.Image = global::WindowsFormsFlower.Properties.Resources.Logout;
            this.로그아웃ToolStripMenuItem.Name = "로그아웃ToolStripMenuItem";
            this.로그아웃ToolStripMenuItem.Size = new System.Drawing.Size(83, 36);
            this.로그아웃ToolStripMenuItem.Text = "로그아웃";
            // 
            // 인쇄ToolStripMenuItem
            // 
            this.인쇄ToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.인쇄ToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.인쇄ToolStripMenuItem.Image = global::WindowsFormsFlower.Properties.Resources.print1;
            this.인쇄ToolStripMenuItem.Name = "인쇄ToolStripMenuItem";
            this.인쇄ToolStripMenuItem.Size = new System.Drawing.Size(59, 36);
            this.인쇄ToolStripMenuItem.Text = "인쇄";
            this.인쇄ToolStripMenuItem.Click += new System.EventHandler(this.인쇄ToolStripMenuItem_Click);
            // 
            // 전체창닫기ToolStripMenuItem
            // 
            this.전체창닫기ToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.전체창닫기ToolStripMenuItem.Image = global::WindowsFormsFlower.Properties.Resources.closeAll;
            this.전체창닫기ToolStripMenuItem.Name = "전체창닫기ToolStripMenuItem";
            this.전체창닫기ToolStripMenuItem.Size = new System.Drawing.Size(103, 36);
            this.전체창닫기ToolStripMenuItem.Text = "전체 창 닫기";
            this.전체창닫기ToolStripMenuItem.Click += new System.EventHandler(this.전체창닫기ToolStripMenuItem_Click);
            // 
            // 홈ToolStripMenuItem
            // 
            this.홈ToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.홈ToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.홈ToolStripMenuItem.Image = global::WindowsFormsFlower.Properties.Resources.home;
            this.홈ToolStripMenuItem.Name = "홈ToolStripMenuItem";
            this.홈ToolStripMenuItem.Size = new System.Drawing.Size(47, 36);
            this.홈ToolStripMenuItem.Tag = "frmChart";
            this.홈ToolStripMenuItem.Text = "홈";
            this.홈ToolStripMenuItem.Click += new System.EventHandler(this.홈ToolStripMenuItem_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(81, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "구디꽃방";
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCustomer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomer.FlatAppearance.BorderSize = 0;
            this.btnCustomer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnCustomer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.ForeColor = System.Drawing.Color.White;
            this.btnCustomer.Location = new System.Drawing.Point(0, 45);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(100, 45);
            this.btnCustomer.TabIndex = 1;
            this.btnCustomer.Tag = "frmCustomer";
            this.btnCustomer.Text = "거래처관리";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // checkBoxHide
            // 
            this.checkBoxHide.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxHide.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.checkBoxHide.FlatAppearance.BorderSize = 0;
            this.checkBoxHide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.checkBoxHide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.checkBoxHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxHide.ForeColor = System.Drawing.Color.White;
            this.checkBoxHide.Location = new System.Drawing.Point(0, 659);
            this.checkBoxHide.Name = "checkBoxHide";
            this.checkBoxHide.Size = new System.Drawing.Size(100, 50);
            this.checkBoxHide.TabIndex = 2;
            this.checkBoxHide.Text = "<";
            this.checkBoxHide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxHide.UseVisualStyleBackColor = true;
            this.checkBoxHide.CheckedChanged += new System.EventHandler(this.checkBoxHide_CheckedChanged);
            // 
            // btnMaterial
            // 
            this.btnMaterial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMaterial.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMaterial.FlatAppearance.BorderSize = 0;
            this.btnMaterial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnMaterial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaterial.ForeColor = System.Drawing.Color.White;
            this.btnMaterial.Location = new System.Drawing.Point(0, 90);
            this.btnMaterial.Name = "btnMaterial";
            this.btnMaterial.Size = new System.Drawing.Size(100, 45);
            this.btnMaterial.TabIndex = 3;
            this.btnMaterial.Tag = "frmMaterialReg";
            this.btnMaterial.Text = "자재관리";
            this.btnMaterial.UseVisualStyleBackColor = true;
            this.btnMaterial.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProduct.FlatAppearance.BorderSize = 0;
            this.btnProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.ForeColor = System.Drawing.Color.White;
            this.btnProduct.Location = new System.Drawing.Point(0, 135);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(100, 45);
            this.btnProduct.TabIndex = 4;
            this.btnProduct.Tag = "frmProduct";
            this.btnProduct.Text = "제품관리";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // btnBOM
            // 
            this.btnBOM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBOM.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBOM.FlatAppearance.BorderSize = 0;
            this.btnBOM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnBOM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnBOM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBOM.ForeColor = System.Drawing.Color.White;
            this.btnBOM.Location = new System.Drawing.Point(0, 180);
            this.btnBOM.Name = "btnBOM";
            this.btnBOM.Size = new System.Drawing.Size(100, 45);
            this.btnBOM.TabIndex = 9;
            this.btnBOM.Tag = "frmBOMReg";
            this.btnBOM.Text = "BOM";
            this.btnBOM.UseVisualStyleBackColor = true;
            this.btnBOM.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // btnOrderCheck
            // 
            this.btnOrderCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOrderCheck.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrderCheck.FlatAppearance.BorderSize = 0;
            this.btnOrderCheck.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnOrderCheck.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnOrderCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderCheck.ForeColor = System.Drawing.Color.White;
            this.btnOrderCheck.Location = new System.Drawing.Point(0, 225);
            this.btnOrderCheck.Name = "btnOrderCheck";
            this.btnOrderCheck.Size = new System.Drawing.Size(100, 45);
            this.btnOrderCheck.TabIndex = 16;
            this.btnOrderCheck.Tag = "frmOrderCheck";
            this.btnOrderCheck.Text = "발주등록";
            this.btnOrderCheck.UseVisualStyleBackColor = true;
            this.btnOrderCheck.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // btnPurchase
            // 
            this.btnPurchase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPurchase.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPurchase.FlatAppearance.BorderSize = 0;
            this.btnPurchase.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnPurchase.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurchase.ForeColor = System.Drawing.Color.White;
            this.btnPurchase.Location = new System.Drawing.Point(0, 270);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(100, 45);
            this.btnPurchase.TabIndex = 17;
            this.btnPurchase.Tag = "frmPurChaseOrder";
            this.btnPurchase.Text = "발주관리";
            this.btnPurchase.UseVisualStyleBackColor = true;
            this.btnPurchase.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // btnIncome
            // 
            this.btnIncome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnIncome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIncome.FlatAppearance.BorderSize = 0;
            this.btnIncome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnIncome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnIncome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncome.ForeColor = System.Drawing.Color.White;
            this.btnIncome.Location = new System.Drawing.Point(0, 315);
            this.btnIncome.Name = "btnIncome";
            this.btnIncome.Size = new System.Drawing.Size(100, 45);
            this.btnIncome.TabIndex = 18;
            this.btnIncome.Tag = "frmOrderIncome";
            this.btnIncome.Text = "입고관리";
            this.btnIncome.UseVisualStyleBackColor = true;
            this.btnIncome.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // btnSale
            // 
            this.btnSale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSale.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSale.FlatAppearance.BorderSize = 0;
            this.btnSale.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnSale.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSale.ForeColor = System.Drawing.Color.White;
            this.btnSale.Location = new System.Drawing.Point(0, 360);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(100, 45);
            this.btnSale.TabIndex = 19;
            this.btnSale.Tag = "frmSales";
            this.btnSale.Text = "판매관리";
            this.btnSale.UseVisualStyleBackColor = true;
            this.btnSale.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // btnOutcome
            // 
            this.btnOutcome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOutcome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOutcome.FlatAppearance.BorderSize = 0;
            this.btnOutcome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnOutcome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnOutcome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOutcome.ForeColor = System.Drawing.Color.White;
            this.btnOutcome.Location = new System.Drawing.Point(0, 405);
            this.btnOutcome.Name = "btnOutcome";
            this.btnOutcome.Size = new System.Drawing.Size(100, 45);
            this.btnOutcome.TabIndex = 20;
            this.btnOutcome.Tag = "frmOrderOutcome";
            this.btnOutcome.Text = "출고관리";
            this.btnOutcome.UseVisualStyleBackColor = true;
            this.btnOutcome.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // btnContainer
            // 
            this.btnContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnContainer.FlatAppearance.BorderSize = 0;
            this.btnContainer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnContainer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnContainer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContainer.ForeColor = System.Drawing.Color.White;
            this.btnContainer.Location = new System.Drawing.Point(0, 450);
            this.btnContainer.Name = "btnContainer";
            this.btnContainer.Size = new System.Drawing.Size(100, 45);
            this.btnContainer.TabIndex = 21;
            this.btnContainer.Tag = "frmContainer";
            this.btnContainer.Text = "재고관리";
            this.btnContainer.UseVisualStyleBackColor = true;
            this.btnContainer.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelSideMenu.Controls.Add(this.btnForward);
            this.panelSideMenu.Controls.Add(this.btnContainer);
            this.panelSideMenu.Controls.Add(this.btnOutcome);
            this.panelSideMenu.Controls.Add(this.btnSale);
            this.panelSideMenu.Controls.Add(this.btnIncome);
            this.panelSideMenu.Controls.Add(this.btnPurchase);
            this.panelSideMenu.Controls.Add(this.btnOrderCheck);
            this.panelSideMenu.Controls.Add(this.btnBOM);
            this.panelSideMenu.Controls.Add(this.btnProduct);
            this.panelSideMenu.Controls.Add(this.btnMaterial);
            this.panelSideMenu.Controls.Add(this.checkBoxHide);
            this.panelSideMenu.Controls.Add(this.btnCustomer);
            this.panelSideMenu.Controls.Add(this.btnUser);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 40);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(100, 709);
            this.panelSideMenu.TabIndex = 2;
            // 
            // btnUser
            // 
            this.btnUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.ForeColor = System.Drawing.Color.White;
            this.btnUser.Location = new System.Drawing.Point(0, 0);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(100, 45);
            this.btnUser.TabIndex = 0;
            this.btnUser.Tag = "frmMember";
            this.btnUser.Text = "회원관리";
            this.btnUser.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(77, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // ucTabControl1
            // 
            this.ucTabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.ucTabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.ucTabControl1.Location = new System.Drawing.Point(100, 40);
            this.ucTabControl1.Margin = new System.Windows.Forms.Padding(50, 10, 10, 10);
            this.ucTabControl1.Name = "ucTabControl1";
            this.ucTabControl1.SelectedIndex = 0;
            this.ucTabControl1.Size = new System.Drawing.Size(1270, 23);
            this.ucTabControl1.TabIndex = 3;
            this.ucTabControl1.SelectedIndexChanged += new System.EventHandler(this.ucTabControl1_SelectedIndexChanged);
            this.ucTabControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ucTabControl1_MouseDown);
            // 
            // btnForward
            // 
            this.btnForward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnForward.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnForward.FlatAppearance.BorderSize = 0;
            this.btnForward.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnForward.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnForward.ForeColor = System.Drawing.Color.White;
            this.btnForward.Location = new System.Drawing.Point(0, 495);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(100, 45);
            this.btnForward.TabIndex = 22;
            this.btnForward.Tag = "frmFowardReverse";
            this.btnForward.Text = "정전개/역전개";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.MenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ucTabControl1);
            this.Controls.Add(this.panelSideMenu);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "메인화면";
            this.Load += new System.EventHandler(this.frmMain1_Load);
            this.MdiChildActivate += new System.EventHandler(this.frmMain_MdiChildActivate);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelSideMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.Timer timerSliding;
        private ucTabControl ucTabControl1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 홈ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 로그아웃ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 인쇄ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.CheckBox checkBoxHide;
        private System.Windows.Forms.Button btnMaterial;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnBOM;
        private System.Windows.Forms.Button btnOrderCheck;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.Button btnIncome;
        private System.Windows.Forms.Button btnSale;
        private System.Windows.Forms.Button btnOutcome;
        private System.Windows.Forms.Button btnContainer;
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.ToolStripMenuItem 전체창닫기ToolStripMenuItem;
        private System.Windows.Forms.Button btnForward;
    }
}