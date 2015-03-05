using System;
namespace Lottoprogram
{
    partial class LottoForm
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
            this.label_yourLottoRow = new System.Windows.Forms.Label();
            this.textBox_lottoRow1 = new System.Windows.Forms.TextBox();
            this.textBox_lottoRow2 = new System.Windows.Forms.TextBox();
            this.textBox_lottoRow3 = new System.Windows.Forms.TextBox();
            this.textBox_lottoRow4 = new System.Windows.Forms.TextBox();
            this.textBox_lottoRow5 = new System.Windows.Forms.TextBox();
            this.textBox_lottoRow6 = new System.Windows.Forms.TextBox();
            this.textBox_lottoRow7 = new System.Windows.Forms.TextBox();
            this.label_numDraws = new System.Windows.Forms.Label();
            this.textBox_numDraws = new System.Windows.Forms.TextBox();
            this.button_startLotto = new System.Windows.Forms.Button();
            this.label_fiveRight = new System.Windows.Forms.Label();
            this.label_fiveRightAnswer = new System.Windows.Forms.Label();
            this.label_sixRight = new System.Windows.Forms.Label();
            this.label_sixRightAnswer = new System.Windows.Forms.Label();
            this.label_sevenRight = new System.Windows.Forms.Label();
            this.label_sevenRightAnswer = new System.Windows.Forms.Label();
            this.label_error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_yourLottoRow
            // 
            this.label_yourLottoRow.AutoSize = true;
            this.label_yourLottoRow.Location = new System.Drawing.Point(10, 20);
            this.label_yourLottoRow.Name = "label_yourLottoRow";
            this.label_yourLottoRow.Size = new System.Drawing.Size(60, 20);
            this.label_yourLottoRow.TabIndex = 0;
            this.label_yourLottoRow.Text = "Your row:";
            // 
            // textBox_lottoRow1
            // 
            this.textBox_lottoRow1.Location = new System.Drawing.Point(80, 20);
            this.textBox_lottoRow1.Name = "textBox_lottoRow1";
            this.textBox_lottoRow1.Size = new System.Drawing.Size(50, 20);
            this.textBox_lottoRow1.TabIndex = 1;
            this.textBox_lottoRow1.Text = "1";
            // 
            // textBox_lottoRow2
            // 
            this.textBox_lottoRow2.Location = new System.Drawing.Point(135, 20);
            this.textBox_lottoRow2.Name = "textBox_lottoRow2";
            this.textBox_lottoRow2.Size = new System.Drawing.Size(50, 20);
            this.textBox_lottoRow2.TabIndex = 2;
            this.textBox_lottoRow2.Text = "2";
            // 
            // textBox_lottoRow3
            // 
            this.textBox_lottoRow3.Location = new System.Drawing.Point(190, 20);
            this.textBox_lottoRow3.Name = "textBox_lottoRow3";
            this.textBox_lottoRow3.Size = new System.Drawing.Size(50, 20);
            this.textBox_lottoRow3.TabIndex = 3;
            this.textBox_lottoRow3.Text = "3";
            // 
            // textBox_lottoRow4
            // 
            this.textBox_lottoRow4.Location = new System.Drawing.Point(245, 20);
            this.textBox_lottoRow4.Name = "textBox_lottoRow4";
            this.textBox_lottoRow4.Size = new System.Drawing.Size(50, 20);
            this.textBox_lottoRow4.TabIndex = 4;
            this.textBox_lottoRow4.Text = "4";
            // 
            // textBox_lottoRow5
            // 
            this.textBox_lottoRow5.Location = new System.Drawing.Point(300, 20);
            this.textBox_lottoRow5.Name = "textBox_lottoRow5";
            this.textBox_lottoRow5.Size = new System.Drawing.Size(50, 20);
            this.textBox_lottoRow5.TabIndex = 5;
            this.textBox_lottoRow5.Text = "5";
            // 
            // textBox_lottoRow6
            // 
            this.textBox_lottoRow6.Location = new System.Drawing.Point(355, 20);
            this.textBox_lottoRow6.Name = "textBox_lottoRow6";
            this.textBox_lottoRow6.Size = new System.Drawing.Size(50, 20);
            this.textBox_lottoRow6.TabIndex = 6;
            this.textBox_lottoRow6.Text = "6";
            // 
            // textBox_lottoRow7
            // 
            this.textBox_lottoRow7.Location = new System.Drawing.Point(410, 20);
            this.textBox_lottoRow7.Name = "textBox_lottoRow7";
            this.textBox_lottoRow7.Size = new System.Drawing.Size(50, 20);
            this.textBox_lottoRow7.TabIndex = 7;
            this.textBox_lottoRow7.Text = "7";
            // 
            // label_numDraws
            // 
            this.label_numDraws.AutoSize = true;
            this.label_numDraws.Location = new System.Drawing.Point(69, 69);
            this.label_numDraws.Name = "label_antalDrag";
            this.label_numDraws.Size = new System.Drawing.Size(89, 13);
            this.label_numDraws.TabIndex = 7;
            this.label_numDraws.Text = "number of draws:";
            // textBox_numDraws
            // 
            this.textBox_numDraws.Location = new System.Drawing.Point(185, 66);
            this.textBox_numDraws.Name = "textBox_antalDrag";
            this.textBox_numDraws.Size = new System.Drawing.Size(100, 20);
            this.textBox_numDraws.TabIndex = 8;
            this.textBox_numDraws.Text = "99";
            // 
            // button_startLotto
            // 
            this.button_startLotto.Location = new System.Drawing.Point(305, 63);
            this.button_startLotto.Name = "button_startaLotto";
            this.button_startLotto.Size = new System.Drawing.Size(109, 22);
            this.button_startLotto.TabIndex = 9;
            this.button_startLotto.Text = "Start Lotto!";
            this.button_startLotto.UseVisualStyleBackColor = true;
            button_startLotto.Click += new EventHandler(button_Click);
            // 
            // label_fiveRight
            // 
            this.label_fiveRight.AutoSize = true;
            this.label_fiveRight.Location = new System.Drawing.Point(40, 120);
            this.label_fiveRight.Name = "label_fiveRight";
            this.label_fiveRight.Size = new System.Drawing.Size(40, 20);
            this.label_fiveRight.TabIndex = 10;
            this.label_fiveRight.Text = "5 right:";
            // 
            // label_fiveRightAnswer
            // 
            this.label_fiveRightAnswer.AutoSize = true;
            this.label_fiveRightAnswer.Location = new System.Drawing.Point(80, 120);
            this.label_fiveRightAnswer.Name = "label_fiveRightAnswer";
            this.label_fiveRightAnswer.Size = new System.Drawing.Size(40, 20);
            this.label_fiveRightAnswer.TabIndex = 11;
            this.label_fiveRightAnswer.Text = "";
            // 
            // label_sixRightAnswer
            // 
            this.label_sixRightAnswer.AutoSize = true;
            this.label_sixRightAnswer.Location = new System.Drawing.Point(210, 120);
            this.label_sixRightAnswer.Name = "label_sixRightAnswer";
            this.label_sixRightAnswer.Size = new System.Drawing.Size(40, 20);
            this.label_sixRightAnswer.TabIndex = 12;
            this.label_sixRightAnswer.Text = "";
            // 
            // label_sevenRightAnswer
            // 
            this.label_sevenRightAnswer.AutoSize = true;
            this.label_sevenRightAnswer.Location = new System.Drawing.Point(338, 120);
            this.label_sevenRightAnswer.Name = "label_sevenRightAnswer";
            this.label_sevenRightAnswer.Size = new System.Drawing.Size(40, 20);
            this.label_sevenRightAnswer.TabIndex = 13;
            this.label_sevenRightAnswer.Text = "";
            // 
            // label_sixRight
            // 
            this.label_sixRight.AutoSize = true;
            this.label_sixRight.Location = new System.Drawing.Point(161, 120);
            this.label_sixRight.Name = "label_sixRight";
            this.label_sixRight.Size = new System.Drawing.Size(40, 20);
            this.label_sixRight.TabIndex = 14;
            this.label_sixRight.Text = "6 right:";
            // 
            // label_sevenRight
            // 
            this.label_sevenRight.AutoSize = true;
            this.label_sevenRight.Location = new System.Drawing.Point(296, 120);
            this.label_sevenRight.Name = "label_sevenRight";
            this.label_sevenRight.Size = new System.Drawing.Size(40, 20);
            this.label_sevenRight.TabIndex = 15;
            this.label_sevenRight.Text = "7 right:";
            //
            // label_error
            //
            this.label_error.AutoSize = true;
            this.label_error.Location = new System.Drawing.Point(296, 140);
            this.label_error.Name = "label_error";
            this.label_error.Size = new System.Drawing.Size(40, 20);
            this.label_error.TabIndex = 15;
            this.label_error.Text = "";
            this.label_error.ForeColor = System.Drawing.Color.Red;
            // 
            // LottoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 200);
            this.Controls.Add(this.label_sevenRight);
            this.Controls.Add(this.label_sixRight);
            this.Controls.Add(this.label_sevenRightAnswer);
            this.Controls.Add(this.label_sixRightAnswer);
            this.Controls.Add(this.label_fiveRightAnswer);
            this.Controls.Add(this.label_fiveRight);
            this.Controls.Add(this.button_startLotto);
            this.Controls.Add(this.textBox_numDraws);
            this.Controls.Add(this.label_numDraws);
            this.Controls.Add(this.textBox_lottoRow7);
            this.Controls.Add(this.textBox_lottoRow6);
            this.Controls.Add(this.textBox_lottoRow5);
            this.Controls.Add(this.textBox_lottoRow4);
            this.Controls.Add(this.textBox_lottoRow3);
            this.Controls.Add(this.textBox_lottoRow2);
            this.Controls.Add(this.textBox_lottoRow1);
            this.Controls.Add(this.label_yourLottoRow);
            this.Controls.Add(this.label_error);
            this.Name = "LottoForm";
            this.Text = "Lotto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_yourLottoRow;
        private System.Windows.Forms.TextBox textBox_lottoRow1;
        private System.Windows.Forms.TextBox textBox_lottoRow2;
        private System.Windows.Forms.TextBox textBox_lottoRow3;
        private System.Windows.Forms.TextBox textBox_lottoRow4;
        private System.Windows.Forms.TextBox textBox_lottoRow5;
        private System.Windows.Forms.TextBox textBox_lottoRow6;
        private System.Windows.Forms.TextBox textBox_lottoRow7;
        private System.Windows.Forms.Label label_numDraws;
        private System.Windows.Forms.TextBox textBox_numDraws;
        private System.Windows.Forms.Button button_startLotto;
        private System.Windows.Forms.Label label_fiveRight;
        private System.Windows.Forms.Label label_fiveRightAnswer;
        private System.Windows.Forms.Label label_sixRight;
        private System.Windows.Forms.Label label_sixRightAnswer;
        private System.Windows.Forms.Label label_sevenRight;
        private System.Windows.Forms.Label label_sevenRightAnswer;
        private System.Windows.Forms.Label label_error;


        internal Logic logic { get; set; }

    }
        

}

