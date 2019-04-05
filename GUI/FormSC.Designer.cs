namespace GUI
{
    partial class FormSC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSC));
            this.rtbShow = new System.Windows.Forms.RichTextBox();
            this.tbxInput = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.btnHvi = new System.Windows.Forms.Button();
            this.btnDchuyen = new System.Windows.Forms.Button();
            this.btnXuat = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tbxOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGiaiHV = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnGiaiDc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbShow
            // 
            this.rtbShow.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.rtbShow.Enabled = false;
            this.rtbShow.Location = new System.Drawing.Point(9, 106);
            this.rtbShow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtbShow.Name = "rtbShow";
            this.rtbShow.Size = new System.Drawing.Size(429, 205);
            this.rtbShow.TabIndex = 0;
            this.rtbShow.Text = "";
            // 
            // tbxInput
            // 
            this.tbxInput.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbxInput.Location = new System.Drawing.Point(106, 26);
            this.tbxInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxInput.Name = "tbxInput";
            this.tbxInput.Size = new System.Drawing.Size(107, 26);
            this.tbxInput.TabIndex = 1;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.SystemColors.Window;
            this.labelName.Location = new System.Drawing.Point(13, 32);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(68, 20);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Tên file";
            // 
            // btnHvi
            // 
            this.btnHvi.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnHvi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHvi.BackgroundImage")));
            this.btnHvi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHvi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHvi.Location = new System.Drawing.Point(220, 63);
            this.btnHvi.Name = "btnHvi";
            this.btnHvi.Size = new System.Drawing.Size(129, 35);
            this.btnHvi.TabIndex = 3;
            this.btnHvi.Text = "Hoán vị";
            this.btnHvi.UseVisualStyleBackColor = false;
            this.btnHvi.Click += new System.EventHandler(this.btnHvi_Click);
            // 
            // btnDchuyen
            // 
            this.btnDchuyen.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnDchuyen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDchuyen.BackgroundImage")));
            this.btnDchuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDchuyen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDchuyen.Location = new System.Drawing.Point(220, 22);
            this.btnDchuyen.Name = "btnDchuyen";
            this.btnDchuyen.Size = new System.Drawing.Size(129, 35);
            this.btnDchuyen.TabIndex = 4;
            this.btnDchuyen.Text = "Dịch chuyển";
            this.btnDchuyen.UseVisualStyleBackColor = false;
            this.btnDchuyen.Click += new System.EventHandler(this.btnDchuyen_Click);
            // 
            // btnXuat
            // 
            this.btnXuat.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnXuat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXuat.BackgroundImage")));
            this.btnXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnXuat.Location = new System.Drawing.Point(132, 355);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(184, 35);
            this.btnXuat.TabIndex = 5;
            this.btnXuat.Text = "XUẤT FILE";
            this.btnXuat.UseVisualStyleBackColor = false;
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(9, 321);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 69);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "T H O Á T";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tbxOutput
            // 
            this.tbxOutput.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbxOutput.Location = new System.Drawing.Point(209, 321);
            this.tbxOutput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxOutput.Name = "tbxOutput";
            this.tbxOutput.Size = new System.Drawing.Size(107, 26);
            this.tbxOutput.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(128, 327);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Tên file ";
            // 
            // tbxKey
            // 
            this.tbxKey.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbxKey.Location = new System.Drawing.Point(106, 67);
            this.tbxKey.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbxKey.Name = "tbxKey";
            this.tbxKey.Size = new System.Drawing.Size(107, 26);
            this.tbxKey.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(13, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên khóa";
            // 
            // btnGiaiHV
            // 
            this.btnGiaiHV.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnGiaiHV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGiaiHV.BackgroundImage")));
            this.btnGiaiHV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiaiHV.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGiaiHV.Location = new System.Drawing.Point(355, 63);
            this.btnGiaiHV.Name = "btnGiaiHV";
            this.btnGiaiHV.Size = new System.Drawing.Size(83, 35);
            this.btnGiaiHV.TabIndex = 11;
            this.btnGiaiHV.Text = "Giải HV";
            this.btnGiaiHV.UseVisualStyleBackColor = false;
            this.btnGiaiHV.Click += new System.EventHandler(this.btnGiaiHV_Click);
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnView.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnView.BackgroundImage")));
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnView.Location = new System.Drawing.Point(334, 319);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(104, 69);
            this.btnView.TabIndex = 13;
            this.btnView.Text = "XEM FILE";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnGiaiDc
            // 
            this.btnGiaiDc.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnGiaiDc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGiaiDc.BackgroundImage")));
            this.btnGiaiDc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiaiDc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGiaiDc.Location = new System.Drawing.Point(355, 22);
            this.btnGiaiDc.Name = "btnGiaiDc";
            this.btnGiaiDc.Size = new System.Drawing.Size(83, 35);
            this.btnGiaiDc.TabIndex = 14;
            this.btnGiaiDc.Text = "Giải DC";
            this.btnGiaiDc.UseVisualStyleBackColor = false;
            this.btnGiaiDc.Click += new System.EventHandler(this.btnGiaiDc_Click);
            // 
            // FormSC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.BackgroundImage = global::GUI.Properties.Resources.artist_waves_colorful_129158_1366x768;
            this.ClientSize = new System.Drawing.Size(451, 394);
            this.Controls.Add(this.btnGiaiDc);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnGiaiHV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxOutput);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.btnDchuyen);
            this.Controls.Add(this.btnHvi);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.tbxInput);
            this.Controls.Add(this.rtbShow);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormSC";
            this.Text = "SC_Thuattoan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbShow;
        private System.Windows.Forms.TextBox tbxInput;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button btnHvi;
        private System.Windows.Forms.Button btnDchuyen;
        private System.Windows.Forms.Button btnXuat;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox tbxOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGiaiHV;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnGiaiDc;
    }
}