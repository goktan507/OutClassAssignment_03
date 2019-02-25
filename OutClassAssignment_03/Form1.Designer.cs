namespace OutClassAssignment_03
{
    partial class btn_selectfile
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txt_file = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.box_longest = new System.Windows.Forms.TextBox();
            this.box_firstalpha = new System.Windows.Forms.TextBox();
            this.box_lastalpha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.box_mostvowel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // txt_file
            // 
            this.txt_file.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_file.Location = new System.Drawing.Point(12, 12);
            this.txt_file.Name = "txt_file";
            this.txt_file.Size = new System.Drawing.Size(579, 423);
            this.txt_file.TabIndex = 0;
            this.txt_file.Text = "";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(607, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 57);
            this.button1.TabIndex = 1;
            this.button1.Text = "Select File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(636, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Longest Word";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(613, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "First Alphabetically";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(615, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Alphabetically";
            // 
            // box_longest
            // 
            this.box_longest.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_longest.Location = new System.Drawing.Point(633, 118);
            this.box_longest.Multiline = true;
            this.box_longest.Name = "box_longest";
            this.box_longest.Size = new System.Drawing.Size(140, 31);
            this.box_longest.TabIndex = 5;
            this.box_longest.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // box_firstalpha
            // 
            this.box_firstalpha.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_firstalpha.Location = new System.Drawing.Point(633, 201);
            this.box_firstalpha.Multiline = true;
            this.box_firstalpha.Name = "box_firstalpha";
            this.box_firstalpha.Size = new System.Drawing.Size(140, 31);
            this.box_firstalpha.TabIndex = 6;
            this.box_firstalpha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // box_lastalpha
            // 
            this.box_lastalpha.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_lastalpha.Location = new System.Drawing.Point(633, 284);
            this.box_lastalpha.Multiline = true;
            this.box_lastalpha.Name = "box_lastalpha";
            this.box_lastalpha.Size = new System.Drawing.Size(140, 31);
            this.box_lastalpha.TabIndex = 7;
            this.box_lastalpha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(627, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "w/ Most Vowels";
            // 
            // box_mostvowel
            // 
            this.box_mostvowel.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_mostvowel.Location = new System.Drawing.Point(633, 367);
            this.box_mostvowel.Multiline = true;
            this.box_mostvowel.Name = "box_mostvowel";
            this.box_mostvowel.Size = new System.Drawing.Size(140, 31);
            this.box_mostvowel.TabIndex = 9;
            this.box_mostvowel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_selectfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 447);
            this.Controls.Add(this.box_mostvowel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.box_lastalpha);
            this.Controls.Add(this.box_firstalpha);
            this.Controls.Add(this.box_longest);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_file);
            this.Name = "btn_selectfile";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox txt_file;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox box_longest;
        private System.Windows.Forms.TextBox box_firstalpha;
        private System.Windows.Forms.TextBox box_lastalpha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox box_mostvowel;
    }
}

