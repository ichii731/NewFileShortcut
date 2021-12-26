
namespace NewFileShortcut
{
    partial class setKeyInfo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.key = new System.Windows.Forms.TextBox();
            this.ctrl = new System.Windows.Forms.CheckBox();
            this.alt = new System.Windows.Forms.CheckBox();
            this.shift = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.plus = new System.Windows.Forms.Label();
            this.ext = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.content = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.active = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.key);
            this.groupBox1.Controls.Add(this.ctrl);
            this.groupBox1.Controls.Add(this.alt);
            this.groupBox1.Controls.Add(this.shift);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.plus);
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 65);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "キー割り当て";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(6, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "仮想キー番号";
            // 
            // key
            // 
            this.key.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.key.Location = new System.Drawing.Point(81, 25);
            this.key.MaxLength = 1;
            this.key.Name = "key";
            this.key.ShortcutsEnabled = false;
            this.key.Size = new System.Drawing.Size(100, 23);
            this.key.TabIndex = 8;
            this.toolTip1.SetToolTip(this.key, "「T」や「H」などのキーの直接入力には対応していません。\r\nウィンドウ右上から仮想キー番号対照表にアクセスして、対象のキー番号を数字で入力してください！");
            // 
            // ctrl
            // 
            this.ctrl.AutoSize = true;
            this.ctrl.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ctrl.Location = new System.Drawing.Point(224, 26);
            this.ctrl.Name = "ctrl";
            this.ctrl.Size = new System.Drawing.Size(51, 24);
            this.ctrl.TabIndex = 5;
            this.ctrl.Text = "Ctrl";
            this.ctrl.UseVisualStyleBackColor = true;
            // 
            // alt
            // 
            this.alt.AutoSize = true;
            this.alt.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.alt.Location = new System.Drawing.Point(407, 26);
            this.alt.Name = "alt";
            this.alt.Size = new System.Drawing.Size(47, 24);
            this.alt.TabIndex = 4;
            this.alt.Text = "Alt";
            this.alt.UseVisualStyleBackColor = true;
            // 
            // shift
            // 
            this.shift.AutoSize = true;
            this.shift.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.shift.Location = new System.Drawing.Point(312, 26);
            this.shift.Name = "shift";
            this.shift.Size = new System.Drawing.Size(58, 24);
            this.shift.TabIndex = 3;
            this.shift.Text = "Shift";
            this.shift.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(370, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "＋";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(275, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "＋";
            // 
            // plus
            // 
            this.plus.AutoSize = true;
            this.plus.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.plus.Location = new System.Drawing.Point(187, 23);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(31, 25);
            this.plus.TabIndex = 0;
            this.plus.Text = "＋";
            // 
            // ext
            // 
            this.ext.Location = new System.Drawing.Point(282, 136);
            this.ext.Name = "ext";
            this.ext.Size = new System.Drawing.Size(100, 23);
            this.ext.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(265, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = ".";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(12, 136);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(247, 23);
            this.name.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 136);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(247, 23);
            this.textBox1.TabIndex = 14;
            // 
            // content
            // 
            this.content.Location = new System.Drawing.Point(12, 182);
            this.content.Multiline = true;
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(510, 121);
            this.content.TabIndex = 10;
            this.content.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "ファイル内容";
            // 
            // active
            // 
            this.active.AutoSize = true;
            this.active.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.active.Location = new System.Drawing.Point(12, 12);
            this.active.Name = "active";
            this.active.Size = new System.Drawing.Size(74, 21);
            this.active.TabIndex = 9;
            this.active.Text = "IsActive";
            this.active.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "ファイル名";
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saveButton.Location = new System.Drawing.Point(387, 319);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(135, 25);
            this.saveButton.TabIndex = 18;
            this.saveButton.Text = "保存・適用";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(282, 116);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "拡張子";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.Location = new System.Drawing.Point(309, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(214, 17);
            this.linkLabel1.TabIndex = 20;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "入力方法・仮想キー番号対照表はこちら";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // setKeyInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(535, 356);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ext);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.name);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.content);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.active);
            this.Controls.Add(this.label1);
            this.Name = "setKeyInfo";
            this.Text = "setKeyInfo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox key;
        private System.Windows.Forms.CheckBox ctrl;
        private System.Windows.Forms.CheckBox alt;
        private System.Windows.Forms.CheckBox shift;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label plus;
        private System.Windows.Forms.TextBox ext;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox content;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox active;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}