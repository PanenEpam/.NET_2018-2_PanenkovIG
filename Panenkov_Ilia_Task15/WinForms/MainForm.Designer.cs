namespace WinForms
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ctlTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ctlUsersGridViwe = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ctlRewardsGridView = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlExit = new System.Windows.Forms.ToolStripMenuItem();
            this.пользовательToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlAddUser = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlEditUser = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlRemoveUser = new System.Windows.Forms.ToolStripMenuItem();
            this.наградаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlAddReward = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlEditReward = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlRemoveReward = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctlUsersGridViwe)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctlRewardsGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctlTab
            // 
            this.ctlTab.Controls.Add(this.tabPage1);
            this.ctlTab.Controls.Add(this.tabPage2);
            this.ctlTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlTab.Location = new System.Drawing.Point(0, 24);
            this.ctlTab.Name = "ctlTab";
            this.ctlTab.SelectedIndex = 0;
            this.ctlTab.Size = new System.Drawing.Size(604, 335);
            this.ctlTab.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ctlUsersGridViwe);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(596, 309);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Пользователи";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ctlUsersGridViwe
            // 
            this.ctlUsersGridViwe.AllowUserToOrderColumns = true;
            this.ctlUsersGridViwe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ctlUsersGridViwe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlUsersGridViwe.Location = new System.Drawing.Point(3, 3);
            this.ctlUsersGridViwe.Name = "ctlUsersGridViwe";
            this.ctlUsersGridViwe.Size = new System.Drawing.Size(590, 303);
            this.ctlUsersGridViwe.TabIndex = 0;
            this.ctlUsersGridViwe.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ctlUsersGridViwe_ColumnHeaderMouseClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ctlRewardsGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(596, 309);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Награды";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ctlRewardsGridView
            // 
            this.ctlRewardsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ctlRewardsGridView.Cursor = System.Windows.Forms.Cursors.Default;
            this.ctlRewardsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlRewardsGridView.Location = new System.Drawing.Point(3, 3);
            this.ctlRewardsGridView.Name = "ctlRewardsGridView";
            this.ctlRewardsGridView.Size = new System.Drawing.Size(590, 303);
            this.ctlRewardsGridView.TabIndex = 0;
            this.ctlRewardsGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ctlRewardsGridView_ColumnHeaderMouseClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.пользовательToolStripMenuItem,
            this.наградаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(604, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctlExit});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // ctlExit
            // 
            this.ctlExit.Name = "ctlExit";
            this.ctlExit.Size = new System.Drawing.Size(108, 22);
            this.ctlExit.Text = "Выход";
            this.ctlExit.Click += new System.EventHandler(this.ctlExit_Click);
            // 
            // пользовательToolStripMenuItem
            // 
            this.пользовательToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctlAddUser,
            this.ctlEditUser,
            this.ctlRemoveUser});
            this.пользовательToolStripMenuItem.Name = "пользовательToolStripMenuItem";
            this.пользовательToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.пользовательToolStripMenuItem.Text = "Пользователь";
            // 
            // ctlAddUser
            // 
            this.ctlAddUser.Name = "ctlAddUser";
            this.ctlAddUser.Size = new System.Drawing.Size(131, 22);
            this.ctlAddUser.Text = "Добавить";
            this.ctlAddUser.Click += new System.EventHandler(this.ctrAddUser_Click);
            // 
            // ctlEditUser
            // 
            this.ctlEditUser.Name = "ctlEditUser";
            this.ctlEditUser.Size = new System.Drawing.Size(131, 22);
            this.ctlEditUser.Text = "Изменить ";
            this.ctlEditUser.Click += new System.EventHandler(this.ctlEditUser_Click);
            // 
            // ctlRemoveUser
            // 
            this.ctlRemoveUser.Name = "ctlRemoveUser";
            this.ctlRemoveUser.Size = new System.Drawing.Size(131, 22);
            this.ctlRemoveUser.Text = "Удалить";
            this.ctlRemoveUser.Click += new System.EventHandler(this.ctlRemoveUser_Click);
            // 
            // наградаToolStripMenuItem
            // 
            this.наградаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctlAddReward,
            this.ctlEditReward,
            this.ctlRemoveReward});
            this.наградаToolStripMenuItem.Name = "наградаToolStripMenuItem";
            this.наградаToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.наградаToolStripMenuItem.Text = "Награда";
            // 
            // ctlAddReward
            // 
            this.ctlAddReward.Name = "ctlAddReward";
            this.ctlAddReward.Size = new System.Drawing.Size(131, 22);
            this.ctlAddReward.Text = "Добавить";
            this.ctlAddReward.Click += new System.EventHandler(this.ctlAddReward_Click);
            // 
            // ctlEditReward
            // 
            this.ctlEditReward.Name = "ctlEditReward";
            this.ctlEditReward.Size = new System.Drawing.Size(131, 22);
            this.ctlEditReward.Text = "Изменить ";
            this.ctlEditReward.Click += new System.EventHandler(this.ctlEditReward_Click);
            // 
            // ctlRemoveReward
            // 
            this.ctlRemoveReward.Name = "ctlRemoveReward";
            this.ctlRemoveReward.Size = new System.Drawing.Size(131, 22);
            this.ctlRemoveReward.Text = "Удалить";
            this.ctlRemoveReward.Click += new System.EventHandler(this.ctlRemoveReward_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 359);
            this.Controls.Add(this.ctlTab);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная страница";
            this.ctlTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ctlUsersGridViwe)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ctlRewardsGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TabControl ctlTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridView ctlRewardsGridView;
        private System.Windows.Forms.DataGridView ctlUsersGridViwe;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ctlExit;
        private System.Windows.Forms.ToolStripMenuItem пользовательToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ctlAddUser;
        private System.Windows.Forms.ToolStripMenuItem ctlEditUser;
        private System.Windows.Forms.ToolStripMenuItem ctlRemoveUser;
        private System.Windows.Forms.ToolStripMenuItem наградаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ctlAddReward;
        private System.Windows.Forms.ToolStripMenuItem ctlEditReward;
        private System.Windows.Forms.ToolStripMenuItem ctlRemoveReward;
    }
}

