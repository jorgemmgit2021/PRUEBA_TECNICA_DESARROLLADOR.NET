using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PRUEBA_TECNICA_DESARROLLADOR
{
    class Program
    {
        static void Main(string[] args){
            init:
            Console.WriteLine("PRUEBA TECNICA DESARROLLADOR C# JUNIOR");
            Console.WriteLine("Digite el numero de ejercicio");
            int ej = 0;
            string val = Console.ReadLine();
            if (!int.TryParse(val, out ej)) goto init;
            switch (ej){
                case 1: new MyArray(); break;
                case 2: new Histograma(); break;
                case 3: new SumaDigitos(); break;
                default:break;
            }
            Console.WriteLine("¿Finalizar prueba? S/N");
            if(Console.ReadLine().ToUpper()=="N")goto init;
        }
    }
    public class MyArray{
        public MyArray(){
            Console.WriteLine("PRUEBA TECNICA DESARROLLADOR C# JUNIOR");
            Console.WriteLine("Ejercicio 1: Imprimir el valor mayor dentro de un array");
            Console.WriteLine("Ingrese 5 números separados por un espacio");
            var _entry = Console.ReadLine().Split(' ');
            int[] elementos = new int[5];
            int i = -1;
            int value;
            foreach (string numero in _entry){
                if(int.TryParse(numero, out value)&&value<=100 && value> 0)elementos[++i]= Convert.ToInt32(numero);
                else{
                    Console.WriteLine("El contenido de la secuencia incluye caracteres o números menores a 0 o  mayores a 100");
                    return;
                }
            }
            Busqueda_Numero_Mayor(elementos);
        }
        public void Busqueda_Numero_Mayor(int[] MyArray){
            int Mayor = 0;
            foreach (int elemento in MyArray){
                if (elemento > Mayor) Mayor = elemento;
            }
            Console.WriteLine($"El numero mayor en la secuencia es {Mayor}");
        }
    }

    public class Histograma{
        public Histograma(){
            Console.WriteLine("PRUEBA TECNICA DESARROLLADOR C# JUNIOR");
            Console.WriteLine("Ejercicio 2: Histograma de frecuencia");
            Console.WriteLine("Ingrese 10 dígitos mayores a 0 y menores a 6 separados por un espacio");
            var _entry = Console.ReadLine().Split(' ');
            int[] elementos = new int[10];
            int i = -1;
            int value;
            foreach (string numero in _entry){
                if (int.TryParse(numero, out value) && value <= 5 && value > 0) elementos[++i] = Convert.ToInt32(numero);
                else{
                    Console.WriteLine("El contenido de la secuencia incluye caracteres o números menores a 0 o  mayores a 5");
                    return;
                }
            }
            Mostrar_Histograma(elementos);
        }
        private void Mostrar_Histograma(int[] myArray){
            StringBuilder stringBuilder = new StringBuilder("1: '\n' 2:'\n' 3:'\n'4:'\n'5:'\n'");
            foreach (int digito in myArray){
                switch (digito){
                    case 1:stringBuilder.Replace("1:", "1:*"); break;
                    case 2:stringBuilder.Replace("2:", "2:*"); break;
                    case 3:stringBuilder.Replace("3:", "3:*"); break;
                    case 4:stringBuilder.Replace("4:", "4:*"); break;
                    case 5:stringBuilder.Replace("5:", "5:*"); break;
                    default:break;
                }
            }
            Console.WriteLine(stringBuilder.ToString());
        }
    }

    public class SumaDigitos{
        public SumaDigitos(){
            Console.WriteLine("PRUEBA TECNICA DESARROLLADOR C# JUNIOR");
            Console.WriteLine("Ejercicio 3: Calcular resultado igual a 10 con 2 elementos de entrada");
            Console.WriteLine("Ingrese 6 dígitos mayores a 0 y menores a 10 separados por un espacio");
            var _entry = Console.ReadLine().Split(' ');
            int[] elementos =new int[6];
            int i = -1;
            int value;
            foreach (string numero in _entry){
                if (int.TryParse(numero, out value) && value <= 9 && value > 0) elementos[++i] = Convert.ToInt32(numero);
                else{
                    Console.WriteLine("El contenido de la secuencia incluye caracteres o números menores a 0 o  mayores a 9");
                    return;
                }
            }
            Calcular_Resultado(elementos);
        }

        private void Calcular_Resultado(int[] elementos){
            foreach (int digito in elementos){
                int i = -1;
                int v = 0;
                while (i<elementos.Length){
                    int x = (int)elementos.GetValue(++i);
                    v = x + digito;
                    if(v == 10 || i == 5) break;
                }
                if (v == 10) { Console.WriteLine($"{digito} {elementos.GetValue(i)}"); return; }
            }
        }
    }
}
