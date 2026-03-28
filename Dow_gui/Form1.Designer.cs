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
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Location = new Point(219, 51);
            button1.Name = "button1";
            button1.Size = new Size(86, 29);
            button1.TabIndex = 0;
            button1.Text = "code error";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label_jdk21
            // 
            label_jdk21.AutoSize = true;
            label_jdk21.BackColor = Color.Red;
            label_jdk21.Location = new Point(43, 55);
            label_jdk21.Name = "label_jdk21";
            label_jdk21.Size = new Size(65, 20);
            label_jdk21.TabIndex = 1;
            label_jdk21.Text = "  jdk 21  ";
            // 
            // label_bat
            // 
            label_bat.AutoSize = true;
            label_bat.Location = new Point(49, 106);
            label_bat.Name = "label_bat";
            label_bat.Size = new Size(47, 20);
            label_bat.TabIndex = 2;
            label_bat.Text = "  Bat  ";
            label_bat.Click += label2_Click;
            // 
            // button2
            // 
            button2.Location = new Point(203, 159);
            button2.Name = "button2";
            button2.Size = new Size(134, 29);
            button2.TabIndex = 3;
            button2.Text = "Choisir un dossier";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.Location = new Point(43, 1);
            label1.Name = "label1";
            label1.Size = new Size(101, 23);
            label1.TabIndex = 0;
            // 
            // label_Dossier_serv
            // 
            label_Dossier_serv.AutoSize = true;
            label_Dossier_serv.Location = new Point(17, 164);
            label_Dossier_serv.Name = "label_Dossier_serv";
            label_Dossier_serv.Size = new Size(125, 20);
            label_Dossier_serv.TabIndex = 5;
            label_Dossier_serv.Text = "  Dossier serveur  ";
            label_Dossier_serv.Click += label_Dossier_serv_Click;
            // 
            // button_bat
            // 
            button_bat.Location = new Point(209, 105);
            button_bat.Name = "button_bat";
            button_bat.Size = new Size(118, 29);
            button_bat.TabIndex = 6;
            button_bat.Text = "Aucun dossier";
            button_bat.UseVisualStyleBackColor = true;
            button_bat.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(363, 168);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 7;
            label2.Click += label2_Click_1;
            // 
            // statutjdk
            // 
            statutjdk.AutoSize = true;
            statutjdk.Location = new Point(345, 55);
            statutjdk.Name = "statutjdk";
            statutjdk.Size = new Size(50, 20);
            statutjdk.TabIndex = 8;
            statutjdk.Text = "label3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(473, 255);
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
    }
}
