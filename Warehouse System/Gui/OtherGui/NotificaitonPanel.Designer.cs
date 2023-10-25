
namespace SMSystem.Gui.OtherGui
{
    partial class NotificaitonPanel
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
            PanelNote = new System.Windows.Forms.Panel();
            LabelNote = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            PanelNote.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PanelNote
            // 
            PanelNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            PanelNote.Controls.Add(LabelNote);
            PanelNote.Controls.Add(pictureBox1);
            PanelNote.Location = new System.Drawing.Point(3, 2);
            PanelNote.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            PanelNote.Name = "PanelNote";
            PanelNote.Size = new System.Drawing.Size(472, 58);
            PanelNote.TabIndex = 1;
            // 
            // LabelNote
            // 
            LabelNote.BackColor = System.Drawing.Color.Silver;
            LabelNote.Dock = System.Windows.Forms.DockStyle.Fill;
            LabelNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            LabelNote.ForeColor = System.Drawing.Color.Black;
            LabelNote.Location = new System.Drawing.Point(82, 0);
            LabelNote.Name = "LabelNote";
            LabelNote.Size = new System.Drawing.Size(388, 56);
            LabelNote.TabIndex = 1;
            LabelNote.Text = "لا يلزم اتخاذ قرار ";
            LabelNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            pictureBox1.Image = Properties.Resources.icons8_Notification_128px;
            pictureBox1.Location = new System.Drawing.Point(0, 0);
            pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(82, 56);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // NotificaitonPanel
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(PanelNote);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "NotificaitonPanel";
            Size = new System.Drawing.Size(480, 63);
            PanelNote.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public System.Windows.Forms.Panel PanelNote;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label LabelNote;
    }
}
