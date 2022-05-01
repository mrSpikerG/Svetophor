using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2
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
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Text = "Светофор";

            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;

            this.Location = new System.Drawing.Point(300, 0);

            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;

            //фиксирование начальных размеров
            this.oldHeight = this.Height;
            this.oldWidth = this.Width;

           
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 4500;
            timer.Tick += Red;
            timer.Start();
        }
        private void Red(object sender, System.EventArgs e)
        {
            this.Location = new System.Drawing.Point(300, 0);
            timer.Interval = 45000;

            this.BackColor = Color.Red;
            this.Size = new Size(this.oldWidth, this.oldHeight);
            timer.Tick += Yellow;
        }
        private void Yellow(object sender, System.EventArgs e)
        {
            this.Location = new System.Drawing.Point(300, 250);
            timer.Interval = 5000;

            this.BackColor = Color.Yellow;
            this.Size = new Size(this.oldWidth/3, this.oldHeight/3);
            timer.Tick += Green;
        }
        private void Green(object sender, System.EventArgs e)
        {
            this.Location = new System.Drawing.Point(300, 400);
            timer.Interval = 45000;

            this.BackColor = Color.Green;
            this.Size = new Size(this.oldWidth/2, this.oldHeight/2);
            timer.Tick += Red;
        }

        private System.Windows.Forms.Timer timer;
        private int oldWidth = 0;
        private int oldHeight = 0;
        #endregion
    }
}

