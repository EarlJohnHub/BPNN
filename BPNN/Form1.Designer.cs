namespace BPNN
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
            this.first_input = new System.Windows.Forms.TextBox();
            this.second_input = new System.Windows.Forms.TextBox();
            this.output_box = new System.Windows.Forms.TextBox();
            this.createbpnn = new System.Windows.Forms.Button();
            this.trainnn = new System.Windows.Forms.Button();
            this.test = new System.Windows.Forms.Button();
            this.third_input = new System.Windows.Forms.TextBox();
            this.fourth_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // first_input
            // 
            this.first_input.Location = new System.Drawing.Point(75, 110);
            this.first_input.Name = "first_input";
            this.first_input.Size = new System.Drawing.Size(202, 22);
            this.first_input.TabIndex = 0;
            // 
            // second_input
            // 
            this.second_input.Location = new System.Drawing.Point(75, 161);
            this.second_input.Name = "second_input";
            this.second_input.Size = new System.Drawing.Size(202, 22);
            this.second_input.TabIndex = 1;
            // 
            // output_box
            // 
            this.output_box.Location = new System.Drawing.Point(523, 179);
            this.output_box.Name = "output_box";
            this.output_box.Size = new System.Drawing.Size(217, 22);
            this.output_box.TabIndex = 2;
            // 
            // createbpnn
            // 
            this.createbpnn.Location = new System.Drawing.Point(88, 311);
            this.createbpnn.Name = "createbpnn";
            this.createbpnn.Size = new System.Drawing.Size(156, 53);
            this.createbpnn.TabIndex = 3;
            this.createbpnn.Text = "Create BPNN";
            this.createbpnn.UseVisualStyleBackColor = true;
            this.createbpnn.Click += new System.EventHandler(this.create_bpnn_Click);
            // 
            // trainnn
            // 
            this.trainnn.Location = new System.Drawing.Point(323, 311);
            this.trainnn.Name = "trainnn";
            this.trainnn.Size = new System.Drawing.Size(156, 53);
            this.trainnn.TabIndex = 4;
            this.trainnn.Text = "Train the Neural Net";
            this.trainnn.UseVisualStyleBackColor = true;
            this.trainnn.Click += new System.EventHandler(this.train_nn_Click);
            // 
            // test
            // 
            this.test.Location = new System.Drawing.Point(554, 311);
            this.test.Name = "test";
            this.test.Size = new System.Drawing.Size(156, 53);
            this.test.TabIndex = 5;
            this.test.Text = "Test";
            this.test.UseVisualStyleBackColor = true;
            this.test.Click += new System.EventHandler(this.test_Click);
            // 
            // third_input
            // 
            this.third_input.Location = new System.Drawing.Point(75, 213);
            this.third_input.Name = "third_input";
            this.third_input.Size = new System.Drawing.Size(202, 22);
            this.third_input.TabIndex = 6;
            // 
            // fourth_input
            // 
            this.fourth_input.Location = new System.Drawing.Point(75, 269);
            this.fourth_input.Name = "fourth_input";
            this.fourth_input.Size = new System.Drawing.Size(202, 22);
            this.fourth_input.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Input 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Input 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Input 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Input 4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(520, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Input 1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fourth_input);
            this.Controls.Add(this.third_input);
            this.Controls.Add(this.test);
            this.Controls.Add(this.trainnn);
            this.Controls.Add(this.createbpnn);
            this.Controls.Add(this.output_box);
            this.Controls.Add(this.second_input);
            this.Controls.Add(this.first_input);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox first_input;
        private System.Windows.Forms.TextBox second_input;
        private System.Windows.Forms.TextBox output_box;
        private System.Windows.Forms.Button createbpnn;
        private System.Windows.Forms.Button trainnn;
        private System.Windows.Forms.Button test;
        private System.Windows.Forms.TextBox third_input;
        private System.Windows.Forms.TextBox fourth_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

