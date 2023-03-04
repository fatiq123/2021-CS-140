namespace _2021_CS_140
{
    partial class ManageStudentGridView
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.closeBtn = new System.Windows.Forms.Button();
            this.studentDeleteBtn = new System.Windows.Forms.Button();
            this.studentUpdateBtn = new System.Windows.Forms.Button();
            this.searchStudentBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(949, 322);
            this.dataGridView1.TabIndex = 0;
            // 
            // closeBtn
            // 
            this.closeBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.Location = new System.Drawing.Point(836, 431);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(104, 44);
            this.closeBtn.TabIndex = 9;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            // 
            // studentDeleteBtn
            // 
            this.studentDeleteBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.studentDeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentDeleteBtn.Location = new System.Drawing.Point(284, 431);
            this.studentDeleteBtn.Name = "studentDeleteBtn";
            this.studentDeleteBtn.Size = new System.Drawing.Size(104, 44);
            this.studentDeleteBtn.TabIndex = 8;
            this.studentDeleteBtn.Text = "Delete";
            this.studentDeleteBtn.UseVisualStyleBackColor = true;
            // 
            // studentUpdateBtn
            // 
            this.studentUpdateBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.studentUpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentUpdateBtn.Location = new System.Drawing.Point(153, 431);
            this.studentUpdateBtn.Name = "studentUpdateBtn";
            this.studentUpdateBtn.Size = new System.Drawing.Size(104, 44);
            this.studentUpdateBtn.TabIndex = 7;
            this.studentUpdateBtn.Text = "Update";
            this.studentUpdateBtn.UseVisualStyleBackColor = true;
            // 
            // searchStudentBtn
            // 
            this.searchStudentBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchStudentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchStudentBtn.Location = new System.Drawing.Point(24, 431);
            this.searchStudentBtn.Name = "searchStudentBtn";
            this.searchStudentBtn.Size = new System.Drawing.Size(104, 44);
            this.searchStudentBtn.TabIndex = 6;
            this.searchStudentBtn.Text = "Search";
            this.searchStudentBtn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(971, 522);
            this.panel1.TabIndex = 10;
            // 
            // ManageStudentGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 522);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.studentDeleteBtn);
            this.Controls.Add(this.studentUpdateBtn);
            this.Controls.Add(this.searchStudentBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "ManageStudentGridView";
            this.Text = "ManageStudentGridView";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button studentDeleteBtn;
        private System.Windows.Forms.Button studentUpdateBtn;
        private System.Windows.Forms.Button searchStudentBtn;
        private System.Windows.Forms.Panel panel1;
    }
}