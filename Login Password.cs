
namespace passLogin
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.Box1 = new System.Windows.Forms.TextBox();
			this.Box2 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(42, 62);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "UserName";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(42, 119);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Password";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(63, 202);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "Aceptar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// Box1
			// 
			this.Box1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.Box1.Location = new System.Drawing.Point(120, 62);
			this.Box1.Name = "Box1";
			this.Box1.Size = new System.Drawing.Size(100, 20);
			this.Box1.TabIndex = 3;
			this.Box1.TextChanged += new System.EventHandler(this.Box1TextChanged);
			// 
			// Box2
			// 
			this.Box2.Location = new System.Drawing.Point(120, 119);
			this.Box2.Name = "Box2";
			this.Box2.PasswordChar = '*';
			this.Box2.Size = new System.Drawing.Size(100, 20);
			this.Box2.TabIndex = 4;
			this.Box2.TextChanged += new System.EventHandler(this.Box2TextChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.Box2);
			this.Controls.Add(this.Box1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "passLogin";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox Box2;
		private System.Windows.Forms.TextBox Box1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		
		
}

	}

