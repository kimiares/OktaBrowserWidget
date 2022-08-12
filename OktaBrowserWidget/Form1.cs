using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OktaBrowserWidget
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void InitializeChromium()
        {
            CefSettings settings = new CefSettings();
            // Initialize cef with the provided settings
            Cef.Initialize(settings);
            // Create a browser component
            var chromeBrowser = new ChromiumWebBrowser("www.google.com");
            // Add it to the form and fill it to the form window.
            this.Controls.Add(chromeBrowser);
            string html = System.IO.File.ReadAllText(@"C:\Users\3211553\source\repos\OKTAtest\OKTAtest\HTMLPage1.html");
            chromeBrowser.LoadHtml(html);
            //chromeBrowser.Dock = DockStyle.Fill;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Cef.Shutdown();
        }
    }
}
