namespace WindowsFormsApp35
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
            this.processListView = new System.Windows.Forms.ListView();
            this.Имя = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Потоки = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Дескрипторы = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.refreshButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // processListView
            // 
            this.processListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Имя,
            this.ID,
            this.Потоки,
            this.Дескрипторы});
            this.processListView.FullRowSelect = true;
            this.processListView.GridLines = true;
            this.processListView.HideSelection = false;
            this.processListView.Location = new System.Drawing.Point(12, 13);
            this.processListView.MultiSelect = false;
            this.processListView.Name = "processListView";
            this.processListView.Size = new System.Drawing.Size(508, 425);
            this.processListView.TabIndex = 0;
            this.processListView.UseCompatibleStateImageBehavior = false;
            this.processListView.View = System.Windows.Forms.View.Details;
            // 
            // Имя
            // 
            this.Имя.Width = 128;
            // 
            // ID
            // 
            this.ID.Width = 143;
            // 
            // Потоки
            // 
            this.Потоки.Width = 215;
            // 
            // Дескрипторы
            // 
            this.Дескрипторы.Width = 262;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(590, 110);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(168, 53);
            this.refreshButton.TabIndex = 1;
            this.refreshButton.Text = "Обновить";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(590, 217);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(168, 57);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.processListView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView processListView;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ColumnHeader Имя;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Потоки;
        private System.Windows.Forms.ColumnHeader Дескрипторы;
    }
}

