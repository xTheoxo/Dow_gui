namespace Dow_gui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            label_jdk21 = new Label();
            label_bat = new Label();
            button2 = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            label1 = new Label();
            label_Dossier_serv = new Label();
            button_bat = new Button();
            label2 = new Label();
            statutjdk = new Label();
            Version = new Label();
            version_mc = new Button();
            checkedListBox1 = new CheckedListBox();
            vanillacheck = new CheckBox();
            Papercheck = new CheckBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Location = new Point(174, 25);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(116, 22);
            button1.TabIndex = 0;
            button1.Text = "code error";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label_jdk21
            // 
            label_jdk21.AutoSize = true;
            label_jdk21.BackColor = Color.Red;
            label_jdk21.Location = new Point(25, 29);
            label_jdk21.Name = "label_jdk21";
            label_jdk21.Size = new Size(50, 15);
            label_jdk21.TabIndex = 1;
            label_jdk21.Text = "  jdk 21  ";
            // 
            // label_bat
            // 
            label_bat.AutoSize = true;
            label_bat.Location = new Point(34, 66);
            label_bat.Name = "label_bat";
            label_bat.Size = new Size(36, 15);
            label_bat.TabIndex = 2;
            label_bat.Text = "  Bat  ";
            label_bat.Click += label2_Click;
            // 
            // button2
            // 
            button2.Location = new Point(174, 91);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(117, 22);
            button2.TabIndex = 3;
            button2.Text = "Choisir un dossier";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.Location = new Point(596, 180);
            label1.Name = "label1";
            label1.Size = new Size(88, 17);
            label1.TabIndex = 0;
            // 
            // label_Dossier_serv
            // 
            label_Dossier_serv.AutoSize = true;
            label_Dossier_serv.Location = new Point(11, 95);
            label_Dossier_serv.Name = "label_Dossier_serv";
            label_Dossier_serv.Size = new Size(98, 15);
            label_Dossier_serv.TabIndex = 5;
            label_Dossier_serv.Text = "  Dossier serveur  ";
            label_Dossier_serv.Click += label_Dossier_serv_Click;
            // 
            // button_bat
            // 
            button_bat.Location = new Point(174, 59);
            button_bat.Margin = new Padding(3, 2, 3, 2);
            button_bat.Name = "button_bat";
            button_bat.Size = new Size(117, 22);
            button_bat.TabIndex = 6;
            button_bat.Text = "Aucun dossier";
            button_bat.UseVisualStyleBackColor = true;
            button_bat.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(314, 98);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 7;
            label2.Click += label2_Click_1;
            // 
            // statutjdk
            // 
            statutjdk.AutoSize = true;
            statutjdk.Location = new Point(324, 25);
            statutjdk.Name = "statutjdk";
            statutjdk.Size = new Size(38, 15);
            statutjdk.TabIndex = 8;
            statutjdk.Text = "label3";
            // 
            // Version
            // 
            Version.AutoSize = true;
            Version.Location = new Point(11, 126);
            Version.Name = "Version";
            Version.Size = new Size(99, 15);
            Version.TabIndex = 9;
            Version.Text = "Version minecraft";
            Version.Click += label3_Click;
            // 
            // version_mc
            // 
            version_mc.Location = new Point(175, 122);
            version_mc.Name = "version_mc";
            version_mc.Size = new Size(116, 23);
            version_mc.TabIndex = 10;
            version_mc.Text = "Choisir sa version";
            version_mc.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Vanilla", "Paper (plugins)", "Spigot (plugins)" });
            checkedListBox1.Location = new Point(581, 167);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(120, 58);
            checkedListBox1.TabIndex = 11;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // vanillacheck
            // 
            vanillacheck.AutoSize = true;
            vanillacheck.Location = new Point(466, 24);
            vanillacheck.Name = "vanillacheck";
            vanillacheck.Size = new Size(60, 19);
            vanillacheck.TabIndex = 12;
            vanillacheck.Text = "Vanilla";
            vanillacheck.UseVisualStyleBackColor = true;
            vanillacheck.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Papercheck
            // 
            Papercheck.AutoSize = true;
            Papercheck.Location = new Point(532, 24);
            Papercheck.Name = "Papercheck";
            Papercheck.Size = new Size(56, 19);
            Papercheck.TabIndex = 13;
            Papercheck.Text = "Paper";
            Papercheck.UseVisualStyleBackColor = true;
            Papercheck.CheckedChanged += Papercheck_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(775, 336);
            Controls.Add(Papercheck);
            Controls.Add(vanillacheck);
            Controls.Add(checkedListBox1);
            Controls.Add(version_mc);
            Controls.Add(Version);
            Controls.Add(statutjdk);
            Controls.Add(label2);
            Controls.Add(button_bat);
            Controls.Add(label_Dossier_serv);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(label_bat);
            Controls.Add(label_jdk21);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Dow";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label_jdk21;
        private Label label_bat;
        private Button button2;
        private FolderBrowserDialog folderBrowserDialog1;
        private Label label1;
        private Label label_Dossier_serv;
        private Button button_bat;
        private Label label2;
        private Label statutjdk;
        private Label Version;
        private Button version_mc;
        private CheckedListBox checkedListBox1;
        private CheckBox vanillacheck;
        private CheckBox Papercheck;
    }
}
