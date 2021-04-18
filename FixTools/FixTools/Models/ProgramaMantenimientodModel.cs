using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FixTools.Models
{
    public class ProgramaMantenimientodModel
    {
        public string Zona { get; set; }
        public IEnumerable<SelectListItem> ListZonas { get; set; }
        public string EquipoEspecial { get; set; }
        public IEnumerable<SelectListItem> ListEquiposEspeciales { get; set; }
        public ProgramaMantenimientodModel() {

            ListZonas = new List<SelectListItem>();
            ListEquiposEspeciales = new List<SelectListItem>();

            List<SelectListItem> lst = new List<SelectListItem>();
            SelectListItem item;

            item = new SelectListItem
            {
                Value = "1",
                Text = "Apartamento"
            };
            lst.Add(item);

            item = new SelectListItem
            {
                Value = "2",
                Text = "Zona Común"
            };
            lst.Add(item);

            item = new SelectListItem
            {
                Value = "3",
                Text = "Piso"
            };
            lst.Add(item);

            ListZonas = lst.ToList();

            lst = new List<SelectListItem>();
            item = new SelectListItem
            {
                Value = "1",
                Text = "Grua"
            };
            lst.Add(item);

            item = new SelectListItem
            {
                Value = "2",
                Text = "Mezcladora"
            };
            lst.Add(item);

            item = new SelectListItem
            {
                Value = "3",
                Text = "Retroexcavadora"
            };
            lst.Add(item);
            ListEquiposEspeciales = lst.ToList();
        }
    }
}