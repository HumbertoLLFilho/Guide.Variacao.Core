# Guide.Variacao.Core

## Funcionamento

Esse projeto foi criado com o intuito de centralizar as configurações padrões de todos os sistemas,

Os 2 namespaces desse projeto são pacotes do Nuget, que são utilizados tanto no `Guide.Variacao.Seed` quanto no `Guide.Variacao.Backend`

Caso queiram consultar as versões do *Nuget* também, segue o link:

[HLLF.Guide.Variacao.Core.DataBase](https://www.nuget.org/packages/HLLF.Guide.Variacao.Core.DataBase/)

[HLLF.Guide.Variacao.Core.Domain](https://www.nuget.org/packages/HLLF.Guide.Variacao.Core.Domain/)

## Sobre a lib
### HLLF.Guide.Variacao.Core.Domain
Esse projeto tem como função armazenar nossas **Models** e **ViewModels**, juntamente com suas respectivas extensões e ou configurações.


### HLLF.Guide.Variacao.Core.DataBase
Já Esse projeto tem como função armazenar nossas classes de **contexto** e **repositório**, juntamente com suas respectivas extensões e ou configurações.

## Repository
É possivel notar uma configuração diferente para o Repositorio do que estamos acostumados a ver em projetos menores:

Ao criar o Objeto:
```
  public abstract class Repository<T> : IRepository<T>, IDisposable where T : class
```

Isso acontece para não termos repetições na hora de criar as *Models* de repositório, para injetção correta e generica, pode ser utilizado:

```
public static IServiceCollection AddGenericRepository(this IServiceCollection services)
{
  services.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
}
```

Dessa forma injetamos a dependencia para todos os tipos que herdem de `IRepository`, o que facilita nossa vida.

:tada: Agora é só injetar nos construtores e já era! :tada:
