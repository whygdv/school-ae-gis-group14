using System;
using System.Collections.Generic;
using System.ComponentModel;
using ESRI.ArcGIS.Geometry;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AE_GIS_DEV_GROUP_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void axMapControl1_OnMouseDown(object sender, ESRI.ArcGIS.Controls.IMapControlEvents2_OnMouseDownEvent e)
        {
            //鼠标中键移动地图
            if (e.button == 4) { 
                 axMapControl1.Pan();
            }                    
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            //axMapControl1.CenterAt(22, 22);
        }
    }
}
