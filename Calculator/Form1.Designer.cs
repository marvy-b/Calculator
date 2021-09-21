
namespace Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.btnEquals = new System.Windows.Forms.Button();
            this.Cancel_Entry = new System.Windows.Forms.Button();
            this.btnCancelOperations = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.btnBackSpace = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.labelCurrentOperation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_Result
            // 
            this.textBox_Result.BackColor = System.Drawing.Color.AliceBlue;
            this.textBox_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Result.Location = new System.Drawing.Point(12, 29);
            this.textBox_Result.Multiline = true;
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.ReadOnly = true;
            this.textBox_Result.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox_Result.Size = new System.Drawing.Size(259, 42);
            this.textBox_Result.TabIndex = 36;
            this.textBox_Result.Text = "0";
            // 
            // btnEquals
            // 
            this.btnEquals.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnEquals.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquals.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEquals.Location = new System.Drawing.Point(146, 309);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(122, 52);
            this.btnEquals.TabIndex = 65;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = false;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // Cancel_Entry
            // 
            this.Cancel_Entry.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Cancel_Entry.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cancel_Entry.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel_Entry.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Cancel_Entry.Location = new System.Drawing.Point(79, 86);
            this.Cancel_Entry.Name = "Cancel_Entry";
            this.Cancel_Entry.Size = new System.Drawing.Size(58, 48);
            this.Cancel_Entry.TabIndex = 85;
            this.Cancel_Entry.Text = "CE";
            this.Cancel_Entry.UseVisualStyleBackColor = false;
            this.Cancel_Entry.Click += new System.EventHandler(this.Cancel_Entry_Click);
            // 
            // btnCancelOperations
            // 
            this.btnCancelOperations.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnCancelOperations.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelOperations.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelOperations.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCancelOperations.Location = new System.Drawing.Point(143, 86);
            this.btnCancelOperations.Name = "btnCancelOperations";
            this.btnCancelOperations.Size = new System.Drawing.Size(61, 48);
            this.btnCancelOperations.TabIndex = 86;
            this.btnCancelOperations.Text = "C";
            this.btnCancelOperations.UseVisualStyleBackColor = false;
            this.btnCancelOperations.Click += new System.EventHandler(this.btnCancelOperations_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(210, 86);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 48);
            this.button2.TabIndex = 92;
            this.button2.Text = " ÷";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Operation_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.AliceBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(142, 138);
            this.button3.Name = "button3";
            this.button3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button3.Size = new System.Drawing.Size(61, 53);
            this.button3.TabIndex = 91;
            this.button3.Text = "9";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.BtnNumerical);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.AliceBlue;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button10.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button10.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button10.Location = new System.Drawing.Point(79, 138);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(58, 53);
            this.button10.TabIndex = 90;
            this.button10.Text = "8";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.BtnNumerical);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.AliceBlue;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button11.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button11.Location = new System.Drawing.Point(12, 138);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(60, 53);
            this.button11.TabIndex = 89;
            this.button11.Text = "7";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.BtnNumerical);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button12.Location = new System.Drawing.Point(210, 140);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(59, 49);
            this.button12.TabIndex = 97;
            this.button12.Text = "*";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.Operation_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.AliceBlue;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button13.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button13.Location = new System.Drawing.Point(142, 195);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(61, 49);
            this.button13.TabIndex = 96;
            this.button13.Text = "6";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.BtnNumerical);
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.AliceBlue;
            this.button22.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button22.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button22.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button22.Location = new System.Drawing.Point(79, 195);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(58, 49);
            this.button22.TabIndex = 95;
            this.button22.Text = "5";
            this.button22.UseVisualStyleBackColor = false;
            this.button22.Click += new System.EventHandler(this.BtnNumerical);
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.Color.AliceBlue;
            this.button23.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button23.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button23.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button23.Location = new System.Drawing.Point(11, 195);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(61, 49);
            this.button23.TabIndex = 94;
            this.button23.Text = "4";
            this.button23.UseVisualStyleBackColor = false;
            this.button23.Click += new System.EventHandler(this.BtnNumerical);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button15.Location = new System.Drawing.Point(209, 250);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(59, 49);
            this.button15.TabIndex = 100;
            this.button15.Text = "+";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.Operation_Click);
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.AliceBlue;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button16.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button16.Location = new System.Drawing.Point(79, 309);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(61, 54);
            this.button16.TabIndex = 99;
            this.button16.Text = ".";
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.BtnNumerical);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.AliceBlue;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button18.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button18.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button18.Location = new System.Drawing.Point(12, 309);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(61, 54);
            this.button18.TabIndex = 98;
            this.button18.Text = "0";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.BtnNumerical);
            // 
            // button25
            // 
            this.button25.BackColor = System.Drawing.Color.AliceBlue;
            this.button25.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button25.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button25.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button25.Location = new System.Drawing.Point(143, 250);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(61, 50);
            this.button25.TabIndex = 106;
            this.button25.Text = "3";
            this.button25.UseVisualStyleBackColor = false;
            this.button25.Click += new System.EventHandler(this.BtnNumerical);
            // 
            // button26
            // 
            this.button26.BackColor = System.Drawing.Color.AliceBlue;
            this.button26.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button26.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button26.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button26.Location = new System.Drawing.Point(78, 250);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(58, 51);
            this.button26.TabIndex = 105;
            this.button26.Text = "2";
            this.button26.UseVisualStyleBackColor = false;
            this.button26.Click += new System.EventHandler(this.BtnNumerical);
            // 
            // button27
            // 
            this.button27.BackColor = System.Drawing.Color.AliceBlue;
            this.button27.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button27.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button27.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button27.Location = new System.Drawing.Point(12, 250);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(61, 51);
            this.button27.TabIndex = 104;
            this.button27.Text = "1";
            this.button27.UseVisualStyleBackColor = false;
            this.button27.Click += new System.EventHandler(this.BtnNumerical);
            // 
            // btnBackSpace
            // 
            this.btnBackSpace.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnBackSpace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBackSpace.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBackSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackSpace.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBackSpace.Location = new System.Drawing.Point(12, 86);
            this.btnBackSpace.Name = "btnBackSpace";
            this.btnBackSpace.Size = new System.Drawing.Size(61, 48);
            this.btnBackSpace.TabIndex = 84;
            this.btnBackSpace.Text = " ←";
            this.btnBackSpace.UseVisualStyleBackColor = false;
            this.btnBackSpace.Click += new System.EventHandler(this.btnBackSpace_Click);
            // 
            // button24
            // 
            this.button24.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button24.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button24.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button24.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button24.Location = new System.Drawing.Point(209, 195);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(59, 49);
            this.button24.TabIndex = 107;
            this.button24.Text = "-";
            this.button24.UseVisualStyleBackColor = false;
            this.button24.Click += new System.EventHandler(this.Operation_Click);
            // 
            // labelCurrentOperation
            // 
            this.labelCurrentOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentOperation.Location = new System.Drawing.Point(12, 0);
            this.labelCurrentOperation.Name = "labelCurrentOperation";
            this.labelCurrentOperation.Size = new System.Drawing.Size(259, 26);
            this.labelCurrentOperation.TabIndex = 109;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(283, 376);
            this.Controls.Add(this.labelCurrentOperation);
            this.Controls.Add(this.button24);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.button26);
            this.Controls.Add(this.button27);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.btnCancelOperations);
            this.Controls.Add(this.Cancel_Entry);
            this.Controls.Add(this.btnBackSpace);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.textBox_Result);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Result;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnBackSpace;
        private System.Windows.Forms.Button Cancel_Entry;
        private System.Windows.Forms.Button btnCancelOperations;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Label labelCurrentOperation;
    }
}

