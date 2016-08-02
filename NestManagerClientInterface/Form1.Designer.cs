namespace NestManagerClientInterface
{
    partial class Form1
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
            this.dgvMainView = new System.Windows.Forms.DataGridView();
            this.comboThickness = new System.Windows.Forms.ComboBox();
            this.btnPromoteNest = new System.Windows.Forms.Button();
            this.btnRemoveNest = new System.Windows.Forms.Button();
            this.btnCustomNest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainView)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMainView
            // 
            this.dgvMainView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMainView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMainView.Location = new System.Drawing.Point(12, 41);
            this.dgvMainView.Name = "dgvMainView";
            this.dgvMainView.Size = new System.Drawing.Size(1062, 313);
            this.dgvMainView.TabIndex = 0;
            // 
            // comboThickness
            // 
            this.comboThickness.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboThickness.FormattingEnabled = true;
            this.comboThickness.Location = new System.Drawing.Point(953, 14);
            this.comboThickness.Name = "comboThickness";
            this.comboThickness.Size = new System.Drawing.Size(121, 21);
            this.comboThickness.TabIndex = 1;
            // 
            // btnPromoteNest
            // 
            this.btnPromoteNest.Location = new System.Drawing.Point(15, 16);
            this.btnPromoteNest.Name = "btnPromoteNest";
            this.btnPromoteNest.Size = new System.Drawing.Size(116, 23);
            this.btnPromoteNest.TabIndex = 2;
            this.btnPromoteNest.Text = "Promote Nest";
            this.btnPromoteNest.UseVisualStyleBackColor = true;
            // 
            // btnRemoveNest
            // 
            this.btnRemoveNest.Enabled = false;
            this.btnRemoveNest.Location = new System.Drawing.Point(255, 16);
            this.btnRemoveNest.Name = "btnRemoveNest";
            this.btnRemoveNest.Size = new System.Drawing.Size(94, 23);
            this.btnRemoveNest.TabIndex = 3;
            this.btnRemoveNest.Text = "Remove Nest";
            this.btnRemoveNest.UseVisualStyleBackColor = true;
            this.btnRemoveNest.Visible = false;
            // 
            // btnCustomNest
            // 
            this.btnCustomNest.Location = new System.Drawing.Point(137, 16);
            this.btnCustomNest.Name = "btnCustomNest";
            this.btnCustomNest.Size = new System.Drawing.Size(112, 23);
            this.btnCustomNest.TabIndex = 4;
            this.btnCustomNest.Text = "Add Custom Nest";
            this.btnCustomNest.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(861, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Plate Thickness:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(764, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "For support, call (985) 705-7956 and have your credit card ready.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 387);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCustomNest);
            this.Controls.Add(this.btnRemoveNest);
            this.Controls.Add(this.btnPromoteNest);
            this.Controls.Add(this.comboThickness);
            this.Controls.Add(this.dgvMainView);
            this.Name = "Form1";
            this.Text = "Nest Manager Clinet Interface";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMainView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMainView;
        private System.Windows.Forms.ComboBox comboThickness;
        private System.Windows.Forms.Button btnPromoteNest;
        private System.Windows.Forms.Button btnRemoveNest;
        private System.Windows.Forms.Button btnCustomNest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

