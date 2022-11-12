
namespace Weighted_Chance_App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inventory = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.diamondNum = new System.Windows.Forms.NumericUpDown();
            this.featherNum = new System.Windows.Forms.NumericUpDown();
            this.goldNum = new System.Windows.Forms.NumericUpDown();
            this.leatherNum = new System.Windows.Forms.NumericUpDown();
            this.fleshNum = new System.Windows.Forms.NumericUpDown();
            this.stringNum = new System.Windows.Forms.NumericUpDown();
            this.wheatNum = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.itemSpawnChance = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.itemiUSesiru = new System.Windows.Forms.Label();
            this.diamondPercentage = new System.Windows.Forms.Label();
            this.featherPercentage = new System.Windows.Forms.Label();
            this.goldPercentage = new System.Windows.Forms.Label();
            this.leatherPercentage = new System.Windows.Forms.Label();
            this.fleshPercentage = new System.Windows.Forms.Label();
            this.stringPercentage = new System.Windows.Forms.Label();
            this.wheatPercentage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.diamondNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.featherNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goldNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leatherNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fleshNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stringNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wheatNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemSpawnChance)).BeginInit();
            this.SuspendLayout();
            // 
            // inventory
            // 
            this.inventory.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.inventory.ColumnCount = 9;
            this.inventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.inventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.inventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.inventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.inventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.inventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.inventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.inventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.inventory.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.inventory.Location = new System.Drawing.Point(12, 12);
            this.inventory.Name = "inventory";
            this.inventory.RowCount = 3;
            this.inventory.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.inventory.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.inventory.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.inventory.Size = new System.Drawing.Size(200, 100);
            this.inventory.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(623, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Generiraj chest";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Koliko itema staviti u šešir";
            // 
            // diamondNum
            // 
            this.diamondNum.Location = new System.Drawing.Point(12, 320);
            this.diamondNum.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.diamondNum.Name = "diamondNum";
            this.diamondNum.Size = new System.Drawing.Size(74, 23);
            this.diamondNum.TabIndex = 3;
            this.diamondNum.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.diamondNum.ValueChanged += new System.EventHandler(this.numValueChanged);
            // 
            // featherNum
            // 
            this.featherNum.Location = new System.Drawing.Point(92, 320);
            this.featherNum.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.featherNum.Name = "featherNum";
            this.featherNum.Size = new System.Drawing.Size(74, 23);
            this.featherNum.TabIndex = 4;
            this.featherNum.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.featherNum.ValueChanged += new System.EventHandler(this.numValueChanged);
            // 
            // goldNum
            // 
            this.goldNum.Location = new System.Drawing.Point(172, 320);
            this.goldNum.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.goldNum.Name = "goldNum";
            this.goldNum.Size = new System.Drawing.Size(74, 23);
            this.goldNum.TabIndex = 5;
            this.goldNum.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.goldNum.ValueChanged += new System.EventHandler(this.numValueChanged);
            // 
            // leatherNum
            // 
            this.leatherNum.Location = new System.Drawing.Point(252, 320);
            this.leatherNum.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.leatherNum.Name = "leatherNum";
            this.leatherNum.Size = new System.Drawing.Size(74, 23);
            this.leatherNum.TabIndex = 6;
            this.leatherNum.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.leatherNum.ValueChanged += new System.EventHandler(this.numValueChanged);
            // 
            // fleshNum
            // 
            this.fleshNum.Location = new System.Drawing.Point(332, 321);
            this.fleshNum.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.fleshNum.Name = "fleshNum";
            this.fleshNum.Size = new System.Drawing.Size(74, 23);
            this.fleshNum.TabIndex = 7;
            this.fleshNum.Value = new decimal(new int[] {
            240,
            0,
            0,
            0});
            this.fleshNum.ValueChanged += new System.EventHandler(this.numValueChanged);
            // 
            // stringNum
            // 
            this.stringNum.Location = new System.Drawing.Point(412, 320);
            this.stringNum.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.stringNum.Name = "stringNum";
            this.stringNum.Size = new System.Drawing.Size(74, 23);
            this.stringNum.TabIndex = 8;
            this.stringNum.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.stringNum.ValueChanged += new System.EventHandler(this.numValueChanged);
            // 
            // wheatNum
            // 
            this.wheatNum.Location = new System.Drawing.Point(492, 320);
            this.wheatNum.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.wheatNum.Name = "wheatNum";
            this.wheatNum.Size = new System.Drawing.Size(74, 23);
            this.wheatNum.TabIndex = 9;
            this.wheatNum.Value = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.wheatNum.ValueChanged += new System.EventHandler(this.numValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "diamond";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "feather";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(172, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "gold";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(252, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "leather";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(332, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "flesh";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(412, 350);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "string";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(492, 350);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "wheat";
            // 
            // itemSpawnChance
            // 
            this.itemSpawnChance.Location = new System.Drawing.Point(623, 320);
            this.itemSpawnChance.Name = "itemSpawnChance";
            this.itemSpawnChance.Size = new System.Drawing.Size(125, 23);
            this.itemSpawnChance.TabIndex = 17;
            this.itemSpawnChance.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(623, 350);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "šansa da se stvori item";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(623, 414);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "Resetiraj chest";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(252, 302);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 15);
            this.label10.TabIndex = 20;
            this.label10.Text = "Itema u šeširu:";
            // 
            // itemiUSesiru
            // 
            this.itemiUSesiru.AutoSize = true;
            this.itemiUSesiru.Location = new System.Drawing.Point(332, 303);
            this.itemiUSesiru.Name = "itemiUSesiru";
            this.itemiUSesiru.Size = new System.Drawing.Size(44, 15);
            this.itemiUSesiru.TabIndex = 21;
            this.itemiUSesiru.Text = "label11";
            // 
            // diamondPercentage
            // 
            this.diamondPercentage.AutoSize = true;
            this.diamondPercentage.Location = new System.Drawing.Point(13, 385);
            this.diamondPercentage.Name = "diamondPercentage";
            this.diamondPercentage.Size = new System.Drawing.Size(44, 15);
            this.diamondPercentage.TabIndex = 22;
            this.diamondPercentage.Text = "label11";
            // 
            // featherPercentage
            // 
            this.featherPercentage.AutoSize = true;
            this.featherPercentage.Location = new System.Drawing.Point(92, 385);
            this.featherPercentage.Name = "featherPercentage";
            this.featherPercentage.Size = new System.Drawing.Size(44, 15);
            this.featherPercentage.TabIndex = 23;
            this.featherPercentage.Text = "label11";
            // 
            // goldPercentage
            // 
            this.goldPercentage.AutoSize = true;
            this.goldPercentage.Location = new System.Drawing.Point(172, 385);
            this.goldPercentage.Name = "goldPercentage";
            this.goldPercentage.Size = new System.Drawing.Size(44, 15);
            this.goldPercentage.TabIndex = 24;
            this.goldPercentage.Text = "label11";
            // 
            // leatherPercentage
            // 
            this.leatherPercentage.AutoSize = true;
            this.leatherPercentage.Location = new System.Drawing.Point(252, 385);
            this.leatherPercentage.Name = "leatherPercentage";
            this.leatherPercentage.Size = new System.Drawing.Size(44, 15);
            this.leatherPercentage.TabIndex = 25;
            this.leatherPercentage.Text = "label11";
            // 
            // fleshPercentage
            // 
            this.fleshPercentage.AutoSize = true;
            this.fleshPercentage.Location = new System.Drawing.Point(332, 385);
            this.fleshPercentage.Name = "fleshPercentage";
            this.fleshPercentage.Size = new System.Drawing.Size(44, 15);
            this.fleshPercentage.TabIndex = 26;
            this.fleshPercentage.Text = "label11";
            // 
            // stringPercentage
            // 
            this.stringPercentage.AutoSize = true;
            this.stringPercentage.Location = new System.Drawing.Point(412, 385);
            this.stringPercentage.Name = "stringPercentage";
            this.stringPercentage.Size = new System.Drawing.Size(44, 15);
            this.stringPercentage.TabIndex = 27;
            this.stringPercentage.Text = "label11";
            // 
            // wheatPercentage
            // 
            this.wheatPercentage.AutoSize = true;
            this.wheatPercentage.Location = new System.Drawing.Point(492, 385);
            this.wheatPercentage.Name = "wheatPercentage";
            this.wheatPercentage.Size = new System.Drawing.Size(44, 15);
            this.wheatPercentage.TabIndex = 28;
            this.wheatPercentage.Text = "label11";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.wheatPercentage);
            this.Controls.Add(this.stringPercentage);
            this.Controls.Add(this.fleshPercentage);
            this.Controls.Add(this.leatherPercentage);
            this.Controls.Add(this.goldPercentage);
            this.Controls.Add(this.featherPercentage);
            this.Controls.Add(this.diamondPercentage);
            this.Controls.Add(this.itemiUSesiru);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.itemSpawnChance);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.wheatNum);
            this.Controls.Add(this.stringNum);
            this.Controls.Add(this.fleshNum);
            this.Controls.Add(this.leatherNum);
            this.Controls.Add(this.goldNum);
            this.Controls.Add(this.featherNum);
            this.Controls.Add(this.diamondNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inventory);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.diamondNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.featherNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goldNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leatherNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fleshNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stringNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wheatNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemSpawnChance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel inventory;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown diamondNum;
        private System.Windows.Forms.NumericUpDown featherNum;
        private System.Windows.Forms.NumericUpDown goldNum;
        private System.Windows.Forms.NumericUpDown leatherNum;
        private System.Windows.Forms.NumericUpDown fleshNum;
        private System.Windows.Forms.NumericUpDown stringNum;
        private System.Windows.Forms.NumericUpDown wheatNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown itemSpawnChance;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label itemiUSesiru;
        private System.Windows.Forms.Label diamondPercentage;
        private System.Windows.Forms.Label featherPercentage;
        private System.Windows.Forms.Label goldPercentage;
        private System.Windows.Forms.Label leatherPercentage;
        private System.Windows.Forms.Label fleshPercentage;
        private System.Windows.Forms.Label stringPercentage;
        private System.Windows.Forms.Label wheatPercentage;
    }
}

