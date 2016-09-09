namespace OPCMessageReciever
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnMessage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnApplication = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnClear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBoxErorsAndWarnings = new System.Windows.Forms.GroupBox();
            this.lblExceptions = new System.Windows.Forms.Label();
            this.lblExceptionsValue = new System.Windows.Forms.Label();
            this.lblErrorsValue = new System.Windows.Forms.Label();
            this.lblErrors = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.параметрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.warningsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informMessagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxErorsAndWarnings.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnID,
            this.columnMessage,
            this.columnDate,
            this.columnType,
            this.columnApplication});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 27);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(742, 520);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnID
            // 
            this.columnID.Text = "ID";
            this.columnID.Width = 47;
            // 
            // columnMessage
            // 
            this.columnMessage.Text = "Сообщение";
            this.columnMessage.Width = 302;
            // 
            // columnDate
            // 
            this.columnDate.Text = "Время";
            this.columnDate.Width = 143;
            // 
            // columnType
            // 
            this.columnType.Text = "Тип сообщения";
            this.columnType.Width = 103;
            // 
            // columnApplication
            // 
            this.columnApplication.Text = "Программа";
            this.columnApplication.Width = 119;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 594);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 594);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.BalloonTipClicked += new System.EventHandler(this.notifyIcon1_BalloonTipClicked_1);
            // 
            // groupBoxErorsAndWarnings
            // 
            this.groupBoxErorsAndWarnings.Controls.Add(this.lblExceptions);
            this.groupBoxErorsAndWarnings.Controls.Add(this.lblExceptionsValue);
            this.groupBoxErorsAndWarnings.Controls.Add(this.lblErrorsValue);
            this.groupBoxErorsAndWarnings.Controls.Add(this.lblErrors);
            this.groupBoxErorsAndWarnings.Location = new System.Drawing.Point(760, 27);
            this.groupBoxErorsAndWarnings.Name = "groupBoxErorsAndWarnings";
            this.groupBoxErorsAndWarnings.Size = new System.Drawing.Size(167, 100);
            this.groupBoxErorsAndWarnings.TabIndex = 20;
            this.groupBoxErorsAndWarnings.TabStop = false;
            // 
            // lblExceptions
            // 
            this.lblExceptions.AutoSize = true;
            this.lblExceptions.Location = new System.Drawing.Point(6, 66);
            this.lblExceptions.Name = "lblExceptions";
            this.lblExceptions.Size = new System.Drawing.Size(97, 13);
            this.lblExceptions.TabIndex = 13;
            this.lblExceptions.Text = "Предупреждения:";
            // 
            // lblExceptionsValue
            // 
            this.lblExceptionsValue.AutoSize = true;
            this.lblExceptionsValue.Location = new System.Drawing.Point(111, 66);
            this.lblExceptionsValue.Name = "lblExceptionsValue";
            this.lblExceptionsValue.Size = new System.Drawing.Size(35, 13);
            this.lblExceptionsValue.TabIndex = 15;
            this.lblExceptionsValue.Text = "label3";
            // 
            // lblErrorsValue
            // 
            this.lblErrorsValue.AutoSize = true;
            this.lblErrorsValue.Location = new System.Drawing.Point(111, 29);
            this.lblErrorsValue.Name = "lblErrorsValue";
            this.lblErrorsValue.Size = new System.Drawing.Size(35, 13);
            this.lblErrorsValue.TabIndex = 14;
            this.lblErrorsValue.Text = "label2";
            // 
            // lblErrors
            // 
            this.lblErrors.AutoSize = true;
            this.lblErrors.Location = new System.Drawing.Point(6, 29);
            this.lblErrors.Name = "lblErrors";
            this.lblErrors.Size = new System.Drawing.Size(50, 13);
            this.lblErrors.TabIndex = 12;
            this.lblErrors.Text = "Ошибки:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.formatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(934, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.параметрыToolStripMenuItem,
            this.toolStripSeparator1,
            this.выходToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // параметрыToolStripMenuItem
            // 
            this.параметрыToolStripMenuItem.Enabled = false;
            this.параметрыToolStripMenuItem.Name = "параметрыToolStripMenuItem";
            this.параметрыToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.параметрыToolStripMenuItem.Text = "Параметры...";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.errorsToolStripMenuItem,
            this.warningsToolStripMenuItem,
            this.informMessagesToolStripMenuItem});
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.formatToolStripMenuItem.Text = "Формат";
            // 
            // errorsToolStripMenuItem
            // 
            this.errorsToolStripMenuItem.Checked = true;
            this.errorsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.errorsToolStripMenuItem.Enabled = false;
            this.errorsToolStripMenuItem.Name = "errorsToolStripMenuItem";
            this.errorsToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.errorsToolStripMenuItem.Text = "Ошибки";
            // 
            // warningsToolStripMenuItem
            // 
            this.warningsToolStripMenuItem.Checked = true;
            this.warningsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.warningsToolStripMenuItem.Name = "warningsToolStripMenuItem";
            this.warningsToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.warningsToolStripMenuItem.Text = "Предупреждения";
            this.warningsToolStripMenuItem.Click += new System.EventHandler(this.warningsToolStripMenuItem_Click);
            // 
            // informMessagesToolStripMenuItem
            // 
            this.informMessagesToolStripMenuItem.Checked = true;
            this.informMessagesToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.informMessagesToolStripMenuItem.Name = "informMessagesToolStripMenuItem";
            this.informMessagesToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.informMessagesToolStripMenuItem.Text = "Информ. сообщения";
            this.informMessagesToolStripMenuItem.Click += new System.EventHandler(this.informMessagesToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(166, 48);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.showToolStripMenuItem.Text = "Показать/Скрыть";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.closeToolStripMenuItem.Text = "Закрыть";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 629);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBoxErorsAndWarnings);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBoxErorsAndWarnings.ResumeLayout(false);
            this.groupBoxErorsAndWarnings.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnID;
        private System.Windows.Forms.ColumnHeader columnMessage;
        private System.Windows.Forms.ColumnHeader columnDate;
        private System.Windows.Forms.ColumnHeader columnType;
        private System.Windows.Forms.ColumnHeader columnApplication;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.GroupBox groupBoxErorsAndWarnings;
        private System.Windows.Forms.Label lblExceptions;
        private System.Windows.Forms.Label lblExceptionsValue;
        private System.Windows.Forms.Label lblErrorsValue;
        private System.Windows.Forms.Label lblErrors;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem параметрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem errorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem warningsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informMessagesToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}

