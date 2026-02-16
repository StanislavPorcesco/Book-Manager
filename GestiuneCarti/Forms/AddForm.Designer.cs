namespace GestiuneCarti.Forms
{
    partial class AddForm
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
            panel1 = new Panel();
            base_panel = new Panel();
            main_panel = new Panel();
            groupBox1 = new GroupBox();
            TablePanel = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            idVechi_tb = new TextBox();
            label7 = new Label();
            label1 = new Label();
            idCarte_tb = new TextBox();
            label8 = new Label();
            pret_tb = new TextBox();
            label5 = new Label();
            idCZU_tb = new TextBox();
            label3 = new Label();
            locPublicare_tb = new TextBox();
            label6 = new Label();
            anPublicare_tb = new TextBox();
            label4 = new Label();
            autor_tb = new TextBox();
            label2 = new Label();
            titlu_tb = new TextBox();
            adaugaCarte_btn = new FontAwesome.Sharp.IconButton();
            base_panel.SuspendLayout();
            main_panel.SuspendLayout();
            groupBox1.SuspendLayout();
            TablePanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(54, 54, 54);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 891);
            panel1.Name = "panel1";
            panel1.Size = new Size(1660, 39);
            panel1.TabIndex = 13;
            // 
            // base_panel
            // 
            base_panel.Controls.Add(main_panel);
            base_panel.Dock = DockStyle.Fill;
            base_panel.Location = new Point(0, 0);
            base_panel.Name = "base_panel";
            base_panel.Padding = new Padding(50);
            base_panel.Size = new Size(1660, 891);
            base_panel.TabIndex = 14;
            // 
            // main_panel
            // 
            main_panel.Controls.Add(groupBox1);
            main_panel.Dock = DockStyle.Fill;
            main_panel.Location = new Point(50, 50);
            main_panel.Name = "main_panel";
            main_panel.Size = new Size(1560, 791);
            main_panel.TabIndex = 13;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TablePanel);
            groupBox1.Controls.Add(adaugaCarte_btn);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(30);
            groupBox1.Size = new Size(1560, 791);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Adaugă carte";
            // 
            // TablePanel
            // 
            TablePanel.Controls.Add(tableLayoutPanel1);
            TablePanel.Dock = DockStyle.Fill;
            TablePanel.Location = new Point(30, 54);
            TablePanel.Name = "TablePanel";
            TablePanel.Padding = new Padding(0, 0, 0, 40);
            TablePanel.Size = new Size(1500, 621);
            TablePanel.TabIndex = 22;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.13333F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 82.86667F));
            tableLayoutPanel1.Controls.Add(idVechi_tb, 1, 1);
            tableLayoutPanel1.Controls.Add(label7, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(idCarte_tb, 1, 0);
            tableLayoutPanel1.Controls.Add(label8, 0, 7);
            tableLayoutPanel1.Controls.Add(pret_tb, 1, 7);
            tableLayoutPanel1.Controls.Add(label5, 0, 6);
            tableLayoutPanel1.Controls.Add(idCZU_tb, 1, 6);
            tableLayoutPanel1.Controls.Add(label3, 0, 5);
            tableLayoutPanel1.Controls.Add(locPublicare_tb, 1, 5);
            tableLayoutPanel1.Controls.Add(label6, 0, 4);
            tableLayoutPanel1.Controls.Add(anPublicare_tb, 1, 4);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(autor_tb, 1, 3);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(titlu_tb, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 74F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1500, 581);
            tableLayoutPanel1.TabIndex = 21;
            // 
            // idVechi_tb
            // 
            idVechi_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            idVechi_tb.BackColor = Color.FromArgb(54, 54, 54);
            idVechi_tb.BorderStyle = BorderStyle.FixedSingle;
            idVechi_tb.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            idVechi_tb.ForeColor = Color.White;
            idVechi_tb.Location = new Point(259, 89);
            idVechi_tb.Name = "idVechi_tb";
            idVechi_tb.Size = new Size(1238, 38);
            idVechi_tb.TabIndex = 2;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label7.Location = new Point(3, 92);
            label7.Name = "label7";
            label7.Size = new Size(102, 31);
            label7.TabIndex = 9;
            label7.Text = "ID Vechi";
            label7.TextAlign = ContentAlignment.MiddleRight;
            label7.Click += label7_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 20);
            label1.Name = "label1";
            label1.Size = new Size(101, 31);
            label1.TabIndex = 0;
            label1.Text = "ID Carte";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // idCarte_tb
            // 
            idCarte_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            idCarte_tb.BackColor = Color.FromArgb(54, 54, 54);
            idCarte_tb.BorderStyle = BorderStyle.FixedSingle;
            idCarte_tb.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            idCarte_tb.ForeColor = Color.White;
            idCarte_tb.Location = new Point(259, 17);
            idCarte_tb.Name = "idCarte_tb";
            idCarte_tb.Size = new Size(1238, 38);
            idCarte_tb.TabIndex = 1;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label8.Location = new Point(3, 527);
            label8.Name = "label8";
            label8.Size = new Size(58, 31);
            label8.TabIndex = 0;
            label8.Text = "Preț";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pret_tb
            // 
            pret_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pret_tb.BackColor = Color.FromArgb(54, 54, 54);
            pret_tb.BorderStyle = BorderStyle.FixedSingle;
            pret_tb.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            pret_tb.ForeColor = Color.White;
            pret_tb.Location = new Point(259, 523);
            pret_tb.Name = "pret_tb";
            pret_tb.Size = new Size(1238, 38);
            pret_tb.TabIndex = 8;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label5.Location = new Point(3, 452);
            label5.Name = "label5";
            label5.Size = new Size(83, 31);
            label5.TabIndex = 0;
            label5.Text = "ID Czu";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // idCZU_tb
            // 
            idCZU_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            idCZU_tb.BackColor = Color.FromArgb(54, 54, 54);
            idCZU_tb.BorderStyle = BorderStyle.FixedSingle;
            idCZU_tb.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            idCZU_tb.ForeColor = Color.White;
            idCZU_tb.Location = new Point(259, 449);
            idCZU_tb.Name = "idCZU_tb";
            idCZU_tb.Size = new Size(1238, 38);
            idCZU_tb.TabIndex = 7;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label3.Location = new Point(3, 380);
            label3.Name = "label3";
            label3.Size = new Size(180, 31);
            label3.TabIndex = 0;
            label3.Text = "Locul publicării";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // locPublicare_tb
            // 
            locPublicare_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            locPublicare_tb.BackColor = Color.FromArgb(54, 54, 54);
            locPublicare_tb.BorderStyle = BorderStyle.FixedSingle;
            locPublicare_tb.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            locPublicare_tb.ForeColor = Color.White;
            locPublicare_tb.Location = new Point(259, 377);
            locPublicare_tb.Name = "locPublicare_tb";
            locPublicare_tb.Size = new Size(1238, 38);
            locPublicare_tb.TabIndex = 6;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label6.Location = new Point(3, 308);
            label6.Name = "label6";
            label6.Size = new Size(173, 31);
            label6.TabIndex = 0;
            label6.Text = "Anul publicării";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // anPublicare_tb
            // 
            anPublicare_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            anPublicare_tb.BackColor = Color.FromArgb(54, 54, 54);
            anPublicare_tb.BorderStyle = BorderStyle.FixedSingle;
            anPublicare_tb.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            anPublicare_tb.ForeColor = Color.White;
            anPublicare_tb.Location = new Point(259, 305);
            anPublicare_tb.Name = "anPublicare_tb";
            anPublicare_tb.Size = new Size(1238, 38);
            anPublicare_tb.TabIndex = 5;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label4.Location = new Point(3, 236);
            label4.Name = "label4";
            label4.Size = new Size(76, 31);
            label4.TabIndex = 0;
            label4.Text = "Autor";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // autor_tb
            // 
            autor_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            autor_tb.BackColor = Color.FromArgb(54, 54, 54);
            autor_tb.BorderStyle = BorderStyle.FixedSingle;
            autor_tb.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            autor_tb.ForeColor = Color.White;
            autor_tb.Location = new Point(259, 233);
            autor_tb.Name = "autor_tb";
            autor_tb.Size = new Size(1238, 38);
            autor_tb.TabIndex = 4;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 164);
            label2.Name = "label2";
            label2.Size = new Size(64, 31);
            label2.TabIndex = 0;
            label2.Text = "Titlu";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // titlu_tb
            // 
            titlu_tb.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            titlu_tb.BackColor = Color.FromArgb(54, 54, 54);
            titlu_tb.BorderStyle = BorderStyle.FixedSingle;
            titlu_tb.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            titlu_tb.ForeColor = Color.White;
            titlu_tb.Location = new Point(259, 161);
            titlu_tb.Name = "titlu_tb";
            titlu_tb.Size = new Size(1238, 38);
            titlu_tb.TabIndex = 3;
            // 
            // adaugaCarte_btn
            // 
            adaugaCarte_btn.BackColor = Color.FromArgb(54, 54, 54);
            adaugaCarte_btn.Dock = DockStyle.Bottom;
            adaugaCarte_btn.FlatStyle = FlatStyle.Flat;
            adaugaCarte_btn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            adaugaCarte_btn.ForeColor = Color.LightGray;
            adaugaCarte_btn.IconChar = FontAwesome.Sharp.IconChar.None;
            adaugaCarte_btn.IconColor = Color.Black;
            adaugaCarte_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            adaugaCarte_btn.Location = new Point(30, 675);
            adaugaCarte_btn.Name = "adaugaCarte_btn";
            adaugaCarte_btn.Size = new Size(1500, 86);
            adaugaCarte_btn.TabIndex = 9;
            adaugaCarte_btn.Text = "Adaugă carte";
            adaugaCarte_btn.UseVisualStyleBackColor = false;
            adaugaCarte_btn.Click += adaugaCarte_btn_Click;
            // 
            // AddForm
            // 
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1660, 930);
            Controls.Add(base_panel);
            Controls.Add(panel1);
            ForeColor = Color.White;
            Name = "AddForm";
            Load += AddForm_Load;
            base_panel.ResumeLayout(false);
            main_panel.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            TablePanel.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel base_panel;
        private Panel main_panel;
        private GroupBox groupBox1;
        private TextBox idCarte_tb;
        private TextBox idCZU_tb;
        private Label label5;
        private TextBox autor_tb;
        private Label label6;
        private TextBox titlu_tb;
        private Label label3;
        private TextBox locPublicare_tb;
        private Label label4;
        private TextBox anPublicare_tb;
        private Label label2;
        private Label label1;
        private FontAwesome.Sharp.IconButton adaugaCarte_btn;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel TablePanel;
        private Label label8;
        private TextBox pret_tb;
        private Label label7;
        private TextBox idVechi_tb;
    }
}