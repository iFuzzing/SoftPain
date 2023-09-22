namespace SoftPain
{
    partial class AttachProcessForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttachProcessForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.dtgProcessList = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnAttachP = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdateListProcesses = new System.Windows.Forms.PictureBox();
            this.pidcol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namecol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbProcesListCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProcessList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAttachP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdateListProcesses)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(270, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(18, 17);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 4;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dtgProcessList
            // 
            this.dtgProcessList.AllowUserToAddRows = false;
            this.dtgProcessList.AllowUserToDeleteRows = false;
            this.dtgProcessList.AllowUserToResizeColumns = false;
            this.dtgProcessList.AllowUserToResizeRows = false;
            this.dtgProcessList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgProcessList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgProcessList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.dtgProcessList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(106)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgProcessList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgProcessList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProcessList.ColumnHeadersVisible = false;
            this.dtgProcessList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pidcol,
            this.namecol});
            this.dtgProcessList.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(204)))), ((int)(((byte)(106)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgProcessList.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtgProcessList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.dtgProcessList.Location = new System.Drawing.Point(12, 127);
            this.dtgProcessList.MultiSelect = false;
            this.dtgProcessList.Name = "dtgProcessList";
            this.dtgProcessList.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(206)))), ((int)(((byte)(106)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgProcessList.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgProcessList.RowHeadersVisible = false;
            this.dtgProcessList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(206)))), ((int)(((byte)(106)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.dtgProcessList.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dtgProcessList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgProcessList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgProcessList.Size = new System.Drawing.Size(276, 218);
            this.dtgProcessList.TabIndex = 6;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SoftPain.Properties.Resources.dashboard;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(73, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // btnAttachP
            // 
            this.btnAttachP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAttachP.Image = global::SoftPain.Properties.Resources.btnAttach;
            this.btnAttachP.Location = new System.Drawing.Point(104, 407);
            this.btnAttachP.Name = "btnAttachP";
            this.btnAttachP.Size = new System.Drawing.Size(98, 31);
            this.btnAttachP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnAttachP.TabIndex = 20;
            this.btnAttachP.TabStop = false;
            this.btnAttachP.Click += new System.EventHandler(this.btnAttachP_Click);
            this.btnAttachP.MouseEnter += new System.EventHandler(this.btnAttachP_MouseEnter);
            this.btnAttachP.MouseLeave += new System.EventHandler(this.btnAttachP_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(88, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "Select a process";
            // 
            // btnUpdateListProcesses
            // 
            this.btnUpdateListProcesses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateListProcesses.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateListProcesses.Image")));
            this.btnUpdateListProcesses.Location = new System.Drawing.Point(141, 379);
            this.btnUpdateListProcesses.Name = "btnUpdateListProcesses";
            this.btnUpdateListProcesses.Size = new System.Drawing.Size(24, 21);
            this.btnUpdateListProcesses.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnUpdateListProcesses.TabIndex = 22;
            this.btnUpdateListProcesses.TabStop = false;
            this.btnUpdateListProcesses.Click += new System.EventHandler(this.btnUpdateListProcesses_Click);
            // 
            // pidcol
            // 
            this.pidcol.HeaderText = "PID";
            this.pidcol.Name = "pidcol";
            this.pidcol.ReadOnly = true;
            // 
            // namecol
            // 
            this.namecol.HeaderText = "Name";
            this.namecol.Name = "namecol";
            this.namecol.ReadOnly = true;
            // 
            // lbProcesListCount
            // 
            this.lbProcesListCount.AutoSize = true;
            this.lbProcesListCount.ForeColor = System.Drawing.Color.White;
            this.lbProcesListCount.Location = new System.Drawing.Point(12, 358);
            this.lbProcesListCount.Name = "lbProcesListCount";
            this.lbProcesListCount.Size = new System.Drawing.Size(66, 13);
            this.lbProcesListCount.TabIndex = 23;
            this.lbProcesListCount.Text = "Nº Process: ";
            // 
            // AttachProcessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(300, 450);
            this.Controls.Add(this.lbProcesListCount);
            this.Controls.Add(this.btnUpdateListProcesses);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAttachP);
            this.Controls.Add(this.dtgProcessList);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AttachProcessForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AttachProcessForm";
            this.Load += new System.EventHandler(this.AttachProcessForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProcessList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAttachP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdateListProcesses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.DataGridView dtgProcessList;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox btnAttachP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnUpdateListProcesses;
        private System.Windows.Forms.DataGridViewTextBoxColumn pidcol;
        private System.Windows.Forms.DataGridViewTextBoxColumn namecol;
        private System.Windows.Forms.Label lbProcesListCount;
    }
}