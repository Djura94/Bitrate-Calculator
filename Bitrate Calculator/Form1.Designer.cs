namespace Bitrate_Calculator
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
            this.btn_InsertFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rtb_ParsedData = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rtb_Bitrate = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insert .json file:";
            // 
            // btn_InsertFile
            // 
            this.btn_InsertFile.Location = new System.Drawing.Point(113, 21);
            this.btn_InsertFile.Name = "btn_InsertFile";
            this.btn_InsertFile.Size = new System.Drawing.Size(64, 23);
            this.btn_InsertFile.TabIndex = 1;
            this.btn_InsertFile.Text = "Insert";
            this.btn_InsertFile.UseVisualStyleBackColor = true;
            this.btn_InsertFile.Click += new System.EventHandler(this.btn_InsertFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Parsed data:";
            // 
            // rtb_ParsedData
            // 
            this.rtb_ParsedData.Location = new System.Drawing.Point(15, 97);
            this.rtb_ParsedData.Name = "rtb_ParsedData";
            this.rtb_ParsedData.ReadOnly = true;
            this.rtb_ParsedData.Size = new System.Drawing.Size(216, 269);
            this.rtb_ParsedData.TabIndex = 3;
            this.rtb_ParsedData.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 408);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bitrate:";
            // 
            // rtb_Bitrate
            // 
            this.rtb_Bitrate.Location = new System.Drawing.Point(15, 424);
            this.rtb_Bitrate.Name = "rtb_Bitrate";
            this.rtb_Bitrate.ReadOnly = true;
            this.rtb_Bitrate.Size = new System.Drawing.Size(216, 43);
            this.rtb_Bitrate.TabIndex = 5;
            this.rtb_Bitrate.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 505);
            this.Controls.Add(this.rtb_Bitrate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtb_ParsedData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_InsertFile);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumSize = new System.Drawing.Size(274, 544);
            this.MinimumSize = new System.Drawing.Size(274, 544);
            this.Name = "Form1";
            this.Text = "Bitrate calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_InsertFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtb_ParsedData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtb_Bitrate;
    }
}

