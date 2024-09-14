import { Produto } from "./Produto";

export default class Cliente{
    private readonly produtos: Produto[];
    private _nome:string;

    constructor(nome:string, produtosObservar: Produto[]){
        this._nome = nome;
        this.produtos = produtosObservar;
    }
    
    get nome():string {
        return this._nome
    }

    obterProdutosDeIntereceCliente(){
        return this.produtos;
    }
}