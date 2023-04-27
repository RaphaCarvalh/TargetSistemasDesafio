class Program {
    static void Main(string[] args) {
        Carro carro = new Carro();
        Caminhao caminhao = new Caminhao();
        double tempoParaEncontro = carro.TempoParaEncontro(caminhao);

        if (tempoParaEncontro * carro.velocidade <= carro.distancia) {
            Console.WriteLine("Quando se cruzarem o carro estará mais próximo de Ribeirão Preto");
        } 
        else {
            Console.WriteLine("Quando se cruzarem o caminhão estará mais próximo de Ribeirão Preto");
        }
    }
}