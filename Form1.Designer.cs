namespace OOPLAB2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonEL = new System.Windows.Forms.Button();
            this.buttonRE = new System.Windows.Forms.Button();
            this.buttonCI = new System.Windows.Forms.Button();
            this.buttonSQ = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(11, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1000, 500);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonEL
            // 
            this.buttonEL.Location = new System.Drawing.Point(2, 23);
            this.buttonEL.Name = "buttonEL";
            this.buttonEL.Size = new System.Drawing.Size(94, 29);
            this.buttonEL.TabIndex = 1;
            this.buttonEL.Text = "Эллипс";
            this.buttonEL.UseVisualStyleBackColor = true;
            this.buttonEL.Click += new System.EventHandler(this.buttonEL_Click);
            // 
            // buttonRE
            // 
            this.buttonRE.Location = new System.Drawing.Point(102, 23);
            this.buttonRE.Name = "buttonRE";
            this.buttonRE.Size = new System.Drawing.Size(134, 29);
            this.buttonRE.TabIndex = 2;
            this.buttonRE.Text = "Прямоугольник";
            this.buttonRE.UseVisualStyleBackColor = true;
            this.buttonRE.Click += new System.EventHandler(this.buttonRE_Click);
            // 
            // buttonCI
            // 
            this.buttonCI.Location = new System.Drawing.Point(342, 23);
            this.buttonCI.Name = "buttonCI";
            this.buttonCI.Size = new System.Drawing.Size(105, 29);
            this.buttonCI.TabIndex = 3;
            this.buttonCI.Text = "Окружность";
            this.buttonCI.UseVisualStyleBackColor = true;
            this.buttonCI.Click += new System.EventHandler(this.buttonCI_Click);
            // 
            // buttonSQ
            // 
            this.buttonSQ.Location = new System.Drawing.Point(242, 23);
            this.buttonSQ.Name = "buttonSQ";
            this.buttonSQ.Size = new System.Drawing.Size(94, 29);
            this.buttonSQ.TabIndex = 4;
            this.buttonSQ.Text = "Квадрат";
            this.buttonSQ.UseVisualStyleBackColor = true;
            this.buttonSQ.Click += new System.EventHandler(this.buttonSQ_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSQ);
            this.groupBox1.Controls.Add(this.buttonCI);
            this.groupBox1.Controls.Add(this.buttonRE);
            this.groupBox1.Controls.Add(this.buttonEL);
            this.groupBox1.Location = new System.Drawing.Point(12, 541);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 62);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Что нарисовать:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(933, 538);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "(1000;500)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "(0;0)";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(490, 564);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(135, 29);
            this.buttonClear.TabIndex = 8;
            this.buttonClear.Text = "Стереть все";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 629);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Button buttonEL;
        private Button buttonRE;
        private Button buttonCI;
        private Button buttonSQ;
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Button buttonClear;
    }
}