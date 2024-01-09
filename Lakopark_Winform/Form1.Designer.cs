
namespace Lakopark_Winform
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
            this.pictureBox_Nevado = new System.Windows.Forms.PictureBox();
            this.panelEpuletek = new System.Windows.Forms.Panel();
            this.button_balNyil = new System.Windows.Forms.Button();
            this.button_jobbraNyil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Nevado)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Nevado
            // 
            this.pictureBox_Nevado.Location = new System.Drawing.Point(26, 31);
            this.pictureBox_Nevado.Name = "pictureBox_Nevado";
            this.pictureBox_Nevado.Size = new System.Drawing.Size(123, 166);
            this.pictureBox_Nevado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Nevado.TabIndex = 0;
            this.pictureBox_Nevado.TabStop = false;
            // 
            // panelEpuletek
            // 
            this.panelEpuletek.Location = new System.Drawing.Point(201, 31);
            this.panelEpuletek.Name = "panelEpuletek";
            this.panelEpuletek.Size = new System.Drawing.Size(200, 100);
            this.panelEpuletek.TabIndex = 1;
            // 
            // button_balNyil
            // 
            this.button_balNyil.BackgroundImage = global::Lakopark_Winform.Properties.Resources.balnyil;
            this.button_balNyil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_balNyil.Location = new System.Drawing.Point(26, 353);
            this.button_balNyil.Name = "button_balNyil";
            this.button_balNyil.Size = new System.Drawing.Size(131, 74);
            this.button_balNyil.TabIndex = 2;
            this.button_balNyil.UseVisualStyleBackColor = true;
            // 
            // button_jobbraNyil
            // 
            this.button_jobbraNyil.BackgroundImage = global::Lakopark_Winform.Properties.Resources.jobbnyil;
            this.button_jobbraNyil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_jobbraNyil.Location = new System.Drawing.Point(634, 353);
            this.button_jobbraNyil.Name = "button_jobbraNyil";
            this.button_jobbraNyil.Size = new System.Drawing.Size(131, 74);
            this.button_jobbraNyil.TabIndex = 2;
            this.button_jobbraNyil.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_jobbraNyil);
            this.Controls.Add(this.button_balNyil);
            this.Controls.Add(this.panelEpuletek);
            this.Controls.Add(this.pictureBox_Nevado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Nevado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Nevado;
        private System.Windows.Forms.Panel panelEpuletek;
        private System.Windows.Forms.Button button_balNyil;
        private System.Windows.Forms.Button button_jobbraNyil;
    }
}

