
namespace Typing_Practice
{
    partial class setting
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
            this.del_fav_btn = new System.Windows.Forms.Button();
            this.set_btn = new System.Windows.Forms.Button();
            this.add_fav_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // del_fav_btn
            // 
            this.del_fav_btn.Location = new System.Drawing.Point(387, 43);
            this.del_fav_btn.Name = "del_fav_btn";
            this.del_fav_btn.Size = new System.Drawing.Size(146, 35);
            this.del_fav_btn.TabIndex = 1;
            this.del_fav_btn.Text = "Delete selected favourite";
            this.del_fav_btn.UseVisualStyleBackColor = true;
            this.del_fav_btn.Click += new System.EventHandler(this.del_fav_btn_Click);
            // 
            // set_btn
            // 
            this.set_btn.Location = new System.Drawing.Point(182, 474);
            this.set_btn.Name = "set_btn";
            this.set_btn.Size = new System.Drawing.Size(75, 23);
            this.set_btn.TabIndex = 2;
            this.set_btn.Text = "Set";
            this.set_btn.UseVisualStyleBackColor = true;
            this.set_btn.Click += new System.EventHandler(this.set_btn_Click);
            // 
            // add_fav_btn
            // 
            this.add_fav_btn.Location = new System.Drawing.Point(374, 474);
            this.add_fav_btn.Name = "add_fav_btn";
            this.add_fav_btn.Size = new System.Drawing.Size(146, 23);
            this.add_fav_btn.TabIndex = 3;
            this.add_fav_btn.Text = "Add to favourite";
            this.add_fav_btn.UseVisualStyleBackColor = true;
            this.add_fav_btn.Click += new System.EventHandler(this.add_fav_btn_Click);
            // 
            // setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 532);
            this.Controls.Add(this.add_fav_btn);
            this.Controls.Add(this.set_btn);
            this.Controls.Add(this.del_fav_btn);
            this.Name = "setting";
            this.Text = "setting";
            this.Load += new System.EventHandler(this.setting_Load);
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.Button del_fav_btn;
        private System.Windows.Forms.Button set_btn;
        private System.Windows.Forms.Button add_fav_btn;
    }
}