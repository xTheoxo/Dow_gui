namespace Dow_gui
{
    partial class Form2
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
            label1 = new Label();
            numUpDownClients = new NumericUpDown();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            checkBoxpvp = new CheckBox();
            label4 = new Label();
            numericUpDowndistance = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numUpDownClients).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDowndistance).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 25);
            label1.Name = "label1";
            label1.Size = new Size(144, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre de joueurs :";
            label1.Click += label1_Click;
            // 
            // numUpDownClients
            // 
            numUpDownClients.Location = new Point(175, 23);
            numUpDownClients.Margin = new Padding(3, 4, 3, 4);
            numUpDownClients.Name = "numUpDownClients";
            numUpDownClients.Size = new Size(137, 27);
            numUpDownClients.TabIndex = 1;
            numUpDownClients.Value = new decimal(new int[] { 20, 0, 0, 0 });
            numUpDownClients.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 71);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 3;
            label2.Text = "Difficulté";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Paisible", "Facile", "Normal", "Difficile" });
            comboBox1.Location = new Point(174, 71);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(138, 28);
            comboBox1.TabIndex = 4;
            comboBox1.Text = "test";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 108);
            label3.Name = "label3";
            label3.Size = new Size(33, 20);
            label3.TabIndex = 5;
            label3.Text = "Pvp";
            // 
            // checkBoxpvp
            // 
            checkBoxpvp.AutoSize = true;
            checkBoxpvp.Location = new Point(175, 108);
            checkBoxpvp.Name = "checkBoxpvp";
            checkBoxpvp.Size = new Size(88, 24);
            checkBoxpvp.TabIndex = 6;
            checkBoxpvp.Text = "Activer ?";
            checkBoxpvp.UseVisualStyleBackColor = true;
            checkBoxpvp.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 149);
            label4.Name = "label4";
            label4.Size = new Size(144, 20);
            label4.TabIndex = 7;
            label4.Text = "Distance d'affichage";
            // 
            // numericUpDowndistance
            // 
            numericUpDowndistance.Location = new Point(175, 149);
            numericUpDowndistance.Name = "numericUpDowndistance";
            numericUpDowndistance.Size = new Size(150, 27);
            numericUpDowndistance.TabIndex = 8;
            numericUpDowndistance.Value = new decimal(new int[] { 12, 0, 0, 0 });
            numericUpDowndistance.ValueChanged += numericUpDown1_ValueChanged_1;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(numericUpDowndistance);
            Controls.Add(label4);
            Controls.Add(checkBoxpvp);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(numUpDownClients);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)numUpDownClients).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDowndistance).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown numUpDownClients;
        private Label label2;
        private ComboBox comboBox1;
        private Label label3;
        private CheckBox checkBoxpvp;
        private Label label4;
        private NumericUpDown numericUpDowndistance;
    }
}