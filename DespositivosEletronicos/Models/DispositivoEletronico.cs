namespace DespositivosEletronicos.Models
{
    public abstract class DispositivoEletronico
    {
        public string Marca {  get; set; } //get obter set guardar 
        public string Modelo { get; set; }
        public int AnoFabri {  get; set; }

        //Metodo
        public abstract string ExibirDetalhes();
    }
}
