namespace PressureConverter
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
            textBoxPa = new TextBox();
            textBoxPsi = new TextBox();
            textBoxBar = new TextBox();
            buttonCalculate = new Button();
            buttonClear = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 27);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 0;
            label1.Text = "Paine kPa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(159, 27);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 1;
            label2.Text = "Paine psi";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(281, 27);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 2;
            label3.Text = "Paine bar";
            // 
            // textBoxPa
            // 
            textBoxPa.Location = new Point(41, 45);
            textBoxPa.Name = "textBoxPa";
            textBoxPa.Size = new Size(72, 23);
            textBoxPa.TabIndex = 3;
            textBoxPa.Leave += textBoxPa_Leave;
            // 
            // textBoxPsi
            // 
            textBoxPsi.Enabled = false;
            textBoxPsi.Location = new Point(159, 45);
            textBoxPsi.Name = "textBoxPsi";
            textBoxPsi.Size = new Size(68, 23);
            textBoxPsi.TabIndex = 4;
            // 
            // textBoxBar
            // 
            textBoxBar.Enabled = false;
            textBoxBar.Location = new Point(281, 45);
            textBoxBar.Name = "textBoxBar";
            textBoxBar.Size = new Size(74, 23);
            textBoxBar.TabIndex = 5;
            // 
            // buttonCalculate
            // 
            buttonCalculate.Enabled = false;
            buttonCalculate.Location = new Point(280, 94);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(75, 23);
            buttonCalculate.TabIndex = 6;
            buttonCalculate.Text = "Laske";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += button1_Click;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(159, 94);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(68, 23);
            buttonClear.TabIndex = 7;
            buttonClear.Text = "Tyhjennä";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 153);
            Controls.Add(buttonClear);
            Controls.Add(buttonCalculate);
            Controls.Add(textBoxBar);
            Controls.Add(textBoxPsi);
            Controls.Add(textBoxPa);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxPa;
        private TextBox textBoxPsi;
        private TextBox textBoxBar;
        private Button buttonCalculate;
        private Button buttonClear;
    }
}
