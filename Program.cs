using ByteBank.Titular;
using ByteBank.ContaCorrente;
using System;

//Como representar a conta de um cliente? (objeto)

//Definindo o objeto e dando valores 
//ContaCorrente contaDoAndre = new ContaCorrente();
//contaDoAndre.titular = "André Silva";
//contaDoAndre.numeroAgencia = 15;
//contaDoAndre.contaCorrente = "1010-X";
//contaDoAndre.saldo = 100; 

//ContaCorrente contaDaMaria = new ContaCorrente();
//contaDaMaria.titular = "Maria Souza";
//contaDaMaria.numeroAgencia = 17;
//contaDaMaria.contaCorrente = "1018-5";
//contaDaMaria.saldo = 350;

//ContaCorrente contaDoJose = new ContaCorrente();
//contaDoJose.titular = "José Gomes";
//contaDoJose.numeroAgencia = 16;
//contaDoJose.contaCorrente = "8594-6";
//contaDoJose.saldo = 503;

////criando a classe Conta Corrente e em seguida exibindo os valores padrão
//ContaCorrente conta = new ContaCorrente();
//Console.WriteLine($"Titular da conta: {conta.titular}");
//Console.WriteLine($"Número da conta: {conta.contaCorrente}");
//Console.WriteLine($"Agência: {conta.numeroAgencia}");
//Console.WriteLine($"Saldo R$ {String.Format("{0:0.00}", conta.saldo)}");

//Console.ReadKey();

/*
 DO MÉTODO DEPOSITAR
-print antes do depósito
Console.WriteLine("Saldo da conta: "+ contaDoAndre.saldo);

-realizando o depósito
contaDoAndre.Depositar(100);
*/

/*
DO MÉTODO SACAR
Console.WriteLine("Saldo da conta: " + contaDoAndre.saldo);

contaDoAndre.Sacar(100);
*/

/*MÉTODO QUE VERIFICA A POSSIBILIDADE DE FAZER O SAQUE
if(contaDoAndre.Sacar(300) == true)
{
    Console.WriteLine("Saldo da conta: " + contaDoAndre.saldo);
}
else
{
    Console.WriteLine("Você não possui saldo para realizar esse saque.");
}
*/

/*METÓDO QUE VERIFICA A POSSIBILIDADE DE TRANSFERENCIA 
contaDoAndre.Transferir(50, contaDaMaria);
Console.WriteLine("Saldo André: " + contaDoAndre.saldo);
Console.WriteLine("Saldo Maria: " + contaDaMaria.saldo);
*/


//Criando um outro objeto que fará ASSOCIAÇÃO do Cliente a Conta Corrente TIRAR DUVIDA C O JHOW SOBRE ESSA ASSOCIAÇÃO
//Cliente cliente = new Cliente();
//cliente.nome = "André Silva";
//cliente.cpf = "123456789";
//cliente.profissao = "Analista";

//ContaCorrente conta = new ContaCorrente();
//conta.titular = cliente;
//conta.contaCorrente = "101-X";
//conta.numeroAgencia = 15;
//conta.saldo = 100;

////infos da conta corrente 
//Console.WriteLine("Titular: " + conta.titular.nome);
//Console.WriteLine("CPF: " + conta.titular.cpf);
//Console.WriteLine("Profissão: " + conta.titular.profissao);
//Console.WriteLine("Nº Conta: " + conta.contaCorrente);
//Console.WriteLine("Saldo: " + conta.saldo);
//Console.WriteLine("Nº Agência: " + conta.numeroAgencia);

//ContaCorrente conta2 = new ContaCorrente();
//conta2.titular = new Cliente();
//conta2.titular.nome = "José Souza";
//conta2.titular.profissao = "Tester";
//conta2.titular.cpf = "987654321";
//conta2.contaCorrente = "9999-X";
//conta2.numeroAgencia = 18;
//conta2.saldo = 500;

//Console.WriteLine(conta2.titular.nome);

//ContaCorrente conta3 = new ContaCorrente();
//conta3.Numero_agencia = 18;
//conta3.Conta = "1011-H";
//conta3.SetSaldo(200);
//Console.WriteLine(conta3.GetSaldo());
//Console.WriteLine(conta3.Numero_agencia);
//Console.WriteLine(conta3.Conta);

ContaCorrente conta5 = new ContaCorrente("Maria Fulana", 234, "1234-X");
ContaCorrente conta6 = new ContaCorrente("José Cicrano", 432, "2314-X");
ContaCorrente conta7 = new ContaCorrente("Ana Beltrana", 332, "1111-X");
ContaCorrente conta8 = new ContaCorrente("Anonymous", 765, "0984-X");
Console.WriteLine("Total de Contas Criadas: " + ContaCorrente.TotalContasCriadas);

Cliente cliente1 = new Cliente();
cliente1.nome = "Maria Fulana";
cliente1.profissao = "Administradora";
cliente1.cpf = "12345678-90";

Cliente cliente2 = new Cliente();
cliente2.nome = "José Cicrano";
cliente2.profissao = "Analista de Dados";
cliente2.cpf = "08765438-36";

Cliente cliente3 = new Cliente();
cliente3.nome = "Ana Beltrana";
cliente3.profissao = "Empresária";
cliente3.cpf = "432576549-17";

Console.WriteLine("Total de clientes: " + Cliente.TotalClientes);