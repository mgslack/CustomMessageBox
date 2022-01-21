# CustomMessageBox

CustomMessageBox class.  Main reason created, no control over sounds played (played or not) unless losing
the icon image displayed also.  Other differences, defaults to centering in parent (if parent form
provided) and will use a 2 line display and stretch out from that instead of a one line.  Also,
has ability to set position in parent form.

Full Form call:

DialogResult res = MsgBox.Show(IWin32Window parent, string message, string title,
    MessageBoxButtons buttons, MessageBoxIcon icon, MessageBoxIcon sound, SoundPlayer customSnd,
    MessageBoxDefaultButton defBtn, Point location);

Various other forms of the call provided including one to return the message box dialog to
show and work with programatically.

Should use the stock MessageBox.Show(xxx) if need help context or other options or
not going to use icon or care about sound.

Includes a test application to try out different configurations to check out the MsgBox.Show call.

Created and built using VS 2019.
