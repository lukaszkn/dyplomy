
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
            this.checkBoxAddPanPani = new System.Windows.Forms.CheckBox();
            this.checkBoxRemoveNonLetters = new System.Windows.Forms.CheckBox();
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
            this.labelDataSource.Size = new System.Drawing.Size(305, 25);
            this.labelDataSource.TabIndex = 2;
            this.labelDataSource.Text = "Data source [nazwa], [miejsce]";
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
            this.buttonCreateDyplomy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCreateDyplomy.Location = new System.Drawing.Point(412, 378);
            this.buttonCreateDyplomy.Name = "buttonCreateDyplomy";
            this.buttonCreateDyplomy.Size = new System.Drawing.Size(345, 102);
            this.buttonCreateDyplomy.TabIndex = 5;
            this.buttonCreateDyplomy.Text = "Create dyplomy";
            this.buttonCreateDyplomy.UseVisualStyleBackColor = true;
            this.buttonCreateDyplomy.Click += new System.EventHandler(this.buttonCreateDyplomy_Click);
            // 
            // checkBoxAddPanPani
            // 
            this.checkBoxAddPanPani.AutoSize = true;
            this.checkBoxAddPanPani.Location = new System.Drawing.Point(12, 230);
            this.checkBoxAddPanPani.Name = "checkBoxAddPanPani";
            this.checkBoxAddPanPani.Size = new System.Drawing.Size(330, 29);
            this.checkBoxAddPanPani.TabIndex = 6;
            this.checkBoxAddPanPani.Text = "Add pan / pani before [nazwa]";
            this.checkBoxAddPanPani.UseVisualStyleBackColor = true;
            // 
            // checkBoxRemoveNonLetters
            // 
            this.checkBoxRemoveNonLetters.AutoSize = true;
            this.checkBoxRemoveNonLetters.Location = new System.Drawing.Point(12, 276);
            this.checkBoxRemoveNonLetters.Name = "checkBoxRemoveNonLetters";
            this.checkBoxRemoveNonLetters.Size = new System.Drawing.Size(358, 29);
            this.checkBoxRemoveNonLetters.TabIndex = 7;
            this.checkBoxRemoveNonLetters.Text = "Remove non letters from [nazwa]";
            this.checkBoxRemoveNonLetters.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 492);
            this.Controls.Add(this.checkBoxRemoveNonLetters);
            this.Controls.Add(this.checkBoxAddPanPani);
            this.Controls.Add(this.buttonCreateDyplomy);
            this.Controls.Add(this.checkBoxUniqueNames);
            this.Controls.Add(this.buttonDataSource);
            this.Controls.Add(this.labelDataSource);
            this.Controls.Add(this.buttonTemplateSelection);
            this.Controls.Add(this.labelTemplate);
            this.Name = "MainForm";
            this.Text = "Dyplomy 0.2";
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
        private System.Windows.Forms.CheckBox checkBoxAddPanPani;
        private System.Windows.Forms.CheckBox checkBoxRemoveNonLetters;
    }
}

