﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLSLQueueingApp
{
    public partial class Page3 : UserControl
    {
        public static Page3 _instance; // New page
        public static Page3 Instance // New page
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Page3();
                }
                return _instance;
            }
        }
        public Page4 Page4 { get; set; }
        public Panel pagePanel { get; set; }
        
        public Page3()
        {
            InitializeComponent();
            BackColor = ColorTranslator.FromHtml("#21282E");
            page3BackBtn.BackColor = ColorTranslator.FromHtml("#21282E");
 
        }

        private void Page3_Load(object sender, EventArgs e)
        {
            normalLaneBtn.BackColor = ColorTranslator.FromHtml("#21282E");
            priorityLaneBtn.BackColor = ColorTranslator.FromHtml("#21282E");
            page3BackBtn.BackColor = ColorTranslator.FromHtml("#21282E");
        }


        private void page3BackBtn_Click_1(object sender, EventArgs e)
        {
            
        }

        private void normalLaneBtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
