using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ControlMED
{
    internal abstract class EntidadNombrada
    {
        public string Nombre { get; set; } = string.Empty;

        public override string ToString()
        {
            return Nombre;
        }
    }
}
