/*
Conhece seus observadores. Qualquer número de objetos Observer pode observar um sujeito

Fornece uma interface para anexar e desanexar objetos Observer.
*/

import Cliente from "../Entities/Cliente";
import { Produto } from "../Entities/Produto";

import ObserverProdutosComDesconto from "./Observer";

export default interface ProdutosComDescontoPublisher {
    adicionarAssinantes(cliente: Cliente, produto: Produto, assinante: ObserverProdutosComDesconto): void;
    notificarAssinantes(produto: Produto) : void;
    removerAssinantes(produto: Produto) : void;
}