using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ActiveProcessWindowUtils.Utils;

namespace ActiveProcessWindowUtils
{
    public partial class updateCEWindowForm : Form
    {
        public updateCEWindowForm()
        {
            InitializeComponent();
        }

        GetProcess getProcess = new GetProcess();
        private void radioButtonSetTop_CheckedChanged(object sender, EventArgs e)
        {
            getProcess.TopMost(comboBoxProcess.SelectedIndex);
        }

        private void radioButtonSetNotTop_CheckedChanged(object sender, EventArgs e)
        {
            getProcess.NoTopMost(comboBoxProcess.SelectedIndex);
        }

        private void trackBarOpaque_Scroll(object sender, EventArgs e)
        {
            byte opageLevel = (byte)(255 - trackBarOpaque.Value);
            getProcess.Opaque(opageLevel, comboBoxProcess.SelectedIndex);
        }

        private void updateCEWindowForm_Load(object sender, EventArgs e)
        {
            createComboBox();
        }

        private ComboBox comboBoxProcess = new ComboBox();
        private void createComboBox()
        {
            // Creating and setting the properties of comboBox
            comboBoxProcess.Location = new Point(13, 15);
            comboBoxProcess.Size = new Size(260, 24);
            comboBoxProcess.DropDownStyle = ComboBoxStyle.DropDownList;
            //get list of processes and add to combobox
            foreach (string process in getProcess.LoadProcesses())
            {
                comboBoxProcess.Items.Add(process);
            }
            // Add this ComboBox to the form
            this.Controls.Add(comboBoxProcess);
        }

    }
}
