namespace Servico
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CentralAlarme")]
    public partial class CentralAlarme
    {
        public int id { get; set; }

        [StringLength(150)]
        public string usuario { get; set; }

        [StringLength(80)]
        public string senha { get; set; }

        [StringLength(150)]
        public string idCentral { get; set; }

        [StringLength(50)]
        public string jalogado { get; set; }

        [StringLength(50)]
        public string alterou { get; set; }

        [StringLength(170)]
        public string diasParaUso { get; set; }

        [StringLength(50)]
        public string bloqueioUsuario { get; set; }

        [StringLength(80)]
        public string bateria { get; set; }

        [StringLength(150)]
        public string zona1 { get; set; }

        [StringLength(150)]
        public string zona2 { get; set; }

        [StringLength(150)]
        public string zona3 { get; set; }

        [StringLength(150)]
        public string zona4 { get; set; }

        [StringLength(150)]
        public string zona5 { get; set; }

        [StringLength(150)]
        public string zona6 { get; set; }

        [StringLength(150)]
        public string zona7 { get; set; }

        [StringLength(150)]
        public string zona8 { get; set; }

        [StringLength(50)]
        public string statZona1 { get; set; }

        [StringLength(50)]
        public string statZona2 { get; set; }

        [StringLength(50)]
        public string statZona3 { get; set; }

        [StringLength(50)]
        public string statZona4 { get; set; }

        [StringLength(50)]
        public string statZona5 { get; set; }

        [StringLength(50)]
        public string statZona6 { get; set; }

        [StringLength(50)]
        public string statZona7 { get; set; }

        [StringLength(50)]
        public string statZona8 { get; set; }

        [StringLength(50)]
        public string despZona1 { get; set; }

        [StringLength(50)]
        public string despZona2 { get; set; }

        [StringLength(50)]
        public string despZona3 { get; set; }

        [StringLength(50)]
        public string despZona4 { get; set; }

        [StringLength(50)]
        public string despZona5 { get; set; }

        [StringLength(50)]
        public string despZona6 { get; set; }

        [StringLength(50)]
        public string despZona7 { get; set; }

        [StringLength(50)]
        public string despZona8 { get; set; }

        [StringLength(180)]
        public string pinExtra1 { get; set; }

        [StringLength(180)]
        public string pinExtra2 { get; set; }

        [StringLength(180)]
        public string pinExtra3 { get; set; }

        [StringLength(180)]
        public string pinExtra4 { get; set; }

        [StringLength(180)]
        public string pinExtra5 { get; set; }

        [StringLength(180)]
        public string pinExtra6 { get; set; }

        [StringLength(180)]
        public string pinExtra7 { get; set; }

        [StringLength(180)]
        public string pinExtra8 { get; set; }
    }
}
