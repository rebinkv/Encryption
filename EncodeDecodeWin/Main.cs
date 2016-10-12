namespace EncodeDecodeWin
{
    using Encryption;
    using ResultDetails;
    using System;
    using System.Windows.Forms;

    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        Result resultObject = new Result();

        private void radioButtonEncode_CheckedChanged(object sender, EventArgs e)
        {
            inputEncodedText.Enabled = radioButtonDecode.Checked;
            btnDecode.Enabled = radioButtonDecode.Checked;
            displayPlainText.Enabled = radioButtonDecode.Checked;
            labelDecode.Enabled = radioButtonDecode.Checked;
            labelDecodeEncodedText.Enabled = radioButtonDecode.Checked;
            labelPlainText.Enabled = radioButtonDecode.Checked;
            this.labelEncodePlainText.ForeColor = System.Drawing.Color.Black;
        }

        private void btnEncode_Click(object sender, EventArgs e)
        {
            Base64Encoder encoderObject = new Base64Encoder();
            resultObject = encoderObject.Encode(this.inputPlainText.Text);

            if (resultObject.Status == true)
            {
                this.labelEncodePlainText.ForeColor = System.Drawing.Color.Black;
                this.displayEncodedText.Text = resultObject.Data;
            }
            else
            {
                MessageBox.Show(resultObject.Data);
                this.labelEncodePlainText.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void radioButtonDecode_CheckedChanged(object sender, EventArgs e)
        {
            inputPlainText.Enabled = radioButtonEncode.Checked;
            insertEncodedText.Enabled = radioButtonEncode.Checked;
            displayEncodedText.Enabled = radioButtonEncode.Checked;
            labelEncode.Enabled = radioButtonEncode.Checked;
            labelEncodePlainText.Enabled = radioButtonEncode.Checked;
            labelEnodeEncodedText.Enabled = radioButtonEncode.Checked;
            this.labelDecodeEncodedText.ForeColor = System.Drawing.Color.Black;
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            Base64Decoder encoderObject = new Base64Decoder();
            resultObject = encoderObject.Decode(this.inputEncodedText.Text);
            if (resultObject.Status == true)
            {
                //Base64Decoder decoderObject = new Base64Decoder();
                //string encodedText = this.inputEncodedText.Text;
                //string plainText = decoderObject.Decode(this.inputEncodedText.Text);
                this.labelDecodeEncodedText.ForeColor = System.Drawing.Color.Black;
                this.displayPlainText.Text = resultObject.Data;
            }
            else
            {
                MessageBox.Show(resultObject.Data);
                this.labelDecodeEncodedText.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void textboxEncode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnEncode_Click(sender, e);
            }
        }

        private void textboxDecode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDecode_Click(sender, e);
            }
        }
    }
}