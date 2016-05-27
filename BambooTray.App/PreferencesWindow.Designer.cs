namespace BambooTray.App
{
    partial class PreferencesWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PreferencesWindow));
            this.preferencesTabControl = new System.Windows.Forms.TabControl();
            this.buildsTabPage = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buildPlansListView = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.serversListBox = new System.Windows.Forms.ListBox();
            this.serverViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.addServerButton = new System.Windows.Forms.Button();
            this.configureServerButton = new System.Windows.Forms.Button();
            this.removeServerButton = new System.Windows.Forms.Button();
            this.generalTabPage = new System.Windows.Forms.TabPage();
            this.groupSpeech = new System.Windows.Forms.GroupBox();
            this.comboSpeechVoice = new System.Windows.Forms.ComboBox();
            this.checkboxEnableSpeechNotifications = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkSpeechNotifications = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBalloon = new System.Windows.Forms.GroupBox();
            this.checkboxEnableBalloonNotifications = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBalloonNotifications = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericBalloonTooltipTimeout = new System.Windows.Forms.NumericUpDown();
            this.numericPollTime = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.checkboxAnimatedBuildIcon = new System.Windows.Forms.CheckBox();
            this.preferencesTabControl.SuspendLayout();
            this.buildsTabPage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serverViewModelBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.generalTabPage.SuspendLayout();
            this.groupSpeech.SuspendLayout();
            this.groupBalloon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericBalloonTooltipTimeout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPollTime)).BeginInit();
            this.SuspendLayout();
            // 
            // preferencesTabControl
            // 
            this.preferencesTabControl.Controls.Add(this.buildsTabPage);
            this.preferencesTabControl.Controls.Add(this.generalTabPage);
            this.preferencesTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.preferencesTabControl.Location = new System.Drawing.Point(0, 0);
            this.preferencesTabControl.Name = "preferencesTabControl";
            this.preferencesTabControl.SelectedIndex = 0;
            this.preferencesTabControl.Size = new System.Drawing.Size(649, 307);
            this.preferencesTabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.preferencesTabControl.TabIndex = 0;
            // 
            // buildsTabPage
            // 
            this.buildsTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.buildsTabPage.Controls.Add(this.groupBox2);
            this.buildsTabPage.Controls.Add(this.groupBox1);
            this.buildsTabPage.Location = new System.Drawing.Point(4, 22);
            this.buildsTabPage.Name = "buildsTabPage";
            this.buildsTabPage.Padding = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.buildsTabPage.Size = new System.Drawing.Size(641, 281);
            this.buildsTabPage.TabIndex = 1;
            this.buildsTabPage.Text = "Builds";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buildPlansListView);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(269, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(369, 268);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Build Plans";
            // 
            // buildPlansListView
            // 
            this.buildPlansListView.CheckBoxes = true;
            this.buildPlansListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buildPlansListView.FullRowSelect = true;
            this.buildPlansListView.Location = new System.Drawing.Point(3, 16);
            this.buildPlansListView.Name = "buildPlansListView";
            this.buildPlansListView.Size = new System.Drawing.Size(363, 249);
            this.buildPlansListView.TabIndex = 0;
            this.buildPlansListView.UseCompatibleStateImageBehavior = false;
            this.buildPlansListView.View = System.Windows.Forms.View.List;
            this.buildPlansListView.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.BuildPlansListViewItemChecked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.serversListBox);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(3, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 268);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Build Servers";
            // 
            // serversListBox
            // 
            this.serversListBox.DataSource = this.serverViewModelBindingSource;
            this.serversListBox.DisplayMember = "Name";
            this.serversListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.serversListBox.FormattingEnabled = true;
            this.serversListBox.Location = new System.Drawing.Point(3, 16);
            this.serversListBox.Name = "serversListBox";
            this.serversListBox.Size = new System.Drawing.Size(260, 213);
            this.serversListBox.TabIndex = 6;
            this.serversListBox.ValueMember = "Address";
            // 
            // serverViewModelBindingSource
            // 
            this.serverViewModelBindingSource.DataSource = typeof(BambooTray.Domain.Settings.Server);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addServerButton);
            this.panel1.Controls.Add(this.configureServerButton);
            this.panel1.Controls.Add(this.removeServerButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 229);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 36);
            this.panel1.TabIndex = 9;
            // 
            // addServerButton
            // 
            this.addServerButton.Location = new System.Drawing.Point(10, 6);
            this.addServerButton.Name = "addServerButton";
            this.addServerButton.Size = new System.Drawing.Size(75, 23);
            this.addServerButton.TabIndex = 6;
            this.addServerButton.Text = "&Add";
            this.addServerButton.UseVisualStyleBackColor = true;
            this.addServerButton.Click += new System.EventHandler(this.AddServerButtonClick);
            // 
            // configureServerButton
            // 
            this.configureServerButton.Location = new System.Drawing.Point(172, 6);
            this.configureServerButton.Name = "configureServerButton";
            this.configureServerButton.Size = new System.Drawing.Size(75, 23);
            this.configureServerButton.TabIndex = 8;
            this.configureServerButton.Text = "&Configure";
            this.configureServerButton.UseVisualStyleBackColor = true;
            this.configureServerButton.Click += new System.EventHandler(this.ConfigureServerButtonClick);
            // 
            // removeServerButton
            // 
            this.removeServerButton.Location = new System.Drawing.Point(91, 6);
            this.removeServerButton.Name = "removeServerButton";
            this.removeServerButton.Size = new System.Drawing.Size(75, 23);
            this.removeServerButton.TabIndex = 7;
            this.removeServerButton.Text = "&Remove";
            this.removeServerButton.UseVisualStyleBackColor = true;
            this.removeServerButton.Click += new System.EventHandler(this.RemoveServerButtonClick);
            // 
            // generalTabPage
            // 
            this.generalTabPage.BackColor = System.Drawing.SystemColors.Control;
            this.generalTabPage.Controls.Add(this.checkboxAnimatedBuildIcon);
            this.generalTabPage.Controls.Add(this.groupSpeech);
            this.generalTabPage.Controls.Add(this.groupBalloon);
            this.generalTabPage.Controls.Add(this.numericPollTime);
            this.generalTabPage.Controls.Add(this.label1);
            this.generalTabPage.Location = new System.Drawing.Point(4, 22);
            this.generalTabPage.Name = "generalTabPage";
            this.generalTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.generalTabPage.Size = new System.Drawing.Size(641, 281);
            this.generalTabPage.TabIndex = 0;
            this.generalTabPage.Text = "General";
            // 
            // groupSpeech
            // 
            this.groupSpeech.Controls.Add(this.comboSpeechVoice);
            this.groupSpeech.Controls.Add(this.checkboxEnableSpeechNotifications);
            this.groupSpeech.Controls.Add(this.label4);
            this.groupSpeech.Controls.Add(this.checkSpeechNotifications);
            this.groupSpeech.Controls.Add(this.label5);
            this.groupSpeech.Location = new System.Drawing.Point(236, 55);
            this.groupSpeech.Name = "groupSpeech";
            this.groupSpeech.Size = new System.Drawing.Size(219, 133);
            this.groupSpeech.TabIndex = 10;
            this.groupSpeech.TabStop = false;
            this.groupSpeech.Text = "Speech Notifications";
            // 
            // comboSpeechVoice
            // 
            this.comboSpeechVoice.FormattingEnabled = true;
            this.comboSpeechVoice.Location = new System.Drawing.Point(80, 35);
            this.comboSpeechVoice.Name = "comboSpeechVoice";
            this.comboSpeechVoice.Size = new System.Drawing.Size(133, 21);
            this.comboSpeechVoice.TabIndex = 9;
            // 
            // checkboxEnableSpeechNotifications
            // 
            this.checkboxEnableSpeechNotifications.AutoSize = true;
            this.checkboxEnableSpeechNotifications.Location = new System.Drawing.Point(6, 19);
            this.checkboxEnableSpeechNotifications.Name = "checkboxEnableSpeechNotifications";
            this.checkboxEnableSpeechNotifications.Size = new System.Drawing.Size(59, 17);
            this.checkboxEnableSpeechNotifications.TabIndex = 2;
            this.checkboxEnableSpeechNotifications.Text = "Enable";
            this.checkboxEnableSpeechNotifications.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Notifications:";
            // 
            // checkSpeechNotifications
            // 
            this.checkSpeechNotifications.FormattingEnabled = true;
            this.checkSpeechNotifications.Location = new System.Drawing.Point(80, 63);
            this.checkSpeechNotifications.Name = "checkSpeechNotifications";
            this.checkSpeechNotifications.Size = new System.Drawing.Size(133, 64);
            this.checkSpeechNotifications.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Voice:";
            // 
            // groupBalloon
            // 
            this.groupBalloon.Controls.Add(this.checkboxEnableBalloonNotifications);
            this.groupBalloon.Controls.Add(this.label3);
            this.groupBalloon.Controls.Add(this.checkBalloonNotifications);
            this.groupBalloon.Controls.Add(this.label2);
            this.groupBalloon.Controls.Add(this.numericBalloonTooltipTimeout);
            this.groupBalloon.Location = new System.Drawing.Point(11, 55);
            this.groupBalloon.Name = "groupBalloon";
            this.groupBalloon.Size = new System.Drawing.Size(219, 133);
            this.groupBalloon.TabIndex = 9;
            this.groupBalloon.TabStop = false;
            this.groupBalloon.Text = "Balloon Notifications";
            // 
            // checkboxEnableBalloonNotifications
            // 
            this.checkboxEnableBalloonNotifications.AutoSize = true;
            this.checkboxEnableBalloonNotifications.Location = new System.Drawing.Point(6, 19);
            this.checkboxEnableBalloonNotifications.Name = "checkboxEnableBalloonNotifications";
            this.checkboxEnableBalloonNotifications.Size = new System.Drawing.Size(59, 17);
            this.checkboxEnableBalloonNotifications.TabIndex = 2;
            this.checkboxEnableBalloonNotifications.Text = "Enable";
            this.checkboxEnableBalloonNotifications.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Notifications:";
            // 
            // checkBalloonNotifications
            // 
            this.checkBalloonNotifications.FormattingEnabled = true;
            this.checkBalloonNotifications.Location = new System.Drawing.Point(80, 63);
            this.checkBalloonNotifications.Name = "checkBalloonNotifications";
            this.checkBalloonNotifications.Size = new System.Drawing.Size(133, 64);
            this.checkBalloonNotifications.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tooltip Timeout (in seconds):";
            // 
            // numericBalloonTooltipTimeout
            // 
            this.numericBalloonTooltipTimeout.Location = new System.Drawing.Point(162, 37);
            this.numericBalloonTooltipTimeout.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericBalloonTooltipTimeout.Name = "numericBalloonTooltipTimeout";
            this.numericBalloonTooltipTimeout.Size = new System.Drawing.Size(51, 20);
            this.numericBalloonTooltipTimeout.TabIndex = 6;
            // 
            // numericPollTime
            // 
            this.numericPollTime.Location = new System.Drawing.Point(127, 6);
            this.numericPollTime.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericPollTime.Name = "numericPollTime";
            this.numericPollTime.Size = new System.Drawing.Size(51, 20);
            this.numericPollTime.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Poll Time (in seconds):";
            // 
            // checkBoxAnimatedBuildIcon
            // 
            this.checkboxAnimatedBuildIcon.AutoSize = true;
            this.checkboxAnimatedBuildIcon.Location = new System.Drawing.Point(11, 32);
            this.checkboxAnimatedBuildIcon.Name = "checkBoxAnimatedBuildIcon";
            this.checkboxAnimatedBuildIcon.Size = new System.Drawing.Size(114, 17);
            this.checkboxAnimatedBuildIcon.TabIndex = 2;
            this.checkboxAnimatedBuildIcon.Text = "Animate Build Icon";
            this.checkboxAnimatedBuildIcon.UseVisualStyleBackColor = true;
            // 
            // PreferencesWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 307);
            this.Controls.Add(this.preferencesTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PreferencesWindow";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bamboo Tray Preferences";
            this.TopMost = true;
            this.preferencesTabControl.ResumeLayout(false);
            this.buildsTabPage.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.serverViewModelBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.generalTabPage.ResumeLayout(false);
            this.generalTabPage.PerformLayout();
            this.groupSpeech.ResumeLayout(false);
            this.groupSpeech.PerformLayout();
            this.groupBalloon.ResumeLayout(false);
            this.groupBalloon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericBalloonTooltipTimeout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPollTime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl preferencesTabControl;
        private System.Windows.Forms.TabPage generalTabPage;
        private System.Windows.Forms.TabPage buildsTabPage;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox serversListBox;
        private System.Windows.Forms.BindingSource serverViewModelBindingSource;
        private System.Windows.Forms.ListView buildPlansListView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addServerButton;
        private System.Windows.Forms.Button configureServerButton;
        private System.Windows.Forms.Button removeServerButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkboxEnableBalloonNotifications;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericBalloonTooltipTimeout;
        private System.Windows.Forms.NumericUpDown numericPollTime;
        private System.Windows.Forms.GroupBox groupSpeech;
        private System.Windows.Forms.CheckBox checkboxEnableSpeechNotifications;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox checkSpeechNotifications;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBalloon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox checkBalloonNotifications;
        private System.Windows.Forms.ComboBox comboSpeechVoice;
        private System.Windows.Forms.CheckBox checkboxAnimatedBuildIcon;
    }
}