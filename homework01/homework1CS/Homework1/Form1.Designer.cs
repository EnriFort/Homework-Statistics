namespace Homework1
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
            this.gbLego = new System.Windows.Forms.GroupBox();
            this.cbLegs = new System.Windows.Forms.ComboBox();
            this.cbBody = new System.Windows.Forms.ComboBox();
            this.cbHead = new System.Windows.Forms.ComboBox();
            this.cbHair = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHair = new System.Windows.Forms.TextBox();
            this.txtHead = new System.Windows.Forms.TextBox();
            this.txtBody = new System.Windows.Forms.TextBox();
            this.txtLegDx = new System.Windows.Forms.TextBox();
            this.txtLegSx = new System.Windows.Forms.TextBox();
            this.txtArmDx = new System.Windows.Forms.TextBox();
            this.txtArmSx = new System.Windows.Forms.TextBox();
            this.gbLego.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbLego
            // 
            this.gbLego.Controls.Add(this.cbLegs);
            this.gbLego.Controls.Add(this.cbBody);
            this.gbLego.Controls.Add(this.cbHead);
            this.gbLego.Controls.Add(this.cbHair);
            this.gbLego.Controls.Add(this.label4);
            this.gbLego.Controls.Add(this.label3);
            this.gbLego.Controls.Add(this.label2);
            this.gbLego.Controls.Add(this.label1);
            this.gbLego.Font = new System.Drawing.Font("MV Boli", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLego.Location = new System.Drawing.Point(12, 64);
            this.gbLego.Name = "gbLego";
            this.gbLego.Size = new System.Drawing.Size(272, 188);
            this.gbLego.TabIndex = 0;
            this.gbLego.TabStop = false;
            this.gbLego.Text = "FIGURE INFO";
            this.gbLego.Enter += new System.EventHandler(this.gbLego_Enter);
            // 
            // cbLegs
            // 
            this.cbLegs.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLegs.FormattingEnabled = true;
            this.cbLegs.Items.AddRange(new object[] {
            "NAVY",
            "RED",
            "PURPLE",
            "GREEN",
            "BROWN",
            "WHITE",
            "YELLOW",
            "ORANGE"});
            this.cbLegs.Location = new System.Drawing.Point(105, 142);
            this.cbLegs.Name = "cbLegs";
            this.cbLegs.Size = new System.Drawing.Size(121, 25);
            this.cbLegs.TabIndex = 7;
            // 
            // cbBody
            // 
            this.cbBody.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBody.FormattingEnabled = true;
            this.cbBody.Items.AddRange(new object[] {
            "NAVY",
            "RED",
            "PURPLE",
            "GREEN",
            "BROWN",
            "WHITE",
            "YELLOW",
            "ORANGE"});
            this.cbBody.Location = new System.Drawing.Point(105, 103);
            this.cbBody.Name = "cbBody";
            this.cbBody.Size = new System.Drawing.Size(121, 25);
            this.cbBody.TabIndex = 6;
            // 
            // cbHead
            // 
            this.cbHead.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHead.FormattingEnabled = true;
            this.cbHead.Items.AddRange(new object[] {
            "LIGHT SKIN",
            "MEDIUM SKIN",
            "DARK SKIN",
            "LEGO SKIN"});
            this.cbHead.Location = new System.Drawing.Point(105, 64);
            this.cbHead.Name = "cbHead";
            this.cbHead.Size = new System.Drawing.Size(121, 25);
            this.cbHead.TabIndex = 5;
            // 
            // cbHair
            // 
            this.cbHair.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHair.FormattingEnabled = true;
            this.cbHair.Items.AddRange(new object[] {
            "GRAY",
            "YELLOW",
            "RED",
            "BROWN",
            "BLACK"});
            this.cbHair.Location = new System.Drawing.Point(105, 27);
            this.cbHair.Name = "cbHair";
            this.cbHair.Size = new System.Drawing.Size(121, 25);
            this.cbHair.TabIndex = 4;
            this.cbHair.SelectedIndexChanged += new System.EventHandler(this.cbHair_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "LEGS";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "BODY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "HEAD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "HAIR";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(188, 258);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(96, 48);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "CREATE";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            this.btnCreate.MouseLeave += new System.EventHandler(this.btnCreate_MouseLeave);
            this.btnCreate.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnCreate_MouseMove);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(447, 40);
            this.label5.TabIndex = 2;
            this.label5.Text = "CREATE YOUR OWN FIGURE";
            // 
            // txtHair
            // 
            this.txtHair.BackColor = System.Drawing.Color.Gainsboro;
            this.txtHair.Location = new System.Drawing.Point(544, 62);
            this.txtHair.Multiline = true;
            this.txtHair.Name = "txtHair";
            this.txtHair.Size = new System.Drawing.Size(79, 20);
            this.txtHair.TabIndex = 3;
            this.txtHair.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtHead
            // 
            this.txtHead.BackColor = System.Drawing.Color.Gainsboro;
            this.txtHead.Location = new System.Drawing.Point(544, 88);
            this.txtHead.Multiline = true;
            this.txtHead.Name = "txtHead";
            this.txtHead.Size = new System.Drawing.Size(79, 89);
            this.txtHead.TabIndex = 4;
            this.txtHead.TextChanged += new System.EventHandler(this.txtHead_TextChanged);
            // 
            // txtBody
            // 
            this.txtBody.BackColor = System.Drawing.Color.Gainsboro;
            this.txtBody.Location = new System.Drawing.Point(524, 186);
            this.txtBody.Multiline = true;
            this.txtBody.Name = "txtBody";
            this.txtBody.Size = new System.Drawing.Size(120, 146);
            this.txtBody.TabIndex = 5;
            // 
            // txtLegDx
            // 
            this.txtLegDx.BackColor = System.Drawing.Color.Gainsboro;
            this.txtLegDx.Location = new System.Drawing.Point(524, 338);
            this.txtLegDx.Multiline = true;
            this.txtLegDx.Name = "txtLegDx";
            this.txtLegDx.Size = new System.Drawing.Size(47, 137);
            this.txtLegDx.TabIndex = 6;
            // 
            // txtLegSx
            // 
            this.txtLegSx.BackColor = System.Drawing.Color.Gainsboro;
            this.txtLegSx.Location = new System.Drawing.Point(597, 339);
            this.txtLegSx.Multiline = true;
            this.txtLegSx.Name = "txtLegSx";
            this.txtLegSx.Size = new System.Drawing.Size(47, 137);
            this.txtLegSx.TabIndex = 7;
            // 
            // txtArmDx
            // 
            this.txtArmDx.BackColor = System.Drawing.Color.Gainsboro;
            this.txtArmDx.Location = new System.Drawing.Point(480, 203);
            this.txtArmDx.Multiline = true;
            this.txtArmDx.Name = "txtArmDx";
            this.txtArmDx.Size = new System.Drawing.Size(38, 123);
            this.txtArmDx.TabIndex = 8;
            this.txtArmDx.TextChanged += new System.EventHandler(this.txtArmDx_TextChanged);
            // 
            // txtArmSx
            // 
            this.txtArmSx.BackColor = System.Drawing.Color.Gainsboro;
            this.txtArmSx.Location = new System.Drawing.Point(650, 203);
            this.txtArmSx.Multiline = true;
            this.txtArmSx.Name = "txtArmSx";
            this.txtArmSx.Size = new System.Drawing.Size(38, 123);
            this.txtArmSx.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(818, 488);
            this.Controls.Add(this.txtArmSx);
            this.Controls.Add(this.txtArmDx);
            this.Controls.Add(this.txtLegSx);
            this.Controls.Add(this.txtLegDx);
            this.Controls.Add(this.txtBody);
            this.Controls.Add(this.txtHead);
            this.Controls.Add(this.txtHair);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.gbLego);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbLego.ResumeLayout(false);
            this.gbLego.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLego;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbLegs;
        private System.Windows.Forms.ComboBox cbBody;
        private System.Windows.Forms.ComboBox cbHead;
        private System.Windows.Forms.ComboBox cbHair;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHair;
        private System.Windows.Forms.TextBox txtHead;
        private System.Windows.Forms.TextBox txtBody;
        private System.Windows.Forms.TextBox txtLegDx;
        private System.Windows.Forms.TextBox txtLegSx;
        private System.Windows.Forms.TextBox txtArmDx;
        private System.Windows.Forms.TextBox txtArmSx;
    }
}

