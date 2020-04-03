using System;

namespace Ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------- BIENVENIDO ----------------");
            metodos met = new metodos();
            met.mostrarMenu();
        }

    }
    public class metodos
    {
        internal void sumarymultiplicarOp()
        {
            int num1 = 0, num2 = 0, sum = 0, prod = 0;

            Console.WriteLine("Digite El primer Numero:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite El Segundo Numero:");
            num2 = int.Parse(Console.ReadLine());

            sum = num1 + num2;
            prod = num1 * num2;
            Console.WriteLine(num1 + " + " + num2 + " = " + sum);
            Console.WriteLine(num1 + " * " + num2 + " = " + prod);
                      
        }

        internal void CalcPromedio()
        {
            float x = 0, sum = 0, acum = 0, prom = 0;
            Console.WriteLine("---------- Ejercicio Promedio ----------");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite valor: ");
                x = float.Parse(Console.ReadLine());
                sum = sum + x;
                acum++;
            }
            prom = sum / acum;
            Console.WriteLine("El promedio es: " + prom);

        }

        internal void calcularPerimetro()
        {
            float lado = 0, per = 0;
            Console.WriteLine("******************* Ejercicio Del Perimetro de un Cuadrado *******************");
            Console.WriteLine("Digite uno de los lados");
            lado = int.Parse(Console.ReadLine());
            per = lado * 4;
            Console.WriteLine("Perimetro: " + per);

        }

        internal void calcularPiezasAptas()
        {
            int n = 0, x = 0, acum = 0;
            float longi = 0;
            Console.WriteLine("-------- Ejercicio de perfiles de hierro");
            Console.WriteLine("Digite Cantidad de piezas");
            n = int.Parse(Console.ReadLine());
            while (x < n)
            {

                Console.WriteLine("Digite Longitud de perfil " + (x + 1) + ": ");
                longi = float.Parse(Console.ReadLine());
                if (longi >= 1.20 && longi <= 1.30)
                {
                    acum++;
                }
                x++;
            }
            Console.WriteLine("Hay: " + acum + " piezas aptas en el lote");
        }

        internal void calcularPromedio()
        {
            float num1 = 0, num2 = 0, num3 = 0, num4 = 0, suma = 0, prom = 0;
            Console.WriteLine("---------- Calculo del Promedio -----------");
            Console.WriteLine("Digite el primer Numero: ");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite el segundo Numero: ");
            num2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite el tercer Numero: ");
            num3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite el cuarto Numero: ");
            num4 = float.Parse(Console.ReadLine());
            suma = num1 + num2 + num3 + num4;
            Console.WriteLine("La suma es: " + suma);
            prom = suma / 4;
            Console.WriteLine("El promedio es: " + prom);

        }

        internal void calcularSueldos()
        {
            int sueldo = 0;
            Console.WriteLine("------- Ejercicio del sueldo --------");
            Console.WriteLine("Digite El sueldo que gana: ");
            sueldo = int.Parse(Console.ReadLine());
            if (sueldo > 3000)
            {
                Console.WriteLine("Debe Abonar impuestos");
            }
            else
            {
                Console.WriteLine("No debe abonar impuestos")
;
            }
        }

        internal void imprimirde1aValor()
        {
            int valor = 0, x = 0;

            Console.WriteLine("------ Ejercicio valor positivo --------");
            Console.WriteLine("Ingrese Valor: ");
            valor = int.Parse(Console.ReadLine());
            if (valor >= 0)
            {
                while (x <= valor)
                {
                    x++;
                    Console.WriteLine(x);
                }
            }
            else
            {
                Console.WriteLine("El valor es negativo");
            }
        }


        internal void mostrarEntreUnoyCinco()
        {
            String num = "";
            Console.WriteLine("------ Ejercicio de Uno-Cinco -------");
            Console.WriteLine("Digite El valor en castellano (Ejemplo cinco):");

            num = Console.ReadLine();

            switch (num)
            {
                case "uno":
                    Console.WriteLine("1");
                    break;
                case "dos":
                    Console.WriteLine("2");
                    break;
                case "tres":
                    Console.WriteLine("3");
                    break;
                case "cuatro":
                    Console.WriteLine("4");
                    break;
                case "cinco":
                    Console.WriteLine("5");
                    break;
                default:
                    Console.WriteLine("Lo sentimos, el valor esta fuera del rango");
                    break;
            }

        }

        internal void mostrarUnoyCinco()
        {
            int num = 0;
            Console.WriteLine("------ Ejercicio de 1-5 -------");
            Console.WriteLine("Digite El valor");
            num = int.Parse(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.WriteLine("uno");
                    break;
                case 2:
                    Console.WriteLine("dos");
                    break;
                case 3:
                    Console.WriteLine("tres");
                    break;
                case 4:
                    Console.WriteLine("cuatro");
                    break;
                case 5:
                    Console.WriteLine("cinco");
                    break;
                default:
                    Console.WriteLine("Lo sentimos, el valor esta fuera del rango");
                    break;
            }

        }

        internal void sumaryMultiplicar()
        {
            float num1 = 0, num2 = 0, num3 = 0, num4 = 0, suma = 0, prod = 0;
            Console.WriteLine("Suma de 1 y 2 Y producto de 3 y 4");
            Console.WriteLine("Digite el primer numero");
            num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite el segundo numero");
            num2 = float.Parse(Console.ReadLine());
            suma = num1 + num2;
            Console.WriteLine("Digite el tercer numero");
            num3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite el cuarto numero");
            num4 = float.Parse(Console.ReadLine());
            prod = num3 * num4;
            Console.WriteLine(num1 + " + " + num2 + " = " + suma);
            Console.WriteLine(num3 + " * " + num4 + " = " + prod);

        }

        internal void verificarMayoroMenor()
        {
            int num1 = 0, num2 = 0, sum = 0, dif = 0, pro = 0, div = 0;
            Console.WriteLine("------ Ejercicio de mayor o menor --------");
            Console.WriteLine("Digite el primer numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite el segundo numero: ");
            num2 = int.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                sum = num1 + num2;
                dif = num1 - num2;
                Console.WriteLine("La suma es: " + sum);
                Console.WriteLine("La Diferencia es: " + dif);
            }
            else
            {
                pro = num1 * num2;
                div = num1 / num2;
                Console.WriteLine("El producto es: " + pro);
                Console.WriteLine("La Division es: " + div);
            }


        }

        internal void verificarNotasdeAlumno()
        {
            float n1 = 0, n2 = 0, n3 = 0, prom = 0;
            Console.WriteLine("-------- Ejercicio Notas de alumno ----------");
            Console.WriteLine("Digite la nota 1: ");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite la nota 2: ");
            n2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite la nota 3: ");
            n3 = float.Parse(Console.ReadLine());
            prom = (n1 + n2 + n3) / 3;
            if (prom > 7)
            {
                Console.WriteLine("Promocionado");
            }
            else
            {
                Console.WriteLine("Su promedio no es suficiente para ser promocionado");
            }

        }

        internal void verificarNumPositivo()
        {
            float num = 0;
            Console.WriteLine("---------- Numero Positivo de 1 o 2 digitos ---------");
            Console.WriteLine("Digite numero: ");
            num = float.Parse(Console.ReadLine());

            if (num % 1 == 0)
            { //para saber si el numero es entero
                if (num > 0 && num < 100)
                {
                    if (num >= 10 && num <= 99)
                    {
                        Console.WriteLine("El numero tiene 2 digitos");
                    }
                    else
                    {
                        Console.WriteLine("El numero tiene 1 digito");
                    }
                }
            }
            else
            {
                Console.WriteLine("El numero no es entero");
            }

        }

        internal void imprimirNumeros()
        {
            int x = 1;
            Console.WriteLine("-------- Ejercicio Impresion de numero del 1-100");
            while (x <= 100)
            {

                Console.WriteLine(x);
                Console.WriteLine(" - ");
                x++;
            }

        }

        internal void VerPromedio()
        {
            float n = 0, nota = 0, sum = 0, prom = 0;
            Console.WriteLine("-------- Ejercicio de promedio --------");
            while (n < 10)
            {
                n++;
                Console.WriteLine("Digite nota " + n + ": ");
                nota = float.Parse(Console.ReadLine());
                sum = sum + nota;

            }
            prom = sum / n;
            Console.WriteLine("El promedio es: " + prom);


        }

        internal void calcNotasMayoresMenores()
        {
            float nota = 0, acu1 = 0, acu2 = 0;
            Console.WriteLine("-------- Ejercicios Notas alumnos ----------");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Digite nota " + i + ": ");
                nota = float.Parse(Console.ReadLine());
                if (nota >= 7)
                {
                    acu1++;
                }
                else
                {
                    acu2++;
                }
            }
            Console.WriteLine("Alumnos con notas mayores o iguales a 7: " + acu1);
            Console.WriteLine("Alumnos con notas menores a 7: " + acu2);

        }

        internal void calCantidadValores()
        {
            int n = 0, acu1 = 0, valor = 0;
            Console.WriteLine("-------- Ejercicio n numeros ---------");
            Console.WriteLine("Digite Tamanio n");
            n = int.Parse(Console.ReadLine());
            Random nr = new Random();
            for (int i = 0; i < n; i++)
            {
                valor = nr.Next(9000);
                Console.WriteLine(valor);
                if (valor >= 1000)
                {
                    acu1++;
                }
            }
            Console.WriteLine("Cantidad de numeros mayores a 1000: " + acu1);

        }

        internal void contarDigitos()
        {
            int x = 0, acu = 0;
            Console.WriteLine("-------- Carga de numero y conteo de dígitos ---------");
            Random rn = new Random();
            x = rn.Next(999);
            Console.WriteLine(x);
            do
            {
                x = x / 10;
                acu++;
            } while (x > 0);
            Console.WriteLine(acu);

        }

        internal void hallarValor()
        {
            float valor = 0, prom = 0, suma = 0, acum = 0;
            Console.WriteLine("------ Ejercicio carga de valores --------");
            Random rn = new Random();
            do
            {
                valor = rn.Next(10);
                Console.WriteLine("valor: " + valor);
                suma = suma + valor;
                acum++;
            } while (valor > 0);
            prom = suma / (acum - 1);
            Console.WriteLine("El valor es: " + prom);

        }

        internal void Acumular()
        {

            int sum = 0, valor = 0;
            Console.WriteLine("------- Ejercicio acumular valores ---------");
            Random rn = new Random();
            do
            {
                valor = rn.Next(10000);
                sum = sum + valor;
                Console.WriteLine("--- " + valor);
            } while (valor != 9999);

            if (sum > 0)
            {
                Console.WriteLine("El acumulado es mayor que 0");
                Console.WriteLine("El acumulado es: " + sum);
            }
            if (sum == 0)
            {
                Console.WriteLine("El acumulado es igual que 0");
                Console.WriteLine("El acumulado es: " + sum);
            }
            if (sum < 0)
            {
                Console.WriteLine("El acumulado es menor que 0");
                Console.WriteLine("El acumulado es: " + sum);

            }
        }

        internal void almacenarSueldos()
        {
            int[] sueldos;
            int valor = 0;
            sueldos = new int[5];
            Console.WriteLine("------- Ejercicio de sueldos -------");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite sueldo: ");
                valor = int.Parse(Console.ReadLine());
                sueldos[i] = valor;
            }
            foreach (int s in sueldos)
            {
                Console.WriteLine("Sueldo: " + s);
            }

        }

        internal void MostrarMayora()
        {
            int[] ele;
            int n = 0, valor = 0, acu = 0;
            Console.WriteLine("------- Ejercicio mayor a 100 ---------");
            Console.WriteLine("Digite cantidad de elementos: ");
            n = int.Parse(Console.ReadLine());
            ele = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Digite valor: ");
                valor = int.Parse(Console.ReadLine());
                ele[i] = valor;
            }
            foreach (int key in ele)
            {
                if (key > 100)
                {
                    acu++;
                }
            }
            Console.WriteLine("Cantidad de valores superiores a 100: " + acu);

        }

        internal void VerStackProperty()
        {
            int i = 0, j = 0;
            Console.WriteLine("-------- Ejercicio 1 Try Catch -------");
            try
            {
                i = 10 / j;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
                Console.WriteLine("Propiedad StackTrace: " + e.StackTrace);

            }
        }

        internal void mostrarTabla()
        {           
            Console.WriteLine("-------- Try Catch ejercicio 2 ---------");

            try
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine("5*" + i + ":" + 5 * i);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }

        }

        internal void imprimirNumerosfor()
        {
            Console.WriteLine("------------ Numeros del 1-100 -------------");
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
                Console.WriteLine(" - ");
            }

        }

        internal void mostrarMenu()
        {
            int opcion = 0;
            Console.WriteLine("------ Todos los ejercicios --------");
            Console.WriteLine("-- Menú --");
            Console.WriteLine("Para la suma y producto presione 1");
            Console.WriteLine("Para calcular perimetro presiones 2");
            Console.WriteLine("Para las sumas y productos presione 3");
            Console.WriteLine("Para calcular promedio presione 4");
            Console.WriteLine("Para ejercicio de sueldos presione 5");
            Console.WriteLine("Para ejercicio de mayormenor presione 6");
            Console.WriteLine("Para ejercicio de numeros positivos presione 7");
            Console.WriteLine("Para ejercicio de notas de alumno presione 8");
            Console.WriteLine("Para ejercicio de Switch #1 presione 9");
            Console.WriteLine("Para ejercicio de switch #2 presione 10");
            Console.WriteLine("Para ejercicio de while #1 presione 11");
            Console.WriteLine("Para ejercicio de while #2 presione 12");
            Console.WriteLine("Para ejercicio de while #3 presione 13");
            Console.WriteLine("Para ejercicio de while #4 presione 14");
            Console.WriteLine("Para ejercicio de for #1 presione 15");
            Console.WriteLine("Para ejercicio de for #2 presione 16");
            Console.WriteLine("Para ejercicio de for #3 presione 17");
            Console.WriteLine("Para ejercicio de for #4 presione 18");
            Console.WriteLine("Para ejercicio de do-while #1 presione 19");
            Console.WriteLine("Para ejercicio de do-while #2 presione 20");
            Console.WriteLine("Para ejercicio de do-while #3 presione 21");
            Console.WriteLine("Para ejercicio de foreach #1 presione 22");
            Console.WriteLine("Para ejercicio de foreach #2 presione 23");
            Console.WriteLine("Para ejercicio de try catch #1 presione 24");
            Console.WriteLine("Para ejercicio de try catch #2 presione 25");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    sumarymultiplicarOp();
                    Console.WriteLine("Desea volver al menú(si o no)?:");
                    if (Console.ReadLine() == "si"){
                        mostrarMenu();
                    }
                    else{ 
                        Environment.Exit(0);
                    }
                    break;
                case 2:
                    calcularPerimetro();
                    Console.WriteLine("Desea volver al menú(si o no)?:");
                    if (Console.ReadLine() == "si"){
                        mostrarMenu();
                    }
                    else{
                        Environment.Exit(0);
                    }
                    break;
                case 3:
                    sumaryMultiplicar();
                    Console.WriteLine("Desea volver al menú(si o no)?:");
                    if (Console.ReadLine() == "si"){
                        mostrarMenu();
                    }
                    else{
                        Environment.Exit(0);
                    }
                    break;
                case 4:
                    calcularPromedio();
                    Console.WriteLine("Desea volver al menú(si o no)?:");
                    if (Console.ReadLine() == "si"){
                        mostrarMenu();
                    }
                    else{
                        Environment.Exit(0);
                    }
                    break;
                case 5:
                    calcularSueldos();
                    Console.WriteLine("Desea volver al menú(si o no)?:");
                    if (Console.ReadLine() == "si"){
                        mostrarMenu();
                    }
                    else{
                        Environment.Exit(0);
                    }
                    break;
                case 6:
                    verificarMayoroMenor();
                    Console.WriteLine("Desea volver al menú(si o no)?:");
                    if (Console.ReadLine() == "si"){
                        mostrarMenu();
                    }
                    else{
                        Environment.Exit(0);
                    }
                    break;
                case 7:
                    verificarNumPositivo();
                    Console.WriteLine("Desea volver al menú(si o no)?:");
                    if (Console.ReadLine() == "si"){
                        mostrarMenu();
                    }
                    else{
                        Environment.Exit(0);
                    }
                    break;
                case 8:
                    verificarNotasdeAlumno();
                    Console.WriteLine("Desea volver al menú(si o no)?:");
                    if (Console.ReadLine() == "si"){
                        mostrarMenu();
                    }
                    else{
                        Environment.Exit(0);
                    }
                    break;
                case 9:
                    mostrarUnoyCinco(); //Ejercicio #1 de swicth
                    Console.WriteLine("Desea volver al menú(si o no)?:");
                    if (Console.ReadLine() == "si"){
                        mostrarMenu();
                    }
                    else{
                        Environment.Exit(0);
                    }
                    break;
                case 10:
                    mostrarEntreUnoyCinco(); //Ejercicio #2 de swicth
                    Console.WriteLine("Desea volver al menú(si o no)?:");
                    if (Console.ReadLine() == "si"){
                        mostrarMenu();
                    }
                    else{
                        Environment.Exit(0);
                    }
                    break;
                case 11:
                    imprimirNumeros(); //Ejercicio #1 while
                    Console.WriteLine("Desea volver al menú(si o no)?:");
                    if (Console.ReadLine() == "si"){
                        mostrarMenu();
                    }
                    else{
                        Environment.Exit(0);
                    }
                    break;
                case 12:
                    imprimirde1aValor(); //Ejercicio #2 while
                    Console.WriteLine("Desea volver al menú(si o no)?:");
                    if (Console.ReadLine() == "si"){
                        mostrarMenu();
                    }
                    else{
                        Environment.Exit(0);
                    }
                    break;
                case 13:
                    VerPromedio(); //Ejercicio #3 while
                    Console.WriteLine("Desea volver al menú(si o no)?:");
                    if (Console.ReadLine() == "si"){
                        mostrarMenu();
                    }
                    else{
                        Environment.Exit(0);
                    }
                    break;
                case 14:
                    calcularPiezasAptas(); //Ejercicio #4 while
                    Console.WriteLine("Desea volver al menú(si o no)?:");
                    if (Console.ReadLine() == "si"){
                        mostrarMenu();
                    }
                    else{
                        Environment.Exit(0);
                    }
                    break;
                case 15:
                    imprimirNumerosfor(); //Ejercicio #1 for
                    Console.WriteLine("Desea volver al menú(si o no)?:");
                    if (Console.ReadLine() == "si"){
                        mostrarMenu();
                    }
                    else{
                        Environment.Exit(0);
                    }
                    break;
                case 16:
                    CalcPromedio(); //Ejercicio #2 for
                    Console.WriteLine("Desea volver al menú(si o no)?:");
                    if (Console.ReadLine() == "si"){
                        mostrarMenu();
                    }
                    else{
                        Environment.Exit(0);
                    }
                    break;
                case 17:
                    calcNotasMayoresMenores(); //Ejercicio #3 for
                    Console.WriteLine("Desea volver al menú(si o no)?:");
                    if (Console.ReadLine() == "si"){
                        mostrarMenu();
                    }
                    else{
                        Environment.Exit(0);
                    }
                    break;
                case 18:
                    calCantidadValores(); //Ejercicio #4 for
                    Console.WriteLine("Desea volver al menú(si o no)?:");
                    if (Console.ReadLine() == "si"){
                        mostrarMenu();
                    }
                    else{
                        Environment.Exit(0);
                    }
                    break;
                case 19:
                    contarDigitos(); //Ejercicio #1 do-while
                    Console.WriteLine("Desea volver al menú(si o no)?:");
                    if (Console.ReadLine() == "si"){
                        mostrarMenu();
                    }
                    else{
                        Environment.Exit(0);
                    }
                    break;
                case 20:
                    hallarValor(); //Ejercicio #2 do-while
                    Console.WriteLine("Desea volver al menú(si o no)?:");
                    if (Console.ReadLine() == "si"){
                        mostrarMenu();
                    }
                    else{
                        Environment.Exit(0);
                    }
                    break;
                case 21:
                    Acumular(); //Ejercicio #3 do-while
                    Console.WriteLine("Desea volver al menú(si o no)?:");
                    if (Console.ReadLine() == "si"){
                        mostrarMenu();
                    }
                    else{
                        Environment.Exit(0);
                    }
                    break;
                case 22:
                    almacenarSueldos(); //Ejercicio #1 foreach
                    Console.WriteLine("Desea volver al menú(si o no)?:");
                    if (Console.ReadLine() == "si"){
                        mostrarMenu();
                    }
                    else{
                        Environment.Exit(0);
                    }
                    break;
                case 23:
                    MostrarMayora(); //Ejercicio #2 foreach
                    Console.WriteLine("Desea volver al menú(si o no)?:");
                    if (Console.ReadLine() == "si"){
                        mostrarMenu();
                    }
                    else{
                        Environment.Exit(0);
                    }
                    break;
                case 24:
                    VerStackProperty(); //Ejercicio #1 try catch
                    Console.WriteLine("Desea volver al menú(si o no)?:");
                    if (Console.ReadLine() == "si"){
                        mostrarMenu();
                    }
                    else{
                        Environment.Exit(0);
                    }
                    break;
                case 25:
                    mostrarTabla(); //Ejercicio #2 try catch
                    Console.WriteLine("Desea volver al menú(si o no)?:");
                    if (Console.ReadLine() == "si"){
                        mostrarMenu();
                    }
                    else{
                        Environment.Exit(0);
                    }
                    break;
                default:
                    Console.WriteLine("Lo sentimos no tenemos esa opcion dentro de nuestro menú");
                    Console.WriteLine("Desea volver a intentarlo(si o no)?:");
                    if (Console.ReadLine() == "si"){
                        mostrarMenu();
                    }
                    else{
                        Environment.Exit(0);
                    }
                    break;
            }
        }
    }
}
