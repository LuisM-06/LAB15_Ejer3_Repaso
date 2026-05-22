namespace LAB15_Ejer3_Repaso.Models
{
    public class AnimalRegistro
    {
        public string TipoAnimal { get; set; } = string.Empty;

        public string NombrePropio { get; set; } = string.Empty;
        public string Especie { get; set; } = string.Empty;
        public string TipoAlimentacion { get; set; } = string.Empty;
        public int TiempoMaximoVida { get; set; }

        public bool Vuela { get; set; }
        public int PeriodoIncubacion { get; set; }

        public bool EsVenenosa { get; set; }
        public double LongitudMaxima { get; set; }
    }
}
