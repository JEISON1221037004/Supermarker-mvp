namespace Supermarket_mvp.Views
{
    partial class PayModeView
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
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            DgPayMode = new DataGridView();
            BtnNew = new Button();
            BtnEdit = new Button();
            tabControl1 = new TabControl();
            tabPagePayModeList = new TabPage();
            BtnSearch = new Button();
            TxtSearch = new TextBox();
            label2 = new Label();
            BtnClose = new Button();
            BtnDelete = new Button();
            tabPagePayModeDetail = new TabPage();
            TxtPayModeObservation = new TextBox();
            TxtPayModeName = new TextBox();
            TxtPayModeId = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            BtnCancel = new Button();
            BtnSave = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DgPayMode).BeginInit();
            tabControl1.SuspendLayout();
            tabPagePayModeList.SuspendLayout();
            tabPagePayModeDetail.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 100);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(118, 33);
            label1.Name = "label1";
            label1.Size = new Size(152, 37);
            label1.TabIndex = 1;
            label1.Text = " Pay Mode";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.buy;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // DgPayMode
            // 
            DgPayMode.AllowUserToAddRows = false;
            DgPayMode.AllowUserToDeleteRows = false;
            DgPayMode.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgPayMode.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgPayMode.Location = new Point(8, 87);
            DgPayMode.Name = "DgPayMode";
            DgPayMode.ReadOnly = true;
            DgPayMode.RowTemplate.Height = 25;
            DgPayMode.Size = new Size(580, 221);
            DgPayMode.TabIndex = 1;
            DgPayMode.CellContentClick += dataGridView1_CellContentClick;
            // 
            // BtnNew
            // 
            BtnNew.BackColor = Color.LightGray;
            BtnNew.ForeColor = SystemColors.ControlDarkDark;
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(637, 56);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(113, 45);
            BtnNew.TabIndex = 2;
            BtnNew.UseVisualStyleBackColor = false;
            // 
            // BtnEdit
            // 
            BtnEdit.BackColor = Color.LightGray;
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(637, 121);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(113, 45);
            BtnEdit.TabIndex = 3;
            BtnEdit.UseVisualStyleBackColor = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPagePayModeList);
            tabControl1.Controls.Add(tabPagePayModeDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 100);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 350);
            tabControl1.TabIndex = 4;
            // 
            // tabPagePayModeList
            // 
            tabPagePayModeList.Controls.Add(BtnSearch);
            tabPagePayModeList.Controls.Add(TxtSearch);
            tabPagePayModeList.Controls.Add(label2);
            tabPagePayModeList.Controls.Add(BtnClose);
            tabPagePayModeList.Controls.Add(BtnDelete);
            tabPagePayModeList.Controls.Add(DgPayMode);
            tabPagePayModeList.Controls.Add(BtnNew);
            tabPagePayModeList.Controls.Add(BtnEdit);
            tabPagePayModeList.Location = new Point(4, 24);
            tabPagePayModeList.Name = "tabPagePayModeList";
            tabPagePayModeList.Padding = new Padding(3);
            tabPagePayModeList.Size = new Size(792, 322);
            tabPagePayModeList.TabIndex = 0;
            tabPagePayModeList.Text = "Pay Mode List";
            tabPagePayModeList.UseVisualStyleBackColor = true;
            // 
            // BtnSearch
            // 
            BtnSearch.BackColor = Color.LightGray;
            BtnSearch.Image = Properties.Resources.search_small;
            BtnSearch.Location = new Point(529, 38);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(59, 39);
            BtnSearch.TabIndex = 8;
            BtnSearch.UseVisualStyleBackColor = false;
            // 
            // TxtSearch
            // 
            TxtSearch.BackColor = SystemColors.HighlightText;
            TxtSearch.Location = new Point(14, 47);
            TxtSearch.Multiline = true;
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to search";
            TxtSearch.Size = new Size(487, 23);
            TxtSearch.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 16);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 6;
            label2.Text = "Search Pay Mode";
            label2.Click += label2_Click;
            // 
            // BtnClose
            // 
            BtnClose.BackColor = Color.LightGray;
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(637, 254);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(113, 45);
            BtnClose.TabIndex = 5;
            BtnClose.UseVisualStyleBackColor = false;
            // 
            // BtnDelete
            // 
            BtnDelete.BackColor = Color.LightGray;
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(637, 185);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(113, 45);
            BtnDelete.TabIndex = 4;
            BtnDelete.UseVisualStyleBackColor = false;
            // 
            // tabPagePayModeDetail
            // 
            tabPagePayModeDetail.Controls.Add(TxtPayModeObservation);
            tabPagePayModeDetail.Controls.Add(TxtPayModeName);
            tabPagePayModeDetail.Controls.Add(TxtPayModeId);
            tabPagePayModeDetail.Controls.Add(label5);
            tabPagePayModeDetail.Controls.Add(label4);
            tabPagePayModeDetail.Controls.Add(label3);
            tabPagePayModeDetail.Controls.Add(BtnCancel);
            tabPagePayModeDetail.Controls.Add(BtnSave);
            tabPagePayModeDetail.Location = new Point(4, 24);
            tabPagePayModeDetail.Name = "tabPagePayModeDetail";
            tabPagePayModeDetail.Padding = new Padding(3);
            tabPagePayModeDetail.Size = new Size(792, 322);
            tabPagePayModeDetail.TabIndex = 1;
            tabPagePayModeDetail.Text = "Pay Mode Detail";
            tabPagePayModeDetail.UseVisualStyleBackColor = true;
            // 
            // TxtPayModeObservation
            // 
            TxtPayModeObservation.ForeColor = SystemColors.WindowText;
            TxtPayModeObservation.Location = new Point(54, 204);
            TxtPayModeObservation.Multiline = true;
            TxtPayModeObservation.Name = "TxtPayModeObservation";
            TxtPayModeObservation.PlaceholderText = "Pay Mode Observation";
            TxtPayModeObservation.Size = new Size(228, 59);
            TxtPayModeObservation.TabIndex = 7;
            TxtPayModeObservation.TextChanged += textBox4_TextChanged;
            // 
            // TxtPayModeName
            // 
            TxtPayModeName.Location = new Point(54, 135);
            TxtPayModeName.Multiline = true;
            TxtPayModeName.Name = "TxtPayModeName";
            TxtPayModeName.PlaceholderText = "Pay Mode Name";
            TxtPayModeName.Size = new Size(228, 23);
            TxtPayModeName.TabIndex = 6;
            // 
            // TxtPayModeId
            // 
            TxtPayModeId.BackColor = SystemColors.MenuBar;
            TxtPayModeId.Location = new Point(54, 69);
            TxtPayModeId.Multiline = true;
            TxtPayModeId.Name = "TxtPayModeId";
            TxtPayModeId.Size = new Size(228, 23);
            TxtPayModeId.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(54, 186);
            label5.Name = "label5";
            label5.Size = new Size(127, 15);
            label5.TabIndex = 4;
            label5.Text = "Pay Mode Observation";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 117);
            label4.Name = "label4";
            label4.Size = new Size(95, 15);
            label4.TabIndex = 3;
            label4.Text = "Pay Mode Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 51);
            label3.Name = "label3";
            label3.Size = new Size(73, 15);
            label3.TabIndex = 2;
            label3.Text = "Pay Mode Id";
            label3.Click += label3_Click;
            // 
            // BtnCancel
            // 
            BtnCancel.BackColor = Color.LightGray;
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(160, 269);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(75, 45);
            BtnCancel.TabIndex = 1;
            BtnCancel.UseVisualStyleBackColor = false;
            // 
            // BtnSave
            // 
            BtnSave.BackColor = Color.LightGray;
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(52, 270);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(75, 44);
            BtnSave.TabIndex = 0;
            BtnSave.UseVisualStyleBackColor = false;
            // 
            // PayModeView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "PayModeView";
            Text = "Pay Mode Management";
            Load += PayModelView_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DgPayMode).EndInit();
            tabControl1.ResumeLayout(false);
            tabPagePayModeList.ResumeLayout(false);
            tabPagePayModeList.PerformLayout();
            tabPagePayModeDetail.ResumeLayout(false);
            tabPagePayModeDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private DataGridView DgPayMode;
        private Button BtnNew;
        private Button BtnEdit;
        private TabControl tabControl1;
        private TabPage tabPagePayModeList;
        private TabPage tabPagePayModeDetail;
        private TextBox TxtSearch;
        private Label label2;
        private Button BtnClose;
        private Button BtnDelete;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button BtnCancel;
        private Button BtnSave;
        private TextBox TxtPayModeObservation;
        private TextBox TxtPayModeName;
        private TextBox TxtPayModeId;
        private Button BtnSearch;
    }
}