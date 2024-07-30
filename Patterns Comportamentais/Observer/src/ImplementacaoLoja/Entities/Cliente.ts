import ObserverProdutos from "../Padrao/Observer";
import { ProdutoObservar } from "./ProdutoObservar";

export default class ClienteIphone implements ObserverProdutos{
    private readonly produtos: ProdutoObservar[];
    private nome:string;

    constructor(nome:string, produtosObservar: ProdutoObservar[]){
        this.nome = nome;
        this.produtos = produtosObservar;
    }
    
    obterProdutosDeIntereceCliente(){
        return this.produtos;
    }

    eventoOcorreu (produto: ProdutoObservar) {
        console.log("Recebi a notificação: "+ this.nome)
        console.log(`Produto: ${produto.nome}, Valor: ${produto.price}`)
    }
}