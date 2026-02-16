namespace GestiuneCarti.Forms
{
    partial class ImprimareForm
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
            load_pdf_btn = new Button();
            pdfPanel = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            margin_tb = new TextBox();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // load_pdf_btn
            // 
            load_pdf_btn.BackColor = Color.FromArgb(54, 54, 54);
            load_pdf_btn.Dock = DockStyle.Fill;
            load_pdf_btn.FlatStyle = FlatStyle.Flat;
            load_pdf_btn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            load_pdf_btn.ForeColor = Color.LightGray;
            load_pdf_btn.Location = new Point(0, 0);
            load_pdf_btn.Margin = new Padding(0, 0, 10, 0);
            load_pdf_btn.Name = "load_pdf_btn";
            tableLayoutPanel1.SetRowSpan(load_pdf_btn, 2);
            load_pdf_btn.Size = new Size(734, 85);
            load_pdf_btn.TabIndex = 13;
            load_pdf_btn.Text = "Vizualizează";
            load_pdf_btn.UseVisualStyleBackColor = false;
            load_pdf_btn.Click += load_pdf_btn_Click;
            // 
            // pdfPanel
            // 
            pdfPanel.BackColor = Color.FromArgb(54, 54, 54);
            pdfPanel.BorderStyle = BorderStyle.Fixed3D;
            pdfPanel.Dock = DockStyle.Fill;
            pdfPanel.Location = new Point(50, 50);
            pdfPanel.Name = "pdfPanel";
            pdfPanel.Size = new Size(1489, 763);
            pdfPanel.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(53, 9);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 5, 5, 5);
            label1.Size = new Size(186, 35);
            label1.TabIndex = 29;
            label1.Text = "Afișare registru PDF";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(54, 54, 54);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 963);
            panel1.Name = "panel1";
            panel1.Size = new Size(1589, 39);
            panel1.TabIndex = 30;
            // 
            // panel3
            // 
            panel3.Controls.Add(pdfPanel);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(50, 50, 50, 150);
            panel3.Size = new Size(1589, 963);
            panel3.TabIndex = 32;
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 838);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(50, 20, 50, 20);
            panel2.Size = new Size(1589, 125);
            panel2.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label2, 1, 0);
            tableLayoutPanel1.Controls.Add(load_pdf_btn, 0, 0);
            tableLayoutPanel1.Controls.Add(margin_tb, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(50, 20);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1489, 85);
            tableLayoutPanel1.TabIndex = 14;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(754, 5);
            label2.Margin = new Padding(10, 0, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(732, 31);
            label2.TabIndex = 15;
            label2.Text = "Marginea stângă     (valoarea standard 60 pixeli)";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // margin_tb
            // 
            margin_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            margin_tb.BackColor = Color.FromArgb(54, 54, 54);
            margin_tb.BorderStyle = BorderStyle.FixedSingle;
            margin_tb.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            margin_tb.ForeColor = Color.White;
            margin_tb.Location = new Point(754, 45);
            margin_tb.Margin = new Padding(10, 3, 3, 3);
            margin_tb.Name = "margin_tb";
            margin_tb.Size = new Size(732, 38);
            margin_tb.TabIndex = 14;
            margin_tb.Text = "30";
            // 
            // ImprimareForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1589, 1002);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "ImprimareForm";
            Text = "ImprimareForm";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button load_pdf_btn;
        private Panel pdfPanel;
        private Label label1;
        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox margin_tb;
        private Label label2;
    }
}