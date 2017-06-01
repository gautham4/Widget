using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Okta
{
    public interface OktaWidgetInterface
    {
        int displayWidget(long parent);
    }

    public class OktaWidgetClass : OktaWidgetInterface
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /*[STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }*/

        public int displayWidget(long parent)
        {

            Form form = new Form1();
            var result = form.ShowDialog(new WindowWrapper(new IntPtr(parent)));
            if(result == DialogResult.OK)
            {
                return 1;
            }

            return 0;
        }
    }

    public class WindowWrapper : System.Windows.Forms.IWin32Window
    {
        public WindowWrapper(IntPtr handle)
        {
            _hwnd = handle;
        }

        public IntPtr Handle
        {
            get { return _hwnd; }
        }

        private IntPtr _hwnd;
    }

}
