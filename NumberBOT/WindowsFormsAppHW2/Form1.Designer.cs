namespace WindowsFormsAppHW2
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
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnAddNum = new System.Windows.Forms.Button();
            this.lbGuessedNumbers = new System.Windows.Forms.TextBox();
            this.lbAddNumbers = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPointsY = new System.Windows.Forms.TextBox();
            this.tbPointsBot = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAddNum
            // 
            this.btnAddNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddNum.Location = new System.Drawing.Point(285, 12);
            this.btnAddNum.Name = "btnAddNum";
            this.btnAddNum.Size = new System.Drawing.Size(337, 49);
            this.btnAddNum.TabIndex = 2;
            this.btnAddNum.Text = "Guess a nuber";
            this.toolTip1.SetToolTip(this.btnAddNum, "Загадайте число от 1 до 2000 \r\nи введите количество попыток\r\nна отгадывание. Толь" +
        "ко играйте \r\nпо правилам.");
            this.btnAddNum.UseVisualStyleBackColor = true;
            this.btnAddNum.Click += new System.EventHandler(this.btnAddNum_Click);
            // 
            // lbGuessedNumbers
            // 
            this.lbGuessedNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbGuessedNumbers.Location = new System.Drawing.Point(12, 125);
            this.lbGuessedNumbers.Name = "lbGuessedNumbers";
            this.lbGuessedNumbers.Size = new System.Drawing.Size(877, 41);
            this.lbGuessedNumbers.TabIndex = 3;
            // 
            // lbAddNumbers
            // 
            this.lbAddNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbAddNumbers.Location = new System.Drawing.Point(12, 67);
            this.lbAddNumbers.Name = "lbAddNumbers";
            this.lbAddNumbers.Size = new System.Drawing.Size(877, 41);
            this.lbAddNumbers.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(362, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Твои очки: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(362, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Очки бота:";
            // 
            // tbPointsY
            // 
            this.tbPointsY.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPointsY.Location = new System.Drawing.Point(517, 187);
            this.tbPointsY.Name = "tbPointsY";
            this.tbPointsY.Size = new System.Drawing.Size(59, 35);
            this.tbPointsY.TabIndex = 7;
            // 
            // tbPointsBot
            // 
            this.tbPointsBot.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPointsBot.Location = new System.Drawing.Point(517, 217);
            this.tbPointsBot.Name = "tbPointsBot";
            this.tbPointsBot.Size = new System.Drawing.Size(59, 35);
            this.tbPointsBot.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 262);
            this.Controls.Add(this.tbPointsBot);
            this.Controls.Add(this.tbPointsY);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbAddNumbers);
            this.Controls.Add(this.lbGuessedNumbers);
            this.Controls.Add(this.btnAddNum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnAddNum;
        private System.Windows.Forms.TextBox lbGuessedNumbers;
        private System.Windows.Forms.TextBox lbAddNumbers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPointsY;
        private System.Windows.Forms.TextBox tbPointsBot;
    }
}

