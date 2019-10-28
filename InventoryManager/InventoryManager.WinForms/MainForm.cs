using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using IntentoryManager.Data;
using System.IO;

namespace InventoryManager.WinForms
{
    public partial class MainForm : Form
    {
        private World World { get => mWorld; set => mWorld = value; }

        public MainForm()
        {
            InitializeComponent();
        }

        private void SelectFileButton_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                World = JsonConvert.DeserializeObject<World>(File.ReadAllText(openFileDialog.FileName));
                fileTextBox.Text = openFileDialog.FileName;
            }
        }

        private World mWorld;
    }
}
