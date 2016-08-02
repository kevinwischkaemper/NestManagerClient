using NestManagerLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NestManagerClientInterface
{
    public partial class Form1 : Form
    {
        NestManager NestManager;
        public Form1()
        {
            InitializeComponent();
            dgvMainView.AllowUserToAddRows = false;
            NestManager = new NestManager(dgvMainView, comboThickness, btnRemoveNest, btnPromoteNest, btnCustomNest, true);
        }
    }
}
