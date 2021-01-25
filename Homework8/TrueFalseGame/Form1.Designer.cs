
namespace TrueFalseGame
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
            this.Questions = new System.Windows.Forms.TextBox();
            this.True = new System.Windows.Forms.Button();
            this.False = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Questions
            // 
            this.Questions.Location = new System.Drawing.Point(87, 57);
            this.Questions.Name = "Questions";
            this.Questions.Size = new System.Drawing.Size(650, 22);
            this.Questions.TabIndex = 0;
            // 
            // True
            // 
            this.True.Location = new System.Drawing.Point(121, 218);
            this.True.Name = "True";
            this.True.Size = new System.Drawing.Size(151, 99);
            this.True.TabIndex = 1;
            this.True.Text = "True";
            this.True.UseVisualStyleBackColor = true;
            this.True.Click += new System.EventHandler(this.True_Click);
            // 
            // False
            // 
            this.False.Location = new System.Drawing.Point(525, 218);
            this.False.Name = "False";
            this.False.Size = new System.Drawing.Size(151, 99);
            this.False.TabIndex = 2;
            this.False.Text = "False";
            this.False.UseVisualStyleBackColor = true;
            this.False.Click += new System.EventHandler(this.False_Click);
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(304, 373);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(182, 23);
            this.Next.TabIndex = 3;
            this.Next.Text = "Next question";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.False);
            this.Controls.Add(this.True);
            this.Controls.Add(this.Questions);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Questions;
        private System.Windows.Forms.Button True;
        private System.Windows.Forms.Button False;
        private System.Windows.Forms.Button Next;
    }
}

