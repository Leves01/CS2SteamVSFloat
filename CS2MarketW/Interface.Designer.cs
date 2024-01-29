using CS2MarketL.Enums;
using System;

namespace CS2MarketW
{
    partial class Interface
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
            this.nameBox = new System.Windows.Forms.ComboBox();
            this.skinBox = new System.Windows.Forms.ComboBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.currencyBox = new System.Windows.Forms.ComboBox();
            this.conditionBox = new System.Windows.Forms.ComboBox();
            this.gridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.FormattingEnabled = true;
            this.nameBox.Items.AddRange(new object[] {
            "AK-47",
            "M4A1-S",
            "M4A4",
            "AWP",
            "Desert Eagle"});
            this.nameBox.Location = new System.Drawing.Point(12, 12);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(161, 21);
            this.nameBox.TabIndex = 0;
            // 
            // skinBox
            // 
            this.skinBox.FormattingEnabled = true;
            this.skinBox.Items.AddRange(new object[] {
            "Bloodsport"});
            this.skinBox.Location = new System.Drawing.Point(12, 39);
            this.skinBox.Name = "skinBox";
            this.skinBox.Size = new System.Drawing.Size(179, 21);
            this.skinBox.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(12, 120);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(97, 42);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_ClickAsync);
            // 
            // currencyBox
            // 
            this.currencyBox.FormattingEnabled = true;
            this.currencyBox.Location = new System.Drawing.Point(12, 93);
            this.currencyBox.Name = "currencyBox";
            this.currencyBox.Size = new System.Drawing.Size(100, 21);
            this.currencyBox.TabIndex = 5;
            // 
            // conditionBox
            // 
            this.conditionBox.FormattingEnabled = true;
            this.conditionBox.Location = new System.Drawing.Point(12, 66);
            this.conditionBox.Name = "conditionBox";
            this.conditionBox.Size = new System.Drawing.Size(112, 21);
            this.conditionBox.TabIndex = 6;
            // 
            // gridView
            // 
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Location = new System.Drawing.Point(12, 168);
            this.gridView.Name = "gridView";
            this.gridView.Size = new System.Drawing.Size(757, 270);
            this.gridView.TabIndex = 7;
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 450);
            this.Controls.Add(this.gridView);
            this.Controls.Add(this.conditionBox);
            this.Controls.Add(this.currencyBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.skinBox);
            this.Controls.Add(this.nameBox);
            this.Name = "Interface";
            this.Text = "Interface";
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox nameBox;
        private System.Windows.Forms.ComboBox skinBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ComboBox currencyBox;
        private System.Windows.Forms.ComboBox conditionBox;
        private System.Windows.Forms.DataGridView gridView;
    }
}

