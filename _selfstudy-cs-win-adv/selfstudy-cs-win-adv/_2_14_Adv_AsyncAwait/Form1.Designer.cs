namespace _2_14_Adv_AsyncAwait
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
            this.TaskButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AsyncAwaitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TaskButton
            // 
            this.TaskButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskButton.Location = new System.Drawing.Point(55, 175);
            this.TaskButton.Name = "TaskButton";
            this.TaskButton.Size = new System.Drawing.Size(325, 90);
            this.TaskButton.TabIndex = 0;
            this.TaskButton.Text = "Task.Factory.StartNew";
            this.TaskButton.UseVisualStyleBackColor = true;
            this.TaskButton.Click += new System.EventHandler(this.TaskButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Click a button!";
            // 
            // AsyncAwaitButton
            // 
            this.AsyncAwaitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AsyncAwaitButton.Location = new System.Drawing.Point(404, 175);
            this.AsyncAwaitButton.Name = "AsyncAwaitButton";
            this.AsyncAwaitButton.Size = new System.Drawing.Size(325, 90);
            this.AsyncAwaitButton.TabIndex = 2;
            this.AsyncAwaitButton.Text = "AsyncAwait";
            this.AsyncAwaitButton.UseVisualStyleBackColor = true;
            this.AsyncAwaitButton.Click += new System.EventHandler(this.AsyncAwaitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.AsyncAwaitButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TaskButton);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TaskButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AsyncAwaitButton;
    }
}

