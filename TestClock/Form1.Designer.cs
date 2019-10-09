namespace TestClock
{
    partial class Form_Main
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
            this.components = new System.ComponentModel.Container();
            this.label_show = new System.Windows.Forms.Label();
            this.btn_show = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer_show = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_show
            // 
            this.label_show.BackColor = System.Drawing.Color.LightSteelBlue;
            this.label_show.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_show.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_show.ForeColor = System.Drawing.Color.Navy;
            this.label_show.Location = new System.Drawing.Point(0, 0);
            this.label_show.Name = "label_show";
            this.label_show.Size = new System.Drawing.Size(391, 100);
            this.label_show.TabIndex = 0;
            this.label_show.Text = "label1";
            this.label_show.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_show
            // 
            this.btn_show.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_show.BackColor = System.Drawing.Color.CadetBlue;
            this.btn_show.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_show.ForeColor = System.Drawing.Color.Purple;
            this.btn_show.Location = new System.Drawing.Point(156, 128);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(88, 41);
            this.btn_show.TabIndex = 1;
            this.btn_show.Text = "SHOW";
            this.btn_show.UseVisualStyleBackColor = false;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label_show);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 100);
            this.panel1.TabIndex = 2;
            // 
            // timer_show
            // 
            this.timer_show.Interval = 50;
            this.timer_show.Tick += new System.EventHandler(this.timer_show_Tick);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 194);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_show);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clock";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_show;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer_show;
    }
}

