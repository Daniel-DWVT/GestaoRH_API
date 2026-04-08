## Gestão de RH
* **Solução para administração de funcionários, com foco em segurança de dados sensíveis e regras de negócio para departamentos.**
## Tecnologias Utilizadas:
* **C#**
* **ASP.NET Core**
* **Entity Framework**
* **SQL Server**
## Padrões e Arquiteturas utilizadas:
* **Repository Pattern:** utilizado para separar a lógica de dados da lógica de controle.
* **DTOs:** Uso de DTOs para segurança e integridade na entrada de dados
e Data Annotations para evitar a entrada de informações inválidas.
* **Scalar:** Utilização do Scalar para documentação e teste dos endpoints assim que executar a aplicação.
* **Injeção de Dependência:** utilização para desacoplamento entre a camada de controle e a camada de dados 
## Como rodar o projeto:
* **1 -** Configure o servidor através do ConnectionStrings no appsettings.json
* **2 -** Abra o Console do Gerenciador de Pacotes e execute:
```
Update-Database
```
* **3 -** Execute a aplicação e utilize o Scalar para testar os endpoints.
