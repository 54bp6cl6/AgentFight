﻿namespace AgentFight
{
	partial class TestForm
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.canvas_PB = new System.Windows.Forms.PictureBox();
			this.painter_Tm = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.canvas_PB)).BeginInit();
			this.SuspendLayout();
			// 
			// canvas_PB
			// 
			this.canvas_PB.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.canvas_PB.Location = new System.Drawing.Point(12, 12);
			this.canvas_PB.Name = "canvas_PB";
			this.canvas_PB.Size = new System.Drawing.Size(1200, 600);
			this.canvas_PB.TabIndex = 0;
			this.canvas_PB.TabStop = false;
			// 
			// painter_Tm
			// 
			this.painter_Tm.Interval = 1;
			this.painter_Tm.Tick += new System.EventHandler(this.painter_Tm_Tick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1435, 729);
			this.Controls.Add(this.canvas_PB);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
			((System.ComponentModel.ISupportInitialize)(this.canvas_PB)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox canvas_PB;
		private System.Windows.Forms.Timer painter_Tm;
	}
}

