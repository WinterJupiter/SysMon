namespace SysMon
{
    partial class body
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(body));
            this.menu = new System.Windows.Forms.Panel();
            this.sysinfo = new System.Windows.Forms.Button();
            this.temperature = new System.Windows.Forms.Button();
            this.manager = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.head = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            this.panelContain = new System.Windows.Forms.Panel();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.head.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.Yellow;
            this.menu.Controls.Add(this.sysinfo);
            this.menu.Controls.Add(this.temperature);
            this.menu.Controls.Add(this.manager);
            this.menu.Controls.Add(this.pictureBox4);
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(99, 582);
            this.menu.TabIndex = 0;
            // 
            // sysinfo
            // 
            this.sysinfo.FlatAppearance.BorderSize = 0;
            this.sysinfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sysinfo.Image = ((System.Drawing.Image)(resources.GetObject("sysinfo.Image")));
            this.sysinfo.Location = new System.Drawing.Point(15, 320);
            this.sysinfo.Margin = new System.Windows.Forms.Padding(4);
            this.sysinfo.Name = "sysinfo";
            this.sysinfo.Size = new System.Drawing.Size(79, 65);
            this.sysinfo.TabIndex = 5;
            this.sysinfo.UseVisualStyleBackColor = true;
            this.sysinfo.Click += new System.EventHandler(this.sysinfo_Click);
            // 
            // temperature
            // 
            this.temperature.FlatAppearance.BorderSize = 0;
            this.temperature.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.temperature.Image = ((System.Drawing.Image)(resources.GetObject("temperature.Image")));
            this.temperature.Location = new System.Drawing.Point(15, 223);
            this.temperature.Margin = new System.Windows.Forms.Padding(4);
            this.temperature.Name = "temperature";
            this.temperature.Size = new System.Drawing.Size(79, 65);
            this.temperature.TabIndex = 4;
            this.temperature.UseVisualStyleBackColor = true;
            this.temperature.Click += new System.EventHandler(this.temperature_Click);
            // 
            // manager
            // 
            this.manager.FlatAppearance.BorderSize = 0;
            this.manager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manager.Image = ((System.Drawing.Image)(resources.GetObject("manager.Image")));
            this.manager.Location = new System.Drawing.Point(15, 126);
            this.manager.Margin = new System.Windows.Forms.Padding(4);
            this.manager.Name = "manager";
            this.manager.Size = new System.Drawing.Size(79, 65);
            this.manager.TabIndex = 3;
            this.manager.UseVisualStyleBackColor = true;
            this.manager.Click += new System.EventHandler(this.manager_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(-17, 459);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 100);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // head
            // 
            this.head.BackColor = System.Drawing.SystemColors.Control;
            this.head.Controls.Add(this.exit);
            this.head.Controls.Add(this.name);
            this.head.Dock = System.Windows.Forms.DockStyle.Top;
            this.head.Location = new System.Drawing.Point(99, 0);
            this.head.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.head.Name = "head";
            this.head.Size = new System.Drawing.Size(841, 65);
            this.head.TabIndex = 1;
            // 
            // exit
            // 
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.Location = new System.Drawing.Point(780, 14);
            this.exit.Margin = new System.Windows.Forms.Padding(4);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(33, 31);
            this.exit.TabIndex = 2;
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.button1_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.ForeColor = System.Drawing.SystemColors.ControlText;
            this.name.Location = new System.Drawing.Point(264, 14);
            this.name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(246, 32);
            this.name.TabIndex = 1;
            this.name.Text = "SysMonitor with Alina";
            // 
            // panelContain
            // 
            this.panelContain.BackColor = System.Drawing.SystemColors.Control;
            this.panelContain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContain.Location = new System.Drawing.Point(99, 65);
            this.panelContain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelContain.Name = "panelContain";
            this.panelContain.Size = new System.Drawing.Size(841, 517);
            this.panelContain.TabIndex = 2;
            // 
            // body
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(940, 582);
            this.Controls.Add(this.panelContain);
            this.Controls.Add(this.head);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "body";
            this.Text = "SysMonitor with Alina";
            this.Load += new System.EventHandler(this.body_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.head.ResumeLayout(false);
            this.head.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.Panel head;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button sysinfo;
        private System.Windows.Forms.Button temperature;
        private System.Windows.Forms.Button manager;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Panel panelContain;
    }
}

