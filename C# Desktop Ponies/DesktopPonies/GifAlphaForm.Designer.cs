﻿namespace CSDesktopPonies.DesktopPonies
{
    partial class GifAlphaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ImageSelector = new System.Windows.Forms.ComboBox();
            this.ColorDialog = new System.Windows.Forms.ColorDialog();
            this.ImageComparison = new System.Windows.Forms.SplitContainer();
            this.BackgroundColorCommand = new System.Windows.Forms.Button();
            this.ImageSourcePalette = new System.Windows.Forms.Panel();
            this.ImageDesiredPalette = new System.Windows.Forms.Panel();
            this.DesiredColorCode = new System.Windows.Forms.TextBox();
            this.DesiredAlphaCode = new System.Windows.Forms.TextBox();
            this.FrameSelector = new System.Windows.Forms.TrackBar();
            this.SaveCommand = new System.Windows.Forms.Button();
            this.FrameControls = new System.Windows.Forms.GroupBox();
            this.PreviousCommand = new System.Windows.Forms.Button();
            this.NextCommand = new System.Windows.Forms.Button();
            this.PlayCommand = new System.Windows.Forms.Button();
            this.TimeSelectorSections = new System.Windows.Forms.Panel();
            this.TimeSelector = new System.Windows.Forms.TrackBar();
            this.FrameLabel = new System.Windows.Forms.Label();
            this.ImageNameLabel = new System.Windows.Forms.Label();
            this.ColorControls = new System.Windows.Forms.GroupBox();
            this.ImageColors = new System.Windows.Forms.Panel();
            this.ImageSourceColor = new System.Windows.Forms.Panel();
            this.ImageDesiredColor = new System.Windows.Forms.Panel();
            this.SourceColorCode = new System.Windows.Forms.TextBox();
            this.SourceAlphaCode = new System.Windows.Forms.TextBox();
            this.PaletteControls = new System.Windows.Forms.GroupBox();
            this.DesiredPaletteLabel = new System.Windows.Forms.Label();
            this.SourcePaletteLabel = new System.Windows.Forms.Label();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.AnimationTimer = new System.Windows.Forms.Timer(this.components);
            this.ResetCommand = new System.Windows.Forms.Button();
            this.ImageComparison.SuspendLayout();
            this.FrameControls.SuspendLayout();
            this.ColorControls.SuspendLayout();
            this.ImageColors.SuspendLayout();
            this.PaletteControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImageSelector
            // 
            this.ImageSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ImageSelector.FormattingEnabled = true;
            this.ImageSelector.Location = new System.Drawing.Point(73, 12);
            this.ImageSelector.Name = "ImageSelector";
            this.ImageSelector.Size = new System.Drawing.Size(649, 21);
            this.ImageSelector.TabIndex = 1;
            this.ImageSelector.SelectedIndexChanged += new System.EventHandler(this.ImageSelector_SelectedIndexChanged);
            // 
            // ColorDialog
            // 
            this.ColorDialog.FullOpen = true;
            // 
            // ImageComparison
            // 
            this.ImageComparison.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageComparison.BackColor = System.Drawing.Color.Black;
            this.ImageComparison.Location = new System.Drawing.Point(12, 178);
            this.ImageComparison.Name = "ImageComparison";
            // 
            // ImageComparison.Panel1
            // 
            this.ImageComparison.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ImageComparison.Panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ImageComparison_Panel_MouseClick);
            // 
            // ImageComparison.Panel2
            // 
            this.ImageComparison.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ImageComparison.Panel2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ImageComparison_Panel_MouseClick);
            this.ImageComparison.Size = new System.Drawing.Size(710, 322);
            this.ImageComparison.SplitterDistance = 352;
            this.ImageComparison.TabIndex = 6;
            // 
            // BackgroundColorCommand
            // 
            this.BackgroundColorCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BackgroundColorCommand.Location = new System.Drawing.Point(223, 25);
            this.BackgroundColorCommand.Name = "BackgroundColorCommand";
            this.BackgroundColorCommand.Size = new System.Drawing.Size(128, 23);
            this.BackgroundColorCommand.TabIndex = 6;
            this.BackgroundColorCommand.Text = "Change Background";
            this.BackgroundColorCommand.UseVisualStyleBackColor = true;
            this.BackgroundColorCommand.Click += new System.EventHandler(this.BackgroundColorCommand_Click);
            // 
            // ImageSourcePalette
            // 
            this.ImageSourcePalette.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageSourcePalette.BackColor = System.Drawing.Color.Black;
            this.ImageSourcePalette.Location = new System.Drawing.Point(55, 16);
            this.ImageSourcePalette.Name = "ImageSourcePalette";
            this.ImageSourcePalette.Size = new System.Drawing.Size(423, 13);
            this.ImageSourcePalette.TabIndex = 1;
            this.ImageSourcePalette.Resize += new System.EventHandler(this.ImagePalette_Resize);
            // 
            // ImageDesiredPalette
            // 
            this.ImageDesiredPalette.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageDesiredPalette.BackColor = System.Drawing.Color.Black;
            this.ImageDesiredPalette.Location = new System.Drawing.Point(55, 38);
            this.ImageDesiredPalette.Name = "ImageDesiredPalette";
            this.ImageDesiredPalette.Size = new System.Drawing.Size(423, 13);
            this.ImageDesiredPalette.TabIndex = 3;
            this.ImageDesiredPalette.Resize += new System.EventHandler(this.ImagePalette_Resize);
            // 
            // DesiredColorCode
            // 
            this.DesiredColorCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DesiredColorCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.DesiredColorCode.Font = new System.Drawing.Font("Segoe UI Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesiredColorCode.Location = new System.Drawing.Point(125, 41);
            this.DesiredColorCode.Margin = new System.Windows.Forms.Padding(1);
            this.DesiredColorCode.MaxLength = 6;
            this.DesiredColorCode.Name = "DesiredColorCode";
            this.DesiredColorCode.Size = new System.Drawing.Size(56, 22);
            this.DesiredColorCode.TabIndex = 4;
            this.DesiredColorCode.TextChanged += new System.EventHandler(this.DesiredColorCode_TextChanged);
            // 
            // DesiredAlphaCode
            // 
            this.DesiredAlphaCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DesiredAlphaCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.DesiredAlphaCode.Font = new System.Drawing.Font("Segoe UI Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesiredAlphaCode.Location = new System.Drawing.Point(99, 41);
            this.DesiredAlphaCode.Margin = new System.Windows.Forms.Padding(1);
            this.DesiredAlphaCode.MaxLength = 2;
            this.DesiredAlphaCode.Name = "DesiredAlphaCode";
            this.DesiredAlphaCode.Size = new System.Drawing.Size(24, 22);
            this.DesiredAlphaCode.TabIndex = 3;
            this.DesiredAlphaCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DesiredAlphaCode.TextChanged += new System.EventHandler(this.DesiredAlphaCode_TextChanged);
            // 
            // FrameSelector
            // 
            this.FrameSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FrameSelector.Location = new System.Drawing.Point(6, 19);
            this.FrameSelector.Maximum = 0;
            this.FrameSelector.Name = "FrameSelector";
            this.FrameSelector.Size = new System.Drawing.Size(208, 45);
            this.FrameSelector.TabIndex = 0;
            this.FrameSelector.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.FrameSelector.ValueChanged += new System.EventHandler(this.FrameSelector_ValueChanged);
            // 
            // SaveCommand
            // 
            this.SaveCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveCommand.Location = new System.Drawing.Point(380, 37);
            this.SaveCommand.Name = "SaveCommand";
            this.SaveCommand.Size = new System.Drawing.Size(98, 23);
            this.SaveCommand.TabIndex = 5;
            this.SaveCommand.Text = "Save Mapping";
            this.SaveCommand.UseVisualStyleBackColor = true;
            this.SaveCommand.Click += new System.EventHandler(this.SaveCommand_Click);
            // 
            // FrameControls
            // 
            this.FrameControls.Controls.Add(this.PreviousCommand);
            this.FrameControls.Controls.Add(this.NextCommand);
            this.FrameControls.Controls.Add(this.PlayCommand);
            this.FrameControls.Controls.Add(this.TimeSelectorSections);
            this.FrameControls.Controls.Add(this.TimeSelector);
            this.FrameControls.Controls.Add(this.FrameLabel);
            this.FrameControls.Controls.Add(this.FrameSelector);
            this.FrameControls.Location = new System.Drawing.Point(12, 39);
            this.FrameControls.Name = "FrameControls";
            this.FrameControls.Size = new System.Drawing.Size(220, 133);
            this.FrameControls.TabIndex = 2;
            this.FrameControls.TabStop = false;
            this.FrameControls.Text = "Frame";
            // 
            // PreviousCommand
            // 
            this.PreviousCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PreviousCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviousCommand.Location = new System.Drawing.Point(54, 68);
            this.PreviousCommand.Name = "PreviousCommand";
            this.PreviousCommand.Size = new System.Drawing.Size(25, 16);
            this.PreviousCommand.TabIndex = 2;
            this.PreviousCommand.Text = "<";
            this.PreviousCommand.UseVisualStyleBackColor = true;
            this.PreviousCommand.Click += new System.EventHandler(this.PreviousCommand_Click);
            // 
            // NextCommand
            // 
            this.NextCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NextCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextCommand.Location = new System.Drawing.Point(141, 68);
            this.NextCommand.Name = "NextCommand";
            this.NextCommand.Size = new System.Drawing.Size(25, 16);
            this.NextCommand.TabIndex = 4;
            this.NextCommand.Text = ">";
            this.NextCommand.UseVisualStyleBackColor = true;
            this.NextCommand.Click += new System.EventHandler(this.NextCommand_Click);
            // 
            // PlayCommand
            // 
            this.PlayCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayCommand.Location = new System.Drawing.Point(85, 68);
            this.PlayCommand.Name = "PlayCommand";
            this.PlayCommand.Size = new System.Drawing.Size(50, 16);
            this.PlayCommand.TabIndex = 3;
            this.PlayCommand.Text = "Play";
            this.PlayCommand.UseVisualStyleBackColor = true;
            this.PlayCommand.Click += new System.EventHandler(this.PlayCommand_Click);
            // 
            // TimeSelectorSections
            // 
            this.TimeSelectorSections.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeSelectorSections.Location = new System.Drawing.Point(20, 104);
            this.TimeSelectorSections.Name = "TimeSelectorSections";
            this.TimeSelectorSections.Size = new System.Drawing.Size(180, 4);
            this.TimeSelectorSections.TabIndex = 6;
            this.TimeSelectorSections.Paint += new System.Windows.Forms.PaintEventHandler(this.TimeSelectorSections_Paint);
            // 
            // TimeSelector
            // 
            this.TimeSelector.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeSelector.LargeChange = 5000;
            this.TimeSelector.Location = new System.Drawing.Point(6, 82);
            this.TimeSelector.Maximum = 0;
            this.TimeSelector.Name = "TimeSelector";
            this.TimeSelector.Size = new System.Drawing.Size(208, 45);
            this.TimeSelector.SmallChange = 1000;
            this.TimeSelector.TabIndex = 5;
            this.TimeSelector.TickFrequency = 0;
            this.TimeSelector.ValueChanged += new System.EventHandler(this.TimeSelector_ValueChanged);
            // 
            // FrameLabel
            // 
            this.FrameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FrameLabel.Location = new System.Drawing.Point(6, 49);
            this.FrameLabel.Name = "FrameLabel";
            this.FrameLabel.Size = new System.Drawing.Size(208, 16);
            this.FrameLabel.TabIndex = 1;
            this.FrameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ImageNameLabel
            // 
            this.ImageNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageNameLabel.AutoSize = true;
            this.ImageNameLabel.Location = new System.Drawing.Point(12, 15);
            this.ImageNameLabel.Name = "ImageNameLabel";
            this.ImageNameLabel.Size = new System.Drawing.Size(55, 13);
            this.ImageNameLabel.TabIndex = 0;
            this.ImageNameLabel.Text = "Image file:";
            // 
            // ColorControls
            // 
            this.ColorControls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ColorControls.Controls.Add(this.ResetCommand);
            this.ColorControls.Controls.Add(this.BackgroundColorCommand);
            this.ColorControls.Controls.Add(this.SaveCommand);
            this.ColorControls.Controls.Add(this.ImageColors);
            this.ColorControls.Controls.Add(this.SourceColorCode);
            this.ColorControls.Controls.Add(this.SourceAlphaCode);
            this.ColorControls.Controls.Add(this.DesiredColorCode);
            this.ColorControls.Controls.Add(this.DesiredAlphaCode);
            this.ColorControls.Location = new System.Drawing.Point(238, 105);
            this.ColorControls.Name = "ColorControls";
            this.ColorControls.Size = new System.Drawing.Size(484, 67);
            this.ColorControls.TabIndex = 4;
            this.ColorControls.TabStop = false;
            this.ColorControls.Text = "Color";
            // 
            // ImageColors
            // 
            this.ImageColors.BackColor = System.Drawing.Color.Black;
            this.ImageColors.Controls.Add(this.ImageSourceColor);
            this.ImageColors.Controls.Add(this.ImageDesiredColor);
            this.ImageColors.Location = new System.Drawing.Point(6, 17);
            this.ImageColors.Name = "ImageColors";
            this.ImageColors.Size = new System.Drawing.Size(89, 46);
            this.ImageColors.TabIndex = 0;
            // 
            // ImageSourceColor
            // 
            this.ImageSourceColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ImageSourceColor.Location = new System.Drawing.Point(3, 3);
            this.ImageSourceColor.Name = "ImageSourceColor";
            this.ImageSourceColor.Size = new System.Drawing.Size(40, 40);
            this.ImageSourceColor.TabIndex = 0;
            // 
            // ImageDesiredColor
            // 
            this.ImageDesiredColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ImageDesiredColor.Location = new System.Drawing.Point(46, 3);
            this.ImageDesiredColor.Name = "ImageDesiredColor";
            this.ImageDesiredColor.Size = new System.Drawing.Size(40, 40);
            this.ImageDesiredColor.TabIndex = 1;
            this.ImageDesiredColor.Click += new System.EventHandler(this.ImageDesiredColor_Click);
            // 
            // SourceColorCode
            // 
            this.SourceColorCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.SourceColorCode.Font = new System.Drawing.Font("Segoe UI Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SourceColorCode.Location = new System.Drawing.Point(125, 17);
            this.SourceColorCode.Margin = new System.Windows.Forms.Padding(1);
            this.SourceColorCode.MaxLength = 6;
            this.SourceColorCode.Name = "SourceColorCode";
            this.SourceColorCode.ReadOnly = true;
            this.SourceColorCode.Size = new System.Drawing.Size(56, 22);
            this.SourceColorCode.TabIndex = 2;
            // 
            // SourceAlphaCode
            // 
            this.SourceAlphaCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.SourceAlphaCode.Font = new System.Drawing.Font("Segoe UI Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SourceAlphaCode.Location = new System.Drawing.Point(99, 17);
            this.SourceAlphaCode.Margin = new System.Windows.Forms.Padding(1);
            this.SourceAlphaCode.MaxLength = 2;
            this.SourceAlphaCode.Name = "SourceAlphaCode";
            this.SourceAlphaCode.ReadOnly = true;
            this.SourceAlphaCode.Size = new System.Drawing.Size(24, 22);
            this.SourceAlphaCode.TabIndex = 1;
            this.SourceAlphaCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // PaletteControls
            // 
            this.PaletteControls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PaletteControls.Controls.Add(this.DesiredPaletteLabel);
            this.PaletteControls.Controls.Add(this.SourcePaletteLabel);
            this.PaletteControls.Controls.Add(this.ImageSourcePalette);
            this.PaletteControls.Controls.Add(this.ImageDesiredPalette);
            this.PaletteControls.Location = new System.Drawing.Point(238, 39);
            this.PaletteControls.Name = "PaletteControls";
            this.PaletteControls.Size = new System.Drawing.Size(484, 60);
            this.PaletteControls.TabIndex = 3;
            this.PaletteControls.TabStop = false;
            this.PaletteControls.Text = "Palette";
            // 
            // DesiredPaletteLabel
            // 
            this.DesiredPaletteLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DesiredPaletteLabel.AutoSize = true;
            this.DesiredPaletteLabel.Location = new System.Drawing.Point(6, 38);
            this.DesiredPaletteLabel.Name = "DesiredPaletteLabel";
            this.DesiredPaletteLabel.Size = new System.Drawing.Size(43, 13);
            this.DesiredPaletteLabel.TabIndex = 2;
            this.DesiredPaletteLabel.Text = "Desired";
            // 
            // SourcePaletteLabel
            // 
            this.SourcePaletteLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SourcePaletteLabel.AutoSize = true;
            this.SourcePaletteLabel.Location = new System.Drawing.Point(6, 16);
            this.SourcePaletteLabel.Name = "SourcePaletteLabel";
            this.SourcePaletteLabel.Size = new System.Drawing.Size(41, 13);
            this.SourcePaletteLabel.TabIndex = 0;
            this.SourcePaletteLabel.Text = "Source";
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ErrorLabel.Location = new System.Drawing.Point(12, 178);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(710, 100);
            this.ErrorLabel.TabIndex = 5;
            this.ErrorLabel.Text = "Error Message";
            this.ErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ErrorLabel.Visible = false;
            // 
            // AnimationTimer
            // 
            this.AnimationTimer.Interval = 50;
            this.AnimationTimer.Tick += new System.EventHandler(this.AnimationTimer_Tick);
            // 
            // ResetCommand
            // 
            this.ResetCommand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetCommand.Location = new System.Drawing.Point(380, 13);
            this.ResetCommand.Name = "ResetCommand";
            this.ResetCommand.Size = new System.Drawing.Size(98, 23);
            this.ResetCommand.TabIndex = 7;
            this.ResetCommand.Text = "Reset Mapping";
            this.ResetCommand.UseVisualStyleBackColor = true;
            this.ResetCommand.Click += new System.EventHandler(this.ResetCommand_Click);
            // 
            // GifAlphaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 512);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.PaletteControls);
            this.Controls.Add(this.ColorControls);
            this.Controls.Add(this.ImageNameLabel);
            this.Controls.Add(this.FrameControls);
            this.Controls.Add(this.ImageComparison);
            this.Controls.Add(this.ImageSelector);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "GifAlphaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gif with Alpha - C# Desktop Ponies";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GifAlphaForm_FormClosing);
            this.Load += new System.EventHandler(this.GifAlphaForm_Load);
            this.ImageComparison.ResumeLayout(false);
            this.FrameControls.ResumeLayout(false);
            this.FrameControls.PerformLayout();
            this.ColorControls.ResumeLayout(false);
            this.ColorControls.PerformLayout();
            this.ImageColors.ResumeLayout(false);
            this.PaletteControls.ResumeLayout(false);
            this.PaletteControls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ImageSelector;
        private System.Windows.Forms.ColorDialog ColorDialog;
        private System.Windows.Forms.SplitContainer ImageComparison;
        private System.Windows.Forms.Button BackgroundColorCommand;
        private System.Windows.Forms.Panel ImageSourcePalette;
        private System.Windows.Forms.Panel ImageDesiredPalette;
        private System.Windows.Forms.TextBox DesiredColorCode;
        private System.Windows.Forms.TextBox DesiredAlphaCode;
        private System.Windows.Forms.TrackBar FrameSelector;
        private System.Windows.Forms.Button SaveCommand;
        private System.Windows.Forms.GroupBox FrameControls;
        private System.Windows.Forms.Label FrameLabel;
        private System.Windows.Forms.Label ImageNameLabel;
        private System.Windows.Forms.GroupBox ColorControls;
        private System.Windows.Forms.GroupBox PaletteControls;
        private System.Windows.Forms.Label DesiredPaletteLabel;
        private System.Windows.Forms.Label SourcePaletteLabel;
        private System.Windows.Forms.Panel ImageSourceColor;
        private System.Windows.Forms.TextBox SourceColorCode;
        private System.Windows.Forms.TextBox SourceAlphaCode;
        private System.Windows.Forms.Panel ImageDesiredColor;
        private System.Windows.Forms.Panel ImageColors;
        private System.Windows.Forms.TrackBar TimeSelector;
        private System.Windows.Forms.Panel TimeSelectorSections;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Button PreviousCommand;
        private System.Windows.Forms.Button NextCommand;
        private System.Windows.Forms.Button PlayCommand;
        private System.Windows.Forms.Timer AnimationTimer;
        private System.Windows.Forms.Button ResetCommand;
    }
}