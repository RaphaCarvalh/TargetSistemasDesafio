class Caminhao : Veiculo {
    public int tempoPedagio; // minutos

    public Caminhao() {
        velocidade = 80;
        distancia = 100;
        tempoPedagio = 5;
    }

    public new double TempoParaEncontro(Veiculo outroVeiculo) {
        double distanciaTotal = this.distancia + outroVeiculo.distancia;
        double tempoTotal = distanciaTotal / (this.velocidade + outroVeiculo.velocidade);
        double tempoParaEncontro = this.distancia / (double)this.velocidade;
        tempoParaEncontro += (tempoPedagio / 60.0);
        tempoParaEncontro += ((tempoTotal / 2) - (tempoPedagio / 120.0));
        return tempoParaEncontro;
    }
}