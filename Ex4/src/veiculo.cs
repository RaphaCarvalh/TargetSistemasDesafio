using System;

class Veiculo {
    public int velocidade; // km/h
    public int distancia; // km

    public double TempoParaEncontro(Veiculo outroVeiculo) {
        double distanciaTotal = this.distancia + outroVeiculo.distancia;
        double tempoTotal = distanciaTotal / (this.velocidade + outroVeiculo.velocidade);
        double tempoParaEncontro = this.distancia / (double)this.velocidade;
        return tempoParaEncontro + (tempoTotal / 2);
    }
}