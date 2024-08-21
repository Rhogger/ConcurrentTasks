<h1 align="center">Título</h1>

<div align="center">

[Projeto](#projeto)
&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
[Como Executar](#como-executar)
&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
[Estruturas de Dados](#estruturas)
&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
[Tecnologias](#tecnologias)
&nbsp;&nbsp;&nbsp;|&nbsp;&nbsp;&nbsp;
[Licença](#license)

</div>

<p align="center">
  <img alt="License" src="https://img.shields.io/static/v1?label=license&message=MIT&color=49AA26&labelColor=000000">
</p>

<hr>

## 💻 Projeto <a name="projeto"></a>

### Descrição do Projeto

Este projeto é uma implementação em .NET que aborda conceitos de programação concorrente através de dois exercícios práticos. Ele explora a execução paralela de processos e a realização de tarefas simultâneas utilizando threads e tasks.

#### Exercício 1:

O primeiro exercício envolve a criação de dois processos paralelos. O primeiro processo gera números aleatórios e os coloca em uma fila (ConcurrentQueue<int>). O segundo processo consome esses números da fila, calcula a soma dos números retirados e imprime o resultado na tela. A implementação permite escolher se uma pausa (Sleep) será incluída em cada iteração para simular um processamento mais longo.

#### Exercício 2:

O segundo exercício foca em realizar requisições HTTP para quatro sites diferentes, medindo o tempo de resposta de cada um. Essas requisições são executadas em paralelo utilizando tarefas assíncronas (async e await), demonstrando como as requisições podem ser concluídas em ordens diferentes dependendo do tempo de resposta dos sites, sem bloquear a execução do programa.

<br>

## Como Executar o Projeto .NET <a name="como-executar"></a>

Para executar este projeto em .NET, siga os passos abaixo:

##### Clone o Repositório: 

Baixe o código-fonte para a sua máquina.

```shell
git clone https://github.com/Rhogger/ConcurrentTasks.git
cd ConcurrentTasks/ConcurrentTasks/
```

##### Restaure as Dependências: 

Caso o projeto utilize pacotes externos, restaure as dependências com o comando:

```shell
dotnet restore
```

##### Compile o Projeto: 

Compile o projeto para garantir que não há erros de compilação.

```shell
dotnet build
```

###### Execute o Programa: 

Execute o programa, e ele solicitará que você escolha qual exercício deseja rodar.

```shell
dotnet run
```

##### Escolha o Exercício: 

No terminal, insira "1", "2", ou "3" para escolher qual exercício deseja executar:

1: Executa o primeiro exercício com Sleep para simular tempo de processamento. <br>
2: Executa o primeiro exercício sem Sleep, para uma execução mais rápida. <br>
3: Executa o segundo exercício, que faz requisições HTTP em paralelo.

<br>

## Motivo da Utilização das Estruturas de Dados <a name="estruturas"></a>

A escolha das estruturas de dados utilizadas neste projeto foi guiada por questões de segurança e eficiência na programação concorrente:

- ConcurrentQueue<int>: Esta fila concorrente foi utilizada no primeiro exercício para garantir que múltiplas threads possam acessar e modificar a fila simultaneamente sem causar problemas de condição de corrida (race conditions). Isso permite que a geração e o consumo de números aconteçam de maneira segura e ordenada.


- CancellationTokenSource e CancellationToken: Estes foram empregados para permitir a interrupção segura dos processos paralelos. O CancellationToken é propagado para as tasks, permitindo que elas verifiquem periodicamente se devem parar de executar, evitando cenários onde as threads continuariam a executar indefinidamente.


- HttpClient com Task e async/await: No segundo exercício, a utilização de Task junto com async/await não só facilita a execução paralela das requisições HTTP como também melhora a responsividade da aplicação. O HttpClient é reutilizado dentro das tarefas para evitar o overhead de criar novas instâncias para cada requisição, seguindo as melhores práticas de performance e segurança.

<br>

## 🚀 Tecnologias <a name="tecnologias"></a>

- C#
- .NET

<br>

##  🔒 Licença <a name="license">

Esse projeto está sob a licença MIT.

<hr>
