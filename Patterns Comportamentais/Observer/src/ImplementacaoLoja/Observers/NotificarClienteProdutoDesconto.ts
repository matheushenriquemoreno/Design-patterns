import Cliente from "../Entities/Cliente";
import { Produto } from "../Entities/Produto";
import ObserverProdutosComDesconto from "../Padrao/Observer";

export default class NotificarClienteProdutoDesconto implements ObserverProdutosComDesconto {
    eventoOcorreu (cliente: Cliente, produto: Produto) {
        console.log(`O sistema ira notificar o cliente: ${cliente.nome}`)
        const precoAnterior = cliente.obterProdutosDeIntereceCliente().find(x => x.nome == produto.nome)?.price
        console.log(`Que o Produto: ${produto.nome}, está com o de Valor: R$ ${produto.price}, comparado com o anterior de R$ ${precoAnterior}`)
    }
}