namespace WindowsFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            //button
            //
            this.button.Location = new System.Drawing.Point(200, 200);
            this.button.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(100,100);
            this.button.TabIndex = 0;
            this.button.MouseHover += new System.EventHandler(this.button_MouseHover);
            this.button.Text = "BUTTON";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // Form1
            // 
            this.Location = new System.Drawing.Point(600, 600);   
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.button);
            this.Margin = new System.Windows.Forms.Padding(50, 50, 50, 50);
            this.Name = "Form1";
            this.Text = "Mustafa DESTECI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button;
    }
}

