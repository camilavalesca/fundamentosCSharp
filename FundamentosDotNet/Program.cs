using System.ComponentModel;
using System.Diagnostics;
using FundamentosDotNet.Models;

//Declarando variáveis
string nomePessoa = "milinha"; //conjunto de caracteres
int quantidade = 17; //números inteiros
double altura = 1.80; //números decimais
decimal preco = 1.80m;
bool verificacao = true; //booleano
DateTime dataAtual = DateTime.Now; //Now: Pega as informações da data do computador/máquina e tem como colocarmos Now.Add que nos proporciona a possiblidade de adicionar dias, meses, anos, microsegundos, milisegundos, segundos, minutos e horas a nossa medição!!

Console.WriteLine("Valor da variável nomePessoa: " + nomePessoa);
Console.WriteLine("Valor da variável quantidade: " + quantidade);
Console.WriteLine("Valor da variável altura: " + altura.ToString("0.00"));
Console.WriteLine("Valor da variável altura: " + altura);
Console.WriteLine("Valor da variável preco: " + preco);
Console.WriteLine("Valor da variável verificacao: " + verificacao);

Console.WriteLine("A data atual: " + dataAtual);
Console.WriteLine("A data atual: " + dataAtual.ToString("dd/MM/yyyy")); //MM = mês; mm = minutos.
Console.WriteLine("A hora atual: " + dataAtual.ToString("HH:mm"));//Horas = HH.

//Testando o conceito de variável, mostrando como podemos manipular e modificar os dados armazenados dentro dela.
quantidade = 14;
Console.WriteLine("Valor da variável quantidade: " + quantidade);


int x = 10;
x = x + 34; //ou seja, 10 + 34.
Console.WriteLine(x);

x +=80; //44 +80
Console.WriteLine(x);

//Convertendo tipos de dados (Cast - Casting)
int numero = Convert.ToInt32("78"); //Está convertendo a string 78 em um número
Console.WriteLine(numero);

int contador = int.Parse("56");
Console.WriteLine(contador);
//Diferenças: O convert é mais indicado por aceitar e tratar números nulos (null), diferente do parse que dá erro e impede do programa continuar rodando.

string posicoes = Convert.ToString(45);
Console.WriteLine(posicoes);
posicoes +=90;
Console.WriteLine(posicoes);//Concatenou, ou seja, é uma string!!!!

//ou

int transformar = 9;
string palavraNova = transformar.ToString();
Console.WriteLine(palavraNova);

//Cast implícito
int a = 9;
double b = a;
Console.WriteLine(b);//Um inteiro cabe um double

//O C sharp (C#) segue a ordem das operações de acordo com as regras matemáticas;

//Convertendo com segurança

string textoNumero = "24-";
int saida = 0;

int.TryParse(textoNumero, out saida); //O valor após o out é sempre de acordo com o tipo a ser tranformado. Se o número for válido, saida recebrá esse dado. Se não, o que estava em saída permanecerá. Logo, o programa da erro, mas o código não para no erro.

int.TryParse(textoNumero, out int saidaAlternativa); //Outra forma de se realizar
Console.WriteLine(saida);

//INSTANCIANDO A CLASSE
Pessoa pessoa1 = new Pessoa();
pessoa1.Nome = "Camila";
pessoa1.Idade = 17;
pessoa1.Apresentar();


//OPERADORES CONDICIONAIS
int quantidadeDeProdutosEmEstoque = 8;
int quantidadeDaCompra = 5;

if (quantidadeDaCompra > quantidadeDeProdutosEmEstoque) //condição
{
   Console.WriteLine("A quantidade de produtos desejada excede a disponibilidade do nosso estoque."); //condição sendo verdadeira
} 
else 
{
    Console.WriteLine("Compra realizada com sucesso!"); //condição sendo falsa
}

//ou

bool possibilidadeDeCompra = quantidadeDaCompra > quantidadeDeProdutosEmEstoque;

if (possibilidadeDeCompra) //condição
{
   Console.WriteLine("A quantidade de produtos desejada excede a disponibilidade do nosso estoque."); //condição sendo verdadeira
} 
else 
{
    Console.WriteLine("Compra realizada com sucesso!"); //condição sendo falsa
}

//ou 

possibilidadeDeCompra = quantidadeDaCompra <= quantidadeDeProdutosEmEstoque;

if (possibilidadeDeCompra) //condição
{
    Console.WriteLine("Compra realizada com sucesso!"); //condição sendo verdadeira
} 
else 
{
    Console.WriteLine("A quantidade de produtos desejada excede a disponibilidade do nosso estoque."); //condição sendo falsa
}

//If aninhado

decimal notaDoAluno = 4.86m;

if (notaDoAluno > 6) //condição 1
{
    Console.WriteLine("Parabéns! A sua nota foi superior a média.");
} 

else if (notaDoAluno == 6) //condição 2 (== é COMPARAÇÃO; = é ATRIBUIÇÃO)
{
    Console.WriteLine("Atenção! A sua nota ficou colado na média.");
}

else //condição 3 (Quando todas acima dão falso, essa linha é executada)
{
    Console.WriteLine("Que pena! A sua nota ficou abaixo da média.");
}


possibilidadeDeCompra = quantidadeDaCompra > 0 && quantidadeDeProdutosEmEstoque >= quantidadeDaCompra;//&& = Trata-se do operador AND

Console.WriteLine($"Quantidade em estoque: {quantidadeDeProdutosEmEstoque}"); //$ - Para usar as variáveis 'mescladas' no console sem fechar as aspas e usar o +;
Console.WriteLine($"Quantidade de produtos escolhida: {quantidadeDaCompra}");
Console.WriteLine($"É possível realizar a compra? {possibilidadeDeCompra}");

if (quantidadeDaCompra == 0) //condição 1
{
    Console.WriteLine("Venda inválida."); //condição sendo verdadeira
} 
else if (possibilidadeDeCompra) //condição 2
{
    Console.WriteLine("Compra realizada com sucesso!"); //condição sendo verdadeira
} 
else //condição 3 (Quando todas acima dão falso, essa linha é executada)
{
    Console.WriteLine("A quantidade de produtos desejada excede a disponibilidade do nosso estoque.");
}

//Switch Case

//Sem a switch case (extenso)
Console.WriteLine("Digite uma letra: ");
string letraDigitada = Console.ReadLine()!; //Entrada de dados pelo teclado; ! = Feito para tirar o aviso CS8600 (documentação: https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/compiler-messages/nullable-warnings)

if (letraDigitada == "a")
{
    Console.WriteLine("Você digitou uma vogal.");
}
else if (letraDigitada == "e")
{
    Console.WriteLine("Você digitou uma vogal.");
} 
else if (letraDigitada == "i")
{
    Console.WriteLine("Você digitou uma vogal.");
}
else if (letraDigitada == "o")
{
    Console.WriteLine("Você digitou uma vogal.");
}
else if (letraDigitada == "u")
{
    Console.WriteLine("Você digitou uma vogal.");
}
else
{
    Console.WriteLine("Você digitou uma consoante.");
}

//Sem switch case (resumido)
Console.WriteLine("Digite uma letra: ");
string letraDigitadaResumida = Console.ReadLine()!; //Entrada de dados pelo teclado

if (letraDigitadaResumida == "a" || 
letraDigitadaResumida == "e" || 
letraDigitadaResumida == "i" || 
letraDigitadaResumida == "o" || 
letraDigitadaResumida == "u") // || = Trata-se da representação do operador OR/OU (também chamado de Pipe)
{
    Console.WriteLine("Você digitou uma vogal.");
}
else
{
    Console.WriteLine("Não é uma vogal, mas sim uma consoante.");
}


//Com switch case
Console.WriteLine("Digite uma letra: ");
string letraDigitadaComSwitch = Console.ReadLine()!; //Entrada de dados pelo teclado

switch (letraDigitadaComSwitch)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("É uma vogal.");
        break;
    default:
        Console.WriteLine("Não é uma vogal.");
        break;
}

//OPERADORES LÓGICOS

//OR (||) : O operador lógico OU consiste na tabela verdade que é verdadeira quando uma das afirmações é verdadeira. Ele é falso apenas quando ambas afirmativas são falsas, de resto, é verdadeiro.
//Tabela verdade OR: V V F F  ||  V F V F = V V V F
bool maiorIdade = true;
bool possuirAutorizacaoDosPais = false;

if (maiorIdade || possuirAutorizacaoDosPais) 
{
    Console.WriteLine("Entrada autorizada.");
}

else {
    Console.WriteLine("Entrada negada");
}


// AND (&&) : O operador lógico AND consiste na tabela verdade que é verdadeira apenas quando ambas afirmações são verdadeiras. Quando apenas uma das preposições é verdadeira, o resultado ainda será falso.
//tabela verdade AND: V V F F  &&  V F V F = V F F F
bool possuirPresencaMinima = true;
double mediaDoAluno = 7.5;

if (possuirPresencaMinima && mediaDoAluno >= 7)
{
    Console.WriteLine("Parabéns. Você foi aprovado (a)!");
}
else 
{
    Console.WriteLine("Você foi reprovado!");
}

// NOT (!) : Ele inverte um valor booleano e operadores também (está ligado a negação de valores!!!).
bool choveu = true;
bool estaTarde = true;

if (!choveu  && !estaTarde) //O if SEMPRE considera a afirmação positiva, ou seja, a linha de código if só roda quando o que está dentro do parênteses for true.
{
    Console.WriteLine("Vou pedalar.");
}
else {
    Console.WriteLine("Vou pedalar outro dia.");
}

//OPERADORES ARITMÉTICOS E A CLASS MATH
// + = Adição; - = Subtração; * = Multiplicação; / = Divisão; % = Módulo (Retorna o resto da divisão); ++ = Incremento (Aumenta 1); -- = Decremento (Diminui 1).

//Intanciar a class calculadora 
Calculadora calc = new Calculadora();

calc.Somar(6,8);
calc.Subtrair(2,5);
calc.Multiplicar(7,9);
calc.Dividir(6,6);

calc.Potencia(2,2);
calc.RaizQuadrada(4);

calc.Seno(30);
calc.Cosseno(30);
calc.Tangente(30);

//Incremento e decremento
int numeroIncrementoEDecremento = 10;

Console.WriteLine(numeroIncrementoEDecremento);
Console.WriteLine($"Incrementando {numeroIncrementoEDecremento}: {numeroIncrementoEDecremento ++}");
Console.WriteLine($"Decrementando {numeroIncrementoEDecremento}: {numeroIncrementoEDecremento --}");

//ESTRUTURAS (LAÇOS) DE REPETIÇÃO

int valor = 10;

for (int contadorRepeticao = 0; contadorRepeticao <= 10; contadorRepeticao++) //(inicio do contador - criação da variável apenas do começo do programa {SEMPRE UM NÚMERO INTEIRO}; condição de parada; passo - de quanto em quanto a variável vai mudar, podendo aumentar e diminuir)
{
    Console.WriteLine($"{valor} x {contadorRepeticao} = {valor * contadorRepeticao}");
}


int contadorWhile = 0;

while (contadorWhile <=10)//Enquanto a condição for verdadeira, o bloco se repetirá
{
    Console.WriteLine($"{valor} x {contadorWhile} = {valor * contadorWhile}");
    contadorWhile++;
}


//Interromper loop/quebrar o laço = break;
int contadorWhileBreak = 0;

while (contadorWhileBreak <=10)//Enquanto a condição for verdadeira, o bloco se repetirá
{
    Console.WriteLine($"{valor} x {contadorWhileBreak} = {valor * contadorWhileBreak}");
    contadorWhileBreak++;

    if (contadorWhileBreak == 5){
        break; //ATENÇÃO: A conta finaliza quando o contador é 4, a última multiplicação é valor * 4. logo, mesmo quando a afirmação é verdadeira, caso tenhamos uma verificação if contendo um break, o código será interrompido.
    }
}


int somaDoWhile = 0, numeroDoWhile = 0; //Você pode declarar duas variáveis de mesmo tipo e valor na mesma linha.

do //Primeiro exexuta
{
    Console.WriteLine("Digite um número ou 0 para parar: ");
    numeroDoWhile = Convert.ToInt32(Console.ReadLine()); //O Console.ReadLine retorna apenas valores do tipo string, ou seja, é preciso transformar para outros tipos de dados.

    somaDoWhile += numeroDoWhile;
} while (numeroDoWhile != 0);//Depois verifica

Console.WriteLine($"Total da soma dos números digitados é: {somaDoWhile}"); 


int contadorDoWhile = 0;

do
{
    Console.WriteLine($"{valor} x {contadorDoWhile} = {valor * contadorDoWhile}");
    contadorDoWhile++;

} while (contadorDoWhile < 5);


//MENU INTERATIVO COM O WHILE

//Menu refatorado
string opcaoRefatorada;
bool exibirMenu = true;

while (exibirMenu)
{
    Console.Clear(); //Ao invés de repetir o menu, ele limpa antes de voltar

    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar Cliente;");
    Console.WriteLine("2 - Buscar Cliente;");
    Console.WriteLine("3 - Apagar Cliente;");
    Console.WriteLine("4 - Encerrar.");

    opcaoRefatorada = Console.ReadLine()!;

    switch (opcaoRefatorada)
    {
        case "1":
            Console.WriteLine("Cadastro de cliente");
            break;
        case "2":
            Console.WriteLine("Busca de Cliente");
            break;
        case "3":
            Console.WriteLine("Apagar cliente");
            break;
        case "4":
            Console.WriteLine("Encerrando...");
            exibirMenu = false; //Troca do Environment.Exit(0) por uma variável booleana
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }

}

//Menu que para o programa (Descomente para executar)

// string opcao;
// while (true)
// {

//     Console.WriteLine("Digite a sua opção:");
//     Console.WriteLine("1 - Cadastrar Cliente;");
//     Console.WriteLine("2 - Buscar Cliente;");
//     Console.WriteLine("3 - Apagar Cliente;");
//     Console.WriteLine("4 - Encerrar.");

//     opcao = Console.ReadLine()!;

//     switch (opcao)
//     {
//         case "1":
//             Console.WriteLine("Cadastro de cliente");
//             break;
//         case "2":
//             Console.WriteLine("Busca de Cliente");
//             break;
//         case "3":
//             Console.WriteLine("Apagar cliente");
//             break;
//         case "4":
//             Console.WriteLine("Encerrando...");
//             Environment.Exit(0); //Esse comando REALMENTE encerrar o programa, ou seja, se tiver código após o laço, ele não vai executar já que esse comando parou TUDO. Para que isso não ocorra, precisamos REFATORAR o nosso código.
//             break;
//         default:
//             Console.WriteLine("Opção inválida");
//             break;
//     }
// }


