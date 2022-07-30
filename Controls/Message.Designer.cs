
namespace BudgetExecution
{
        using System;
        using System.ComponentModel;
        using System.Threading;
        using System.Windows.Forms;
        using VisualPlus.Toolkit.Controls.Editors;
        using VisualPlus.Toolkit.Controls.Interactivity;
        using VisualPlus.Toolkit.Controls.Layout;

        partial class Message
        {
            /// <summary>
            /// Required designer variable.
            /// </summary>
            private IContainer components = null;

            /// <summary>
            /// Clean up any resources being used.
            /// </summary>
            /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Message));
            this.TextBox = new VisualPlus.Toolkit.Controls.Editors.VisualRichTextBox();
            this.layout1 = new BudgetExecution.Layout();
            this.OpenButton = new BudgetExecution.Button();
            this.ToolTip = new BudgetExecution.ToolTip();
            this.CloseButton = new BudgetExecution.Button();
            this.layout1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextBox
            // 
            this.TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.TextBox.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.TextBox.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.TextBox.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBox.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.TextBox.Border.HoverVisible = true;
            this.TextBox.Border.Rounding = 6;
            this.TextBox.Border.Thickness = 1;
            this.TextBox.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.TextBox.Border.Visible = true;
            this.TextBox.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox.ForeColor = System.Drawing.Color.White;
            this.TextBox.Location = new System.Drawing.Point(99, 95);
            this.TextBox.MaxLength = 2147483647;
            this.TextBox.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.TextBox.Name = "TextBox";
            this.TextBox.ReadOnly = true;
            this.TextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Both;
            this.TextBox.ShowSelectionMargin = false;
            this.TextBox.Size = new System.Drawing.Size(418, 180);
            this.TextBox.TabIndex = 8;
            this.TextBox.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.TextBox.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TextBox.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TextBox.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TextBox.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.TextBox.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.TextBox.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // layout1
            // 
            this.layout1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.layout1.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.layout1.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.layout1.BindingSource = null;
            this.layout1.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.layout1.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.layout1.Border.HoverVisible = false;
            this.layout1.Border.Rounding = 6;
            this.layout1.Border.Thickness = 1;
            this.layout1.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.layout1.Border.Visible = true;
            this.layout1.Children = null;
            this.layout1.Controls.Add(this.OpenButton);
            this.layout1.Controls.Add(this.CloseButton);
            this.layout1.DataFilter = null;
            this.layout1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.layout1.Field = BudgetExecution.Field.RpioActivityCode;
            this.layout1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(139)))), ((int)(((byte)(138)))));
            this.layout1.HoverText = null;
            this.layout1.Location = new System.Drawing.Point(0, 323);
            this.layout1.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.layout1.Name = "layout1";
            this.layout1.Numeric = BudgetExecution.Numeric.NS;
            this.layout1.Padding = new System.Windows.Forms.Padding(1);
            this.layout1.Size = new System.Drawing.Size(609, 80);
            this.layout1.TabIndex = 12;
            this.layout1.Text = "layout1";
            this.layout1.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.layout1.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.layout1.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.layout1.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.layout1.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.layout1.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.layout1.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.layout1.ToolTip = null;
            // 
            // OpenButton
            // 
            this.OpenButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.OpenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.OpenButton.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.OpenButton.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.OpenButton.BackColorState.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.OpenButton.BackColorState.Pressed = System.Drawing.Color.SteelBlue;
            this.OpenButton.BindingSource = null;
            this.OpenButton.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.OpenButton.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.OpenButton.Border.HoverVisible = true;
            this.OpenButton.Border.Rounding = 6;
            this.OpenButton.Border.Thickness = 1;
            this.OpenButton.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.OpenButton.Border.Visible = true;
            this.OpenButton.DataFilter = null;
            this.OpenButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.OpenButton.Field = BudgetExecution.Field.RpioActivityCode;
            this.OpenButton.Font = new System.Drawing.Font("Roboto", 9F);
            this.OpenButton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.OpenButton.HoverText = null;
            this.OpenButton.Image = null;
            this.OpenButton.Images = null;
            this.OpenButton.Location = new System.Drawing.Point(99, 25);
            this.OpenButton.Margin = new System.Windows.Forms.Padding(0);
            this.OpenButton.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(141, 46);
            this.OpenButton.TabIndex = 9;
            this.OpenButton.Text = "Open";
            this.OpenButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.OpenButton.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.OpenButton.TextStyle.Enabled = System.Drawing.Color.LightSteelBlue;
            this.OpenButton.TextStyle.Hover = System.Drawing.Color.White;
            this.OpenButton.TextStyle.Pressed = System.Drawing.Color.White;
            this.OpenButton.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.OpenButton.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.OpenButton.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.OpenButton.ToolTip = this.ToolTip;
            // 
            // ToolTip
            // 
            this.ToolTip.AutoPopDelay = 5000;
            this.ToolTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.ToolTip.BindingSource = null;
            this.ToolTip.BorderColor = System.Drawing.SystemColors.Highlight;
            this.ToolTip.Field = BudgetExecution.Field.RpioActivityCode;
            this.ToolTip.ForeColor = System.Drawing.Color.White;
            this.ToolTip.InitialDelay = 500;
            this.ToolTip.Name = null;
            this.ToolTip.OwnerDraw = true;
            this.ToolTip.ReshowDelay = 100;
            this.ToolTip.Style = MetroSet_UI.Design.Style.Custom;
            this.ToolTip.StyleManager = null;
            this.ToolTip.ThemeAuthor = "Terry D. Eppler";
            this.ToolTip.ThemeName = "Budget Execution";
            this.ToolTip.TipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ToolTip.TipText = null;
            this.ToolTip.TipTitle = null;
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.CloseButton.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.CloseButton.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.CloseButton.BackColorState.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.CloseButton.BackColorState.Pressed = System.Drawing.Color.SteelBlue;
            this.CloseButton.BindingSource = null;
            this.CloseButton.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.CloseButton.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.CloseButton.Border.HoverVisible = true;
            this.CloseButton.Border.Rounding = 6;
            this.CloseButton.Border.Thickness = 1;
            this.CloseButton.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.CloseButton.Border.Visible = true;
            this.CloseButton.DataFilter = null;
            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CloseButton.Field = BudgetExecution.Field.RpioActivityCode;
            this.CloseButton.Font = new System.Drawing.Font("Roboto", 9F);
            this.CloseButton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.CloseButton.HoverText = null;
            this.CloseButton.Image = null;
            this.CloseButton.Images = null;
            this.CloseButton.Location = new System.Drawing.Point(376, 25);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(0);
            this.CloseButton.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(141, 46);
            this.CloseButton.TabIndex = 10;
            this.CloseButton.Text = "Close";
            this.CloseButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.CloseButton.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.CloseButton.TextStyle.Enabled = System.Drawing.Color.LightSteelBlue;
            this.CloseButton.TextStyle.Hover = System.Drawing.Color.White;
            this.CloseButton.TextStyle.Pressed = System.Drawing.Color.White;
            this.CloseButton.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.CloseButton.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.CloseButton.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.CloseButton.ToolTip = this.ToolTip;
            // 
            // Message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BorderColor = System.Drawing.Color.SteelBlue;
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.CaptionBarHeight = 3;
            this.CaptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CaptionButtonHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CaptionFont = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionForeColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(609, 403);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.layout1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightGray;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.MinimizeBox = false;
            this.Name = "Message";
            this.ShowIcon = false;
            this.ShowMaximizeBox = false;
            this.ShowMinimizeBox = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.layout1.ResumeLayout(false);
            this.ResumeLayout(false);

            }

            #endregion
        public VisualRichTextBox TextBox;
        public Button OpenButton;
        public ToolTip ToolTip;
        public Button CloseButton;
        private Layout layout1;
    }
    
}
