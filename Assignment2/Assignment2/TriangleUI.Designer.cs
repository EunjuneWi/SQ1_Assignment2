namespace Assignment2
{
    partial class TriangleUI
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.side1_1 = new System.Windows.Forms.TextBox();
            this.side1_2 = new System.Windows.Forms.TextBox();
            this.Result1 = new System.Windows.Forms.Label();
            this.Calculate1 = new System.Windows.Forms.Button();
            this.side2_1 = new System.Windows.Forms.TextBox();
            this.side2_2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.answer2 = new System.Windows.Forms.Label();
            this.angle1 = new System.Windows.Forms.TextBox();
            this.angle2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.answer3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(763, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "1. Enter length of two right triangle side to get another one\'s length.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(585, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "2. Enter length of two right triangle side to get area.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(749, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "3. Enter size of two angles from triangle to get another angle size.";
            // 
            // side1_1
            // 
            this.side1_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.side1_1.Location = new System.Drawing.Point(45, 69);
            this.side1_1.Name = "side1_1";
            this.side1_1.Size = new System.Drawing.Size(134, 36);
            this.side1_1.TabIndex = 3;
            // 
            // side1_2
            // 
            this.side1_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.side1_2.Location = new System.Drawing.Point(216, 69);
            this.side1_2.Name = "side1_2";
            this.side1_2.Size = new System.Drawing.Size(134, 36);
            this.side1_2.TabIndex = 4;
            // 
            // Result1
            // 
            this.Result1.AutoSize = true;
            this.Result1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result1.Location = new System.Drawing.Point(68, 118);
            this.Result1.Name = "Result1";
            this.Result1.Size = new System.Drawing.Size(111, 29);
            this.Result1.TabIndex = 5;
            this.Result1.Text = "Answer: ";
            // 
            // Calculate1
            // 
            this.Calculate1.BackColor = System.Drawing.SystemColors.Info;
            this.Calculate1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculate1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Calculate1.Location = new System.Drawing.Point(383, 68);
            this.Calculate1.Name = "Calculate1";
            this.Calculate1.Size = new System.Drawing.Size(192, 36);
            this.Calculate1.TabIndex = 6;
            this.Calculate1.Text = "Calculate";
            this.Calculate1.UseVisualStyleBackColor = false;
            this.Calculate1.Click += new System.EventHandler(this.Calculate1_Click);
            // 
            // side2_1
            // 
            this.side2_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.side2_1.Location = new System.Drawing.Point(45, 202);
            this.side2_1.Name = "side2_1";
            this.side2_1.Size = new System.Drawing.Size(134, 36);
            this.side2_1.TabIndex = 7;
            // 
            // side2_2
            // 
            this.side2_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.side2_2.Location = new System.Drawing.Point(216, 202);
            this.side2_2.Name = "side2_2";
            this.side2_2.Size = new System.Drawing.Size(134, 36);
            this.side2_2.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(383, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 36);
            this.button1.TabIndex = 9;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // answer2
            // 
            this.answer2.AutoSize = true;
            this.answer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer2.Location = new System.Drawing.Point(68, 257);
            this.answer2.Name = "answer2";
            this.answer2.Size = new System.Drawing.Size(111, 29);
            this.answer2.TabIndex = 10;
            this.answer2.Text = "Answer: ";
            // 
            // angle1
            // 
            this.angle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.angle1.Location = new System.Drawing.Point(45, 349);
            this.angle1.Name = "angle1";
            this.angle1.Size = new System.Drawing.Size(134, 36);
            this.angle1.TabIndex = 11;
            // 
            // angle2
            // 
            this.angle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.angle2.Location = new System.Drawing.Point(216, 349);
            this.angle2.Name = "angle2";
            this.angle2.Size = new System.Drawing.Size(134, 36);
            this.angle2.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Info;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(383, 349);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 36);
            this.button2.TabIndex = 13;
            this.button2.Text = "Calculate";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // answer3
            // 
            this.answer3.AutoSize = true;
            this.answer3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer3.Location = new System.Drawing.Point(68, 401);
            this.answer3.Name = "answer3";
            this.answer3.Size = new System.Drawing.Size(111, 29);
            this.answer3.TabIndex = 14;
            this.answer3.Text = "Answer: ";
            // 
            // TriangleUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.answer3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.angle2);
            this.Controls.Add(this.angle1);
            this.Controls.Add(this.answer2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.side2_2);
            this.Controls.Add(this.side2_1);
            this.Controls.Add(this.Calculate1);
            this.Controls.Add(this.Result1);
            this.Controls.Add(this.side1_2);
            this.Controls.Add(this.side1_1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TriangleUI";
            this.Text = "TriangleUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox side1_1;
        private System.Windows.Forms.TextBox side1_2;
        private System.Windows.Forms.Label Result1;
        private System.Windows.Forms.Button Calculate1;
        private System.Windows.Forms.TextBox side2_1;
        private System.Windows.Forms.TextBox side2_2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label answer2;
        private System.Windows.Forms.TextBox angle1;
        private System.Windows.Forms.TextBox angle2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label answer3;
    }
}