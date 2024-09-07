# TesteTargetSistemas

## Obs: Para rodar os scripts em .NET é necessário ter o SDK do .NET 8 instalado em sua máquina e para executar basta:
~~~
dotnet run
~~~

> Questão 1:
### O valor da variável SOMA será 77
### Há o script em C# em QuestaoUm

> Questão 2:
### a) 1, 3, 5, 7, 9
### b) 2, 4, 8, 16, 32, 64, 128
### c) 0, 1, 4, 9, 16, 25, 36, 49
### d) 4, 16, 36, 64, 100
### e) 1, 1, 2, 3, 5, 8, 13
### f) 2,10, 12, 16, 17, 18, 19, 200

> Questão 3:
### Há o script em C# em QuestaoTres

> Questão 4:
### Link para visualizar o Diagrama ER: [https://lucid.app/lucidchart/9acb3171-3ef7-44cd-bbd9-c6d4b9bea7eb/edit?invitationId=inv_e3c8f68f-7c46-46d7-a05f-3a9ab573f121&page=0_0#](https://lucid.app/lucidchart/9acb3171-3ef7-44cd-bbd9-c6d4b9bea7eb/edit?viewport_loc=-593%2C-122%2C3034%2C1471%2C0_0&invitationId=inv_e3c8f68f-7c46-46d7-a05f-3a9ab573f121)
### - Faça uma busca utilizando comando SQL que traga o código, a razão social e o(s) telefone(s) de todos os clientes do estado de São Paulo (código “SP”):
~~~
SELECT 
    Clients.id AS Codigo_Cliente, 
    Clients.corporate AS Razao_Social, 
    Phones.name AS Telefone
FROM 
    Clients
JOIN 
    Phones ON Clients.phone_ids = Phones.id
JOIN 
    States ON Clients.uf = States.code
WHERE 
    States.code = 'SP';
~~~

> Questão 5:
### ponto de referência é Ribeirão Preto
### a equação horária do carro é: x1 = v1.t
### a do caminhão é: x2 = 125km - v2.t
### tempo de viagem para o carro:
### tSO = 125/90=1,39 // 125 km e 90 km/h
### por perder 15  minutos (0,25 horas) em pedagios: 
### v1 = 125km/1,64h = 76,22
### t = x1/v1
### t = x2-125 / -v2
### x1 = x2 => x/v1 = x-125/-v2
### -v2.x = v1.x - v1.125
### x = v1.125 / v1-v2 = 90.125/90+76,22
### x = 67,68 -> ponto onde os dois se cruzam, a mesma distância da cidade de Ribeirão Preto
