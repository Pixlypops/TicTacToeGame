namespace TicTacToeGame
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
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.Location = new Point(159, 112);
            btn1.Name = "btn1";
            btn1.Size = new Size(59, 34);
            btn1.TabIndex = 0;
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn_Click;
            btn1.MouseLeave += btn_MouseLeave;
            btn1.MouseHover += btn_MouseHover;
            // 
            // btn2
            // 
            btn2.Location = new Point(224, 112);
            btn2.Name = "btn2";
            btn2.Size = new Size(57, 34);
            btn2.TabIndex = 1;
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn_Click;
            btn2.MouseLeave += btn_MouseLeave;
            btn2.MouseHover += btn_MouseHover;
            // 
            // btn3
            // 
            btn3.Location = new Point(287, 112);
            btn3.Name = "btn3";
            btn3.Size = new Size(58, 34);
            btn3.TabIndex = 2;
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn_Click;
            btn3.MouseLeave += btn_MouseLeave;
            btn3.MouseHover += btn_MouseHover;
            // 
            // btn4
            // 
            btn4.Location = new Point(159, 160);
            btn4.Name = "btn4";
            btn4.Size = new Size(59, 35);
            btn4.TabIndex = 3;
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn_Click;
            btn4.MouseLeave += btn_MouseLeave;
            btn4.MouseHover += btn_MouseHover;
            // 
            // btn5
            // 
            btn5.Location = new Point(224, 160);
            btn5.Name = "btn5";
            btn5.Size = new Size(57, 31);
            btn5.TabIndex = 4;
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn_Click;
            btn5.MouseLeave += btn_MouseLeave;
            btn5.MouseHover += btn_MouseHover;
            // 
            // btn6
            // 
            btn6.Location = new Point(287, 159);
            btn6.Name = "btn6";
            btn6.Size = new Size(58, 33);
            btn6.TabIndex = 5;
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn_Click;
            btn6.MouseLeave += btn_MouseLeave;
            btn6.MouseHover += btn_MouseHover;
            // 
            // btn7
            // 
            btn7.Location = new Point(159, 199);
            btn7.Name = "btn7";
            btn7.Size = new Size(59, 34);
            btn7.TabIndex = 6;
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn_Click;
            btn7.MouseLeave += btn_MouseLeave;
            btn7.MouseHover += btn_MouseHover;
            // 
            // btn8
            // 
            btn8.Location = new Point(224, 199);
            btn8.Name = "btn8";
            btn8.Size = new Size(57, 34);
            btn8.TabIndex = 7;
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn_Click;
            btn8.MouseLeave += btn_MouseLeave;
            btn8.MouseHover += btn_MouseHover;
            // 
            // btn9
            // 
            btn9.Location = new Point(287, 198);
            btn9.Name = "btn9";
            btn9.Size = new Size(58, 34);
            btn9.TabIndex = 8;
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn_Click;
            btn9.MouseLeave += btn_MouseLeave;
            btn9.MouseHover += btn_MouseHover;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(144, 249);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 9;
            label1.Text = "Player's Turn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(253, 249);
            label2.Name = "label2";
            label2.Size = new Size(14, 15);
            label2.TabIndex = 10;
            label2.Text = "X";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Aquamarine;
            ClientSize = new Size(500, 400);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Name = "Form1";
            Text = "Tic-Tac-Toe Game";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Label label1;
        private Label label2;
    }
}
