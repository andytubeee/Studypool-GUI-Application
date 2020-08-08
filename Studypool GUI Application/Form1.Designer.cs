namespace Studypool_GUI_Application
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
			this.txtNum1 = new System.Windows.Forms.TextBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.txtNum2 = new System.Windows.Forms.TextBox();
			this.txtNum3 = new System.Windows.Forms.TextBox();
			this.txtNum4 = new System.Windows.Forms.TextBox();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnCalc = new System.Windows.Forms.Button();
			this.lblSum = new System.Windows.Forms.Label();
			this.lblProd = new System.Windows.Forms.Label();
			this.lblSmallest = new System.Windows.Forms.Label();
			this.lblLargest = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtNum1
			// 
			this.txtNum1.Font = new System.Drawing.Font("Open Sans Light", 9.55F);
			this.txtNum1.Location = new System.Drawing.Point(9, 39);
			this.txtNum1.Name = "txtNum1";
			this.txtNum1.Size = new System.Drawing.Size(64, 25);
			this.txtNum1.TabIndex = 0;
			this.txtNum1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum1_KeyPress);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// txtNum2
			// 
			this.txtNum2.Font = new System.Drawing.Font("Open Sans Light", 9.55F);
			this.txtNum2.Location = new System.Drawing.Point(9, 87);
			this.txtNum2.Name = "txtNum2";
			this.txtNum2.Size = new System.Drawing.Size(64, 25);
			this.txtNum2.TabIndex = 2;
			this.txtNum2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum2_KeyPress);
			// 
			// txtNum3
			// 
			this.txtNum3.Font = new System.Drawing.Font("Open Sans Light", 9.55F);
			this.txtNum3.Location = new System.Drawing.Point(9, 135);
			this.txtNum3.Name = "txtNum3";
			this.txtNum3.Size = new System.Drawing.Size(64, 25);
			this.txtNum3.TabIndex = 3;
			this.txtNum3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum3_KeyPress);
			// 
			// txtNum4
			// 
			this.txtNum4.Font = new System.Drawing.Font("Open Sans Light", 9.55F);
			this.txtNum4.Location = new System.Drawing.Point(9, 183);
			this.txtNum4.Name = "txtNum4";
			this.txtNum4.Size = new System.Drawing.Size(64, 25);
			this.txtNum4.TabIndex = 4;
			this.txtNum4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum4_KeyPress);
			// 
			// btnExit
			// 
			this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnExit.Font = new System.Drawing.Font("Open Sans SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExit.Location = new System.Drawing.Point(310, 212);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(103, 38);
			this.btnExit.TabIndex = 5;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnCalc
			// 
			this.btnCalc.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCalc.Font = new System.Drawing.Font("Open Sans SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCalc.Location = new System.Drawing.Point(201, 212);
			this.btnCalc.Name = "btnCalc";
			this.btnCalc.Size = new System.Drawing.Size(103, 38);
			this.btnCalc.TabIndex = 6;
			this.btnCalc.Text = "Calculate";
			this.btnCalc.UseVisualStyleBackColor = true;
			this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
			// 
			// lblSum
			// 
			this.lblSum.AutoSize = true;
			this.lblSum.Font = new System.Drawing.Font("Open Sans Light", 12.25F);
			this.lblSum.Location = new System.Drawing.Point(107, 38);
			this.lblSum.Name = "lblSum";
			this.lblSum.Size = new System.Drawing.Size(48, 23);
			this.lblSum.TabIndex = 7;
			this.lblSum.Text = "Sum:";
			// 
			// lblProd
			// 
			this.lblProd.AutoSize = true;
			this.lblProd.Font = new System.Drawing.Font("Open Sans Light", 12.25F);
			this.lblProd.Location = new System.Drawing.Point(107, 87);
			this.lblProd.Name = "lblProd";
			this.lblProd.Size = new System.Drawing.Size(75, 23);
			this.lblProd.TabIndex = 8;
			this.lblProd.Text = "Product:";
			// 
			// lblSmallest
			// 
			this.lblSmallest.AutoSize = true;
			this.lblSmallest.Font = new System.Drawing.Font("Open Sans Light", 12.25F);
			this.lblSmallest.Location = new System.Drawing.Point(107, 135);
			this.lblSmallest.Name = "lblSmallest";
			this.lblSmallest.Size = new System.Drawing.Size(78, 23);
			this.lblSmallest.TabIndex = 9;
			this.lblSmallest.Text = "Smallest:";
			// 
			// lblLargest
			// 
			this.lblLargest.AutoSize = true;
			this.lblLargest.Font = new System.Drawing.Font("Open Sans Light", 12.25F);
			this.lblLargest.Location = new System.Drawing.Point(107, 183);
			this.lblLargest.Name = "lblLargest";
			this.lblLargest.Size = new System.Drawing.Size(71, 23);
			this.lblLargest.TabIndex = 10;
			this.lblLargest.Text = "Largest:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Open Sans Light", 8.25F);
			this.label1.Location = new System.Drawing.Point(23, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(33, 15);
			this.label1.TabIndex = 11;
			this.label1.Text = "Input";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Open Sans Light", 8.25F);
			this.label2.Location = new System.Drawing.Point(7, 235);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(187, 15);
			this.label2.TabIndex = 12;
			this.label2.Text = "Application Created by Andrew Yang";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(419, 257);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblLargest);
			this.Controls.Add(this.lblSmallest);
			this.Controls.Add(this.lblProd);
			this.Controls.Add(this.lblSum);
			this.Controls.Add(this.btnCalc);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.txtNum4);
			this.Controls.Add(this.txtNum3);
			this.Controls.Add(this.txtNum2);
			this.Controls.Add(this.txtNum1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Studypool GUI Application";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtNum1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.TextBox txtNum2;
		private System.Windows.Forms.TextBox txtNum3;
		private System.Windows.Forms.TextBox txtNum4;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnCalc;
		private System.Windows.Forms.Label lblSum;
		private System.Windows.Forms.Label lblProd;
		private System.Windows.Forms.Label lblSmallest;
		private System.Windows.Forms.Label lblLargest;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}

