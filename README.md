<!-- ![logo_ProjTestes](Images/Img1.jpg) -->

<hr>

<!-- <p align="center">
   <img src="http://img.shields.io/static/v1?label=STATUS&message=EM%20DESENVOLVIMENTO&color=RED&style=for-the-badge" #vitrinedev/>
</p> -->

### Tópicos 

- [Descrição do projeto](#descrição-do-projeto)

- [Implantação](#implantação)

- [Test end points](#test-end-points)

- [Ferramentas utilizadas](#ferramentas-utilizadas)

## Descrição do projeto 

<p align="justify">
Esta API foi desenvolvida para explorar o serviço de fila do <a href="https://www.rabbitmq.com/">RabbitMQ</a>

Seu conteúdo é composto de 1 API emissora e outra consumidora de elementos enviados por fila.
</p>
<br>

## Implantação
<div style="width:100%">


`Preparação:`
<!-- ![Tela de abertura](Images/abertura.jpg) -->
* Clonar a API emissora e consumidora <a href="https://github.com/medinasp/API_Worker_RabbitMQ">ApiWorkerRabbitMQ</a>

* Abrir as 2 APIs em 2 Visual Studios separados.

* Instalar a extensão do RabbitMQ.Client nos 2 projetos.

* Baixar e instalar o RabbitMQ Server <br>
<a href="https://www.rabbitmq.com/download.html" target="_blank" rel="noreferrer"> <img src="https://img.shields.io/badge/rabbitmq-%23FF6600.svg?&style=for-the-badge&logo=rabbitmq&logoColor=white"/></a>

* Talvez seja necessário baixar e instalar também o Erlang <br>
<a href="https://www.erlang.org/downloads" target="_blank" rel="noreferrer"> <img src="https://img.shields.io/badge/Erlang-A90533?style=for-the-badge&logo=erlang&logoColor=white"/></a>

* Navegar até a pasta de instalação do RabbitMQ Server, provavelmente c:/Arquivos de Programas/RabbitMQ server/ rabbitmq-server - x x x / sbin e rodar plugin rabbit mq ´plugins enable rabbit mq - management

* Executar o endereço configurado e acessar com as configurações. Seguem servidor e acessos padrões:
<a href="http://localhost:15672/#/">http://localhost:15672/#/</a>, User: guest, password: guest

`Execução:`
   * Com os 2 projetos rodando, abra o testador de sua preferência e execute os endpoints:

      ✅ `Create:`
      * Exemplo de json para end point "Create":<br>
         Post: https://localhost:7100/api/CreateProd<br>
         Json Content:<br>
            {<br>
               "Descricao":"Registro 9",<br>
            }<br><br>

      ✅ `List:`
      * Exemplo de json para end point "List":<br>
         Post: https://localhost:7100/api/ListProd<br>
         Json Content:<br>
            {<br>
               "codigo": 0,<br>
               "descricao": "",<br>
               "dataCriacao": "",<br>
               "dataAtualizacao": ""<br>
            }<br><br>

      ✅ `Update:`
      * Exemplo de json para end point "Update":<br>
         Post: https://localhost:7100/api/UpdateProd<br>
         Json Content:<br>
            {<br>
               "codigo": 1002,<br>
               "descricao": "Updated Register" <br>
            }<br><br>

      ✅ `GetOne`
      * Exemplo de json para end point "GetOne":<br>
         Post: https://localhost:7100/api/GetOne/1004<br>
         Json Content:<br>
            não é necessário json, basta passar o código na url, como no exemplo, código 1004<br><br>

      ✅ `Delete`
      * Exemplo de json para end point "Delete":<br>
         Post: https://localhost:7100/api/DeleteProd/1004<br>
         Json Content:<br>
            não é necessário json, basta passar o código na url, como no exemplo, código 1004<br>
</div>   
</br>

## Ferramentas utilizadas

<a href="https://www.w3schools.com/cs/" target="_blank" rel="noreferrer"> <img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/csharp/csharp-original.svg" alt="csharp" width="40" height="40"/></a>
<a href="https://dotnet.microsoft.com/" target="_blank" rel="noreferrer"> <img src="https://raw.githubusercontent.com/devicons/devicon/master/icons/dot-net/dot-net-original-wordmark.svg" alt="dotnet" width="40" height="40"/></a>
