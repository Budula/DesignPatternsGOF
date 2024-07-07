
# GOF C# Designer Patterns

Designer Patterns usando .net Core


## Adapter pattern

**Definição:** Adapta uma interface em outra de acordo com a expectativa do client.
Permite a colaboração de objetos com "interfaces" incopatíveis.

**Intenção**
- Converter a interface de uma classe em outra.
- Envolver uma classe existente com uma nova interface.
- Introduzir um componente legado em um novo sistema.

**Exemplo de uso**
- Quando umm objeto precisa usar uma classe existente com uma interface incompatível
- Quando você deseja criar uma classe reutilizável que coopere com classes que não possuam interfaces compatíveis.

## Bridge pattern
**Definição:**
- Desacopla uma abstração de sua implementação para que as duas possam variar de forma independente.
- Divide a lógica de negócio em hierarquias de classe separadas que podem ser desenvolvidas de forma independente.
- Separa a interface do objeto de sua implementação.
