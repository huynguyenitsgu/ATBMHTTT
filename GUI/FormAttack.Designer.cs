namespace GUI
{
    partial class FormAttack
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAttack));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnTke = new System.Windows.Forms.Button();
            this.btnAttack = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.txtTenfile = new System.Windows.Forms.TextBox();
            this.rtbShow = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(13, 263);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(589, 35);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "T H O Á T";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnTke
            // 
            this.btnTke.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnTke.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTke.BackgroundImage")));
            this.btnTke.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTke.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTke.Location = new System.Drawing.Point(384, 10);
            this.btnTke.Name = "btnTke";
            this.btnTke.Size = new System.Drawing.Size(129, 35);
            this.btnTke.TabIndex = 11;
            this.btnTke.Text = "Thống kê";
            this.btnTke.UseVisualStyleBackColor = false;
            this.btnTke.Click += new System.EventHandler(this.btnTke_Click);
            // 
            // btnAttack
            // 
            this.btnAttack.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnAttack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAttack.BackgroundImage")));
            this.btnAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAttack.Location = new System.Drawing.Point(519, 10);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(83, 35);
            this.btnAttack.TabIndex = 10;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = false;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.SystemColors.Window;
            this.labelName.Location = new System.Drawing.Point(18, 17);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(108, 20);
            this.labelName.TabIndex = 9;
            this.labelName.Text = "Tên file .text";
            // 
            // txtTenfile
            // 
            this.txtTenfile.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtTenfile.Location = new System.Drawing.Point(134, 14);
            this.txtTenfile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenfile.Name = "txtTenfile";
            this.txtTenfile.Size = new System.Drawing.Size(122, 26);
            this.txtTenfile.TabIndex = 8;
            // 
            // rtbShow
            // 
            this.rtbShow.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.rtbShow.Enabled = false;
            this.rtbShow.Location = new System.Drawing.Point(13, 50);
            this.rtbShow.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rtbShow.Name = "rtbShow";
            this.rtbShow.Size = new System.Drawing.Size(589, 205);
            this.rtbShow.TabIndex = 7;
            this.rtbShow.Text = "";
            // 
            // FormAttack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::GUI.Properties.Resources.northern_lights_aurora_mountains_135646_1366x768;
            this.ClientSize = new System.Drawing.Size(617, 309);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTke);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.txtTenfile);
            this.Controls.Add(this.rtbShow);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormAttack";
            this.Text = "Attack";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnTke;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox txtTenfile;
        private System.Windows.Forms.RichTextBox rtbShow;
    }
}