namespace Tutorial_4_4
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
            label2 = new Label();
            label3 = new Label();
            distanceTextBox = new TextBox();
            gasTextBox = new TextBox();
            averageLabel = new Label();
            calculatbutton = new Button();
            exitbutton = new Button();
            loglistBox = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(78, 58);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 0;
            label1.Text = "輸入行駛里程數";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label2.Location = new Point(78, 189);
            label2.Name = "label2";
            label2.Size = new Size(121, 20);
            label2.TabIndex = 1;
            label2.Text = "消耗油量公升數";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label3.Location = new Point(94, 124);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 2;
            label3.Text = "你的平均油耗";
            // 
            // distanceTextBox
            // 
            distanceTextBox.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            distanceTextBox.Location = new Point(205, 55);
            distanceTextBox.Name = "distanceTextBox";
            distanceTextBox.Size = new Size(121, 28);
            distanceTextBox.TabIndex = 3;
            // 
            // gasTextBox
            // 
            gasTextBox.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            gasTextBox.Location = new Point(205, 186);
            gasTextBox.Name = "gasTextBox";
            gasTextBox.Size = new Size(121, 28);
            gasTextBox.TabIndex = 4;
            // 
            // averageLabel
            // 
            averageLabel.BorderStyle = BorderStyle.Fixed3D;
            averageLabel.Location = new Point(205, 121);
            averageLabel.Name = "averageLabel";
            averageLabel.Size = new Size(121, 23);
            averageLabel.TabIndex = 6;
            averageLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // calculatbutton
            // 
            calculatbutton.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            calculatbutton.Location = new Point(89, 248);
            calculatbutton.Name = "calculatbutton";
            calculatbutton.Size = new Size(78, 39);
            calculatbutton.TabIndex = 7;
            calculatbutton.Text = "計算";
            calculatbutton.UseVisualStyleBackColor = true;
            calculatbutton.Click += calculatbutton_Click;
            // 
            // exitbutton
            // 
            exitbutton.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            exitbutton.Location = new Point(248, 248);
            exitbutton.Name = "exitbutton";
            exitbutton.Size = new Size(78, 39);
            exitbutton.TabIndex = 8;
            exitbutton.Text = "離開";
            exitbutton.UseVisualStyleBackColor = true;
            exitbutton.Click += exitbutton_Click;
            // 
            // loglistBox
            // 
            loglistBox.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            loglistBox.FormattingEnabled = true;
            loglistBox.ItemHeight = 20;
            loglistBox.Location = new Point(383, 55);
            loglistBox.Name = "loglistBox";
            loglistBox.Size = new Size(205, 204);
            loglistBox.TabIndex = 9;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 136);
            button1.Location = new Point(426, 283);
            button1.Name = "button1";
            button1.Size = new Size(107, 39);
            button1.TabIndex = 10;
            button1.Text = "總平均油耗";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(loglistBox);
            Controls.Add(exitbutton);
            Controls.Add(calculatbutton);
            Controls.Add(averageLabel);
            Controls.Add(gasTextBox);
            Controls.Add(distanceTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox distanceTextBox;
        private TextBox gasTextBox;
        private Label averageLabel;
        private Button calculatbutton;
        private Button exitbutton;
        private ListBox loglistBox;
        private Button button1;
    }
}
