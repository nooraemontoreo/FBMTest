
namespace FBMTest
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
            this.txtgradeid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.fbmdatagridview = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtgradename = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fbmdatagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // txtgradeid
            // 
            this.txtgradeid.Location = new System.Drawing.Point(126, 19);
            this.txtgradeid.Name = "txtgradeid";
            this.txtgradeid.Size = new System.Drawing.Size(100, 22);
            this.txtgradeid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Grade ID ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fbmdatagridview
            // 
            this.fbmdatagridview.AllowUserToOrderColumns = true;
            this.fbmdatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fbmdatagridview.Location = new System.Drawing.Point(34, 152);
            this.fbmdatagridview.Name = "fbmdatagridview";
            this.fbmdatagridview.RowHeadersWidth = 51;
            this.fbmdatagridview.RowTemplate.Height = 24;
            this.fbmdatagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.fbmdatagridview.Size = new System.Drawing.Size(383, 132);
            this.fbmdatagridview.TabIndex = 3;
            this.fbmdatagridview.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.fbmdatagridview_CellClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(133, 117);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 29);
            this.button2.TabIndex = 4;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(232, 117);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(66, 29);
            this.button3.TabIndex = 5;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Grade Name";
            // 
            // txtgradename
            // 
            this.txtgradename.Location = new System.Drawing.Point(126, 58);
            this.txtgradename.Name = "txtgradename";
            this.txtgradename.Size = new System.Drawing.Size(100, 22);
            this.txtgradename.TabIndex = 6;
            this.txtgradename.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(555, 296);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtgradename);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.fbmdatagridview);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtgradeid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTest";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fbmdatagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtgradeid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView fbmdatagridview;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtgradename;
    }
}

