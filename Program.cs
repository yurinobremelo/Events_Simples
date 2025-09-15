// See https://aka.ms/new-console-template for more information

public class Botao
{
    public event EventHandler? Clique; // Evento, é um delegate já pronto no .Net
    public void DispararClique()
    {
        Clique?.Invoke(this, EventArgs.Empty); // Dispara o evento
    }
}

class Program
{
    static void Main(string[] args)
    {
        Botao botao = new Botao();
        botao.Clique += Botao_Clique_Ouvinte1; // Inscreve o método no evento
        botao.DispararClique(); // Dispara o evento
        botao.Clique += Botao_Clique_Ouvinte2; // Inscreve o método no evento
        botao.Clique += Botao_Clique_Ouvinte3; // Dispara o evento
        botao.Clique += (sender,e) => Console.WriteLine("(Ouvinte 4) Botão clicado também!"); // Inscreve o método anônimo no evento
        botao.DispararClique(); // Dispara o evento

    }
    private static void Botao_Clique_Ouvinte1(object? sender, EventArgs e)
    {
        Console.WriteLine("(Ouvinte 1) Botão clicado!");
    }
    private static void Botao_Clique_Ouvinte2(object? sender, EventArgs e)
    {
        Console.WriteLine("(Ouvinte 2) Botão clicado!");
    }
    private static void Botao_Clique_Ouvinte3(object? sender, EventArgs e)
    {
        Console.WriteLine("(Ouvinte 3) Botão clicado!");
    }
}