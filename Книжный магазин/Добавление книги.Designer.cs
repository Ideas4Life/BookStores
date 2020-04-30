namespace Книжный_магазин
{
    partial class AddBooks
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.back_addBooks = new System.Windows.Forms.Label();
            this.genre = new System.Windows.Forms.Label();
            this.tableAddBooks = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tBAuthor1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.tBAuthor2 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.tBAuthor3 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.tBAuthor4 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.addPicture1 = new System.Windows.Forms.Button();
            this.addPicture2 = new System.Windows.Forms.Button();
            this.addPicture3 = new System.Windows.Forms.Button();
            this.addPicture4 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableAddBooks.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Location = new System.Drawing.Point(35, 27);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(268, 82);
            this.label1.TabIndex = 8;
            this.label1.Text = "Книжный магазин\r\n       \"Феникс\"";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.back_addBooks);
            this.panel1.Location = new System.Drawing.Point(556, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 23);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(7, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(29, 16);
            this.panel2.TabIndex = 13;
            // 
            // back_addBooks
            // 
            this.back_addBooks.AutoSize = true;
            this.back_addBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_addBooks.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back_addBooks.Location = new System.Drawing.Point(61, 1);
            this.back_addBooks.Name = "back_addBooks";
            this.back_addBooks.Size = new System.Drawing.Size(122, 17);
            this.back_addBooks.TabIndex = 0;
            this.back_addBooks.Text = "ВЕРНУТЬСЯ НАЗАД";
            this.back_addBooks.Click += new System.EventHandler(this.back_addBooks_Click);
            // 
            // genre
            // 
            this.genre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.genre.BackColor = System.Drawing.Color.Silver;
            this.genre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.genre.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genre.Location = new System.Drawing.Point(450, 27);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(403, 50);
            this.genre.TabIndex = 14;
            this.genre.Text = "Добавление книг";
            this.genre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableAddBooks
            // 
            this.tableAddBooks.AutoScroll = true;
            this.tableAddBooks.ColumnCount = 6;
            this.tableAddBooks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableAddBooks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableAddBooks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableAddBooks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableAddBooks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableAddBooks.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableAddBooks.Controls.Add(this.label7, 5, 0);
            this.tableAddBooks.Controls.Add(this.addPicture4, 5, 4);
            this.tableAddBooks.Controls.Add(this.addPicture3, 5, 3);
            this.tableAddBooks.Controls.Add(this.addPicture2, 5, 2);
            this.tableAddBooks.Controls.Add(this.textBox20, 4, 4);
            this.tableAddBooks.Controls.Add(this.textBox19, 3, 4);
            this.tableAddBooks.Controls.Add(this.textBox18, 2, 4);
            this.tableAddBooks.Controls.Add(this.tBAuthor4, 1, 4);
            this.tableAddBooks.Controls.Add(this.textBox16, 0, 4);
            this.tableAddBooks.Controls.Add(this.textBox15, 4, 3);
            this.tableAddBooks.Controls.Add(this.textBox14, 3, 3);
            this.tableAddBooks.Controls.Add(this.textBox13, 2, 3);
            this.tableAddBooks.Controls.Add(this.tBAuthor3, 1, 3);
            this.tableAddBooks.Controls.Add(this.textBox10, 4, 2);
            this.tableAddBooks.Controls.Add(this.textBox9, 3, 2);
            this.tableAddBooks.Controls.Add(this.textBox8, 2, 2);
            this.tableAddBooks.Controls.Add(this.tBAuthor2, 1, 2);
            this.tableAddBooks.Controls.Add(this.textBox6, 0, 2);
            this.tableAddBooks.Controls.Add(this.textBox5, 4, 1);
            this.tableAddBooks.Controls.Add(this.textBox4, 3, 1);
            this.tableAddBooks.Controls.Add(this.textBox3, 2, 1);
            this.tableAddBooks.Controls.Add(this.tBAuthor1, 1, 1);
            this.tableAddBooks.Controls.Add(this.textBox1, 0, 1);
            this.tableAddBooks.Controls.Add(this.label6, 4, 0);
            this.tableAddBooks.Controls.Add(this.label5, 3, 0);
            this.tableAddBooks.Controls.Add(this.label4, 2, 0);
            this.tableAddBooks.Controls.Add(this.label3, 1, 0);
            this.tableAddBooks.Controls.Add(this.label2, 0, 0);
            this.tableAddBooks.Controls.Add(this.textBox11, 0, 3);
            this.tableAddBooks.Controls.Add(this.addPicture1, 5, 1);
            this.tableAddBooks.Location = new System.Drawing.Point(67, 158);
            this.tableAddBooks.Name = "tableAddBooks";
            this.tableAddBooks.RowCount = 5;
            this.tableAddBooks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableAddBooks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableAddBooks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableAddBooks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableAddBooks.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableAddBooks.Size = new System.Drawing.Size(925, 350);
            this.tableAddBooks.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 50);
            this.label2.TabIndex = 0;
            this.label2.Text = "Название";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(153, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 50);
            this.label3.TabIndex = 1;
            this.label3.Text = "Автор";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(303, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(294, 50);
            this.label4.TabIndex = 2;
            this.label4.Text = "Описание";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(603, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 50);
            this.label5.TabIndex = 3;
            this.label5.Text = "Жанр";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(753, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 50);
            this.label6.TabIndex = 4;
            this.label6.Text = "Цена";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(3, 53);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 69);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tBAuthor1
            // 
            this.tBAuthor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tBAuthor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBAuthor1.Location = new System.Drawing.Point(153, 53);
            this.tBAuthor1.Multiline = true;
            this.tBAuthor1.Name = "tBAuthor1";
            this.tBAuthor1.Size = new System.Drawing.Size(144, 69);
            this.tBAuthor1.TabIndex = 10;
            this.tBAuthor1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(303, 53);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox3.Size = new System.Drawing.Size(294, 69);
            this.textBox3.TabIndex = 11;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.Location = new System.Drawing.Point(603, 53);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(144, 69);
            this.textBox4.TabIndex = 12;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox5.Location = new System.Drawing.Point(753, 53);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(94, 69);
            this.textBox5.TabIndex = 13;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox6.Location = new System.Drawing.Point(3, 128);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(144, 69);
            this.textBox6.TabIndex = 14;
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tBAuthor2
            // 
            this.tBAuthor2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tBAuthor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBAuthor2.Location = new System.Drawing.Point(153, 128);
            this.tBAuthor2.Multiline = true;
            this.tBAuthor2.Name = "tBAuthor2";
            this.tBAuthor2.Size = new System.Drawing.Size(144, 69);
            this.tBAuthor2.TabIndex = 15;
            this.tBAuthor2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            this.textBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox8.Location = new System.Drawing.Point(303, 128);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox8.Size = new System.Drawing.Size(294, 69);
            this.textBox8.TabIndex = 16;
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox9
            // 
            this.textBox9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox9.Location = new System.Drawing.Point(603, 128);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(144, 69);
            this.textBox9.TabIndex = 17;
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox10
            // 
            this.textBox10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox10.Location = new System.Drawing.Point(753, 128);
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(94, 69);
            this.textBox10.TabIndex = 18;
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox11
            // 
            this.textBox11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox11.Location = new System.Drawing.Point(3, 203);
            this.textBox11.Multiline = true;
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(144, 69);
            this.textBox11.TabIndex = 19;
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tBAuthor3
            // 
            this.tBAuthor3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tBAuthor3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBAuthor3.Location = new System.Drawing.Point(153, 203);
            this.tBAuthor3.Multiline = true;
            this.tBAuthor3.Name = "tBAuthor3";
            this.tBAuthor3.Size = new System.Drawing.Size(144, 69);
            this.tBAuthor3.TabIndex = 20;
            this.tBAuthor3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox13
            // 
            this.textBox13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox13.Location = new System.Drawing.Point(303, 203);
            this.textBox13.Multiline = true;
            this.textBox13.Name = "textBox13";
            this.textBox13.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox13.Size = new System.Drawing.Size(294, 69);
            this.textBox13.TabIndex = 21;
            this.textBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox14
            // 
            this.textBox14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox14.Location = new System.Drawing.Point(603, 203);
            this.textBox14.Multiline = true;
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(144, 69);
            this.textBox14.TabIndex = 22;
            this.textBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox15
            // 
            this.textBox15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox15.Location = new System.Drawing.Point(753, 203);
            this.textBox15.Multiline = true;
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(94, 69);
            this.textBox15.TabIndex = 23;
            this.textBox15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox16
            // 
            this.textBox16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox16.Location = new System.Drawing.Point(3, 278);
            this.textBox16.Multiline = true;
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(144, 119);
            this.textBox16.TabIndex = 24;
            this.textBox16.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tBAuthor4
            // 
            this.tBAuthor4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tBAuthor4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBAuthor4.Location = new System.Drawing.Point(153, 278);
            this.tBAuthor4.Multiline = true;
            this.tBAuthor4.Name = "tBAuthor4";
            this.tBAuthor4.Size = new System.Drawing.Size(144, 119);
            this.tBAuthor4.TabIndex = 25;
            this.tBAuthor4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox18
            // 
            this.textBox18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox18.Location = new System.Drawing.Point(303, 278);
            this.textBox18.Multiline = true;
            this.textBox18.Name = "textBox18";
            this.textBox18.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox18.Size = new System.Drawing.Size(294, 119);
            this.textBox18.TabIndex = 26;
            this.textBox18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox19
            // 
            this.textBox19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox19.Location = new System.Drawing.Point(603, 278);
            this.textBox19.Multiline = true;
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(144, 119);
            this.textBox19.TabIndex = 27;
            this.textBox19.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox20
            // 
            this.textBox20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox20.Location = new System.Drawing.Point(753, 278);
            this.textBox20.Multiline = true;
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(94, 119);
            this.textBox20.TabIndex = 28;
            this.textBox20.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // addPicture1
            // 
            this.addPicture1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addPicture1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addPicture1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addPicture1.Location = new System.Drawing.Point(853, 53);
            this.addPicture1.Name = "addPicture1";
            this.addPicture1.Size = new System.Drawing.Size(69, 69);
            this.addPicture1.TabIndex = 29;
            this.addPicture1.Text = "button";
            this.addPicture1.UseVisualStyleBackColor = false;
            this.addPicture1.Click += new System.EventHandler(this.addPicture1_Click);
            // 
            // addPicture2
            // 
            this.addPicture2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addPicture2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addPicture2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addPicture2.Location = new System.Drawing.Point(853, 128);
            this.addPicture2.Name = "addPicture2";
            this.addPicture2.Size = new System.Drawing.Size(69, 69);
            this.addPicture2.TabIndex = 31;
            this.addPicture2.Text = "button";
            this.addPicture2.UseVisualStyleBackColor = false;
            // 
            // addPicture3
            // 
            this.addPicture3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addPicture3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addPicture3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addPicture3.Location = new System.Drawing.Point(853, 203);
            this.addPicture3.Name = "addPicture3";
            this.addPicture3.Size = new System.Drawing.Size(69, 69);
            this.addPicture3.TabIndex = 32;
            this.addPicture3.Text = "button";
            this.addPicture3.UseVisualStyleBackColor = false;
            // 
            // addPicture4
            // 
            this.addPicture4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addPicture4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addPicture4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addPicture4.Location = new System.Drawing.Point(853, 278);
            this.addPicture4.Name = "addPicture4";
            this.addPicture4.Size = new System.Drawing.Size(69, 119);
            this.addPicture4.TabIndex = 33;
            this.addPicture4.Text = "button";
            this.addPicture4.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(853, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 50);
            this.label7.TabIndex = 34;
            this.label7.Text = "Фото";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Книжный_магазин.Properties.Resources.ptica_feniks_orig;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1036, 661);
            this.ControlBox = false;
            this.Controls.Add(this.tableAddBooks);
            this.Controls.Add(this.genre);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(1052, 700);
            this.MinimumSize = new System.Drawing.Size(1052, 700);
            this.Name = "AddBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление книги";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableAddBooks.ResumeLayout(false);
            this.tableAddBooks.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label back_addBooks;
        public System.Windows.Forms.Label genre;
        private System.Windows.Forms.TableLayoutPanel tableAddBooks;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox tBAuthor2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox tBAuthor1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox tBAuthor4;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox tBAuthor3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button addPicture4;
        private System.Windows.Forms.Button addPicture3;
        private System.Windows.Forms.Button addPicture2;
        private System.Windows.Forms.Button addPicture1;
    }
}