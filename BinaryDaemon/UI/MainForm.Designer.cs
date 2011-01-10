﻿namespace BinaryDaemon.UI
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
            this.lvWatchers = new System.Windows.Forms.ListView( );
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader( );
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader( );
            this.listContextMenu = new System.Windows.Forms.ContextMenuStrip( this.components );
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem( );
            this.btnNewWatcher = new System.Windows.Forms.Button( );
            this.label1 = new System.Windows.Forms.Label( );
            this.watchFileDialog = new System.Windows.Forms.OpenFileDialog( );
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader( );
            this.listContextMenu.SuspendLayout( );
            this.SuspendLayout( );
            // 
            // lvWatchers
            // 
            this.lvWatchers.Columns.AddRange( new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader2} );
            this.lvWatchers.ContextMenuStrip = this.listContextMenu;
            this.lvWatchers.FullRowSelect = true;
            this.lvWatchers.Location = new System.Drawing.Point( 22, 46 );
            this.lvWatchers.Name = "lvWatchers";
            this.lvWatchers.Size = new System.Drawing.Size( 419, 97 );
            this.lvWatchers.TabIndex = 0;
            this.lvWatchers.UseCompatibleStateImageBehavior = false;
            this.lvWatchers.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "File";
            this.columnHeader1.Width = 163;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Last Changed";
            this.columnHeader2.Width = 89;
            // 
            // listContextMenu
            // 
            this.listContextMenu.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem} );
            this.listContextMenu.Name = "listContextMenu";
            this.listContextMenu.Size = new System.Drawing.Size( 116, 26 );
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size( 115, 22 );
            this.editToolStripMenuItem.Text = "Edit...";
            this.editToolStripMenuItem.Click += new System.EventHandler( this.editToolStripMenuItem_Click );
            // 
            // btnNewWatcher
            // 
            this.btnNewWatcher.Location = new System.Drawing.Point( 343, 12 );
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
            this.label1.Location = new System.Drawing.Point( 19, 17 );
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size( 185, 16 );
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome to BinaryDaemon.";
            // 
            // watchFileDialog
            // 
            this.watchFileDialog.Filter = "EXE files|*.exe|All files|*.*";
            this.watchFileDialog.Title = "Choose an EXE to watch...";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "On Change";
            this.columnHeader3.Width = 153;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 453, 157 );
            this.Controls.Add( this.label1 );
            this.Controls.Add( this.btnNewWatcher );
            this.Controls.Add( this.lvWatchers );
            this.Font = new System.Drawing.Font( "Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ( (byte) ( 0 ) ) );
            this.Icon = ( (System.Drawing.Icon) ( resources.GetObject( "$this.Icon" ) ) );
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "BinaryDeamon";
            this.listContextMenu.ResumeLayout( false );
            this.ResumeLayout( false );
            this.PerformLayout( );

        }

        #endregion

        private System.Windows.Forms.ListView lvWatchers;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btnNewWatcher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog watchFileDialog;
        private System.Windows.Forms.ContextMenuStrip listContextMenu;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

