
namespace SMSystem.Gui.IncomeGui
{
    partial class IncomeUserControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            flowLayoutPanelNavBar = new System.Windows.Forms.FlowLayoutPanel();
            buttonAdd = new System.Windows.Forms.Button();
            buttonEdit = new System.Windows.Forms.Button();
            buttonDelete = new System.Windows.Forms.Button();
            buttonDamge = new System.Windows.Forms.Button();
            buttonOutConsceince = new System.Windows.Forms.Button();
            buttonRefresh = new System.Windows.Forms.Button();
            panelSearchBar = new System.Windows.Forms.Panel();
            buttonSearch = new System.Windows.Forms.Button();
            textBoxSearch = new System.Windows.Forms.TextBox();
            dataGridView = new System.Windows.Forms.DataGridView();
            flowLayoutPanelNavBar.SuspendLayout();
            panelSearchBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanelNavBar
            // 
            flowLayoutPanelNavBar.AutoScroll = true;
            flowLayoutPanelNavBar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            flowLayoutPanelNavBar.Controls.Add(buttonAdd);
            flowLayoutPanelNavBar.Controls.Add(buttonEdit);
            flowLayoutPanelNavBar.Controls.Add(buttonDelete);
            flowLayoutPanelNavBar.Controls.Add(buttonDamge);
            flowLayoutPanelNavBar.Controls.Add(buttonOutConsceince);
            flowLayoutPanelNavBar.Controls.Add(buttonRefresh);
            flowLayoutPanelNavBar.Controls.Add(panelSearchBar);
            flowLayoutPanelNavBar.Dock = System.Windows.Forms.DockStyle.Top;
            flowLayoutPanelNavBar.Location = new System.Drawing.Point(0, 0);
            flowLayoutPanelNavBar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            flowLayoutPanelNavBar.Name = "flowLayoutPanelNavBar";
            flowLayoutPanelNavBar.Padding = new System.Windows.Forms.Padding(5);
            flowLayoutPanelNavBar.Size = new System.Drawing.Size(1062, 75);
            flowLayoutPanelNavBar.TabIndex = 1;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = System.Drawing.Color.Silver;
            buttonAdd.Image = Properties.Resources.add_32px;
            buttonAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonAdd.Location = new System.Drawing.Point(955, 11);
            buttonAdd.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new System.Drawing.Size(93, 54);
            buttonAdd.TabIndex = 0;
            buttonAdd.Text = "  اضافة";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = System.Drawing.Color.Silver;
            buttonEdit.Image = Properties.Resources.edit_32px;
            buttonEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonEdit.Location = new System.Drawing.Point(858, 11);
            buttonEdit.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new System.Drawing.Size(89, 54);
            buttonEdit.TabIndex = 1;
            buttonEdit.Text = "  تعديل";
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = System.Drawing.Color.Silver;
            buttonDelete.Image = Properties.Resources.Delete_32px;
            buttonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonDelete.Location = new System.Drawing.Point(761, 11);
            buttonDelete.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new System.Drawing.Size(89, 54);
            buttonDelete.TabIndex = 2;
            buttonDelete.Text = "  حذف";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonDamge
            // 
            buttonDamge.BackColor = System.Drawing.Color.Silver;
            buttonDamge.Image = Properties.Resources.icons8_damaged_parcel_32px_1;
            buttonDamge.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonDamge.Location = new System.Drawing.Point(654, 11);
            buttonDamge.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            buttonDamge.Name = "buttonDamge";
            buttonDamge.Size = new System.Drawing.Size(99, 54);
            buttonDamge.TabIndex = 7;
            buttonDamge.Text = "منتهي الصلاحيه";
            buttonDamge.UseVisualStyleBackColor = false;
            buttonDamge.Click += buttonDamge_Click;
            // 
            // buttonOutConsceince
            // 
            buttonOutConsceince.BackColor = System.Drawing.Color.Silver;
            buttonOutConsceince.Image = Properties.Resources.icons8_export_32px;
            buttonOutConsceince.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonOutConsceince.Location = new System.Drawing.Point(528, 11);
            buttonOutConsceince.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            buttonOutConsceince.Name = "buttonOutConsceince";
            buttonOutConsceince.Size = new System.Drawing.Size(118, 54);
            buttonOutConsceince.TabIndex = 9;
            buttonOutConsceince.Text = "خارج مسؤلية المخزن";
            buttonOutConsceince.UseVisualStyleBackColor = false;
            buttonOutConsceince.Click += buttonOutConsceince_Click;
            // 
            // buttonRefresh
            // 
            buttonRefresh.BackColor = System.Drawing.Color.Silver;
            buttonRefresh.Image = Properties.Resources.refresh_32px;
            buttonRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            buttonRefresh.Location = new System.Drawing.Point(427, 11);
            buttonRefresh.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new System.Drawing.Size(93, 54);
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
            panelSearchBar.Location = new System.Drawing.Point(36, 16);
            panelSearchBar.Name = "panelSearchBar";
            panelSearchBar.Size = new System.Drawing.Size(384, 44);
            panelSearchBar.TabIndex = 4;
            // 
            // buttonSearch
            // 
            buttonSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            buttonSearch.Dock = System.Windows.Forms.DockStyle.Right;
            buttonSearch.Image = Properties.Resources.search_32px;
            buttonSearch.Location = new System.Drawing.Point(320, 0);
            buttonSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new System.Drawing.Size(64, 44);
            buttonSearch.TabIndex = 6;
            buttonSearch.UseVisualStyleBackColor = false;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Anchor = System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            textBoxSearch.BackColor = System.Drawing.SystemColors.Menu;
            textBoxSearch.Location = new System.Drawing.Point(0, 15);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new System.Drawing.Size(313, 26);
            textBoxSearch.TabIndex = 5;
            textBoxSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = System.Drawing.Color.Salmon;
            dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.ColumnHeadersHeight = 40;
            dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.Location = new System.Drawing.Point(0, 75);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.NullValue = "لا بيانات";
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView.RowHeadersWidth = 60;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView.RowTemplate.Height = 29;
            dataGridView.Size = new System.Drawing.Size(1062, 523);
            dataGridView.TabIndex = 2;
            dataGridView.DoubleClick += dataGridView_DoubleClick;
            // 
            // IncomeUserControl
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            Controls.Add(dataGridView);
            Controls.Add(flowLayoutPanelNavBar);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            Name = "IncomeUserControl";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            Size = new System.Drawing.Size(1062, 598);
            flowLayoutPanelNavBar.ResumeLayout(false);
            panelSearchBar.ResumeLayout(false);
            panelSearchBar.PerformLayout();
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
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonDamge;
        private System.Windows.Forms.Button buttonOutConsceince;
    }
}
