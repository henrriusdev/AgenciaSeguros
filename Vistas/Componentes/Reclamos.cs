﻿using AgenciaSeguros.Datos;
using AgenciaSeguros.Entidades;
using System;
using System.Linq;
using System.Windows.Forms;

namespace AgenciaSeguros.Vistas.Componentes
{
  public partial class Reclamos : Form
  {
    private int? _reclamoId;
    public Reclamos(int? reclamoId)
    {
      InitializeComponent();
      _reclamoId = reclamoId;
      if (_reclamoId.HasValue)
      {
        label1.Text = "Editar reclamo";
        this.Text = $"Editar Reclamo #{_reclamoId.Value}";
      }
      else
      {
        this.Text = "Nuevo reclamo";
      }
      LoadReclamoData();

      estadoCombobox.SelectedValueChanged += (s, e) => ValidateForm();
      polizasCombobox.SelectedValueChanged += (s, e) => ValidateForm();
      clienteCombobox.SelectedValueChanged += (s, e) => ValidateForm();
      descripcionText.TextChanged += (s, e) => ValidateForm();

      btnGuardar.Enabled = false;
    }

    private void LoadReclamoData()
    {
      using (var context = new AppDbContext())
      {
        // Cargar el combobox con los clientes, mostrando el nombre y el id debe ser el valor
        clienteCombobox.DataSource = context.Clientes.Select(c => new
        {
          c.Id,
          c.Nombre
        }).ToList();
        clienteCombobox.DisplayMember = "Nombre";
        clienteCombobox.ValueMember = "Id";

        if (!_reclamoId.HasValue)
        {
          return;
        }

        var reclamo = context.Reclamos.Find(_reclamoId.Value);
        if (reclamo != null)
        {
          estadoCombobox.SelectedItem = reclamo.Estado;
          clienteCombobox.SelectedValue = reclamo.ClienteId;
          polizasCombobox.SelectedValue = reclamo.PolizaId;
          descripcionText.Text = reclamo.Descripcion;

          // Cargar las pólizas del cliente seleccionado
          var clienteId = reclamo.ClienteId;
          polizasCombobox.DataSource = context.Polizas
              .Where(p => p.ClienteId == clienteId)
              .ToList()
              .Select(p => new
              {
                p.Id,
                Text = $"{p.Marca} {p.Modelo} {p.Anio} {p.Placa}"
              }).ToList();
          polizasCombobox.DisplayMember = "Text";
          polizasCombobox.ValueMember = "Id";
          polizasCombobox.SelectedValue = reclamo.PolizaId;
        }
      }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
      using (var context = new AppDbContext())
      {
        if (_reclamoId.HasValue)
        {
          var reclamo = context.Reclamos.Find(_reclamoId.Value);
          reclamo.Estado = estadoCombobox.SelectedItem.ToString();
          reclamo.ClienteId = (int)clienteCombobox.SelectedValue;
          reclamo.PolizaId = (int)polizasCombobox.SelectedValue;
          reclamo.Descripcion = descripcionText.Text;
        }
        else
        {
          var reclamo = new Reclamo()
          {
            Descripcion = descripcionText.Text,
            FechaReclamo = DateTime.Now,
            Estado = estadoCombobox.SelectedItem.ToString(),
            ClienteId = (int)clienteCombobox.SelectedValue,
            PolizaId = (int)polizasCombobox.SelectedValue
          };

          context.Reclamos.Add(reclamo);
        }

        context.SaveChanges();
      }

      this.Close();
    }

    private void ValidateForm()
    {
      bool descripcionValida = !string.IsNullOrEmpty(descripcionText.Text) && descripcionText.Text.Length <= 200;
      bool clienteValido = clienteCombobox.SelectedValue != null;
      bool estadoValido = estadoCombobox.SelectedItem != null;
      bool polizaValida = polizasCombobox.SelectedValue != null;

      btnGuardar.Enabled = descripcionValida && clienteValido && estadoValido && polizaValida;

      if (!clienteValido)
      {
        errorProvider1.SetError(clienteCombobox, "El cliente es requerido");
      }
      else
      {
        errorProvider1.SetError(clienteCombobox, "");

        // Encontrar todas las pólizas del cliente seleccionado, mostrando como texto la unión entre la marca, modelo, año y placa
        using (var context = new AppDbContext())
        {
          var clienteId = (int)clienteCombobox.SelectedValue;
          var polizas = context.Polizas
              .Where(p => p.ClienteId == clienteId)
              .ToList()
              .Select(p => new
              {
                p.Id,
                Text = $"{p.Marca} {p.Modelo} {p.Anio} {p.Placa}"
              }).ToList();

          polizasCombobox.DataSource = polizas;
          polizasCombobox.DisplayMember = "Text";
          polizasCombobox.ValueMember = "Id";

          if (polizas.Count > 0)
          {
            polizasCombobox.SelectedValue = polizas.First().Id;

            polizaValida = polizasCombobox.SelectedValue != null;

            btnGuardar.Enabled = descripcionValida && clienteValido && estadoValido && polizaValida;
          }
          else
          {
            errorProvider1.SetError(polizasCombobox, "El cliente seleccionado no tiene pólizas.");
          }
        }
      }

      if (!descripcionValida)
      {
        errorProvider1.SetError(descripcionText, "La descripción es requerida y debe tener menos de 200 caracteres");
      }
      else
      {
        errorProvider1.SetError(descripcionText, "");
      }

      if (!estadoValido)
      {
        errorProvider1.SetError(estadoCombobox, "El estado es requerido");
      }
      else
      {
        errorProvider1.SetError(estadoCombobox, "");
      }

      if (!polizaValida)
      {
        errorProvider1.SetError(polizasCombobox, "La póliza es requerida");
      }
      else
      {
        errorProvider1.SetError(polizasCombobox, "");
      }
    }
  }
}
