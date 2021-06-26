
namespace AverageCasesForm
{
    partial class formAverageCases
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
            this.components = new System.ComponentModel.Container();
            this.labelCasePrompt = new System.Windows.Forms.Label();
            this.labelDay = new System.Windows.Forms.Label();
            this.labelAverageOutput = new System.Windows.Forms.Label();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.textBoxCaseEntry = new System.Windows.Forms.TextBox();
            this.textBoxRegion1 = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.labelRegion1 = new System.Windows.Forms.Label();
            this.labelRegion1Average = new System.Windows.Forms.Label();
            this.labelRegion2 = new System.Windows.Forms.Label();
            this.textBoxRegion2 = new System.Windows.Forms.TextBox();
            this.labelRegion2Average = new System.Windows.Forms.Label();
            this.labelRegion3 = new System.Windows.Forms.Label();
            this.textBoxRegion3 = new System.Windows.Forms.TextBox();
            this.labelRegion3Average = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCasePrompt
            // 
            this.labelCasePrompt.AutoSize = true;
            this.labelCasePrompt.Location = new System.Drawing.Point(56, 46);
            this.labelCasePrompt.Name = "labelCasePrompt";
            this.labelCasePrompt.Size = new System.Drawing.Size(72, 15);
            this.labelCasePrompt.TabIndex = 0;
            this.labelCasePrompt.Text = " Daily &Cases:";
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.Location = new System.Drawing.Point(474, 39);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(33, 15);
            this.labelDay.TabIndex = 2;
            this.labelDay.Text = "Day1";
            this.labelDay.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelAverageOutput
            // 
            this.labelAverageOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelAverageOutput.Location = new System.Drawing.Point(31, 320);
            this.labelAverageOutput.Name = "labelAverageOutput";
            this.labelAverageOutput.Size = new System.Drawing.Size(523, 29);
            this.labelAverageOutput.TabIndex = 14;
            this.labelAverageOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(56, 370);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(127, 35);
            this.buttonEnter.TabIndex = 13;
            this.buttonEnter.Text = "&Enter";
            this.toolTip1.SetToolTip(this.buttonEnter, "button to enter on program");
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.EnterClick);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(206, 372);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(123, 34);
            this.buttonReset.TabIndex = 15;
            this.buttonReset.Text = "&Reset";
            this.toolTip1.SetToolTip(this.buttonReset, "button to reset program");
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.ResetClick);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(369, 371);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(138, 33);
            this.buttonExit.TabIndex = 16;
            this.buttonExit.Text = "E&xit";
            this.toolTip1.SetToolTip(this.buttonExit, "button to exit program");
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ExitClick);
            // 
            // textBoxCaseEntry
            // 
            this.textBoxCaseEntry.Location = new System.Drawing.Point(145, 43);
            this.textBoxCaseEntry.Name = "textBoxCaseEntry";
            this.textBoxCaseEntry.Size = new System.Drawing.Size(244, 23);
            this.textBoxCaseEntry.TabIndex = 1;
            // 
            // textBoxRegion1
            // 
            this.textBoxRegion1.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxRegion1.Location = new System.Drawing.Point(51, 116);
            this.textBoxRegion1.Multiline = true;
            this.textBoxRegion1.Name = "textBoxRegion1";
            this.textBoxRegion1.ReadOnly = true;
            this.textBoxRegion1.Size = new System.Drawing.Size(132, 159);
            this.textBoxRegion1.TabIndex = 4;
            this.toolTip1.SetToolTip(this.textBoxRegion1, "List of daily cases region1");
            // 
            // labelRegion1
            // 
            this.labelRegion1.AutoSize = true;
            this.labelRegion1.Location = new System.Drawing.Point(56, 91);
            this.labelRegion1.Name = "labelRegion1";
            this.labelRegion1.Size = new System.Drawing.Size(53, 15);
            this.labelRegion1.TabIndex = 3;
            this.labelRegion1.Text = "Region &1";
            this.labelRegion1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRegion1Average
            // 
            this.labelRegion1Average.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelRegion1Average.Location = new System.Drawing.Point(51, 284);
            this.labelRegion1Average.Name = "labelRegion1Average";
            this.labelRegion1Average.Size = new System.Drawing.Size(125, 25);
            this.labelRegion1Average.TabIndex = 5;
            this.labelRegion1Average.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.labelRegion1Average, "Average cases for region 1");
            // 
            // labelRegion2
            // 
            this.labelRegion2.AutoSize = true;
            this.labelRegion2.Location = new System.Drawing.Point(231, 98);
            this.labelRegion2.Name = "labelRegion2";
            this.labelRegion2.Size = new System.Drawing.Size(53, 15);
            this.labelRegion2.TabIndex = 7;
            this.labelRegion2.Text = "Region &2";
            this.labelRegion2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxRegion2
            // 
            this.textBoxRegion2.Location = new System.Drawing.Point(196, 116);
            this.textBoxRegion2.Multiline = true;
            this.textBoxRegion2.Name = "textBoxRegion2";
            this.textBoxRegion2.Size = new System.Drawing.Size(132, 159);
            this.textBoxRegion2.TabIndex = 8;
            this.toolTip1.SetToolTip(this.textBoxRegion2, "List of daily cases region2");
            // 
            // labelRegion2Average
            // 
            this.labelRegion2Average.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelRegion2Average.Location = new System.Drawing.Point(196, 284);
            this.labelRegion2Average.Name = "labelRegion2Average";
            this.labelRegion2Average.Size = new System.Drawing.Size(125, 25);
            this.labelRegion2Average.TabIndex = 9;
            this.labelRegion2Average.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.labelRegion2Average, "Average cases for region 2");
            // 
            // labelRegion3
            // 
            this.labelRegion3.AutoSize = true;
            this.labelRegion3.Location = new System.Drawing.Point(419, 98);
            this.labelRegion3.Name = "labelRegion3";
            this.labelRegion3.Size = new System.Drawing.Size(53, 15);
            this.labelRegion3.TabIndex = 10;
            this.labelRegion3.Text = "Region &3";
            this.labelRegion3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxRegion3
            // 
            this.textBoxRegion3.Location = new System.Drawing.Point(350, 116);
            this.textBoxRegion3.Multiline = true;
            this.textBoxRegion3.Name = "textBoxRegion3";
            this.textBoxRegion3.Size = new System.Drawing.Size(140, 159);
            this.textBoxRegion3.TabIndex = 11;
            this.toolTip1.SetToolTip(this.textBoxRegion3, "List of daily cases region3");
            // 
            // labelRegion3Average
            // 
            this.labelRegion3Average.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelRegion3Average.Location = new System.Drawing.Point(365, 284);
            this.labelRegion3Average.Name = "labelRegion3Average";
            this.labelRegion3Average.Size = new System.Drawing.Size(125, 25);
            this.labelRegion3Average.TabIndex = 12;
            this.labelRegion3Average.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.labelRegion3Average, "Average cases for region 3");
            // 
            // formAverageCases
            // 
            this.AcceptButton = this.buttonEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonReset;
            this.ClientSize = new System.Drawing.Size(579, 450);
            this.Controls.Add(this.labelRegion3Average);
            this.Controls.Add(this.textBoxRegion3);
            this.Controls.Add(this.labelRegion3);
            this.Controls.Add(this.labelRegion2Average);
            this.Controls.Add(this.textBoxRegion2);
            this.Controls.Add(this.labelRegion2);
            this.Controls.Add(this.labelRegion1Average);
            this.Controls.Add(this.labelRegion1);
            this.Controls.Add(this.textBoxRegion1);
            this.Controls.Add(this.textBoxCaseEntry);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.labelAverageOutput);
            this.Controls.Add(this.labelDay);
            this.Controls.Add(this.labelCasePrompt);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formAverageCases";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Average Weekly Units by Region";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCasePrompt;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.Label labelAverageOutput;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox textBoxCaseEntry;
        private System.Windows.Forms.TextBox textBoxRegion1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label labelRegion1;
        private System.Windows.Forms.Label labelRegion1Average;
        private System.Windows.Forms.Label labelRegion2;
        private System.Windows.Forms.TextBox textBoxRegion2;
        private System.Windows.Forms.Label labelRegion2Average;
        private System.Windows.Forms.Label labelRegion3;
        private System.Windows.Forms.TextBox textBoxRegion3;
        private System.Windows.Forms.Label labelRegion3Average;
    }
}

