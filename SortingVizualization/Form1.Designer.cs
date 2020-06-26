namespace SortingVizualization
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
            this.pnlSort = new System.Windows.Forms.PictureBox();
            this.cmdRandomize = new System.Windows.Forms.Button();
            this.cmdSort = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pnlSort)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSort
            // 
            this.pnlSort.BackColor = System.Drawing.Color.White;
            this.pnlSort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSort.Location = new System.Drawing.Point(12, 12);
            this.pnlSort.Name = "pnlSort";
            this.pnlSort.Size = new System.Drawing.Size(495, 310);
            this.pnlSort.TabIndex = 0;
            this.pnlSort.TabStop = false;
            // 
            // cmdRandomize
            // 
            this.cmdRandomize.Location = new System.Drawing.Point(582, 89);
            this.cmdRandomize.Name = "cmdRandomize";
            this.cmdRandomize.Size = new System.Drawing.Size(90, 42);
            this.cmdRandomize.TabIndex = 1;
            this.cmdRandomize.Text = "Randomize";
            this.cmdRandomize.UseVisualStyleBackColor = true;
            this.cmdRandomize.Click += new System.EventHandler(this.cmdRandomize_Click);
            // 
            // cmdSort
            // 
            this.cmdSort.Location = new System.Drawing.Point(582, 182);
            this.cmdSort.Name = "cmdSort";
            this.cmdSort.Size = new System.Drawing.Size(90, 42);
            this.cmdSort.TabIndex = 2;
            this.cmdSort.Text = "Sort";
            this.cmdSort.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 334);
            this.Controls.Add(this.cmdSort);
            this.Controls.Add(this.cmdRandomize);
            this.Controls.Add(this.pnlSort);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pnlSort)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pnlSort;
        private System.Windows.Forms.Button cmdRandomize;
        private System.Windows.Forms.Button cmdSort;
    }
}

