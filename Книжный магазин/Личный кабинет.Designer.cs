namespace Книжный_магазин
{
    partial class PersonalRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonalRoom));
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.back_peronal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.product = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel11.SuspendLayout();
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
            this.label1.Location = new System.Drawing.Point(39, 27);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(268, 82);
            this.label1.TabIndex = 10;
            this.label1.Text = "Книжный магазин\r\n       \"Феникс\"";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.back_peronal);
            this.panel5.Location = new System.Drawing.Point(65, 123);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(212, 23);
            this.panel5.TabIndex = 14;
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = global::Книжный_магазин.Properties.Resources._28_512;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel6.Location = new System.Drawing.Point(7, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(29, 16);
            this.panel6.TabIndex = 13;
            // 
            // back_peronal
            // 
            this.back_peronal.AutoSize = true;
            this.back_peronal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_peronal.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back_peronal.Location = new System.Drawing.Point(42, 2);
            this.back_peronal.Name = "back_peronal";
            this.back_peronal.Size = new System.Drawing.Size(165, 17);
            this.back_peronal.TabIndex = 0;
            this.back_peronal.Text = "ВЕРНУТЬСЯ НА ГЛАВНУЮ";
            this.back_peronal.Click += new System.EventHandler(this.Back_peronal_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label2.Location = new System.Drawing.Point(695, 27);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(248, 43);
            this.label2.TabIndex = 15;
            this.label2.Text = "Личный кабинет";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Controls.Add(this.product);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(27, 48);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(168, 38);
            this.panel3.TabIndex = 18;
            // 
            // product
            // 
            this.product.BackgroundImage = global::Книжный_магазин.Properties.Resources.purchase_basket_shop_512;
            this.product.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.product.Cursor = System.Windows.Forms.Cursors.Hand;
            this.product.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.product.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.product.Location = new System.Drawing.Point(43, 2);
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(122, 34);
            this.product.TabIndex = 9;
            this.product.Text = "Заказать товар";
            this.product.UseVisualStyleBackColor = true;
            this.product.Click += new System.EventHandler(this.Product_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = global::Книжный_магазин.Properties.Resources.school_book_noterbook_512;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(34, 33);
            this.panel4.TabIndex = 8;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel9.Controls.Add(this.exit);
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Location = new System.Drawing.Point(27, 125);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(168, 38);
            this.panel9.TabIndex = 20;
            // 
            // exit
            // 
            this.exit.BackgroundImage = global::Книжный_магазин.Properties.Resources.purchase_basket_shop_512;
            this.exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.exit.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.Location = new System.Drawing.Point(43, 2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(122, 34);
            this.exit.TabIndex = 9;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Transparent;
            this.panel10.BackgroundImage = global::Книжный_магазин.Properties.Resources._011_018_palm_fingers_five_512;
            this.panel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel10.Location = new System.Drawing.Point(3, 3);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(34, 33);
            this.panel10.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(30, 626);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(470, 26);
            this.label4.TabIndex = 21;
            this.label4.Text = "2011—2020, ООО «Новый Книжный Центр». Копирование всех составляющих частей сайта\r" +
    "\n в какой бы то ни было форме без разрешения владельцевавторских прав запрещено." +
    " ";
            // 
            // panel11
            // 
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel11.Controls.Add(this.panel9);
            this.panel11.Controls.Add(this.panel3);
            this.panel11.Location = new System.Drawing.Point(715, 97);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(228, 221);
            this.panel11.TabIndex = 22;
            // 
            // PersonalRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Книжный_магазин.Properties.Resources.ptica_feniks3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1036, 661);
            this.ControlBox = false;
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1052, 700);
            this.MinimumSize = new System.Drawing.Size(1052, 700);
            this.Name = "PersonalRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Личный кабинет";
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label back_peronal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button product;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel11;
    }
}