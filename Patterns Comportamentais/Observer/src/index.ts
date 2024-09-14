/*
Problema a ser resolvido:

Tenho meus clientes na loja, que possui uma lista de produtos com interesse em receber notificação de em caso do valor tenha abaixado.
Com isso e salvo o nome do produto, e o preço de quando ele adicionou na lista.

Com base nesses produtos e o preço atual, tenho que notificar eles toda vez que ficar mais barato
visando facilitar a compra desses clientes.

*/

import Cliente from "./ImplementacaoLoja/Entities/Cliente";
import NotificarClienteProdutoDesconto from "./ImplementacaoLoja/Observers/NotificarClienteProdutoDesconto";
import LojaPublisher from "./ImplementacaoLoja/ProdutoComDescontoPublisher";
import VerificadorPrecos from "./ImplementacaoLoja/VerificadorPrecos";

const cliente1 = new Cliente("Matheus",[
  // {
  //   nome: 'PS5',
  //   price: 2500,
  // },
  // {
  //   nome: 'IPhone 12',
  //   price: 4000,
  // },
  {
    nome: 'Geladeira',
    price: 3000,
  }]
);

const cliente2 = new Cliente("Gabriel",[
  {
    nome: 'PS5',
    price: 2800,
  }
]
);


// Pensando em um cenario real a loja pode ter um local como banco de dados para pegar eventos ainda não acionados,
// como o envio de um e-mail. 
const lojaPublisher = new LojaPublisher();

const event = new NotificarClienteProdutoDesconto();


cliente1
.obterProdutosDeIntereceCliente()
.forEach(produto => {
  lojaPublisher.adicionarAssinantes(cliente1, produto, event);
})

cliente2.obterProdutosDeIntereceCliente().forEach(produto => {
  lojaPublisher.adicionarAssinantes(cliente2, produto, event);
})

const verificadorPrecos = new VerificadorPrecos(lojaPublisher);

// Verificação de preços a cada 10 segundos
verificadorPrecos.checkPrices([cliente1,cliente2]);

setInterval(() => {
  verificadorPrecos.checkPrices([cliente1,cliente2]);
}, 10000);