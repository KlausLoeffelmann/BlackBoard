
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblLoginInfo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabFrontPage = new System.Windows.Forms.TabPage();
            this.txtFrontPage = new System.Windows.Forms.TextBox();
            this.tabToday = new System.Windows.Forms.TabPage();
            this.dtpTodayEmulator = new System.Windows.Forms.DateTimePicker();
            this.txtToday = new System.Windows.Forms.TextBox();
            this.tabPrevious = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.loginViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabFrontPage.SuspendLayout();
            this.tabToday.SuspendLayout();
            this.tabPrevious.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginViewModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(750, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblLoginInfo
            // 
            this.lblLoginInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLoginInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLoginInfo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loginViewModelBindingSource, "", true));
            this.lblLoginInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLoginInfo.Location = new System.Drawing.Point(18, 12);
            this.lblLoginInfo.Name = "lblLoginInfo";
            this.lblLoginInfo.Size = new System.Drawing.Size(726, 35);
            this.lblLoginInfo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Your Blackboard:";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabFrontPage);
            this.tabControl1.Controls.Add(this.tabToday);
            this.tabControl1.Controls.Add(this.tabPrevious);
            this.tabControl1.Location = new System.Drawing.Point(18, 105);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(847, 440);
            this.tabControl1.TabIndex = 4;
            // 
            // tabFrontPage
            // 
            this.tabFrontPage.Controls.Add(this.txtFrontPage);
            this.tabFrontPage.Location = new System.Drawing.Point(4, 29);
            this.tabFrontPage.Name = "tabFrontPage";
            this.tabFrontPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabFrontPage.Size = new System.Drawing.Size(839, 407);
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
            this.txtFrontPage.Size = new System.Drawing.Size(812, 382);
            this.txtFrontPage.TabIndex = 3;
            // 
            // tabToday
            // 
            this.tabToday.Controls.Add(this.dtpTodayEmulator);
            this.tabToday.Controls.Add(this.txtToday);
            this.tabToday.Location = new System.Drawing.Point(4, 29);
            this.tabToday.Name = "tabToday";
            this.tabToday.Padding = new System.Windows.Forms.Padding(3);
            this.tabToday.Size = new System.Drawing.Size(839, 407);
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
            this.txtToday.Location = new System.Drawing.Point(17, 45);
            this.txtToday.Multiline = true;
            this.txtToday.Name = "txtToday";
            this.txtToday.Size = new System.Drawing.Size(803, 347);
            this.txtToday.TabIndex = 3;
            // 
            // tabPrevious
            // 
            this.tabPrevious.Controls.Add(this.textBox1);
            this.tabPrevious.Controls.Add(this.treeView1);
            this.tabPrevious.Location = new System.Drawing.Point(4, 29);
            this.tabPrevious.Name = "tabPrevious";
            this.tabPrevious.Size = new System.Drawing.Size(839, 407);
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
            this.textBox1.Location = new System.Drawing.Point(226, 13);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(595, 379);
            this.textBox1.TabIndex = 4;
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeView1.Location = new System.Drawing.Point(21, 13);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(181, 379);
            this.treeView1.TabIndex = 0;
            // 
            // loginViewModelBindingSource
            // 
            this.loginViewModelBindingSource.DataSource = typeof(Blackboard.WinForms.LoginViewModel);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 582);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLoginInfo);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Blackboard.NET";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabFrontPage.ResumeLayout(false);
            this.tabFrontPage.PerformLayout();
            this.tabToday.ResumeLayout(false);
            this.tabToday.PerformLayout();
            this.tabPrevious.ResumeLayout(false);
            this.tabPrevious.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginViewModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblLoginInfo;
        private System.Windows.Forms.Label label1;
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
    }
}

