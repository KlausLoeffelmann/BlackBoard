
namespace BlackBoardWinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.loginViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabFrontPage = new System.Windows.Forms.TabPage();
            this.txtFrontPage = new System.Windows.Forms.TextBox();
            this.tabToday = new System.Windows.Forms.TabPage();
            this.dtpTodayEmulator = new System.Windows.Forms.DateTimePicker();
            this.txtToday = new System.Windows.Forms.TextBox();
            this.tabPrevious = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslLoginInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslLastHttpResponse = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.loginViewModelBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabFrontPage.SuspendLayout();
            this.tabToday.SuspendLayout();
            this.tabPrevious.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginViewModelBindingSource
            // 
            this.loginViewModelBindingSource.DataSource = typeof(Blackboard.WinForms.LoginViewModel);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabFrontPage);
            this.tabControl1.Controls.Add(this.tabToday);
            this.tabControl1.Controls.Add(this.tabPrevious);
            this.tabControl1.Location = new System.Drawing.Point(18, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1049, 599);
            this.tabControl1.TabIndex = 4;
            // 
            // tabFrontPage
            // 
            this.tabFrontPage.Controls.Add(this.txtFrontPage);
            this.tabFrontPage.Location = new System.Drawing.Point(4, 29);
            this.tabFrontPage.Name = "tabFrontPage";
            this.tabFrontPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabFrontPage.Size = new System.Drawing.Size(1041, 566);
            this.tabFrontPage.TabIndex = 0;
            this.tabFrontPage.Text = "Front Page";
            this.tabFrontPage.UseVisualStyleBackColor = true;
            // 
            // txtFrontPage
            // 
            this.txtFrontPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFrontPage.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtFrontPage.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginViewModelBindingSource, "FrontPageContent", true));
            this.txtFrontPage.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFrontPage.ForeColor = System.Drawing.SystemColors.Window;
            this.txtFrontPage.Location = new System.Drawing.Point(16, 12);
            this.txtFrontPage.Multiline = true;
            this.txtFrontPage.Name = "txtFrontPage";
            this.txtFrontPage.Size = new System.Drawing.Size(1014, 541);
            this.txtFrontPage.TabIndex = 3;
            // 
            // tabToday
            // 
            this.tabToday.Controls.Add(this.dtpTodayEmulator);
            this.tabToday.Controls.Add(this.txtToday);
            this.tabToday.Location = new System.Drawing.Point(4, 29);
            this.tabToday.Name = "tabToday";
            this.tabToday.Padding = new System.Windows.Forms.Padding(3);
            this.tabToday.Size = new System.Drawing.Size(839, 435);
            this.tabToday.TabIndex = 1;
            this.tabToday.Text = "Today";
            this.tabToday.UseVisualStyleBackColor = true;
            // 
            // dtpTodayEmulator
            // 
            this.dtpTodayEmulator.Location = new System.Drawing.Point(17, 12);
            this.dtpTodayEmulator.Name = "dtpTodayEmulator";
            this.dtpTodayEmulator.Size = new System.Drawing.Size(349, 27);
            this.dtpTodayEmulator.TabIndex = 4;
            // 
            // txtToday
            // 
            this.txtToday.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtToday.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtToday.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtToday.ForeColor = System.Drawing.SystemColors.Window;
            this.txtToday.Location = new System.Drawing.Point(17, -428);
            this.txtToday.Multiline = true;
            this.txtToday.Name = "txtToday";
            this.txtToday.Size = new System.Drawing.Size(803, 848);
            this.txtToday.TabIndex = 3;
            // 
            // tabPrevious
            // 
            this.tabPrevious.Controls.Add(this.textBox1);
            this.tabPrevious.Controls.Add(this.treeView1);
            this.tabPrevious.Location = new System.Drawing.Point(4, 29);
            this.tabPrevious.Name = "tabPrevious";
            this.tabPrevious.Size = new System.Drawing.Size(839, 435);
            this.tabPrevious.TabIndex = 2;
            this.tabPrevious.Text = "Previous Dates";
            this.tabPrevious.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBox1.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(226, -466);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(595, 886);
            this.textBox1.TabIndex = 4;
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeView1.Location = new System.Drawing.Point(21, -466);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(181, 886);
            this.treeView1.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(906, 626);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(157, 43);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslLoginInfo,
            this.tslLastHttpResponse});
            this.statusStrip1.Location = new System.Drawing.Point(0, 558);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(933, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslLoginInfo
            // 
            this.tslLoginInfo.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.tslLoginInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tslLoginInfo.Name = "tslLoginInfo";
            this.tslLoginInfo.Size = new System.Drawing.Size(459, 16);
            this.tslLoginInfo.Spring = true;
            // 
            // tslLastHttpResponse
            // 
            this.tslLastHttpResponse.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.tslLastHttpResponse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tslLastHttpResponse.Name = "tslLastHttpResponse";
            this.tslLastHttpResponse.Size = new System.Drawing.Size(459, 16);
            this.tslLastHttpResponse.Spring = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 710);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Blackboard.NET";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loginViewModelBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabFrontPage.ResumeLayout(false);
            this.tabFrontPage.PerformLayout();
            this.tabToday.ResumeLayout(false);
            this.tabToday.PerformLayout();
            this.tabPrevious.ResumeLayout(false);
            this.tabPrevious.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabFrontPage;
        private System.Windows.Forms.TextBox txtFrontPage;
        private System.Windows.Forms.TabPage tabToday;
        private System.Windows.Forms.TabPage tabPrevious;
        private System.Windows.Forms.DateTimePicker dtpTodayEmulator;
        private System.Windows.Forms.TextBox txtToday;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource loginViewModelBindingSource;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslLoginInfo;
        private System.Windows.Forms.ToolStripStatusLabel tslLastHttpResponse;
    }
}

