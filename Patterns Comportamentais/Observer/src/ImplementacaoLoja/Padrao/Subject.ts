/*
Conhece seus observadores. Qualquer número de objetos Observer pode observar um sujeito

Fornece uma interface para anexar e desanexar objetos Observer.
*/

import { ProdutoObservar } from "../Entities/ProdutoObservar";
import Assinante from "./Observer";

export default interface Publisher {
    adicionarAssinantes(evento: string, assinante: Assinante): void;
    notificarAssinantes(evento: string, produto:ProdutoObservar) : void;
}