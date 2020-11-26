using Gecko;
using Gecko.WebIDL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soundcloud
{
    public partial class SoundCloud : Form
    {
        public SoundCloud()
        {
            InitializeComponent();
            string user_agent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/83.0.4103.61 Safari/537.36 Edg/83.0.478.37";
            Xpcom.Initialize("Firefox");
            Gecko.GeckoPreferences.User["general.useragent.override"] = user_agent;

            geckoWebBrowser1.Navigate("m.soundcloud.com");

            geckoWebBrowser1.Document.Body.Style.CssText = "::-webkit-scrollbar {display:none;}";
        }
    }
}
