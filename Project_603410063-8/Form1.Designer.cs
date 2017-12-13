namespace Project_603410063_8
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.regularity = new System.Windows.Forms.Button();
            this.room = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("One Stroke Script LET", 69.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(292, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(386, 107);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apartment";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("One Stroke Script LET", 70F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(97, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(335, 108);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sasikorn";
            // 
            // regularity
            // 
            this.regularity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.regularity.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.regularity.Font = new System.Drawing.Font("Orange LET", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regularity.ForeColor = System.Drawing.Color.Red;
            this.regularity.Location = new System.Drawing.Point(115, 376);
            this.regularity.Name = "regularity";
            this.regularity.Size = new System.Drawing.Size(197, 85);
            this.regularity.TabIndex = 4;
            this.regularity.Text = "ระเบียบหอพัก";
            this.regularity.UseVisualStyleBackColor = false;
            this.regularity.Click += new System.EventHandler(this.regularity_Click);
            // 
            // room
            // 
            this.room.BackColor = System.Drawing.Color.Red;
            this.room.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.room.Font = new System.Drawing.Font("Orange LET", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.room.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.room.Location = new System.Drawing.Point(453, 376);
            this.room.Name = "room";
            this.room.Size = new System.Drawing.Size(197, 85);
            this.room.TabIndex = 5;
            this.room.Text = "คำนวณค่าห้อง";
            this.room.UseVisualStyleBackColor = false;
            this.room.Click += new System.EventHandler(this.room_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Yellow;
            this.exit.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.exit.Font = new System.Drawing.Font("Orange LET", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.exit.Location = new System.Drawing.Point(807, 376);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(197, 85);
            this.exit.TabIndex = 7;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project_603410063_8.Properties.Resources._201310031051522131;
            this.pictureBox1.Location = new System.Drawing.Point(603, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(523, 297);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1161, 542);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.room);
            this.Controls.Add(this.regularity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button regularity;
        private System.Windows.Forms.Button room;
        private System.Windows.Forms.Button exit;
    }
}

