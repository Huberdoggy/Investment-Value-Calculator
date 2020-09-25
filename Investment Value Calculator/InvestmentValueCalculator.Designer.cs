using System;

namespace Investment_Value_Calculator
{
    partial class InvestmentValueCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvestmentValueCalculator));
            this.InformationGroupBox = new System.Windows.Forms.GroupBox();
            this.anticipatedARRTxtBox = new System.Windows.Forms.TextBox();
            this.anticipatedARRLbl = new System.Windows.Forms.Label();
            this.desiredNumSharesTxtBox = new System.Windows.Forms.TextBox();
            this.desiredNumSharesLbl = new System.Windows.Forms.Label();
            this.costPerShareTxtBox = new System.Windows.Forms.TextBox();
            this.costPerShareLbl = new System.Windows.Forms.Label();
            this.stockSymbolTxtBox = new System.Windows.Forms.TextBox();
            this.stockSymbolLbl = new System.Windows.Forms.Label();
            this.stockNameTxtBox = new System.Windows.Forms.TextBox();
            this.stockNameLbl = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.after_6Btn = new System.Windows.Forms.Button();
            this.after_1Btn = new System.Windows.Forms.Button();
            this.after_2Btn = new System.Windows.Forms.Button();
            this.after_5Btn = new System.Windows.Forms.Button();
            this.resultsGroupBox = new System.Windows.Forms.GroupBox();
            this.totalAvgLbl = new System.Windows.Forms.Label();
            this.totalAvgTxtBox = new System.Windows.Forms.TextBox();
            this.calcValueTxtBox = new System.Windows.Forms.TextBox();
            this.calcValueLbl = new System.Windows.Forms.Label();
            this.submitInfoBtn = new System.Windows.Forms.Button();
            this.InformationGroupBox.SuspendLayout();
            this.resultsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // InformationGroupBox
            // 
            this.InformationGroupBox.BackColor = System.Drawing.Color.DodgerBlue;
            this.InformationGroupBox.Controls.Add(this.anticipatedARRTxtBox);
            this.InformationGroupBox.Controls.Add(this.anticipatedARRLbl);
            this.InformationGroupBox.Controls.Add(this.desiredNumSharesTxtBox);
            this.InformationGroupBox.Controls.Add(this.desiredNumSharesLbl);
            this.InformationGroupBox.Controls.Add(this.costPerShareTxtBox);
            this.InformationGroupBox.Controls.Add(this.costPerShareLbl);
            this.InformationGroupBox.Controls.Add(this.stockSymbolTxtBox);
            this.InformationGroupBox.Controls.Add(this.stockSymbolLbl);
            this.InformationGroupBox.Controls.Add(this.stockNameTxtBox);
            this.InformationGroupBox.Controls.Add(this.stockNameLbl);
            this.InformationGroupBox.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InformationGroupBox.ForeColor = System.Drawing.Color.GhostWhite;
            this.InformationGroupBox.Location = new System.Drawing.Point(12, 29);
            this.InformationGroupBox.Name = "InformationGroupBox";
            this.InformationGroupBox.Size = new System.Drawing.Size(367, 267);
            this.InformationGroupBox.TabIndex = 0;
            this.InformationGroupBox.TabStop = false;
            this.InformationGroupBox.Text = "Initial Information";
            // 
            // anticipatedARRTxtBox
            // 
            this.anticipatedARRTxtBox.BackColor = System.Drawing.Color.Moccasin;
            this.anticipatedARRTxtBox.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anticipatedARRTxtBox.ForeColor = System.Drawing.Color.ForestGreen;
            this.anticipatedARRTxtBox.Location = new System.Drawing.Point(253, 189);
            this.anticipatedARRTxtBox.Name = "anticipatedARRTxtBox";
            this.anticipatedARRTxtBox.Size = new System.Drawing.Size(100, 25);
            this.anticipatedARRTxtBox.TabIndex = 5;
            // 
            // anticipatedARRLbl
            // 
            this.anticipatedARRLbl.AutoSize = true;
            this.anticipatedARRLbl.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anticipatedARRLbl.Location = new System.Drawing.Point(28, 191);
            this.anticipatedARRLbl.Name = "anticipatedARRLbl";
            this.anticipatedARRLbl.Size = new System.Drawing.Size(219, 18);
            this.anticipatedARRLbl.TabIndex = 4;
            this.anticipatedARRLbl.Text = "Anticipated Annual Return Rate %:";
            this.anticipatedARRLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // desiredNumSharesTxtBox
            // 
            this.desiredNumSharesTxtBox.BackColor = System.Drawing.Color.Moccasin;
            this.desiredNumSharesTxtBox.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desiredNumSharesTxtBox.ForeColor = System.Drawing.Color.ForestGreen;
            this.desiredNumSharesTxtBox.Location = new System.Drawing.Point(201, 150);
            this.desiredNumSharesTxtBox.Name = "desiredNumSharesTxtBox";
            this.desiredNumSharesTxtBox.Size = new System.Drawing.Size(100, 25);
            this.desiredNumSharesTxtBox.TabIndex = 4;
            // 
            // desiredNumSharesLbl
            // 
            this.desiredNumSharesLbl.AutoSize = true;
            this.desiredNumSharesLbl.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desiredNumSharesLbl.Location = new System.Drawing.Point(28, 152);
            this.desiredNumSharesLbl.Name = "desiredNumSharesLbl";
            this.desiredNumSharesLbl.Size = new System.Drawing.Size(167, 18);
            this.desiredNumSharesLbl.TabIndex = 3;
            this.desiredNumSharesLbl.Text = "Desired Number of Shares:";
            this.desiredNumSharesLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // costPerShareTxtBox
            // 
            this.costPerShareTxtBox.BackColor = System.Drawing.Color.Moccasin;
            this.costPerShareTxtBox.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costPerShareTxtBox.ForeColor = System.Drawing.Color.ForestGreen;
            this.costPerShareTxtBox.Location = new System.Drawing.Point(132, 111);
            this.costPerShareTxtBox.Name = "costPerShareTxtBox";
            this.costPerShareTxtBox.Size = new System.Drawing.Size(100, 25);
            this.costPerShareTxtBox.TabIndex = 3;
            // 
            // costPerShareLbl
            // 
            this.costPerShareLbl.AutoSize = true;
            this.costPerShareLbl.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costPerShareLbl.Location = new System.Drawing.Point(28, 113);
            this.costPerShareLbl.Name = "costPerShareLbl";
            this.costPerShareLbl.Size = new System.Drawing.Size(98, 18);
            this.costPerShareLbl.TabIndex = 2;
            this.costPerShareLbl.Text = "Cost Per Share:";
            this.costPerShareLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stockSymbolTxtBox
            // 
            this.stockSymbolTxtBox.BackColor = System.Drawing.Color.Moccasin;
            this.stockSymbolTxtBox.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockSymbolTxtBox.ForeColor = System.Drawing.Color.ForestGreen;
            this.stockSymbolTxtBox.Location = new System.Drawing.Point(126, 74);
            this.stockSymbolTxtBox.Name = "stockSymbolTxtBox";
            this.stockSymbolTxtBox.Size = new System.Drawing.Size(100, 25);
            this.stockSymbolTxtBox.TabIndex = 2;
            // 
            // stockSymbolLbl
            // 
            this.stockSymbolLbl.AutoSize = true;
            this.stockSymbolLbl.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockSymbolLbl.Location = new System.Drawing.Point(28, 74);
            this.stockSymbolLbl.Name = "stockSymbolLbl";
            this.stockSymbolLbl.Size = new System.Drawing.Size(92, 18);
            this.stockSymbolLbl.TabIndex = 1;
            this.stockSymbolLbl.Text = "Stock Symbol:";
            this.stockSymbolLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stockNameTxtBox
            // 
            this.stockNameTxtBox.BackColor = System.Drawing.Color.Moccasin;
            this.stockNameTxtBox.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockNameTxtBox.ForeColor = System.Drawing.Color.ForestGreen;
            this.stockNameTxtBox.Location = new System.Drawing.Point(116, 35);
            this.stockNameTxtBox.Name = "stockNameTxtBox";
            this.stockNameTxtBox.Size = new System.Drawing.Size(100, 25);
            this.stockNameTxtBox.TabIndex = 1;
            // 
            // stockNameLbl
            // 
            this.stockNameLbl.AutoSize = true;
            this.stockNameLbl.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockNameLbl.Location = new System.Drawing.Point(28, 35);
            this.stockNameLbl.Name = "stockNameLbl";
            this.stockNameLbl.Size = new System.Drawing.Size(82, 18);
            this.stockNameLbl.TabIndex = 0;
            this.stockNameLbl.Text = "Stock Name:";
            this.stockNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.exitBtn.FlatAppearance.BorderColor = System.Drawing.Color.GhostWhite;
            this.exitBtn.FlatAppearance.BorderSize = 5;
            this.exitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.exitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.exitBtn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.Color.GhostWhite;
            this.exitBtn.Location = new System.Drawing.Point(575, 185);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(140, 60);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.Text = "E&xit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.clearBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.clearBtn.FlatAppearance.BorderColor = System.Drawing.Color.GhostWhite;
            this.clearBtn.FlatAppearance.BorderSize = 5;
            this.clearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.clearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.clearBtn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.ForeColor = System.Drawing.Color.GhostWhite;
            this.clearBtn.Location = new System.Drawing.Point(420, 185);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(140, 60);
            this.clearBtn.TabIndex = 4;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // after_6Btn
            // 
            this.after_6Btn.BackColor = System.Drawing.Color.MidnightBlue;
            this.after_6Btn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.after_6Btn.ForeColor = System.Drawing.Color.MintCream;
            this.after_6Btn.Location = new System.Drawing.Point(138, 133);
            this.after_6Btn.Name = "after_6Btn";
            this.after_6Btn.Size = new System.Drawing.Size(100, 90);
            this.after_6Btn.TabIndex = 2;
            this.after_6Btn.Text = "After\r\n6 Months";
            this.after_6Btn.UseVisualStyleBackColor = false;
            this.after_6Btn.Click += new System.EventHandler(this.after_6Btn_Click_1);
            // 
            // after_1Btn
            // 
            this.after_1Btn.BackColor = System.Drawing.Color.MidnightBlue;
            this.after_1Btn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.after_1Btn.ForeColor = System.Drawing.Color.MintCream;
            this.after_1Btn.Location = new System.Drawing.Point(265, 133);
            this.after_1Btn.Name = "after_1Btn";
            this.after_1Btn.Size = new System.Drawing.Size(100, 90);
            this.after_1Btn.TabIndex = 3;
            this.after_1Btn.Text = "After\r\nOne Year";
            this.after_1Btn.UseVisualStyleBackColor = false;
            this.after_1Btn.Click += new System.EventHandler(this.after_1Btn_Click);
            // 
            // after_2Btn
            // 
            this.after_2Btn.BackColor = System.Drawing.Color.MidnightBlue;
            this.after_2Btn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.after_2Btn.ForeColor = System.Drawing.Color.MintCream;
            this.after_2Btn.Location = new System.Drawing.Point(392, 133);
            this.after_2Btn.Name = "after_2Btn";
            this.after_2Btn.Size = new System.Drawing.Size(100, 90);
            this.after_2Btn.TabIndex = 4;
            this.after_2Btn.Text = "After \r\nTwo Years";
            this.after_2Btn.UseVisualStyleBackColor = false;
            this.after_2Btn.Click += new System.EventHandler(this.after_2Btn_Click);
            // 
            // after_5Btn
            // 
            this.after_5Btn.BackColor = System.Drawing.Color.MidnightBlue;
            this.after_5Btn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.after_5Btn.ForeColor = System.Drawing.Color.MintCream;
            this.after_5Btn.Location = new System.Drawing.Point(519, 133);
            this.after_5Btn.Name = "after_5Btn";
            this.after_5Btn.Size = new System.Drawing.Size(100, 90);
            this.after_5Btn.TabIndex = 5;
            this.after_5Btn.Text = "After\r\nFive Years";
            this.after_5Btn.UseVisualStyleBackColor = false;
            this.after_5Btn.Click += new System.EventHandler(this.after_5Btn_Click);
            // 
            // resultsGroupBox
            // 
            this.resultsGroupBox.BackColor = System.Drawing.Color.DodgerBlue;
            this.resultsGroupBox.Controls.Add(this.totalAvgLbl);
            this.resultsGroupBox.Controls.Add(this.totalAvgTxtBox);
            this.resultsGroupBox.Controls.Add(this.calcValueTxtBox);
            this.resultsGroupBox.Controls.Add(this.after_5Btn);
            this.resultsGroupBox.Controls.Add(this.calcValueLbl);
            this.resultsGroupBox.Controls.Add(this.after_2Btn);
            this.resultsGroupBox.Controls.Add(this.after_6Btn);
            this.resultsGroupBox.Controls.Add(this.after_1Btn);
            this.resultsGroupBox.Enabled = false;
            this.resultsGroupBox.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsGroupBox.ForeColor = System.Drawing.Color.GhostWhite;
            this.resultsGroupBox.Location = new System.Drawing.Point(12, 335);
            this.resultsGroupBox.Name = "resultsGroupBox";
            this.resultsGroupBox.Size = new System.Drawing.Size(757, 373);
            this.resultsGroupBox.TabIndex = 3;
            this.resultsGroupBox.TabStop = false;
            this.resultsGroupBox.Text = "Results";
            // 
            // totalAvgLbl
            // 
            this.totalAvgLbl.AutoSize = true;
            this.totalAvgLbl.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAvgLbl.Location = new System.Drawing.Point(12, 274);
            this.totalAvgLbl.Name = "totalAvgLbl";
            this.totalAvgLbl.Size = new System.Drawing.Size(260, 22);
            this.totalAvgLbl.TabIndex = 7;
            this.totalAvgLbl.Text = "Total Average Annual Rate of Return:";
            this.totalAvgLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalAvgTxtBox
            // 
            this.totalAvgTxtBox.BackColor = System.Drawing.Color.Moccasin;
            this.totalAvgTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalAvgTxtBox.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalAvgTxtBox.ForeColor = System.Drawing.Color.ForestGreen;
            this.totalAvgTxtBox.Location = new System.Drawing.Point(278, 262);
            this.totalAvgTxtBox.Multiline = true;
            this.totalAvgTxtBox.Name = "totalAvgTxtBox";
            this.totalAvgTxtBox.Size = new System.Drawing.Size(445, 69);
            this.totalAvgTxtBox.TabIndex = 6;
            this.totalAvgTxtBox.Visible = false;
            // 
            // calcValueTxtBox
            // 
            this.calcValueTxtBox.BackColor = System.Drawing.Color.Moccasin;
            this.calcValueTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.calcValueTxtBox.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcValueTxtBox.ForeColor = System.Drawing.Color.ForestGreen;
            this.calcValueTxtBox.Location = new System.Drawing.Point(146, 23);
            this.calcValueTxtBox.Multiline = true;
            this.calcValueTxtBox.Name = "calcValueTxtBox";
            this.calcValueTxtBox.Size = new System.Drawing.Size(464, 74);
            this.calcValueTxtBox.TabIndex = 1;
            // 
            // calcValueLbl
            // 
            this.calcValueLbl.AutoSize = true;
            this.calcValueLbl.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcValueLbl.Location = new System.Drawing.Point(12, 38);
            this.calcValueLbl.Name = "calcValueLbl";
            this.calcValueLbl.Size = new System.Drawing.Size(128, 22);
            this.calcValueLbl.TabIndex = 0;
            this.calcValueLbl.Text = "Calculated Value:";
            this.calcValueLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // submitInfoBtn
            // 
            this.submitInfoBtn.BackColor = System.Drawing.Color.MidnightBlue;
            this.submitInfoBtn.FlatAppearance.BorderColor = System.Drawing.Color.GhostWhite;
            this.submitInfoBtn.FlatAppearance.BorderSize = 5;
            this.submitInfoBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.submitInfoBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.submitInfoBtn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitInfoBtn.ForeColor = System.Drawing.Color.GhostWhite;
            this.submitInfoBtn.Location = new System.Drawing.Point(511, 105);
            this.submitInfoBtn.Name = "submitInfoBtn";
            this.submitInfoBtn.Size = new System.Drawing.Size(140, 60);
            this.submitInfoBtn.TabIndex = 2;
            this.submitInfoBtn.Text = "Submit Information";
            this.submitInfoBtn.UseVisualStyleBackColor = false;
            this.submitInfoBtn.Click += new System.EventHandler(this.submitInfoBtn_Click);
            // 
            // InvestmentValueCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CancelButton = this.clearBtn;
            this.ClientSize = new System.Drawing.Size(791, 720);
            this.Controls.Add(this.submitInfoBtn);
            this.Controls.Add(this.resultsGroupBox);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.InformationGroupBox);
            this.ForeColor = System.Drawing.Color.MintCream;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InvestmentValueCalculator";
            this.Text = "Kyle\'s Investment Value Calculator";
            this.InformationGroupBox.ResumeLayout(false);
            this.InformationGroupBox.PerformLayout();
            this.resultsGroupBox.ResumeLayout(false);
            this.resultsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        private void after_6Btn_Click(object sender, EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.GroupBox InformationGroupBox;
        private System.Windows.Forms.TextBox anticipatedARRTxtBox;
        private System.Windows.Forms.Label anticipatedARRLbl;
        private System.Windows.Forms.TextBox desiredNumSharesTxtBox;
        private System.Windows.Forms.Label desiredNumSharesLbl;
        private System.Windows.Forms.TextBox costPerShareTxtBox;
        private System.Windows.Forms.Label costPerShareLbl;
        private System.Windows.Forms.TextBox stockSymbolTxtBox;
        private System.Windows.Forms.Label stockSymbolLbl;
        private System.Windows.Forms.Label stockNameLbl;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button after_6Btn;
        private System.Windows.Forms.Button after_1Btn;
        private System.Windows.Forms.Button after_2Btn;
        private System.Windows.Forms.Button after_5Btn;
        private System.Windows.Forms.GroupBox resultsGroupBox;
        private System.Windows.Forms.Label calcValueLbl;
        private System.Windows.Forms.TextBox calcValueTxtBox;
        private System.Windows.Forms.Button submitInfoBtn;
        private System.Windows.Forms.TextBox stockNameTxtBox;
        private System.Windows.Forms.Label totalAvgLbl;
        private System.Windows.Forms.TextBox totalAvgTxtBox;
    }
}

