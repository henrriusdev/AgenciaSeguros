﻿namespace AgenciaSeguros.Vistas.Componentes
{
  partial class Pagos
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
      this.clienteCombobox = new System.Windows.Forms.ComboBox();
      this.fechaRealizado = new System.Windows.Forms.DateTimePicker();
      this.label13 = new System.Windows.Forms.Label();
      this.label11 = new System.Windows.Forms.Label();
      this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
      this.montoNum = new System.Windows.Forms.NumericUpDown();
      this.label10 = new System.Windows.Forms.Label();
      this.button2 = new System.Windows.Forms.Button();
      this.btnGuardar = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.descripcionText = new System.Windows.Forms.TextBox();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.montoNum)).BeginInit();
      this.SuspendLayout();
      // 
      // clienteCombobox
      // 
      this.clienteCombobox.FormattingEnabled = true;
      this.clienteCombobox.Location = new System.Drawing.Point(429, 153);
      this.clienteCombobox.Name = "clienteCombobox";
      this.clienteCombobox.Size = new System.Drawing.Size(173, 28);
      this.clienteCombobox.TabIndex = 104;
      // 
      // fechaRealizado
      // 
      this.fechaRealizado.CustomFormat = "dd/MM/yyyy";
      this.fechaRealizado.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.fechaRealizado.Location = new System.Drawing.Point(60, 155);
      this.fechaRealizado.MaxDate = new System.DateTime(2024, 7, 16, 0, 0, 0, 0);
      this.fechaRealizado.MinDate = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
      this.fechaRealizado.Name = "fechaRealizado";
      this.fechaRealizado.Size = new System.Drawing.Size(149, 26);
      this.fechaRealizado.TabIndex = 99;
      this.fechaRealizado.Value = new System.DateTime(2024, 7, 16, 0, 0, 0, 0);
      // 
      // label13
      // 
      this.label13.AutoSize = true;
      this.label13.Location = new System.Drawing.Point(56, 123);
      this.label13.Name = "label13";
      this.label13.Size = new System.Drawing.Size(122, 20);
      this.label13.TabIndex = 98;
      this.label13.Text = "Fecha realizado";
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Location = new System.Drawing.Point(425, 123);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(58, 20);
      this.label11.TabIndex = 96;
      this.label11.Text = "Cliente";
      // 
      // errorProvider1
      // 
      this.errorProvider1.ContainerControl = this;
      // 
      // montoNum
      // 
      this.montoNum.DecimalPlaces = 2;
      this.montoNum.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
      this.montoNum.Location = new System.Drawing.Point(249, 155);
      this.montoNum.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
      this.montoNum.Name = "montoNum";
      this.montoNum.Size = new System.Drawing.Size(132, 26);
      this.montoNum.TabIndex = 106;
      this.montoNum.ThousandsSeparator = true;
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Location = new System.Drawing.Point(245, 123);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(54, 20);
      this.label10.TabIndex = 95;
      this.label10.Text = "Monto";
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(442, 235);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(160, 43);
      this.button2.TabIndex = 86;
      this.button2.Text = "Cancelar";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // btnGuardar
      // 
      this.btnGuardar.Location = new System.Drawing.Point(442, 305);
      this.btnGuardar.Name = "btnGuardar";
      this.btnGuardar.Size = new System.Drawing.Size(160, 43);
      this.btnGuardar.TabIndex = 85;
      this.btnGuardar.Text = "Guardar";
      this.btnGuardar.UseVisualStyleBackColor = true;
      this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(266, 49);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(114, 20);
      this.label1.TabIndex = 81;
      this.label1.Text = "Registrar pago";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(56, 202);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(92, 20);
      this.label2.TabIndex = 108;
      this.label2.Text = "Descripción";
      // 
      // descripcionText
      // 
      this.descripcionText.Location = new System.Drawing.Point(60, 235);
      this.descripcionText.Multiline = true;
      this.descripcionText.Name = "descripcionText";
      this.descripcionText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.descripcionText.Size = new System.Drawing.Size(357, 113);
      this.descripcionText.TabIndex = 107;
      // 
      // Pagos
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(661, 419);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.descripcionText);
      this.Controls.Add(this.clienteCombobox);
      this.Controls.Add(this.fechaRealizado);
      this.Controls.Add(this.label13);
      this.Controls.Add(this.label11);
      this.Controls.Add(this.montoNum);
      this.Controls.Add(this.label10);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.btnGuardar);
      this.Controls.Add(this.label1);
      this.Name = "Pagos";
      this.Text = "Pagos";
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.montoNum)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.ComboBox clienteCombobox;
    private System.Windows.Forms.DateTimePicker fechaRealizado;
    private System.Windows.Forms.Label label13;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.ErrorProvider errorProvider1;
    private System.Windows.Forms.NumericUpDown montoNum;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button btnGuardar;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox descripcionText;
  }
}