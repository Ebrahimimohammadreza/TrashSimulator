
namespace TrashSimulator
{
    partial class frmTrash
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblTrashID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblLongitude = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.lblOccupied = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.plnLED = new System.Windows.Forms.Panel();
            this.lblExtra = new System.Windows.Forms.Label();
            this.lblLatitude = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Trash ID :";
            // 
            // lblTrashID
            // 
            this.lblTrashID.Location = new System.Drawing.Point(79, 13);
            this.lblTrashID.Name = "lblTrashID";
            this.lblTrashID.Size = new System.Drawing.Size(89, 13);
            this.lblTrashID.TabIndex = 1;
            this.lblTrashID.Text = "TrashID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = " Lat Lon :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 3;
            // 
            // lblLongitude
            // 
            this.lblLongitude.Location = new System.Drawing.Point(148, 40);
            this.lblLongitude.Name = "lblLongitude";
            this.lblLongitude.Size = new System.Drawing.Size(75, 13);
            this.lblLongitude.TabIndex = 4;
            this.lblLongitude.Text = "Longitude";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(16, 95);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(241, 44);
            this.progressBar1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Occupied :";
            // 
            // lblOccupied
            // 
            this.lblOccupied.Location = new System.Drawing.Point(79, 68);
            this.lblOccupied.Name = "lblOccupied";
            this.lblOccupied.Size = new System.Drawing.Size(178, 13);
            this.lblOccupied.TabIndex = 7;
            this.lblOccupied.Text = "Occupied";
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.Color.LavenderBlush;
            this.lblMessage.Location = new System.Drawing.Point(19, 178);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(238, 22);
            this.lblMessage.TabIndex = 8;
            this.lblMessage.Text = "Message";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 6000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // plnLED
            // 
            this.plnLED.BackColor = System.Drawing.Color.Green;
            this.plnLED.Location = new System.Drawing.Point(233, 12);
            this.plnLED.Name = "plnLED";
            this.plnLED.Size = new System.Drawing.Size(24, 24);
            this.plnLED.TabIndex = 9;
            // 
            // lblExtra
            // 
            this.lblExtra.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lblExtra.Location = new System.Drawing.Point(17, 142);
            this.lblExtra.Name = "lblExtra";
            this.lblExtra.Size = new System.Drawing.Size(240, 30);
            this.lblExtra.TabIndex = 10;
            this.lblExtra.Text = "Extra Capacity Closed";
            this.lblExtra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLatitude
            // 
            this.lblLatitude.Location = new System.Drawing.Point(71, 40);
            this.lblLatitude.Name = "lblLatitude";
            this.lblLatitude.Size = new System.Drawing.Size(75, 13);
            this.lblLatitude.TabIndex = 11;
            this.lblLatitude.Text = "Latitude";
            // 
            // frmTrash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 204);
            this.Controls.Add(this.lblLatitude);
            this.Controls.Add(this.lblExtra);
            this.Controls.Add(this.plnLED);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblOccupied);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblLongitude);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTrashID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTrash";
            this.Text = "Trash";
            this.Load += new System.EventHandler(this.frmTrash_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTrashID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblLongitude;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblOccupied;
        public System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel plnLED;
        private System.Windows.Forms.Label lblExtra;
        private System.Windows.Forms.Label lblLatitude;
    }
}