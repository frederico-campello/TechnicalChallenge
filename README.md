## Desafio Técnico

### Problema

* Desenvolver um algoritmo que, dado um número, encontre seus divisores e também os números primos entre os divisores.
* As informações devem ser disponibilizadas através de um serviço.

### Solução

##### Para o desenvolvimento da API, foi escolhido o template ASP.NET Core Web Application. Seguindo a orientação para estruturação em camadas, foi utilizada a arquitetura Model-Service-Controller. O endpoint disponibilizado pela API é /Divisors, e o resultado (divisores e divisores primos) pode ser obtido com a passagem de um número via query string (ex.: /Divisors?number=45). A solução inclui também um projeto Console Application que, através do HttpClient demonstra o consumo da API. Para execução no Visual Studio foi configurada, nas propriedades da solução, a opção "Multiple startup projects".