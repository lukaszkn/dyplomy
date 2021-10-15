
namespace Dyplomy
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
            this.labelTemplate = new System.Windows.Forms.Label();
            this.buttonTemplateSelection = new System.Windows.Forms.Button();
            this.labelDataSource = new System.Windows.Forms.Label();
            this.buttonDataSource = new System.Windows.Forms.Button();
            this.checkBoxUniqueNames = new System.Windows.Forms.CheckBox();
            this.buttonCreateDyplomy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTemplate
            // 
            this.labelTemplate.AutoSize = true;
            this.labelTemplate.Location = new System.Drawing.Point(190, 40);
            this.labelTemplate.Name = "labelTemplate";
            this.labelTemplate.Size = new System.Drawing.Size(101, 25);
            this.labelTemplate.TabIndex = 0;
            this.labelTemplate.Text = "Template";
            // 
            // buttonTemplateSelection
            // 
            this.buttonTemplateSelection.Location = new System.Drawing.Point(12, 23);
            this.buttonTemplateSelection.Name = "buttonTemplateSelection";
            this.buttonTemplateSelection.Size = new System.Drawing.Size(150, 58);
            this.buttonTemplateSelection.TabIndex = 1;
            this.buttonTemplateSelection.Text = "Browse";
            this.buttonTemplateSelection.UseVisualStyleBackColor = true;
            this.buttonTemplateSelection.Click += new System.EventHandler(this.buttonTemplateSelection_Click);
            // 
            // labelDataSource
            // 
            this.labelDataSource.AutoSize = true;
            this.labelDataSource.Location = new System.Drawing.Point(190, 116);
            this.labelDataSource.Name = "labelDataSource";
            this.labelDataSource.Size = new System.Drawing.Size(128, 25);
            this.labelDataSource.TabIndex = 2;
            this.labelDataSource.Text = "Data source";
            // 
            // buttonDataSource
            // 
            this.buttonDataSource.Location = new System.Drawing.Point(12, 99);
            this.buttonDataSource.Name = "buttonDataSource";
            this.buttonDataSource.Size = new System.Drawing.Size(150, 58);
            this.buttonDataSource.TabIndex = 3;
            this.buttonDataSource.Text = "Browse";
            this.buttonDataSource.UseVisualStyleBackColor = true;
            this.buttonDataSource.Click += new System.EventHandler(this.buttonDataSource_Click);
            // 
            // checkBoxUniqueNames
            // 
            this.checkBoxUniqueNames.AutoSize = true;
            this.checkBoxUniqueNames.Location = new System.Drawing.Point(12, 186);
            this.checkBoxUniqueNames.Name = "checkBoxUniqueNames";
            this.checkBoxUniqueNames.Size = new System.Drawing.Size(228, 29);
            this.checkBoxUniqueNames.TabIndex = 4;
            this.checkBoxUniqueNames.Text = "Unique names only";
            this.checkBoxUniqueNames.UseVisualStyleBackColor = true;
            // 
            // buttonCreateDyplomy
            // 
            this.buttonCreateDyplomy.Location = new System.Drawing.Point(412, 267);
            this.buttonCreateDyplomy.Name = "buttonCreateDyplomy";
            this.buttonCreateDyplomy.Size = new System.Drawing.Size(345, 102);
            this.buttonCreateDyplomy.TabIndex = 5;
            this.buttonCreateDyplomy.Text = "Create dyplomy";
            this.buttonCreateDyplomy.UseVisualStyleBackColor = true;
            this.buttonCreateDyplomy.Click += new System.EventHandler(this.buttonCreateDyplomy_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 424);
            this.Controls.Add(this.buttonCreateDyplomy);
            this.Controls.Add(this.checkBoxUniqueNames);
            this.Controls.Add(this.buttonDataSource);
            this.Controls.Add(this.labelDataSource);
            this.Controls.Add(this.buttonTemplateSelection);
            this.Controls.Add(this.labelTemplate);
            this.Name = "MainForm";
            this.Text = "Dyplomy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTemplate;
        private System.Windows.Forms.Button buttonTemplateSelection;
        private System.Windows.Forms.Label labelDataSource;
        private System.Windows.Forms.Button buttonDataSource;
        private System.Windows.Forms.CheckBox checkBoxUniqueNames;
        private System.Windows.Forms.Button buttonCreateDyplomy;
    }
}

