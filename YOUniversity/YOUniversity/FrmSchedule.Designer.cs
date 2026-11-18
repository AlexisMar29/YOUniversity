namespace YOUniversity
{
    partial class FrmSchedule
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
            this.lstvSchedule = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMeet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLoc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCredHrs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colInstructor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstvSchedule
            // 
            this.lstvSchedule.CheckBoxes = true;
            this.lstvSchedule.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colMeet,
            this.colLoc,
            this.colCredHrs,
            this.colInstructor});
            this.lstvSchedule.HideSelection = false;
            this.lstvSchedule.Location = new System.Drawing.Point(52, 64);
            this.lstvSchedule.Name = "lstvSchedule";
            this.lstvSchedule.Size = new System.Drawing.Size(930, 253);
            this.lstvSchedule.TabIndex = 0;
            this.lstvSchedule.UseCompatibleStateImageBehavior = false;
            this.lstvSchedule.View = System.Windows.Forms.View.Details;
            this.lstvSchedule.SelectedIndexChanged += new System.EventHandler(this.lstvSchedule_SelectedIndexChanged);
            // 
            // colName
            // 
            this.colName.Text = "Course Name";
            this.colName.Width = 175;
            // 
            // colMeet
            // 
            this.colMeet.Text = "Meeting Times";
            this.colMeet.Width = 125;
            // 
            // colLoc
            // 
            this.colLoc.Text = "Location";
            this.colLoc.Width = 125;
            // 
            // colCredHrs
            // 
            this.colCredHrs.Text = "Credit Hours";
            this.colCredHrs.Width = 125;
            // 
            // colInstructor
            // 
            this.colInstructor.Text = "Instructor";
            this.colInstructor.Width = 125;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(393, 323);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(273, 74);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "Remove Selected";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click_1);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(393, 419);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(273, 88);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "Register Now!";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(860, 352);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(15, 16);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "0";
            this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(713, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total credit hours:";
            // 
            // FrmSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 564);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lstvSchedule);
            this.Name = "FrmSchedule";
            this.Text = "Your Schedule";
            this.Load += new System.EventHandler(this.FrmSchedule_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstvSchedule;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colMeet;
        private System.Windows.Forms.ColumnHeader colLoc;
        private System.Windows.Forms.ColumnHeader colCredHrs;
        private System.Windows.Forms.ColumnHeader colInstructor;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
    }
}