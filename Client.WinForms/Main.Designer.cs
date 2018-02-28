namespace Client.WinForms
{
	partial class Main
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
			this.btnV1 = new System.Windows.Forms.Button();
			this.btnV2 = new System.Windows.Forms.Button();
			this.rtbOutput = new System.Windows.Forms.RichTextBox();
			this.btnListLoadedAsemblies = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnV1
			// 
			this.btnV1.Location = new System.Drawing.Point(231, 26);
			this.btnV1.Name = "btnV1";
			this.btnV1.Size = new System.Drawing.Size(117, 23);
			this.btnV1.TabIndex = 0;
			this.btnV1.Text = "Execute Version 1";
			this.btnV1.UseVisualStyleBackColor = true;
			this.btnV1.Click += new System.EventHandler(this.btnV1_Click);
			// 
			// btnV2
			// 
			this.btnV2.Location = new System.Drawing.Point(372, 26);
			this.btnV2.Name = "btnV2";
			this.btnV2.Size = new System.Drawing.Size(117, 23);
			this.btnV2.TabIndex = 1;
			this.btnV2.Text = "Execute Version 2";
			this.btnV2.UseVisualStyleBackColor = true;
			this.btnV2.Click += new System.EventHandler(this.btnV2_Click);
			// 
			// rtbOutput
			// 
			this.rtbOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rtbOutput.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rtbOutput.Location = new System.Drawing.Point(12, 69);
			this.rtbOutput.Name = "rtbOutput";
			this.rtbOutput.Size = new System.Drawing.Size(815, 421);
			this.rtbOutput.TabIndex = 2;
			this.rtbOutput.Text = "";
			// 
			// btnListLoadedAsemblies
			// 
			this.btnListLoadedAsemblies.Location = new System.Drawing.Point(12, 26);
			this.btnListLoadedAsemblies.Name = "btnListLoadedAsemblies";
			this.btnListLoadedAsemblies.Size = new System.Drawing.Size(197, 23);
			this.btnListLoadedAsemblies.TabIndex = 3;
			this.btnListLoadedAsemblies.Text = "List Currently Loaded Assemblies";
			this.btnListLoadedAsemblies.UseVisualStyleBackColor = true;
			this.btnListLoadedAsemblies.Click += new System.EventHandler(this.btnListLoadedAsemblies_Click);
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(839, 502);
			this.Controls.Add(this.btnListLoadedAsemblies);
			this.Controls.Add(this.rtbOutput);
			this.Controls.Add(this.btnV2);
			this.Controls.Add(this.btnV1);
			this.Name = "Main";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Dynamic Assembly Loading Demo";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnV1;
		private System.Windows.Forms.Button btnV2;
		private System.Windows.Forms.RichTextBox rtbOutput;
		private System.Windows.Forms.Button btnListLoadedAsemblies;
	}
}

