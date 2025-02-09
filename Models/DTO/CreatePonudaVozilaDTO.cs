﻿namespace carGooBackend.Models.DTO
{
    public class CreatePonudaVozilaDTO
    {
        public string DrzavaU { get; set; }
        public string DrzavaI { get; set; }
        public string MestoU { get; set; }
        public string MestoI { get; set; }
        public string RadiusI { get; set; }
        public DateTime Utovar { get; set; }
        public DateTime Istovar { get; set; }
        public double Duzina { get; set; }
        public double Tezina { get; set; }
        public string TipNadogradnje { get; set; }
        public string TipKamiona { get; set; }
        public string IdKorisnika { get; set; }
        public Guid IdPreduzeca { get; set; }
        public DateTime Vreme { get; set; }
    }
}
