/* Задача 21: Напишите программу, которая принимает на 
вход координаты двух точек и находит расстояние между 
ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

// Заменить ввод функцией ввода

int coordinateX1 = Coordinate("X1", "A");
int coordinateY1 = Coordinate("Y1", "A");
int coordinateZ1 = Coordinate("Z1", "A");
int coordinateX2 = Coordinate("X2", "B");
int coordinateY2 = Coordinate("Y2", "B");
int coordinateZ2 = Coordinate("Z2", "B");

double distance = Calculation(coordinateX1, coordinateY1, coordinateZ1, coordinateX2, coordinateY2, coordinateZ2);
Console.WriteLine($"Расстояние между двумя точками в проостранстве равно {distance}");

///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
double Calculation(int x1, int y1, int z1, int x2, int y2, int z2) // Функция/метод вычисления расстояния между двумя точками в пространстве //
{                                                                                                                                            //
    double valueX = Math.Pow(x1 - x2, 2);                                                                                                    //
    double valueY = Math.Pow(y1 - y2, 2);                                                                                                    //
    double valueZ = Math.Pow(z1 - z2, 2);                                                                                                    //
    double result = Math.Round(Math.Sqrt(valueX + valueY + valueZ), 2);                                                                      //
    return result;                                                                                                                           //
}                                                                                                                                            //
                                                                                                                                             //
int Coordinate(string coordinateName, string pointName) // Функция/метод ввода координат                                                     //
{                                                                                                                                            //
    Console.Write($"Введите координату {coordinateName} точки {pointName}: ");                                                               //
    return Convert.ToInt16(Console.ReadLine());                                                                                              //
}                                                                                                                                            //
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////