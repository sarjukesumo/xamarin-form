﻿using System;
using Android.Content;
using Android.Widget;
using MikePhil.Charting.Charts;
using UltimateXF.Droid.Renderers;
using UltimateXF.Widget.Charts;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(SupportRadarChart), typeof(SupportRadarChartRenderer))]
namespace UltimateXF.Droid.Renderers
{
    public class SupportRadarChartRenderer : ViewRenderer<SupportRadarChart, RadarChart>
    {
        private SupportRadarChart supportChart;
        private RadarChart chartOriginal;

        public SupportRadarChartRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<SupportRadarChart> e)
        {
            base.OnElementChanged(e);
            if (e.NewElement != null)
            {
                if (Element is SupportRadarChart)
                {
                    supportChart = Element as SupportRadarChart;
                    chartOriginal = new RadarChart(this.Context);
                    chartOriginal.LayoutParameters = new LinearLayout.LayoutParams(LinearLayout.LayoutParams.MatchParent, LinearLayout.LayoutParams.MatchParent);
                    InitializeChart();
                    SetNativeControl(chartOriginal);
                }
            }
        }

        private void InitializeChart()
        {
            //if (supportChart != null && supportChart.ChartData != null && chartOriginal != null)
            //{
            //    var data = supportChart.ChartData.IF_GetDataSet();

            //    var entryOriginal = data.IF_GetEntry().Select(item => new MikePhil.Charting.Data.PieEntry(item.GetPercent(), item.GetText()));
            //    PieDataSet lineDataSet = new PieDataSet(entryOriginal.ToArray(), data.IF_GetTitle());
            //    lineDataSet.SetColors(data.IF_GetEntry().Select(item => item.GetColorFill().ToAndroid().ToArgb()).ToArray());
            //    PieData lineData = new PieData(lineDataSet);
            //    lineData.SetValueFormatter(new PercentFormatter());
            //    lineData.SetValueTextSize(supportChart.ChartData.ValueDisplaySize);
            //    lineData.SetValueTextColor(supportChart.ChartData.ValueDisplayColor.ToAndroid());
            //    chartOriginal.SetEntryLabelColor(supportChart.ChartData.TextDisplayColor.ToAndroid());
            //    chartOriginal.SetEntryLabelTextSize(supportChart.ChartData.TextDisplaySize);
            //    chartOriginal.Data = lineData;
            //}
        }
    }
}