#region Copyright Syncfusion Inc. 2001-2018.
// Copyright Syncfusion Inc. 2001-2018. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion

namespace BudgetExecution
{
    
    
        using System;
        using System.ComponentModel;
        using System.Threading;
        using System.Windows.Forms;

        public partial class ColumnConfiguration
        {
            /// <summary>
            /// Required designer variable.
            /// </summary>
            private IContainer components = null;

            /// <summary>
            /// Clean up any resources being used.
            /// </summary>
            /// <dict name="disposing">true if managed resources should be disposed; otherwise, false.</dict>
            protected override void Dispose( bool disposing )
            {
                if( disposing && ( components != null ) )
                {
                    components.Dispose();
                }

                base.Dispose( disposing );
            }

            #region Windows Form Designer generated code

            /// <summary>
            /// Required method for Designer support - do not modify
            /// the contents of this method with the code editor.
            /// </summary>
            private void InitializeComponent()
            {
            Syncfusion.Windows.Forms.CaptionImage captionImage1 = new Syncfusion.Windows.Forms.CaptionImage();
            this.ColumnListBox = new System.Windows.Forms.CheckedListBox();
            this.ColumnConfigPanel = new System.Windows.Forms.Panel();
            this.ColumnConfigPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ColumnListBox
            // 
            this.ColumnListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ColumnListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ColumnListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ColumnListBox.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColumnListBox.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.ColumnListBox.FormattingEnabled = true;
            this.ColumnListBox.Location = new System.Drawing.Point(1, 1);
            this.ColumnListBox.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.ColumnListBox.Name = "ColumnListBox";
            this.ColumnListBox.Size = new System.Drawing.Size(210, 288);
            this.ColumnListBox.TabIndex = 3;
            // 
            // ColumnConfigPanel
            // 
            this.ColumnConfigPanel.Controls.Add(this.ColumnListBox);
            this.ColumnConfigPanel.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.ColumnConfigPanel.Location = new System.Drawing.Point(25, 23);
            this.ColumnConfigPanel.Name = "ColumnConfigPanel";
            this.ColumnConfigPanel.Padding = new System.Windows.Forms.Padding(1);
            this.ColumnConfigPanel.Size = new System.Drawing.Size(212, 290);
            this.ColumnConfigPanel.TabIndex = 5;
            // 
            // ColumnConfiguration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.BorderColor = System.Drawing.Color.SteelBlue;
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.CaptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CaptionButtonHoverColor = System.Drawing.Color.White;
            this.CaptionFont = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            captionImage1.BackColor = System.Drawing.Color.Transparent;
            captionImage1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            captionImage1.Location = new System.Drawing.Point(10, 5);
            captionImage1.Name = "Image";
            captionImage1.Size = new System.Drawing.Size(16, 16);
            this.CaptionImages.Add(captionImage1);
            this.ClientSize = new System.Drawing.Size(238, 314);
            this.Controls.Add(this.ColumnConfigPanel);
            this.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.MaximumSize = new System.Drawing.Size(250, 350);
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.MinimumSize = new System.Drawing.Size(250, 350);
            this.Name = "ColumnConfiguration";
            this.ShowIcon = false;
            this.ShowMaximizeBox = false;
            this.ShowMinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "       SELECT COLUMNS";
            this.ColumnConfigPanel.ResumeLayout(false);
            this.ResumeLayout(false);

            }

            #endregion

            public CheckedListBox ColumnListBox;

            public Panel ColumnConfigPanel;
        }
    
}