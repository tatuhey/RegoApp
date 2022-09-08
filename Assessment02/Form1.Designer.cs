namespace Assessment02
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ststripRego = new System.Windows.Forms.ToolStripStatusLabel();
            this.lstboxRego = new System.Windows.Forms.ListBox();
            this.btnEnterRego = new System.Windows.Forms.Button();
            this.btnSaveRego = new System.Windows.Forms.Button();
            this.btnOpenRego = new System.Windows.Forms.Button();
            this.btnExitRego = new System.Windows.Forms.Button();
            this.btnEditRego = new System.Windows.Forms.Button();
            this.btnLinearSearch = new System.Windows.Forms.Button();
            this.btnBinarySearch = new System.Windows.Forms.Button();
            this.btnTagRego = new System.Windows.Forms.Button();
            this.btnResetRego = new System.Windows.Forms.Button();
            this.tbxInputRego = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ststripRego});
            this.statusStrip1.Location = new System.Drawing.Point(0, 471);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(688, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ststripRego
            // 
            this.ststripRego.Name = "ststripRego";
            this.ststripRego.Size = new System.Drawing.Size(66, 17);
            this.ststripRego.Text = "ststripRego";
            // 
            // lstboxRego
            // 
            this.lstboxRego.FormattingEnabled = true;
            this.lstboxRego.ItemHeight = 15;
            this.lstboxRego.Location = new System.Drawing.Point(50, 54);
            this.lstboxRego.Name = "lstboxRego";
            this.lstboxRego.Size = new System.Drawing.Size(187, 364);
            this.lstboxRego.TabIndex = 1;
            this.lstboxRego.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstboxRego_MouseClick);
            // 
            // btnEnterRego
            // 
            this.btnEnterRego.Location = new System.Drawing.Point(298, 175);
            this.btnEnterRego.Name = "btnEnterRego";
            this.btnEnterRego.Size = new System.Drawing.Size(88, 41);
            this.btnEnterRego.TabIndex = 2;
            this.btnEnterRego.Text = "Enter";
            this.btnEnterRego.UseVisualStyleBackColor = true;
            this.btnEnterRego.Click += new System.EventHandler(this.btnEnterRego_Click);
            // 
            // btnSaveRego
            // 
            this.btnSaveRego.Location = new System.Drawing.Point(392, 54);
            this.btnSaveRego.Name = "btnSaveRego";
            this.btnSaveRego.Size = new System.Drawing.Size(88, 41);
            this.btnSaveRego.TabIndex = 3;
            this.btnSaveRego.Text = "Save";
            this.btnSaveRego.UseVisualStyleBackColor = true;
            // 
            // btnOpenRego
            // 
            this.btnOpenRego.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnOpenRego.Location = new System.Drawing.Point(298, 54);
            this.btnOpenRego.Name = "btnOpenRego";
            this.btnOpenRego.Size = new System.Drawing.Size(88, 41);
            this.btnOpenRego.TabIndex = 4;
            this.btnOpenRego.Text = "Open";
            this.btnOpenRego.UseVisualStyleBackColor = false;
            this.btnOpenRego.Click += new System.EventHandler(this.btnOpenRego_Click);
            // 
            // btnExitRego
            // 
            this.btnExitRego.Location = new System.Drawing.Point(486, 175);
            this.btnExitRego.Name = "btnExitRego";
            this.btnExitRego.Size = new System.Drawing.Size(88, 41);
            this.btnExitRego.TabIndex = 5;
            this.btnExitRego.Text = "Exit";
            this.btnExitRego.UseVisualStyleBackColor = true;
            this.btnExitRego.Click += new System.EventHandler(this.btnExitRego_Click);
            // 
            // btnEditRego
            // 
            this.btnEditRego.Location = new System.Drawing.Point(392, 175);
            this.btnEditRego.Name = "btnEditRego";
            this.btnEditRego.Size = new System.Drawing.Size(88, 41);
            this.btnEditRego.TabIndex = 6;
            this.btnEditRego.Text = "Edit";
            this.btnEditRego.UseVisualStyleBackColor = true;
            this.btnEditRego.Click += new System.EventHandler(this.btnEditRego_Click);
            // 
            // btnLinearSearch
            // 
            this.btnLinearSearch.Location = new System.Drawing.Point(298, 243);
            this.btnLinearSearch.Name = "btnLinearSearch";
            this.btnLinearSearch.Size = new System.Drawing.Size(88, 41);
            this.btnLinearSearch.TabIndex = 7;
            this.btnLinearSearch.Text = "Linear Search";
            this.btnLinearSearch.UseVisualStyleBackColor = true;
            this.btnLinearSearch.Click += new System.EventHandler(this.btnLinearSearch_Click);
            // 
            // btnBinarySearch
            // 
            this.btnBinarySearch.Location = new System.Drawing.Point(486, 243);
            this.btnBinarySearch.Name = "btnBinarySearch";
            this.btnBinarySearch.Size = new System.Drawing.Size(88, 41);
            this.btnBinarySearch.TabIndex = 8;
            this.btnBinarySearch.Text = "Binary Search";
            this.btnBinarySearch.UseVisualStyleBackColor = true;
            this.btnBinarySearch.Click += new System.EventHandler(this.btnBinarySearch_Click);
            // 
            // btnTagRego
            // 
            this.btnTagRego.Location = new System.Drawing.Point(580, 125);
            this.btnTagRego.Name = "btnTagRego";
            this.btnTagRego.Size = new System.Drawing.Size(75, 23);
            this.btnTagRego.TabIndex = 9;
            this.btnTagRego.Text = "Tag";
            this.btnTagRego.UseVisualStyleBackColor = true;
            // 
            // btnResetRego
            // 
            this.btnResetRego.Location = new System.Drawing.Point(486, 54);
            this.btnResetRego.Name = "btnResetRego";
            this.btnResetRego.Size = new System.Drawing.Size(88, 41);
            this.btnResetRego.TabIndex = 10;
            this.btnResetRego.Text = "Reset";
            this.btnResetRego.UseVisualStyleBackColor = true;
            this.btnResetRego.Click += new System.EventHandler(this.btnResetRego_Click);
            // 
            // tbxInputRego
            // 
            this.tbxInputRego.Location = new System.Drawing.Point(298, 125);
            this.tbxInputRego.Name = "tbxInputRego";
            this.tbxInputRego.Size = new System.Drawing.Size(276, 23);
            this.tbxInputRego.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 493);
            this.Controls.Add(this.tbxInputRego);
            this.Controls.Add(this.btnResetRego);
            this.Controls.Add(this.btnTagRego);
            this.Controls.Add(this.btnBinarySearch);
            this.Controls.Add(this.btnLinearSearch);
            this.Controls.Add(this.btnEditRego);
            this.Controls.Add(this.btnExitRego);
            this.Controls.Add(this.btnOpenRego);
            this.Controls.Add(this.btnSaveRego);
            this.Controls.Add(this.btnEnterRego);
            this.Controls.Add(this.lstboxRego);
            this.Controls.Add(this.statusStrip1);
            this.Name = "Form1";
            this.Text = "Assessment 02";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel ststripRego;
        private ListBox lstboxRego;
        private Button btnEnterRego;
        private Button btnSaveRego;
        private Button btnOpenRego;
        private Button btnExitRego;
        private Button btnEditRego;
        private Button btnLinearSearch;
        private Button btnBinarySearch;
        private Button btnTagRego;
        private Button btnResetRego;
        private TextBox tbxInputRego;
    }
}