﻿namespace WinFormsApp2
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
                this.listBox1 = new System.Windows.Forms.ListBox();
                this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
                this.SuspendLayout();
                // 
                // listBox1
                // 
                this.listBox1.FormattingEnabled = true;
                this.listBox1.ItemHeight = 16;
                this.listBox1.Location = new System.Drawing.Point(12, 12);
                this.listBox1.Name = "listBox1";
                this.listBox1.Size = new System.Drawing.Size(269, 164);
                this.listBox1.TabIndex = 0;
                this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
                // 
                // propertyGrid1
                // 
                this.propertyGrid1.HelpVisible = false;
                this.propertyGrid1.Location = new System.Drawing.Point(66, 233);
                this.propertyGrid1.Name = "propertyGrid1";
                this.propertyGrid1.Size = new System.Drawing.Size(205, 205);
                this.propertyGrid1.TabIndex = 1;
                this.propertyGrid1.Click += new System.EventHandler(this.propertyGrid1_Click);
                // 
                // Form1
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.ClientSize = new System.Drawing.Size(295, 450);
                this.Controls.Add(this.propertyGrid1);
                this.Controls.Add(this.listBox1);
                this.Name = "Form1";
                this.Text = "Form1";
                this.ResumeLayout(false);

            }

            #endregion

            private System.Windows.Forms.ListBox listBox1;
            private System.Windows.Forms.PropertyGrid propertyGrid1;
        }
    }

