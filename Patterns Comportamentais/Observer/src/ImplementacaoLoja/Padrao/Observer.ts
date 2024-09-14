/*
O Observer 

define uma interface de atualização para objetos que devem ser notificados sobre alterações em um assunto.

ou seja ea classe do assinante, que deseja reber a atualização do evento que ocorreu
*/

import Cliente from "../Entities/Cliente";
import { Produto } from "../Entities/Produto";

export default interface ObserverProdutosComDesconto {
    eventoOcorreu: (cliente: Cliente, produto: Produto) => void;
}