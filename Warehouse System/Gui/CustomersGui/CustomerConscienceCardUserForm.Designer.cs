
namespace SMSystem.Gui.CustomersGui
{
    partial class CustomerConscienceCardUserForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            flowLayoutPanelNavBar = new System.Windows.Forms.FlowLayoutPanel();
            buttonAdd = new System.Windows.Forms.Button();
            buttonEdit = new System.Windows.Forms.Button();
            buttonDelete = new System.Windows.Forms.Button();
            buttonRefresh = new System.Windows.Forms.Button();
            panelSearchBar = new System.Windows.Forms.Panel();
            buttonSearch = new System.Windows.Forms.Button();
            textBoxSearch = new System.Windows.Forms.TextBox();
            panel1 = new System.Windows.Forms.Panel();
            labelFullName = new System.Windows.Forms.Label();
            labelCustomerId = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            dataGridView = new System.Windows.Forms.DataGridView();
            flowLayoutPanelNavBar.SuspendLayout();
            panelSearchBar.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanelNavBar
            // 
            flowLayoutPanelNavBar.AutoScroll = true;
            flowLayoutPanelNavBar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            flowLayoutPanelNavBar.Controls.Add(buttonAdd);
            flowLayoutPanelNavBar.Controls.Add(buttonEdit);
            flowLayoutPanelNavBar.Controls.Add(buttonDelete);
            flowLayoutPanelNavBar.Controls.Add(buttonRefresh);
            flowLayoutPanelNavBar.Controls.Add(panelSearchBar);
            flowLayoutPanelNavBar.Dock = System.Windows.Forms.DockStyle.Top;
            flowLayoutPanelNavBar.Location = new System.Drawing.Point(0, 0);
            flowLayoutPanelNavBar.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            flowLayoutPanelNavBar.Name = "flowLayoutPanelNavBar";
            flowLayoutPanelNavBar.Padding = new System.Windows.Forms.Padding(5);
            flowLayoutPanelNavBar.Size = new System.Drawing.Size(1146, 76);
            flowLayoutPanelNavBar.TabIndex = 1;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = System.Drawing.Color.Salmon;
            buttonAdd.Image = Properties.Resources.add_32px;
            buttonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonAdd.Location = new System.Drawing.Point(1012, 11);
            buttonAdd.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new System.Drawing.Size(119, 54);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "  اضافة";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = System.Drawing.Color.Salmon;
            buttonEdit.Image = Properties.Resources.edit_32px;
            buttonEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonEdit.Location = new System.Drawing.Point(883, 11);
            buttonEdit.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new System.Drawing.Size(119, 54);
            buttonEdit.TabIndex = 1;
            buttonEdit.Text = "  تعديل";
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = System.Drawing.Color.Salmon;
            buttonDelete.Image = Properties.Resources.Delete_32px;
            buttonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonDelete.Location = new System.Drawing.Point(754, 11);
            buttonDelete.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new System.Drawing.Size(119, 54);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "  حذف";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonRefresh
            // 
            buttonRefresh.BackColor = System.Drawing.Color.Salmon;
            buttonRefresh.Image = Properties.Resources.refresh_32px;
            buttonRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonRefresh.Location = new System.Drawing.Point(625, 11);
            buttonRefresh.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new System.Drawing.Size(119, 54);
            buttonRefresh.TabIndex = 3;
            buttonRefresh.Text = "  تحديث";
            buttonRefresh.UseVisualStyleBackColor = false;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // panelSearchBar
            // 
            panelSearchBar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            panelSearchBar.Controls.Add(buttonSearch);
            panelSearchBar.Controls.Add(textBoxSearch);
            panelSearchBar.Location = new System.Drawing.Point(234, 15);
            panelSearchBar.Name = "panelSearchBar";
            panelSearchBar.Size = new System.Drawing.Size(383, 45);
            panelSearchBar.TabIndex = 4;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            buttonSearch.Dock = System.Windows.Forms.DockStyle.Right;
            buttonSearch.Image = Properties.Resources.search_32px;
            buttonSearch.Location = new System.Drawing.Point(322, 0);
            buttonSearch.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new System.Drawing.Size(61, 45);
            buttonSearch.TabIndex = 6;
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            textBoxSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            textBoxSearch.Location = new System.Drawing.Point(0, 16);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new System.Drawing.Size(314, 26);
            textBoxSearch.TabIndex = 5;
            textBoxSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(255, 128, 0);
            panel1.Controls.Add(labelFullName);
            panel1.Controls.Add(labelCustomerId);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel1.Location = new System.Drawing.Point(0, 612);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1146, 88);
            panel1.TabIndex = 3;
            // 
            // labelFullName
            // 
            labelFullName.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            labelFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            labelFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelFullName.Location = new System.Drawing.Point(13, 23);
            labelFullName.Name = "labelFullName";
            labelFullName.Size = new System.Drawing.Size(456, 56);
            labelFullName.TabIndex = 0;
            labelFullName.Text = "....................";
            labelFullName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            labelFullName.Click += label4_Click;
            // 
            // labelCustomerId
            // 
            labelCustomerId.Anchor = System.Windows.Forms.AnchorStyles.Right;
            labelCustomerId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            labelCustomerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelCustomerId.Location = new System.Drawing.Point(772, 23);
            labelCustomerId.Name = "labelCustomerId";
            labelCustomerId.Size = new System.Drawing.Size(173, 56);
            labelCustomerId.TabIndex = 0;
            labelCustomerId.Text = "000";
            labelCustomerId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(475, 23);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(166, 29);
            label3.TabIndex = 0;
            label3.Text = "اسم العميل او الوحدة";
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(940, 23);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(120, 29);
            label1.TabIndex = 0;
            label1.Text = "معرف العميل:";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridView.BackgroundColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridView.Location = new System.Drawing.Point(0, 76);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridView.RowTemplate.Height = 29;
            dataGridView.Size = new System.Drawing.Size(1146, 536);
            dataGridView.TabIndex = 4;
            dataGridView.CellDoubleClick += dataGridView_CellDoubleClick;
            // 
            // CustomerConscienceCardUserForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(1146, 700);
            Controls.Add(dataGridView);
            Controls.Add(panel1);
            Controls.Add(flowLayoutPanelNavBar);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            Name = "CustomerConscienceCardUserForm";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            RightToLeftLayout = true;
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "إدارة سجل الذمة";
            TopMost = true;
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            flowLayoutPanelNavBar.ResumeLayout(false);
            panelSearchBar.ResumeLayout(false);
            panelSearchBar.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelNavBar;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Panel panelSearchBar;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.Label labelCustomerId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}
