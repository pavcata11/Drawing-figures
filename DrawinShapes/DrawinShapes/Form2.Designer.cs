namespace DrawinShapes
{
    partial class Form2
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
            this.btnDraw = new System.Windows.Forms.Button();
            this.txtSideA = new System.Windows.Forms.TextBox();
            this.txtSideB = new System.Windows.Forms.TextBox();
            this.txtSideC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbljustNumber = new System.Windows.Forms.Label();
            this.listColor = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.radioBtnCircle = new System.Windows.Forms.RadioButton();
            this.radioBtnTriangle = new System.Windows.Forms.RadioButton();
            this.radiobtnRectangle = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnDraw
            // 
            this.btnDraw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDraw.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDraw.Location = new System.Drawing.Point(183, 297);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(110, 58);
            this.btnDraw.TabIndex = 0;
            this.btnDraw.Text = "OK";
            this.btnDraw.UseVisualStyleBackColor = false;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // txtSideA
            // 
            this.txtSideA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtSideA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSideA.Font = new System.Drawing.Font("Bernard MT Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSideA.Location = new System.Drawing.Point(63, 174);
            this.txtSideA.Multiline = true;
            this.txtSideA.Name = "txtSideA";
            this.txtSideA.Size = new System.Drawing.Size(137, 32);
            this.txtSideA.TabIndex = 4;
            // 
            // txtSideB
            // 
            this.txtSideB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtSideB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSideB.Font = new System.Drawing.Font("Bernard MT Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSideB.Location = new System.Drawing.Point(63, 212);
            this.txtSideB.Multiline = true;
            this.txtSideB.Name = "txtSideB";
            this.txtSideB.Size = new System.Drawing.Size(137, 32);
            this.txtSideB.TabIndex = 5;
            // 
            // txtSideC
            // 
            this.txtSideC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtSideC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSideC.Font = new System.Drawing.Font("Bernard MT Condensed", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSideC.Location = new System.Drawing.Point(63, 250);
            this.txtSideC.Multiline = true;
            this.txtSideC.Name = "txtSideC";
            this.txtSideC.Size = new System.Drawing.Size(137, 32);
            this.txtSideC.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "1: Choose Option:";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Berlin Sans FB", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.Location = new System.Drawing.Point(36, 180);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(23, 18);
            this.lblA.TabIndex = 8;
            this.lblA.Text = "A:";
            this.lblA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("Berlin Sans FB", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB.Location = new System.Drawing.Point(36, 218);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(23, 18);
            this.lblB.TabIndex = 9;
            this.lblB.Text = "B:";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("Berlin Sans FB", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC.Location = new System.Drawing.Point(36, 256);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(22, 18);
            this.lblC.TabIndex = 10;
            this.lblC.Text = "C:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(219, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "2: Input size between [1;500]:";
            // 
            // lbljustNumber
            // 
            this.lbljustNumber.AutoSize = true;
            this.lbljustNumber.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbljustNumber.ForeColor = System.Drawing.Color.DarkRed;
            this.lbljustNumber.Location = new System.Drawing.Point(60, 148);
            this.lbljustNumber.Name = "lbljustNumber";
            this.lbljustNumber.Size = new System.Drawing.Size(145, 18);
            this.lbljustNumber.TabIndex = 12;
            this.lbljustNumber.Text = "Input just numbers!";
            // 
            // listColor
            // 
            this.listColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.listColor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listColor.Font = new System.Drawing.Font("Berlin Sans FB", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listColor.ForeColor = System.Drawing.Color.Black;
            this.listColor.FormattingEnabled = true;
            this.listColor.ItemHeight = 19;
            this.listColor.Items.AddRange(new object[] {
            "AliceBlue",
            "AntiqueWhite",
            "Aqua",
            "Aquamarine",
            "Azure",
            "Beige",
            "Bisque",
            "Black",
            "BlanchedAlmond",
            "Blue",
            "BlueViolet",
            "Brown",
            "BurlyWood",
            "CadetBlue",
            "Chartreuse",
            "Chocolate",
            "Coral",
            "CornflowerBlue",
            "Cornsilk",
            "Crimson",
            "Cyan",
            "DarkBlue",
            "DarkCyan",
            "DarkGoldenrod",
            "DarkGray",
            "DarkGreen",
            "DarkKhaki",
            "DarkMagena",
            "DarkOliveGreen",
            "DarkOrange",
            "DarkOrchid",
            "DarkRed",
            "DarkSalmon",
            "DarkSeaGreen",
            "DarkSlateBlue",
            "DarkSlateGray",
            "DarkTurquoise",
            "DarkViolet",
            "DeepPink",
            "DeepSkyBlue",
            "DimGray",
            "DodgerBlue",
            "Firebrick",
            "FloralWhite",
            "ForestGreen",
            "Fuschia",
            "Gainsboro",
            "GhostWhite",
            "Gold",
            "Goldenrod",
            "Gray",
            "Green",
            "GreenYellow",
            "Honeydew",
            "HotPink",
            "IndianRed",
            "Indigo",
            "Ivory",
            "Khaki",
            "Lavender",
            "LavenderBlush",
            "LawnGreen",
            "LemonChiffon",
            "LightBlue",
            "LightCoral",
            "LightCyan",
            "LightGoldenrodYellow",
            "LightGreen",
            "LightGray",
            "LightPink",
            "LightSalmon",
            "LightSeaGreen",
            "LightSkyBlue",
            "LightSlateGray",
            "LightSteelBlue",
            "LightYellow",
            "Lime",
            "LimeGreen",
            "Linen",
            "Magenta",
            "Maroon",
            "MediumAquamarine",
            "MediumBlue",
            "MediumOrchid",
            "MediumPurple",
            "MediumSeaGreen",
            "MediumSlateBlue",
            "MediumSpringGreen",
            "MediumTurquoise",
            "MediumVioletRed",
            "MidnightBlue",
            "MintCream",
            "MistyRose",
            "Moccasin",
            "NavajoWhite",
            "Navy",
            "OldLace",
            "Olive",
            "OliveDrab",
            "Orange",
            "OrangeRed",
            "Orchid",
            "PaleGoldenrod",
            "PaleGreen",
            "PaleTurquoise",
            "PaleVioletRed",
            "PapayaWhip",
            "PeachPuff",
            "Peru",
            "Pink",
            "Plum",
            "PowderBlue",
            "Purple",
            "RosyBrown",
            "RoyalBlue",
            "SaddleBrown",
            "Salmon",
            "SandyBrown",
            "SeaGreen",
            "Seashell",
            "Sienna",
            "Silver",
            "SkyBlue",
            "SlateBlue",
            "SlateGray",
            "Snow",
            "SpringGreen",
            "SteelBlue",
            "Tan",
            "Teal",
            "Thistle",
            "Tomato",
            "Turquoise",
            "Violet",
            "Wheat",
            "White",
            "WhiteSmoke",
            "Yellow",
            "YellowGreen"});
            this.listColor.Location = new System.Drawing.Point(312, 40);
            this.listColor.Name = "listColor";
            this.listColor.Size = new System.Drawing.Size(234, 323);
            this.listColor.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(378, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "3: Choose Color";
            // 
            // radioBtnCircle
            // 
            this.radioBtnCircle.AutoSize = true;
            this.radioBtnCircle.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnCircle.Location = new System.Drawing.Point(119, 52);
            this.radioBtnCircle.Name = "radioBtnCircle";
            this.radioBtnCircle.Size = new System.Drawing.Size(67, 22);
            this.radioBtnCircle.TabIndex = 2;
            this.radioBtnCircle.TabStop = true;
            this.radioBtnCircle.Text = "Circle";
            this.radioBtnCircle.UseVisualStyleBackColor = true;
            this.radioBtnCircle.CheckedChanged += new System.EventHandler(this.radioBtnCircle_CheckedChanged);
            // 
            // radioBtnTriangle
            // 
            this.radioBtnTriangle.AutoSize = true;
            this.radioBtnTriangle.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnTriangle.Location = new System.Drawing.Point(192, 52);
            this.radioBtnTriangle.Name = "radioBtnTriangle";
            this.radioBtnTriangle.Size = new System.Drawing.Size(86, 22);
            this.radioBtnTriangle.TabIndex = 3;
            this.radioBtnTriangle.TabStop = true;
            this.radioBtnTriangle.Text = "Triangle";
            this.radioBtnTriangle.UseVisualStyleBackColor = true;
            this.radioBtnTriangle.CheckedChanged += new System.EventHandler(this.radioBtnTriangle_CheckedChanged);
            // 
            // radiobtnRectangle
            // 
            this.radiobtnRectangle.AutoSize = true;
            this.radiobtnRectangle.Font = new System.Drawing.Font("Berlin Sans FB", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtnRectangle.Location = new System.Drawing.Point(15, 52);
            this.radiobtnRectangle.Name = "radiobtnRectangle";
            this.radiobtnRectangle.Size = new System.Drawing.Size(98, 22);
            this.radiobtnRectangle.TabIndex = 1;
            this.radiobtnRectangle.TabStop = true;
            this.radiobtnRectangle.Text = "Rectangle";
            this.radiobtnRectangle.UseVisualStyleBackColor = true;
            this.radiobtnRectangle.CheckedChanged += new System.EventHandler(this.radiobtnRectangle_CheckedChanged);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(546, 367);
            this.Controls.Add(this.radioBtnTriangle);
            this.Controls.Add(this.radiobtnRectangle);
            this.Controls.Add(this.radioBtnCircle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listColor);
            this.Controls.Add(this.lbljustNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSideC);
            this.Controls.Add(this.txtSideB);
            this.Controls.Add(this.txtSideA);
            this.Controls.Add(this.btnDraw);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.Text = "Options";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.TextBox txtSideA;
        private System.Windows.Forms.TextBox txtSideB;
        private System.Windows.Forms.TextBox txtSideC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbljustNumber;
        private System.Windows.Forms.ListBox listColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioBtnCircle;
        private System.Windows.Forms.RadioButton radioBtnTriangle;
        private System.Windows.Forms.RadioButton radiobtnRectangle;
    }
}