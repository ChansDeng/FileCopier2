namespace FileCopier
{
    partial class FrmFileCopier
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
            this.lblSource = new System.Windows.Forms.Label();
            this.lblTarget = new System.Windows.Forms.Label();
            this.txtTargetDir = new System.Windows.Forms.TextBox();
            this.tvwSource = new System.Windows.Forms.TreeView();
            this.tvwTarget = new System.Windows.Forms.TreeView();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.chkOverWrite = new System.Windows.Forms.CheckBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSource
            // 
            this.lblSource.AutoSize = true;
            this.lblSource.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblSource.Location = new System.Drawing.Point(12, 9);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(77, 17);
            this.lblSource.TabIndex = 0;
            this.lblSource.Text = "Source Files";
            // 
            // lblTarget
            // 
            this.lblTarget.AutoSize = true;
            this.lblTarget.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.lblTarget.Location = new System.Drawing.Point(272, 9);
            this.lblTarget.Name = "lblTarget";
            this.lblTarget.Size = new System.Drawing.Size(73, 17);
            this.lblTarget.TabIndex = 1;
            this.lblTarget.Text = "Target Files";
            // 
            // txtTargetDir
            // 
            this.txtTargetDir.Location = new System.Drawing.Point(275, 30);
            this.txtTargetDir.Name = "txtTargetDir";
            this.txtTargetDir.Size = new System.Drawing.Size(235, 21);
            this.txtTargetDir.TabIndex = 2;
            // 
            // tvwSource
            // 
            this.tvwSource.CheckBoxes = true;
            this.tvwSource.Location = new System.Drawing.Point(15, 30);
            this.tvwSource.Name = "tvwSource";
            this.tvwSource.Size = new System.Drawing.Size(235, 243);
            this.tvwSource.TabIndex = 3;
            this.tvwSource.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tvwSource_AfterCheck);
            this.tvwSource.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvwSource_BeforeExpand);
            // 
            // tvwTarget
            // 
            this.tvwTarget.Location = new System.Drawing.Point(275, 57);
            this.tvwTarget.Name = "tvwTarget";
            this.tvwTarget.Size = new System.Drawing.Size(235, 216);
            this.tvwTarget.TabIndex = 4;
            this.tvwTarget.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvwTarget_BeforeExpand);
            this.tvwTarget.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwTarget_AfterSelect);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(95, 289);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(15, 323);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(41, 12);
            this.lblStatus.TabIndex = 6;
            this.lblStatus.Text = "Status";
            // 
            // chkOverWrite
            // 
            this.chkOverWrite.AutoSize = true;
            this.chkOverWrite.Location = new System.Drawing.Point(275, 289);
            this.chkOverWrite.Name = "chkOverWrite";
            this.chkOverWrite.Size = new System.Drawing.Size(138, 16);
            this.chkOverWrite.TabIndex = 7;
            this.chkOverWrite.Text = "Overwrite if exists";
            this.chkOverWrite.UseVisualStyleBackColor = true;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(419, 289);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 8;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(419, 323);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(419, 357);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // FrmFileCopier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 395);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.chkOverWrite);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.tvwTarget);
            this.Controls.Add(this.tvwSource);
            this.Controls.Add(this.txtTargetDir);
            this.Controls.Add(this.lblTarget);
            this.Controls.Add(this.lblSource);
            this.Name = "FrmFileCopier";
            this.Text = "File Copier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Label lblTarget;
        private System.Windows.Forms.TextBox txtTargetDir;
        private System.Windows.Forms.TreeView tvwSource;
        private System.Windows.Forms.TreeView tvwTarget;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.CheckBox chkOverWrite;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
    }
}

