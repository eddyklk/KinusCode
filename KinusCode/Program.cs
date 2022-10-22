int r1 = 1, r2 = 3, r3 = 5, r4 = 6, r5 = 7, r6 = 8, r7 = 9, r8 = 10, r9 = 11, r10 = 12;
  //  r11 = 1, r12 = 14, r13 = 15, r14 = 16, r15 = 17, r16 = 18, r17 = 19, r18 = 20, r19 = 21, r20 = 12;

//Para digitar numero y procesarlo de mayor que 1 y menos que 80. 

//ciclo anidado un while dentro de otro while. 


do
{
    Console.WriteLine("Digite el primer numero entre el 1 y el 80");
    r1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite el segundo numero entre el 1 y el 80");
    r2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite el tercer numero entre el 1 y el 80");
    r3 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite el cuarto numero entre el 1 y el 80");
    r4 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite el quinto numero entre el 1 y el 80");
    r5 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite el sexto numero entre el 1 y el 80");
    r6 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite el septimo numero entre el 1 y el 80");
    r7 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite el octavo numero entre el 1 y el 80");
    r8 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite el noveno numero entre el 1 y el 80");
    r9 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite el decimo numero entre el 1 y el 80");
    r10 = Convert.ToInt32(Console.ReadLine());

}
while (
(r1 < 1 || r1 > 80) &&
(r2 < 1 || r2 > 80) &&
(r3 < 1 || r3 > 80) && 
(r4 < 1 || r4 > 80) && 
(r5 < 1 || r5 > 80) &&
(r6 < 1 || r6 > 80) &&
(r7 < 1 || r7 > 80) &&
(r8 < 1 || r8 > 80) &&
(r9 < 1 || r9 > 80) &&
(r10 < 1 || r10 > 80)
);

Console.WriteLine("Numeros que restan.");

List<int> lista = new List<int>()
{
    1,2,3,4,5,6,7,8,9,
    10,11,12,13,14,15,16,17,18,19,
    20,21,22,23,24,25,26,27,28,29,
    30,31,32,33,34,35,36,37,38,39,
    40,41,42,43,44,45,46,47,48,49,
    50,51,52,53,54,55,56,57,58,59,
    60,61,62,63,64,65,66,67,68,69,
    70,71,72,73,74,75,76,77,78,79,
    80
};



    // Primera jugada
    lista.Remove(r1);
    lista.Remove(r2);
    lista.Remove(r3);
    lista.Remove(r4);
    lista.Remove(r5);
    lista.Remove(r6);
    lista.Remove(r7);
    lista.Remove(r8);
    lista.Remove(r9);
    lista.Remove(r10);

    //// Segunda jugada
    //lista.Remove(r11);
    //lista.Remove(r12);
    //lista.Remove(r13);
    //lista.Remove(r14);
    //lista.Remove(r15);
    //lista.Remove(r16);
    //lista.Remove(r17);
    //lista.Remove(r18);
    //lista.Remove(r19);
    //lista.Remove(r20);



   

    foreach (var numero in lista)
    {
        Console.Write(numero + ",");
    }

    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Numero que se repiten.");

    int[] valores = new[]
    {  1,2,3,4,5,6,7,8,9,
    10,11,12,13,14,15,16,17,18,19,
    20,21,22,23,24,25,26,27,28,29,
    30,31,32,33,34,35,36,37,38,39,
    40,41,42,43,44,45,46,47,48,49,
    50,51,52,53,54,55,56,57,58,59,
    60,61,62,63,64,65,66,67,68,69,
    70,71,72,73,74,75,76,77,78,79,
    80,80,r3};




    foreach (var grouping in valores.GroupBy(t => t).Where(t => t.Count() != 1))
    {
        Console.WriteLine(string.Format("'{0}' está repetido {1} veces.", grouping.Key, grouping.Count()));
    }




    //------------------------------------------ 


    //------------------------------------------
    Console.WriteLine();


    List<int> lista2 = new List<int> { 2, 5, 6, 6, 11, 1, 1, 2, 3, 3 };

    var listaDistinct = lista2.Distinct();

    Console.Write("Numero que son unicos: ");
    foreach (int num in listaDistinct)
    {

        Console.Write(num + ",");

    }


    //------------------------------------------

    Console.WriteLine();
    Console.WriteLine("Prueba 3");
    List<int> lista3 = new List<int>()
{
    1,2,3,4,5,6,7,8,9,
    10,11,12,13,14,15,16,17,18,19,
    20,21,22,23,24,25,26,27,28,29,
    30,31,32,33,34,35,36,37,38,39,
    40,41,42,43,44,45,46,47,48,49,
    50,51,52,53,54,55,56,57,58,59,
    60,61,62,63,64,65,66,67,68,69,
    70,71,72,73,74,75,76,77,78,79,
    80
};

    lista.Add(r1);
    lista.Add(r2);
    lista.Add(r3);
    lista.Add(r4);
    lista.Add(r5);
    lista.Add(r6);
    lista.Add(r7);
    lista.Add(r8);
    lista.Add(r9);
    lista.Add(r10);

    // Segunda jugada
    //lista.Add(r11);
    //lista.Add(r12);
    //lista.Add(r13);
    //lista.Add(r14);
    //lista.Add(r15);
    //lista.Add(r16);
    //lista.Add(r17);
    //lista.Add(r18);
    //lista.Add(r19);
    //lista.Add(r20);



    foreach (var grouping in lista3.GroupBy(t => t).Where(t => t.Count() != 1))
    {
        Console.WriteLine(string.Format("'{0}' está repetido {1} veces.", grouping.Key, grouping.Count()));
    }



    Console.ReadKey();

















//// See https://aka.ms/new-console-template for more information


//int No1, No2, No3, No4, No5, No6, No7 , No8 , No9 , No10, NumG;
//double No1r, No2r, No3r, No4r, No5r, No6r, No7r, No8r, No9r, No10r;
//int num1 = 1, num2 = 2, num3 = 3, num4 = 4, num5 = 5, num6 = 6, num7 = 7, num8 = 8, num9 = 9, num10 = 10,
//    num11 = 11, num12 = 12, num13 = 13, num14 = 14, num15 = 15, num16 = 16, num17 = 17, num18 = 18, num19 = 19, num20 = 20,
//    num21 = 21, num22 = 22, num23 = 23, num24 = 24, num25 = 25, num26 = 26, num27 = 27, num28 = 28, num29 = 29, num30 = 30,
//    num31 = 31, num32 = 32, num33 = 33, num34 = 34, num35 = 35, num36 = 36, num37 = 37, num38 = 38, num39 = 39, num40 = 40,
//    num41 = 41, num42 = 42, num43 = 43, num44 = 44, num45 = 45, num46 = 46, num47 = 47, num48 = 48, num49 = 49, num50 = 50,
//    num51 = 51, num52 = 52, num53 = 53, num54 = 54, num55 = 55, num56 = 56, num57 = 57, num58 = 58, num59 = 59, num60 = 60,
//    num61 = 61, num62 = 62, num63 = 63, num64 = 64, num65 = 65, num66 = 66, num67 = 67, num68 = 68, num69 = 69, num70 = 70,
//    num71 = 71, num72 = 72, num73 = 73, num74 = 74, num75 = 75, num76 = 76, num77 = 77, num78 = 78;

////for para generar los numero del 1 al 78.
////comparar los numero dado con los que no.


//Console.WriteLine("Bienvenido a Kinus.");
//Console.WriteLine("Digite una jugada");
//Console.ReadKey();
//Console.WriteLine("Digite el numero 1");
//No1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Digite el numero 2");
//No2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Digite el numero 3");
//No3 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Digite el numero 4");
//No4 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Digite el numero 5");
//No5 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Digite el numero 6");
//No6 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Digite el numero 7");
//No7 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Digite el numero 8");
//No8 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Digite el numero 9");
//No9 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Digite el numero 10");
//No10 = Convert.ToInt32(Console.ReadLine());
//Console.ReadKey();



//if (No1 > num78)
//{
//    Console.WriteLine("El numero no puede ser mayor a 78.");
//    return;


//}
//else if (No1 < 0)
//{
//    Console.WriteLine("El numero no puede ser menor a 0.");

//}
//else if (No1 == num1)
//{
//    No1;
//}
//Console.ReadKey();