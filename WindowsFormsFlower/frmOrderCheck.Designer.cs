﻿
namespace WindowsFormsFlower
{
    partial class frmOrderCheck
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblStock = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.lblMatName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelNum = new System.Windows.Forms.Label();
            this.lblCusID = new System.Windows.Forms.Label();
            this.lblCusManager = new System.Windows.Forms.Label();
            this.lblCusName = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.lblTot = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.cboCustomer = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.btnOrderAdd = new System.Windows.Forms.Button();
            this.btnOrderChange = new System.Windows.Forms.Button();
            this.btnOrderDel = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblMatID = new System.Windows.Forms.Label();
            this.nuQuantity = new System.Windows.Forms.NumericUpDown();
            this.txtPrice = new WindowsFormsFlower.Controls.NumTextBox();
            this.dgvMaterial = new System.Windows.Forms.DataGridView();
            this.dgvOrderDetail = new System.Windows.Forms.DataGridView();
            this.label45 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpRequiredDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMat = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblCurCustomer = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.btnOrderDel);
            this.splitContainer1.Panel2.Controls.Add(this.btnOrderChange);
            this.splitContainer1.Panel2.Controls.Add(this.btnOrderAdd);
            this.splitContainer1.Size = new System.Drawing.Size(1099, 583);
            this.splitContainer1.SplitterDistance = 772;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtMat);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.cboCustomer);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Size = new System.Drawing.Size(1099, 66);
            this.panel1.Controls.SetChildIndex(this.panel3, 0);
            this.panel1.Controls.SetChildIndex(this.label22, 0);
            this.panel1.Controls.SetChildIndex(this.label20, 0);
            this.panel1.Controls.SetChildIndex(this.cboCustomer, 0);
            this.panel1.Controls.SetChildIndex(this.label23, 0);
            this.panel1.Controls.SetChildIndex(this.txtMat, 0);
            this.panel1.Controls.SetChildIndex(this.btnSearch, 0);
            // 
            // splitContainer2
            // 
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dgvMaterial);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dgvOrderDetail);
            this.splitContainer2.Size = new System.Drawing.Size(772, 532);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblCurCustomer);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dtpRequiredDate);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnOrder);
            this.panel2.Controls.Add(this.lblTot);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Size = new System.Drawing.Size(772, 51);
            // 
            // panel3
            // 
            this.panel3.Size = new System.Drawing.Size(1099, 31);
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(18, 361);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(0, 12);
            this.lblStock.TabIndex = 55;
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Location = new System.Drawing.Point(18, 318);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(0, 12);
            this.lblUnit.TabIndex = 54;
            // 
            // lblMatName
            // 
            this.lblMatName.AutoSize = true;
            this.lblMatName.Location = new System.Drawing.Point(18, 275);
            this.lblMatName.Name = "lblMatName";
            this.lblMatName.Size = new System.Drawing.Size(0, 12);
            this.lblMatName.TabIndex = 53;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(18, 191);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(0, 12);
            this.lblEmail.TabIndex = 52;
            // 
            // lblTelNum
            // 
            this.lblTelNum.AutoSize = true;
            this.lblTelNum.Location = new System.Drawing.Point(18, 148);
            this.lblTelNum.Name = "lblTelNum";
            this.lblTelNum.Size = new System.Drawing.Size(0, 12);
            this.lblTelNum.TabIndex = 51;
            // 
            // lblCusID
            // 
            this.lblCusID.AutoSize = true;
            this.lblCusID.Location = new System.Drawing.Point(18, 103);
            this.lblCusID.Name = "lblCusID";
            this.lblCusID.Size = new System.Drawing.Size(0, 12);
            this.lblCusID.TabIndex = 49;
            // 
            // lblCusManager
            // 
            this.lblCusManager.AutoSize = true;
            this.lblCusManager.Location = new System.Drawing.Point(18, 60);
            this.lblCusManager.Name = "lblCusManager";
            this.lblCusManager.Size = new System.Drawing.Size(0, 12);
            this.lblCusManager.TabIndex = 48;
            // 
            // lblCusName
            // 
            this.lblCusName.AutoSize = true;
            this.lblCusName.Location = new System.Drawing.Point(18, 17);
            this.lblCusName.Name = "lblCusName";
            this.lblCusName.Size = new System.Drawing.Size(0, 12);
            this.lblCusName.TabIndex = 47;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(657, 14);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 23);
            this.btnOrder.TabIndex = 5;
            this.btnOrder.Text = "발주하기";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // lblTot
            // 
            this.lblTot.Location = new System.Drawing.Point(245, 17);
            this.lblTot.Name = "lblTot";
            this.lblTot.Size = new System.Drawing.Size(80, 16);
            this.lblTot.TabIndex = 4;
            this.lblTot.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "발주 총 금액 :";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(251, 41);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(41, 12);
            this.label23.TabIndex = 42;
            this.label23.Text = "자재명";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(292, 41);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(0, 12);
            this.label22.TabIndex = 39;
            // 
            // cboCustomer
            // 
            this.cboCustomer.FormattingEnabled = true;
            this.cboCustomer.Location = new System.Drawing.Point(113, 37);
            this.cboCustomer.Name = "cboCustomer";
            this.cboCustomer.Size = new System.Drawing.Size(121, 20);
            this.cboCustomer.TabIndex = 38;
            this.cboCustomer.SelectedIndexChanged += new System.EventHandler(this.cboCustomer_SelectedIndexChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(37, 41);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(53, 12);
            this.label20.TabIndex = 37;
            this.label20.Text = "거래처명";
            // 
            // btnOrderAdd
            // 
            this.btnOrderAdd.Location = new System.Drawing.Point(22, 541);
            this.btnOrderAdd.Name = "btnOrderAdd";
            this.btnOrderAdd.Size = new System.Drawing.Size(75, 23);
            this.btnOrderAdd.TabIndex = 56;
            this.btnOrderAdd.Text = "등록";
            this.btnOrderAdd.UseVisualStyleBackColor = true;
            this.btnOrderAdd.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // btnOrderChange
            // 
            this.btnOrderChange.Location = new System.Drawing.Point(129, 541);
            this.btnOrderChange.Name = "btnOrderChange";
            this.btnOrderChange.Size = new System.Drawing.Size(75, 23);
            this.btnOrderChange.TabIndex = 57;
            this.btnOrderChange.Text = "수정";
            this.btnOrderChange.UseVisualStyleBackColor = true;
            // 
            // btnOrderDel
            // 
            this.btnOrderDel.Location = new System.Drawing.Point(236, 541);
            this.btnOrderDel.Name = "btnOrderDel";
            this.btnOrderDel.Size = new System.Drawing.Size(75, 23);
            this.btnOrderDel.TabIndex = 58;
            this.btnOrderDel.Text = "삭제";
            this.btnOrderDel.UseVisualStyleBackColor = true;
            this.btnOrderDel.Click += new System.EventHandler(this.btnOrderDel_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblMatID);
            this.panel4.Controls.Add(this.lblStock);
            this.panel4.Controls.Add(this.lblUnit);
            this.panel4.Controls.Add(this.lblMatName);
            this.panel4.Controls.Add(this.lblEmail);
            this.panel4.Controls.Add(this.lblTelNum);
            this.panel4.Controls.Add(this.lblCusID);
            this.panel4.Controls.Add(this.lblCusManager);
            this.panel4.Controls.Add(this.lblCusName);
            this.panel4.Location = new System.Drawing.Point(109, 20);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(179, 392);
            this.panel4.TabIndex = 59;
            // 
            // lblMatID
            // 
            this.lblMatID.AutoSize = true;
            this.lblMatID.Location = new System.Drawing.Point(18, 237);
            this.lblMatID.Name = "lblMatID";
            this.lblMatID.Size = new System.Drawing.Size(0, 12);
            this.lblMatID.TabIndex = 59;
            // 
            // nuQuantity
            // 
            this.nuQuantity.Location = new System.Drawing.Point(123, 26);
            this.nuQuantity.Name = "nuQuantity";
            this.nuQuantity.Size = new System.Drawing.Size(100, 21);
            this.nuQuantity.TabIndex = 58;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(123, 60);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 21);
            this.txtPrice.TabIndex = 56;
            // 
            // dgvMaterial
            // 
            this.dgvMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMaterial.Location = new System.Drawing.Point(0, 0);
            this.dgvMaterial.Name = "dgvMaterial";
            this.dgvMaterial.RowTemplate.Height = 23;
            this.dgvMaterial.Size = new System.Drawing.Size(772, 369);
            this.dgvMaterial.TabIndex = 0;
            this.dgvMaterial.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMaterial_CellDoubleClick);
            // 
            // dgvOrderDetail
            // 
            this.dgvOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrderDetail.Location = new System.Drawing.Point(0, 0);
            this.dgvOrderDetail.Name = "dgvOrderDetail";
            this.dgvOrderDetail.RowTemplate.Height = 23;
            this.dgvOrderDetail.Size = new System.Drawing.Size(772, 159);
            this.dgvOrderDetail.TabIndex = 0;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(13, 36);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(41, 12);
            this.label45.TabIndex = 60;
            this.label45.Text = "거래처";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(13, 79);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(41, 12);
            this.label44.TabIndex = 61;
            this.label44.Text = "담당자";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(13, 210);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(81, 12);
            this.label35.TabIndex = 70;
            this.label35.Text = "거래처 이메일";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(13, 167);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(81, 12);
            this.label36.TabIndex = 69;
            this.label36.Text = "거래처 연락처";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(14, 64);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(29, 12);
            this.label37.TabIndex = 68;
            this.label37.Text = "단가";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(13, 294);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(41, 12);
            this.label41.TabIndex = 64;
            this.label41.Text = "재료명";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(14, 30);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(29, 12);
            this.label38.TabIndex = 67;
            this.label38.Text = "수량";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(13, 337);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(29, 12);
            this.label39.TabIndex = 66;
            this.label39.Text = "단위";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(14, 380);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(53, 12);
            this.label40.TabIndex = 65;
            this.label40.Text = "최소수량";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(13, 122);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(52, 12);
            this.label43.TabIndex = 62;
            this.label43.Text = "거래처ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 12);
            this.label3.TabIndex = 71;
            this.label3.Text = "재료ID";
            // 
            // dtpRequiredDate
            // 
            this.dtpRequiredDate.Location = new System.Drawing.Point(466, 15);
            this.dtpRequiredDate.Name = "dtpRequiredDate";
            this.dtpRequiredDate.Size = new System.Drawing.Size(128, 21);
            this.dtpRequiredDate.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(362, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "납품 요청일";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "원";
            // 
            // txtMat
            // 
            this.txtMat.Location = new System.Drawing.Point(301, 37);
            this.txtMat.Name = "txtMat";
            this.txtMat.Size = new System.Drawing.Size(109, 21);
            this.txtMat.TabIndex = 43;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(420, 36);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 44;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblCurCustomer
            // 
            this.lblCurCustomer.Location = new System.Drawing.Point(96, 15);
            this.lblCurCustomer.Name = "lblCurCustomer";
            this.lblCurCustomer.Size = new System.Drawing.Size(64, 21);
            this.lblCurCustomer.TabIndex = 10;
            this.lblCurCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "현재 거래처 :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label45);
            this.groupBox1.Controls.Add(this.label44);
            this.groupBox1.Controls.Add(this.label43);
            this.groupBox1.Controls.Add(this.label35);
            this.groupBox1.Controls.Add(this.label36);
            this.groupBox1.Controls.Add(this.label41);
            this.groupBox1.Controls.Add(this.label39);
            this.groupBox1.Controls.Add(this.label40);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Location = new System.Drawing.Point(17, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 418);
            this.groupBox1.TabIndex = 72;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "기본정보";
            this.groupBox1.UseCompatibleTextRendering = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nuQuantity);
            this.groupBox2.Controls.Add(this.txtPrice);
            this.groupBox2.Controls.Add(this.label37);
            this.groupBox2.Controls.Add(this.label38);
            this.groupBox2.Location = new System.Drawing.Point(17, 431);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(294, 101);
            this.groupBox2.TabIndex = 73;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "입력정보";
            // 
            // frmOrderCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.ClientSize = new System.Drawing.Size(1099, 649);
            this.Name = "frmOrderCheck";
            this.Text = "발주등록";
            this.Load += new System.EventHandler(this.frmOrderCheck_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Label lblStock;
        protected System.Windows.Forms.Label lblUnit;
        protected System.Windows.Forms.Label lblMatName;
        protected System.Windows.Forms.Label lblEmail;
        protected System.Windows.Forms.Label lblTelNum;
        protected System.Windows.Forms.Label lblCusID;
        protected System.Windows.Forms.Label lblCusManager;
        protected System.Windows.Forms.Label lblCusName;
        protected System.Windows.Forms.Button btnOrder;
        protected System.Windows.Forms.Label lblTot;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Label label23;
        protected System.Windows.Forms.Label label22;
        protected System.Windows.Forms.ComboBox cboCustomer;
        protected System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnOrderDel;
        private System.Windows.Forms.Button btnOrderChange;
        private System.Windows.Forms.Button btnOrderAdd;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvMaterial;
        private System.Windows.Forms.DataGridView dgvOrderDetail;
        protected System.Windows.Forms.Label label45;
        protected System.Windows.Forms.Label label44;
        protected System.Windows.Forms.Label label35;
        protected System.Windows.Forms.Label label36;
        protected System.Windows.Forms.Label label37;
        protected System.Windows.Forms.Label label41;
        protected System.Windows.Forms.Label label38;
        protected System.Windows.Forms.Label label39;
        protected System.Windows.Forms.Label label40;
        private Controls.NumTextBox txtPrice;
        private System.Windows.Forms.NumericUpDown nuQuantity;
        protected System.Windows.Forms.Label label43;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.Label lblMatID;
        private System.Windows.Forms.DateTimePicker dtpRequiredDate;
        private System.Windows.Forms.Label label4;
        protected System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtMat;
        protected System.Windows.Forms.Label lblCurCustomer;
        protected System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
