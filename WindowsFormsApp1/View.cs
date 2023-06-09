﻿using System.Windows.Forms;
using LiveChartsCore.SkiaSharpView.WinForms;
using System;

namespace WindowsFormsApp1
{
    public partial class View : UserControl
    {
        private readonly CartesianChart cartesianChart;
        public View()
        {
            InitializeComponent();
            Size = new System.Drawing.Size(50, 50);

            var viewModel = new ViewModel();

            cartesianChart = new CartesianChart
            {
                Series = viewModel.Series,
                Title = viewModel.Title,
                ZoomMode = LiveChartsCore.Measure.ZoomAndPanMode.X,
                // out of livecharts properties...
                Location = new System.Drawing.Point(0, 0),
                Size = new System.Drawing.Size(50, 50),
                Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top | AnchorStyles.Bottom
            };

            Controls.Add(cartesianChart);
        }

        private void View_Load(object sender, System.EventArgs e)
        {

        }
    }
}
