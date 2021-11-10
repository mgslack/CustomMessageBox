using System;
using System.Drawing;
using System.IO;
using System.Media;
using System.Reflection;
using System.Windows.Forms;
using CustomMessageBox;

/*
 * Test application for the CustomMessageBox class.
 * 
 * Author: Michael G. Slack
 * Written: 2021-11-10
 * Version: 1.0.0.0
 * 
 * ----------------------------------------------------------------------------
 * 
 * Updated: yyyy-mm-dd - xxxxx.
 * 
 */
namespace CustomMessageBoxTest
{
    public partial class MainWin : Form
    {
        private const string SOUND_NAMESPACE = "CustomMessageBoxTest.sounds.beep.wav";

        private SoundPlayer beepSound = null;
        private bool bSoundLoaded = false;

        private Stream GetResourceStream(string path)
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            return asm.GetManifestResourceStream(path);
        }

        private void LoadSoundPlayer()
        {
            try
            {
                beepSound = new SoundPlayer(GetResourceStream(SOUND_NAMESPACE));
                bSoundLoaded = true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Wav (" + SOUND_NAMESPACE + "): " + e.Message, this.Text);
                beepSound = null;
            }
        }

        public MainWin()
        {
            InitializeComponent();
        }

        private void MainWin_Load(object sender, EventArgs e)
        {
            LoadSoundPlayer();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            IWin32Window parent = null;
            string message = tMsg.Text, title = tTitle.Text;
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBoxIcon icon = MessageBoxIcon.None, sound = MessageBoxIcon.None;
            MessageBoxDefaultButton defBtn = MessageBoxDefaultButton.Button1;
            SoundPlayer lcl = null;

            if (cbParent.Checked) parent = this;

            if (rbOKC.Checked)
                buttons = MessageBoxButtons.OKCancel;
            else if (rbYN.Checked)
                buttons = MessageBoxButtons.YesNo;
            else if (rbARI.Checked)
                buttons = MessageBoxButtons.AbortRetryIgnore;

            if (rbIErr.Checked)
                icon = MessageBoxIcon.Error;
            else if (rbIInf.Checked)
                icon = MessageBoxIcon.Information;
            else if (rbIQ.Checked)
                icon = MessageBoxIcon.Question;
            else if (rbIWarn.Checked)
                icon = MessageBoxIcon.Warning;

            if (rbSCust.Checked)
            {
                if (bSoundLoaded) lcl = beepSound;
            }
            else
            {
                if (rbSErr.Checked)
                    sound = MessageBoxIcon.Error;
                else if (rbSInf.Checked)
                    sound = MessageBoxIcon.Information;
                else if (rbSQ.Checked)
                    sound = MessageBoxIcon.Question;
                else if (rbSWarn.Checked)
                    sound = MessageBoxIcon.Warning;
            }

            if (rb2.Checked)
                defBtn = MessageBoxDefaultButton.Button2;
            else if (rb3.Checked)
                defBtn = MessageBoxDefaultButton.Button3;

            DialogResult res = MsgBox.Show(parent, message, title, buttons, icon, sound, lcl, defBtn,
                Point.Empty);
            lblRes.Text = "" + res;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
