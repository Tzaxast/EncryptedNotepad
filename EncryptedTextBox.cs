using Crypto;
using System;
using System.Windows.Forms;

namespace Encrypted_Notepad
{

    public class EncryptedTextBox : TextBox
    {
        private EncryptedString enc;

        public override string Text
        {

            get
            {
                enc = base.Text;
                return enc;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    base.Text = value;
                    OnTextChanged(EventArgs.Empty);
                    return;
                }
                enc = value;
                base.Text = enc;
                OnTextChanged(EventArgs.Empty);
            }

        }
    }
}
