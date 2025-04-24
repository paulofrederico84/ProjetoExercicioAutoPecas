using ProjetoExercicioAutoPecas.Menus;

namespace ProjetoExercicioAutoPecas
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.Main();

            string caminhoBanco = BuscarCaminhoBanco();
            
            if (!File.Exists(caminhoBanco))
            {
                Console.WriteLine("Arquivo de banco de dados não encontrado.");
                return;
            }
            
            string[] linhas = File.ReadAllLines(caminhoBanco);
            foreach (string linha in linhas)
            {
                Console.WriteLine(linha);
            }
            
        }

        private static string BuscarCaminhoBanco()        
        {            
            return @"C:\Users\Paulo\OneDrive\Área de Trabalho\AULA PROGRAMAÇÃO\Entra21\C#\ProjetoExercicio\ProjetoExercicioAutoPecas\BancoDados";
        }
    }
    
}