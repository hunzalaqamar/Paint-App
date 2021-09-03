
namespace Paint
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.color_picker = new System.Windows.Forms.PictureBox();
            this.picColor = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Line = new System.Windows.Forms.Button();
            this.rectangle = new System.Windows.Forms.Button();
            this.btn_color = new System.Windows.Forms.Button();
            this.Fill = new System.Windows.Forms.Button();
            this.pencil = new System.Windows.Forms.Button();
            this.eraser = new System.Windows.Forms.Button();
            this.circle = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pic = new System.Windows.Forms.PictureBox();
            this.Clear = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.color_picker)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.Save);
            this.panel1.Controls.Add(this.Clear);
            this.panel1.Controls.Add(this.color_picker);
            this.panel1.Controls.Add(this.picColor);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1089, 100);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // color_picker
            // 
            this.color_picker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.color_picker.Image = global::Paint.Properties.Resources.download__42_;
            this.color_picker.Location = new System.Drawing.Point(12, 12);
            this.color_picker.Name = "color_picker";
            this.color_picker.Size = new System.Drawing.Size(207, 82);
            this.color_picker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.color_picker.TabIndex = 3;
            this.color_picker.TabStop = false;
            this.color_picker.MouseClick += new System.Windows.Forms.MouseEventHandler(this.color_picker_MouseClick);
            // 
            // picColor
            // 
            this.picColor.BackColor = System.Drawing.Color.White;
            this.picColor.Location = new System.Drawing.Point(240, 30);
            this.picColor.Name = "picColor";
            this.picColor.Size = new System.Drawing.Size(54, 48);
            this.picColor.TabIndex = 0;
            this.picColor.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.Line);
            this.panel3.Controls.Add(this.rectangle);
            this.panel3.Controls.Add(this.btn_color);
            this.panel3.Controls.Add(this.Fill);
            this.panel3.Controls.Add(this.pencil);
            this.panel3.Controls.Add(this.eraser);
            this.panel3.Controls.Add(this.circle);
            this.panel3.Location = new System.Drawing.Point(300, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(608, 100);
            this.panel3.TabIndex = 3;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // Line
            // 
            this.Line.BackColor = System.Drawing.Color.White;
            this.Line.BackgroundImage = global::Paint.Properties.Resources.download__7_;
            this.Line.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Line.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Line.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Line.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Line.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Line.Location = new System.Drawing.Point(522, 12);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(78, 82);
            this.Line.TabIndex = 7;
            this.Line.Text = "Line";
            this.Line.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Line.UseVisualStyleBackColor = false;
            this.Line.Click += new System.EventHandler(this.Line_Click);
            // 
            // rectangle
            // 
            this.rectangle.BackColor = System.Drawing.Color.White;
            this.rectangle.BackgroundImage = global::Paint.Properties.Resources.download__7_;
            this.rectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.rectangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rectangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rectangle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rectangle.Location = new System.Drawing.Point(438, 12);
            this.rectangle.Name = "rectangle";
            this.rectangle.Size = new System.Drawing.Size(78, 82);
            this.rectangle.TabIndex = 5;
            this.rectangle.Text = "Rectangle";
            this.rectangle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rectangle.UseVisualStyleBackColor = false;
            this.rectangle.Click += new System.EventHandler(this.rectangle_Click);
            // 
            // btn_color
            // 
            this.btn_color.BackColor = System.Drawing.Color.White;
            this.btn_color.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_color.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_color.Image = global::Paint.Properties.Resources.images__26_1;
            this.btn_color.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_color.Location = new System.Drawing.Point(18, 12);
            this.btn_color.Name = "btn_color";
            this.btn_color.Size = new System.Drawing.Size(78, 82);
            this.btn_color.TabIndex = 1;
            this.btn_color.Text = "Color";
            this.btn_color.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_color.UseVisualStyleBackColor = false;
            this.btn_color.Click += new System.EventHandler(this.btn_color_Click);
            // 
            // Fill
            // 
            this.Fill.BackColor = System.Drawing.Color.White;
            this.Fill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Fill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Fill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Fill.Location = new System.Drawing.Point(102, 12);
            this.Fill.Name = "Fill";
            this.Fill.Size = new System.Drawing.Size(78, 82);
            this.Fill.TabIndex = 2;
            this.Fill.Text = "Fill";
            this.Fill.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Fill.UseVisualStyleBackColor = false;
            this.Fill.Click += new System.EventHandler(this.Fill_Click);
            // 
            // pencil
            // 
            this.pencil.BackColor = System.Drawing.Color.White;
            this.pencil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pencil.BackgroundImage")));
            this.pencil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pencil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pencil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pencil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pencil.Location = new System.Drawing.Point(186, 12);
            this.pencil.Name = "pencil";
            this.pencil.Size = new System.Drawing.Size(78, 82);
            this.pencil.TabIndex = 3;
            this.pencil.Text = "Pencil";
            this.pencil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.pencil.UseVisualStyleBackColor = false;
            this.pencil.Click += new System.EventHandler(this.pencil_Click);
            // 
            // eraser
            // 
            this.eraser.BackColor = System.Drawing.Color.White;
            this.eraser.BackgroundImage = global::Paint.Properties.Resources.download__7_;
            this.eraser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.eraser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eraser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eraser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eraser.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.eraser.Location = new System.Drawing.Point(270, 12);
            this.eraser.Name = "eraser";
            this.eraser.Size = new System.Drawing.Size(78, 82);
            this.eraser.TabIndex = 4;
            this.eraser.Text = "Eraser";
            this.eraser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.eraser.UseVisualStyleBackColor = false;
            this.eraser.Click += new System.EventHandler(this.eraser_Click);
            // 
            // circle
            // 
            this.circle.BackColor = System.Drawing.Color.White;
            this.circle.BackgroundImage = global::Paint.Properties.Resources.download__7_;
            this.circle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.circle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.circle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.circle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.circle.Location = new System.Drawing.Point(354, 12);
            this.circle.Name = "circle";
            this.circle.Size = new System.Drawing.Size(78, 82);
            this.circle.TabIndex = 6;
            this.circle.Text = "Circle";
            this.circle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.circle.UseVisualStyleBackColor = false;
            this.circle.Click += new System.EventHandler(this.circle_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 488);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1089, 32);
            this.panel2.TabIndex = 1;
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.White;
            this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic.Location = new System.Drawing.Point(0, 100);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(1089, 388);
            this.pic.TabIndex = 2;
            this.pic.TabStop = false;
            this.pic.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_Paint);
            this.pic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pic_MouseClick);
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_MouseMove);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_MouseUp);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.White;
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(936, 12);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(86, 33);
            this.Clear.TabIndex = 4;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.White;
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.Location = new System.Drawing.Point(936, 61);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(86, 33);
            this.Save.TabIndex = 5;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 520);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.color_picker)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_color;
        private System.Windows.Forms.Button picColor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button Fill;
        private System.Windows.Forms.Button pencil;
        private System.Windows.Forms.Button eraser;
        private System.Windows.Forms.Button circle;
        private System.Windows.Forms.Button rectangle;
        private System.Windows.Forms.Button Line;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox color_picker;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Clear;
    }
}

