import Publisher from "./Padrao/Subject";
import Terminal from "../utils/Terminal";
import { ProdutoObservar } from "./Entities/ProdutoObservar";
import ObserverProdutos from "./Padrao/Observer";

export default class LojaPublisher implements Publisher {
  private assinantes: Map<string, ObserverProdutos[]> = new Map();
  private products: ProdutoObservar[] = [
    { nome: 'PS5', price: 1000 },
    { nome: 'IPhone', price: 500 },
    { nome: 'Headset', price: 100 },
    { nome: 'Geladeira', price: 100 },
  ];

  adicionarAssinantes(evento: string, assinante: ObserverProdutos): void {
    if (!this.assinantes.has(evento)) {
      this.assinantes.set(evento, [assinante])
      return;
    }

    this.assinantes.get(evento)?.push(assinante);
  }

  notificarAssinantes(evento: string, produto: ProdutoObservar): void {
    const assinantesDoEvento = this.assinantes.get(evento) ?? [];
    assinantesDoEvento.forEach(element => {
      element.eventoOcorreu(produto);
    });
  }

  // Método para simular a verificação de preços
  public checkPrices(): void {
    Terminal.limparTela();
    console.log('Verificando Preços... ')
    for (const product of this.products) {
      const newPrice = this.simulatePriceChange(product.price!);
      if (newPrice < product.price!) {
        product.price = newPrice;
        this.notificarAssinantes(product.nome, product);
      }
    }
    console.log('Finalizado Preços... ')

  }

  private simulatePriceChange(currentPrice: number): number {
    // Simula uma mudança de preço
    return currentPrice - Math.floor(Math.random() * 50);
  }

}