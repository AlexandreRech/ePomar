namespace Uniplac.ePomar.WindowsApp.Controls.RelatorioForms
{
    partial class RelatorioProdutosDialog
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.produtoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.produtoesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // chart
            // 
            chartArea1.CursorX.Interval = 10D;
            chartArea1.CursorX.IntervalOffset = 10D;
            chartArea1.CursorY.Interval = 10D;
            chartArea1.CursorY.IntervalOffset = 10D;
            chartArea1.Name = "ChartArea1";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 91F;
            chartArea1.Position.Width = 67.15659F;
            chartArea1.Position.X = 3F;
            chartArea1.Position.Y = 9F;
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.DataSource = this.produtoesBindingSource;
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(1, -3);
            this.chart.Name = "chart";
            this.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            this.chart.Size = new System.Drawing.Size(563, 441);
            this.chart.TabIndex = 0;
            this.chart.Text = "chart1";
            // 
            // RelatorioProdutosDialog
            // 
            this.ClientSize = new System.Drawing.Size(564, 437);
            this.Controls.Add(this.chart);
            this.Name = "RelatorioProdutosDialog";
            this.Text = "Relatório de produtos em estoque";
            ((System.ComponentModel.ISupportInitialize)(this.produtoesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.BindingSource produtoesBindingSource;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        
    }
}