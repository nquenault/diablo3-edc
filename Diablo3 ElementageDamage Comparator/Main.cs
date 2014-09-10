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

        private double gainCalc(double currentPC, double itemPC)
        {
            double newPC = currentPC + itemPC;

            currentPC = currentPC / 100 + 1;
            newPC = newPC / 100 + 1;
            double diffPC = newPC / currentPC;
            diffPC = (diffPC - 1) * 100;

            return diffPC;
        }

        private void Compute()
        {
            Color resBackColor =_defaultResColor;
            Color resForeColor = Color.Black;
            string res = "";

            try
            {
                double currentElementalDamage = double.Parse(ui_CurrentElementalDamage.Text.Replace(".", ","));
                double currentEliteDamage = double.Parse(ui_CurrentEliteDamage.Text.Replace(".", ","));
                double currentSkillDamage = double.Parse(ui_CurrentSkillDamage.Text.Replace(".", ","));

                double itemElementalDamage = double.Parse(ui_ItemElementalDamage.Text.Replace(".", ","));
                double itemEliteDamage = double.Parse(ui_ItemEliteDamage.Text.Replace(".", ","));
                double itemSkillDamage = double.Parse(ui_ItemSkillDamage.Text.Replace(".", ","));
                double dpsAddition = double.Parse(ui_DPSAddition.Text.Replace(".", ","));

                double gainElementalDamage = gainCalc(currentElementalDamage, itemElementalDamage);
                double gainEliteDamage = gainCalc(currentEliteDamage, itemEliteDamage);
                double gainSkillDamage = gainCalc(currentSkillDamage, itemSkillDamage);

                double gain = gainElementalDamage + gainEliteDamage + gainSkillDamage + dpsAddition;

                if (gain > 0)
                {
                    res = resultString.Replace("%res%", "better");
                    resBackColor = Color.Green; // Color.FromArgb(0, 192, 0);
                    resForeColor = Color.White;
                }
                else if (gain < 0)
                {
                    res = resultString.Replace("%res%", "worst");
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

        private void thisAppOnGoogleCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://diablo3-elementaldamage-comparator.googlecode.com/");
        }

        private void onMouseClick(object sender, MouseEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.SelectionStart = 0;
            textBox.SelectionLength = textBox.TextLength;
        }

        private void visitWebappVersionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://d3ec.nquenault.com/");
        }
    }
}
