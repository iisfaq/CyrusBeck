namespace CyrusBeckLineClipping
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblIntersects = new System.Windows.Forms.Label();
            this.lblIntersectsValue = new System.Windows.Forms.Label();
            this.lblLineStart = new System.Windows.Forms.Label();
            this.lblLineStartValue = new System.Windows.Forms.Label();
            this.lblLineEndValue = new System.Windows.Forms.Label();
            this.lblLineEnd = new System.Windows.Forms.Label();
            this.lblTrimmedLineEndValue = new System.Windows.Forms.Label();
            this.lblTrimmedLineEnd = new System.Windows.Forms.Label();
            this.lblTrimmedLineStartValue = new System.Windows.Forms.Label();
            this.lblTrimmedLineStart = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(672, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "0,75 to 300,75";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(672, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "0,0 to 500,500";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(672, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "250,0 to 0,250";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblTrimmedLineEndValue);
            this.panel1.Controls.Add(this.lblTrimmedLineEnd);
            this.panel1.Controls.Add(this.lblTrimmedLineStartValue);
            this.panel1.Controls.Add(this.lblTrimmedLineStart);
            this.panel1.Controls.Add(this.lblLineEndValue);
            this.panel1.Controls.Add(this.lblLineEnd);
            this.panel1.Controls.Add(this.lblLineStartValue);
            this.panel1.Controls.Add(this.lblLineStart);
            this.panel1.Controls.Add(this.lblIntersectsValue);
            this.panel1.Controls.Add(this.lblIntersects);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 361);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 89);
            this.panel1.TabIndex = 3;
            // 
            // lblIntersects
            // 
            this.lblIntersects.AutoSize = true;
            this.lblIntersects.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntersects.Location = new System.Drawing.Point(11, 10);
            this.lblIntersects.Name = "lblIntersects";
            this.lblIntersects.Size = new System.Drawing.Size(63, 13);
            this.lblIntersects.TabIndex = 0;
            this.lblIntersects.Text = "Intersects";
            // 
            // lblIntersectsValue
            // 
            this.lblIntersectsValue.AutoSize = true;
            this.lblIntersectsValue.Location = new System.Drawing.Point(70, 10);
            this.lblIntersectsValue.Name = "lblIntersectsValue";
            this.lblIntersectsValue.Size = new System.Drawing.Size(53, 13);
            this.lblIntersectsValue.TabIndex = 1;
            this.lblIntersectsValue.Text = "Intersects";
            // 
            // lblLineStart
            // 
            this.lblLineStart.AutoSize = true;
            this.lblLineStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLineStart.Location = new System.Drawing.Point(11, 36);
            this.lblLineStart.Name = "lblLineStart";
            this.lblLineStart.Size = new System.Drawing.Size(62, 13);
            this.lblLineStart.TabIndex = 2;
            this.lblLineStart.Text = "Line Start";
            // 
            // lblLineStartValue
            // 
            this.lblLineStartValue.AutoSize = true;
            this.lblLineStartValue.Location = new System.Drawing.Point(69, 36);
            this.lblLineStartValue.Name = "lblLineStartValue";
            this.lblLineStartValue.Size = new System.Drawing.Size(52, 13);
            this.lblLineStartValue.TabIndex = 3;
            this.lblLineStartValue.Text = "Line Start";
            // 
            // lblLineEndValue
            // 
            this.lblLineEndValue.AutoSize = true;
            this.lblLineEndValue.Location = new System.Drawing.Point(69, 55);
            this.lblLineEndValue.Name = "lblLineEndValue";
            this.lblLineEndValue.Size = new System.Drawing.Size(49, 13);
            this.lblLineEndValue.TabIndex = 5;
            this.lblLineEndValue.Text = "Line End";
            // 
            // lblLineEnd
            // 
            this.lblLineEnd.AutoSize = true;
            this.lblLineEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLineEnd.Location = new System.Drawing.Point(11, 55);
            this.lblLineEnd.Name = "lblLineEnd";
            this.lblLineEnd.Size = new System.Drawing.Size(57, 13);
            this.lblLineEnd.TabIndex = 4;
            this.lblLineEnd.Text = "Line End";
            // 
            // lblTrimmedLineEndValue
            // 
            this.lblTrimmedLineEndValue.AutoSize = true;
            this.lblTrimmedLineEndValue.Location = new System.Drawing.Point(402, 55);
            this.lblTrimmedLineEndValue.Name = "lblTrimmedLineEndValue";
            this.lblTrimmedLineEndValue.Size = new System.Drawing.Size(122, 13);
            this.lblTrimmedLineEndValue.TabIndex = 9;
            this.lblTrimmedLineEndValue.Text = "Trimmed Line End Value";
            // 
            // lblTrimmedLineEnd
            // 
            this.lblTrimmedLineEnd.AutoSize = true;
            this.lblTrimmedLineEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrimmedLineEnd.Location = new System.Drawing.Point(283, 55);
            this.lblTrimmedLineEnd.Name = "lblTrimmedLineEnd";
            this.lblTrimmedLineEnd.Size = new System.Drawing.Size(108, 13);
            this.lblTrimmedLineEnd.TabIndex = 8;
            this.lblTrimmedLineEnd.Text = "Trimmed Line End";
            // 
            // lblTrimmedLineStartValue
            // 
            this.lblTrimmedLineStartValue.AutoSize = true;
            this.lblTrimmedLineStartValue.Location = new System.Drawing.Point(402, 36);
            this.lblTrimmedLineStartValue.Name = "lblTrimmedLineStartValue";
            this.lblTrimmedLineStartValue.Size = new System.Drawing.Size(125, 13);
            this.lblTrimmedLineStartValue.TabIndex = 7;
            this.lblTrimmedLineStartValue.Text = "Trimmed Line Start Value";
            // 
            // lblTrimmedLineStart
            // 
            this.lblTrimmedLineStart.AutoSize = true;
            this.lblTrimmedLineStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrimmedLineStart.Location = new System.Drawing.Point(283, 36);
            this.lblTrimmedLineStart.Name = "lblTrimmedLineStart";
            this.lblTrimmedLineStart.Size = new System.Drawing.Size(113, 13);
            this.lblTrimmedLineStart.TabIndex = 6;
            this.lblTrimmedLineStart.Text = "Trimmed Line Start";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Click two points on screen with mouse to draw line";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblIntersectsValue;
        private System.Windows.Forms.Label lblIntersects;
        private System.Windows.Forms.Label lblLineEndValue;
        private System.Windows.Forms.Label lblLineEnd;
        private System.Windows.Forms.Label lblLineStartValue;
        private System.Windows.Forms.Label lblLineStart;
        private System.Windows.Forms.Label lblTrimmedLineEndValue;
        private System.Windows.Forms.Label lblTrimmedLineEnd;
        private System.Windows.Forms.Label lblTrimmedLineStartValue;
        private System.Windows.Forms.Label lblTrimmedLineStart;
    }
}

