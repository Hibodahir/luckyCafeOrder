namespace luckuCafeOrder
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
            this.label1 = new System.Windows.Forms.Label();
            this.LstOrderLisft = new System.Windows.Forms.ListBox();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnloadfromfile = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.lbltotalprice = new System.Windows.Forms.Label();
            this.lblluckymassege = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbjuice = new System.Windows.Forms.RadioButton();
            this.rbcoffe = new System.Windows.Forms.RadioButton();
            this.rbtea = new System.Windows.Forms.RadioButton();
            this.cbxstudent = new System.Windows.Forms.CheckBox();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcustomername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(30, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "lucky cafe order";
            // 
            // LstOrderLisft
            // 
            this.LstOrderLisft.BackColor = System.Drawing.Color.OldLace;
            this.LstOrderLisft.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstOrderLisft.FormattingEnabled = true;
            this.LstOrderLisft.ItemHeight = 22;
            this.LstOrderLisft.Location = new System.Drawing.Point(600, 27);
            this.LstOrderLisft.Name = "LstOrderLisft";
            this.LstOrderLisft.Size = new System.Drawing.Size(472, 466);
            this.LstOrderLisft.TabIndex = 10;
            // 
            // btncalculate
            // 
            this.btncalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculate.Location = new System.Drawing.Point(58, 550);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(164, 51);
            this.btncalculate.TabIndex = 11;
            this.btncalculate.Text = "Calculate order";
            this.btncalculate.UseVisualStyleBackColor = true;
            this.btncalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(253, 550);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(164, 51);
            this.btnsave.TabIndex = 12;
            this.btnsave.Text = "save to file";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnloadfromfile
            // 
            this.btnloadfromfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnloadfromfile.Location = new System.Drawing.Point(463, 550);
            this.btnloadfromfile.Name = "btnloadfromfile";
            this.btnloadfromfile.Size = new System.Drawing.Size(164, 51);
            this.btnloadfromfile.TabIndex = 13;
            this.btnloadfromfile.Text = "load from file";
            this.btnloadfromfile.UseVisualStyleBackColor = true;
            this.btnloadfromfile.Click += new System.EventHandler(this.btnloadfromfile_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(668, 550);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(164, 51);
            this.btnclear.TabIndex = 14;
            this.btnclear.Text = "clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // lbltotalprice
            // 
            this.lbltotalprice.BackColor = System.Drawing.Color.White;
            this.lbltotalprice.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalprice.ForeColor = System.Drawing.Color.Navy;
            this.lbltotalprice.Location = new System.Drawing.Point(53, 624);
            this.lbltotalprice.Name = "lbltotalprice";
            this.lbltotalprice.Size = new System.Drawing.Size(779, 47);
            this.lbltotalprice.TabIndex = 15;
            // 
            // lblluckymassege
            // 
            this.lblluckymassege.BackColor = System.Drawing.Color.White;
            this.lblluckymassege.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblluckymassege.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblluckymassege.Location = new System.Drawing.Point(53, 683);
            this.lblluckymassege.Name = "lblluckymassege";
            this.lblluckymassege.Size = new System.Drawing.Size(779, 47);
            this.lblluckymassege.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OldLace;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.cbxstudent);
            this.panel1.Controls.Add(this.txtquantity);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtcustomername);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(487, 443);
            this.panel1.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(19, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(237, 47);
            this.label5.TabIndex = 19;
            this.label5.Text = "customer information";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbjuice);
            this.groupBox1.Controls.Add(this.rbcoffe);
            this.groupBox1.Controls.Add(this.rbtea);
            this.groupBox1.Location = new System.Drawing.Point(24, 163);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 145);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // rbjuice
            // 
            this.rbjuice.AutoSize = true;
            this.rbjuice.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbjuice.Location = new System.Drawing.Point(48, 94);
            this.rbjuice.Name = "rbjuice";
            this.rbjuice.Size = new System.Drawing.Size(117, 27);
            this.rbjuice.TabIndex = 17;
            this.rbjuice.TabStop = true;
            this.rbjuice.Text = "juice ($3)";
            this.rbjuice.UseVisualStyleBackColor = true;
            // 
            // rbcoffe
            // 
            this.rbcoffe.AutoSize = true;
            this.rbcoffe.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbcoffe.Location = new System.Drawing.Point(46, 49);
            this.rbcoffe.Name = "rbcoffe";
            this.rbcoffe.Size = new System.Drawing.Size(129, 27);
            this.rbcoffe.TabIndex = 16;
            this.rbcoffe.TabStop = true;
            this.rbcoffe.Text = "coffee ($2)";
            this.rbcoffe.UseVisualStyleBackColor = true;
            // 
            // rbtea
            // 
            this.rbtea.AutoSize = true;
            this.rbtea.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtea.Location = new System.Drawing.Point(48, 5);
            this.rbtea.Name = "rbtea";
            this.rbtea.Size = new System.Drawing.Size(108, 27);
            this.rbtea.TabIndex = 15;
            this.rbtea.TabStop = true;
            this.rbtea.Text = "Tea ($1)";
            this.rbtea.UseVisualStyleBackColor = true;
            // 
            // cbxstudent
            // 
            this.cbxstudent.AutoSize = true;
            this.cbxstudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxstudent.Location = new System.Drawing.Point(226, 344);
            this.cbxstudent.Name = "cbxstudent";
            this.cbxstudent.Size = new System.Drawing.Size(238, 26);
            this.cbxstudent.TabIndex = 17;
            this.cbxstudent.Text = "student member (10% off)";
            this.cbxstudent.UseVisualStyleBackColor = true;
            // 
            // txtquantity
            // 
            this.txtquantity.Location = new System.Drawing.Point(135, 339);
            this.txtquantity.Multiline = true;
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(64, 31);
            this.txtquantity.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 47);
            this.label3.TabIndex = 15;
            this.label3.Text = "Quantity";
            // 
            // txtcustomername
            // 
            this.txtcustomername.Location = new System.Drawing.Point(24, 107);
            this.txtcustomername.Name = "txtcustomername";
            this.txtcustomername.Size = new System.Drawing.Size(343, 22);
            this.txtcustomername.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 47);
            this.label2.TabIndex = 10;
            this.label2.Text = "customer name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1125, 768);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblluckymassege);
            this.Controls.Add(this.lbltotalprice);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnloadfromfile);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.LstOrderLisft);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox LstOrderLisft;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnloadfromfile;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Label lbltotalprice;
        private System.Windows.Forms.Label lblluckymassege;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbxstudent;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcustomername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbjuice;
        private System.Windows.Forms.RadioButton rbcoffe;
        private System.Windows.Forms.RadioButton rbtea;
    }
}

