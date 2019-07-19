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
            this.label1 = new System.Windows.Forms.Label();
            this.txtINT = new System.Windows.Forms.TextBox();
            this.btnReadPrimitive = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReadPrimitive);
            this.groupBox1.Controls.Add(this.txtINT);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 423);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Primitive Datetype";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "int";
            // 
            // txtINT
            // 
            this.txtINT.Location = new System.Drawing.Point(101, 34);
            this.txtINT.Name = "txtINT";
            this.txtINT.Size = new System.Drawing.Size(100, 22);
            this.txtINT.TabIndex = 1;
            // 
            // btnReadPrimitive
            // 
            this.btnReadPrimitive.Location = new System.Drawing.Point(47, 384);
            this.btnReadPrimitive.Name = "btnReadPrimitive";
            this.btnReadPrimitive.Size = new System.Drawing.Size(75, 23);
            this.btnReadPrimitive.TabIndex = 2;
            this.btnReadPrimitive.Text = "Read";
            this.btnReadPrimitive.UseVisualStyleBackColor = true;
            this.btnReadPrimitive.Click += new System.EventHandler(this.btnReadPrimitive_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

