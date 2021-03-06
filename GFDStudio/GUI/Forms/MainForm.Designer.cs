﻿using GFDStudio.GUI.DataViewNodes;

namespace GFDStudio.GUI.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mMainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.mFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mOpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mPropertyGrid = new System.Windows.Forms.PropertyGrid();
            this.mContentPanel = new System.Windows.Forms.Panel();
            this.mDataTreeView = new GFDStudio.GUI.DataViewNodes.DataTreeView();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeRelativeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mMainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mMainMenuStrip
            // 
            this.mMainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mFileToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.mMainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mMainMenuStrip.Name = "mMainMenuStrip";
            this.mMainMenuStrip.Size = new System.Drawing.Size(1222, 24);
            this.mMainMenuStrip.TabIndex = 0;
            this.mMainMenuStrip.Text = "menuStrip1";
            // 
            // mFileToolStripMenuItem
            // 
            this.mFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.mOpenToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.mFileToolStripMenuItem.Name = "mFileToolStripMenuItem";
            this.mFileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.mFileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modelToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // modelToolStripMenuItem
            // 
            this.modelToolStripMenuItem.Name = "modelToolStripMenuItem";
            this.modelToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.modelToolStripMenuItem.Text = "Model";
            this.modelToolStripMenuItem.Click += new System.EventHandler(this.HandleNewModelToolStripMenuItemClick);
            // 
            // mOpenToolStripMenuItem
            // 
            this.mOpenToolStripMenuItem.Name = "mOpenToolStripMenuItem";
            this.mOpenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mOpenToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.mOpenToolStripMenuItem.Text = "Open";
            this.mOpenToolStripMenuItem.Click += new System.EventHandler(this.HandleOpenToolStripMenuItemClick);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.HandleSaveToolStripMenuItemClick);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.saveAsToolStripMenuItem.Text = "Save as...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.HandleSaveAsToolStripMenuItemClick);
            // 
            // mPropertyGrid
            // 
            this.mPropertyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mPropertyGrid.LineColor = System.Drawing.SystemColors.ControlDark;
            this.mPropertyGrid.Location = new System.Drawing.Point(713, 413);
            this.mPropertyGrid.Name = "mPropertyGrid";
            this.mPropertyGrid.Size = new System.Drawing.Size(497, 414);
            this.mPropertyGrid.TabIndex = 2;
            this.mPropertyGrid.PropertySort = System.Windows.Forms.PropertySort.NoSort;
            // 
            // mContentPanel
            // 
            this.mContentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mContentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mContentPanel.Location = new System.Drawing.Point(12, 28);
            this.mContentPanel.Name = "mContentPanel";
            this.mContentPanel.Size = new System.Drawing.Size(695, 800);
            this.mContentPanel.TabIndex = 3;
            // 
            // mDataTreeView
            // 
            this.mDataTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mDataTreeView.Location = new System.Drawing.Point(713, 27);
            this.mDataTreeView.Name = "mDataTreeView";
            this.mDataTreeView.Size = new System.Drawing.Size(497, 380);
            this.mDataTreeView.TabIndex = 1;
            this.mDataTreeView.TopNode = null;
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makeRelativeToolStripMenuItem} );
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // makeRelativeToolStripMenuItem
            // 
            this.makeRelativeToolStripMenuItem.Name = "makeRelativeToolStripMenuItem";
            this.makeRelativeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.makeRelativeToolStripMenuItem.Text = "Make animation packs relative";
            this.makeRelativeToolStripMenuItem.Click += new System.EventHandler(this.HandleMakeAnimationsRelativeToolStripMenuItemClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 839);
            this.Controls.Add(this.mPropertyGrid);
            this.Controls.Add(this.mDataTreeView);
            this.Controls.Add(this.mMainMenuStrip);
            this.Controls.Add(this.mContentPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mMainMenuStrip;
            this.Name = "MainForm";
            this.Text = "GFD Studio";
            this.mMainMenuStrip.ResumeLayout(false);
            this.mMainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mMainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem mFileToolStripMenuItem;
        private System.Windows.Forms.PropertyGrid mPropertyGrid;
        private System.Windows.Forms.ToolStripMenuItem mOpenToolStripMenuItem;
        private System.Windows.Forms.Panel mContentPanel;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modelToolStripMenuItem;
        private DataTreeView mDataTreeView;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeRelativeToolStripMenuItem;
    }
}