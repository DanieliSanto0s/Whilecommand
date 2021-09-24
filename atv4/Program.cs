using System;

namespace atv4
{
    class Program
    {
        static void Main(string[] args)
        {
            int maMatricula;
            Double maNota;

            int Matricula;
            Double Nota;

            string nome;
            string maNome = string.Empty;

            maNota = 0;
            maMatricula = 0;
        

            int contador = 1;
            while (contador <= 15)
            {
                Console.WriteLine("");
                Console.Write("Informe o nome do aluno: ");
                nome = (Console.ReadLine());
                Console.WriteLine("");
                Console.Write("Informe a matricula do aluno: ");
                Matricula = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
                Console.Write("Informe a nota do aluno: ");
                Nota = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("");

                if (maNota < Nota)
                {
                    maNome = nome;
                    maMatricula = Matricula;
                    maNota = Nota;
                }
                contador++;
            }
            Console.WriteLine($"O nome do aluno com a nota mais alta é {maNome}, a Matricula do aluno é : {maMatricula} e a Nota que ele recebeu foi: {maNota}");
        }
    }
}
