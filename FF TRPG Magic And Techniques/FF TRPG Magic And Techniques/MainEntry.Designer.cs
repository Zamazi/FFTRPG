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
            // MainEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 261);
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
    }
}

