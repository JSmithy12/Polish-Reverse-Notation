﻿namespace RPN
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
            this.Txt_Input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Eval = new System.Windows.Forms.Button();
            this.Lbl_Output = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reverse Polish Notation";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Txt_Input
            // 
            this.Txt_Input.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Input.Location = new System.Drawing.Point(40, 102);
            this.Txt_Input.Name = "Txt_Input";
            this.Txt_Input.Size = new System.Drawing.Size(238, 22);
            this.Txt_Input.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter expression to evaluate";
            // 
            // Btn_Eval
            // 
            this.Btn_Eval.Location = new System.Drawing.Point(203, 130);
            this.Btn_Eval.Name = "Btn_Eval";
            this.Btn_Eval.Size = new System.Drawing.Size(75, 23);
            this.Btn_Eval.TabIndex = 3;
            this.Btn_Eval.Text = "Evaluate";
            this.Btn_Eval.UseVisualStyleBackColor = true;
            this.Btn_Eval.Click += new System.EventHandler(this.Btn_Eval_Click);
            // 
            // Lbl_Output
            // 
            this.Lbl_Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Output.Location = new System.Drawing.Point(12, 180);
            this.Lbl_Output.Name = "Lbl_Output";
            this.Lbl_Output.Size = new System.Drawing.Size(297, 30);
            this.Lbl_Output.TabIndex = 4;
            this.Lbl_Output.Text = "...";
            this.Lbl_Output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 231);
            this.Controls.Add(this.Lbl_Output);
            this.Controls.Add(this.Btn_Eval);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_Input);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_Eval;
        private System.Windows.Forms.Label Lbl_Output;
    }
}

