namespace Day14ExerciseWindowsFormsApp
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
            this.txtStud_Code = new System.Windows.Forms.TextBox();
            this.txtStud_Name = new System.Windows.Forms.TextBox();
            this.txtDept_Code = new System.Windows.Forms.TextBox();
            this.txtStud_Dob = new System.Windows.Forms.TextBox();
            this.lblStud_Code = new System.Windows.Forms.Label();
            this.lblStud_Name = new System.Windows.Forms.Label();
            this.lblDept_Code = new System.Windows.Forms.Label();
            this.lblStud_Dob = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtStud_Code
            // 
            this.txtStud_Code.Location = new System.Drawing.Point(339, 51);
            this.txtStud_Code.Name = "txtStud_Code";
            this.txtStud_Code.Size = new System.Drawing.Size(131, 22);
            this.txtStud_Code.TabIndex = 0;
            // 
            // txtStud_Name
            // 
            this.txtStud_Name.Location = new System.Drawing.Point(339, 135);
            this.txtStud_Name.Name = "txtStud_Name";
            this.txtStud_Name.Size = new System.Drawing.Size(131, 22);
            this.txtStud_Name.TabIndex = 1;
            // 
            // txtDept_Code
            // 
            this.txtDept_Code.Location = new System.Drawing.Point(339, 217);
            this.txtDept_Code.Name = "txtDept_Code";
            this.txtDept_Code.Size = new System.Drawing.Size(131, 22);
            this.txtDept_Code.TabIndex = 2;
            // 
            // txtStud_Dob
            // 
            this.txtStud_Dob.Location = new System.Drawing.Point(339, 293);
            this.txtStud_Dob.Name = "txtStud_Dob";
            this.txtStud_Dob.Size = new System.Drawing.Size(131, 22);
            this.txtStud_Dob.TabIndex = 3;
            // 
            // lblStud_Code
            // 
            this.lblStud_Code.AutoSize = true;
            this.lblStud_Code.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStud_Code.Location = new System.Drawing.Point(149, 51);
            this.lblStud_Code.Name = "lblStud_Code";
            this.lblStud_Code.Size = new System.Drawing.Size(120, 22);
            this.lblStud_Code.TabIndex = 4;
            this.lblStud_Code.Text = "Stud_Code";
            // 
            // lblStud_Name
            // 
            this.lblStud_Name.AutoSize = true;
            this.lblStud_Name.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStud_Name.Location = new System.Drawing.Point(149, 135);
            this.lblStud_Name.Name = "lblStud_Name";
            this.lblStud_Name.Size = new System.Drawing.Size(128, 22);
            this.lblStud_Name.TabIndex = 5;
            this.lblStud_Name.Text = "Stud_Name";
            // 
            // lblDept_Code
            // 
            this.lblDept_Code.AutoSize = true;
            this.lblDept_Code.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDept_Code.Location = new System.Drawing.Point(149, 223);
            this.lblDept_Code.Name = "lblDept_Code";
            this.lblDept_Code.Size = new System.Drawing.Size(121, 22);
            this.lblDept_Code.TabIndex = 6;
            this.lblDept_Code.Text = "Dept_Code";
            // 
            // lblStud_Dob
            // 
            this.lblStud_Dob.AutoSize = true;
            this.lblStud_Dob.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStud_Dob.Location = new System.Drawing.Point(149, 309);
            this.lblStud_Dob.Name = "lblStud_Dob";
            this.lblStud_Dob.Size = new System.Drawing.Size(110, 22);
            this.lblStud_Dob.TabIndex = 7;
            this.lblStud_Dob.Text = "Stud_Dob";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(149, 384);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(93, 22);
            this.lblAddress.TabIndex = 8;
            this.lblAddress.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(339, 384);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(131, 22);
            this.txtAddress.TabIndex = 9;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(69, 469);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(125, 40);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click_1);
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(237, 469);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(115, 40);
            this.btnShow.TabIndex = 11;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(395, 469);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(99, 40);
            this.btnInsert.TabIndex = 12;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(546, 469);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(106, 40);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(546, 384);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(106, 40);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 577);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblStud_Dob);
            this.Controls.Add(this.lblDept_Code);
            this.Controls.Add(this.lblStud_Name);
            this.Controls.Add(this.lblStud_Code);
            this.Controls.Add(this.txtStud_Dob);
            this.Controls.Add(this.txtDept_Code);
            this.Controls.Add(this.txtStud_Name);
            this.Controls.Add(this.txtStud_Code);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStud_Code;
        private System.Windows.Forms.TextBox txtStud_Name;
        private System.Windows.Forms.TextBox txtDept_Code;
        private System.Windows.Forms.TextBox txtStud_Dob;
        private System.Windows.Forms.Label lblStud_Code;
        private System.Windows.Forms.Label lblStud_Name;
        private System.Windows.Forms.Label lblDept_Code;
        private System.Windows.Forms.Label lblStud_Dob;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSearch;
    }
}

