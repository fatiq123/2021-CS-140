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
            this.closeBtn = new System.Windows.Forms.Button();
            this.studentDeleteBtn = new System.Windows.Forms.Button();
            this.studentUpdateBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentSearchBox = new System.Windows.Forms.TextBox();
            this.SearchLabel = new System.Windows.Forms.Label();
            this.manageStudentForm = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.manageStudentForm.SuspendLayout();
            this.SuspendLayout();
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
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click_1);
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
            this.studentDeleteBtn.Click += new System.EventHandler(this.studentDeleteBtn_Click);
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
            this.studentUpdateBtn.Click += new System.EventHandler(this.studentUpdateBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(949, 322);
            this.dataGridView1.TabIndex = 0;
            // 
            // studentSearchBox
            // 
            this.studentSearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentSearchBox.Location = new System.Drawing.Point(641, 30);
            this.studentSearchBox.Name = "studentSearchBox";
            this.studentSearchBox.Size = new System.Drawing.Size(217, 26);
            this.studentSearchBox.TabIndex = 7;
            this.studentSearchBox.TextChanged += new System.EventHandler(this.studentSearchBox_TextChanged);
            // 
            // SearchLabel
            // 
            this.SearchLabel.AutoSize = true;
            this.SearchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchLabel.Location = new System.Drawing.Point(543, 30);
            this.SearchLabel.Name = "SearchLabel";
            this.SearchLabel.Size = new System.Drawing.Size(70, 24);
            this.SearchLabel.TabIndex = 8;
            this.SearchLabel.Text = "Search";
            // 
            // manageStudentForm
            // 
            this.manageStudentForm.Controls.Add(this.SearchLabel);
            this.manageStudentForm.Controls.Add(this.studentSearchBox);
            this.manageStudentForm.Controls.Add(this.dataGridView1);
            this.manageStudentForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.manageStudentForm.Location = new System.Drawing.Point(0, 0);
            this.manageStudentForm.Name = "manageStudentForm";
            this.manageStudentForm.Size = new System.Drawing.Size(971, 522);
            this.manageStudentForm.TabIndex = 10;
            this.manageStudentForm.Paint += new System.Windows.Forms.PaintEventHandler(this.manageStudentForm_Paint);
            // 
            // ManageStudentGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 522);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.studentDeleteBtn);
            this.Controls.Add(this.studentUpdateBtn);
            this.Controls.Add(this.manageStudentForm);
            this.Name = "ManageStudentGridView";
            this.Text = "ManageStudentGridView";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.manageStudentForm.ResumeLayout(false);
            this.manageStudentForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button studentDeleteBtn;
        private System.Windows.Forms.Button studentUpdateBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox studentSearchBox;
        private System.Windows.Forms.Label SearchLabel;
        private System.Windows.Forms.Panel manageStudentForm;
    }
}