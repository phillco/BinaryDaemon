namespace BinaryDaemon.UI
{
    partial class WatcherOptionsForm
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
            if ( disposing && ( components != null ) )
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
        private void InitializeComponent( )
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( WatcherOptionsForm ) );
            this.lblWatchingFile = new System.Windows.Forms.Label( );
            this.cbRestartProcess = new System.Windows.Forms.CheckBox( );
            this.label1 = new System.Windows.Forms.Label( );
            this.tbRestartParameters = new System.Windows.Forms.TextBox( );
            this.label2 = new System.Windows.Forms.Label( );
            this.cbCopyFile = new System.Windows.Forms.CheckBox( );
            this.btnSave = new System.Windows.Forms.Button( );
            this.btnCancel = new System.Windows.Forms.Button( );
            this.tbCopyPath = new System.Windows.Forms.TextBox( );
            this.btnBrowse = new System.Windows.Forms.Button( );
            this.copyFolderBrowser = new System.Windows.Forms.FolderBrowserDialog( );
            this.SuspendLayout( );
            // 
            // lblWatchingFile
            // 
            this.lblWatchingFile.AutoSize = true;
            this.lblWatchingFile.Font = new System.Drawing.Font( "Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte) ( 0 ) ) );
            this.lblWatchingFile.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblWatchingFile.Location = new System.Drawing.Point( 13, 12 );
            this.lblWatchingFile.Name = "lblWatchingFile";
            this.lblWatchingFile.Size = new System.Drawing.Size( 81, 16 );
            this.lblWatchingFile.TabIndex = 0;
            this.lblWatchingFile.Text = "File Options";
            // 
            // cbRestartProcess
            // 
            this.cbRestartProcess.AutoSize = true;
            this.cbRestartProcess.Checked = true;
            this.cbRestartProcess.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRestartProcess.Location = new System.Drawing.Point( 43, 65 );
            this.cbRestartProcess.Name = "cbRestartProcess";
            this.cbRestartProcess.Size = new System.Drawing.Size( 71, 17 );
            this.cbRestartProcess.TabIndex = 1;
            this.cbRestartProcess.Text = "Restart it";
            this.cbRestartProcess.UseVisualStyleBackColor = true;
            this.cbRestartProcess.CheckedChanged += new System.EventHandler( this.cbRestartProcess_CheckedChanged );
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point( 13, 38 );
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size( 126, 13 );
            this.label1.TabIndex = 2;
            this.label1.Text = "When the file changes...";
            // 
            // tbRestartParameters
            // 
            this.tbRestartParameters.Location = new System.Drawing.Point( 64, 109 );
            this.tbRestartParameters.Multiline = true;
            this.tbRestartParameters.Name = "tbRestartParameters";
            this.tbRestartParameters.Size = new System.Drawing.Size( 222, 64 );
            this.tbRestartParameters.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point( 61, 89 );
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size( 136, 13 );
            this.label2.TabIndex = 4;
            this.label2.Text = "Command-line parameters:";
            // 
            // cbCopyFile
            // 
            this.cbCopyFile.AutoSize = true;
            this.cbCopyFile.Location = new System.Drawing.Point( 43, 195 );
            this.cbCopyFile.Name = "cbCopyFile";
            this.cbCopyFile.Size = new System.Drawing.Size( 145, 17 );
            this.cbCopyFile.TabIndex = 6;
            this.cbCopyFile.Text = "Copy it to another folder";
            this.cbCopyFile.UseVisualStyleBackColor = true;
            this.cbCopyFile.CheckedChanged += new System.EventHandler( this.cbCopyFile_CheckedChanged );
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ( (System.Windows.Forms.AnchorStyles) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.btnSave.Location = new System.Drawing.Point( 159, 264 );
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size( 75, 23 );
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler( this.btnSave_Click );
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ( (System.Windows.Forms.AnchorStyles) ( ( System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point( 240, 264 );
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size( 75, 23 );
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // tbCopyPath
            // 
            this.tbCopyPath.Location = new System.Drawing.Point( 64, 218 );
            this.tbCopyPath.Name = "tbCopyPath";
            this.tbCopyPath.Size = new System.Drawing.Size( 180, 21 );
            this.tbCopyPath.TabIndex = 9;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point( 250, 217 );
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size( 35, 23 );
            this.btnBrowse.TabIndex = 10;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler( this.btnBrowse_Click );
            // 
            // copyFolderBrowser
            // 
            this.copyFolderBrowser.Description = "Select a folder to copy the program to.";
            // 
            // WatcherOptionsForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size( 333, 299 );
            this.Controls.Add( this.btnBrowse );
            this.Controls.Add( this.tbCopyPath );
            this.Controls.Add( this.btnCancel );
            this.Controls.Add( this.btnSave );
            this.Controls.Add( this.cbCopyFile );
            this.Controls.Add( this.label2 );
            this.Controls.Add( this.tbRestartParameters );
            this.Controls.Add( this.label1 );
            this.Controls.Add( this.cbRestartProcess );
            this.Controls.Add( this.lblWatchingFile );
            this.Font = new System.Drawing.Font( "Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte) ( 0 ) ) );
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ( (System.Drawing.Icon) ( resources.GetObject( "$this.Icon" ) ) );
            this.MaximizeBox = false;
            this.Name = "WatcherOptionsForm";
            this.Text = "Filename here";
            this.ResumeLayout( false );
            this.PerformLayout( );

        }

        #endregion

        private System.Windows.Forms.Label lblWatchingFile;
        private System.Windows.Forms.CheckBox cbRestartProcess;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbRestartParameters;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbCopyFile;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox tbCopyPath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.FolderBrowserDialog copyFolderBrowser;
    }
}