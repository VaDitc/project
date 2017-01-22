﻿using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace WCSC
{
    public partial class WeightInformation : Form
    {
        public WeightInformation()
        {
            InitializeComponent();
            StartShowTimeDate();
            DrawGrph();
        }

        private void WeightInformation_Load(object sender, EventArgs e)
        {

        }
        private void StartShowTimeDate()
        {
            Timer timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_tick);
            timer1.Interval = 100;
            timer1.Start();
        }

        public void timer1_tick(object sender, EventArgs e)
        {
            DateTime ThToday = DateTime.Now;
            string ThData = ThToday.Date.ToShortDateString();
            string ThTime = ThToday.ToLongTimeString();
            this.textBox1.Text = ThData;
            this.textBox2.Text = ThTime;
        }

        public void DrawGrph()
        {
            cartesianChart3.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Производительность:",
                    Values = new ChartValues<double> {0.4, 0.4, 0.6, 0.9, 0.9, 0.6, 0.5, 0.5, 0.5, 0.7 }
                },
            };

            cartesianChart3.AxisX.Add(new Axis
            {
               // Title = "Month",
                Labels = new[] { "12:09:38\n23.11.06", "12:09:38\n23.11.06", "12:10:38\n23.11.06", "12:11:38\n23.11.06", "12:12:38\n23.11.06"
                , "12:13:38\n23.11.06", "12:14:38\n23.11.06", "12:15:38\n23.11.06", "12:16:38\n23.11.06", "12:17:38\n23.11.06" },
                Separator = new Separator
                {
                    Step = 1

                },

                Foreground = System.Windows.Media.Brushes.Black
            });

            cartesianChart3.AxisY.Add(new Axis
            {
                Title = "Производительность, т/ч",
                LabelFormatter = value => value.ToString("N"),
                Foreground = System.Windows.Media.Brushes.Black,
                MinValue = 0
            });
            //////////////////////////////////////////////////////////
            cartesianChart2.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Вес:",
                    Values = new ChartValues<double> {40, 40, 60, 90, 90, 96, 100, 100, 150, 170 }
                },
            };

            cartesianChart2.AxisX.Add(new Axis
            {
                Labels = new[] { "", "", "", "", ""
                , "", "", "", "", "" }
            });

            cartesianChart2.AxisY.Add(new Axis
            {
                Title = "Вес, т",
                LabelFormatter = value => value.ToString("N"),
                Foreground = System.Windows.Media.Brushes.Black,
                MinValue = 0
            });
            //////////////////////////////////////////
            cartesianChart1.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Скорость:",
                    Values = new ChartValues<double> {0.4, 0.4, 0.6, 0.9, 0.9, 0.6, 0.5, 0.5, 0.5, 0.7 }
                },
            };

            cartesianChart1.AxisX.Add(new Axis
            {
                Labels = new[] { "", "", "", "", ""
                , "", "", "", "", "" }
            });

            cartesianChart1.AxisY.Add(new Axis
            {
                Title = "Скорость, м/с",
                LabelFormatter = value => value.ToString("N"),
                Foreground = System.Windows.Media.Brushes.Black,
                MinValue = 0
            });



        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }
    }
 }
