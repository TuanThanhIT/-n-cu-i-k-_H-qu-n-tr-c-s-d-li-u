﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DemoCSDL.ActiveInForms;

namespace DemoCSDL.Forms
{
    public partial class FWorker : Form
    {
        public FWorker()
        {
            InitializeComponent();
        }

        private void FWorker_Load(object sender, EventArgs e)
        {
            Active.OpenChildForm(new WorkerChildForms.FWMenu(), ref Active.activeForm, panelFill);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Active.OpenChildForm(new WorkerChildForms.FWMenu(), ref Active.activeForm, panelFill);
        }
        private void btnSideBar_Click(object sender, EventArgs e)
        {
            if (panelLeft.Visible == false)
            {
                panelLeft.Visible = true;
            }
            else
            {
                panelLeft.Visible = false;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            FLogin fLogin = new FLogin();
            fLogin.ShowDialog();
            this.Close();
        }

        private void btnCa_Click(object sender, EventArgs e)
        {
            Active.OpenChildForm(new WorkerChildForms.FWShift(), ref Active.activeForm, panelFill);
        }

        private void btnThongTin_Click(object sender, EventArgs e)
        {
            Active.OpenChildForm(new WorkerChildForms.FWinformation(), ref Active.activeForm, panelFill);
        }
    }
}
