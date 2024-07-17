namespace WinFormsApp1;

partial class Form1 {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
        label1 = new Label();
        button1 = new Button();
        textBox1 = new TextBox();
        button2 = new Button();
        button3 = new Button();
        numericUpDown1 = new NumericUpDown();
        numericUpDown2 = new NumericUpDown();
        button4 = new Button();
        ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
        this.SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(0, 0);
        label1.Name = "label1";
        label1.Size = new Size(59, 25);
        label1.TabIndex = 0;
        label1.Text = "label1";
        // 
        // button1
        // 
        button1.Location = new Point(133, 364);
        button1.Name = "button1";
        button1.Size = new Size(112, 34);
        button1.TabIndex = 1;
        button1.Text = "button1";
        button1.UseVisualStyleBackColor = true;
        button1.Click += this.Button1_Click;
        // 
        // textBox1
        // 
        textBox1.Location = new Point(326, 285);
        textBox1.Multiline = true;
        textBox1.Name = "textBox1";
        textBox1.ReadOnly = true;
        textBox1.Size = new Size(477, 153);
        textBox1.TabIndex = 2;
        textBox1.TextChanged += this.TextBox1_TextChanged;
        // 
        // button2
        // 
        button2.Location = new Point(199, 49);
        button2.Name = "button2";
        button2.Size = new Size(112, 34);
        button2.TabIndex = 3;
        button2.Text = "rel";
        button2.UseVisualStyleBackColor = true;
        button2.Click += this.Button2_Click;
        // 
        // button3
        // 
        button3.Location = new Point(199, 127);
        button3.Name = "button3";
        button3.Size = new Size(112, 34);
        button3.TabIndex = 4;
        button3.Text = "abs";
        button3.UseVisualStyleBackColor = true;
        button3.Click += this.Button3_Click;
        // 
        // numericUpDown1
        // 
        numericUpDown1.Location = new Point(347, 52);
        numericUpDown1.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
        numericUpDown1.Minimum = new decimal(new int[] { 999999, 0, 0, Int32.MinValue });
        numericUpDown1.Name = "numericUpDown1";
        numericUpDown1.Size = new Size(180, 31);
        numericUpDown1.TabIndex = 7;
        // 
        // numericUpDown2
        // 
        numericUpDown2.Location = new Point(347, 130);
        numericUpDown2.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
        numericUpDown2.Minimum = new decimal(new int[] { 999999, 0, 0, Int32.MinValue });
        numericUpDown2.Name = "numericUpDown2";
        numericUpDown2.Size = new Size(180, 31);
        numericUpDown2.TabIndex = 8;
        // 
        // button4
        // 
        button4.Location = new Point(199, 197);
        button4.Name = "button4";
        button4.Size = new Size(112, 34);
        button4.TabIndex = 9;
        button4.Text = "button4";
        button4.UseVisualStyleBackColor = true;
        button4.Click += this.Button4_Click;
        // 
        // Form1
        // 
        this.AutoScaleDimensions = new SizeF(10F, 25F);
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(800, 450);
        this.Controls.Add(button4);
        this.Controls.Add(numericUpDown2);
        this.Controls.Add(numericUpDown1);
        this.Controls.Add(button3);
        this.Controls.Add(button2);
        this.Controls.Add(textBox1);
        this.Controls.Add(button1);
        this.Controls.Add(label1);
        this.Name = "Form1";
        this.Text = "Form1";
        this.Load += this.Form1_Load;
        ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
        ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private Label label1;
    private Button button1;
    private TextBox textBox1;
    private Button button2;
    private Button button3;
    private NumericUpDown numericUpDown1;
    private NumericUpDown numericUpDown2;
    private Button button4;
}
