
namespace WinFormApp
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
            this.CalcSum = new System.Windows.Forms.Button();
            this.OperandOne = new System.Windows.Forms.TextBox();
            this.OperandTwo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CalcSum
            // 
            this.CalcSum.Location = new System.Drawing.Point(365, 240);
            this.CalcSum.Name = "CalcSum";
            this.CalcSum.Size = new System.Drawing.Size(100, 42);
            this.CalcSum.TabIndex = 0;
            this.CalcSum.Text = "Calc Sum";
            this.CalcSum.UseVisualStyleBackColor = true;
            this.CalcSum.Click += new System.EventHandler(this.CalcSum_Click);
            // 
            // OperandOne
            // 
            this.OperandOne.Location = new System.Drawing.Point(365, 140);
            this.OperandOne.Name = "OperandOne";
            this.OperandOne.Size = new System.Drawing.Size(100, 26);
            this.OperandOne.TabIndex = 1;
            // 
            // OperandTwo
            // 
            this.OperandTwo.Location = new System.Drawing.Point(365, 189);
            this.OperandTwo.Name = "OperandTwo";
            this.OperandTwo.Size = new System.Drawing.Size(100, 26);
            this.OperandTwo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Operand 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Operand 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OperandTwo);
            this.Controls.Add(this.OperandOne);
            this.Controls.Add(this.CalcSum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.Enter += new System.EventHandler(this.Form1_Enter);
            this.MouseEnter += new System.EventHandler(this.Form1_MouseEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CalcSum;
        private System.Windows.Forms.TextBox OperandOne;
        private System.Windows.Forms.TextBox OperandTwo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

