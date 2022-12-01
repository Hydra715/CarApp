namespace CarApp
{
    partial class CarTypeList
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
            this.CarType = new System.Windows.Forms.ListBox();
            this.Ok = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CarType
            // 
            this.CarType.FormattingEnabled = true;
            this.CarType.ItemHeight = 20;
            this.CarType.Location = new System.Drawing.Point(15, 12);
            this.CarType.Name = "CarType";
            this.CarType.Size = new System.Drawing.Size(221, 144);
            this.CarType.TabIndex = 0;
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(12, 175);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(94, 29);
            this.Ok.TabIndex = 1;
            this.Ok.Text = "Ok";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(143, 175);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CarTypeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 216);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.CarType);
            this.Name = "CarTypeList";
            this.Text = "CarTypeList";
            this.Load += new System.EventHandler(this.CarTypeList_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox CarType;
        private Button Ok;
        private Button button1;
    }
}