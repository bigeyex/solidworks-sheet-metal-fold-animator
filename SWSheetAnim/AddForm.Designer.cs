namespace SWSheetAnim
{
    partial class AddForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.partListControl = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.foldListControl = new System.Windows.Forms.ListBox();
            this.addPreFoldBtn = new System.Windows.Forms.Button();
            this.addFoldBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.addMoveBtn = new System.Windows.Forms.Button();
            this.addCameraMoveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Parts";
            // 
            // partListControl
            // 
            this.partListControl.FormattingEnabled = true;
            this.partListControl.ItemHeight = 24;
            this.partListControl.Location = new System.Drawing.Point(33, 76);
            this.partListControl.Name = "partListControl";
            this.partListControl.Size = new System.Drawing.Size(206, 268);
            this.partListControl.TabIndex = 1;
            this.partListControl.SelectedIndexChanged += new System.EventHandler(this.partListControl_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Folds";
            // 
            // foldListControl
            // 
            this.foldListControl.FormattingEnabled = true;
            this.foldListControl.ItemHeight = 24;
            this.foldListControl.Location = new System.Drawing.Point(299, 76);
            this.foldListControl.Name = "foldListControl";
            this.foldListControl.Size = new System.Drawing.Size(206, 268);
            this.foldListControl.TabIndex = 1;
            // 
            // addPreFoldBtn
            // 
            this.addPreFoldBtn.Location = new System.Drawing.Point(299, 368);
            this.addPreFoldBtn.Name = "addPreFoldBtn";
            this.addPreFoldBtn.Size = new System.Drawing.Size(92, 46);
            this.addPreFoldBtn.TabIndex = 2;
            this.addPreFoldBtn.Text = "Crease";
            this.addPreFoldBtn.UseVisualStyleBackColor = true;
            this.addPreFoldBtn.Click += new System.EventHandler(this.addPreFoldBtn_Click);
            // 
            // addFoldBtn
            // 
            this.addFoldBtn.Location = new System.Drawing.Point(413, 368);
            this.addFoldBtn.Name = "addFoldBtn";
            this.addFoldBtn.Size = new System.Drawing.Size(92, 46);
            this.addFoldBtn.TabIndex = 2;
            this.addFoldBtn.Text = "Fold";
            this.addFoldBtn.UseVisualStyleBackColor = true;
            this.addFoldBtn.Click += new System.EventHandler(this.addFoldBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(126, 21);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(113, 45);
            this.refreshBtn.TabIndex = 3;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            // 
            // addMoveBtn
            // 
            this.addMoveBtn.Location = new System.Drawing.Point(147, 368);
            this.addMoveBtn.Name = "addMoveBtn";
            this.addMoveBtn.Size = new System.Drawing.Size(92, 46);
            this.addMoveBtn.TabIndex = 2;
            this.addMoveBtn.Text = "Move";
            this.addMoveBtn.UseVisualStyleBackColor = true;
            this.addMoveBtn.Click += new System.EventHandler(this.addMoveBtn_Click);
            // 
            // addCameraMoveBtn
            // 
            this.addCameraMoveBtn.Location = new System.Drawing.Point(33, 368);
            this.addCameraMoveBtn.Name = "addCameraMoveBtn";
            this.addCameraMoveBtn.Size = new System.Drawing.Size(92, 46);
            this.addCameraMoveBtn.TabIndex = 2;
            this.addCameraMoveBtn.Text = "Camera";
            this.addCameraMoveBtn.UseVisualStyleBackColor = true;
            this.addCameraMoveBtn.Click += new System.EventHandler(this.addCameraMoveBtn_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 467);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.addFoldBtn);
            this.Controls.Add(this.addCameraMoveBtn);
            this.Controls.Add(this.addMoveBtn);
            this.Controls.Add(this.addPreFoldBtn);
            this.Controls.Add(this.foldListControl);
            this.Controls.Add(this.partListControl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddForm";
            this.Text = "Add a Step";
            this.Shown += new System.EventHandler(this.AddForm_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox partListControl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox foldListControl;
        private System.Windows.Forms.Button addPreFoldBtn;
        private System.Windows.Forms.Button addFoldBtn;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button addMoveBtn;
        private System.Windows.Forms.Button addCameraMoveBtn;
    }
}