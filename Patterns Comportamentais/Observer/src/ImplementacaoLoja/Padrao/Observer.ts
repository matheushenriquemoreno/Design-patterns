/*
O Observer 

define uma interface de atualização para objetos que devem ser notificados sobre alterações em um assunto.

ou seja ea classe do assinante, que deseja reber a atualização do evento que ocorreu


*/

import { ProdutoObservar } from "../Entities/ProdutoObservar";

export default interface ObserverProdutos {
    eventoOcorreu: (ProdutoObservar: ProdutoObservar) => void;
}