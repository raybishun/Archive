
namespace WinFormAppForSQL
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
            this.RunSQL = new System.Windows.Forms.Button();
            this.ReadFlatFile = new System.Windows.Forms.Button();
            this.ReadXML = new System.Windows.Forms.Button();
            this.InMemDataSets = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RunSQL
            // 
            this.RunSQL.Location = new System.Drawing.Point(273, 66);
            this.RunSQL.Name = "RunSQL";
            this.RunSQL.Size = new System.Drawing.Size(232, 49);
            this.RunSQL.TabIndex = 0;
            this.RunSQL.Text = "Run SQL";
            this.RunSQL.UseVisualStyleBackColor = true;
            this.RunSQL.Click += new System.EventHandler(this.RunSQL_Click);
            // 
            // ReadFlatFile
            // 
            this.ReadFlatFile.Location = new System.Drawing.Point(273, 143);
            this.ReadFlatFile.Name = "ReadFlatFile";
            this.ReadFlatFile.Size = new System.Drawing.Size(232, 52);
            this.ReadFlatFile.TabIndex = 1;
            this.ReadFlatFile.Text = "Read Flat File";
            this.ReadFlatFile.UseVisualStyleBackColor = true;
            this.ReadFlatFile.Click += new System.EventHandler(this.ReadFlatFile_Click);
            // 
            // ReadXML
            // 
            this.ReadXML.Location = new System.Drawing.Point(273, 212);
            this.ReadXML.Name = "ReadXML";
            this.ReadXML.Size = new System.Drawing.Size(232, 52);
            this.ReadXML.TabIndex = 2;
            this.ReadXML.Text = "Read XML File";
            this.ReadXML.UseVisualStyleBackColor = true;
            this.ReadXML.Click += new System.EventHandler(this.ReadXML_Click);
            // 
            // InMemDataSets
            // 
            this.InMemDataSets.Location = new System.Drawing.Point(273, 282);
            this.InMemDataSets.Name = "InMemDataSets";
            this.InMemDataSets.Size = new System.Drawing.Size(232, 52);
            this.InMemDataSets.TabIndex = 3;
            this.InMemDataSets.Text = "In-Memory Datasets";
            this.InMemDataSets.UseVisualStyleBackColor = true;
            this.InMemDataSets.Click += new System.EventHandler(this.InMemDataSets_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InMemDataSets);
            this.Controls.Add(this.ReadXML);
            this.Controls.Add(this.ReadFlatFile);
            this.Controls.Add(this.RunSQL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RunSQL;
        private System.Windows.Forms.Button ReadFlatFile;
        private System.Windows.Forms.Button ReadXML;
        private System.Windows.Forms.Button InMemDataSets;
    }
}

