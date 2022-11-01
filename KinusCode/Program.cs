
//jugada 1
using System.Runtime.Intrinsics;

int r1 = 0, r2 = 0, r3 = 0, r4 = 0, r5 = 0, r6 = 0, r7 = 0, r8 = 0, r9 = 0, r10 = 0,
//jugada 2
r11 = 0, r12 = 0, r13 = 0, r14 = 0, r15 = 0, r16 = 0, r17 = 0, r18 = 0, r19 = 0, r20 = 0,
//Jugara 3
r21 = 0, r22 = 0, r23 = 0, r24 = 0, r25 = 0, r26 = 0, r27 = 0, r28 = 0, r29 = 0, r30 = 0,
//Jugara 3
r31 = 0, r32 = 0, r33 = 0, r34 = 0, r35 = 0, r36 = 0, r37 = 0, r38 = 0, r39 = 0, r40 = 0;

//Para digitar numero y procesarlo de mayor que 1 y menos que 80. 

//ciclo anidado un while dentro de otro while. 
Console.ForegroundColor = ConsoleColor.White;

do
{
    Console.WriteLine("Digite el primer numero  entre el 1 y el 80");
    r1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite el segundo numero entre el 1 y el 80");
    r2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite el tercer numero  entre el 1 y el 80");
    r3 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite el cuarto numero  entre el 1 y el 80");
    r4 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite el quinto numero  entre el 1 y el 80");
    r5 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite el sexto numero   entre el 1 y el 80");
    r6 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite el septimo numero entre el 1 y el 80");
    r7 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite el octavo numero  entre el 1 y el 80");
    r8 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite el noveno numero  entre el 1 y el 80");
    r9 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite el decimo numero  entre el 1 y el 80");
    r10 = Convert.ToInt32(Console.ReadLine());

    //jugada 2
    Console.WriteLine("Digite el decimoprimer numero  entre el 1 y el 80");
    r11 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite el decimosegundo numero entre el 1 y el 80");
    r12 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite el decimotercer numero  entre el 1 y el 80");
    r13 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite el decimocuarto numero  entre el 1 y el 80");
    r14 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite el decimoquinto numero  entre el 1 y el 80");
    r15 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite el decimosexto numero   entre el 1 y el 80");
    r16 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite el decimoseptimo numero entre el 1 y el 80");
    r17 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite el decimoctavo numero  entre el 1 y el 80");
    r18 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite el decimonoveno numero  entre el 1 y el 80");
    r19 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite el vigésimo numero  entre el 1 y el 80");
    r20 = Convert.ToInt32(Console.ReadLine());

    //jugada 3
    Console.WriteLine("Digite el vigésimoprimer numero  entre el 1 y el 80");
    r21 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite el vigésimosegundo numero entre el 1 y el 80");
    r22 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite el vigésimotercer numero  entre el 1 y el 80");
    r23 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite el vigésimocuarto numero  entre el 1 y el 80");
    r24 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite el vigésimoquinto numero  entre el 1 y el 80");
    r25 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite el vigésimosexto numero   entre el 1 y el 80");
    r26 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite el vigésimoseptimo numero entre el 1 y el 80");
    r27 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite el vigésimoctavo numero  entre el 1 y el 80");
    r28 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite el vigésimonoveno numero  entre el 1 y el 80");
    r29 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite el trigésimo numero  entre el 1 y el 80");
    r30 = Convert.ToInt32(Console.ReadLine());

    //jugada 4
    Console.WriteLine("Digite el trigesimoprimer numero  entre el 1 y el 80");
    r31 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite el trigesimosegundo numero entre el 1 y el 80");
    r32 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite el trigesimotercer numero  entre el 1 y el 80");
    r33 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite el trigesimocuarto numero  entre el 1 y el 80");
    r34 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite el trigesimoquinto numero  entre el 1 y el 80");
    r35 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite el trigesimosexto numero   entre el 1 y el 80");
    r36 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite el trigesimoseptimo numero entre el 1 y el 80");
    r37 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite el trigesimoctavo numero  entre el 1 y el 80");
    r38 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite el trigesimonoveno numero  entre el 1 y el 80");
    r39 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite el Cuadragésimo numero  entre el 1 y el 80");
    r40 = Convert.ToInt32(Console.ReadLine());

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


Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Green;
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

    // Segunda jugada
    lista.Remove(r11);
    lista.Remove(r12);
    lista.Remove(r13);
    lista.Remove(r14);
    lista.Remove(r15);
    lista.Remove(r16);
    lista.Remove(r17);
    lista.Remove(r18);
    lista.Remove(r19);
    lista.Remove(r20);





foreach (var numero in lista)
    {
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write(numero + ",");
    }

    Console.WriteLine();
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Numero que se repiten.");

int[] valores = new[]{
    r1,r2,r3,r4,r5,r6,r7,r8,r9,r10,
    r11,r12,r13,r14,r15,r16,r17,r18,r19,r20,
    r21,r22,r23,r24,r25,r26,r27,r28,r29,r30,
    r31,r32,r33,r34,r35,r36,r37,r38,r39,r40 };


    foreach (var grouping in valores.GroupBy(t => t).Where(t => t.Count() != 1))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(string.Format("'{0}' está repetido {1} veces.", grouping.Key, grouping.Count()));
    }


    //------------------------------------------ 


    //------------------------------------------
    Console.WriteLine();


    List<int> lista2 = new List<int> { 
    r1,r2,r3,r4,r5,r6,r7,r8,r9,r10,
    r11,r12,r13,r14,r15,r16,r17,r18,r19,r20,
    r21,r22,r23,r24,r25,r26,r27,r28,r29,r30,
    r31,r32,r33,r34,r35,r36,r37,r38,r39,r40 };

    var listaDistinct = lista2.Distinct();

    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("Numero que son unicos: ");
    foreach (int num in listaDistinct)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(num + ",");

    }


    //------------------------------------------






    crear numero random a partir de los que existen en la variable num


    Console.ReadKey();
















