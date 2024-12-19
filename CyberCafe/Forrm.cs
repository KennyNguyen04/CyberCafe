using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyberCafe
{
    public partial class Form : UserControl
    {
        public Form()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
            // Kiểm tra trạng thái của Panel
            if (!panelchuongtrinh.Visible)
            {
                // Hiển thị Panel tại vị trí phù hợp
                panelchuongtrinh.Location = new Point(toolStripMenuItem1.Bounds.Left, toolStripMenuItem1.Bounds.Bottom);
                panelchuongtrinh.Visible = true;
            }
            else
            {
                // Ẩn Panel
                panelchuongtrinh.Visible = false;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void Form_Load(object sender, EventArgs e)
        {

        }

        private void Form_MouseClick(object sender, MouseEventArgs e)
        {
            if (!panelchuongtrinh.Bounds.Contains(e.Location))
            {
                panelchuongtrinh.Visible = false;
            }
        }
    }
}
