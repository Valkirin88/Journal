namespace Journal
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Файл = new System.Windows.Forms.ToolStripMenuItem();
            this.newJobButton = new System.Windows.Forms.Button();
            this.plantBox = new System.Windows.Forms.ComboBox();
            this.plantLabel = new System.Windows.Forms.Label();
            this.equipmentLabel = new System.Windows.Forms.Label();
            this.equipmentBox = new System.Windows.Forms.ComboBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.workerLabel = new System.Windows.Forms.Label();
            this.workerBox = new System.Windows.Forms.ComboBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.DebugText = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(12, 267);
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(621, 343);
            this.descriptionBox.TabIndex = 0;
            this.descriptionBox.TextChanged += new System.EventHandler(this.descriptionBox_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Файл});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(926, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Файл
            // 
            this.Файл.Name = "Файл";
            this.Файл.Size = new System.Drawing.Size(59, 24);
            this.Файл.Text = "Файл";
            // 
            // newJobButton
            // 
            this.newJobButton.Location = new System.Drawing.Point(699, 126);
            this.newJobButton.Name = "newJobButton";
            this.newJobButton.Size = new System.Drawing.Size(154, 54);
            this.newJobButton.TabIndex = 2;
            this.newJobButton.Text = "Новая работа";
            this.newJobButton.UseVisualStyleBackColor = true;
            this.newJobButton.Click += new System.EventHandler(this.newJobButton_Click);
            // 
            // plantBox
            // 
            this.plantBox.FormattingEnabled = true;
            this.plantBox.Items.AddRange(new object[] {
            "П1",
            "П2",
            "П3"});
            this.plantBox.Location = new System.Drawing.Point(12, 117);
            this.plantBox.Name = "plantBox";
            this.plantBox.Size = new System.Drawing.Size(121, 24);
            this.plantBox.TabIndex = 3;
            this.plantBox.SelectedIndexChanged += new System.EventHandler(this.plantBox_SelectedIndexChanged);
            // 
            // plantLabel
            // 
            this.plantLabel.AutoSize = true;
            this.plantLabel.Location = new System.Drawing.Point(41, 98);
            this.plantLabel.Name = "plantLabel";
            this.plantLabel.Size = new System.Drawing.Size(61, 16);
            this.plantLabel.TabIndex = 4;
            this.plantLabel.Text = "Участок";
            // 
            // equipmentLabel
            // 
            this.equipmentLabel.AutoSize = true;
            this.equipmentLabel.Location = new System.Drawing.Point(182, 98);
            this.equipmentLabel.Name = "equipmentLabel";
            this.equipmentLabel.Size = new System.Drawing.Size(105, 16);
            this.equipmentLabel.TabIndex = 6;
            this.equipmentLabel.Text = "Оборудование";
            // 
            // equipmentBox
            // 
            this.equipmentBox.FormattingEnabled = true;
            this.equipmentBox.Items.AddRange(new object[] {
            "OCS CP"});
            this.equipmentBox.Location = new System.Drawing.Point(174, 117);
            this.equipmentBox.Name = "equipmentBox";
            this.equipmentBox.Size = new System.Drawing.Size(121, 24);
            this.equipmentBox.TabIndex = 5;
            this.equipmentBox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(699, 419);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(154, 54);
            this.searchButton.TabIndex = 7;
            this.searchButton.Text = "Поиск";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 179);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // workerLabel
            // 
            this.workerLabel.AutoSize = true;
            this.workerLabel.Location = new System.Drawing.Point(362, 98);
            this.workerLabel.Name = "workerLabel";
            this.workerLabel.Size = new System.Drawing.Size(70, 16);
            this.workerLabel.TabIndex = 10;
            this.workerLabel.Text = "Работник";
            // 
            // workerBox
            // 
            this.workerBox.DropDownWidth = 180;
            this.workerBox.FormattingEnabled = true;
            this.workerBox.Items.AddRange(new object[] {
            "Пушняков Виктор Александрович",
            "Карпычев Виталий Львович",
            "Сизов Дмитрий Сергеевич",
            "Сивак Виктор Михайлович",
            "Филипенко Вадим Андреевич"});
            this.workerBox.Location = new System.Drawing.Point(338, 117);
            this.workerBox.Name = "workerBox";
            this.workerBox.Size = new System.Drawing.Size(161, 24);
            this.workerBox.TabIndex = 9;
            this.workerBox.SelectedIndexChanged += new System.EventHandler(this.workerBox_SelectedIndexChanged);
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(699, 287);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(154, 54);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(269, 179);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 12;
            this.dateTimePicker2.Value = new System.DateTime(2021, 11, 19, 9, 26, 0, 0);
            // 
            // DebugText
            // 
            this.DebugText.Location = new System.Drawing.Point(98, 28);
            this.DebugText.Name = "DebugText";
            this.DebugText.Size = new System.Drawing.Size(657, 48);
            this.DebugText.TabIndex = 13;
            this.DebugText.Text = "label1";
            this.DebugText.Click += new System.EventHandler(this.DebugText_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 654);
            this.Controls.Add(this.DebugText);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.workerLabel);
            this.Controls.Add(this.workerBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.equipmentLabel);
            this.Controls.Add(this.equipmentBox);
            this.Controls.Add(this.plantLabel);
            this.Controls.Add(this.plantBox);
            this.Controls.Add(this.newJobButton);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Файл;
        private System.Windows.Forms.Button newJobButton;
        private System.Windows.Forms.ComboBox plantBox;
        private System.Windows.Forms.Label plantLabel;
        private System.Windows.Forms.Label equipmentLabel;
        private System.Windows.Forms.ComboBox equipmentBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label workerLabel;
        private System.Windows.Forms.ComboBox workerBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label DebugText;
    }
}

