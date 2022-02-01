
namespace _01_Task
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
            this.btnBaixar = new System.Windows.Forms.Button();
            this.txtSite = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBaixar
            // 
            this.btnBaixar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnBaixar.Location = new System.Drawing.Point(0, 235);
            this.btnBaixar.Name = "btnBaixar";
            this.btnBaixar.Size = new System.Drawing.Size(225, 38);
            this.btnBaixar.TabIndex = 0;
            this.btnBaixar.Text = "Baixar";
            this.btnBaixar.UseVisualStyleBackColor = true;
            this.btnBaixar.Click += new System.EventHandler(this.btnBaixar_Click);
            // 
            // txtSite
            // 
            this.txtSite.Location = new System.Drawing.Point(46, 22);
            this.txtSite.Name = "txtSite";
            this.txtSite.Size = new System.Drawing.Size(167, 20);
            this.txtSite.TabIndex = 1;
            // 
            // txtResultado
            // 
            this.txtResultado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtResultado.Location = new System.Drawing.Point(0, 66);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(225, 169);
            this.txtResultado.TabIndex = 2;
            this.txtResultado.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Site:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 273);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtSite);
            this.Controls.Add(this.btnBaixar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBaixar;
        private System.Windows.Forms.TextBox txtSite;
        private System.Windows.Forms.RichTextBox txtResultado;
        private System.Windows.Forms.Label label1;
    }
}

