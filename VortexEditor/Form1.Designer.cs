
namespace VortexEditor
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newText = new System.Windows.Forms.ToolStripMenuItem();
            this.openText = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveText = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quit = new System.Windows.Forms.ToolStripMenuItem();
            this.bearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoText = new System.Windows.Forms.ToolStripMenuItem();
            this.redoText = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cutText = new System.Windows.Forms.ToolStripMenuItem();
            this.copyText = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteText = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllText = new System.Windows.Forms.ToolStripMenuItem();
            this.hilfeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.githubLink = new System.Windows.Forms.ToolStripMenuItem();
            this.gitlabLink = new System.Windows.Forms.ToolStripMenuItem();
            this.youtubeLink = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.info = new System.Windows.Forms.ToolStripMenuItem();
            this.text = new System.Windows.Forms.RichTextBox();
            this.tools = new System.Windows.Forms.ToolStrip();
            this.newTextTools = new System.Windows.Forms.ToolStripButton();
            this.openTextTools = new System.Windows.Forms.ToolStripButton();
            this.saveTextTools = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cutTextTools = new System.Windows.Forms.ToolStripButton();
            this.copyTextTools = new System.Windows.Forms.ToolStripButton();
            this.pasteTextTools = new System.Windows.Forms.ToolStripButton();
            this.menu.SuspendLayout();
            this.tools.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.bearbeitenToolStripMenuItem,
            this.hilfeToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1363, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menu";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newText,
            this.openText,
            this.toolStripSeparator,
            this.saveText,
            this.toolStripSeparator1,
            this.quit});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.dateiToolStripMenuItem.Text = "&File";
            // 
            // newText
            // 
            this.newText.Image = ((System.Drawing.Image)(resources.GetObject("newText.Image")));
            this.newText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newText.Name = "newText";
            this.newText.ShortcutKeyDisplayString = "Crlt+N";
            this.newText.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newText.Size = new System.Drawing.Size(180, 22);
            this.newText.Text = "&New";
            this.newText.Click += new System.EventHandler(this.newText_Click);
            // 
            // openText
            // 
            this.openText.Image = ((System.Drawing.Image)(resources.GetObject("openText.Image")));
            this.openText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openText.Name = "openText";
            this.openText.ShortcutKeyDisplayString = "Crlt+O";
            this.openText.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openText.Size = new System.Drawing.Size(180, 22);
            this.openText.Text = "&Open";
            this.openText.Click += new System.EventHandler(this.openText_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(177, 6);
            // 
            // saveText
            // 
            this.saveText.Image = ((System.Drawing.Image)(resources.GetObject("saveText.Image")));
            this.saveText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveText.Name = "saveText";
            this.saveText.ShortcutKeyDisplayString = "Crlt+S";
            this.saveText.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveText.Size = new System.Drawing.Size(180, 22);
            this.saveText.Text = "&Save";
            this.saveText.Click += new System.EventHandler(this.saveText_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // quit
            // 
            this.quit.Name = "quit";
            this.quit.ShortcutKeyDisplayString = "Alt+F4";
            this.quit.Size = new System.Drawing.Size(180, 22);
            this.quit.Text = "&Quit";
            this.quit.Click += new System.EventHandler(this.quit_Click);
            // 
            // bearbeitenToolStripMenuItem
            // 
            this.bearbeitenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoText,
            this.redoText,
            this.toolStripSeparator3,
            this.cutText,
            this.copyText,
            this.pasteText,
            this.toolStripSeparator4,
            this.selectAllText});
            this.bearbeitenToolStripMenuItem.Name = "bearbeitenToolStripMenuItem";
            this.bearbeitenToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.bearbeitenToolStripMenuItem.Text = "&Edit";
            // 
            // undoText
            // 
            this.undoText.Name = "undoText";
            this.undoText.ShortcutKeyDisplayString = "Crlt+Z";
            this.undoText.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoText.Size = new System.Drawing.Size(180, 22);
            this.undoText.Text = "&Undo";
            this.undoText.Click += new System.EventHandler(this.undoText_Click);
            // 
            // redoText
            // 
            this.redoText.Name = "redoText";
            this.redoText.ShortcutKeyDisplayString = "Crlt+Y";
            this.redoText.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoText.Size = new System.Drawing.Size(180, 22);
            this.redoText.Text = "&Redo";
            this.redoText.Click += new System.EventHandler(this.redoText_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // cutText
            // 
            this.cutText.Image = ((System.Drawing.Image)(resources.GetObject("cutText.Image")));
            this.cutText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutText.Name = "cutText";
            this.cutText.ShortcutKeyDisplayString = "Crlt+X";
            this.cutText.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutText.Size = new System.Drawing.Size(180, 22);
            this.cutText.Text = "&Cut";
            this.cutText.Click += new System.EventHandler(this.cutText_Click);
            // 
            // copyText
            // 
            this.copyText.Image = ((System.Drawing.Image)(resources.GetObject("copyText.Image")));
            this.copyText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyText.Name = "copyText";
            this.copyText.ShortcutKeyDisplayString = "Crlt+C";
            this.copyText.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyText.Size = new System.Drawing.Size(180, 22);
            this.copyText.Text = "&Copy";
            this.copyText.Click += new System.EventHandler(this.copyText_Click);
            // 
            // pasteText
            // 
            this.pasteText.Image = ((System.Drawing.Image)(resources.GetObject("pasteText.Image")));
            this.pasteText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteText.Name = "pasteText";
            this.pasteText.ShortcutKeyDisplayString = "Crlt+V";
            this.pasteText.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteText.Size = new System.Drawing.Size(180, 22);
            this.pasteText.Text = "&Paste";
            this.pasteText.Click += new System.EventHandler(this.pasteText_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
            // 
            // selectAllText
            // 
            this.selectAllText.Name = "selectAllText";
            this.selectAllText.ShortcutKeyDisplayString = "Crlt+A";
            this.selectAllText.Size = new System.Drawing.Size(180, 22);
            this.selectAllText.Text = "&Select all";
            this.selectAllText.Click += new System.EventHandler(this.selectAllText_Click);
            // 
            // hilfeToolStripMenuItem
            // 
            this.hilfeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.githubLink,
            this.gitlabLink,
            this.youtubeLink,
            this.toolStripSeparator5,
            this.info});
            this.hilfeToolStripMenuItem.Name = "hilfeToolStripMenuItem";
            this.hilfeToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.hilfeToolStripMenuItem.Text = "&Help";
            // 
            // githubLink
            // 
            this.githubLink.Name = "githubLink";
            this.githubLink.Size = new System.Drawing.Size(180, 22);
            this.githubLink.Text = "&Github";
            this.githubLink.Click += new System.EventHandler(this.githubLink_Click);
            // 
            // gitlabLink
            // 
            this.gitlabLink.Name = "gitlabLink";
            this.gitlabLink.Size = new System.Drawing.Size(180, 22);
            this.gitlabLink.Text = "Git&lab";
            this.gitlabLink.Click += new System.EventHandler(this.gitlabLink_Click);
            // 
            // youtubeLink
            // 
            this.youtubeLink.Name = "youtubeLink";
            this.youtubeLink.Size = new System.Drawing.Size(180, 22);
            this.youtubeLink.Text = "&Youtube";
            this.youtubeLink.Click += new System.EventHandler(this.youtubeLink_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(177, 6);
            // 
            // info
            // 
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(180, 22);
            this.info.Text = "Inf&o...";
            this.info.Click += new System.EventHandler(this.info_Click);
            // 
            // text
            // 
            this.text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text.Location = new System.Drawing.Point(0, 52);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(1363, 582);
            this.text.TabIndex = 1;
            this.text.TabStop = false;
            this.text.Text = "";
            // 
            // tools
            // 
            this.tools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTextTools,
            this.openTextTools,
            this.saveTextTools,
            this.toolStripSeparator2,
            this.cutTextTools,
            this.copyTextTools,
            this.pasteTextTools});
            this.tools.Location = new System.Drawing.Point(0, 24);
            this.tools.Name = "tools";
            this.tools.Size = new System.Drawing.Size(1363, 25);
            this.tools.TabIndex = 2;
            this.tools.Text = "tools";
            // 
            // newTextTools
            // 
            this.newTextTools.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newTextTools.Image = ((System.Drawing.Image)(resources.GetObject("newTextTools.Image")));
            this.newTextTools.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newTextTools.Name = "newTextTools";
            this.newTextTools.Size = new System.Drawing.Size(23, 22);
            this.newTextTools.Text = "&New";
            this.newTextTools.Click += new System.EventHandler(this.newTextTools_Click);
            // 
            // openTextTools
            // 
            this.openTextTools.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openTextTools.Image = ((System.Drawing.Image)(resources.GetObject("openTextTools.Image")));
            this.openTextTools.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openTextTools.Name = "openTextTools";
            this.openTextTools.Size = new System.Drawing.Size(23, 22);
            this.openTextTools.Text = "&Open";
            this.openTextTools.Click += new System.EventHandler(this.openTextTools_Click);
            // 
            // saveTextTools
            // 
            this.saveTextTools.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveTextTools.Image = ((System.Drawing.Image)(resources.GetObject("saveTextTools.Image")));
            this.saveTextTools.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveTextTools.Name = "saveTextTools";
            this.saveTextTools.Size = new System.Drawing.Size(23, 22);
            this.saveTextTools.Text = "&Save";
            this.saveTextTools.Click += new System.EventHandler(this.saveTextTools_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // cutTextTools
            // 
            this.cutTextTools.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutTextTools.Image = ((System.Drawing.Image)(resources.GetObject("cutTextTools.Image")));
            this.cutTextTools.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutTextTools.Name = "cutTextTools";
            this.cutTextTools.Size = new System.Drawing.Size(23, 22);
            this.cutTextTools.Text = "C&ut";
            this.cutTextTools.Click += new System.EventHandler(this.cutTextTools_Click);
            // 
            // copyTextTools
            // 
            this.copyTextTools.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyTextTools.Image = ((System.Drawing.Image)(resources.GetObject("copyTextTools.Image")));
            this.copyTextTools.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyTextTools.Name = "copyTextTools";
            this.copyTextTools.Size = new System.Drawing.Size(23, 22);
            this.copyTextTools.Text = "&Copy";
            this.copyTextTools.Click += new System.EventHandler(this.copyTextTools_Click);
            // 
            // pasteTextTools
            // 
            this.pasteTextTools.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteTextTools.Image = ((System.Drawing.Image)(resources.GetObject("pasteTextTools.Image")));
            this.pasteTextTools.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteTextTools.Name = "pasteTextTools";
            this.pasteTextTools.Size = new System.Drawing.Size(23, 22);
            this.pasteTextTools.Text = "&Paste";
            this.pasteTextTools.Click += new System.EventHandler(this.pasteTextTools_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 634);
            this.Controls.Add(this.tools);
            this.Controls.Add(this.text);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Name = "Form1";
            this.Text = "...";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.tools.ResumeLayout(false);
            this.tools.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newText;
        private System.Windows.Forms.ToolStripMenuItem openText;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveText;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem quit;
        private System.Windows.Forms.ToolStripMenuItem bearbeitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoText;
        private System.Windows.Forms.ToolStripMenuItem redoText;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutText;
        private System.Windows.Forms.ToolStripMenuItem copyText;
        private System.Windows.Forms.ToolStripMenuItem pasteText;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllText;
        private System.Windows.Forms.ToolStripMenuItem hilfeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem youtubeLink;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem info;
        private System.Windows.Forms.RichTextBox text;
        private System.Windows.Forms.ToolStripMenuItem githubLink;
        private System.Windows.Forms.ToolStripMenuItem gitlabLink;
        private System.Windows.Forms.ToolStrip tools;
        private System.Windows.Forms.ToolStripButton newTextTools;
        private System.Windows.Forms.ToolStripButton openTextTools;
        private System.Windows.Forms.ToolStripButton saveTextTools;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton cutTextTools;
        private System.Windows.Forms.ToolStripButton copyTextTools;
        private System.Windows.Forms.ToolStripButton pasteTextTools;
    }
}

