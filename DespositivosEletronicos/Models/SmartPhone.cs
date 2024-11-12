namespace DespositivosEletronicos.Models
{
    public class SmartPhone : DispositivoEletronico
    {
        public bool Tem5G {  get; set; }

        public override string ExibirDetalhes()
        {
            return $"Marca: {Marca}, Modelo: {Modelo}, Ano: {AnoFabri}, 5G: {(Tem5G ?"Sim":"Não")}";
        }
    }
}
