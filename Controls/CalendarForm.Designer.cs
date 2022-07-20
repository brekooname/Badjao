namespace BudgetExecution
{
    partial class CalendarForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if( disposing && ( components != null ) )
            {
                components.Dispose( );
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalendarForm));
            this.Calendar = new Syncfusion.WinForms.Input.SfCalendar();
            this.SuspendLayout();
            // 
            // Calendar
            // 
            this.Calendar.CanOverrideStyle = true;
            this.Calendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.Calendar.Location = new System.Drawing.Point(26, 52);
            this.Calendar.Name = "Calendar";
            this.Calendar.ShowToolTip = true;
            this.Calendar.Size = new System.Drawing.Size(623, 395);
            this.Calendar.Style.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Calendar.Style.Cell.BlackoutDatesBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Calendar.Style.Cell.BlackoutDatesForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Calendar.Style.Cell.CellBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Calendar.Style.Cell.CellFont = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calendar.Style.Cell.CellForeColor = System.Drawing.Color.SteelBlue;
            this.Calendar.Style.Cell.CellHoverBorderColor = System.Drawing.Color.SteelBlue;
            this.Calendar.Style.Cell.SelectedCellBackColor = System.Drawing.Color.SteelBlue;
            this.Calendar.Style.Cell.SelectedCellBorderColor = System.Drawing.Color.SteelBlue;
            this.Calendar.Style.Cell.SelectedCellFont = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calendar.Style.Cell.SelectedCellForeColor = System.Drawing.Color.White;
            this.Calendar.Style.Cell.SelectedCellHoverBorderColor = System.Drawing.Color.SteelBlue;
            this.Calendar.Style.Cell.TodayBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Calendar.Style.Cell.TodayFont = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calendar.Style.Cell.TodayForeColor = System.Drawing.Color.SteelBlue;
            this.Calendar.Style.Cell.TodayHoverBorderColor = System.Drawing.Color.SteelBlue;
            this.Calendar.Style.Cell.TrailingCellBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Calendar.Style.Cell.TrailingCellFont = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calendar.Style.Cell.TrailingCellForeColor = System.Drawing.Color.SteelBlue;
            this.Calendar.Style.Cell.WeekNumberBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Calendar.Style.Cell.WeekNumberFont = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calendar.Style.Cell.WeekNumberForeColor = System.Drawing.Color.SteelBlue;
            this.Calendar.Style.Footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Calendar.Style.Footer.ForeColor = System.Drawing.Color.SteelBlue;
            this.Calendar.Style.Footer.HoverBackColor = System.Drawing.Color.SteelBlue;
            this.Calendar.Style.Footer.HoverForeColor = System.Drawing.Color.White;
            this.Calendar.Style.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Calendar.Style.Header.DayNamesBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Calendar.Style.Header.DayNamesFont = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calendar.Style.Header.DayNamesForeColor = System.Drawing.Color.SteelBlue;
            this.Calendar.Style.Header.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calendar.Style.Header.ForeColor = System.Drawing.Color.SteelBlue;
            this.Calendar.Style.Header.HoverForeColor = System.Drawing.Color.White;
            this.Calendar.Style.Header.NavigationButtonDisabledForeColor = System.Drawing.Color.DimGray;
            this.Calendar.Style.Header.NavigationButtonForeColor = System.Drawing.Color.SteelBlue;
            this.Calendar.Style.Header.NavigationButtonHoverForeColor = System.Drawing.Color.White;
            this.Calendar.Style.HorizontalSplitterColor = System.Drawing.Color.DimGray;
            this.Calendar.Style.VerticalSplitterColor = System.Drawing.Color.DimGray;
            this.Calendar.TabIndex = 0;
            // 
            // CalendarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BorderColor = System.Drawing.Color.SteelBlue;
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.CaptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CaptionButtonHoverColor = System.Drawing.Color.Maroon;
            this.CaptionFont = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionForeColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(675, 469);
            this.Controls.Add(this.Calendar);
            this.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.MinimizeBox = false;
            this.Name = "CalendarForm";
            this.ShowIcon = false;
            this.ShowMaximizeBox = false;
            this.ShowMinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        public Syncfusion.WinForms.Input.SfCalendar Calendar;
    }
}