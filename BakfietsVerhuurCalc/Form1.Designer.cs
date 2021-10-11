
namespace BakfietsVerhuurCalc
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
            this.label1 = new System.Windows.Forms.Label();
            this.NudDays = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CBModel = new System.Windows.Forms.ComboBox();
            this.NudAmountOfBikes = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NudRainCover = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.NudToddlerChair = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.NudPillow = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NudDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudAmountOfBikes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudRainCover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudToddlerChair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudPillow)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bereken de huur prijs";
            // 
            // NudDays
            // 
            this.NudDays.Location = new System.Drawing.Point(318, 86);
            this.NudDays.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudDays.Name = "NudDays";
            this.NudDays.Size = new System.Drawing.Size(120, 23);
            this.NudDays.TabIndex = 1;
            this.NudDays.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Aantal dagen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Welk model";
            // 
            // CBModel
            // 
            this.CBModel.Cursor = System.Windows.Forms.Cursors.Default;
            this.CBModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBModel.FormattingEnabled = true;
            this.CBModel.Items.AddRange(new object[] {
            "Troy",
            "Vogue",
            "BUXXO"});
            this.CBModel.Location = new System.Drawing.Point(318, 121);
            this.CBModel.Name = "CBModel";
            this.CBModel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CBModel.Size = new System.Drawing.Size(121, 23);
            this.CBModel.TabIndex = 5;
            
            // 
            // NudAmountOfBikes
            // 
            this.NudAmountOfBikes.Location = new System.Drawing.Point(492, 121);
            this.NudAmountOfBikes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudAmountOfBikes.Name = "NudAmountOfBikes";
            this.NudAmountOfBikes.Size = new System.Drawing.Size(120, 23);
            this.NudAmountOfBikes.TabIndex = 6;
            this.NudAmountOfBikes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
           
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(445, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Aantal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(235, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 15);
            this.label6.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(235, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Regenhoes";
            // 
            // NudRainCover
            // 
            this.NudRainCover.Location = new System.Drawing.Point(319, 150);
            this.NudRainCover.Name = "NudRainCover";
            this.NudRainCover.Size = new System.Drawing.Size(120, 23);
            this.NudRainCover.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(235, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Peuter stoel";
            // 
            // NudToddlerChair
            // 
            this.NudToddlerChair.Location = new System.Drawing.Point(318, 179);
            this.NudToddlerChair.Name = "NudToddlerChair";
            this.NudToddlerChair.Size = new System.Drawing.Size(120, 23);
            this.NudToddlerChair.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(235, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "Kussen";
           
            // 
            // NudPillow
            // 
            this.NudPillow.Location = new System.Drawing.Point(319, 208);
            this.NudPillow.Name = "NudPillow";
            this.NudPillow.Size = new System.Drawing.Size(120, 23);
            this.NudPillow.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(315, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Bereken prijs";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NudPillow);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.NudToddlerChair);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.NudRainCover);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NudAmountOfBikes);
            this.Controls.Add(this.CBModel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NudDays);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NudDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudAmountOfBikes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudRainCover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudToddlerChair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudPillow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NudDays;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CBModel;
        private System.Windows.Forms.NumericUpDown NudAmountOfBikes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown NudRainCover;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown NudToddlerChair;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown NudPillow;
        private System.Windows.Forms.Button button1;
    }
}

