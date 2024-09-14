import { Produto } from "./Entities/Produto";
import ObserverProdutos from "./Padrao/Observer";
import Cliente from "./Entities/Cliente";
import ObserverProdutosComDesconto from "./Padrao/Observer";
import ProdutosComDescontoPublisher from "./Padrao/Publisher";

export default class ProdutoComDescontoPublisher implements ProdutosComDescontoPublisher {
  private assinantes: Map<string, [{ cliente: Cliente, produto: Produto, assinante: ObserverProdutosComDesconto }]> = new Map();

  adicionarAssinantes(cliente: Cliente, produto: Produto, assinante: ObserverProdutosComDesconto): void {
    if (!this.assinantes.has(produto.nome)) {
      this.assinantes.set(produto.nome, [{
        assinante: assinante,
        cliente: cliente,
        produto: produto
      }])
      return;
    }
    this.assinantes.get(produto.nome)?.push({
      assinante: assinante,
      cliente: cliente,
      produto: produto
    });
  }

  notificarAssinantes(produto: Produto): void {
    const assinantesDoEvento = this.assinantes.get(produto.nome) ?? [];

    assinantesDoEvento.forEach(evento => {
      evento.assinante.eventoOcorreu(evento.cliente, produto);
    });
  }

  removerAssinantes(produto: Produto): void {
    this.assinantes.delete(produto.nome)
  }
}