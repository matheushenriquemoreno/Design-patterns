import Terminal from "../utils/Terminal";
import Cliente from "./Entities/Cliente";
import { Produto } from "./Entities/Produto";
import ProdutoComDescontoPublisher from "./ProdutoComDescontoPublisher";

export default class VerificadorPrecos {
  private readonly _lojaPublisher: ProdutoComDescontoPublisher;

  constructor(lojaPublicher: ProdutoComDescontoPublisher){
    this._lojaPublisher = lojaPublicher;
  }

  // produtos que vão ser observados.
  private products: Produto[] = [
    { nome: 'PS5', price: 1000 },
    { nome: 'IPhone 12', price: 500 },
    { nome: 'Headset', price: 100 },
    { nome: 'Geladeira', price: 100 },
  ];

  // Método para simular a verificação de preços
  public checkPrices(clientes: Cliente[]): void {
    Terminal.limparTela();
    for(const cliente of clientes) {
      console.log(`Verificando Preços dos produtos do cliente: ${cliente.nome}`)

      for (const clienteProduto of cliente.obterProdutosDeIntereceCliente()) {

        const produto = this.products.find(x => x.nome === clienteProduto.nome)

        if(!produto){
          this._lojaPublisher.removerAssinantes(clienteProduto);
          return;
        }

        produto.price= this.simulatePriceChange(produto.price);
        
        if (produto.price < clienteProduto.price) {
          this._lojaPublisher.notificarAssinantes(produto);
        }
      }
    }

    console.log('Finalizado Preços... ')
  }

  private simulatePriceChange(currentPrice: number): number {
    // Simula uma mudança de preço
    return currentPrice - Math.floor(Math.random() * 50);
  }

}