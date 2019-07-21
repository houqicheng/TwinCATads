namespace csADS
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReadPrimitive = new System.Windows.Forms.Button();
            this.txtINT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBool = new System.Windows.Forms.TextBox();
            this.txtDint = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtByte = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtReal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLreal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLreal);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtReal);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtByte);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDint);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBool);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnReadPrimitive);
            this.groupBox1.Controls.Add(this.txtINT);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 423);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Primitive Datetype";
            // 
            // btnReadPrimitive
            // 
            this.btnReadPrimitive.Location = new System.Drawing.Point(47, 375);
            this.btnReadPrimitive.Name = "btnReadPrimitive";
            this.btnReadPrimitive.Size = new System.Drawing.Size(85, 32);
            this.btnReadPrimitive.TabIndex = 2;
            this.btnReadPrimitive.Text = "Read";
            this.btnReadPrimitive.UseVisualStyleBackColor = true;
            this.btnReadPrimitive.Click += new System.EventHandler(this.btnReadPrimitive_Click);
            // 
            // txtINT
            // 
            this.txtINT.Location = new System.Drawing.Point(128, 24);
            this.txtINT.Name = "txtINT";
            this.txtINT.Size = new System.Drawing.Size(101, 22);
            this.txtINT.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "int";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bool";
            // 
            // txtBool
            // 
            this.txtBool.Location = new System.Drawing.Point(128, 60);
            this.txtBool.Name = "txtBool";
            this.txtBool.Size = new System.Drawing.Size(101, 22);
            this.txtBool.TabIndex = 4;
            // 
            // txtDint
            // 
            this.txtDint.Location = new System.Drawing.Point(128, 88);
            this.txtDint.Name = "txtDint";
            this.txtDint.Size = new System.Drawing.Size(101, 22);
            this.txtDint.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(6, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dint";
            // 
            // txtByte
            // 
            this.txtByte.Location = new System.Drawing.Point(128, 118);
            this.txtByte.Name = "txtByte";
            this.txtByte.Size = new System.Drawing.Size(101, 22);
            this.txtByte.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(6, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Byte";
            // 
            // txtReal
            // 
            this.txtReal.Location = new System.Drawing.Point(128, 146);
            this.txtReal.Name = "txtReal";
            this.txtReal.Size = new System.Drawing.Size(101, 22);
            this.txtReal.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(6, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Real";
            // 
            // txtLreal
            // 
            this.txtLreal.Location = new System.Drawing.Point(128, 174);
            this.txtLreal.Name = "txtLreal";
            this.txtLreal.Size = new System.Drawing.Size(101, 22);
            this.txtLreal.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(6, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Lreal";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtINT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReadPrimitive;
        private System.Windows.Forms.TextBox txtLreal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtReal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtByte;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDint;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBool;
        private System.Windows.Forms.Label label2;
    }
}

