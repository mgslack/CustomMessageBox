using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

/*
 * Primary class defines the dialog to be used by the custum message box class.
 *
 * Author:  M. G. Slack
 * Written: 2021-11-09
 *
 * ----------------------------------------------------------------------------
 * 
 * Updated: yyyy-mm-dd - xxxxx.
 * 
 */
namespace CustomMessageBox
{
    public partial class MsgBoxDlg : Form
    {
        #region Properties
        private IWin32Window _parent = null;
        public IWin32Window MsgBoxParent { get { return _parent; } set { _parent = value; } }

        private string _message = "";
        public string Message { get { return _message; } set { _message = value; } }

        private string _title = "";
        public string Title { get { return _title; } set { _title = value; } }

        private MessageBoxButtons _buttons = MessageBoxButtons.OK;
        public MessageBoxButtons Buttons { get { return _buttons; } set { _buttons = value; } }

        private MessageBoxIcon _icon = MessageBoxIcon.None;
        public MessageBoxIcon MsgBoxIcon { get { return _icon; } set { _icon = value; } }

        private MessageBoxIcon _sound = MessageBoxIcon.None;
        public MessageBoxIcon Sound { get { return _sound; } set { _sound = value; } }

        private SoundPlayer _customSound = null;
        public SoundPlayer CustomSound { get { return _customSound; } set { _customSound = value; } }

        private MessageBoxDefaultButton _defButton = MessageBoxDefaultButton.Button1;
        public MessageBoxDefaultButton DefButton { get { return _defButton; } set { _defButton = value; } }
        #endregion

        #region Constants
        private string T_ABORT = "&Abort";
        private string T_RETRY = "&Retry";
        private string T_IGNORE = "&Ignore";
        private string T_OK = "&OK";
        private string T_CANCEL = "&Cancel";
        private string T_YES = "&Yes";
        private string T_NO = "&No";
        private int ICON_WIDTH = 32;
        #endregion

        // --------------------------------------------------------------------

        #region Private Methods
        private void SetIconInDlg()
        {
            if (_icon == MessageBoxIcon.Error)  // .Hand and .Stop
            { // 16
                pbIcon.Image = SystemIcons.Error.ToBitmap();
            }
            else if (_icon == MessageBoxIcon.Question)
            { // 32
                pbIcon.Image = SystemIcons.Question.ToBitmap();
            }
            else if (_icon == MessageBoxIcon.Warning)  // .Exclamation
            { // 48
                pbIcon.Image = SystemIcons.Warning.ToBitmap();
            }
            else if (_icon == MessageBoxIcon.Information)  // .Asterisk
            { // 64
                pbIcon.Image = SystemIcons.Information.ToBitmap();
            }
            else
            {
                pbIcon.Dispose();
                // add size to label now
                lblMsg.Size = new Size(lblMsg.Size.Width + ICON_WIDTH, lblMsg.Size.Height);
            }
        }

        private void SetTextInDlg()
        {
            Size mSize = TextRenderer.MeasureText(_message, lblMsg.Font);
            int initWidth = lblMsg.Size.Width * 2; // 2 line label in dlg at start

            if (mSize.Width > initWidth)
            { // need to resize
                int delta = (mSize.Width - initWidth);
                if (delta > 0)
                {
                    this.Size = new Size(this.Size.Width + delta, this.Size.Height);
                    tlPanel.Size = new Size(tlPanel.Size.Width + delta, tlPanel.Size.Height);
                    lblMsg.Size = new Size(lblMsg.Size.Width + delta, lblMsg.Size.Height);
                }
            }

            lblMsg.Text = _message;
        }

        private void SetupButtons()
        {
            // default - MessageBoxButtons.OK
            button1.Text = T_OK; button1.DialogResult = DialogResult.OK;
            
            if (_buttons == MessageBoxButtons.AbortRetryIgnore)
            {
                button1.Text = T_ABORT; button1.DialogResult = DialogResult.Abort;
                button2.Visible = true; button2.Enabled = true;
                button2.Text = T_RETRY; button2.DialogResult = DialogResult.Retry;
                button3.Visible = true; button3.Enabled = true;
                button3.Text = T_IGNORE; button3.DialogResult = DialogResult.Ignore;
            }
            else if (_buttons == MessageBoxButtons.OKCancel)
            {
                // already have button1 setup
                button2.Visible = true; button2.Enabled = true;
                button2.Text = T_CANCEL; button2.DialogResult = DialogResult.Cancel;
            }
            else if (_buttons == MessageBoxButtons.RetryCancel)
            {
                button1.Text = T_RETRY; button1.DialogResult = DialogResult.Retry;
                button2.Visible = true; button2.Enabled = true;
                button2.Text = T_CANCEL; button2.DialogResult = DialogResult.Cancel;
            }
            else if (_buttons == MessageBoxButtons.YesNo || _buttons == MessageBoxButtons.YesNoCancel)
            {
                button1.Text = T_YES; button1.DialogResult = DialogResult.Yes;
                button2.Visible = true; button2.Enabled = true;
                button2.Text = T_NO; button2.DialogResult = DialogResult.No;
                if (_buttons == MessageBoxButtons.YesNoCancel)
                {
                    button3.Visible = true; button3.Enabled = true;
                    button3.Text = T_CANCEL; button3.DialogResult = DialogResult.Cancel;
                }
            }
        }

        private void PlaySound()
        {
            // use custom sound if set first
            if (_customSound != null)
            {
                try { _customSound.Play(); } catch (Exception) { }
            }
            else if (_sound != MessageBoxIcon.None)
            {
                if (_sound == MessageBoxIcon.Error)
                    SystemSounds.Hand.Play();
                else if (_sound == MessageBoxIcon.Information)
                    SystemSounds.Beep.Play(); // like beep versus SystemSounds.Asterisk.Play();
                else if (_sound == MessageBoxIcon.Question)
                    SystemSounds.Question.Play();
                else if (_sound == MessageBoxIcon.Warning)
                    SystemSounds.Exclamation.Play();
                else
                    SystemSounds.Asterisk.Play();
            }
        }
        #endregion

        // --------------------------------------------------------------------

        public MsgBoxDlg()
        {
            InitializeComponent();
        }

        // --------------------------------------------------------------------

        #region Event Handlers
        private void MsgBoxDlg_Load(object sender, EventArgs e)
        {
            SetIconInDlg();
            SetTextInDlg();
            SetupButtons();
            if (!"".Equals(_title)) Text = _title;
        }

        private void MsgBoxDlg_Shown(object sender, EventArgs e)
        {
            button1.Focus();
            if (_defButton == MessageBoxDefaultButton.Button2 && button2.Enabled)
                button2.Focus();
            else if (_defButton == MessageBoxDefaultButton.Button3 && button3.Enabled)
                button3.Focus();
        }
        #endregion

        // --------------------------------------------------------------------

        #region Public Methods (including hidden)
        public void SetDlgLocation(Point location)
        {
            StartPosition = FormStartPosition.Manual;
            Location = location;
        }

        public void SetDlgLocation(int x, int y)
        {
            SetDlgLocation(new Point(x, y));
        }

        public new DialogResult ShowDialog()
        {
            PlaySound();
            return base.ShowDialog();
        }

        public new DialogResult ShowDialog(IWin32Window parent)
        {
            PlaySound();
            return base.ShowDialog(parent);
        }
        #endregion
    }
}
