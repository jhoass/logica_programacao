
using System;
using System.Globalization;

/*
String frase = Console.ReadLine();
String o = Console.ReadLine();
String y = Console.ReadLine();
String z = Console.ReadLine();

String s = Console.ReadLine();
String[] vet = s.Split(' ');
String p1 = vet[0];
String p2 = vet[1];
String p3 = vet[2];

Console.WriteLine(p1);
Console.WriteLine(p2);
Console.WriteLine(p3);

Console.WriteLine("Você digitou: " + frase);
Console.WriteLine(o);
Console.WriteLine(y);
Console.WriteLine(z);

Console.WriteLine("Hello, World!");
Console.WriteLine("Isso ae!");
Console.Write("isso mesmo");
Console.Write("testando");

double x = 20.29930;

int a, b, c;
a = 10;
b = 6;
c = a + b;

double d;
int e;

d = 20.940;
e = (int)d / 2;



Console.WriteLine(e);
Console.WriteLine(c);
Console.WriteLine(x);
Console.WriteLine(x.ToString("F2"));
Console.WriteLine(x.ToString("F5")); */

/*
int n1 = int.Parse(Console.ReadLine());
char ch = char.Parse(Console.ReadLine());
double n2 = double.Parse(Console.ReadLine());

String[] vet = Console.ReadLine().Split(' ');
String nome = vet[0];
char sexo = char.Parse(vet[1]);
int idade = int.Parse(vet[2]);
double altura = double.Parse(vet[3]); 






Console.WriteLine("Você da variável n1: " + n1);
Console.WriteLine("Valor da variável ch: " + ch);
Console.WriteLine("Valor da variável n2: " + n2);
Console.WriteLine("nome: " + nome);
Console.WriteLine("sexo: " + sexo);
Console.WriteLine("idade: " + idade);
Console.WriteLine("altura: " + altura);*/

/*
Console.WriteLine("Entre com seu nome completo: ");
String nome = Console.ReadLine();

Console.WriteLine("Quantos quartos tem na sua casa");
int quartos = int.Parse(Console.ReadLine());

Console.WriteLine("Entre com o preço de um produto: ");
double preco = double.Parse(Console.ReadLine());

Console.WriteLine("Entre seu último nome, idade e altura (mesma linha)");
String[] vet = Console.ReadLine().Split(' ');
String sobrenome = vet[0];
int idade = int.Parse(vet[1]);
double altura = double.Parse(vet[2]);


Console.WriteLine(nome);
Console.WriteLine(quartos);
Console.WriteLine(preco);
Console.WriteLine(sobrenome);
Console.WriteLine(idade);
Console.WriteLine(altura);
*/

/*
double x = 3.0;
double y = 4.0;
double z = -5.0;
double A, B, C;

A = Math.Sqrt(x);
B = Math.Sqrt(y);
C = Math.Sqrt(25.0);
Console.WriteLine("A raiz quadrada de: " + x + " resulta em: " + A);
Console.WriteLine("A raiz quadrada de: " + y + " resulta em: " + B);
Console.WriteLine("A raiz quadrada de 25 é: " + C);

A = Math.Pow(x, y);
B = Math.Pow(x, 40.0);
C = Math.Pow(5.0, 3.0);
Console.WriteLine("A potencialização de: " + x + " com o valor: " + y + " é de: " + A);
Console.WriteLine("A potencialização de: " + x + " com valor de 40, resulta em: " + B);
Console.WriteLine("A potencialização de 5 com 3, resulta em: " + C);

A = Math.Abs(y);
B = Math.Abs(z);
C = Math.Abs(7.0);

Console.WriteLine("O valor absoluto de " + y + " resulta em: " + A);
Console.WriteLine("O valor absoluto de " + z + "resulta em: " + B);
Console.WriteLine("O valor absoluto de 7.0 é : " + C); */
/*
double largura, comprimento, precoMetroQuadrado, area, preco;

largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
precoMetroQuadrado = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

area = largura * comprimento;
preco = area * precoMetroQuadrado;

Console.WriteLine("ÁREA: " + area.ToString(CultureInfo.InvariantCulture));
Console.WriteLine("PREÇO: " + preco.ToString("F2", CultureInfo.InvariantCulture));*/

/*
int A, B, X;

A = int.Parse(Console.ReadLine());
B = int.Parse(Console.ReadLine());

X = A + B;

Console.WriteLine("X = " + X);*/
/*
double A, R, Pi;

R = double.Parse(Console.ReadLine());
Pi = (3.14159);
A = Pi * Math.Pow(R, 2.0);

Console.WriteLine("A=" + A.ToString("F4"));*/

/*
int A, B, SOMA;

A = int.Parse(Console.ReadLine());
B = int.Parse(Console.ReadLine());
SOMA = A + B;

Console.WriteLine("SOMA = " + SOMA);*/

/*
int A, B, PROD;

A = int.Parse(Console.ReadLine());
B = int.Parse(Console.ReadLine());
PROD = A * B;

Console.WriteLine("PROD = " + PROD);*/

/*

int A, B, C, D, DIFERENCA;

A = int.Parse(Console.ReadLine());
B = int.Parse(Console.ReadLine());
C = int.Parse(Console.ReadLine());
D = int.Parse(Console.ReadLine());

DIFERENCA = (A * B - C * D);

Console.WriteLine("DIFERENÇA = " + DIFERENCA);*/



/*
int FUNCIONARIO, HORAS;
double SALARIO, VALORHORA;

FUNCIONARIO = int.Parse(Console.ReadLine());
HORAS = int.Parse(Console.ReadLine());
VALORHORA = double.Parse(Console.ReadLine());
SALARIO = HORAS * VALORHORA;

Console.WriteLine("NUMBER = " + FUNCIONARIO);
Console.WriteLine("SALARY = U$ " + SALARIO.ToString("F2"));*/

//// minha maneira de fazer: 
/*
int CODIGO1, NUMEROUNIDADES1, CODIGO2, NUMEROUNIDADES2;
double VALORUNITARIO1, VALORUNITARIO2, VALORTOTAL;

CODIGO1 = int.Parse(Console.ReadLine());
NUMEROUNIDADES1 = int.Parse(Console.ReadLine());
VALORUNITARIO1 = double.Parse(Console.ReadLine());

CODIGO2 = int.Parse(Console.ReadLine());
NUMEROUNIDADES2 = int.Parse(Console.ReadLine());
VALORUNITARIO2 = double.Parse(Console.ReadLine());

VALORTOTAL = NUMEROUNIDADES1 * VALORUNITARIO1 + NUMEROUNIDADES2 * VALORUNITARIO2;

Console.WriteLine("VALOR A PAGAR: R$ " + VALORTOTAL.ToString("F2", CultureInfo.InvariantCulture));*/

int cod1, cod2, qt1, qt2;
double preco1, preco2, total;

String[] valores = Console.ReadLine().Split(' ');

cod1 = int.Parse(valores[0]);
qt1 = int.Parse(valores[1]);
preco1 = double.Parse(valores[2], CultureInfo.InvariantCulture);

cod2 = int.Parse(valores[0]);
qt2 = int.Parse(valores[1]);
preco2 = double.Parse(valores[2], CultureInfo.InvariantCulture);

total = qt1 * preco1 + qt2 * preco2;

Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));








































