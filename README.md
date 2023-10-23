<!-- ![logo_ProjTestes](Images/Img1.jpg) -->

<hr>

<!-- <p align="center">
   <img src="http://img.shields.io/static/v1?label=STATUS&message=EM%20DESENVOLVIMENTO&color=RED&style=for-the-badge" #vitrinedev/>
</p> -->
# API Padrão de Fila com RabbitMQ 

### Tópicos 

- [Descrição do projeto](#descrição-do-projeto)

- [Preparação](#preparação)

- [Execução](#execução)

- [Ferramentas utilizadas](#ferramentas-utilizadas)

<br>

## Descrição do projeto 

<p align="justify">
Esta API foi desenvolvida para explorar o serviço de fila do <a href="https://www.rabbitmq.com/">RabbitMQ</a>

Seu conteúdo é composto de 1 API emissora e outra consumidora de elementos enviados por fila.
</p>
<br>

## Preparação
<div style="width:100%">

* Clonar a API emissora e consumidora <a href="https://github.com/medinasp/API_Worker_RabbitMQ">ApiWorkerRabbitMQ</a>

* Instalar a extensão do RabbitMQ.Client nos 2 projetos.

* Baixar e instalar o RabbitMQ Server <br>
<a href="https://www.rabbitmq.com/download.html" target="_blank" rel="noreferrer"> <img src="https://img.shields.io/badge/rabbitmq-%23FF6600.svg?&style=for-the-badge&logo=rabbitmq&logoColor=white"/></a>

* Talvez seja necessário baixar e instalar também o Erlang <br>
<a href="https://www.erlang.org/downloads" target="_blank" rel="noreferrer"> <img src="https://img.shields.io/badge/Erlang-A90533?style=for-the-badge&logo=erlang&logoColor=white"/></a>

* Executar o serviço RabbitMQ no Windows, ou no SO escolhido.

* Se não der certo, navegar até a pasta de instalação do RabbitMQ Server, provavelmente c:/Arquivos de Programas/RabbitMQ server/ rabbitmq-server - x x x / sbin e rodar plugin rabbit mq - plugins enable rabbit mq - management

## Execução

* Abrir as 2 APIs em 2 Visual Studios separados.

* Executar os dois.

* Executar o endereço abaixo e acessar com as configurações. Seguem servidor e acessos padrões:
<a href="http://localhost:15672/#/">http://localhost:15672/#/</a>, username: guest, password: guest
![screen_RabbitMQ](Img/ConRabbit.jpg)

* Com os 2 projetos rodando, abrir o testador de sua preferência, vou usar o Thunder Client no VSCode e chamar a API configurada:
https://localhost:7020/api/Order
{
  "orderNumber": "1",
  "itemName": "Herbie Hancock",
  "price": "1000"
}<br>
  ![screen_ApiThunderClient](Img/CallApi.jpg)

* Tela de execução do app enviando ordens para fila:<br>
![screen_RabbitMQ](Img/ScreenAppRun.jpg)

* Verificar a Api sendo consumida na fila do RabbitMQ após conectar:
Repare que neste caso foram enviados 3 chamados para a fila e consumido os 3:
![screen_RabbitMQ](Img/RabbitExec.jpg)

</br>

## Ferramentas utilizadas

<a href="https://www.w3schools.com/cs/" target="_blank" rel="noreferrer"> <img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/csharp/csharp-original.svg" alt="csharp" width="40" height="40"/></a>
<a href="https://dotnet.microsoft.com/" target="_blank" rel="noreferrer"> <img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/dot-net/dot-net-original-wordmark.svg" alt="dotnet" width="40" height="40"/></a>
<a href="https://www.rabbitmq.com/download.html" target="_blank" rel="noreferrer"> <img src="https://img.shields.io/badge/rabbitmq-%23FF6600.svg?&style=for-the-badge&logo=rabbitmq&logoColor=white"/></a>
