namespace Uniplac.ePomar.WindowsApp.Controls.FornecedorForms
{
    partial class FornecedorControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listFornecedores = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listFornecedores
            // 
            this.listFornecedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listFornecedores.FormattingEnabled = true;
            this.listFornecedores.Location = new System.Drawing.Point(0, 0);
            this.listFornecedores.Name = "listFornecedores";
            this.listFornecedores.Size = new System.Drawing.Size(323, 262);
            this.listFornecedores.TabIndex = 0;
            // 
            // FornecedorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listFornecedores);
            this.Name = "FornecedorControl";
            this.Size = new System.Drawing.Size(323, 262);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listFornecedores;
    }
}
