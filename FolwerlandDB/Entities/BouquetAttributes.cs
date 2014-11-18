using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace FolwerLandBase
{
    [ComplexType]
  public class BouqetAttributes
    {
        public decimal VasePrice { get; set; }
        public Color VaseColor { get; set; }
        public decimal GridlePrice { get; set; }
        public Color GridleColor { get; set; }
    }

 public enum Color
    {
        transparent = 0,
        white,
        red,
        green,
        yellow,
        blue,
        pink
    }
}
