namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnpreencher = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnpreencher
            // 
            this.btnpreencher.Location = new System.Drawing.Point(226, 165);
            this.btnpreencher.Name = "btnpreencher";
            this.btnpreencher.Size = new System.Drawing.Size(160, 55);
            this.btnpreencher.TabIndex = 0;
            this.btnpreencher.Text = "Preencher";
            this.btnpreencher.UseVisualStyleBackColor = true;
            this.btnpreencher.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 531);
            this.Controls.Add(this.btnpreencher);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnpreencher;
    }
}

