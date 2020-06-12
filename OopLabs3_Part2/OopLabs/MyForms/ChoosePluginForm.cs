using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PluginsInterface;

namespace OopLabs
{
    public partial class ChoosePluginForm : Form
    {
        MainForm.UpdateMethod reqMethod;
        List<IPlugin> reqPluginsList;
        public ChoosePluginForm(MainForm.UpdateMethod method, List<IPlugin> pluginsList)
        {
            InitializeComponent();

            cmbChoosePlugin.Items.Add("None");
            foreach (IPlugin curPlugin in pluginsList)
            {
                if (curPlugin != null)
                    cmbChoosePlugin.Items.Add(curPlugin.GetType().Name);
            }

            reqMethod = method;
            reqPluginsList = pluginsList;
            MainForm.window.Enabled = false;
            this.Show();
        }

        

        private void btnChoosePlugin_Click(object sender, EventArgs e)
        {
            reqMethod(reqPluginsList, cmbChoosePlugin.SelectedIndex);            
            this.Close();
        }

        private void ChoosePluginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.window.Enabled = true;
        }
    }
}
