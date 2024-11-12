namespace DespositivosEletronicos.Models
{
    public class Computador : DispositivoEletronico
    {
        public bool Laptop {  get; set; }
        public int MemoriaRam {  get; set; }
        public string SistemaOperacional { get; set; }

        public override string ExibirDetalhes()
        {
            return $"Marca: {Marca}, Modelo: {Modelo}, Ano: {AnoFabri}, Sistema: {SistemaOperacional}";
        }


    }
}
