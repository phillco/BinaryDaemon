namespace BinaryDaemon.UI
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container( );
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( MainForm ) );
            this.listContextMenu = new System.Windows.Forms.ContextMenuStrip( this.components );
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator( );
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
            this.btnNewWatcher = new System.Windows.Forms.Button( );
            this.label1 = new System.Windows.Forms.Label( );
            this.watchFileDialog = new System.Windows.Forms.OpenFileDialog( );
            this.refreshTimer = new System.Windows.Forms.Timer( this.components );
            this.panel1 = new System.Windows.Forms.Panel( );
            this.lvWatchers = new System.Windows.Forms.ListView( );
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader( );
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader( );
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader( );
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader( );
            this.panel2 = new System.Windows.Forms.Panel( );
            this.listContextMenu.SuspendLayout( );
            this.panel1.SuspendLayout( );
            this.panel2.SuspendLayout( );
            this.SuspendLayout( );
            // 
            // listContextMenu
            // 
            this.listContextMenu.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.restartToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.toolStripSeparator1,
            this.editToolStripMenuItem} );
            this.listContextMenu.Name = "listContextMenu";
            this.listContextMenu.Size = new System.Drawing.Size( 181, 76 );
            this.listContextMenu.Opening += new System.ComponentModel.CancelEventHandler( this.listContextMenu_Opening );
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Font = new System.Drawing.Font( "Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte) ( 0 ) ) );
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size( 180, 22 );
            this.restartToolStripMenuItem.Text = "Restart program";
            this.restartToolStripMenuItem.Click += new System.EventHandler( this.restartToolStripMenuItem_Click );
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size( 180, 22 );
            this.stopToolStripMenuItem.Text = "Stop program";
            this.stopToolStripMenuItem.Click += new System.EventHandler( this.stopToolStripMenuItem_Click );
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size( 177, 6 );
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size( 180, 22 );
            this.editToolStripMenuItem.Text = "Edit...";
            this.editToolStripMenuItem.Click += new System.EventHandler( this.editToolStripMenuItem_Click );
            // 
            // btnNewWatcher
            // 
            this.btnNewWatcher.Anchor = ( (System.Windows.Forms.AnchorStyles) ( ( System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right ) ) );
            this.btnNewWatcher.Location = new System.Drawing.Point( 396, 10 );
            this.btnNewWatcher.Name = "btnNewWatcher";
            this.btnNewWatcher.Size = new System.Drawing.Size( 98, 25 );
            this.btnNewWatcher.TabIndex = 1;
            this.btnNewWatcher.Text = "Watch File...";
            this.btnNewWatcher.UseVisualStyleBackColor = true;
            this.btnNewWatcher.Click += new System.EventHandler( this.btnNewWatcher_Click );
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font( "Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ( (byte) ( 0 ) ) );
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point( 13, 15 );
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding( 0, 1, 0, 0 );
            this.label1.Size = new System.Drawing.Size( 185, 17 );
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome to BinaryDaemon.";
            // 
            // watchFileDialog
            // 
            this.watchFileDialog.Filter = "EXE files|*.exe|All files|*.*";
            this.watchFileDialog.Title = "Choose an EXE to watch...";
            // 
            // refreshTimer
            // 
            this.refreshTimer.Enabled = true;
            this.refreshTimer.Interval = 1000;
            this.refreshTimer.Tick += new System.EventHandler( this.refreshTimer_Tick );
            // 
            // panel1
            // 
            this.panel1.Controls.Add( this.lvWatchers );
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point( 0, 0 );
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding( 16, 41, 16, 16 );
            this.panel1.Size = new System.Drawing.Size( 509, 155 );
            this.panel1.TabIndex = 3;
            // 
            // lvWatchers
            // 
            this.lvWatchers.Columns.AddRange( new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader4,
            this.columnHeader3,
            this.columnHeader2} );
            this.lvWatchers.ContextMenuStrip = this.listContextMenu;
            this.lvWatchers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvWatchers.FullRowSelect = true;
            this.lvWatchers.Location = new System.Drawing.Point( 16, 41 );
            this.lvWatchers.Name = "lvWatchers";
            this.lvWatchers.Size = new System.Drawing.Size( 477, 98 );
            this.lvWatchers.TabIndex = 1;
            this.lvWatchers.UseCompatibleStateImageBehavior = false;
            this.lvWatchers.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "File";
            this.columnHeader1.Width = 163;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Status";
            this.columnHeader4.Width = 74;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "On Change";
            this.columnHeader3.Width = 125;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Last Changed";
            this.columnHeader2.Width = 89;
            // 
            // panel2
            // 
            this.panel2.Controls.Add( this.btnNewWatcher );
            this.panel2.Controls.Add( this.label1 );
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point( 0, 0 );
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size( 509, 35 );
            this.panel2.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 509, 155 );
            this.Controls.Add( this.panel2 );
            this.Controls.Add( this.panel1 );
            this.Font = new System.Drawing.Font( "Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte) ( 0 ) ) );
            this.Icon = ( (System.Drawing.Icon) ( resources.GetObject( "$this.Icon" ) ) );
            this.Name = "MainForm";
            this.Text = "BinaryDeamon";
            this.listContextMenu.ResumeLayout( false );
            this.panel1.ResumeLayout( false );
            this.panel2.ResumeLayout( false );
            this.panel2.PerformLayout( );
            this.ResumeLayout( false );

        }

        #endregion

        private System.Windows.Forms.Button btnNewWatcher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog watchFileDialog;
        private System.Windows.Forms.ContextMenuStrip listContextMenu;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.Timer refreshTimer;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lvWatchers;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Panel panel2;
    }
}

