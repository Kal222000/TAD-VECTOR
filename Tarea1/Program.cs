Vector vec1 = new Vector(8);
vec1.Asignar_Elemento(1, 1);
vec1.Asignar_Elemento(2, 1);
vec1.Asignar_Elemento(3, 4);
vec1.Asignar_Elemento(4, 4);
vec1.Asignar_Elemento(5, 0);
vec1.Asignar_Elemento(6, 0);
vec1.Asignar_Elemento(7, 0);
vec1.Asignar_Elemento(8, 4);


Console.WriteLine(vec1.Obtener_Longitud());
vec1.Mostrar_Array();
vec1.EliminarDuplicados();
Console.WriteLine(vec1.Obtener_Longitud());
vec1.Mostrar_Array();

