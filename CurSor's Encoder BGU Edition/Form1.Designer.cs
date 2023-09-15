namespace CurSor_s_Encoder_BGU_Edition
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.tbxBeginText = new System.Windows.Forms.TextBox();
            this.cbxEncType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblKey = new System.Windows.Forms.Label();
            this.tbxKey = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTextEnd = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(14, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "MUDUTU:";
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenerate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnGenerate.Location = new System.Drawing.Point(729, 171);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(159, 29);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "ERESU";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // tbxBeginText
            // 
            this.tbxBeginText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxBeginText.Location = new System.Drawing.Point(16, 35);
            this.tbxBeginText.Multiline = true;
            this.tbxBeginText.Name = "tbxBeginText";
            this.tbxBeginText.Size = new System.Drawing.Size(870, 129);
            this.tbxBeginText.TabIndex = 2;
            // 
            // cbxEncType
            // 
            this.cbxEncType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEncType.FormattingEnabled = true;
            this.cbxEncType.Items.AddRange(new object[] {
            "Шифр Цезаря",
            "Лозунговый шифр",
            "Полибианский квадрат",
            "Шифр Трисемуса"});
            this.cbxEncType.Location = new System.Drawing.Point(123, 172);
            this.cbxEncType.Name = "cbxEncType";
            this.cbxEncType.Size = new System.Drawing.Size(314, 28);
            this.cbxEncType.TabIndex = 4;
            this.cbxEncType.TextChanged += new System.EventHandler(this.cbxEncType_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(14, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "KUNUKKUM:";
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.ForeColor = System.Drawing.SystemColors.Control;
            this.lblKey.Location = new System.Drawing.Point(443, 175);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(45, 20);
            this.lblKey.TabIndex = 7;
            this.lblKey.Text = "ATU:";
            this.lblKey.Visible = false;
            // 
            // tbxKey
            // 
            this.tbxKey.Location = new System.Drawing.Point(494, 172);
            this.tbxKey.Name = "tbxKey";
            this.tbxKey.Size = new System.Drawing.Size(229, 26);
            this.tbxKey.TabIndex = 8;
            this.tbxKey.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CurSor_s_Encoder_BGU_Edition.Properties.Resources._2a7627f46c70237eebc0de3278956c8d;
            this.pictureBox1.Location = new System.Drawing.Point(894, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(324, 325);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // lblTextEnd
            // 
            this.lblTextEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTextEnd.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTextEnd.Location = new System.Drawing.Point(14, 203);
            this.lblTextEnd.Name = "lblTextEnd";
            this.lblTextEnd.Size = new System.Drawing.Size(873, 157);
            this.lblTextEnd.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1230, 385);
            this.Controls.Add(this.lblTextEnd);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbxKey);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxEncType);
            this.Controls.Add(this.tbxBeginText);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CurSor\'s Encoder";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox tbxBeginText;
        private System.Windows.Forms.ComboBox cbxEncType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.TextBox tbxKey;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTextEnd;
    }
}

