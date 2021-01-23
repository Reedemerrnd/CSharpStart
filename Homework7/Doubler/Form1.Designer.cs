namespace Doubler
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Score = new System.Windows.Forms.Label();
            this.CommandsCount = new System.Windows.Forms.Label();
            this.Increment = new System.Windows.Forms.Button();
            this.Multiplyer = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.Undo = new System.Windows.Forms.Button();
            this.Target = new System.Windows.Forms.Label();
            this.Turns = new System.Windows.Forms.Label();
            this.counterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(504, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.counterToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "menu";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.gameToolStripMenuItem.Text = "Game";
            this.gameToolStripMenuItem.Click += new System.EventHandler(this.gameToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.Location = new System.Drawing.Point(88, 82);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(46, 17);
            this.Score.TabIndex = 1;
            this.Score.Text = "label1";
            // 
            // CommandsCount
            // 
            this.CommandsCount.AutoSize = true;
            this.CommandsCount.Location = new System.Drawing.Point(12, 273);
            this.CommandsCount.Name = "CommandsCount";
            this.CommandsCount.Size = new System.Drawing.Size(46, 17);
            this.CommandsCount.TabIndex = 2;
            this.CommandsCount.Text = "label1";
            // 
            // Increment
            // 
            this.Increment.Location = new System.Drawing.Point(380, 40);
            this.Increment.Name = "Increment";
            this.Increment.Size = new System.Drawing.Size(110, 59);
            this.Increment.TabIndex = 3;
            this.Increment.Text = "button1";
            this.Increment.UseVisualStyleBackColor = true;
            this.Increment.Click += new System.EventHandler(this.Increment_Click);
            // 
            // Multiplyer
            // 
            this.Multiplyer.Location = new System.Drawing.Point(380, 123);
            this.Multiplyer.Name = "Multiplyer";
            this.Multiplyer.Size = new System.Drawing.Size(110, 59);
            this.Multiplyer.TabIndex = 4;
            this.Multiplyer.Text = "button2";
            this.Multiplyer.UseVisualStyleBackColor = true;
            this.Multiplyer.Click += new System.EventHandler(this.Multiplyer_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(380, 252);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(110, 59);
            this.Reset.TabIndex = 5;
            this.Reset.Text = "button3";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Undo
            // 
            this.Undo.Location = new System.Drawing.Point(401, 198);
            this.Undo.Name = "Undo";
            this.Undo.Size = new System.Drawing.Size(59, 34);
            this.Undo.TabIndex = 6;
            this.Undo.Text = "button4";
            this.Undo.UseVisualStyleBackColor = true;
            this.Undo.Click += new System.EventHandler(this.Undo_Click);
            // 
            // Target
            // 
            this.Target.AutoSize = true;
            this.Target.Location = new System.Drawing.Point(88, 123);
            this.Target.Name = "Target";
            this.Target.Size = new System.Drawing.Size(46, 17);
            this.Target.TabIndex = 7;
            this.Target.Text = "label1";
            // 
            // Turns
            // 
            this.Turns.AutoSize = true;
            this.Turns.Location = new System.Drawing.Point(88, 165);
            this.Turns.Name = "Turns";
            this.Turns.Size = new System.Drawing.Size(46, 17);
            this.Turns.TabIndex = 8;
            this.Turns.Text = "label1";
            // 
            // counterToolStripMenuItem
            // 
            this.counterToolStripMenuItem.Name = "counterToolStripMenuItem";
            this.counterToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.counterToolStripMenuItem.Text = "Counter";
            this.counterToolStripMenuItem.Click += new System.EventHandler(this.counterToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 324);
            this.Controls.Add(this.Turns);
            this.Controls.Add(this.Target);
            this.Controls.Add(this.Undo);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Multiplyer);
            this.Controls.Add(this.Increment);
            this.Controls.Add(this.CommandsCount);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label CommandsCount;
        private System.Windows.Forms.Button Increment;
        private System.Windows.Forms.Button Multiplyer;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button Undo;
        private System.Windows.Forms.Label Target;
        private System.Windows.Forms.Label Turns;
        private System.Windows.Forms.ToolStripMenuItem counterToolStripMenuItem;
    }
}

