using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
namespace ControlMED
{
    internal class InventarioItem
    {
        public int IdInventario { get; set; }
        public int IdSucursal { get; set; }
        public string NombreSucursal { get; set; } = string.Empty;
        public int IdMedicamento { get; set; }
        public string NombreMedicamento { get; set; } = string.Empty;
        public int Existencia { get; set; }
    }
}
