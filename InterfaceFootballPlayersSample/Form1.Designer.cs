namespace InterfaceFootballPlayersSample
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lstFootballers = new ListBox();
            flpFootballerAttributes = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // lstFootballers
            // 
            lstFootballers.FormattingEnabled = true;
            lstFootballers.Location = new Point(12, 12);
            lstFootballers.Name = "lstFootballers";
            lstFootballers.Size = new Size(295, 424);
            lstFootballers.TabIndex = 0;
            lstFootballers.SelectedIndexChanged += lstFootballers_SelectedIndexChanged;
            // 
            // flpFootballerAttributes
            // 
            flpFootballerAttributes.Location = new Point(313, 12);
            flpFootballerAttributes.Name = "flpFootballerAttributes";
            flpFootballerAttributes.Size = new Size(475, 426);
            flpFootballerAttributes.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flpFootballerAttributes);
            Controls.Add(lstFootballers);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstFootballers;
        private FlowLayoutPanel flpFootballerAttributes;
    }
}
