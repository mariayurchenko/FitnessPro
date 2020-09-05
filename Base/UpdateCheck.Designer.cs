namespace Base
{
    partial class UpdateCheck
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
            System.Windows.Forms.Label dataStartLabel;
            System.Windows.Forms.Label dataEndLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label dataVisitLabel;
            System.Windows.Forms.Label valueLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label noteLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataStartTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataEndTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.dataVisitDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.noteTextBox = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.radioButtonYes = new System.Windows.Forms.RadioButton();
            this.radioButtonNo = new System.Windows.Forms.RadioButton();
            this.numberLabel = new System.Windows.Forms.Label();
            dataStartLabel = new System.Windows.Forms.Label();
            dataEndLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            dataVisitLabel = new System.Windows.Forms.Label();
            valueLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            noteLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(122)))), ((int)(((byte)(172)))));
            this.panel1.Controls.Add(this.close);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(731, 52);
            this.panel1.TabIndex = 55;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(122)))), ((int)(((byte)(172)))));
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close.ForeColor = System.Drawing.Color.White;
            this.close.Location = new System.Drawing.Point(696, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(35, 36);
            this.close.TabIndex = 7;
            this.close.Text = "x";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            this.close.MouseEnter += new System.EventHandler(this.close_MouseEnter);
            this.close.MouseLeave += new System.EventHandler(this.close_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(261, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Коректування";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // dataStartTimePicker
            // 
            this.dataStartTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataStartTimePicker.Location = new System.Drawing.Point(430, 200);
            this.dataStartTimePicker.Name = "dataStartTimePicker";
            this.dataStartTimePicker.Size = new System.Drawing.Size(278, 34);
            this.dataStartTimePicker.TabIndex = 75;
            // 
            // dataEndTimePicker
            // 
            this.dataEndTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataEndTimePicker.Location = new System.Drawing.Point(430, 240);
            this.dataEndTimePicker.Name = "dataEndTimePicker";
            this.dataEndTimePicker.Size = new System.Drawing.Size(278, 34);
            this.dataEndTimePicker.TabIndex = 74;
            // 
            // dataStartLabel
            // 
            dataStartLabel.AutoSize = true;
            dataStartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataStartLabel.Location = new System.Drawing.Point(31, 205);
            dataStartLabel.Name = "dataStartLabel";
            dataStartLabel.Size = new System.Drawing.Size(183, 29);
            dataStartLabel.TabIndex = 73;
            dataStartLabel.Text = "Дата початку:";
            // 
            // dataEndLabel
            // 
            dataEndLabel.AutoSize = true;
            dataEndLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataEndLabel.Location = new System.Drawing.Point(31, 245);
            dataEndLabel.Name = "dataEndLabel";
            dataEndLabel.Size = new System.Drawing.Size(152, 29);
            dataEndLabel.TabIndex = 72;
            dataEndLabel.Text = "Дата кінця:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            nameLabel.Location = new System.Drawing.Point(31, 125);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(61, 29);
            nameLabel.TabIndex = 60;
            nameLabel.Text = "ПІБ:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTextBox.Location = new System.Drawing.Point(319, 120);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(389, 34);
            this.nameTextBox.TabIndex = 61;
            this.nameTextBox.Leave += new System.EventHandler(this.nameTextBox_Leave);
            // 
            // dataVisitLabel
            // 
            dataVisitLabel.AutoSize = true;
            dataVisitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataVisitLabel.Location = new System.Drawing.Point(31, 165);
            dataVisitLabel.Name = "dataVisitLabel";
            dataVisitLabel.Size = new System.Drawing.Size(161, 29);
            dataVisitLabel.TabIndex = 62;
            dataVisitLabel.Text = "Дата візиту:";
            // 
            // dataVisitDateTimePicker
            // 
            this.dataVisitDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataVisitDateTimePicker.Location = new System.Drawing.Point(430, 160);
            this.dataVisitDateTimePicker.Name = "dataVisitDateTimePicker";
            this.dataVisitDateTimePicker.Size = new System.Drawing.Size(278, 34);
            this.dataVisitDateTimePicker.TabIndex = 63;
            // 
            // valueLabel
            // 
            valueLabel.AutoSize = true;
            valueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            valueLabel.Location = new System.Drawing.Point(31, 285);
            valueLabel.Name = "valueLabel";
            valueLabel.Size = new System.Drawing.Size(106, 29);
            valueLabel.TabIndex = 66;
            valueLabel.Text = "Всього:";
            // 
            // valueTextBox
            // 
            this.valueTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueTextBox.Location = new System.Drawing.Point(430, 280);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(278, 34);
            this.valueTextBox.TabIndex = 67;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            statusLabel.Location = new System.Drawing.Point(31, 325);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(103, 29);
            statusLabel.TabIndex = 68;
            statusLabel.Text = "Статус:";
            // 
            // noteLabel
            // 
            noteLabel.AutoSize = true;
            noteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            noteLabel.Location = new System.Drawing.Point(31, 365);
            noteLabel.Name = "noteLabel";
            noteLabel.Size = new System.Drawing.Size(198, 29);
            noteLabel.TabIndex = 70;
            noteLabel.Text = "Адміністратор:";
            // 
            // noteTextBox
            // 
            this.noteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.noteTextBox.Location = new System.Drawing.Point(319, 360);
            this.noteTextBox.Name = "noteTextBox";
            this.noteTextBox.Size = new System.Drawing.Size(389, 34);
            this.noteTextBox.TabIndex = 71;
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.LightSeaGreen;
            this.save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.save.FlatAppearance.BorderSize = 3;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save.ForeColor = System.Drawing.Color.MintCream;
            this.save.Location = new System.Drawing.Point(538, 423);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(170, 50);
            this.save.TabIndex = 59;
            this.save.Text = "Зберегти";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // radioButtonYes
            // 
            this.radioButtonYes.AutoSize = true;
            this.radioButtonYes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonYes.Location = new System.Drawing.Point(353, 320);
            this.radioButtonYes.Name = "radioButtonYes";
            this.radioButtonYes.Size = new System.Drawing.Size(153, 33);
            this.radioButtonYes.TabIndex = 76;
            this.radioButtonYes.TabStop = true;
            this.radioButtonYes.Text = "Оплачено";
            this.radioButtonYes.UseVisualStyleBackColor = true;
            // 
            // radioButtonNo
            // 
            this.radioButtonNo.AutoSize = true;
            this.radioButtonNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonNo.Location = new System.Drawing.Point(521, 320);
            this.radioButtonNo.Name = "radioButtonNo";
            this.radioButtonNo.Size = new System.Drawing.Size(185, 33);
            this.radioButtonNo.TabIndex = 77;
            this.radioButtonNo.TabStop = true;
            this.radioButtonNo.Text = "Не оплачено";
            this.radioButtonNo.UseVisualStyleBackColor = true;
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.numberLabel.Location = new System.Drawing.Point(264, 66);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(172, 29);
            this.numberLabel.TabIndex = 78;
            this.numberLabel.Text = "Квитанція №";
            this.numberLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UpdateCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(206)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(731, 508);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.radioButtonNo);
            this.Controls.Add(this.radioButtonYes);
            this.Controls.Add(this.dataStartTimePicker);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataEndTimePicker);
            this.Controls.Add(this.noteTextBox);
            this.Controls.Add(dataStartLabel);
            this.Controls.Add(this.save);
            this.Controls.Add(dataEndLabel);
            this.Controls.Add(noteLabel);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(statusLabel);
            this.Controls.Add(dataVisitLabel);
            this.Controls.Add(this.valueTextBox);
            this.Controls.Add(this.dataVisitDateTimePicker);
            this.Controls.Add(valueLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateCheck";
            this.Text = "UpdateCheck";
            this.Load += new System.EventHandler(this.UpdateCheck_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dataStartTimePicker;
        private System.Windows.Forms.DateTimePicker dataEndTimePicker;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.DateTimePicker dataVisitDateTimePicker;
        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.TextBox noteTextBox;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.RadioButton radioButtonYes;
        private System.Windows.Forms.RadioButton radioButtonNo;
        private System.Windows.Forms.Label numberLabel;
    }
}