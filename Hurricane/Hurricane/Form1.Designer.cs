
namespace Hurricane
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.windSpeed = new System.Windows.Forms.TextBox();
            this.hurcCatagory = new System.Windows.Forms.TextBox();
            this.runProg = new System.Windows.Forms.Button();
            this.closeProg = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // windSpeed
            // 
            this.windSpeed.Location = new System.Drawing.Point(247, 117);
            this.windSpeed.Name = "windSpeed";
            this.windSpeed.Size = new System.Drawing.Size(193, 22);
            this.windSpeed.TabIndex = 0;
            this.windSpeed.TextChanged += new System.EventHandler(this.windSpeed_TextChanged);
            // 
            // hurcCatagory
            // 
            this.hurcCatagory.Location = new System.Drawing.Point(513, 117);
            this.hurcCatagory.Name = "hurcCatagory";
            this.hurcCatagory.Size = new System.Drawing.Size(193, 22);
            this.hurcCatagory.TabIndex = 1;
            this.hurcCatagory.TextChanged += new System.EventHandler(this.hurcCatagory_TextChanged);
            // 
            // runProg
            // 
            this.runProg.Location = new System.Drawing.Point(511, 193);
            this.runProg.Name = "runProg";
            this.runProg.Size = new System.Drawing.Size(97, 37);
            this.runProg.TabIndex = 2;
            this.runProg.Text = "Run Prog";
            this.runProg.UseVisualStyleBackColor = true;
            this.runProg.Click += new System.EventHandler(this.runProg_Click);
            // 
            // closeProg
            // 
            this.closeProg.Location = new System.Drawing.Point(614, 193);
            this.closeProg.Name = "closeProg";
            this.closeProg.Size = new System.Drawing.Size(102, 37);
            this.closeProg.TabIndex = 3;
            this.closeProg.Text = "Close Prog";
            this.closeProg.UseVisualStyleBackColor = true;
            this.closeProg.Click += new System.EventHandler(this.closeProg_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter wind speed in MPH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(538, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hurricane Catagory";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(968, 488);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeProg);
            this.Controls.Add(this.runProg);
            this.Controls.Add(this.hurcCatagory);
            this.Controls.Add(this.windSpeed);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox windSpeed;
        private System.Windows.Forms.TextBox hurcCatagory;
        private System.Windows.Forms.Button runProg;
        private System.Windows.Forms.Button closeProg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

