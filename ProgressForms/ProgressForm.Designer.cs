namespace ProgressForms
{
    partial class ProgressForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.CancelButton = new System.Windows.Forms.Button();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.MainMessageLabel = new System.Windows.Forms.Label();
            this.SubMessageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(387, 122);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(114, 26);
            this.CancelButton.TabIndex = 0;
            this.CancelButton.Text = "キャンセル";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(12, 78);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(489, 24);
            this.ProgressBar.TabIndex = 1;
            // 
            // MainMessageLabel
            // 
            this.MainMessageLabel.AutoSize = true;
            this.MainMessageLabel.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MainMessageLabel.Location = new System.Drawing.Point(12, 21);
            this.MainMessageLabel.Name = "MainMessageLabel";
            this.MainMessageLabel.Size = new System.Drawing.Size(128, 15);
            this.MainMessageLabel.TabIndex = 2;
            this.MainMessageLabel.Text = "hogehogeしています";
            // 
            // SubMessageLabel
            // 
            this.SubMessageLabel.AutoSize = true;
            this.SubMessageLabel.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SubMessageLabel.Location = new System.Drawing.Point(12, 49);
            this.SubMessageLabel.Name = "SubMessageLabel";
            this.SubMessageLabel.Size = new System.Drawing.Size(128, 15);
            this.SubMessageLabel.TabIndex = 3;
            this.SubMessageLabel.Text = "hogehogeしています";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 165);
            this.Controls.Add(this.SubMessageLabel);
            this.Controls.Add(this.MainMessageLabel);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.CancelButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Label MainMessageLabel;
        private System.Windows.Forms.Label SubMessageLabel;
    }
}

