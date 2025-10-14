// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var tarefa01 = new Tarefa();
tarefa01.nome = "Fazer compras";
tarefa01.descricao = "Comprar arroz, feijao e frutas";
tarefa01.dataCriacao = DateTime.Now;
tarefa01.dataExecucao = null;

Console.WriteLine("Dados tarefa 01 preenchidos");

Console.WriteLine("Inserindo dados no banco de dados");

var operacoes = new Operacoes();
int idInserido = operacoes.Criar(tarefa01);

Console.WriteLine($"Dados inseridos no banco de dados com sucesso. Id: (idInserido)");
