using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atiran.Rahyab
{
    public class Default:Form
    {
        public Default()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Default
            // 
            this.ClientSize = new System.Drawing.Size(883, 457);
            this.Name = "Default";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Default_Load);
            this.ResumeLayout(false);

        }

        private void Default_Load(object sender, EventArgs e)
        {
            var offline = new Base.TraceOffline();
            offline.Dock = DockStyle.Fill;
            this.Controls.Add(offline);
        }
    }
}
