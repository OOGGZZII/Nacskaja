namespace Etterem
{
	partial class EtteremNyilvantartas
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
			if(disposing && (components != null))
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EtteremNyilvantartas));
			this.BTN_ORDER = new System.Windows.Forms.Button();
			this.BTN_STORAGE = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// BTN_ORDER
			// 
			this.BTN_ORDER.BackColor = System.Drawing.Color.Bisque;
			this.BTN_ORDER.Font = new System.Drawing.Font("Niagara Solid", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BTN_ORDER.Location = new System.Drawing.Point(216, 454);
			this.BTN_ORDER.Name = "BTN_ORDER";
			this.BTN_ORDER.Size = new System.Drawing.Size(156, 95);
			this.BTN_ORDER.TabIndex = 0;
			this.BTN_ORDER.Text = "Rendelés";
			this.BTN_ORDER.UseVisualStyleBackColor = false;
			// 
			// BTN_STORAGE
			// 
			this.BTN_STORAGE.BackColor = System.Drawing.Color.Bisque;
			this.BTN_STORAGE.Font = new System.Drawing.Font("Niagara Solid", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BTN_STORAGE.Location = new System.Drawing.Point(12, 454);
			this.BTN_STORAGE.Name = "BTN_STORAGE";
			this.BTN_STORAGE.Size = new System.Drawing.Size(156, 95);
			this.BTN_STORAGE.TabIndex = 1;
			this.BTN_STORAGE.Text = "Beszerzés";
			this.BTN_STORAGE.UseVisualStyleBackColor = false;
			// 
			// EtteremNyilvantartas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(384, 561);
			this.Controls.Add(this.BTN_STORAGE);
			this.Controls.Add(this.BTN_ORDER);
			this.DoubleBuffered = true;
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(400, 600);
			this.MinimumSize = new System.Drawing.Size(400, 600);
			this.Name = "EtteremNyilvantartas";
			this.Text = ":3";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button BTN_ORDER;
		private System.Windows.Forms.Button BTN_STORAGE;
	}
}

