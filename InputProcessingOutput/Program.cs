/* Escreva um algoritmo para calcular e exibir o número de lâmpadas necessárias para iluminar determinado cômodo de uma residência.
Entrada de dados: a potência da lâmpada utilizada (em watts) e as dimensões (largura e comprimento, em metros) do cômodo.

Considere que a potência necessária é de 18 watts por metro quadrado.

Processamento: após o algoritmo obter os dados de entrada, ele segue a seguinte sequência:

Calcula quantos metros quadrados possui o cômodo multiplicando width por length.
Calcula o quociente X dividindo a potência da lâmpada que será utilizada por 18, quantidade necessária para iluminar 1 metro quadrado.
Calcula a quantidade de lâmpadas necessárias dividindo o total de metros quadrados do cômodo pelo quociente X.
Saída de Dados: Uma mensagem coerente e bem formatada deve ser exibida na tela do Console para a pessoa que utiliza o programa e forneceu os dados de entrada. */

// input
Console.WriteLine("Digite a potência da lâmpada (em watts):");
int power = int.Parse(Console.ReadLine());

Console.WriteLine("Digite a largura do cômodo:");
int width = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o comprimento do cômodo:");
int length = int.Parse(Console.ReadLine());

// processing
decimal area = width * length;
decimal x = power / 18;
int lamps = (int) Math.Ceiling(area / x);

// output
Console.WriteLine($"Para iluminar uma área de {area.ToString("N2")}m², a quantidade de lâmpada(s) necessária(s) será de {lamps} lâmpada(s).");