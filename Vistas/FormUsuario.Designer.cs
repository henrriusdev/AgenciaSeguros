﻿namespace AgenciaSeguros.Vistas
{
  partial class FormUsuario
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
      this.button11 = new System.Windows.Forms.Button();
      this.toolTip = new System.Windows.Forms.ToolTip(this.components);
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.polizasPage = new System.Windows.Forms.TabPage();
      this.polizasData = new System.Windows.Forms.DataGridView();
      this.label5 = new System.Windows.Forms.Label();
      this.clientesPage = new System.Windows.Forms.TabPage();
      this.clientesData = new System.Windows.Forms.DataGridView();
      this.label4 = new System.Windows.Forms.Label();
      this.pagosPage = new System.Windows.Forms.TabPage();
      this.pagosData = new System.Windows.Forms.DataGridView();
      this.label6 = new System.Windows.Forms.Label();
      this.reclamosPage = new System.Windows.Forms.TabPage();
      this.reclamosData = new System.Windows.Forms.DataGridView();
      this.label7 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.button4 = new System.Windows.Forms.Button();
      this.button5 = new System.Windows.Forms.Button();
      this.button6 = new System.Windows.Forms.Button();
      this.button7 = new System.Windows.Forms.Button();
      this.button8 = new System.Windows.Forms.Button();
      this.button10 = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.button12 = new System.Windows.Forms.Button();
      this.button9 = new System.Windows.Forms.Button();
      this.tabPage7 = new System.Windows.Forms.TabPage();
      this.tabControl1.SuspendLayout();
      this.polizasPage.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.polizasData)).BeginInit();
      this.clientesPage.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.clientesData)).BeginInit();
      this.pagosPage.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pagosData)).BeginInit();
      this.reclamosPage.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.reclamosData)).BeginInit();
      this.tabPage7.SuspendLayout();
      this.SuspendLayout();
      // 
      // button11
      // 
      this.button11.BackColor = System.Drawing.Color.DodgerBlue;
      this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button11.Location = new System.Drawing.Point(541, 538);
      this.button11.Margin = new System.Windows.Forms.Padding(2);
      this.button11.Name = "button11";
      this.button11.Size = new System.Drawing.Size(109, 25);
      this.button11.TabIndex = 11;
      this.button11.Text = "Registrar nuevo";
      this.button11.UseVisualStyleBackColor = false;
      this.button11.Click += new System.EventHandler(this.button11_Click);
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPage7);
      this.tabControl1.Controls.Add(this.polizasPage);
      this.tabControl1.Controls.Add(this.clientesPage);
      this.tabControl1.Controls.Add(this.pagosPage);
      this.tabControl1.Controls.Add(this.reclamosPage);
      this.tabControl1.Location = new System.Drawing.Point(-3, 2);
      this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(897, 570);
      this.tabControl1.TabIndex = 8;
      this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
      // 
      // polizasPage
      // 
      this.polizasPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(238)))), ((int)(((byte)(251)))));
      this.polizasPage.Controls.Add(this.label5);
      this.polizasPage.Controls.Add(this.polizasData);
      this.polizasPage.Location = new System.Drawing.Point(4, 22);
      this.polizasPage.Margin = new System.Windows.Forms.Padding(2);
      this.polizasPage.Name = "polizasPage";
      this.polizasPage.Padding = new System.Windows.Forms.Padding(2);
      this.polizasPage.Size = new System.Drawing.Size(889, 544);
      this.polizasPage.TabIndex = 1;
      this.polizasPage.Text = "Pólizas";
      // 
      // polizasData
      // 
      this.polizasData.AllowUserToAddRows = false;
      this.polizasData.AllowUserToDeleteRows = false;
      this.polizasData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(238)))), ((int)(((byte)(251)))));
      this.polizasData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.polizasData.Cursor = System.Windows.Forms.Cursors.Default;
      this.polizasData.Location = new System.Drawing.Point(25, 35);
      this.polizasData.Margin = new System.Windows.Forms.Padding(2);
      this.polizasData.MultiSelect = false;
      this.polizasData.Name = "polizasData";
      this.polizasData.ReadOnly = true;
      this.polizasData.RowHeadersVisible = false;
      this.polizasData.RowHeadersWidth = 62;
      this.polizasData.RowTemplate.Height = 28;
      this.polizasData.ShowEditingIcon = false;
      this.polizasData.ShowRowErrors = false;
      this.polizasData.Size = new System.Drawing.Size(843, 463);
      this.polizasData.TabIndex = 4;
      this.polizasData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.polizasData_CellContentClick);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(47, 12);
      this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(40, 13);
      this.label5.TabIndex = 5;
      this.label5.Text = "Pólizas";
      // 
      // clientesPage
      // 
      this.clientesPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(238)))), ((int)(((byte)(251)))));
      this.clientesPage.Controls.Add(this.label4);
      this.clientesPage.Controls.Add(this.clientesData);
      this.clientesPage.Location = new System.Drawing.Point(4, 22);
      this.clientesPage.Margin = new System.Windows.Forms.Padding(2);
      this.clientesPage.Name = "clientesPage";
      this.clientesPage.Padding = new System.Windows.Forms.Padding(2);
      this.clientesPage.Size = new System.Drawing.Size(889, 544);
      this.clientesPage.TabIndex = 2;
      this.clientesPage.Text = "Clientes";
      // 
      // clientesData
      // 
      this.clientesData.AllowUserToAddRows = false;
      this.clientesData.AllowUserToDeleteRows = false;
      this.clientesData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(238)))), ((int)(((byte)(251)))));
      this.clientesData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.clientesData.Cursor = System.Windows.Forms.Cursors.Default;
      this.clientesData.Location = new System.Drawing.Point(25, 35);
      this.clientesData.Margin = new System.Windows.Forms.Padding(2);
      this.clientesData.MultiSelect = false;
      this.clientesData.Name = "clientesData";
      this.clientesData.ReadOnly = true;
      this.clientesData.RowHeadersVisible = false;
      this.clientesData.RowHeadersWidth = 62;
      this.clientesData.RowTemplate.Height = 28;
      this.clientesData.ShowEditingIcon = false;
      this.clientesData.ShowRowErrors = false;
      this.clientesData.Size = new System.Drawing.Size(843, 463);
      this.clientesData.TabIndex = 2;
      this.clientesData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientesData_CellContentClick);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(47, 12);
      this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(44, 13);
      this.label4.TabIndex = 3;
      this.label4.Text = "Clientes";
      // 
      // pagosPage
      // 
      this.pagosPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(238)))), ((int)(((byte)(251)))));
      this.pagosPage.Controls.Add(this.label6);
      this.pagosPage.Controls.Add(this.pagosData);
      this.pagosPage.Location = new System.Drawing.Point(4, 22);
      this.pagosPage.Margin = new System.Windows.Forms.Padding(2);
      this.pagosPage.Name = "pagosPage";
      this.pagosPage.Padding = new System.Windows.Forms.Padding(2);
      this.pagosPage.Size = new System.Drawing.Size(889, 544);
      this.pagosPage.TabIndex = 3;
      this.pagosPage.Text = "Pagos";
      // 
      // pagosData
      // 
      this.pagosData.AllowUserToAddRows = false;
      this.pagosData.AllowUserToDeleteRows = false;
      this.pagosData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(238)))), ((int)(((byte)(251)))));
      this.pagosData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.pagosData.Cursor = System.Windows.Forms.Cursors.Default;
      this.pagosData.Location = new System.Drawing.Point(21, 27);
      this.pagosData.Margin = new System.Windows.Forms.Padding(2);
      this.pagosData.MultiSelect = false;
      this.pagosData.Name = "pagosData";
      this.pagosData.ReadOnly = true;
      this.pagosData.RowHeadersVisible = false;
      this.pagosData.RowHeadersWidth = 62;
      this.pagosData.RowTemplate.Height = 28;
      this.pagosData.ShowEditingIcon = false;
      this.pagosData.ShowRowErrors = false;
      this.pagosData.Size = new System.Drawing.Size(843, 463);
      this.pagosData.TabIndex = 4;
      this.pagosData.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.pagosData_CellContentDoubleClick);
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(47, 12);
      this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(37, 13);
      this.label6.TabIndex = 5;
      this.label6.Text = "Pagos";
      // 
      // reclamosPage
      // 
      this.reclamosPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(238)))), ((int)(((byte)(251)))));
      this.reclamosPage.Controls.Add(this.label7);
      this.reclamosPage.Controls.Add(this.reclamosData);
      this.reclamosPage.Location = new System.Drawing.Point(4, 22);
      this.reclamosPage.Margin = new System.Windows.Forms.Padding(2);
      this.reclamosPage.Name = "reclamosPage";
      this.reclamosPage.Padding = new System.Windows.Forms.Padding(2);
      this.reclamosPage.Size = new System.Drawing.Size(889, 544);
      this.reclamosPage.TabIndex = 4;
      this.reclamosPage.Text = "Reclamos";
      // 
      // reclamosData
      // 
      this.reclamosData.AllowUserToAddRows = false;
      this.reclamosData.AllowUserToDeleteRows = false;
      this.reclamosData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(238)))), ((int)(((byte)(251)))));
      this.reclamosData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.reclamosData.Cursor = System.Windows.Forms.Cursors.Default;
      this.reclamosData.Location = new System.Drawing.Point(25, 35);
      this.reclamosData.Margin = new System.Windows.Forms.Padding(2);
      this.reclamosData.MultiSelect = false;
      this.reclamosData.Name = "reclamosData";
      this.reclamosData.ReadOnly = true;
      this.reclamosData.RowHeadersVisible = false;
      this.reclamosData.RowHeadersWidth = 62;
      this.reclamosData.RowTemplate.Height = 28;
      this.reclamosData.ShowEditingIcon = false;
      this.reclamosData.ShowRowErrors = false;
      this.reclamosData.Size = new System.Drawing.Size(843, 463);
      this.reclamosData.TabIndex = 6;
      this.reclamosData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.reclamosData_CellContentDoubleClick);
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(47, 12);
      this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(54, 13);
      this.label7.TabIndex = 7;
      this.label7.Text = "Reclamos";
      // 
      // button1
      // 
      this.button1.BackColor = System.Drawing.Color.PaleVioletRed;
      this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button1.Location = new System.Drawing.Point(773, 538);
      this.button1.Margin = new System.Windows.Forms.Padding(2);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(109, 25);
      this.button1.TabIndex = 9;
      this.button1.Text = "Cerrar sesión";
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // button2
      // 
      this.button2.BackColor = System.Drawing.Color.DodgerBlue;
      this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button2.Location = new System.Drawing.Point(660, 538);
      this.button2.Margin = new System.Windows.Forms.Padding(2);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(109, 25);
      this.button2.TabIndex = 10;
      this.button2.Text = "Volver al inicio";
      this.button2.UseVisualStyleBackColor = false;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(119, 53);
      this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(104, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Operaciones rápidas";
      // 
      // button4
      // 
      this.button4.BackColor = System.Drawing.Color.LightGreen;
      this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button4.Location = new System.Drawing.Point(179, 112);
      this.button4.Margin = new System.Windows.Forms.Padding(2);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(121, 30);
      this.button4.TabIndex = 2;
      this.button4.Text = "Registrar póliza";
      this.button4.UseVisualStyleBackColor = false;
      this.button4.Click += new System.EventHandler(this.button4_Click);
      // 
      // button5
      // 
      this.button5.BackColor = System.Drawing.Color.LightGreen;
      this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button5.Location = new System.Drawing.Point(313, 112);
      this.button5.Margin = new System.Windows.Forms.Padding(2);
      this.button5.Name = "button5";
      this.button5.Size = new System.Drawing.Size(121, 30);
      this.button5.TabIndex = 3;
      this.button5.Text = "Registrar pago";
      this.button5.UseVisualStyleBackColor = false;
      this.button5.Click += new System.EventHandler(this.button5_Click);
      // 
      // button6
      // 
      this.button6.BackColor = System.Drawing.Color.LightGreen;
      this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button6.Location = new System.Drawing.Point(41, 112);
      this.button6.Margin = new System.Windows.Forms.Padding(2);
      this.button6.Name = "button6";
      this.button6.Size = new System.Drawing.Size(121, 30);
      this.button6.TabIndex = 4;
      this.button6.Text = "Registrar reclamo";
      this.button6.UseVisualStyleBackColor = false;
      this.button6.Click += new System.EventHandler(this.button6_Click);
      // 
      // button7
      // 
      this.button7.BackColor = System.Drawing.Color.LightGreen;
      this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button7.Location = new System.Drawing.Point(179, 170);
      this.button7.Margin = new System.Windows.Forms.Padding(2);
      this.button7.Name = "button7";
      this.button7.Size = new System.Drawing.Size(121, 30);
      this.button7.TabIndex = 5;
      this.button7.Text = "Registrar cliente";
      this.button7.UseVisualStyleBackColor = false;
      this.button7.Click += new System.EventHandler(this.button7_Click);
      // 
      // button8
      // 
      this.button8.BackColor = System.Drawing.Color.LightGreen;
      this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button8.Location = new System.Drawing.Point(313, 170);
      this.button8.Margin = new System.Windows.Forms.Padding(2);
      this.button8.Name = "button8";
      this.button8.Size = new System.Drawing.Size(121, 30);
      this.button8.TabIndex = 6;
      this.button8.Text = "Ver pólizas";
      this.button8.UseVisualStyleBackColor = false;
      this.button8.Click += new System.EventHandler(this.button8_Click);
      // 
      // button10
      // 
      this.button10.BackColor = System.Drawing.Color.LightGreen;
      this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button10.Location = new System.Drawing.Point(41, 170);
      this.button10.Margin = new System.Windows.Forms.Padding(2);
      this.button10.Name = "button10";
      this.button10.Size = new System.Drawing.Size(121, 30);
      this.button10.TabIndex = 8;
      this.button10.Text = "Ver clientes";
      this.button10.UseVisualStyleBackColor = false;
      this.button10.Click += new System.EventHandler(this.button10_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(659, 53);
      this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(50, 13);
      this.label2.TabIndex = 9;
      this.label2.Text = "Reportes";
      // 
      // button12
      // 
      this.button12.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.button12.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.button12.BackColor = System.Drawing.Color.LightGreen;
      this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button12.Location = new System.Drawing.Point(661, 113);
      this.button12.Margin = new System.Windows.Forms.Padding(0);
      this.button12.Name = "button12";
      this.button12.Size = new System.Drawing.Size(142, 58);
      this.button12.TabIndex = 10;
      this.button12.Text = "Reportes de Pólizas";
      this.button12.UseVisualStyleBackColor = false;
      // 
      // button9
      // 
      this.button9.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.button9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.button9.BackColor = System.Drawing.Color.LightGreen;
      this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button9.Location = new System.Drawing.Point(661, 210);
      this.button9.Margin = new System.Windows.Forms.Padding(0);
      this.button9.Name = "button9";
      this.button9.Size = new System.Drawing.Size(142, 61);
      this.button9.TabIndex = 11;
      this.button9.Text = "Reportes de datos";
      this.button9.UseVisualStyleBackColor = false;
      // 
      // tabPage7
      // 
      this.tabPage7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(238)))), ((int)(((byte)(251)))));
      this.tabPage7.CausesValidation = false;
      this.tabPage7.Controls.Add(this.button9);
      this.tabPage7.Controls.Add(this.button12);
      this.tabPage7.Controls.Add(this.label2);
      this.tabPage7.Controls.Add(this.button10);
      this.tabPage7.Controls.Add(this.button8);
      this.tabPage7.Controls.Add(this.button7);
      this.tabPage7.Controls.Add(this.button6);
      this.tabPage7.Controls.Add(this.button5);
      this.tabPage7.Controls.Add(this.button4);
      this.tabPage7.Controls.Add(this.label1);
      this.tabPage7.Location = new System.Drawing.Point(4, 22);
      this.tabPage7.Margin = new System.Windows.Forms.Padding(2);
      this.tabPage7.Name = "tabPage7";
      this.tabPage7.Padding = new System.Windows.Forms.Padding(2);
      this.tabPage7.Size = new System.Drawing.Size(889, 544);
      this.tabPage7.TabIndex = 6;
      this.tabPage7.Text = "Inicio";
      // 
      // FormUsuario
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(891, 565);
      this.Controls.Add(this.button11);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.tabControl1);
      this.Name = "FormUsuario";
      this.Text = "Inicio del usuario";
      this.tabControl1.ResumeLayout(false);
      this.polizasPage.ResumeLayout(false);
      this.polizasPage.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.polizasData)).EndInit();
      this.clientesPage.ResumeLayout(false);
      this.clientesPage.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.clientesData)).EndInit();
      this.pagosPage.ResumeLayout(false);
      this.pagosPage.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pagosData)).EndInit();
      this.reclamosPage.ResumeLayout(false);
      this.reclamosPage.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.reclamosData)).EndInit();
      this.tabPage7.ResumeLayout(false);
      this.tabPage7.PerformLayout();
      this.ResumeLayout(false);

    }
    #endregion

    private System.Windows.Forms.Button button11;
    private System.Windows.Forms.ToolTip toolTip;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage7;
    private System.Windows.Forms.Button button9;
    private System.Windows.Forms.Button button12;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button button10;
    private System.Windows.Forms.Button button8;
    private System.Windows.Forms.Button button7;
    private System.Windows.Forms.Button button6;
    private System.Windows.Forms.Button button5;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TabPage polizasPage;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.DataGridView polizasData;
    private System.Windows.Forms.TabPage clientesPage;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.DataGridView clientesData;
    private System.Windows.Forms.TabPage pagosPage;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.DataGridView pagosData;
    private System.Windows.Forms.TabPage reclamosPage;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.DataGridView reclamosData;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
  }
}



