
namespace BlackboardWinForms
{
    partial class BlackBoardControl
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
            this._tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this._tlpEntryLabelAndInfoLabel = new System.Windows.Forms.TableLayoutPanel();
            this._lblEntryInfo = new System.Windows.Forms.Label();
            this._btnFilter = new System.Windows.Forms.Button();
            this._tlpEntryTextBoxAndButton = new System.Windows.Forms.TableLayoutPanel();
            this._addEditButton = new System.Windows.Forms.Button();
            this._txtNewEditEntry = new System.Windows.Forms.TextBox();
            this.lblHistory = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this._tlpMain.SuspendLayout();
            this._tlpEntryLabelAndInfoLabel.SuspendLayout();
            this._tlpEntryTextBoxAndButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // _tlpMain
            // 
            this._tlpMain.ColumnCount = 1;
            this._tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tlpMain.Controls.Add(this._tlpEntryLabelAndInfoLabel, 0, 0);
            this._tlpMain.Controls.Add(this._tlpEntryTextBoxAndButton, 0, 1);
            this._tlpMain.Controls.Add(this.lblHistory, 0, 2);
            this._tlpMain.Controls.Add(this.dataGridView1, 0, 3);
            this._tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tlpMain.Location = new System.Drawing.Point(0, 0);
            this._tlpMain.Name = "_tlpMain";
            this._tlpMain.RowCount = 5;
            this._tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this._tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this._tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._tlpMain.Size = new System.Drawing.Size(835, 609);
            this._tlpMain.TabIndex = 0;
            // 
            // _tlpEntryLabelAndInfoLabel
            // 
            this._tlpEntryLabelAndInfoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this._tlpEntryLabelAndInfoLabel.AutoSize = true;
            this._tlpEntryLabelAndInfoLabel.ColumnCount = 2;
            this._tlpEntryLabelAndInfoLabel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tlpEntryLabelAndInfoLabel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this._tlpEntryLabelAndInfoLabel.Controls.Add(this._lblEntryInfo, 0, 0);
            this._tlpEntryLabelAndInfoLabel.Controls.Add(this._btnFilter, 1, 0);
            this._tlpEntryLabelAndInfoLabel.Location = new System.Drawing.Point(3, 3);
            this._tlpEntryLabelAndInfoLabel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this._tlpEntryLabelAndInfoLabel.Name = "_tlpEntryLabelAndInfoLabel";
            this._tlpEntryLabelAndInfoLabel.RowCount = 1;
            this._tlpEntryLabelAndInfoLabel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._tlpEntryLabelAndInfoLabel.Size = new System.Drawing.Size(829, 41);
            this._tlpEntryLabelAndInfoLabel.TabIndex = 0;
            // 
            // _lblEntryInfo
            // 
            this._lblEntryInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._lblEntryInfo.AutoSize = true;
            this._lblEntryInfo.Location = new System.Drawing.Point(3, 16);
            this._lblEntryInfo.Name = "_lblEntryInfo";
            this._lblEntryInfo.Size = new System.Drawing.Size(344, 25);
            this._lblEntryInfo.TabIndex = 0;
            this._lblEntryInfo.Text = "#New Entry by #you from #today, #10:22";
            // 
            // _btnFilter
            // 
            this._btnFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._btnFilter.Location = new System.Drawing.Point(726, 3);
            this._btnFilter.Name = "_btnFilter";
            this._btnFilter.Size = new System.Drawing.Size(100, 35);
            this._btnFilter.TabIndex = 1;
            this._btnFilter.Text = "Filter...";
            this._btnFilter.UseVisualStyleBackColor = true;
            // 
            // _tlpEntryTextBoxAndButton
            // 
            this._tlpEntryTextBoxAndButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._tlpEntryTextBoxAndButton.AutoSize = true;
            this._tlpEntryTextBoxAndButton.ColumnCount = 2;
            this._tlpEntryTextBoxAndButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._tlpEntryTextBoxAndButton.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this._tlpEntryTextBoxAndButton.Controls.Add(this._addEditButton, 1, 0);
            this._tlpEntryTextBoxAndButton.Controls.Add(this._txtNewEditEntry, 0, 0);
            this._tlpEntryTextBoxAndButton.Location = new System.Drawing.Point(3, 53);
            this._tlpEntryTextBoxAndButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this._tlpEntryTextBoxAndButton.Name = "_tlpEntryTextBoxAndButton";
            this._tlpEntryTextBoxAndButton.RowCount = 1;
            this._tlpEntryTextBoxAndButton.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this._tlpEntryTextBoxAndButton.Size = new System.Drawing.Size(829, 110);
            this._tlpEntryTextBoxAndButton.TabIndex = 1;
            // 
            // _addEditButton
            // 
            this._addEditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._addEditButton.Location = new System.Drawing.Point(719, 3);
            this._addEditButton.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this._addEditButton.Name = "_addEditButton";
            this._addEditButton.Size = new System.Drawing.Size(107, 41);
            this._addEditButton.TabIndex = 1;
            this._addEditButton.Text = "#AddEdit";
            this._addEditButton.UseVisualStyleBackColor = true;
            // 
            // _txtNewEditEntry
            // 
            this._txtNewEditEntry.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._txtNewEditEntry.Location = new System.Drawing.Point(3, 3);
            this._txtNewEditEntry.Multiline = true;
            this._txtNewEditEntry.Name = "_txtNewEditEntry";
            this._txtNewEditEntry.Size = new System.Drawing.Size(683, 104);
            this._txtNewEditEntry.TabIndex = 2;
            // 
            // lblHistory
            // 
            this.lblHistory.AutoSize = true;
            this.lblHistory.Location = new System.Drawing.Point(3, 183);
            this.lblHistory.Name = "lblHistory";
            this.lblHistory.Size = new System.Drawing.Size(206, 25);
            this.lblHistory.TabIndex = 2;
            this.lblHistory.Text = "Blackboard from #today";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 211);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(829, 394);
            this.dataGridView1.TabIndex = 3;
            // 
            // BlackBoardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._tlpMain);
            this.Name = "BlackBoardControl";
            this.Size = new System.Drawing.Size(835, 609);
            this._tlpMain.ResumeLayout(false);
            this._tlpMain.PerformLayout();
            this._tlpEntryLabelAndInfoLabel.ResumeLayout(false);
            this._tlpEntryLabelAndInfoLabel.PerformLayout();
            this._tlpEntryTextBoxAndButton.ResumeLayout(false);
            this._tlpEntryTextBoxAndButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel _tlpMain;
        private System.Windows.Forms.TableLayoutPanel _tlpEntryLabelAndInfoLabel;
        private System.Windows.Forms.Label _lblEntryInfo;
        private System.Windows.Forms.TableLayoutPanel _tlpEntryTextBoxAndButton;
        private System.Windows.Forms.Button _addEditButton;
        private System.Windows.Forms.TextBox _txtNewEditEntry;
        private System.Windows.Forms.Label lblHistory;
        private System.Windows.Forms.Button _btnFilter;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
