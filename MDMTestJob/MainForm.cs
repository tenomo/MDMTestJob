﻿using MDMTestJob.Domian.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDMTestJob
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            MdmTestJob_dbEntities db = new MdmTestJob_dbEntities();
            this.dataGridView1.DataSource = db.Customers.ToList();
            
        }
    }
}
