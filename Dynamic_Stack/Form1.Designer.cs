namespace Dynamic_Stack
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtNumber = new TextBox();
            groupBox1 = new GroupBox();
            btnClear = new Button();
            btnPeek = new Button();
            btnPop = new Button();
            btnPush = new Button();
            lblCount = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 59);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Number";
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(106, 56);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(100, 23);
            txtNumber.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(btnPeek);
            groupBox1.Controls.Add(btnPop);
            groupBox1.Controls.Add(btnPush);
            groupBox1.Controls.Add(txtNumber);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(45, 45);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(292, 197);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(148, 133);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(89, 29);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnPeek
            // 
            btnPeek.Location = new Point(148, 98);
            btnPeek.Name = "btnPeek";
            btnPeek.Size = new Size(89, 29);
            btnPeek.TabIndex = 4;
            btnPeek.Text = "Peek";
            btnPeek.UseVisualStyleBackColor = true;
            btnPeek.Click += btnPeek_Click;
            // 
            // btnPop
            // 
            btnPop.Location = new Point(38, 133);
            btnPop.Name = "btnPop";
            btnPop.Size = new Size(89, 29);
            btnPop.TabIndex = 3;
            btnPop.Text = "Pop";
            btnPop.UseVisualStyleBackColor = true;
            btnPop.Click += btnPop_Click;
            // 
            // btnPush
            // 
            btnPush.Location = new Point(38, 98);
            btnPush.Name = "btnPush";
            btnPush.Size = new Size(89, 29);
            btnPush.TabIndex = 2;
            btnPush.Text = "Push ";
            btnPush.UseVisualStyleBackColor = true;
            btnPush.Click += btnPush_Click;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCount.Location = new Point(361, 99);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(18, 20);
            lblCount.TabIndex = 3;
            lblCount.Text = "...";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(562, 290);
            Controls.Add(lblCount);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumber;
        private GroupBox groupBox1;
        private Button btnPush;
        private Label lblCount;
        private Button btnPeek;
        private Button btnPop;
        private Button btnClear;
    }
}
