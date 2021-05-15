using System;

namespace ProgramasPF
{
    class Program
    {
        static void Main(string[] args)
        {
            string res = null;
            do 
            { 
            Console.WriteLine("Escoge el número de ejercicio a ver");
            byte opcion = byte.Parse(Console.ReadLine());

            
            
                switch (opcion)
                {
                    case 1: // Determina el volumen de un cubo
                        {
                            Console.Clear();
                            Console.WriteLine("Opten el volumen de una caja de dimensiones A, B, C");
                            int resultado = 0;
                            Console.WriteLine("Ingrese el valor del lado A");
                            int LadoA = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese el valor del lado B");
                            int LadoB = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingresa el valor del lado C");
                            int LadoC = int.Parse(Console.ReadLine());
                            resultado = (LadoA * LadoB * LadoC);
                            Console.WriteLine("El volumen de tu caja es de:" + resultado);

                            break;
                        }

                    case 2: // Determina el area de un rectangulo
                        {
                            Console.Clear();
                            Console.WriteLine("Determina el area de un rectángulo");
                            int area = 0;
                            Console.WriteLine("Ingrese la altura del rectángulo");
                            int altura = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese la base del rectángulo ");
                            int basse = int.Parse(Console.ReadLine());
                            area = (basse * altura);
                            Console.WriteLine("El area del rectángulo es:" + area);
                            break;
                        }

                    case 3: // Determinar si un número es mayor que otro
                        {
                            Console.Clear();
                            Console.WriteLine("Determinar si un número es mayor que otro");
                            Console.WriteLine("Ingrese el primer número");
                            double C1 = double.Parse(Console.ReadLine());
                            Console.WriteLine("Ingres el segundo número");
                            double C2 = double.Parse(Console.ReadLine());
                            if (C1 == C2)
                            {
                                Console.WriteLine("Los números son iguales");
                            }
                            else
                            {
                                if (C1 < C2)
                                {
                                    Console.WriteLine("El número mayor es:" + C2);
                                }
                                else
                                {
                                    Console.WriteLine("El número mayor es:" + C1);
                                }
                            }
                            break;
                        }


                    case 4: // Suma de 10 números cuales quiera
                        {
                            Console.Clear();
                            Console.WriteLine("Suma de 10 números cuales quiera");
                            double suma = 0;
                            for (int x = 1; x <= 10; x = x + 1)

                            {

                                Console.WriteLine("Ingrese el número a sumar");
                                double num = double.Parse(Console.ReadLine());
                                suma = (suma + num);

                            }
                            Console.WriteLine("La suma total de tus números es:" + suma);
                            break;
                        }


                    case 5://Promedio de  4 calificaciones obtenidas
                        {
                            Console.Clear();
                            Console.WriteLine("Promedio de 4 calificaciones obtenidas");
                            double suma = 0;
                            for (byte x = 1; x <= 4; x++)
                            {
                                Console.WriteLine("Ingrese su calificación");
                                double calif = double.Parse(Console.ReadLine());
                                suma = (suma + calif);

                            }
                            Console.WriteLine("Su promedio es de: " + suma / 4);

                            break;
                        }


                    case 6: //area de una circunferencia

                        {
                            Console.Clear();
                            Console.WriteLine("Calcular el area de una circunferencia");
                            Console.WriteLine("Ingresa el radio de la circunferencia");
                            double rad = double.Parse(Console.ReadLine());
                            double poten = 0;
                            double area = 0;
                            poten = (rad * rad);
                            area = (3.1416 * poten);
                            Console.WriteLine("El area de la circunferencia es:" + area);



                            break;
                        }


                    case 7: //Ejemplo 2.5 area de una figura de forma "A"
                        {
                            Console.Clear();
                            double AreaTr = 0;
                            double AreaRec = 0;
                            Console.WriteLine("Ejemplo 2.5: Area de la figura de forma A");
                            Console.WriteLine("Ingrese el valor de lado mas largo (A)");
                            double A = double.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese el valor de la base de la figura (B)");
                            double B = double.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese el valor del lado paralelo al lado A (C)");
                            double C = double.Parse(Console.ReadLine());

                            AreaTr = ((B * (A - C)) / 2);
                            AreaRec = (B * C);
                            Console.WriteLine("El area de tu figura es:" + (AreaTr + AreaRec));


                            break;
                        }


                    case 8:// Ejemplo 2.6 Area de la figura A
                        {
                            Console.Clear();
                            double CatF = 0;
                            double AreaC = 0;
                            double AreaTr = 0;
                            double AreaTOT = 0;
                            double Sum = 0;
                            Console.WriteLine("Ejemplo 2.6: Obten el area de la figura de la forma A");
                            Console.WriteLine("Ingrese el valor de la base del triágulo rectángulo (R)");
                            double Rad = double.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese el valor de la hipotenusa del triangulo (H)");
                            double Hip = double.Parse(Console.ReadLine());
                            Sum = ((Hip * Hip) - (Rad * Rad));
                            CatF = Math.Sqrt(+Sum);
                            AreaTr = ((2 * (Rad * CatF)) / 2);
                            AreaC = ((3.1416 * Rad * Rad) / 2);
                            AreaTOT = (AreaC + AreaTr);
                            Console.WriteLine("El area total de la figura es:" + AreaTOT);
                            break;
                        }


                    case 9: //pago de leche por galón
                        {
                            Console.Clear();
                            double conver = 0;
                            double preciF = 0;
                            Console.WriteLine("Ganacias de venta de leche");
                            Console.WriteLine("Ingrece el precio por galón");
                            double PreG = double.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrece la cantidad de litros a vender");
                            double Litr = double.Parse(Console.ReadLine());
                            conver = (Litr / 3.785);
                            preciF = (conver * PreG);
                            Console.WriteLine("La ganacia por la leche es:" + preciF);
                            break;
                        }


                    case 10://Distancia entre dos puntos en el plano cartesiano
                        {
                            Console.Clear();
                            int x1 = 0;
                            int x2 = 0;
                            int y1 = 0;
                            int y2 = 0;
                            int xf = 0;
                            int yf = 0;
                            double Dist = 0;
                            Console.WriteLine("Obten la distancia que existe entre dos puntos dentro de un plano carteciano");
                            Console.WriteLine("Ingrese las el valor de X del primer punto");
                            x1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese las el valor de Y del primer punto");
                            y1 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese las el valor de X del segundo punto");
                            x2 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese las el valor de Y del segundo punto");
                            y2 = int.Parse(Console.ReadLine());

                            xf = (x2 - x1);
                            yf = (y2 - y1);
                            Dist = Math.Sqrt((xf * xf) + (yf * yf));
                            Console.WriteLine("La distancia entre tus puntos es:" + Dist);

                            break;
                        }


                    case 11://Sueldo de un trabajador
                        {
                            int pagt = 0;
                            Console.Clear();
                            Console.WriteLine("Se requiere obtener el sueldo semanal de un trabajador");
                            Console.WriteLine("Ingrese las horas que se trabajaron en la semana");
                            byte horas = byte.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese el pago por hora");
                            int pagh = int.Parse(Console.ReadLine());
                            pagt = (horas * pagh);
                            Console.WriteLine("El pago total por la semana es de:" + pagt);

                            break;
                        }


                    case 12: // Modista realiza prendas de vestir (Metros a pulgadas)
                        {
                            double Convers = 0;
                            Console.Clear();
                            Console.WriteLine("Tela, conversion de metros a pulgadas");
                            Console.WriteLine("Ingrese la cantidad de metros que desea ordenar");
                            double CantM = double.Parse(Console.ReadLine());
                            Convers = CantM / 0.0254;
                            Console.WriteLine("La cantidad de pulgadas a pedir es:" + Convers);
                            break;
                        }


                    case 13:// Ejemplo 2.11
                        {
                            double vol = 0;
                            double pag = 0;
                            Console.Clear();
                            Console.WriteLine("Ejemplo 2.11: Pago por gasto de agua");
                            Console.WriteLine("Ingrese la altura de la alberca en metros");
                            double Alt = double.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese lo largo de su alberca en metros");
                            double Lar = double.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese el ancho de su alberca en metros");
                            double anch = double.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese el costo por metro cúbico");
                            double Cost = double.Parse(Console.ReadLine());
                            vol = (Alt * Lar * anch);
                            pag = (vol * Cost);
                            Console.WriteLine("El pago a realizar es de:" + pag);
                            break;
                        }


                    case 14:// Problemas propuestos 2.1 area de un triangulo
                        {
                            double area = 0;
                            Console.Clear();
                            Console.WriteLine("Problemas 2.1 Obtener el área de un triángulo");
                            Console.WriteLine("Ingrese la base del triangulo");
                            double basses = double.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese la altura de su triangulo");
                            double H = double.Parse(Console.ReadLine());
                            area = ((basses * H) / 2);
                            Console.WriteLine("El área de tu triángulo es" + area);
                            break;
                        }


                    case 15://Problemas propuesto 2.2 Pesos a dólares
                        {
                            double conver = 0;
                            Console.Clear();
                            Console.WriteLine("Problema 2.2: Pesos a dolares");
                            Console.WriteLine("Ingresa la cantidad de dinero mexicano que tienes");
                            double Pesos = double.Parse(Console.ReadLine());
                            Console.WriteLine("Ingresa el valor del dolar en este momento");
                            double ValDola = double.Parse(Console.ReadLine());
                            conver = Pesos / ValDola;
                            Console.WriteLine("La cantidad de dólares es de:" + conver);
                            break;
                        }


                    case 16:// Problemas propuestos 2.3: Edad de una persona sólo con el año
                        {
                            int edad = 0;
                            Console.Clear();
                            Console.WriteLine("Problema 2.3: Edad de una persona dado el año de nacimiento");
                            Console.WriteLine("Ingrese el año actual");
                            int añoA = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese el año de nacimiento del trabajador");
                            int añoN = int.Parse(Console.ReadLine());
                            edad = añoA - añoN;
                            Console.WriteLine("La edad aproximada del trabajador es de:" + edad);

                            break;
                        }


                    case 17:// Problemas propuestos 2.4: Horas de pago en un estacionamiento
                        {
                            double pag = 0;
                            Console.Clear();
                            Console.WriteLine("Determina el pago de estacionamiento de acuerdo a las horas");
                            Console.WriteLine("Ingrese el pago por hora");
                            double PPH = double.Parse(Console.ReadLine());
                            Console.WriteLine("Ingresa las horas de estancia");
                            int Horas = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese los minutos extra de estancia si es que los hubo, en caso contrario ponga 0");
                            byte Minu = byte.Parse(Console.ReadLine());
                            if (Minu != 0)
                            {
                                Horas = Horas + 1;
                                pag = Horas * PPH;

                            }
                            else
                            {
                                pag = Horas * PPH;
                            }
                            Console.WriteLine("El pago total por tiempo de estacionamiento es de:" + pag);
                            break;
                        }


                    case 18:// Problemas propuestos 2.5 "La Brocha gorda"
                        {
                            double precF = 0;
                            Console.Clear();
                            Console.WriteLine("Problema 2.5: La brocha gorda");
                            Console.WriteLine("Ingrese el precio por metro cuadrado");
                            double preM = double.Parse(Console.ReadLine());
                            Console.WriteLine("¿Tienes los metros cuadrados a pintar?");
                            string respuesta = Console.ReadLine();


                            if (respuesta.ToLower() == "si")
                            {
                                Console.WriteLine("Ingrese los metros cuadrados a pintar");
                                double MC = double.Parse(Console.ReadLine());
                                precF = MC * preM;
                            }
                            else
                            {
                                double areaC = 0;
                                Console.WriteLine("Ingrese la altura de la superficie a pintar");
                                double alt = double.Parse(Console.ReadLine());
                                Console.WriteLine("Ingrese la base de la superficie a pintar");
                                double Bassse = double.Parse(Console.ReadLine());
                                areaC = Bassse * alt;
                                precF = areaC * preM;
                            }
                            Console.WriteLine("El precio total es de:" + precF);
                            break;
                        }


                    case 19: // Problemas propuestos 2.6: Determinar la hipotenusa de un triángulo rectangulo
                        {
                            double hip = 0;
                            Console.Clear();
                            Console.WriteLine("Problema 2.6: Determina la hipotenusa de un triángulo rectangulo");
                            Console.WriteLine("Ingrese la medida del cateto A");
                            int catA = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese la medida del cateto B");
                            int catB = int.Parse(Console.ReadLine());
                            hip = Math.Sqrt((catA * catA) + (catB * catB));
                            Console.WriteLine("Tu hipotenusa tiene un valor de:" + hip);
                            break;
                        }


                    case 20:// Problemas propuestos 2.7: ""La Curva loca"
                        {
                            double bole = 0;
                            Console.Clear();
                            Console.WriteLine("Problemas 2.7: La curva loca");
                            Console.WriteLine("Ingrese los kilometros a recorrer");
                            double KiloA = double.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese el costo por kilometro");
                            double Cost = double.Parse(Console.ReadLine());
                            bole = KiloA * Cost;
                            Console.WriteLine("El costo de su boleto es de:" + bole);
                            break;
                        }

                    case 21:// Problemas propuestos 2.8: Tiempo de llegada de un ciclista
                        {
                            double time = 0;
                            Console.Clear();
                            Console.WriteLine("Problema 2.8: ¿Tiempo de recorrido de un ciclista");
                            Console.WriteLine("Ingrese la distancia en metros desde una ciudad a otra");
                            int Dis = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese la velocidad del ciclista en metros");
                            int vel = int.Parse(Console.ReadLine());
                            time = Dis / vel;
                            Console.WriteLine("El tiempo de recorrido es de:" + time, "Minutos");
                            break;
                        }

                    case 22:// Problemas propuestos 2.9: Costo de llamada telefonica
                        {
                            double cos = 0;
                            Console.Clear();
                            Console.WriteLine("Problema 2.9: LLamada telefónica");
                            Console.WriteLine("Ingrese el monto por minuto");
                            double min = double.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese la cantidad de minutos de llamada realizada");
                            int CMin = int.Parse(Console.ReadLine());
                            cos = CMin * min;
                            Console.WriteLine("El precio por tu llamada es de:$" + cos);


                            break;
                        }

                    case 23:// Problemas propuestos 2.10: CONAGUA Pago por persona
                        {
                            double CosPC = 0;
                            Console.Clear();
                            Console.WriteLine("Problemas 2.10:CONAGUA");
                            Console.WriteLine("Ingrese el costo por metro cúbico");
                            double CosMC = double.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese la cantidad de metros cúbicos consumidos");
                            double MCC = double.Parse(Console.ReadLine());
                            CosPC = CosMC * MCC;
                            Console.WriteLine("La cantiadad total a pagar es de:$" + CosPC);

                            break;
                        }

                    case 24:// Problemas propuestos 2.11 Luz y sombras CLS
                        {
                            double precio = 0;
                            Console.Clear();
                            Console.WriteLine("Problea 2.11: Costo por consumo eléctrico Luz y sombras");
                            Console.WriteLine("Ingrese el precio por KiloWatt");
                            double PPKW = double.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese los KiloWatts cosumidos");
                            double KWC = double.Parse(Console.ReadLine());

                            precio = PPKW * KWC;
                            Console.WriteLine("El costo de tu cosnumo es de: $" + precio);
                            break;
                        }

                    case 25:// Problemas propuestos 2.12 Precios con descuentos
                        {
                            double PrecCD = 0;
                            double PF = 0;
                            Console.Clear();
                            Console.WriteLine("Problema 2.12: Descuento de articulo x");
                            Console.WriteLine("Ingrese el costo del articulo");
                            double artP = double.Parse(Console.ReadLine());
                            PrecCD = artP * 0.80;
                            PF = artP * 0.95;
                            Console.WriteLine("El costo de tu articulo con descuento es de: $" + PrecCD);
                            Console.WriteLine("El costo total de tu articulo es de: $" + PF);
                            break;
                        }

                    case 26://Problemas propuestos 2.13: Ahorro de una persona
                        {
                            double ahorr = 0;
                            Console.Clear();
                            Console.WriteLine("Problemas 2.13: Ahorro de una persona"); //El sueldo no cambia, se consideran 4 semanas por mes
                            Console.WriteLine("Ingrese su sueldo");
                            double Suel = double.Parse(Console.ReadLine());
                            ahorr = Suel * .15 * 12 * 4;
                            Console.WriteLine("El ahorro durante todo el año es de: $" + ahorr);

                            break;
                        }

                    case 27://Problemas propuestos 2.14: Estancia en Monterrey por días
                        {
                            double Sum = 0;
                            double GasTH = 0;
                            double GasTPC = 0;
                            double GasTPDD = 0;
                            Console.Clear();
                            Console.WriteLine("Problema 2.14: Empresa paga un cheque para la estancia en Monterrey");
                            Console.WriteLine("Ingrese la cantidad de días de estancia");
                            byte DiasE = byte.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese el costo del hotel");
                            double CosH = double.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese el gasto por comida al día");
                            double GPC = double.Parse(Console.ReadLine());
                            GasTH = DiasE * CosH;
                            GasTPC = DiasE * GPC;
                            GasTPDD = DiasE * 100;
                            Sum = GasTH + GasTPC + GasTPDD;
                            Console.WriteLine("El costo por hotel es de: $" + GasTH);
                            Console.WriteLine("El costo por comida es de: $" + GasTPC);
                            Console.WriteLine("El costo por los 100 pesos extra es de: $" + GasTPDD);
                            Console.WriteLine("El cheque debera de ser de: $" + Sum);


                            break;
                        }

                    case 28:// Problemas propuestos 2.15: Calculo de la potencia eléctrica
                        {
                            double Volt = 0;
                            double Pot = 0;
                            Console.Clear();
                            Console.WriteLine("Problema 2.15: Potencia eléctrica del circuito en serie");
                            Console.WriteLine("Ingrese el valor de la resistencia");
                            double Res = double.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese el valor de la intensidad eléctrica");
                            double intenE = double.Parse(Console.ReadLine());
                            Volt = Res * intenE;
                            Pot = Volt * intenE;
                            Console.WriteLine("La potencia eléctrica de tu circuito en serie es de:" + Pot);

                            break;
                        }

                    case 29:// Problemas propuestos 2.20: Calificacion de una materia en base a exámenes 
                        {
                            double prom1 = 0;
                            double prom2 = 0;
                            double prom3 = 0;
                            Console.Clear();
                            Console.WriteLine("Problema 2.20: Calificacion dados los exámenes");
                            Console.WriteLine("Ingrese la calificación del primer examen");
                            byte Cal1 = byte.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese la calificación del segundo examen");
                            byte Cal2 = byte.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese la calificación del tercer examen");
                            byte Cal3 = byte.Parse(Console.ReadLine());
                            prom1 = ((Cal1 * 25) / 10);
                            prom2 = ((Cal2 * 25) / 10);
                            prom3 = ((Cal3 * 50) / 10);
                            double suma = ((prom1 + prom2 + prom3)/10);
                            Console.WriteLine("La calificación final es de:" + suma);
                            break;
                        }

                    case 30:// Problemas propuestos 2.23: Hotel Cama arena
                        {
                            Console.Clear();
                            Console.WriteLine("Problema 2.23: Pago de guesped por estancia Hotel cama arena");
                            Console.WriteLine("Ingrese el costo por noche de estancia");
                            double CosPN = double.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese los días de estancia");
                            byte DiDE = byte.Parse(Console.ReadLine());
                            double CostT = CosPN * DiDE;
                            Console.WriteLine("El costo por los días de estancia es de:" + CostT);
                            break;
                        }

                    case 31:// Ejemplo 3.2 Determinar si un número es positivo o negativo
                        {
                            Console.Clear();
                            Console.WriteLine("Ejemplo 3.2 Determinar si un número es positivo o negativo");
                            Console.WriteLine("Ingrese su número");
                            int num = int.Parse(Console.ReadLine());
                            if (num >= 0)
                            {
                                Console.WriteLine("El número proporcionado es positivo");

                            }
                            else
                            {
                                Console.WriteLine("El número proporcionado es negativo");
                            }
                            break;
                        }

                    case 32:// Ejemplo 3.3 Pago por cantidad de lapices
                        {
                            double PagoT = 0;
                            Console.Clear();
                            Console.WriteLine("Ejemplo 3.3: Pago por cantidad de lapices");
                            Console.WriteLine("Ingrese la cantidad de lapices a comprar");
                            int lap = int.Parse(Console.ReadLine());

                            if (lap >= 1000)
                            {
                                PagoT = lap * 0.85;
                            }
                            else
                            {
                                PagoT = lap * 0.90;
                            }
                            Console.WriteLine("El pago por la cantidad de lapices es de: $" + PagoT);
                            break;
                        }

                    case 33:// Ejemplo 3.4 "El harapiento distinguido"
                        {
                            double DE = 0;
                            double PF = 0;
                            Console.Clear();
                            Console.WriteLine("Ejemplo 3.4 Traje del harapiento distinguido");
                            Console.WriteLine("Ingrese el costo del traje a comprar");
                            double preciT = double.Parse(Console.ReadLine());

                            if (preciT > 2500)
                            {
                                DE = preciT * 0.15;
                            }
                            else
                            {
                                DE = preciT * 0.08;
                            }
                            PF = preciT - DE;
                            Console.WriteLine("El costo final del traje es de: $" + PF);
                            Console.WriteLine("El valor del descuento es de: $" + DE);
                            break;
                        }

                    case 34:// Ejemplo 3.5 Determinar cual de las 3 cantidades es mayor
                        {
                            double Mayor = 0;
                            Console.Clear();
                            Console.WriteLine("Ejemplo 3.5: Dadas 3 cantidades determinar cuál es la mayor");
                            Console.WriteLine("Ingrese la primer cantidad");
                            double A = double.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese la segunda cantidad");
                            double B = double.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese la tercera cantidad");
                            double C = double.Parse(Console.ReadLine());

                            //Condición
                            if (A > B)
                            {
                                if (A > C)
                                {
                                    Mayor = A;
                                }
                                else
                                {
                                    Mayor = C;
                                }
                            }
                            else
                            {
                                if (B > C)
                                {
                                    Mayor = B;
                                }
                                else
                                {
                                    Mayor = C;
                                }
                            }
                            //Fin de la condición

                            Console.WriteLine("El número mayor es:" + Mayor);
                            break;
                        }

                    case 35: //Ejemplo 3.6 "La langosta ahumada"
                        {
                            double TOT = 0;
                            Console.Clear();
                            Console.WriteLine("Ejemplo 3.6: La langosta ahumada y los banquetes");
                            Console.WriteLine("Ingrese el número de personas para el banquete");
                            int NP = int.Parse(Console.ReadLine());


                            // Inicio de la comparación
                            if (NP > 300)
                            {
                                TOT = NP * 75;
                            }
                            else
                            {
                                if (NP > 200)
                                {
                                    TOT = NP * 85;
                                }
                                else
                                {
                                    TOT = NP * 95;
                                }
                            }

                            //Fin de la comparación

                            Console.WriteLine("El costo total por el banquete es de:" + TOT);
                            break;
                        }

                    case 36:// Ejemplo 3.7 Precio del kilo de uva de acuerdo al tipo especifico
                        {
                            Console.Clear();
                            Console.WriteLine("Ejemplo 3.7: Precio del kilo de uva");
                            Console.WriteLine("Ingrese el tipo de Uva (A o B)");
                            string TI = Console.ReadLine();
                            Console.WriteLine("Ingrese el tamaño de la uva");
                            byte TA = byte.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese el precio de la Uva");
                            double P = double.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese los kilos de producción");
                            int K = int.Parse(Console.ReadLine());
                            double GA = 0;

                            //Inicio de la condición
                            if (TI.ToLower() == "a")
                            {
                                if (TA == 1)
                                {
                                    P = P + 0.20;
                                }
                                else
                                {
                                    P = P + 0.30;
                                }

                            }
                            else
                            {
                                if (TA == 1)
                                {
                                    P = P - 0.30;
                                }
                                else
                                {
                                    P = P - 0.50;
                                }

                            }

                            //Fin de la comparación
                            GA = P * K;
                            Console.WriteLine("La ganancia total es de: $" + GA);
                            break;
                        }

                    case 37: // Ejemplo 3.8: Viaje escolar y gastos
                        {
                            Console.Clear();
                            Console.WriteLine("Ejemplo 3.8: Viaje escolar y gastos");
                            Console.WriteLine("Ingrese el número de alumnos que asistirán al viaje");
                            int NA = int.Parse(Console.ReadLine());
                            double PA = 0;
                            double TOT = 0;


                            //Inicio de la condición 
                            if (NA >= 100)
                            {
                                PA = 65.0;
                            }
                            else
                            {
                                if (NA >= 50)
                                {
                                    PA = 70.0;
                                }
                                else
                                {
                                    if (NA >= 30)
                                    {
                                        PA = 95.0;
                                    }
                                    else
                                    {
                                        PA = 4000 / NA;
                                    }
                                }
                            }
                            // Fin de las condiciones


                            TOT = PA * NA;
                            Console.WriteLine("El pago por alumno es de: $" + PA);
                            Console.WriteLine("El pago total es: $" + TOT);
                            break;
                        }

                    case 38:// Ejemplo 3.9: Compañia "Chimefon"
                        {
                            Console.Clear();
                            Console.WriteLine("Ejemplo 3.9: Compañia Chismefon");
                            Console.WriteLine("Ingrese la duración del llamada (Minutos)");
                            int TI = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese el día en que se realizo la llamada Ejemplo: Domingo");
                            string DI = Console.ReadLine();
                            Console.WriteLine("Ingrese el turno en el que se realizó la llamada (Matutino/Vespertino)");
                            string TU = Console.ReadLine();
                            double PAG = 0;
                            double IM = 0;
                            double TOT = 0;
                            // Inicio de las condiciones


                            if (TI < 5)
                            {
                                PAG = TI * 1;
                            }
                            else
                            {
                                if (TI < 8)
                                {
                                    PAG = (TI - 5) * 0.8 + 5;
                                }
                                else
                                {
                                    if (TI <= 10)
                                    {
                                        PAG = (TI - 8) * 0.7 + 7.4;
                                    }
                                    else
                                    {
                                        PAG = (TI - 10) * 0.5 + 8.8;
                                    }
                                }
                            }
                            // Segunda condición
                            if (DI.ToLower() == "domingo")
                            {
                                IM = PAG * 0.05;
                            }
                            else
                            {
                                if (TU.ToLower() == "matutino")
                                {
                                    IM = PAG * 0.15;
                                }
                                else
                                {
                                    IM = PAG * 0.10;
                                }
                            }

                            TOT = PAG + IM;
                            Console.WriteLine("El pago por la llamada es de:" + PAG);
                            Console.WriteLine("El impuesto es de" + IM);
                            Console.WriteLine("El total es de" + TOT);
                            break;
                        }

                    case 39://Ejemplo 3.10: Compañia de viajes
                        {
                            Console.Clear();
                            Console.WriteLine("Ejemplo 3.10: La compañia de viajes");
                            Console.WriteLine("Ingrese el tipo de Autobús(A, B, C)");
                            string TI = Console.ReadLine();
                            Console.WriteLine("Ingrese los Kilometros a recorrer");
                            int KM = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese el número de personas");
                            int NPR = int.Parse(Console.ReadLine());
                            double CK = 0;
                            int NP = 0;
                            double CP = 0;
                            double TO = 0;

                            //inicio de las condiciones
                            if (TI.ToLower() == "a")
                            {
                                CK = 2.00;
                            }
                            else
                            {
                                if (TI.ToLower() == "b")
                                {
                                    CK = 2.50;
                                }
                                else
                                {
                                    CK = 3.00;
                                }
                            }
                            if (NPR < 20)
                            {
                                NP = 20;
                            }
                            else
                            {
                                NP = NPR;
                            }

                            //Fin de las condiciones


                            TO = NP * CK * KM;
                            CP = TO / NPR;




                            Console.WriteLine("El costo por persona es de: $" + CP);
                            Console.WriteLine("El total del viaje es de: $" + TO);
                            break;
                        }

                    case 40:// Ejemplo 3.11: El naufrago satisfecho
                        {
                            Console.Clear();
                            Console.WriteLine("Ejemplo 3.11: El naufrago satisfecho ofrece hamburguesas");
                            Console.WriteLine("Ingrese el tipo de haburguesa a consumir (Sencilla, doble o triple)");
                            string TI = Console.ReadLine();
                            Console.WriteLine("Ingrese el número de hamburguesas a consumir");
                            int N = int.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese el tipo de pago (Efectivo o Tarjeta)");
                            string TP = Console.ReadLine();
                            double PA = 0;
                            double CA = 0;
                            double TO = 0;
                            double TOT = 0;

                            // Inicio de condiciones
                            if (TI.ToLower() == "sencilla")
                            {
                                PA = 20;
                            }
                            else
                            {
                                if (TI.ToLower() == "doble")
                                {
                                    PA = 25;
                                }
                                else
                                {
                                    PA = 28;
                                }
                            }
                            //Fin de la primera condición
                            TO = PA * N;

                            //Inicio de la segunda condición Pago con tarjeta
                            if (TP.ToLower() == "tarjeta")
                            {
                                CA = TO * 0.05;
                            }
                            else
                            {
                                CA = 0;
                            }

                            //Fin de la segunda Condición

                            TOT = TO + CA;

                            Console.WriteLine("El precio de la hamburguesa es de: $" + PA);
                            Console.WriteLine("El total sin el cargo es de: $" + TO);
                            Console.WriteLine("El cargo es de: $" + CA);
                            Console.WriteLine("El precio total es: $" + TOT);


                            break;
                        }

                }
                Console.WriteLine("Deseas correr otro ejercicio si/no");
                res = Console.ReadLine();
            }
            while (res.ToLower() == "si");
            
        }
    }
}
