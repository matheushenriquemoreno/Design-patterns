
import Cliente from "./ImplementacaoLoja/Entities/Cliente";
import LojaPublisher from "./ImplementacaoLoja/verificadorDePrecos";

const cliente1 = new Cliente("Matheus",[
  {
    nome: 'PS5'
  },
  {
    nome: 'IPhone'
  },
  {
    nome: 'Geladeira'
  }]
);

const cliente2 = new Cliente("Gabriel",[
  {
    nome: 'PS5'
  }
]
);

const lojaPublisher = new LojaPublisher();

cliente1.obterProdutosDeIntereceCliente().forEach(produto => {
  lojaPublisher.adicionarAssinantes(produto.nome, cliente1);
})

cliente2.obterProdutosDeIntereceCliente().forEach(produto => {
  lojaPublisher.adicionarAssinantes(produto.nome, cliente2);
})

// Verificação de preços a cada 10 segundos
lojaPublisher.checkPrices();

setInterval(() => {
  lojaPublisher.checkPrices();
}, 10000);