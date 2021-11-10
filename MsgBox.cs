using System.Windows.Forms;
using System.Drawing;
using System.Media;

/*
 * CustomMessageBox class.  Main reason, no control over sounds played (played or not) unless losing
 * the icon image displayed also.  Other differences, defaults to centering in parent (if parent form
 * provided) and will use a 2 line display and stretch out from that instead of a one line.  Also,
 * has ability to set position in parent form.
 * Full Form call:
 * DialogResult res = MsgBox.Show(IWin32Window parent, string message, string title,
 *     MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxIcon sound, SoundPlayer customSnd,
 *     MessageBoxDefaultButton defBtn, Point location);
 * Various other forms of the call provided including one to return the message box dialog to
 * show and work with programatically.
 * Should use the stock MessageBox.Show(xxx) if need help context or other options or
 * not going to use icon or care about sound.
 * 
 * Author: Michael G. Slack
 * Written: 2021-11-09
 * Version: 1.0.0.0
 * 
 * ----------------------------------------------------------------------------
 * 
 * Updated: yyyy-mm-dd - xxxxx.
 * 
 */
namespace CustomMessageBox
{
    public class MsgBox
    {
        public static DialogResult Show(IWin32Window parent, string message, string title,
            MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxIcon sound,
            SoundPlayer customSnd, MessageBoxDefaultButton defBtn, Point location)
        {
            DialogResult res;
            MsgBoxDlg dlg = new MsgBoxDlg
            {
                MsgBoxParent = parent,
                Message = message.Trim(),
                Title = title.Trim(),
                Buttons = buttons,
                MsgBoxIcon = icon,
                Sound = sound,
                CustomSound = customSnd,
                DefButton = defBtn
            };

            if (location != null && location != Point.Empty)
                dlg.SetDlgLocation(location);
            if (parent != null)  
                res = dlg.ShowDialog(parent);
            else
                res = dlg.ShowDialog();
            dlg.Dispose();
            return res;
        }

        public static DialogResult Show(string message, string title,
            MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxIcon sound,
            SoundPlayer customSnd, MessageBoxDefaultButton defBtn, Point location)
        {
            return Show(null, message, title, buttons, icon, sound, customSnd, defBtn, location);
        }

        public static DialogResult Show(IWin32Window parent, string message, string title,
            MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxIcon sound,
            SoundPlayer customSnd)
        {
            return Show(parent, message, title, buttons, icon, sound, customSnd, 
                MessageBoxDefaultButton.Button1, Point.Empty);
        }

        public static DialogResult Show(string message, string title, MessageBoxButtons buttons,
            MessageBoxIcon icon, MessageBoxIcon sound, SoundPlayer customSnd)
        {
            return Show(null, message, title, buttons, icon, sound, customSnd);
        }

        public static DialogResult Show(IWin32Window parent, string message, string title,
            MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxIcon sound)
        {
            return Show(parent, message, title, buttons, icon, sound, null);
        }

        public static DialogResult Show(string message, string title, MessageBoxButtons buttons,
            MessageBoxIcon icon, MessageBoxIcon sound)
        {
            return Show(null, message, title, buttons, icon, sound);
        }

        public static DialogResult Show(IWin32Window parent, string message, string title,
            MessageBoxButtons buttons, MessageBoxIcon icon, SoundPlayer customSnd)
        {
            return Show(parent, message, title, buttons, icon, MessageBoxIcon.None, customSnd);
        }

        public static DialogResult Show(string message, string title, MessageBoxButtons buttons,
            MessageBoxIcon icon, SoundPlayer customSnd)
        {
            return Show(null, message, title, buttons, icon, customSnd);
        }

        public static DialogResult Show(IWin32Window parent, string message, string title,
            MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            return Show(parent, message, title, buttons, icon, MessageBoxIcon.None, null);
        }

        public static DialogResult Show(string message, string title, MessageBoxButtons buttons,
            MessageBoxIcon icon)
        {
            return Show(null, message, title, buttons, icon);
        }

        public static MsgBoxDlg CreateMsgBoxDlg()
        {
            return new MsgBoxDlg();
        }
    }
}
