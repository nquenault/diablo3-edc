using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace Diablo3_ElementageDamage_Comparator
{
    public partial class Main : Form
    {
        private string resultString
        {
            get
            {
                return "The new item is %res% than your current item";
            }
        }

        private Color _defaultResColor;

        public Main()
        {
            InitializeComponent();

            ui_Result.Text = "";
            _defaultResColor = ui_Result.BackColor;
        }

        private void Compute()
        {
            Color resBackColor =_defaultResColor;
            Color resForeColor = Color.Black;
            string res = "";

            try
            {
                double currentPC = double.Parse(ui_CurrentPC.Text.Replace(".", ","));
                double itemPC = double.Parse(ui_ItemPC.Text.Replace(".", ","));
                double DPSAddition = double.Parse(ui_DPSAddition.Text.Replace(".", ","));
                double newPC = currentPC + itemPC;

                currentPC = currentPC / 100 + 1;
                newPC = newPC / 100 + 1;
                double diffPC = newPC / currentPC;
                diffPC = (diffPC - 1) * 100;

                double gain = diffPC + DPSAddition;

                if (gain > 0)
                {
                    res = resultString.Replace("%res%", "better");
                    resBackColor = Color.Green; // Color.FromArgb(0, 192, 0);
                    resForeColor = Color.White;
                }
                else if (gain < 0)
                {
                    res = resultString.Replace("%res%", "worth");
                    resBackColor = Color.Red;
                    resForeColor = Color.White;
                }
                else
                {
                    res = resultString.Replace("%res%", "equals");
                    resBackColor = Color.Orange;
                    resForeColor = Color.White;
                }

                res += " (gain " + Math.Round(gain, 2).ToString() + "% dps)";
            }
            catch (Exception ex)
            {
                res = ex.Message;
            }
            finally
            {
                ui_Result.Text = res;
                ui_Result.BackColor = resBackColor;
                ui_Result.ForeColor = resForeColor;
            }
        }

        private void onTextChanged(object sender, EventArgs e)
        {
            Compute();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void alwaysOnTopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.TopMost = alwaysOnTopToolStripMenuItem.Checked;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://diablo3-elementaldamage-comparator.googlecode.com/");
        }
    }
}
