namespace YOUniversity
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
            this.label1 = new System.Windows.Forms.Label();
            this.lstCourses = new System.Windows.Forms.ListBox();
            this.boxDetails = new System.Windows.Forms.GroupBox();
            this.lblInstructor = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblTimes = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblInst = new System.Windows.Forms.Label();
            this.lblhrs = new System.Windows.Forms.Label();
            this.lblLoc = new System.Windows.Forms.Label();
            this.lblMeeting = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.bntView = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.boxDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(459, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Browse from courses below to start building your dream schedule:";
            // 
            // lstCourses
            // 
            this.lstCourses.FormattingEnabled = true;
            this.lstCourses.ItemHeight = 16;
            this.lstCourses.Location = new System.Drawing.Point(47, 102);
            this.lstCourses.Name = "lstCourses";
            this.lstCourses.Size = new System.Drawing.Size(384, 340);
            this.lstCourses.TabIndex = 1;
            this.lstCourses.SelectedIndexChanged += new System.EventHandler(this.lstCourses_SelectedIndexChanged);
            // 
            // boxDetails
            // 
            this.boxDetails.Controls.Add(this.lblInstructor);
            this.boxDetails.Controls.Add(this.lblHours);
            this.boxDetails.Controls.Add(this.lblLocation);
            this.boxDetails.Controls.Add(this.lblTimes);
            this.boxDetails.Controls.Add(this.lblCourse);
            this.boxDetails.Controls.Add(this.lblInst);
            this.boxDetails.Controls.Add(this.lblhrs);
            this.boxDetails.Controls.Add(this.lblLoc);
            this.boxDetails.Controls.Add(this.lblMeeting);
            this.boxDetails.Controls.Add(this.label2);
            this.boxDetails.Location = new System.Drawing.Point(487, 154);
            this.boxDetails.Name = "boxDetails";
            this.boxDetails.Size = new System.Drawing.Size(328, 346);
            this.boxDetails.TabIndex = 2;
            this.boxDetails.TabStop = false;
            this.boxDetails.Text = "Course Details";
            this.boxDetails.Enter += new System.EventHandler(this.boxDetails_Enter);
            // 
            // lblInstructor
            // 
            this.lblInstructor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblInstructor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructor.Location = new System.Drawing.Point(24, 295);
            this.lblInstructor.Name = "lblInstructor";
            this.lblInstructor.Size = new System.Drawing.Size(213, 30);
            this.lblInstructor.TabIndex = 14;
            // 
            // lblHours
            // 
            this.lblHours.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHours.Location = new System.Drawing.Point(159, 218);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(78, 28);
            this.lblHours.TabIndex = 13;
            // 
            // lblLocation
            // 
            this.lblLocation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocation.Location = new System.Drawing.Point(20, 218);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(82, 28);
            this.lblLocation.TabIndex = 12;
            // 
            // lblTimes
            // 
            this.lblTimes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimes.Location = new System.Drawing.Point(24, 135);
            this.lblTimes.Name = "lblTimes";
            this.lblTimes.Size = new System.Drawing.Size(271, 28);
            this.lblTimes.TabIndex = 11;
            // 
            // lblCourse
            // 
            this.lblCourse.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourse.Location = new System.Drawing.Point(15, 60);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(280, 25);
            this.lblCourse.TabIndex = 10;
            // 
            // lblInst
            // 
            this.lblInst.AutoSize = true;
            this.lblInst.Location = new System.Drawing.Point(21, 266);
            this.lblInst.Name = "lblInst";
            this.lblInst.Size = new System.Drawing.Size(60, 16);
            this.lblInst.TabIndex = 8;
            this.lblInst.Text = "Instructor";
            this.lblInst.Click += new System.EventHandler(this.lblIntructor_Click);
            // 
            // lblhrs
            // 
            this.lblhrs.AutoSize = true;
            this.lblhrs.Location = new System.Drawing.Point(156, 190);
            this.lblhrs.Name = "lblhrs";
            this.lblhrs.Size = new System.Drawing.Size(81, 16);
            this.lblhrs.TabIndex = 5;
            this.lblhrs.Text = "Credit Hours";
            // 
            // lblLoc
            // 
            this.lblLoc.AutoSize = true;
            this.lblLoc.Location = new System.Drawing.Point(17, 189);
            this.lblLoc.Name = "lblLoc";
            this.lblLoc.Size = new System.Drawing.Size(58, 16);
            this.lblLoc.TabIndex = 4;
            this.lblLoc.Text = "Location";
            // 
            // lblMeeting
            // 
            this.lblMeeting.AutoSize = true;
            this.lblMeeting.Location = new System.Drawing.Point(17, 107);
            this.lblMeeting.Name = "lblMeeting";
            this.lblMeeting.Size = new System.Drawing.Size(96, 16);
            this.lblMeeting.TabIndex = 2;
            this.lblMeeting.Text = "Meeting Times";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Course Name";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(502, 506);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(295, 57);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add this course to my schedule";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // bntView
            // 
            this.bntView.Location = new System.Drawing.Point(502, 569);
            this.bntView.Name = "bntView";
            this.bntView.Size = new System.Drawing.Size(295, 54);
            this.bntView.TabIndex = 4;
            this.bntView.Text = "View my schedule >>";
            this.bntView.UseVisualStyleBackColor = true;
            this.bntView.Click += new System.EventHandler(this.bntView_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(679, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 636);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bntView);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.boxDetails);
            this.Controls.Add(this.lstCourses);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Welcome to YOUniversity --- where YOU decide what you study!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.boxDetails.ResumeLayout(false);
            this.boxDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstCourses;
        private System.Windows.Forms.GroupBox boxDetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblInst;
        private System.Windows.Forms.Label lblhrs;
        private System.Windows.Forms.Label lblLoc;
        private System.Windows.Forms.Label lblMeeting;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button bntView;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblTimes;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblInstructor;
    }
}

