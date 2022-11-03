







//jugada 1
int r1 = 0, r2 = 0, r3 = 0, r4 = 0, r5 = 0, r6 = 0, r7 = 0, r8 = 0, r9 = 0, r10 = 0,
//jugada 2
r11 = 0, r12 = 0, r13 = 0, r14 = 0, r15 = 0, r16 = 0, r17 = 0, r18 = 0, r19 = 0, r20 = 0,
//Jugara 3
r21 = 0, r22 = 0, r23 = 0, r24 = 0, r25 = 0, r26 = 0, r27 = 0, r28 = 0, r29 = 0, r30 = 0,
//Jugara 3
r31 = 0, r32 = 0, r33 = 0, r34 = 0, r35 = 0, r36 = 0, r37 = 0, r38 = 0, r39 = 0, r40 = 0,
//numero que salieron
s1 = 0, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12, s13, s14, s15, s16, s17, s18, s19, s20, numjugada;
bool jugada;


Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("Bienvenido a Kinus intento hacerte");
Console.ForegroundColor = ConsoleColor.Green;
Console.Write(" MILLONARIO");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine(" :)");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Ahora, dime cuantas jugadas quieres agregar? ");
numjugada = Convert.ToInt32(Console.ReadLine());



//aqui entra un ciclo anidado un switch/case y dentro un while dentro de otro while. 
switch (numjugada)
{
    case 1:


        do
        {
            Console.WriteLine("Digite el primer numero  entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r1 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el segundo numero entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r2 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el tercer numero  entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r3 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el cuarto numero  entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r4 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el quinto numero  entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r5 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el sexto numero   entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r6 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el septimo numero entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r7 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el octavo numero  entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r8 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el noveno numero  entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r9 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el decimo numero  entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r10 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;

           

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




        break;
    case 2:

        do
        {
            Console.WriteLine("Digite el primer numero  entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r1 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el segundo numero entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r2 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el tercer numero  entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r3 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el cuarto numero  entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r4 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el quinto numero  entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r5 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el sexto numero   entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r6 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el septimo numero entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r7 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el octavo numero  entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r8 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el noveno numero  entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r9 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el decimo numero  entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r10 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;

            //jugada 2
            Console.WriteLine("Digite el decimoprimer numero  entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r11 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el decimosegundo numero entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r12 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el decimotercer numero  entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r13 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el decimocuarto numero  entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r14 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el decimoquinto numero  entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r15 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el decimosexto numero   entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r16 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el decimoseptimo numero entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r17 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el decimoctavo numero  entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r18 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el decimonoveno numero  entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r19 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el vigésimo numero  entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r20 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;

           

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
        (r10 < 1 || r10 > 80)&&

        (r11 < 1 || r11 > 80) &&
        (r12 < 1 || r12 > 80) &&
        (r13 < 1 || r13 > 80) &&
        (r14 < 1 || r14 > 80) &&
        (r15 < 1 || r15 > 80) &&
        (r16 < 1 || r16 > 80) &&
        (r17 < 1 || r17 > 80) &&
        (r18 < 1 || r18 > 80) &&
        (r19 < 1 || r19 > 80) &&
        (r20 < 1 || r20 > 80)

      
        );



        break;
    case 3:

        do
        {
            Console.WriteLine("Digite el primer numero  entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r1 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el segundo numero entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r2 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el tercer numero  entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r3 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el cuarto numero  entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r4 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el quinto numero  entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r5 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el sexto numero   entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r6 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el septimo numero entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r7 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el octavo numero  entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r8 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el noveno numero  entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r9 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el decimo numero  entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r10 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;

            //jugada 2
            Console.WriteLine("Digite el decimoprimer numero  entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r11 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el decimosegundo numero entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r12 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el decimotercer numero  entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r13 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el decimocuarto numero  entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r14 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el decimoquinto numero  entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r15 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el decimosexto numero   entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r16 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el decimoseptimo numero entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r17 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el decimoctavo numero  entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r18 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el decimonoveno numero  entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r19 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el vigésimo numero  entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r20 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;

            //jugada 3
            Console.WriteLine("Digite el vigésimoprimer numero  entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r21 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el vigésimosegundo numero entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r22 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el vigésimotercer numero  entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r23 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el vigésimocuarto numero  entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r24 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el vigésimoquinto numero  entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r25 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el vigésimosexto numero   entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r26 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el vigésimoseptimo numero entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r27 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el vigésimoctavo numero  entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r28 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el vigésimonoveno numero  entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r29 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el trigésimo numero  entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r30 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;



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
        (r10 < 1 || r10 > 80) &&

        (r11 < 1 || r11 > 80) &&
        (r12 < 1 || r12 > 80) &&
        (r13 < 1 || r13 > 80) &&
        (r14 < 1 || r14 > 80) &&
        (r15 < 1 || r15 > 80) &&
        (r16 < 1 || r16 > 80) &&
        (r17 < 1 || r17 > 80) &&
        (r18 < 1 || r18 > 80) &&
        (r19 < 1 || r19 > 80) &&
        (r20 < 1 || r20 > 80) &&

        (r21 < 1 || r21 > 80) &&
        (r22 < 1 || r22 > 80) &&
        (r23 < 1 || r23 > 80) &&
        (r24 < 1 || r24 > 80) &&
        (r25 < 1 || r25 > 80) &&
        (r26 < 1 || r26 > 80) &&
        (r27 < 1 || r27 > 80) &&
        (r28 < 1 || r28 > 80) &&
        (r29 < 1 || r29 > 80) &&
        (r30 < 1 || r30 > 80)
        );
      



        break;
    case 4:

        do
        {
            Console.WriteLine("Digite el primer numero  entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r1 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el segundo numero entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r2 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el tercer numero  entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r3 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el cuarto numero  entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r4 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el quinto numero  entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r5 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el sexto numero   entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r6 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el septimo numero entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r7 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el octavo numero  entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r8 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el noveno numero  entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r9 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el decimo numero  entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r10 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;

            //jugada 2
            Console.WriteLine("Digite el decimoprimer numero  entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r11 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el decimosegundo numero entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r12 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el decimotercer numero  entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r13 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el decimocuarto numero  entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r14 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el decimoquinto numero  entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r15 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el decimosexto numero   entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r16 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el decimoseptimo numero entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r17 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el decimoctavo numero  entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r18 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el decimonoveno numero  entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r19 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el vigésimo numero  entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r20 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;

            //jugada 3
            Console.WriteLine("Digite el vigésimoprimer numero  entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r21 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el vigésimosegundo numero entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r22 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el vigésimotercer numero  entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r23 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el vigésimocuarto numero  entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r24 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el vigésimoquinto numero  entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r25 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el vigésimosexto numero   entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r26 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el vigésimoseptimo numero entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r27 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el vigésimoctavo numero  entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r28 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el vigésimonoveno numero  entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r29 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el trigésimo numero  entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r30 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;

            //jugada 4
            Console.WriteLine("Digite el trigesimoprimer numero  entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r31 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el trigesimosegundo numero entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r32 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el trigesimotercer numero  entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r33 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el trigesimocuarto numero  entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r34 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el trigesimoquinto numero  entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r35 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el trigesimosexto numero   entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r36 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el trigesimoseptimo numero entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r37 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el trigesimoctavo numero  entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r38 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el trigesimonoveno numero  entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r39 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Digite el Cuadragésimo numero  entre el 1 y el 80");
            Console.ForegroundColor = ConsoleColor.Yellow;
            r40 = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.White;

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
        (r10 < 1 || r10 > 80)&&

        (r11 < 1 || r11 > 80) &&
        (r12 < 1 || r12 > 80) &&
        (r13 < 1 || r13 > 80) &&
        (r14 < 1 || r14 > 80) &&
        (r15 < 1 || r15 > 80) &&
        (r16 < 1 || r16 > 80) &&
        (r17 < 1 || r17 > 80) &&
        (r18 < 1 || r18 > 80) &&
        (r19 < 1 || r19 > 80) &&
        (r20 < 1 || r20 > 80) &&

        (r21 < 1 || r21 > 80) &&
        (r22 < 1 || r22 > 80) &&
        (r23 < 1 || r23 > 80) &&
        (r24 < 1 || r24 > 80) &&
        (r25 < 1 || r25 > 80) &&
        (r26 < 1 || r26 > 80) &&
        (r27 < 1 || r27 > 80) &&
        (r28 < 1 || r28 > 80) &&
        (r29 < 1 || r29 > 80) &&
        (r30 < 1 || r30 > 80) &&

         (r31 < 1 || r31 > 80) &&
        (r32 < 1 || r32 > 80) &&
        (r33 < 1 || r33 > 80) &&
        (r34 < 1 || r34 > 80) &&
        (r35 < 1 || r35 > 80) &&
        (r36 < 1 || r36 > 80) &&
        (r37 < 1 || r37 > 80) &&
        (r38 < 1 || r38 > 80) &&
        (r39 < 1 || r39 > 80) &&
        (r40 < 1 || r40 > 80)
        );



        break;
}


Console.ForegroundColor = ConsoleColor.White;


Console.WriteLine();


Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Quieres registrar los numeros que salieron?. ");
Console.WriteLine("Escriba True en caso si o escriba false en caso de que no. ");
Console.ForegroundColor = ConsoleColor.Yellow;
jugada = Convert.ToBoolean( Console.ReadLine());


Console.ForegroundColor = ConsoleColor.White;

do
{
    do
    {
        
        Console.WriteLine("Digite el primer numero  entre el 1 y el 20");
        Console.ForegroundColor = ConsoleColor.Yellow;
        s1 = Convert.ToInt32(Console.ReadLine());
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Digite el segundo numero entre el 1 y el 20");
        Console.ForegroundColor = ConsoleColor.Yellow;
        s2 = Convert.ToInt32(Console.ReadLine());
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Digite el tercer numero  entre el 1 y el 20");
        Console.ForegroundColor = ConsoleColor.Yellow;
        s3 = Convert.ToInt32(Console.ReadLine());
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Digite el cuarto numero  entre el 1 y el 20");
        Console.ForegroundColor = ConsoleColor.Yellow;
        s4 = Convert.ToInt32(Console.ReadLine());
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Digite el quinto numero  entre el 1 y el 20");
        Console.ForegroundColor = ConsoleColor.Yellow;
        s5 = Convert.ToInt32(Console.ReadLine());
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Digite el sexto numero   entre el 1 y el 20");
        Console.ForegroundColor = ConsoleColor.Yellow;
        s6 = Convert.ToInt32(Console.ReadLine());
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Digite el septimo numero entre el 1 y el 20");
        Console.ForegroundColor = ConsoleColor.Yellow;
        s7 = Convert.ToInt32(Console.ReadLine());
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Digite el octavo numero  entre el 1 y el 20");
        Console.ForegroundColor = ConsoleColor.Yellow;
        s8 = Convert.ToInt32(Console.ReadLine());
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Digite el noveno numero  entre el 1 y el 20");
        Console.ForegroundColor = ConsoleColor.Yellow;
        s9 = Convert.ToInt32(Console.ReadLine());
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Digite el decimo numero  entre el 1 y el 20");
        Console.ForegroundColor = ConsoleColor.Yellow;
        s10 = Convert.ToInt32(Console.ReadLine());
        Console.ForegroundColor = ConsoleColor.White;

        //jugada 2
        Console.WriteLine("Digite el decimoprimer numero  entre el 1 y el 20");
        Console.ForegroundColor = ConsoleColor.Yellow;
        s11 = Convert.ToInt32(Console.ReadLine());
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Digite el decimosegundo numero entre el 1 y el 20");
        Console.ForegroundColor = ConsoleColor.Yellow;
        s12 = Convert.ToInt32(Console.ReadLine());
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Digite el decimotercer numero  entre el 1 y el 20");
        Console.ForegroundColor = ConsoleColor.Yellow;
        s13 = Convert.ToInt32(Console.ReadLine());
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Digite el decimocuarto numero  entre el 1 y el 20");
        Console.ForegroundColor = ConsoleColor.Yellow;
        s14 = Convert.ToInt32(Console.ReadLine());
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Digite el decimoquinto numero  entre el 1 y el 20");
        Console.ForegroundColor = ConsoleColor.Yellow;
        s15 = Convert.ToInt32(Console.ReadLine());
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Digite el decimosexto numero   entre el 1 y el 20");
        Console.ForegroundColor = ConsoleColor.Yellow;
        s16 = Convert.ToInt32(Console.ReadLine());
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Digite el decimoseptimo numero entre el 1 y el 20");
        Console.ForegroundColor = ConsoleColor.Yellow;
        s17 = Convert.ToInt32(Console.ReadLine());
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Digite el decimoctavo numero  entre el 1 y el 20");
        Console.ForegroundColor = ConsoleColor.Yellow;
        s18 = Convert.ToInt32(Console.ReadLine());
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Digite el decimonoveno numero  entre el 1 y el 20");
        Console.ForegroundColor = ConsoleColor.Yellow;
        s19 = Convert.ToInt32(Console.ReadLine());
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Digite el vigésimo numero  entre el 1 y el 20");
        Console.ForegroundColor = ConsoleColor.Yellow;
        s20 = Convert.ToInt32(Console.ReadLine());
        Console.ForegroundColor = ConsoleColor.White;
        jugada = false;
    }
    while (
        (r1 < 1 || r1 > 20) &&
        (r2 < 1 || r2 > 20) &&
        (r3 < 1 || r3 > 20) &&
        (r4 < 1 || r4 > 20) &&
        (r5 < 1 || r5 > 20) &&
        (r6 < 1 || r6 > 20) &&
        (r7 < 1 || r7 > 20) &&
        (r8 < 1 || r8 > 20) &&
        (r9 < 1 || r9 > 20) &&
        (r10 < 1 || r10 > 20)
        );

}

while (jugada == true) 
//(r1 < 1 || r1 > 80) &&
//(r2 < 1 || r2 > 80) &&
//(r3 < 1 || r3 > 80) &&
//(r4 < 1 || r4 > 80) &&
//(r5 < 1 || r5 > 80) &&
//(r6 < 1 || r6 > 80) &&
//(r7 < 1 || r7 > 80) &&
//(r8 < 1 || r8 > 80) &&
//(r9 < 1 || r9 > 80) &&
//(r10 < 1 || r10 > 80)
;


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

    // tercera jugada
    lista.Remove(r21);
    lista.Remove(r22);
    lista.Remove(r23);
    lista.Remove(r24);
    lista.Remove(r25);
    lista.Remove(r26);
    lista.Remove(r27);
    lista.Remove(r28);
    lista.Remove(r29);
    lista.Remove(r30);

    // Cuarta jugada
    lista.Remove(r31);
    lista.Remove(r32);
    lista.Remove(r33);
    lista.Remove(r34);
    lista.Remove(r35);
    lista.Remove(r36);
    lista.Remove(r37);
    lista.Remove(r38);
    lista.Remove(r39);
    lista.Remove(r40);





foreach (var numero in lista)
    {
    Console.ForegroundColor = ConsoleColor.Yellow;
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
        Console.ForegroundColor = ConsoleColor.Yellow;
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
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write(num + ",");

    }


//------------------------------------------


//crear numero random a partir de los que existen en la variable num



    Random rnd = new Random();
    int randIndex = rnd.Next(lista2.Count);
    int random = lista2[randIndex];
    

    Console.WriteLine(random);

    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("Numero Jugados: ");

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write(r1 + " " + r2 + " " + r3 + " " + r4 + " " + r5 + " " + r6 + " " + r7 + " " + r8 + " " + r9 + " " + r10 + " " +
    r11 + " " + r12 + " " + r13 + " " + r14 + " " + r15 + " " + r16 + " " + r17 + " " + r18 + " " + r19 + " " + r20 + " " +
    r21 + " " + r22 + " " + r23 + " " + r24 + " " + r25 + " " + r26 + " " + r27 + " " + r28 + " " + r29 + " " + r30 + " " +
    r31 + " " + r32 + " " + r33 + " " + r34 + " " + r35 + " " + r36 + " " + r37 + " " + r38 + " " + r39 + " " + r40);


Console.WriteLine();
jugada = true;
if (jugada == true)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write("Numero que salieron: ");

    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.Write(s1 + " " + s2 + " " + s3 + " " + s4 + " " + s5 + " " + s6 + " " + s7 + " " + s8 + " " + s9 + " " + s10 + " " +
        s11 + " " + s12 + " " + s13 + " " + s14 + " " + s15 + " " + s16 + " " + s17 + " " + s18 + " " + s19 + " " + s20);
}

Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Numeros que coinciden que tu jugada: ");

int[] coinciden = new[]{
    r1,r2,r3,r4,r5,r6,r7,r8,r9,r10,
    r11,r12,r13,r14,r15,r16,r17,r18,r19,r20,
    r21,r22,r23,r24,r25,r26,r27,r28,r29,r30,
    r31,r32,r33,r34,r35,r36,r37,r38,r39,r40 };


foreach (var grouping in coinciden.GroupBy(t => t).Where(t => t.Count() != 1))
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine(string.Format("'{0}' está repetido {1} veces.", grouping.Key, grouping.Count()));
}



Console.ReadKey();
















