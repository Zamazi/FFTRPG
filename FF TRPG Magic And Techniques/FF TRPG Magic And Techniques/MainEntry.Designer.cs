namespace FF_TRPG_Magic_And_Techniques
{
    partial class MainEntry
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.CostLabel = new System.Windows.Forms.Label();
            this.PotencyLabel = new System.Windows.Forms.Label();
            this.AccuracyLabel = new System.Windows.Forms.Label();
            this.Nametextbox = new System.Windows.Forms.TextBox();
            this.CostnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.PotencynumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.AccuracynumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.OutputBox = new System.Windows.Forms.RichTextBox();
            this.PrintSpell = new System.Windows.Forms.Button();
            this.DescriptionrichTextBox = new System.Windows.Forms.RichTextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.SkillEffectTypecomboBox = new System.Windows.Forms.ComboBox();
            this.EffectTypeDropdownlabel = new System.Windows.Forms.Label();
            this.Elementlabel = new System.Windows.Forms.Label();
            this.MagicElementcombobox = new System.Windows.Forms.ComboBox();
            this.MagicSchoollabel = new System.Windows.Forms.Label();
            this.MagicSchoolcombobox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.CostnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PotencynumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccuracynumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(24, 9);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(49, 17);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name:";
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostLabel.Location = new System.Drawing.Point(33, 35);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(40, 17);
            this.CostLabel.TabIndex = 1;
            this.CostLabel.Text = "Cost:";
            // 
            // PotencyLabel
            // 
            this.PotencyLabel.AutoSize = true;
            this.PotencyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PotencyLabel.Location = new System.Drawing.Point(10, 61);
            this.PotencyLabel.Name = "PotencyLabel";
            this.PotencyLabel.Size = new System.Drawing.Size(63, 17);
            this.PotencyLabel.TabIndex = 2;
            this.PotencyLabel.Text = "Potency:";
            // 
            // AccuracyLabel
            // 
            this.AccuracyLabel.AutoSize = true;
            this.AccuracyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccuracyLabel.Location = new System.Drawing.Point(3, 84);
            this.AccuracyLabel.Name = "AccuracyLabel";
            this.AccuracyLabel.Size = new System.Drawing.Size(70, 17);
            this.AccuracyLabel.TabIndex = 3;
            this.AccuracyLabel.Text = "Accuracy:";
            // 
            // Nametextbox
            // 
            this.Nametextbox.Location = new System.Drawing.Point(79, 8);
            this.Nametextbox.Name = "Nametextbox";
            this.Nametextbox.Size = new System.Drawing.Size(100, 20);
            this.Nametextbox.TabIndex = 4;
            // 
            // CostnumericUpDown
            // 
            this.CostnumericUpDown.Location = new System.Drawing.Point(79, 32);
            this.CostnumericUpDown.Name = "CostnumericUpDown";
            this.CostnumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.CostnumericUpDown.TabIndex = 5;
            // 
            // PotencynumericUpDown
            // 
            this.PotencynumericUpDown.Location = new System.Drawing.Point(79, 58);
            this.PotencynumericUpDown.Name = "PotencynumericUpDown";
            this.PotencynumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.PotencynumericUpDown.TabIndex = 6;
            // 
            // AccuracynumericUpDown
            // 
            this.AccuracynumericUpDown.Location = new System.Drawing.Point(79, 84);
            this.AccuracynumericUpDown.Name = "AccuracynumericUpDown";
            this.AccuracynumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.AccuracynumericUpDown.TabIndex = 7;
            // 
            // OutputBox
            // 
            this.OutputBox.Location = new System.Drawing.Point(289, 8);
            this.OutputBox.Name = "OutputBox";
            this.OutputBox.Size = new System.Drawing.Size(265, 143);
            this.OutputBox.TabIndex = 8;
            this.OutputBox.Text = "";
            // 
            // PrintSpell
            // 
            this.PrintSpell.Location = new System.Drawing.Point(199, 84);
            this.PrintSpell.Name = "PrintSpell";
            this.PrintSpell.Size = new System.Drawing.Size(75, 23);
            this.PrintSpell.TabIndex = 9;
            this.PrintSpell.Text = "Print Spell";
            this.PrintSpell.UseVisualStyleBackColor = true;
            this.PrintSpell.Click += new System.EventHandler(this.PrintSpell_Click);
            // 
            // DescriptionrichTextBox
            // 
            this.DescriptionrichTextBox.Location = new System.Drawing.Point(79, 223);
            this.DescriptionrichTextBox.Name = "DescriptionrichTextBox";
            this.DescriptionrichTextBox.Size = new System.Drawing.Size(195, 68);
            this.DescriptionrichTextBox.TabIndex = 10;
            this.DescriptionrichTextBox.Text = "";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionLabel.Location = new System.Drawing.Point(76, 203);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(83, 17);
            this.DescriptionLabel.TabIndex = 11;
            this.DescriptionLabel.Text = "Description:";
            // 
            // SkillEffectTypecomboBox
            // 
            this.SkillEffectTypecomboBox.FormattingEnabled = true;
            this.SkillEffectTypecomboBox.Location = new System.Drawing.Point(79, 111);
            this.SkillEffectTypecomboBox.Name = "SkillEffectTypecomboBox";
            this.SkillEffectTypecomboBox.Size = new System.Drawing.Size(100, 21);
            this.SkillEffectTypecomboBox.TabIndex = 12;
            // 
            // EffectTypeDropdownlabel
            // 
            this.EffectTypeDropdownlabel.AutoSize = true;
            this.EffectTypeDropdownlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EffectTypeDropdownlabel.Location = new System.Drawing.Point(24, 112);
            this.EffectTypeDropdownlabel.Name = "EffectTypeDropdownlabel";
            this.EffectTypeDropdownlabel.Size = new System.Drawing.Size(48, 17);
            this.EffectTypeDropdownlabel.TabIndex = 13;
            this.EffectTypeDropdownlabel.Text = "Effect:";
            // 
            // Elementlabel
            // 
            this.Elementlabel.AutoSize = true;
            this.Elementlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Elementlabel.Location = new System.Drawing.Point(12, 165);
            this.Elementlabel.Name = "Elementlabel";
            this.Elementlabel.Size = new System.Drawing.Size(63, 17);
            this.Elementlabel.TabIndex = 15;
            this.Elementlabel.Text = "Element:";
            // 
            // MagicElementcombobox
            // 
            this.MagicElementcombobox.FormattingEnabled = true;
            this.MagicElementcombobox.Location = new System.Drawing.Point(79, 165);
            this.MagicElementcombobox.Name = "MagicElementcombobox";
            this.MagicElementcombobox.Size = new System.Drawing.Size(100, 21);
            this.MagicElementcombobox.TabIndex = 14;
            // 
            // MagicSchoollabel
            // 
            this.MagicSchoollabel.AutoSize = true;
            this.MagicSchoollabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MagicSchoollabel.Location = new System.Drawing.Point(18, 139);
            this.MagicSchoollabel.Name = "MagicSchoollabel";
            this.MagicSchoollabel.Size = new System.Drawing.Size(55, 17);
            this.MagicSchoollabel.TabIndex = 17;
            this.MagicSchoollabel.Text = "School:";
            // 
            // MagicSchoolcombobox
            // 
            this.MagicSchoolcombobox.FormattingEnabled = true;
            this.MagicSchoolcombobox.Location = new System.Drawing.Point(79, 138);
            this.MagicSchoolcombobox.Name = "MagicSchoolcombobox";
            this.MagicSchoolcombobox.Size = new System.Drawing.Size(100, 21);
            this.MagicSchoolcombobox.TabIndex = 16;
            // 
            // MainEntry
            // 
            this.AcceptButton = this.PrintSpell;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 321);
            this.Controls.Add(this.MagicSchoollabel);
            this.Controls.Add(this.MagicSchoolcombobox);
            this.Controls.Add(this.Elementlabel);
            this.Controls.Add(this.MagicElementcombobox);
            this.Controls.Add(this.EffectTypeDropdownlabel);
            this.Controls.Add(this.SkillEffectTypecomboBox);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.DescriptionrichTextBox);
            this.Controls.Add(this.PrintSpell);
            this.Controls.Add(this.OutputBox);
            this.Controls.Add(this.AccuracynumericUpDown);
            this.Controls.Add(this.PotencynumericUpDown);
            this.Controls.Add(this.CostnumericUpDown);
            this.Controls.Add(this.Nametextbox);
            this.Controls.Add(this.AccuracyLabel);
            this.Controls.Add(this.PotencyLabel);
            this.Controls.Add(this.CostLabel);
            this.Controls.Add(this.NameLabel);
            this.Name = "MainEntry";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.CostnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PotencynumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccuracynumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Label PotencyLabel;
        private System.Windows.Forms.Label AccuracyLabel;
        private System.Windows.Forms.TextBox Nametextbox;
        private System.Windows.Forms.NumericUpDown CostnumericUpDown;
        private System.Windows.Forms.NumericUpDown PotencynumericUpDown;
        private System.Windows.Forms.NumericUpDown AccuracynumericUpDown;
        private System.Windows.Forms.RichTextBox OutputBox;
        private System.Windows.Forms.Button PrintSpell;
        private System.Windows.Forms.RichTextBox DescriptionrichTextBox;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.ComboBox SkillEffectTypecomboBox;
        private System.Windows.Forms.Label EffectTypeDropdownlabel;
        private System.Windows.Forms.Label Elementlabel;
        private System.Windows.Forms.ComboBox MagicElementcombobox;
        private System.Windows.Forms.Label MagicSchoollabel;
        private System.Windows.Forms.ComboBox MagicSchoolcombobox;
    }
}

