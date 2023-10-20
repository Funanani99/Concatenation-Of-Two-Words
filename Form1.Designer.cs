namespace Concatenation_Of_Two_Words
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
            this.WordTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Word1ComboBox = new System.Windows.Forms.ComboBox();
            this.Word2ComboBox = new System.Windows.Forms.ComboBox();
            this.Remove1RadioButton = new System.Windows.Forms.RadioButton();
            this.Remove2RadioButton = new System.Windows.Forms.RadioButton();
            this.btnConcatenate = new System.Windows.Forms.Button();
            this.Result = new System.Windows.Forms.TextBox();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a new word:";
            // 
            // WordTextBox
            // 
            this.WordTextBox.Location = new System.Drawing.Point(254, 53);
            this.WordTextBox.Name = "WordTextBox";
            this.WordTextBox.Size = new System.Drawing.Size(236, 26);
            this.WordTextBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(286, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add word";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(331, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "OR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Select a word:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(422, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Select another word:";
            // 
            // Word1ComboBox
            // 
            this.Word1ComboBox.FormattingEnabled = true;
            this.Word1ComboBox.Location = new System.Drawing.Point(12, 277);
            this.Word1ComboBox.Name = "Word1ComboBox";
            this.Word1ComboBox.Size = new System.Drawing.Size(251, 28);
            this.Word1ComboBox.TabIndex = 6;
            this.Word1ComboBox.Text = "--Words--";
            // 
            // Word2ComboBox
            // 
            this.Word2ComboBox.FormattingEnabled = true;
            this.Word2ComboBox.Location = new System.Drawing.Point(405, 277);
            this.Word2ComboBox.Name = "Word2ComboBox";
            this.Word2ComboBox.Size = new System.Drawing.Size(264, 28);
            this.Word2ComboBox.TabIndex = 7;
            this.Word2ComboBox.Text = "--Words--";
            // 
            // Remove1RadioButton
            // 
            this.Remove1RadioButton.AutoSize = true;
            this.Remove1RadioButton.Location = new System.Drawing.Point(12, 326);
            this.Remove1RadioButton.Name = "Remove1RadioButton";
            this.Remove1RadioButton.Size = new System.Drawing.Size(93, 24);
            this.Remove1RadioButton.TabIndex = 8;
            this.Remove1RadioButton.TabStop = true;
            this.Remove1RadioButton.Text = "Remove";
            this.Remove1RadioButton.UseVisualStyleBackColor = true;
            this.Remove1RadioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Remove2RadioButton
            // 
            this.Remove2RadioButton.AutoSize = true;
            this.Remove2RadioButton.Location = new System.Drawing.Point(405, 326);
            this.Remove2RadioButton.Name = "Remove2RadioButton";
            this.Remove2RadioButton.Size = new System.Drawing.Size(93, 24);
            this.Remove2RadioButton.TabIndex = 9;
            this.Remove2RadioButton.TabStop = true;
            this.Remove2RadioButton.Text = "Remove";
            this.Remove2RadioButton.UseVisualStyleBackColor = true;
            this.Remove2RadioButton.CheckedChanged += new System.EventHandler(this.Remove2RadioButton_CheckedChanged);
            // 
            // btnConcatenate
            // 
            this.btnConcatenate.Location = new System.Drawing.Point(275, 403);
            this.btnConcatenate.Name = "btnConcatenate";
            this.btnConcatenate.Size = new System.Drawing.Size(153, 37);
            this.btnConcatenate.TabIndex = 10;
            this.btnConcatenate.Text = "Concatenate";
            this.btnConcatenate.UseVisualStyleBackColor = true;
            this.btnConcatenate.Click += new System.EventHandler(this.button2_Click);
            // 
            // Result
            // 
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Result.ForeColor = System.Drawing.Color.White;
            this.Result.Location = new System.Drawing.Point(16, 457);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(668, 53);
            this.Result.TabIndex = 11;
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.BackColor = System.Drawing.Color.White;
            this.ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultLabel.Location = new System.Drawing.Point(288, 460);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(0, 46);
            this.ResultLabel.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(236, 460);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 46);
            this.label5.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(696, 522);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.btnConcatenate);
            this.Controls.Add(this.Remove2RadioButton);
            this.Controls.Add(this.Remove1RadioButton);
            this.Controls.Add(this.Word2ComboBox);
            this.Controls.Add(this.Word1ComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.WordTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Words";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox WordTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox Word1ComboBox;
        private System.Windows.Forms.ComboBox Word2ComboBox;
        private System.Windows.Forms.RadioButton Remove1RadioButton;
        private System.Windows.Forms.RadioButton Remove2RadioButton;
        private System.Windows.Forms.Button btnConcatenate;
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Label label5;
    }
}

