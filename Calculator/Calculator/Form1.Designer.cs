﻿namespace Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            displayTextBox = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            equalBtn = new Button();
            deleteBtn = new Button();
            operation_lbl = new Label();
            clearBtn = new Button();
            clearEntryBtn = new Button();
            SuspendLayout();
            // 
            // displayTextBox
            // 
            displayTextBox.BackColor = SystemColors.ControlLightLight;
            displayTextBox.BorderStyle = BorderStyle.FixedSingle;
            displayTextBox.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            displayTextBox.Location = new Point(12, 12);
            displayTextBox.Multiline = true;
            displayTextBox.Name = "displayTextBox";
            displayTextBox.ReadOnly = true;
            displayTextBox.Size = new Size(383, 107);
            displayTextBox.TabIndex = 0;
            displayTextBox.Text = "0";
            displayTextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // button1
            // 
            button1.BackColor = Color.GhostWhite;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.Location = new Point(12, 139);
            button1.Name = "button1";
            button1.Size = new Size(64, 48);
            button1.TabIndex = 1;
            button1.Text = "7";
            button1.UseVisualStyleBackColor = false;
            button1.Click += digits_click;
            // 
            // button2
            // 
            button2.BackColor = Color.GhostWhite;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button2.Location = new Point(95, 139);
            button2.Name = "button2";
            button2.Size = new Size(64, 48);
            button2.TabIndex = 1;
            button2.Text = "8";
            button2.UseVisualStyleBackColor = false;
            button2.Click += digits_click;
            // 
            // button3
            // 
            button3.BackColor = Color.GhostWhite;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button3.Location = new Point(180, 139);
            button3.Name = "button3";
            button3.Size = new Size(64, 48);
            button3.TabIndex = 1;
            button3.Text = "9";
            button3.UseVisualStyleBackColor = false;
            button3.Click += digits_click;
            // 
            // button4
            // 
            button4.BackColor = Color.GhostWhite;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button4.Location = new Point(12, 204);
            button4.Name = "button4";
            button4.Size = new Size(64, 48);
            button4.TabIndex = 1;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += digits_click;
            // 
            // button5
            // 
            button5.BackColor = Color.GhostWhite;
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button5.Location = new Point(95, 204);
            button5.Name = "button5";
            button5.Size = new Size(64, 48);
            button5.TabIndex = 1;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += digits_click;
            // 
            // button6
            // 
            button6.BackColor = Color.GhostWhite;
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button6.Location = new Point(180, 204);
            button6.Name = "button6";
            button6.Size = new Size(64, 48);
            button6.TabIndex = 1;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = false;
            button6.Click += digits_click;
            // 
            // button7
            // 
            button7.BackColor = Color.GhostWhite;
            button7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button7.Location = new Point(12, 272);
            button7.Name = "button7";
            button7.Size = new Size(64, 48);
            button7.TabIndex = 1;
            button7.Text = "1";
            button7.UseVisualStyleBackColor = false;
            button7.Click += digits_click;
            // 
            // button8
            // 
            button8.BackColor = Color.GhostWhite;
            button8.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button8.Location = new Point(95, 272);
            button8.Name = "button8";
            button8.Size = new Size(64, 48);
            button8.TabIndex = 1;
            button8.Text = "2";
            button8.UseVisualStyleBackColor = false;
            button8.Click += digits_click;
            // 
            // button9
            // 
            button9.BackColor = Color.GhostWhite;
            button9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button9.Location = new Point(180, 272);
            button9.Name = "button9";
            button9.Size = new Size(64, 48);
            button9.TabIndex = 1;
            button9.Text = "3";
            button9.UseVisualStyleBackColor = false;
            button9.Click += digits_click;
            // 
            // button10
            // 
            button10.BackColor = Color.GhostWhite;
            button10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button10.Location = new Point(12, 339);
            button10.Name = "button10";
            button10.Size = new Size(64, 48);
            button10.TabIndex = 1;
            button10.Text = ".";
            button10.UseVisualStyleBackColor = false;
            button10.Click += digits_click;
            // 
            // button11
            // 
            button11.BackColor = Color.GhostWhite;
            button11.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button11.Location = new Point(95, 339);
            button11.Name = "button11";
            button11.Size = new Size(64, 48);
            button11.TabIndex = 1;
            button11.Text = "0";
            button11.UseVisualStyleBackColor = false;
            button11.Click += digits_click;
            // 
            // button12
            // 
            button12.BackColor = Color.GhostWhite;
            button12.Font = new Font("Microsoft YaHei UI", 12F);
            button12.Location = new Point(260, 141);
            button12.Name = "button12";
            button12.Size = new Size(64, 48);
            button12.TabIndex = 1;
            button12.Text = "+";
            button12.UseVisualStyleBackColor = false;
            button12.Click += operator_click;
            // 
            // button13
            // 
            button13.BackColor = Color.GhostWhite;
            button13.Font = new Font("Microsoft YaHei UI", 12F);
            button13.Location = new Point(260, 206);
            button13.Name = "button13";
            button13.Size = new Size(64, 48);
            button13.TabIndex = 1;
            button13.Text = "x";
            button13.UseVisualStyleBackColor = false;
            button13.Click += operator_click;
            // 
            // button14
            // 
            button14.BackColor = Color.GhostWhite;
            button14.Font = new Font("Microsoft YaHei UI", 12F);
            button14.Location = new Point(330, 141);
            button14.Name = "button14";
            button14.Size = new Size(64, 48);
            button14.TabIndex = 1;
            button14.Text = "-";
            button14.UseVisualStyleBackColor = false;
            button14.Click += operator_click;
            // 
            // button15
            // 
            button15.BackColor = Color.GhostWhite;
            button15.Font = new Font("Microsoft YaHei UI", 12F);
            button15.Location = new Point(330, 206);
            button15.Name = "button15";
            button15.Size = new Size(64, 48);
            button15.TabIndex = 1;
            button15.Text = "/";
            button15.UseVisualStyleBackColor = false;
            button15.Click += operator_click;
            // 
            // equalBtn
            // 
            equalBtn.BackColor = Color.GhostWhite;
            equalBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            equalBtn.Location = new Point(180, 339);
            equalBtn.Name = "equalBtn";
            equalBtn.Size = new Size(64, 48);
            equalBtn.TabIndex = 1;
            equalBtn.Text = "=";
            equalBtn.UseVisualStyleBackColor = false;
            equalBtn.Click += equalBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.GhostWhite;
            deleteBtn.Font = new Font("Microsoft YaHei UI", 12F);
            deleteBtn.Image = (Image)resources.GetObject("deleteBtn.Image");
            deleteBtn.Location = new Point(330, 272);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(64, 48);
            deleteBtn.TabIndex = 1;
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // operation_lbl
            // 
            operation_lbl.AutoSize = true;
            operation_lbl.Location = new Point(16, 15);
            operation_lbl.Name = "operation_lbl";
            operation_lbl.Size = new Size(0, 20);
            operation_lbl.TabIndex = 2;
            // 
            // clearBtn
            // 
            clearBtn.Location = new Point(260, 339);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(64, 48);
            clearBtn.TabIndex = 3;
            clearBtn.Text = "C";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // clearEntryBtn
            // 
            clearEntryBtn.Location = new Point(330, 339);
            clearEntryBtn.Name = "clearEntryBtn";
            clearEntryBtn.Size = new Size(64, 48);
            clearEntryBtn.TabIndex = 3;
            clearEntryBtn.Text = "CE";
            clearEntryBtn.UseVisualStyleBackColor = true;
            clearEntryBtn.Click += clearEntryBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(406, 429);
            Controls.Add(clearEntryBtn);
            Controls.Add(clearBtn);
            Controls.Add(operation_lbl);
            Controls.Add(equalBtn);
            Controls.Add(displayTextBox);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button1);
            Controls.Add(button13);
            Controls.Add(button15);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(deleteBtn);
            Controls.Add(button14);
            Controls.Add(button12);
            Controls.Add(button7);
            Controls.Add(button11);
            Controls.Add(button6);
            Controls.Add(button10);
            Controls.Add(button2);
            Controls.Add(button3);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox displayTextBox;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button equalBtn;
        private Button deleteBtn;
        private Label operation_lbl;
        private Button clearBtn;
        private Button clearEntryBtn;
    }
}
