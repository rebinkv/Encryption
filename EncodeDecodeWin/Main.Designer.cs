namespace EncodeDecodeWin
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelEncodePlainText = new System.Windows.Forms.Label();
            this.inputPlainText = new System.Windows.Forms.TextBox();
            this.displayEncodedText = new System.Windows.Forms.TextBox();
            this.labelEnodeEncodedText = new System.Windows.Forms.Label();
            this.insertEncodedText = new System.Windows.Forms.Button();
            this.btnDecode = new System.Windows.Forms.Button();
            this.displayPlainText = new System.Windows.Forms.TextBox();
            this.labelPlainText = new System.Windows.Forms.Label();
            this.inputEncodedText = new System.Windows.Forms.TextBox();
            this.labelDecodeEncodedText = new System.Windows.Forms.Label();
            this.labelEncode = new System.Windows.Forms.Label();
            this.labelDecode = new System.Windows.Forms.Label();
            this.radioButtonEncode = new System.Windows.Forms.RadioButton();
            this.radioButtonDecode = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // labelEncodePlainText
            // 
            this.labelEncodePlainText.AutoSize = true;
            this.labelEncodePlainText.Location = new System.Drawing.Point(74, 75);
            this.labelEncodePlainText.Name = "labelEncodePlainText";
            this.labelEncodePlainText.Size = new System.Drawing.Size(54, 13);
            this.labelEncodePlainText.TabIndex = 0;
            this.labelEncodePlainText.Text = "Plain Text";
            // 
            // inputPlainText
            // 
            this.inputPlainText.Location = new System.Drawing.Point(161, 72);
            this.inputPlainText.Name = "inputPlainText";
            this.inputPlainText.Size = new System.Drawing.Size(405, 20);
            this.inputPlainText.TabIndex = 1;
            this.inputPlainText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textboxEncode_KeyDown);
            // 
            // displayEncodedText
            // 
            this.displayEncodedText.Location = new System.Drawing.Point(161, 121);
            this.displayEncodedText.Name = "displayEncodedText";
            this.displayEncodedText.Size = new System.Drawing.Size(405, 20);
            this.displayEncodedText.TabIndex = 3;
            // 
            // labelEnodeEncodedText
            // 
            this.labelEnodeEncodedText.AutoSize = true;
            this.labelEnodeEncodedText.Location = new System.Drawing.Point(66, 124);
            this.labelEnodeEncodedText.Name = "labelEnodeEncodedText";
            this.labelEnodeEncodedText.Size = new System.Drawing.Size(74, 13);
            this.labelEnodeEncodedText.TabIndex = 2;
            this.labelEnodeEncodedText.Text = "Encoded Text";
            // 
            // insertEncodedText
            // 
            this.insertEncodedText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertEncodedText.Location = new System.Drawing.Point(594, 70);
            this.insertEncodedText.Name = "insertEncodedText";
            this.insertEncodedText.Size = new System.Drawing.Size(75, 23);
            this.insertEncodedText.TabIndex = 4;
            this.insertEncodedText.Text = "Encode";
            this.insertEncodedText.UseVisualStyleBackColor = true;
            this.insertEncodedText.Click += new System.EventHandler(this.btnEncode_Click);
            // 
            // btnDecode
            // 
            this.btnDecode.Enabled = false;
            this.btnDecode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecode.Location = new System.Drawing.Point(594, 179);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(75, 23);
            this.btnDecode.TabIndex = 9;
            this.btnDecode.Text = "Decode";
            this.btnDecode.UseVisualStyleBackColor = true;
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // displayPlainText
            // 
            this.displayPlainText.Enabled = false;
            this.displayPlainText.Location = new System.Drawing.Point(161, 230);
            this.displayPlainText.Name = "displayPlainText";
            this.displayPlainText.Size = new System.Drawing.Size(405, 20);
            this.displayPlainText.TabIndex = 8;
            // 
            // labelPlainText
            // 
            this.labelPlainText.AutoSize = true;
            this.labelPlainText.Enabled = false;
            this.labelPlainText.Location = new System.Drawing.Point(74, 233);
            this.labelPlainText.Name = "labelPlainText";
            this.labelPlainText.Size = new System.Drawing.Size(54, 13);
            this.labelPlainText.TabIndex = 7;
            this.labelPlainText.Text = "Plain Text";
            // 
            // inputEncodedText
            // 
            this.inputEncodedText.Enabled = false;
            this.inputEncodedText.Location = new System.Drawing.Point(161, 181);
            this.inputEncodedText.Name = "inputEncodedText";
            this.inputEncodedText.Size = new System.Drawing.Size(405, 20);
            this.inputEncodedText.TabIndex = 6;
            this.inputEncodedText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textboxDecode_KeyDown);
            // 
            // labelDecodeEncodedText
            // 
            this.labelDecodeEncodedText.AutoSize = true;
            this.labelDecodeEncodedText.Enabled = false;
            this.labelDecodeEncodedText.Location = new System.Drawing.Point(66, 184);
            this.labelDecodeEncodedText.Name = "labelDecodeEncodedText";
            this.labelDecodeEncodedText.Size = new System.Drawing.Size(74, 13);
            this.labelDecodeEncodedText.TabIndex = 5;
            this.labelDecodeEncodedText.Text = "Encoded Text";
            // 
            // labelEncode
            // 
            this.labelEncode.AutoSize = true;
            this.labelEncode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEncode.Location = new System.Drawing.Point(318, 43);
            this.labelEncode.Name = "labelEncode";
            this.labelEncode.Size = new System.Drawing.Size(58, 13);
            this.labelEncode.TabIndex = 10;
            this.labelEncode.Text = "ENCODE";
            // 
            // labelDecode
            // 
            this.labelDecode.AutoSize = true;
            this.labelDecode.Enabled = false;
            this.labelDecode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDecode.Location = new System.Drawing.Point(318, 154);
            this.labelDecode.Name = "labelDecode";
            this.labelDecode.Size = new System.Drawing.Size(58, 13);
            this.labelDecode.TabIndex = 11;
            this.labelDecode.Text = "DECODE";
            // 
            // radioButtonEncode
            // 
            this.radioButtonEncode.AutoSize = true;
            this.radioButtonEncode.Checked = true;
            this.radioButtonEncode.Location = new System.Drawing.Point(30, 15);
            this.radioButtonEncode.Name = "radioButtonEncode";
            this.radioButtonEncode.Size = new System.Drawing.Size(62, 17);
            this.radioButtonEncode.TabIndex = 12;
            this.radioButtonEncode.TabStop = true;
            this.radioButtonEncode.Text = "Encode";
            this.radioButtonEncode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radioButtonEncode.UseVisualStyleBackColor = true;
            this.radioButtonEncode.CheckedChanged += new System.EventHandler(this.radioButtonEncode_CheckedChanged);
            // 
            // radioButtonDecode
            // 
            this.radioButtonDecode.AutoSize = true;
            this.radioButtonDecode.Location = new System.Drawing.Point(113, 15);
            this.radioButtonDecode.Name = "radioButtonDecode";
            this.radioButtonDecode.Size = new System.Drawing.Size(63, 17);
            this.radioButtonDecode.TabIndex = 13;
            this.radioButtonDecode.Text = "Decode";
            this.radioButtonDecode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radioButtonDecode.UseVisualStyleBackColor = true;
            this.radioButtonDecode.CheckedChanged += new System.EventHandler(this.radioButtonDecode_CheckedChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 274);
            this.Controls.Add(this.radioButtonDecode);
            this.Controls.Add(this.radioButtonEncode);
            this.Controls.Add(this.labelDecode);
            this.Controls.Add(this.labelEncode);
            this.Controls.Add(this.btnDecode);
            this.Controls.Add(this.displayPlainText);
            this.Controls.Add(this.labelPlainText);
            this.Controls.Add(this.inputEncodedText);
            this.Controls.Add(this.labelDecodeEncodedText);
            this.Controls.Add(this.insertEncodedText);
            this.Controls.Add(this.displayEncodedText);
            this.Controls.Add(this.labelEnodeEncodedText);
            this.Controls.Add(this.inputPlainText);
            this.Controls.Add(this.labelEncodePlainText);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "Encryption";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox displayEncodedText;
        private System.Windows.Forms.TextBox displayPlainText;
        private System.Windows.Forms.TextBox inputEncodedText;
        private System.Windows.Forms.Label labelEncodePlainText;
        private System.Windows.Forms.Label labelEnodeEncodedText;
        private System.Windows.Forms.Label labelPlainText;
        private System.Windows.Forms.Label labelDecodeEncodedText;
        private System.Windows.Forms.Label labelEncode;
        private System.Windows.Forms.Label labelDecode;
        private System.Windows.Forms.Button insertEncodedText;
        private System.Windows.Forms.Button btnDecode;
        private System.Windows.Forms.RadioButton radioButtonEncode;
        private System.Windows.Forms.RadioButton radioButtonDecode;
        private System.Windows.Forms.TextBox inputPlainText;
    }
}

