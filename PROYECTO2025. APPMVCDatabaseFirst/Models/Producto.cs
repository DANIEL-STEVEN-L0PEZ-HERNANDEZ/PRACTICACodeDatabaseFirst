﻿using System;
using System.Collections.Generic;

namespace PROYECTO2025._APPMVCDatabaseFirst.Models;

public partial class Producto
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Descripcion { get; set; }

    public decimal Precio { get; set; }

    public int Stock { get; set; }
}
