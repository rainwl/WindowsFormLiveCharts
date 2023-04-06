using CommunityToolkit.Mvvm.ComponentModel;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView.VisualElements;
using SkiaSharp;
using System;

namespace WindowsFormsApp1
{
    [ObservableObject]
    public partial class ViewModel
    {
        public ViewModel()
        {
            var values = new int[100];
            var r = new Random();
            var t = 0;
            for (var i = 0; i < 100; i++)
            {
                t += r.Next(-90, 100);
                values[i] = t;
            }
            Series = new ISeries[]
            {
                new LineSeries<int> { Values = values},
                new LineSeries<double>
                {
                    Values = new double[] { 2, 1, 3, 5, 3, 4, 6,2, 1, 3, 5, 3, 4, 6 },
                    Fill = null,
                    LineSmoothness = 1
                }
            };
        }

        public ISeries[] Series { get; set; } =
            {
                new LineSeries<double>
                {
                    Values = new double[] { 2, 1, 3, 5, 3, 4, 6,2, 1, 3, 5, 3, 4, 6 },
                    Fill = null,
                    LineSmoothness = 1
                }
            };

        public LabelVisual Title { get; set; } =
            new LabelVisual
            {
                Text = "Rain chart title",
                TextSize = 25,
                Padding = new LiveChartsCore.Drawing.Padding(15),
                Paint = new SolidColorPaint(SKColors.DarkSlateGray)
            };
    }
}
