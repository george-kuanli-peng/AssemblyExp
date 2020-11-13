namespace ProgramEncapsulator
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
            this.txtOrigLoc = new System.Windows.Forms.TextBox();
            this.btnSelectOrig = new System.Windows.Forms.Button();
            this.btnSelectOutput = new System.Windows.Forms.Button();
            this.txtOutputLoc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelectTemplate = new System.Windows.Forms.Button();
            this.txtTemplateLoc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEncapsulate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Original program loc:";
            // 
            // txtOrigLoc
            // 
            this.txtOrigLoc.Location = new System.Drawing.Point(225, 60);
            this.txtOrigLoc.Name = "txtOrigLoc";
            this.txtOrigLoc.ReadOnly = true;
            this.txtOrigLoc.Size = new System.Drawing.Size(326, 26);
            this.txtOrigLoc.TabIndex = 5;
            // 
            // btnSelectOrig
            // 
            this.btnSelectOrig.Location = new System.Drawing.Point(557, 60);
            this.btnSelectOrig.Name = "btnSelectOrig";
            this.btnSelectOrig.Size = new System.Drawing.Size(75, 26);
            this.btnSelectOrig.TabIndex = 6;
            this.btnSelectOrig.Text = "S&elect";
            this.btnSelectOrig.UseVisualStyleBackColor = true;
            this.btnSelectOrig.Click += new System.EventHandler(this.btnSelectOrig_Click);
            // 
            // btnSelectOutput
            // 
            this.btnSelectOutput.Location = new System.Drawing.Point(557, 92);
            this.btnSelectOutput.Name = "btnSelectOutput";
            this.btnSelectOutput.Size = new System.Drawing.Size(75, 26);
            this.btnSelectOutput.TabIndex = 9;
            this.btnSelectOutput.Text = "Sele&ct";
            this.btnSelectOutput.UseVisualStyleBackColor = true;
            this.btnSelectOutput.Click += new System.EventHandler(this.btnSelectOutput_Click);
            // 
            // txtOutputLoc
            // 
            this.txtOutputLoc.Location = new System.Drawing.Point(225, 92);
            this.txtOutputLoc.Name = "txtOutputLoc";
            this.txtOutputLoc.ReadOnly = true;
            this.txtOutputLoc.Size = new System.Drawing.Size(326, 26);
            this.txtOutputLoc.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Output program loc:";
            // 
            // btnSelectTemplate
            // 
            this.btnSelectTemplate.Location = new System.Drawing.Point(557, 28);
            this.btnSelectTemplate.Name = "btnSelectTemplate";
            this.btnSelectTemplate.Size = new System.Drawing.Size(75, 26);
            this.btnSelectTemplate.TabIndex = 3;
            this.btnSelectTemplate.Text = "&Select";
            this.btnSelectTemplate.UseVisualStyleBackColor = true;
            this.btnSelectTemplate.Click += new System.EventHandler(this.btnSelectTemplate_Click);
            // 
            // txtTemplateLoc
            // 
            this.txtTemplateLoc.Location = new System.Drawing.Point(225, 28);
            this.txtTemplateLoc.Name = "txtTemplateLoc";
            this.txtTemplateLoc.ReadOnly = true;
            this.txtTemplateLoc.Size = new System.Drawing.Size(326, 26);
            this.txtTemplateLoc.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Extractor template loc:";
            // 
            // btnEncapsulate
            // 
            this.btnEncapsulate.Location = new System.Drawing.Point(225, 124);
            this.btnEncapsulate.Name = "btnEncapsulate";
            this.btnEncapsulate.Size = new System.Drawing.Size(184, 36);
            this.btnEncapsulate.TabIndex = 10;
            this.btnEncapsulate.Text = "Encapsulate &Program";
            this.btnEncapsulate.UseVisualStyleBackColor = true;
            this.btnEncapsulate.Click += new System.EventHandler(this.btnEncapsulate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 195);
            this.Controls.Add(this.btnEncapsulate);
            this.Controls.Add(this.btnSelectTemplate);
            this.Controls.Add(this.txtTemplateLoc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSelectOutput);
            this.Controls.Add(this.txtOutputLoc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSelectOrig);
            this.Controls.Add(this.txtOrigLoc);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Program Encapsulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOrigLoc;
        private System.Windows.Forms.Button btnSelectOrig;
        private System.Windows.Forms.Button btnSelectOutput;
        private System.Windows.Forms.TextBox txtOutputLoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSelectTemplate;
        private System.Windows.Forms.TextBox txtTemplateLoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEncapsulate;
    }
}

