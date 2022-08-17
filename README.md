<h1 align="center"><strong>Execução de tarefas de longa duração em segundo plano utilizando o ASP.NET Core</strong></h1>

### ` 🔍 Sobre`

<p align="justify">As vezes precisamos realizar tarefas de longa duração em segundo plano na nossa aplicação, como, por exemplo, de tempos em tempos, verficar se há registros em determinada tabela do banco de dados e então realizar alguma rotina (gerar relatório, processar estoque, auditoria, enviar email). </p>

<p>A melhor forma de executar esse tipo de tarefa em background utilizando ASP.NET Core é criando Hosted Services. Para isso o C# dispões da poderosa interface 'IHostedService'. </p>

### `🔎 Como utilizar?`

<p>$ git clone https://github.com/devjamesbrandao/background-services.git</p>

<p>$ dotnet restore</p>

<p>$ dotnet build</p>

<p>$ dotnet run</p>

### ` 🌐 Referências`

- <p> Execute queue with ASP.NET core timed hosted service: https://codernr.github.io/posts/execute-queue-with-aspnet-core-timed-hosted-service</p>





