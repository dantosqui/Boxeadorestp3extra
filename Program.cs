﻿Menu();


void Menu()
{

    int resp;
    Boxeador boxeador1=null;
    Boxeador boxeador2=null;

    while (true){
    Console.WriteLine("1. Cargar Datos Boxeador 1\n2. Cargar Datos Boxeador 2\n3. Pelear!\n4. Salir\n5. Cambiar atributos");

    resp = int.Parse(Console.ReadLine());


    switch (resp)
    {


        case 1:

            boxeador1 = IngresarBoxeador();

            break;

        case 2:


            boxeador2 = IngresarBoxeador();


            break;


        case 3:

            Pelear(boxeador1, boxeador2);
            break;

        case 4:
        
            return;
        
        case 5:

            CambiarAtributos(ref boxeador1,ref boxeador2);
            break;
        
        default:
            
            break;
        
        


    }
}}






Boxeador IngresarBoxeador()
{
        Boxeador b;
    string nom = IngresarString("Ingresar el nombre del boxeador");
    string pais = IngresarString("Ingresar el pais del boxeador");
    int peso = IngresarInt("Ingresar el peso del boxeador (kg)");
    int pG; do{ pG= IngresarInt("Ingresar la potencia de golpe del boxeador (Entre 1 y 100)");} while(pG>100 || pG<1);
    int vP; do{ vP= IngresarInt("Ingresar la velocidad de piernas del boxeador (Entre 1 y 100)");} while(vP>100 || vP<1);
    int iq = IngresarInt("Ingresar la inteligencia");

    return b = new Boxeador(nom,pais,peso,pG,vP,iq);

    Console.WriteLine("Se ha creado el boxeador " + b.Nombre);
}


string IngresarString(string prompt)
{

    Console.Write(prompt + ": ");
    return Console.ReadLine();

}

int IngresarInt(string prompt)
{

    Console.Write(prompt + ": ");
    return int.Parse(Console.ReadLine());

}

void Pelear(Boxeador _b1, Boxeador _b2)
{




if(_b1 != null && _b2 != null){

double s1 = _b1.ObtenerSkill();
double s2 = _b2.ObtenerSkill();

double difAbs = Math.Abs(s1-s2);
string ganador = s1-s2 >0 ? _b1.Nombre : _b2.Nombre; 

if(difAbs >= 30){

Console.WriteLine($"Ganó {ganador} por KO");




}else if(difAbs >= 10){

Console.WriteLine($"Ganó {ganador} por puntos en fallo unánime");

}else{


    Console.WriteLine($"Ganó {ganador} por puntos en fallo dividido");
}

}else{

Console.WriteLine("No se ha ingresado algun boxeador");

}


}

void CambiarAtributos(ref Boxeador b1, ref Boxeador b2) {

if (b1!=null && b2!=null) {


Console.WriteLine("A continuacion ingrese los atributos o ingrese 0 para omitir. Recuerde que debe ser entre 1 y 100");

int vp; do{vp= IngresarInt("Ingrese la velocidad de las piernas de " + b1.Nombre + " , el boxeador n°1");} while(vp<0 || vp>100);
if (vp!=0) {b1.VelocidadPiernas=vp;}

int pg; do{pg= IngresarInt("Ingrese la potencia de los golpes de " + b1.Nombre + " , el boxeador n°1");} while(vp<0 || vp>100);
if (pg!=0) {b1.PotenciaGolpes=pg;}

do{vp= IngresarInt("Ingrese la velocidad de las piernas de " + b2.Nombre + " , el boxeador n°2");} while(vp<0 || vp>100);
if (vp!=0) {b2.VelocidadPiernas=vp;}

do{pg= IngresarInt("Ingrese la potencia de los golpes de " + b2.Nombre + " , el boxeador n°2");} while(vp<0 || vp>100);
if (pg!=0) {b2.PotenciaGolpes=pg;}

}
else Console.WriteLine("Aun no se han añadido ambos boxeadores");
}
