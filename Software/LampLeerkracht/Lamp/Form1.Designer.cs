namespace Lamp
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
            this.components = new System.ComponentModel.Container();
            this.keukenButton = new System.Windows.Forms.Button();
            this.keukenLampControle = new System.Windows.Forms.PictureBox();
            this.woonkamerLampControle = new System.Windows.Forms.PictureBox();
            this.woonkamerButton = new System.Windows.Forms.Button();
            this.slaapkamerLampControle = new System.Windows.Forms.PictureBox();
            this.slaapkamerButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.zolderkamerLampControle = new System.Windows.Forms.PictureBox();
            this.zolderkamerButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.keukenLampControle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.woonkamerLampControle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slaapkamerLampControle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zolderkamerLampControle)).BeginInit();
            this.SuspendLayout();
            // 
            // keukenButton
            // 
            this.keukenButton.Location = new System.Drawing.Point(106, 113);
            this.keukenButton.Name = "keukenButton";
            this.keukenButton.Size = new System.Drawing.Size(75, 23);
            this.keukenButton.TabIndex = 0;
            this.keukenButton.Text = "Keuken";
            this.keukenButton.UseVisualStyleBackColor = true;
            this.keukenButton.Click += new System.EventHandler(this.keukenButton_Click);
            // 
            // keukenLampControle
            // 
            this.keukenLampControle.Location = new System.Drawing.Point(116, 57);
            this.keukenLampControle.Name = "keukenLampControle";
            this.keukenLampControle.Size = new System.Drawing.Size(54, 50);
            this.keukenLampControle.TabIndex = 1;
            this.keukenLampControle.TabStop = false;
            // 
            // woonkamerLampControle
            // 
            this.woonkamerLampControle.Location = new System.Drawing.Point(217, 57);
            this.woonkamerLampControle.Name = "woonkamerLampControle";
            this.woonkamerLampControle.Size = new System.Drawing.Size(54, 50);
            this.woonkamerLampControle.TabIndex = 3;
            this.woonkamerLampControle.TabStop = false;
            // 
            // woonkamerButton
            // 
            this.woonkamerButton.Location = new System.Drawing.Point(207, 113);
            this.woonkamerButton.Name = "woonkamerButton";
            this.woonkamerButton.Size = new System.Drawing.Size(75, 23);
            this.woonkamerButton.TabIndex = 2;
            this.woonkamerButton.Text = "Woonkamer";
            this.woonkamerButton.UseVisualStyleBackColor = true;
            this.woonkamerButton.Click += new System.EventHandler(this.woonkamerButton_Click);
            // 
            // slaapkamerLampControle
            // 
            this.slaapkamerLampControle.Location = new System.Drawing.Point(321, 57);
            this.slaapkamerLampControle.Name = "slaapkamerLampControle";
            this.slaapkamerLampControle.Size = new System.Drawing.Size(54, 50);
            this.slaapkamerLampControle.TabIndex = 5;
            this.slaapkamerLampControle.TabStop = false;
            // 
            // slaapkamerButton
            // 
            this.slaapkamerButton.Location = new System.Drawing.Point(311, 113);
            this.slaapkamerButton.Name = "slaapkamerButton";
            this.slaapkamerButton.Size = new System.Drawing.Size(75, 23);
            this.slaapkamerButton.TabIndex = 4;
            this.slaapkamerButton.Text = "Slaapkamer";
            this.slaapkamerButton.UseVisualStyleBackColor = true;
            this.slaapkamerButton.Click += new System.EventHandler(this.slaapkamerButton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label controles:";
            // 
            // zolderkamerLampControle
            // 
            this.zolderkamerLampControle.Location = new System.Drawing.Point(425, 57);
            this.zolderkamerLampControle.Name = "zolderkamerLampControle";
            this.zolderkamerLampControle.Size = new System.Drawing.Size(54, 50);
            this.zolderkamerLampControle.TabIndex = 7;
            this.zolderkamerLampControle.TabStop = false;
            // 
            // zolderkamerButton
            // 
            this.zolderkamerButton.Location = new System.Drawing.Point(419, 113);
            this.zolderkamerButton.Name = "zolderkamerButton";
            this.zolderkamerButton.Size = new System.Drawing.Size(75, 23);
            this.zolderkamerButton.TabIndex = 8;
            this.zolderkamerButton.Text = "Zolderkamer";
            this.zolderkamerButton.UseVisualStyleBackColor = true;
            this.zolderkamerButton.Click += new System.EventHandler(this.zolderkamerButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 194);
            this.Controls.Add(this.zolderkamerButton);
            this.Controls.Add(this.zolderkamerLampControle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.slaapkamerLampControle);
            this.Controls.Add(this.slaapkamerButton);
            this.Controls.Add(this.woonkamerLampControle);
            this.Controls.Add(this.woonkamerButton);
            this.Controls.Add(this.keukenLampControle);
            this.Controls.Add(this.keukenButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.keukenLampControle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.woonkamerLampControle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slaapkamerLampControle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zolderkamerLampControle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button keukenButton;
        private System.Windows.Forms.PictureBox keukenLampControle;
        private System.Windows.Forms.PictureBox woonkamerLampControle;
        private System.Windows.Forms.Button woonkamerButton;
        private System.Windows.Forms.PictureBox slaapkamerLampControle;
        private System.Windows.Forms.Button slaapkamerButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox zolderkamerLampControle;
        private System.Windows.Forms.Button zolderkamerButton;
    }
}

