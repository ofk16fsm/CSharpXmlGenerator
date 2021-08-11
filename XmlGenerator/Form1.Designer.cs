
namespace XmlGenerator
{
    partial class Form1
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
            this.lblId = new System.Windows.Forms.Label();
            this.txtBoxId = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtBoxPrice = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.txtBoxType = new System.Windows.Forms.TextBox();
            this.lblFilename = new System.Windows.Forms.Label();
            this.txtBoxFilename = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRemoveChild = new System.Windows.Forms.Button();
            this.btnReadXml = new System.Windows.Forms.Button();
            this.richTextBoxXml = new System.Windows.Forms.RichTextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblPlaytime = new System.Windows.Forms.Label();
            this.txtBoxPlaytime = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnValidate = new System.Windows.Forms.Button();
            this.btnRemoveSubchild = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(9, 129);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(16, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id";
            // 
            // txtBoxId
            // 
            this.txtBoxId.Location = new System.Drawing.Point(31, 126);
            this.txtBoxId.Name = "txtBoxId";
            this.txtBoxId.Size = new System.Drawing.Size(100, 20);
            this.txtBoxId.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(137, 129);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(178, 126);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(100, 20);
            this.txtBoxName.TabIndex = 3;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(284, 129);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "Price";
            // 
            // txtBoxPrice
            // 
            this.txtBoxPrice.Location = new System.Drawing.Point(321, 126);
            this.txtBoxPrice.Name = "txtBoxPrice";
            this.txtBoxPrice.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPrice.TabIndex = 5;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(427, 129);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 6;
            this.lblType.Text = "Type";
            // 
            // txtBoxType
            // 
            this.txtBoxType.Location = new System.Drawing.Point(464, 126);
            this.txtBoxType.Name = "txtBoxType";
            this.txtBoxType.Size = new System.Drawing.Size(100, 20);
            this.txtBoxType.TabIndex = 7;
            // 
            // lblFilename
            // 
            this.lblFilename.AutoSize = true;
            this.lblFilename.Location = new System.Drawing.Point(9, 95);
            this.lblFilename.Name = "lblFilename";
            this.lblFilename.Size = new System.Drawing.Size(49, 13);
            this.lblFilename.TabIndex = 8;
            this.lblFilename.Text = "Filename";
            // 
            // txtBoxFilename
            // 
            this.txtBoxFilename.Location = new System.Drawing.Point(64, 92);
            this.txtBoxFilename.Name = "txtBoxFilename";
            this.txtBoxFilename.Size = new System.Drawing.Size(100, 20);
            this.txtBoxFilename.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(427, 166);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(99, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRemoveChild
            // 
            this.btnRemoveChild.Location = new System.Drawing.Point(187, 167);
            this.btnRemoveChild.Name = "btnRemoveChild";
            this.btnRemoveChild.Size = new System.Drawing.Size(107, 23);
            this.btnRemoveChild.TabIndex = 11;
            this.btnRemoveChild.Text = "Remove first child";
            this.btnRemoveChild.UseVisualStyleBackColor = true;
            this.btnRemoveChild.Click += new System.EventHandler(this.btnRemoveChild_Click);
            // 
            // btnReadXml
            // 
            this.btnReadXml.Location = new System.Drawing.Point(532, 167);
            this.btnReadXml.Name = "btnReadXml";
            this.btnReadXml.Size = new System.Drawing.Size(75, 23);
            this.btnReadXml.TabIndex = 12;
            this.btnReadXml.Text = "Read XML";
            this.btnReadXml.UseVisualStyleBackColor = true;
            this.btnReadXml.Click += new System.EventHandler(this.btnReadXml_Click);
            // 
            // richTextBoxXml
            // 
            this.richTextBoxXml.AcceptsTab = true;
            this.richTextBoxXml.Location = new System.Drawing.Point(12, 196);
            this.richTextBoxXml.Name = "richTextBoxXml";
            this.richTextBoxXml.ReadOnly = true;
            this.richTextBoxXml.Size = new System.Drawing.Size(711, 227);
            this.richTextBoxXml.TabIndex = 13;
            this.richTextBoxXml.Text = "";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 166);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 23);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add to XML list";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(106, 166);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 15;
            this.btnCreate.Text = "Create XML";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblPlaytime
            // 
            this.lblPlaytime.AutoSize = true;
            this.lblPlaytime.Location = new System.Drawing.Point(571, 128);
            this.lblPlaytime.Name = "lblPlaytime";
            this.lblPlaytime.Size = new System.Drawing.Size(46, 13);
            this.lblPlaytime.TabIndex = 16;
            this.lblPlaytime.Text = "Playtime";
            // 
            // txtBoxPlaytime
            // 
            this.txtBoxPlaytime.Location = new System.Drawing.Point(623, 126);
            this.txtBoxPlaytime.Name = "txtBoxPlaytime";
            this.txtBoxPlaytime.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPlaytime.TabIndex = 17;
            // 
            // lblInfo
            // 
            this.lblInfo.Location = new System.Drawing.Point(12, 13);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(711, 76);
            this.lblInfo.TabIndex = 18;
            this.lblInfo.Text = "Info";
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(613, 167);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(75, 23);
            this.btnValidate.TabIndex = 19;
            this.btnValidate.Text = "Validate";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // btnRemoveSubchild
            // 
            this.btnRemoveSubchild.Location = new System.Drawing.Point(300, 167);
            this.btnRemoveSubchild.Name = "btnRemoveSubchild";
            this.btnRemoveSubchild.Size = new System.Drawing.Size(121, 23);
            this.btnRemoveSubchild.TabIndex = 20;
            this.btnRemoveSubchild.Text = "Remove first subchild";
            this.btnRemoveSubchild.UseVisualStyleBackColor = true;
            this.btnRemoveSubchild.Click += new System.EventHandler(this.btnRemoveSubchild_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 435);
            this.Controls.Add(this.btnRemoveSubchild);
            this.Controls.Add(this.richTextBoxXml);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.txtBoxPlaytime);
            this.Controls.Add(this.lblPlaytime);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnReadXml);
            this.Controls.Add(this.btnRemoveChild);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtBoxFilename);
            this.Controls.Add(this.lblFilename);
            this.Controls.Add(this.txtBoxType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.txtBoxPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtBoxId);
            this.Controls.Add(this.lblId);
            this.Name = "Form1";
            this.Text = "XML Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtBoxId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtBoxPrice;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtBoxType;
        private System.Windows.Forms.Label lblFilename;
        private System.Windows.Forms.TextBox txtBoxFilename;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRemoveChild;
        private System.Windows.Forms.Button btnReadXml;
        private System.Windows.Forms.RichTextBox richTextBoxXml;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblPlaytime;
        private System.Windows.Forms.TextBox txtBoxPlaytime;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Button btnRemoveSubchild;
    }
}

