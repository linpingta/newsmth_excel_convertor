/*
 * Created by SharpDevelop.
 * User: linpingta
 * Date: 2014/1/11
 * Time: 15:01
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System.Windows.Forms;
using System.Drawing;
using System.Data.Common;
using System.Data;
using System;
using System.Diagnostics;
using System.IO;
using System.Collections.Generic;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ExcelConvertor
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.buttonImportExcel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonExportExcel = new System.Windows.Forms.Button();
            this.comboBoxTemplate = new System.Windows.Forms.ComboBox();
            this.listBoxDetail = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewItems = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButtonPrice = new System.Windows.Forms.RadioButton();
            this.radioButtonReprice = new System.Windows.Forms.RadioButton();
            this.groupBoxPrice = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.buttonRevisePrice = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.textBoxStartpart = new System.Windows.Forms.TextBox();
            this.buttonStartpart = new System.Windows.Forms.Button();
            this.listBoxImage = new System.Windows.Forms.ListBox();
            this.buttonDeleteImage = new System.Windows.Forms.Button();
            this.comboBoxFirstSelected = new System.Windows.Forms.ComboBox();
            this.buttonApplyFirstSelected = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.checkBoxFirstSpace = new System.Windows.Forms.CheckBox();
            this.checkBoxSecondSpace = new System.Windows.Forms.CheckBox();
            this.checkBoxReverseSpaceFirst = new System.Windows.Forms.CheckBox();
            this.checkBoxReverseSpaceSecond = new System.Windows.Forms.CheckBox();
            this.textBoxWordBefore = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.textBoxWordAfter = new System.Windows.Forms.TextBox();
            this.buttonDeleteWord = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.textBoxNameRevise = new System.Windows.Forms.TextBox();
            this.buttonNameRevise = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.textBoNewWord = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).BeginInit();
            this.groupBoxPrice.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonImportExcel
            // 
            this.buttonImportExcel.Location = new System.Drawing.Point(12, 12);
            this.buttonImportExcel.Name = "buttonImportExcel";
            this.buttonImportExcel.Size = new System.Drawing.Size(232, 23);
            this.buttonImportExcel.TabIndex = 0;
            this.buttonImportExcel.Text = "导入数据库";
            this.buttonImportExcel.UseVisualStyleBackColor = true;
            this.buttonImportExcel.Click += new System.EventHandler(this.ButtonImportExcelClick);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "    数据源为本软件目录下output.txt";
            // 
            // buttonExportExcel
            // 
            this.buttonExportExcel.Location = new System.Drawing.Point(808, 11);
            this.buttonExportExcel.Name = "buttonExportExcel";
            this.buttonExportExcel.Size = new System.Drawing.Size(198, 21);
            this.buttonExportExcel.TabIndex = 2;
            this.buttonExportExcel.Text = "导出数据库";
            this.buttonExportExcel.UseVisualStyleBackColor = true;
            this.buttonExportExcel.Click += new System.EventHandler(this.ButtonExportExcelClick);
            // 
            // comboBoxTemplate
            // 
            this.comboBoxTemplate.FormattingEnabled = true;
            this.comboBoxTemplate.Items.AddRange(new object[] {
            "模板类别1",
            "模板类别2",
            "模板类别3",
            "模板类别4",
            "模板类别5"});
            this.comboBoxTemplate.Location = new System.Drawing.Point(808, 64);
            this.comboBoxTemplate.Name = "comboBoxTemplate";
            this.comboBoxTemplate.Size = new System.Drawing.Size(196, 20);
            this.comboBoxTemplate.TabIndex = 3;
            this.comboBoxTemplate.SelectedIndexChanged += new System.EventHandler(this.ComboBoxTemplateSelectedIndexChanged);
            // 
            // listBoxDetail
            // 
            this.listBoxDetail.FormattingEnabled = true;
            this.listBoxDetail.ItemHeight = 12;
            this.listBoxDetail.Location = new System.Drawing.Point(1014, 30);
            this.listBoxDetail.Name = "listBoxDetail";
            this.listBoxDetail.Size = new System.Drawing.Size(201, 76);
            this.listBoxDetail.TabIndex = 4;
            this.listBoxDetail.SelectedIndexChanged += new System.EventHandler(this.ListBoxDetailSelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(806, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "模板类型:";
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(12, 149);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(232, 23);
            this.buttonSelect.TabIndex = 6;
            this.buttonSelect.Text = "显示数据";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.ButtonSelectClick);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(12, 178);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(232, 23);
            this.buttonDelete.TabIndex = 7;
            this.buttonDelete.Text = "删除选定项";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.ButtonDeleteClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(316, 496);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(497, 496);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(175, 175);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(678, 496);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(175, 175);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(859, 496);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(175, 175);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(1043, 496);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(175, 175);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 14;
            this.pictureBox5.TabStop = false;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(12, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(298, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "    导出结果为本软件目录下result_模板名称.xls";
            // 
            // dataGridViewItems
            // 
            this.dataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewItems.Location = new System.Drawing.Point(-69, 207);
            this.dataGridViewItems.Name = "dataGridViewItems";
            this.dataGridViewItems.RowTemplate.Height = 23;
            this.dataGridViewItems.Size = new System.Drawing.Size(1201, 269);
            this.dataGridViewItems.TabIndex = 16;
            this.dataGridViewItems.SelectionChanged += new System.EventHandler(this.DataGridViewItemsSelectionChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 479);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 14);
            this.label3.TabIndex = 17;
            this.label3.Text = "图片列表";
            // 
            // radioButtonPrice
            // 
            this.radioButtonPrice.Location = new System.Drawing.Point(6, 17);
            this.radioButtonPrice.Name = "radioButtonPrice";
            this.radioButtonPrice.Size = new System.Drawing.Size(104, 24);
            this.radioButtonPrice.TabIndex = 0;
            this.radioButtonPrice.TabStop = true;
            this.radioButtonPrice.Text = "价格";
            this.radioButtonPrice.UseVisualStyleBackColor = true;
            this.radioButtonPrice.CheckedChanged += new System.EventHandler(this.radioButtonPrice_CheckedChanged);
            // 
            // radioButtonReprice
            // 
            this.radioButtonReprice.Location = new System.Drawing.Point(116, 17);
            this.radioButtonReprice.Name = "radioButtonReprice";
            this.radioButtonReprice.Size = new System.Drawing.Size(104, 24);
            this.radioButtonReprice.TabIndex = 1;
            this.radioButtonReprice.TabStop = true;
            this.radioButtonReprice.Text = "限时折扣价";
            this.radioButtonReprice.UseVisualStyleBackColor = true;
            this.radioButtonReprice.CheckedChanged += new System.EventHandler(this.radioButtonReprice_CheckedChanged);
            // 
            // groupBoxPrice
            // 
            this.groupBoxPrice.Controls.Add(this.radioButtonReprice);
            this.groupBoxPrice.Controls.Add(this.radioButtonPrice);
            this.groupBoxPrice.Location = new System.Drawing.Point(322, 13);
            this.groupBoxPrice.Name = "groupBoxPrice";
            this.groupBoxPrice.Size = new System.Drawing.Size(237, 44);
            this.groupBoxPrice.TabIndex = 18;
            this.groupBoxPrice.TabStop = false;
            this.groupBoxPrice.Text = "价格修改表";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(328, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 19;
            this.label5.Text = "区间";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(328, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 12);
            this.label6.TabIndex = 20;
            this.label6.Text = "0-100";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(387, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(64, 21);
            this.textBox1.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(457, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 12);
            this.label7.TabIndex = 22;
            this.label7.Text = "100-200";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(326, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 12);
            this.label8.TabIndex = 23;
            this.label8.Text = "200-500";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(457, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 24;
            this.label9.Text = "500-1000";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(326, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 12);
            this.label10.TabIndex = 25;
            this.label10.Text = "1000-2000";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(457, 138);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 12);
            this.label11.TabIndex = 26;
            this.label11.Text = "2000-3000";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(328, 161);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 12);
            this.label12.TabIndex = 27;
            this.label12.Text = "3000-5000";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(457, 161);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 28;
            this.label13.Text = "5000-10000";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(328, 183);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 12);
            this.label14.TabIndex = 29;
            this.label14.Text = ">10000";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(525, 83);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(64, 21);
            this.textBox2.TabIndex = 30;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(387, 108);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(64, 21);
            this.textBox3.TabIndex = 31;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(525, 108);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(64, 21);
            this.textBox4.TabIndex = 32;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(387, 135);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(64, 21);
            this.textBox5.TabIndex = 33;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(525, 135);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(64, 21);
            this.textBox6.TabIndex = 34;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(387, 158);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(64, 21);
            this.textBox7.TabIndex = 35;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(525, 158);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(64, 21);
            this.textBox8.TabIndex = 36;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(387, 180);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(64, 21);
            this.textBox9.TabIndex = 37;
            // 
            // buttonRevisePrice
            // 
            this.buttonRevisePrice.Location = new System.Drawing.Point(457, 178);
            this.buttonRevisePrice.Name = "buttonRevisePrice";
            this.buttonRevisePrice.Size = new System.Drawing.Size(130, 23);
            this.buttonRevisePrice.TabIndex = 38;
            this.buttonRevisePrice.Text = "确认修改";
            this.buttonRevisePrice.UseVisualStyleBackColor = true;
            this.buttonRevisePrice.Click += new System.EventHandler(this.buttonRevisePrice_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(806, 183);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 12);
            this.label15.TabIndex = 39;
            this.label15.Text = "添加前缀";
            // 
            // textBoxStartpart
            // 
            this.textBoxStartpart.Location = new System.Drawing.Point(865, 180);
            this.textBoxStartpart.Name = "textBoxStartpart";
            this.textBoxStartpart.Size = new System.Drawing.Size(124, 21);
            this.textBoxStartpart.TabIndex = 40;
            // 
            // buttonStartpart
            // 
            this.buttonStartpart.Location = new System.Drawing.Point(1012, 178);
            this.buttonStartpart.Name = "buttonStartpart";
            this.buttonStartpart.Size = new System.Drawing.Size(201, 23);
            this.buttonStartpart.TabIndex = 41;
            this.buttonStartpart.Text = "确认添加";
            this.buttonStartpart.UseVisualStyleBackColor = true;
            this.buttonStartpart.Click += new System.EventHandler(this.buttonStartpart_Click);
            // 
            // listBoxImage
            // 
            this.listBoxImage.FormattingEnabled = true;
            this.listBoxImage.ItemHeight = 12;
            this.listBoxImage.Location = new System.Drawing.Point(14, 497);
            this.listBoxImage.Name = "listBoxImage";
            this.listBoxImage.Size = new System.Drawing.Size(296, 88);
            this.listBoxImage.TabIndex = 42;
            // 
            // buttonDeleteImage
            // 
            this.buttonDeleteImage.Location = new System.Drawing.Point(13, 592);
            this.buttonDeleteImage.Name = "buttonDeleteImage";
            this.buttonDeleteImage.Size = new System.Drawing.Size(149, 23);
            this.buttonDeleteImage.TabIndex = 43;
            this.buttonDeleteImage.Text = "删除选中项";
            this.buttonDeleteImage.UseVisualStyleBackColor = true;
            this.buttonDeleteImage.Click += new System.EventHandler(this.buttonDeleteImage_Click);
            // 
            // comboBoxFirstSelected
            // 
            this.comboBoxFirstSelected.FormattingEnabled = true;
            this.comboBoxFirstSelected.Location = new System.Drawing.Point(12, 622);
            this.comboBoxFirstSelected.Name = "comboBoxFirstSelected";
            this.comboBoxFirstSelected.Size = new System.Drawing.Size(298, 20);
            this.comboBoxFirstSelected.TabIndex = 44;
            // 
            // buttonApplyFirstSelected
            // 
            this.buttonApplyFirstSelected.Location = new System.Drawing.Point(14, 649);
            this.buttonApplyFirstSelected.Name = "buttonApplyFirstSelected";
            this.buttonApplyFirstSelected.Size = new System.Drawing.Size(148, 23);
            this.buttonApplyFirstSelected.TabIndex = 45;
            this.buttonApplyFirstSelected.Text = "应用首选项";
            this.buttonApplyFirstSelected.UseVisualStyleBackColor = true;
            this.buttonApplyFirstSelected.Click += new System.EventHandler(this.buttonApplyFirstSelected_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(1012, 15);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 12);
            this.label16.TabIndex = 46;
            this.label16.Text = "具体模板";
            // 
            // checkBoxFirstSpace
            // 
            this.checkBoxFirstSpace.AutoSize = true;
            this.checkBoxFirstSpace.Location = new System.Drawing.Point(611, 19);
            this.checkBoxFirstSpace.Name = "checkBoxFirstSpace";
            this.checkBoxFirstSpace.Size = new System.Drawing.Size(108, 16);
            this.checkBoxFirstSpace.TabIndex = 47;
            this.checkBoxFirstSpace.Text = "删除第一空格前";
            this.checkBoxFirstSpace.UseVisualStyleBackColor = true;
            // 
            // checkBoxSecondSpace
            // 
            this.checkBoxSecondSpace.AutoSize = true;
            this.checkBoxSecondSpace.Location = new System.Drawing.Point(611, 41);
            this.checkBoxSecondSpace.Name = "checkBoxSecondSpace";
            this.checkBoxSecondSpace.Size = new System.Drawing.Size(108, 16);
            this.checkBoxSecondSpace.TabIndex = 48;
            this.checkBoxSecondSpace.Text = "删除第二空格前";
            this.checkBoxSecondSpace.UseVisualStyleBackColor = true;
            // 
            // checkBoxReverseSpaceFirst
            // 
            this.checkBoxReverseSpaceFirst.AutoSize = true;
            this.checkBoxReverseSpaceFirst.Location = new System.Drawing.Point(611, 86);
            this.checkBoxReverseSpaceFirst.Name = "checkBoxReverseSpaceFirst";
            this.checkBoxReverseSpaceFirst.Size = new System.Drawing.Size(132, 16);
            this.checkBoxReverseSpaceFirst.TabIndex = 49;
            this.checkBoxReverseSpaceFirst.Text = "删除倒数第一空格后";
            this.checkBoxReverseSpaceFirst.UseVisualStyleBackColor = true;
            // 
            // checkBoxReverseSpaceSecond
            // 
            this.checkBoxReverseSpaceSecond.AutoSize = true;
            this.checkBoxReverseSpaceSecond.Location = new System.Drawing.Point(611, 108);
            this.checkBoxReverseSpaceSecond.Name = "checkBoxReverseSpaceSecond";
            this.checkBoxReverseSpaceSecond.Size = new System.Drawing.Size(132, 16);
            this.checkBoxReverseSpaceSecond.TabIndex = 50;
            this.checkBoxReverseSpaceSecond.Text = "删除倒数第二空格后";
            this.checkBoxReverseSpaceSecond.UseVisualStyleBackColor = true;
            // 
            // textBoxWordBefore
            // 
            this.textBoxWordBefore.Location = new System.Drawing.Point(678, 63);
            this.textBoxWordBefore.Name = "textBoxWordBefore";
            this.textBoxWordBefore.Size = new System.Drawing.Size(100, 21);
            this.textBoxWordBefore.TabIndex = 51;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(611, 64);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 12);
            this.label17.TabIndex = 52;
            this.label17.Text = "删除该词前";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(609, 128);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 12);
            this.label18.TabIndex = 53;
            this.label18.Text = "删除该词后";
            // 
            // textBoxWordAfter
            // 
            this.textBoxWordAfter.Location = new System.Drawing.Point(678, 125);
            this.textBoxWordAfter.Name = "textBoxWordAfter";
            this.textBoxWordAfter.Size = new System.Drawing.Size(100, 21);
            this.textBoxWordAfter.TabIndex = 54;
            // 
            // buttonDeleteWord
            // 
            this.buttonDeleteWord.Location = new System.Drawing.Point(611, 172);
            this.buttonDeleteWord.Name = "buttonDeleteWord";
            this.buttonDeleteWord.Size = new System.Drawing.Size(167, 23);
            this.buttonDeleteWord.TabIndex = 55;
            this.buttonDeleteWord.Text = "确认删除";
            this.buttonDeleteWord.UseVisualStyleBackColor = true;
            this.buttonDeleteWord.Click += new System.EventHandler(this.buttonDeleteWord_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(806, 108);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 12);
            this.label19.TabIndex = 56;
            this.label19.Text = "修改名称";
            // 
            // textBoxNameRevise
            // 
            this.textBoxNameRevise.Location = new System.Drawing.Point(808, 123);
            this.textBoxNameRevise.Name = "textBoxNameRevise";
            this.textBoxNameRevise.Size = new System.Drawing.Size(405, 21);
            this.textBoxNameRevise.TabIndex = 57;
            // 
            // buttonNameRevise
            // 
            this.buttonNameRevise.Location = new System.Drawing.Point(808, 148);
            this.buttonNameRevise.Name = "buttonNameRevise";
            this.buttonNameRevise.Size = new System.Drawing.Size(181, 23);
            this.buttonNameRevise.TabIndex = 58;
            this.buttonNameRevise.Text = "确认名称修改";
            this.buttonNameRevise.UseVisualStyleBackColor = true;
            this.buttonNameRevise.Click += new System.EventHandler(this.buttonNameRevise_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(609, 150);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(71, 12);
            this.label20.TabIndex = 59;
            this.label20.Text = "删除第x词前";
            // 
            // textBoNewWord
            // 
            this.textBoNewWord.Location = new System.Drawing.Point(680, 147);
            this.textBoNewWord.Name = "textBoNewWord";
            this.textBoNewWord.Size = new System.Drawing.Size(41, 21);
            this.textBoNewWord.TabIndex = 62;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 681);
            this.Controls.Add(this.textBoNewWord);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.buttonNameRevise);
            this.Controls.Add(this.textBoxNameRevise);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.buttonDeleteWord);
            this.Controls.Add(this.textBoxWordAfter);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.textBoxWordBefore);
            this.Controls.Add(this.checkBoxReverseSpaceSecond);
            this.Controls.Add(this.checkBoxReverseSpaceFirst);
            this.Controls.Add(this.checkBoxSecondSpace);
            this.Controls.Add(this.checkBoxFirstSpace);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.buttonApplyFirstSelected);
            this.Controls.Add(this.comboBoxFirstSelected);
            this.Controls.Add(this.buttonDeleteImage);
            this.Controls.Add(this.listBoxImage);
            this.Controls.Add(this.buttonStartpart);
            this.Controls.Add(this.textBoxStartpart);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.buttonRevisePrice);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBoxPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridViewItems);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxDetail);
            this.Controls.Add(this.comboBoxTemplate);
            this.Controls.Add(this.buttonExportExcel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonImportExcel);
            this.Name = "MainForm";
            this.Text = "ExcelConvertor";
            this.Load += new System.EventHandler(this.MainFormLoad);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).EndInit();
            this.groupBoxPrice.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.GroupBox groupBoxPrice;
		private System.Windows.Forms.RadioButton radioButtonReprice;
		private System.Windows.Forms.RadioButton radioButtonPrice;
		private System.Windows.Forms.DataGridView dataGridViewItems;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.Button buttonSelect;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ListBox listBoxDetail;
		private System.Windows.Forms.ComboBox comboBoxTemplate;
		private System.Windows.Forms.Button buttonExportExcel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonImportExcel;
		
		//private string[] url_arr = new string[];
		
		void ButtonImportExcelClick(object sender, System.EventArgs e)
		{
			string path = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "\\transfer_txt.py";			
				
	        ProcessStartInfo start = new ProcessStartInfo("python");
	        start.FileName = @"C:\\Python27\\python.exe";
	        start.Arguments = string.Format("{0}",path);	        
	        start.UseShellExecute = false;
	        start.RedirectStandardOutput = true;

            this.dataGridViewItems.DataSource = null;
	        
	        Process p = new Process();
	        p.StartInfo = start;
	        p.Start();
	        
            using (StreamReader reader = p.StandardOutput)
            {
                string result = reader.ReadToEnd();
                Console.Write(result);
                MessageBox.Show(result);
            }
	    
		}
		
		void ButtonExportExcelClick(object sender, System.EventArgs e)
		{
			string path = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "\\operate_excel.py";			
			string outputFilename = "result.xls";
            if (currentDetailTemplate != "")
                outputFilename = currentDetailTemplate;
            else
            {
                MessageBox.Show("请在‘具体模板’中选择实际应用的模板（如电子.cn.xls），并保证相应xls文件在当前路径下!");
                return;
            }
			int templateType = 1;
			if (currentSelectTemplate != -1) {
				templateType = currentSelectTemplate + 1;
			}
	        ProcessStartInfo start = new ProcessStartInfo("python");
	        start.FileName = @"C:\\Python27\\python.exe";
	        start.Arguments = string.Format("{0} {1}",path,outputFilename+";"+Convert.ToString(templateType));
	        start.UseShellExecute = false;
	        start.RedirectStandardOutput = true;
	        
	        Process p = new Process();
	        p.StartInfo = start;
	        p.Start();
	        
            using (StreamReader reader = p.StandardOutput)
            {
                string result = reader.ReadToEnd();
                Console.Write(result);
                MessageBox.Show(result);
            }
		}
						
		private int currentSelectTemplate = -1;
		void ComboBoxTemplateSelectedIndexChanged(object sender, System.EventArgs e)
		{
			currentSelectTemplate = this.comboBoxTemplate.SelectedIndex;
			
			ComboBox comboBox = (ComboBox) sender;
			string selectedItem = (string) comboBox.SelectedItem;
			if (selectedItem == "模板类别1") {
				this.listBoxDetail.Items.Clear();
				this.listBoxDetail.Items.Add("服装鞋帽类.cn.xls");
				this.listBoxDetail.Items.Add("汽车类.cn.xls");
				this.listBoxDetail.Items.Add("电子s.cn.xls");
				this.listBoxDetail.Items.Add("Flat.File.Beauty.cn.xls");
				this.listBoxDetail.Items.Add("Flat.File.FoodAndBeverages.cn.xls");
				this.listBoxDetail.Items.Add("Flat.File.Home.cn.xls");
				this.listBoxDetail.Items.Add("Flat.File.HomeImprovement.cn.xls");
				this.listBoxDetail.Items.Add("Flat.File.Jewelry.cn.xls");
				this.listBoxDetail.Items.Add("Flat.File.LargeAppliances.cn.xls");
				this.listBoxDetail.Items.Add("Flat.File.MusicalInstruments.cn.xls");
				this.listBoxDetail.Items.Add("Flat.File.PetSupplies.cn.xls");
				this.listBoxDetail.Items.Add("Flat.File.Sports.cn.xls");				
				this.listBoxDetail.Items.Add("Flat.File.ToysBaby.cn.xls");
				this.listBoxDetail.Items.Add("Flat.File.Watches.cn.xls");
				this.listBoxDetail.Items.Add("Flat.File.Wine.cn.xls");
			}
			else if(selectedItem == "模板类别2"){
				this.listBoxDetail.Items.Clear();
				// 没有 父SKU，商品变体主题等信息
				this.listBoxDetail.Items.Add("Flat.File.BookLoader.cn.xls");
				this.listBoxDetail.Items.Add("Flat.File.Music.cn.xls");
				this.listBoxDetail.Items.Add("Flat.File.Video.cn.xls");
			}
			else if (selectedItem == "模板类别3"){
				this.listBoxDetail.Items.Clear();
				// 搜索关键词 11 而非 搜索关键词 1
				this.listBoxDetail.Items.Add("Flat.File.Computers.cn.xls");
			}
			else if (selectedItem == "模板类别4"){
				this.listBoxDetail.Items.Clear();
				// 其他图片 URL 只有一个 
				this.listBoxDetail.Items.Add("Flat.File.Health.cn.xls");
			}
			else if (selectedItem == "模板类别5"){
				this.listBoxDetail.Items.Clear();
				// 特价 而非 限时折扣价
				// 搜索关键词 1 - 搜索关键词51
				this.listBoxDetail.Items.Add("Flat.File.Office.cn.xls");
			}
		}
		
		private int currentSelectedIndex = -1;
		private String currentSelectedTitle = "";
		private String currentSelectedUrlList = "";
		private DataGridViewRow currentSelectedRow;

        private void buttonDeleteWord_Click(object sender, EventArgs e)
        {
            bool bFlag = this.checkBoxFirstSpace.Checked;

            string tmp = this.textBoxStartpart.Text;

            string strConn = "server=localhost;User Id=root;password=root1;Database=smth_linpingta";
            MySqlConnection myConn = new MySqlConnection(strConn);
            myConn.Open();

            int row = this.dataGridViewItems.Rows.Count;
            for (int i = 0; i < row - 1; ++i)
            {
                string title = Convert.ToString(this.dataGridViewItems.Rows[i].Cells[1].Value);
                string myid = Convert.ToString(this.dataGridViewItems.Rows[i].Cells[0].Value);
                string tmpTitle = title;
                string[] strArray = title.Split(new char[]{' '});

                // substr
                int startIndex = 0;
                int endIndex = strArray.Length - 1;
                if (this.checkBoxSecondSpace.Checked && strArray.Length > 2)
                {
                    startIndex = 2;
                }
                else if (this.checkBoxFirstSpace.Checked && strArray.Length > 1)
                {
                    startIndex = 1;
                }

                if (this.checkBoxReverseSpaceSecond.Checked && strArray.Length > 2)
                {
                    endIndex = strArray.Length - 3;
                }
                else if (this.checkBoxReverseSpaceFirst.Checked && strArray.Length > 1)
                {
                    endIndex = strArray.Length - 2;
                }

                if (startIndex <= endIndex)
                {
                    tmpTitle = "";
                    for (int j = startIndex; j <= endIndex; ++j)
                    {
                        tmpTitle += strArray[j].ToString();
                    }
                }

                int wordFirstIndex = 0;
                int wordLastIndex = tmpTitle.Length - 1;
                if (this.textBoxWordBefore.Text != "")
                {
                    wordFirstIndex = tmpTitle.IndexOf(this.textBoxWordBefore.Text);
                    if (wordFirstIndex == -1)
                        wordFirstIndex = 0;
                    else
                        wordFirstIndex = wordFirstIndex + this.textBoxWordBefore.Text.Length;
                }
                if (this.textBoxWordAfter.Text != "")
                {
                    wordLastIndex = tmpTitle.LastIndexOf(this.textBoxWordAfter.Text);
                    if (wordLastIndex == -1)
                        wordLastIndex = tmpTitle.Length - 1;
                    else
                        wordLastIndex = wordLastIndex - this.textBoxWordAfter.Text.Length;
                }

                string resultTitle = "";
                if (wordFirstIndex != 0 || wordLastIndex != tmpTitle.Length - 1)
                {
                    if (wordLastIndex > (wordFirstIndex - 1))
                        resultTitle = tmpTitle.Substring(wordFirstIndex, wordLastIndex - wordFirstIndex + 1);
                }
                else
                    resultTitle = tmpTitle;

                if (this.textBoNewWord.Text != "")
                {
                    string tmpStr = resultTitle;
                    int wordNumBefore = Convert.ToInt16(this.textBoNewWord.Text);
                    if (wordNumBefore > 0)
                        resultTitle = tmpStr.Substring(wordNumBefore);
                }

                this.dataGridViewItems.Rows[i].Cells[1].Value = resultTitle;

                if (row > 0)
                {
                    MySqlCommand cmd = new MySqlCommand("update smth2 set title='" + resultTitle + "' where id=" + myid + ";", myConn);
                    cmd.ExecuteNonQuery();
                }
            }

            myConn.Close();
        }
		
		void ButtonSelectClick(object sender, System.EventArgs e)
		{
			// link mysql db
			string strConn = "server=localhost;User Id=root;password=root1;Database=smth_linpingta";
			MySqlConnection myConn = new MySqlConnection(strConn);
			myConn.Open();		
			
			MySqlClientFactory factory = MySqlClientFactory.Instance;
			DbDataAdapter da = factory.CreateDataAdapter();
			da.SelectCommand = myConn.CreateCommand();  
            da.SelectCommand.CommandText = "SELECT * FROM smth2";
            
            DataTable dt = new DataTable("smth2");
            da.Fill(dt);
                        
            this.dataGridViewItems.DataSource = dt;
            
            myConn.Close();
            
            /*
            int index = 0;  
            foreach ( DataRow item in dt.Rows )  
            {  
            	string title = Convert.ToString(item[1]);
            	string desc1 = item[2].ToString();
            	//double price = item[3];
            	//string keywords = item[4];
            	this.listBoxItem.Items.Add(title + "  " + desc1);
                index++;  
            } 
            */          
		}
		
		void MainFormLoad(object sender, System.EventArgs e)
		{
			//this.comboBoxTemplate.Items.Insert(0,"--SELECT TEMPLATE--");
			this.comboBoxTemplate.SelectedIndex = 0;

            // read price file and show
            string strReadFilePath = @".\price.txt";
            StreamReader srReadFile = new StreamReader(strReadFilePath);

            bool bPriceFlag = true;
            while (!srReadFile.EndOfStream)
            {
                string strReadLine = srReadFile.ReadLine(); //读取每行数据

                if (strReadLine == "price")
                {
                    bPriceFlag = true;
                    continue;
                }
                else if (strReadLine == "reprice")
                {
                    bPriceFlag = false;
                    continue;
                }
                string[] strList = strReadLine.Split(';');
                if (bPriceFlag)
                {
                    priceDict.Add(strList[0],Convert.ToDouble(strList[1]));
                }
                else
                {
                    repriceDict.Add(strList[0], Convert.ToDouble(strList[1]));
                }
            }

            srReadFile.Close();
		}

        private void radioButtonPrice_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonPrice.Checked)
            {
                this.textBox1.Text = Convert.ToString(priceDict["0-100"]);
                this.textBox2.Text = Convert.ToString(priceDict["100-200"]);
                this.textBox3.Text = Convert.ToString(priceDict["200-500"]);
                this.textBox4.Text = Convert.ToString(priceDict["500-1000"]);
                this.textBox5.Text = Convert.ToString(priceDict["1000-2000"]);
                this.textBox6.Text = Convert.ToString(priceDict["2000-3000"]);
                this.textBox7.Text = Convert.ToString(priceDict["3000-5000"]);
                this.textBox8.Text = Convert.ToString(priceDict["5000-10000"]);
                this.textBox9.Text = Convert.ToString(priceDict[">10000"]);
            }

            if (this.radioButtonReprice.Checked)
            {
                this.textBox1.Text = Convert.ToString(repriceDict["0-100"]);
                this.textBox2.Text = Convert.ToString(repriceDict["100-200"]);
                this.textBox3.Text = Convert.ToString(repriceDict["200-500"]);
                this.textBox4.Text = Convert.ToString(repriceDict["500-1000"]);
                this.textBox5.Text = Convert.ToString(repriceDict["1000-2000"]);
                this.textBox6.Text = Convert.ToString(repriceDict["2000-3000"]);
                this.textBox7.Text = Convert.ToString(repriceDict["3000-5000"]);
                this.textBox8.Text = Convert.ToString(repriceDict["5000-10000"]);
                this.textBox9.Text = Convert.ToString(repriceDict[">10000"]);
            }
        }

        private void radioButtonReprice_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButtonPrice.Checked)
            {
                this.textBox1.Text = Convert.ToString(priceDict["0-100"]);
                this.textBox2.Text = Convert.ToString(priceDict["100-200"]);
                this.textBox3.Text = Convert.ToString(priceDict["200-500"]);
                this.textBox4.Text = Convert.ToString(priceDict["500-1000"]);
                this.textBox5.Text = Convert.ToString(priceDict["1000-2000"]);
                this.textBox6.Text = Convert.ToString(priceDict["2000-3000"]);
                this.textBox7.Text = Convert.ToString(priceDict["3000-5000"]);
                this.textBox8.Text = Convert.ToString(priceDict["5000-10000"]);
                this.textBox9.Text = Convert.ToString(priceDict[">10000"]);
            }

            if (this.radioButtonReprice.Checked)
            {
                this.textBox1.Text = Convert.ToString(repriceDict["0-100"]);
                this.textBox2.Text = Convert.ToString(repriceDict["100-200"]);
                this.textBox3.Text = Convert.ToString(repriceDict["200-500"]);
                this.textBox4.Text = Convert.ToString(repriceDict["500-1000"]);
                this.textBox5.Text = Convert.ToString(repriceDict["1000-2000"]);
                this.textBox6.Text = Convert.ToString(repriceDict["2000-3000"]);
                this.textBox7.Text = Convert.ToString(repriceDict["3000-5000"]);
                this.textBox8.Text = Convert.ToString(repriceDict["5000-10000"]);
                this.textBox9.Text = Convert.ToString(repriceDict[">10000"]);
            }
        }

        private void buttonRevisePrice_Click(object sender, EventArgs e)
        {
            if (this.radioButtonPrice.Checked)
            {
                priceDict["0-100"] = Convert.ToDouble(this.textBox1.Text);
                priceDict["100-200"] = Convert.ToDouble(this.textBox2.Text);
                priceDict["200-500"] = Convert.ToDouble(this.textBox3.Text);
                priceDict["500-1000"] = Convert.ToDouble(this.textBox4.Text);
                priceDict["1000-2000"] = Convert.ToDouble(this.textBox5.Text);
                priceDict["2000-3000"] = Convert.ToDouble(this.textBox6.Text);
                priceDict["3000-5000"] = Convert.ToDouble(this.textBox7.Text);
                priceDict["5000-10000"] = Convert.ToDouble(this.textBox8.Text);
                priceDict[">10000"] = Convert.ToDouble(this.textBox9.Text);
            }

            if (this.radioButtonReprice.Checked)
            {
                repriceDict["0-100"] = Convert.ToDouble(this.textBox1.Text);
                repriceDict["100-200"] = Convert.ToDouble(this.textBox2.Text);
                repriceDict["200-500"] = Convert.ToDouble(this.textBox3.Text);
                repriceDict["500-1000"] = Convert.ToDouble(this.textBox4.Text);
                repriceDict["1000-2000"] = Convert.ToDouble(this.textBox5.Text);
                repriceDict["2000-3000"] = Convert.ToDouble(this.textBox6.Text);
                repriceDict["3000-5000"] = Convert.ToDouble(this.textBox7.Text);
                repriceDict["5000-10000"] = Convert.ToDouble(this.textBox8.Text);
                repriceDict[">10000"] = Convert.ToDouble(this.textBox9.Text);
            }

            string strWriteFilePath = @".\price.txt";
            StreamWriter swWriteFile = File.CreateText(strWriteFilePath);

            swWriteFile.WriteLine("price");
            foreach (string key in priceDict.Keys)
            {
                swWriteFile.WriteLine(key + ";" + priceDict[key]);
            }

            swWriteFile.WriteLine("reprice");
            foreach (string key in repriceDict.Keys)
            {
                swWriteFile.WriteLine(key + ";" + repriceDict[key]);
            }

            swWriteFile.Close();
        }
		
		void DataGridViewItemsSelectionChanged(object sender, EventArgs e)
		{
			int index = this.dataGridViewItems.CurrentRow.Index;
			currentSelectedRow = this.dataGridViewItems.CurrentRow;
			currentSelectedIndex = index;
			currentSelectedTitle = Convert.ToString(this.dataGridViewItems.Rows[index].Cells[1].Value);
			currentSelectedUrlList = Convert.ToString(this.dataGridViewItems.Rows[index].Cells[7].Value);
            currentMyUrlList = currentSelectedUrlList;

            if (currentSelectedIndex > -1)
            {
                currentSelectedId = Convert.ToInt32(this.dataGridViewItems.Rows[currentSelectedIndex].Cells[0].Value);
                this.textBoxNameRevise.Text = Convert.ToString(this.dataGridViewItems.Rows[index].Cells[1].Value);
            }
            
			string[] urlArray = currentSelectedUrlList.Split(',');
			int urlSize = urlArray.GetLength(0);
            this.listBoxImage.Items.Clear();
            this.comboBoxFirstSelected.Items.Clear();

            this.pictureBox1.Image = null;
            this.pictureBox2.Image = null;
            this.pictureBox3.Image = null;
            this.pictureBox4.Image = null;
            this.pictureBox5.Image = null;

			for (int i = 0;i < urlSize;++i)
			{
                if (currentSelectedUrlList == "")
                    break;

				int cIndex = urlArray[i].LastIndexOf("/");
				if (cIndex > -1 && (cIndex < urlArray[i].Length - 1))
				{
                    this.listBoxImage.Items.Add(urlArray[i]);
                    this.comboBoxFirstSelected.Items.Add(urlArray[i]);
					urlArray[i] = urlArray[i].Substring(cIndex + 1);                    
				}
				if (i == 0)
				{
					this.pictureBox1.Image = Image.FromFile(@".\images\" + urlArray[i]);
				}
				else if (i == 1)
				{
					this.pictureBox2.Image = Image.FromFile(@".\images\" + urlArray[i]);
				}
				else if (i == 2)
				{
					this.pictureBox3.Image = Image.FromFile(@".\images\" + urlArray[i]);
				}
				else if (i == 3)
				{
					this.pictureBox4.Image = Image.FromFile(@".\images\" + urlArray[i]);
				}
				else if (i == 4)
				{
					this.pictureBox5.Image = Image.FromFile(@".\images\" + urlArray[i]);
				}
			}
			
		}

		void ButtonDeleteClick(object sender, EventArgs e)
		{
			if (currentSelectedIndex > -1) {
				int id = Convert.ToInt32(this.dataGridViewItems.Rows[currentSelectedIndex].Cells[0].Value);
                currentSelectedId = id;
				if (id > -1) {
					// link mysql db
					string strConn = "server=localhost;User Id=root;password=root1;Database=smth_linpingta";
					MySqlConnection myConn = new MySqlConnection(strConn);
					myConn.Open();	
					
					this.dataGridViewItems.Rows.Remove(currentSelectedRow);
         			MySqlCommand cmd = new MySqlCommand("delete from smth2 where id=" + id + "", myConn);
         			cmd.ExecuteNonQuery();
         
					myConn.Close();
				}
			}
		}
		
		private String currentDetailTemplate = "";
		void ListBoxDetailSelectedIndexChanged(object sender, EventArgs e)
		{
			currentDetailTemplate = this.listBoxDetail.SelectedItem.ToString();			
		}

        private Label label5;
        private Label label6;
        private TextBox textBox1;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private Button buttonRevisePrice;
        private Label label15;
        private TextBox textBoxStartpart;
        private Button buttonStartpart;

        private void buttonStartpart_Click(object sender, EventArgs e)
        {
            if (this.textBoxStartpart.Text != "")
            {
                string tmp = this.textBoxStartpart.Text;

                string strConn = "server=localhost;User Id=root;password=root1;Database=smth_linpingta";
                MySqlConnection myConn = new MySqlConnection(strConn);
                myConn.Open();

                int row = this.dataGridViewItems.Rows.Count;
                for (int i = 0; i < row - 1;++i)
                {
                    string title = Convert.ToString(this.dataGridViewItems.Rows[i].Cells[1].Value);
                    this.dataGridViewItems.Rows[i].Cells[1].Value = tmp + "_" + title;
                }

                if (row > 0)
                {
                    MySqlCommand cmd = new MySqlCommand("update smth2 set title=concat('" + tmp + "_'" + ",title" + ")", myConn);
                    cmd.ExecuteNonQuery();
                }

                myConn.Close();
            }
        }

        private Dictionary<string, double> priceDict = new Dictionary<string, double>();
        private Dictionary<string, double> repriceDict = new Dictionary<string, double>();
        private ListBox listBoxImage;
        private Button buttonDeleteImage;
        private int currentSelectedId = -1;
        private string currentMyUrlList = "";

        private void buttonDeleteImage_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.listBoxImage.Items.Count; ++i)
            {
                if (Convert.ToString(this.comboBoxFirstSelected.Items[i]) == Convert.ToString(this.listBoxImage.SelectedItem))
                {
                    this.comboBoxFirstSelected.Items.Remove(this.comboBoxFirstSelected.Items[i]);
                    break;
                }
            }

            this.listBoxImage.Items.Remove(this.listBoxImage.SelectedItem);

            string newUrlList = "";
            for (int i = 0; i < this.listBoxImage.Items.Count; ++i)
            {
                newUrlList += Convert.ToString(this.listBoxImage.Items[i]);
                if (i < this.listBoxImage.Items.Count - 1)
                    newUrlList += ",";
            }

         	string[] urlArray = newUrlList.Split(',');
			int urlSize = urlArray.GetLength(0);

            this.listBoxImage.Items.Clear();

            this.pictureBox1.Image = null;
            this.pictureBox2.Image = null;
            this.pictureBox3.Image = null;
            this.pictureBox4.Image = null;
            this.pictureBox5.Image = null;

            for (int i = 0; i < urlSize; ++i)
            {
                if (newUrlList == "")
                    break;

                int cIndex = urlArray[i].LastIndexOf("/");
                if (cIndex > -1 && (cIndex < urlArray[i].Length - 1))
                {
                    this.listBoxImage.Items.Add(urlArray[i]);
                    urlArray[i] = urlArray[i].Substring(cIndex + 1);
                }
                if (i == 0)
                {
                    this.pictureBox1.Image = Image.FromFile(@".\images\" + urlArray[i]);
                }
                else if (i == 1)
                {
                    this.pictureBox2.Image = Image.FromFile(@".\images\" + urlArray[i]);
                }
                else if (i == 2)
                {
                    this.pictureBox3.Image = Image.FromFile(@".\images\" + urlArray[i]);
                }
                else if (i == 3)
                {
                    this.pictureBox4.Image = Image.FromFile(@".\images\" + urlArray[i]);
                }
                else if (i == 4)
                {
                    this.pictureBox5.Image = Image.FromFile(@".\images\" + urlArray[i]);
                }
            }

            currentMyUrlList = newUrlList;

            string strConn = "server=localhost;User Id=root;password=root1;Database=smth_linpingta";
            MySqlConnection myConn = new MySqlConnection(strConn);
            myConn.Open();

            MySqlCommand cmd = new MySqlCommand("update smth2 set URLLIST='" + newUrlList + "' where id=" + currentSelectedId + ";", myConn);
            cmd.ExecuteNonQuery();

            //MySqlClientFactory factory = MySqlClientFactory.Instance;
            //DbDataAdapter da = factory.CreateDataAdapter();
            //da.SelectCommand = myConn.CreateCommand();
            //da.SelectCommand.CommandText = "SELECT * FROM smth2";

            //DataTable dt = new DataTable("smth2");
            //da.Fill(dt);

            //this.dataGridViewItems.DataSource = dt;
            //int a = this.listBoxImage.Items.Count;
            myConn.Close();

            // this.dataGridViewItems.Rows[currentSelectedIndex].Selected = true;  
            this.dataGridViewItems.Rows[currentSelectedIndex].Cells[7].Value = newUrlList;
        }

        private ComboBox comboBoxFirstSelected;
        private Button buttonApplyFirstSelected;

        private void buttonApplyFirstSelected_Click(object sender, EventArgs e)
        {
            string[] urlArray = currentMyUrlList.Split(',');
            int urlSize = urlArray.GetLength(0);

            string selectedItem = (string)this.comboBoxFirstSelected.SelectedItem;
            int iFirst = 0;
            for (int i = 1; i < urlSize; ++i)
            {
                if (urlArray[i] == selectedItem)
                {
                    string tmp = urlArray[i];
                    urlArray[i] = urlArray[iFirst];
                    urlArray[iFirst] = tmp;
                }
            }

            this.listBoxImage.Items.Clear();

            this.pictureBox1.Image = null;
            this.pictureBox2.Image = null;
            this.pictureBox3.Image = null;
            this.pictureBox4.Image = null;
            this.pictureBox5.Image = null;

            string newUrlList = "";
            for (int i = 0; i < urlSize; ++i)
            {
                int cIndex = urlArray[i].LastIndexOf("/");
                if (cIndex > -1 && (cIndex < urlArray[i].Length - 1))
                {
                    newUrlList += urlArray[i];
                    if (i < urlSize - 1)
                        newUrlList += ",";
                    this.listBoxImage.Items.Add(urlArray[i]);
                    urlArray[i] = urlArray[i].Substring(cIndex + 1);
                }
                if (i == 0)
                {
                    this.pictureBox1.Image = Image.FromFile(@".\images\" + urlArray[i]);
                }
                else if (i == 1)
                {
                    this.pictureBox2.Image = Image.FromFile(@".\images\" + urlArray[i]);
                }
                else if (i == 2)
                {
                    this.pictureBox3.Image = Image.FromFile(@".\images\" + urlArray[i]);
                }
                else if (i == 3)
                {
                    this.pictureBox4.Image = Image.FromFile(@".\images\" + urlArray[i]);
                }
                else if (i == 4)
                {
                    this.pictureBox5.Image = Image.FromFile(@".\images\" + urlArray[i]);
                }
            }

            currentMyUrlList = newUrlList;

            string strConn = "server=localhost;User Id=root;password=root1;Database=smth_linpingta";
            MySqlConnection myConn = new MySqlConnection(strConn);
            myConn.Open();

            MySqlCommand cmd = new MySqlCommand("update smth2 set URLLIST='" + newUrlList + "' where id=" + currentSelectedId + ";", myConn);
            cmd.ExecuteNonQuery();

            MySqlClientFactory factory = MySqlClientFactory.Instance;
            DbDataAdapter da = factory.CreateDataAdapter();
            da.SelectCommand = myConn.CreateCommand();
            da.SelectCommand.CommandText = "SELECT * FROM smth2";

            DataTable dt = new DataTable("smth2");
            da.Fill(dt);

            this.dataGridViewItems.DataSource = dt;
            int a = this.listBoxImage.Items.Count;

            myConn.Close();

            this.dataGridViewItems.Rows[currentSelectedIndex].Selected = true;            
        }

        private Label label16;
        private CheckBox checkBoxFirstSpace;
        private CheckBox checkBoxSecondSpace;
        private CheckBox checkBoxReverseSpaceFirst;
        private CheckBox checkBoxReverseSpaceSecond;
        private TextBox textBoxWordBefore;
        private Label label17;
        private Label label18;
        private TextBox textBoxWordAfter;
        private Button buttonDeleteWord;
        private Label label19;
        private TextBox textBoxNameRevise;
        private Button buttonNameRevise;

        private void buttonNameRevise_Click(object sender, EventArgs e)
        {
            string strConn = "server=localhost;User Id=root;password=root1;Database=smth_linpingta";
            MySqlConnection myConn = new MySqlConnection(strConn);
            myConn.Open();

            string resultTitle = this.textBoxNameRevise.Text;
            string myid = Convert.ToString(currentSelectedIndex);
            if (currentSelectedIndex > -1)
            {
                this.dataGridViewItems.Rows[this.dataGridViewItems.CurrentRow.Index].Cells[1].Value = resultTitle;
                MySqlCommand cmd = new MySqlCommand("update smth2 set title='" + resultTitle + "' where id=" + myid + ";", myConn);
                cmd.ExecuteNonQuery();
            }
           
            myConn.Close();
        }

        private Label label20;
        private TextBox textBoNewWord;
	}
}
