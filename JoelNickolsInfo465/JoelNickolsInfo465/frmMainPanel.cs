﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace JoelNickolsInfo465
{
    public partial class frmMainPanel : Form
    {
        
        public frmMainPanel()
        {
            InitializeComponent();
        }

        

        private void frmMainPanel_Load(object sender, EventArgs e)
        {
             
            lblAdvice.Text ="hello";
        }
    }


}
