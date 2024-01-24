namespace SecurityProject
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.P10Key = new System.Windows.Forms.Button();
            this.IPButton = new System.Windows.Forms.Button();
            this.expansion = new System.Windows.Forms.TextBox();
            this.expButton = new System.Windows.Forms.Button();
            this.xor = new System.Windows.Forms.TextBox();
            this.xorButton = new System.Windows.Forms.Button();
            this.k1 = new System.Windows.Forms.TextBox();
            this.k2 = new System.Windows.Forms.TextBox();
            this.SubKeyButton = new System.Windows.Forms.Button();
            this.subsText = new System.Windows.Forms.TextBox();
            this.SubsButton = new System.Windows.Forms.Button();
            this.p4 = new System.Windows.Forms.TextBox();
            this.perm4 = new System.Windows.Forms.Button();
            this.xor4 = new System.Windows.Forms.TextBox();
            this.xor4button = new System.Windows.Forms.Button();
            this.swapButton = new System.Windows.Forms.Button();
            this.roundNum = new System.Windows.Forms.TextBox();
            this.roundssss = new System.Windows.Forms.Label();
            this.ipInv = new System.Windows.Forms.TextBox();
            this.xorK2Button = new System.Windows.Forms.Button();
            this.ogPlain = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EndButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(194, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(226, 26);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter 10-bit key:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(194, 92);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(226, 26);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter 8-bit plaintext:";
            // 
            // P10Key
            // 
            this.P10Key.Location = new System.Drawing.Point(426, 1);
            this.P10Key.Name = "P10Key";
            this.P10Key.Size = new System.Drawing.Size(112, 36);
            this.P10Key.TabIndex = 6;
            this.P10Key.Text = "KeyP10";
            this.P10Key.UseVisualStyleBackColor = true;
            this.P10Key.Click += new System.EventHandler(this.P10Key_Click);
            // 
            // IPButton
            // 
            this.IPButton.Location = new System.Drawing.Point(316, 138);
            this.IPButton.Name = "IPButton";
            this.IPButton.Size = new System.Drawing.Size(75, 35);
            this.IPButton.TabIndex = 8;
            this.IPButton.Text = "IP";
            this.IPButton.UseVisualStyleBackColor = true;
            this.IPButton.Click += new System.EventHandler(this.IPButton_Click);
            // 
            // expansion
            // 
            this.expansion.Location = new System.Drawing.Point(194, 179);
            this.expansion.Name = "expansion";
            this.expansion.ReadOnly = true;
            this.expansion.Size = new System.Drawing.Size(226, 26);
            this.expansion.TabIndex = 9;
            this.expansion.TextChanged += new System.EventHandler(this.expansion_TextChanged);
            // 
            // expButton
            // 
            this.expButton.Location = new System.Drawing.Point(435, 179);
            this.expButton.Name = "expButton";
            this.expButton.Size = new System.Drawing.Size(75, 29);
            this.expButton.TabIndex = 10;
            this.expButton.Text = "E/P";
            this.expButton.UseVisualStyleBackColor = true;
            this.expButton.Click += new System.EventHandler(this.expButton_Click);
            // 
            // xor
            // 
            this.xor.Location = new System.Drawing.Point(194, 211);
            this.xor.Name = "xor";
            this.xor.ReadOnly = true;
            this.xor.Size = new System.Drawing.Size(226, 26);
            this.xor.TabIndex = 11;
            this.xor.TextChanged += new System.EventHandler(this.xor_TextChanged);
            // 
            // xorButton
            // 
            this.xorButton.Location = new System.Drawing.Point(435, 209);
            this.xorButton.Name = "xorButton";
            this.xorButton.Size = new System.Drawing.Size(103, 33);
            this.xorButton.TabIndex = 12;
            this.xorButton.Text = "XOR/K1";
            this.xorButton.UseVisualStyleBackColor = true;
            this.xorButton.Click += new System.EventHandler(this.xorButton_Click);
            // 
            // k1
            // 
            this.k1.Location = new System.Drawing.Point(194, 51);
            this.k1.Name = "k1";
            this.k1.ReadOnly = true;
            this.k1.Size = new System.Drawing.Size(104, 26);
            this.k1.TabIndex = 13;
            // 
            // k2
            // 
            this.k2.Location = new System.Drawing.Point(316, 51);
            this.k2.Name = "k2";
            this.k2.ReadOnly = true;
            this.k2.Size = new System.Drawing.Size(104, 26);
            this.k2.TabIndex = 14;
            // 
            // SubKeyButton
            // 
            this.SubKeyButton.Location = new System.Drawing.Point(426, 38);
            this.SubKeyButton.Name = "SubKeyButton";
            this.SubKeyButton.Size = new System.Drawing.Size(112, 48);
            this.SubKeyButton.TabIndex = 15;
            this.SubKeyButton.Text = "GenSubKey";
            this.SubKeyButton.UseVisualStyleBackColor = true;
            this.SubKeyButton.Click += new System.EventHandler(this.SubKeyButton_Click);
            // 
            // subsText
            // 
            this.subsText.Location = new System.Drawing.Point(194, 243);
            this.subsText.Name = "subsText";
            this.subsText.ReadOnly = true;
            this.subsText.Size = new System.Drawing.Size(226, 26);
            this.subsText.TabIndex = 16;
            // 
            // SubsButton
            // 
            this.SubsButton.Location = new System.Drawing.Point(435, 239);
            this.SubsButton.Name = "SubsButton";
            this.SubsButton.Size = new System.Drawing.Size(75, 35);
            this.SubsButton.TabIndex = 17;
            this.SubsButton.Text = "Subs";
            this.SubsButton.UseVisualStyleBackColor = true;
            this.SubsButton.Click += new System.EventHandler(this.SubsButton_Click);
            // 
            // p4
            // 
            this.p4.Location = new System.Drawing.Point(194, 275);
            this.p4.Name = "p4";
            this.p4.ReadOnly = true;
            this.p4.Size = new System.Drawing.Size(226, 26);
            this.p4.TabIndex = 18;
            // 
            // perm4
            // 
            this.perm4.Location = new System.Drawing.Point(435, 275);
            this.perm4.Name = "perm4";
            this.perm4.Size = new System.Drawing.Size(75, 33);
            this.perm4.TabIndex = 19;
            this.perm4.Text = "P4";
            this.perm4.UseVisualStyleBackColor = true;
            this.perm4.Click += new System.EventHandler(this.perm4_Click);
            // 
            // xor4
            // 
            this.xor4.Location = new System.Drawing.Point(194, 307);
            this.xor4.Name = "xor4";
            this.xor4.ReadOnly = true;
            this.xor4.Size = new System.Drawing.Size(226, 26);
            this.xor4.TabIndex = 20;
            this.xor4.TextChanged += new System.EventHandler(this.xor4_TextChanged);
            // 
            // xor4button
            // 
            this.xor4button.Location = new System.Drawing.Point(426, 307);
            this.xor4button.Name = "xor4button";
            this.xor4button.Size = new System.Drawing.Size(99, 35);
            this.xor4button.TabIndex = 21;
            this.xor4button.Text = "XOR 4-bit";
            this.xor4button.UseVisualStyleBackColor = true;
            this.xor4button.Click += new System.EventHandler(this.xor4button_Click);
            // 
            // swapButton
            // 
            this.swapButton.Location = new System.Drawing.Point(404, 138);
            this.swapButton.Name = "swapButton";
            this.swapButton.Size = new System.Drawing.Size(75, 35);
            this.swapButton.TabIndex = 23;
            this.swapButton.Text = "swap";
            this.swapButton.UseVisualStyleBackColor = true;
            this.swapButton.Visible = false;
            this.swapButton.Click += new System.EventHandler(this.swapButton_Click);
            // 
            // roundNum
            // 
            this.roundNum.Location = new System.Drawing.Point(644, 38);
            this.roundNum.Name = "roundNum";
            this.roundNum.ReadOnly = true;
            this.roundNum.Size = new System.Drawing.Size(15, 26);
            this.roundNum.TabIndex = 24;
            this.roundNum.Text = "1";
            this.roundNum.TextChanged += new System.EventHandler(this.roundNum_TextChanged);
            // 
            // roundssss
            // 
            this.roundssss.AutoSize = true;
            this.roundssss.Location = new System.Drawing.Point(577, 41);
            this.roundssss.Name = "roundssss";
            this.roundssss.Size = new System.Drawing.Size(61, 20);
            this.roundssss.TabIndex = 25;
            this.roundssss.Text = "Round:";
            // 
            // ipInv
            // 
            this.ipInv.Location = new System.Drawing.Point(507, 359);
            this.ipInv.Name = "ipInv";
            this.ipInv.ReadOnly = true;
            this.ipInv.Size = new System.Drawing.Size(118, 26);
            this.ipInv.TabIndex = 26;
            this.ipInv.TextChanged += new System.EventHandler(this.ipInv_TextChanged);
            // 
            // xorK2Button
            // 
            this.xorK2Button.Location = new System.Drawing.Point(78, 209);
            this.xorK2Button.Name = "xorK2Button";
            this.xorK2Button.Size = new System.Drawing.Size(110, 28);
            this.xorK2Button.TabIndex = 28;
            this.xorK2Button.Text = "XOR/K2";
            this.xorK2Button.UseVisualStyleBackColor = true;
            this.xorK2Button.Visible = false;
            this.xorK2Button.Click += new System.EventHandler(this.xorK2Button_Click);
            // 
            // ogPlain
            // 
            this.ogPlain.Location = new System.Drawing.Point(194, 124);
            this.ogPlain.Name = "ogPlain";
            this.ogPlain.ReadOnly = true;
            this.ogPlain.Size = new System.Drawing.Size(90, 26);
            this.ogPlain.TabIndex = 29;
            this.ogPlain.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 30;
            this.label3.Text = "OG plaintext:";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // EndButton
            // 
            this.EndButton.Location = new System.Drawing.Point(327, 362);
            this.EndButton.Name = "EndButton";
            this.EndButton.Size = new System.Drawing.Size(75, 35);
            this.EndButton.TabIndex = 31;
            this.EndButton.Text = "END";
            this.EndButton.UseVisualStyleBackColor = true;
            this.EndButton.Visible = false;
            this.EndButton.Click += new System.EventHandler(this.EndButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(453, 365);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = "IP-inv";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EndButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ogPlain);
            this.Controls.Add(this.xorK2Button);
            this.Controls.Add(this.ipInv);
            this.Controls.Add(this.roundssss);
            this.Controls.Add(this.roundNum);
            this.Controls.Add(this.swapButton);
            this.Controls.Add(this.xor4button);
            this.Controls.Add(this.xor4);
            this.Controls.Add(this.perm4);
            this.Controls.Add(this.p4);
            this.Controls.Add(this.SubsButton);
            this.Controls.Add(this.subsText);
            this.Controls.Add(this.SubKeyButton);
            this.Controls.Add(this.k2);
            this.Controls.Add(this.k1);
            this.Controls.Add(this.xorButton);
            this.Controls.Add(this.xor);
            this.Controls.Add(this.expButton);
            this.Controls.Add(this.expansion);
            this.Controls.Add(this.IPButton);
            this.Controls.Add(this.P10Key);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button P10Key;
        private System.Windows.Forms.Button IPButton;
        private System.Windows.Forms.TextBox expansion;
        private System.Windows.Forms.Button expButton;
        private System.Windows.Forms.TextBox xor;
        private System.Windows.Forms.Button xorButton;
        private System.Windows.Forms.TextBox k1;
        private System.Windows.Forms.TextBox k2;
        private System.Windows.Forms.Button SubKeyButton;
        private System.Windows.Forms.TextBox subsText;
        private System.Windows.Forms.Button SubsButton;
        private System.Windows.Forms.TextBox p4;
        private System.Windows.Forms.Button perm4;
        private System.Windows.Forms.TextBox xor4;
        private System.Windows.Forms.Button xor4button;
        private System.Windows.Forms.Button swapButton;
        private System.Windows.Forms.TextBox roundNum;
        private System.Windows.Forms.Label roundssss;
        private System.Windows.Forms.TextBox ipInv;
        private System.Windows.Forms.Button xorK2Button;
        private System.Windows.Forms.TextBox ogPlain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button EndButton;
        private System.Windows.Forms.Label label4;
    }
}

