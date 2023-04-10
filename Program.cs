Menu();


void Menu()
{

    int resp;
    Boxeador boxeador1;
    Boxeador boxeador2;
    Console.WriteLine("1. Cargar Datos Boxeador 1\n2. Cargar Datos Boxeador 2\n3. Pelear!\n4. Salir");

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

            Pelear();
            break;



    }
}






Boxeador IngresarBoxeador()
{
        Boxeador b;
    string nom = IngresarString("Ingresar el nombre del boxeador");
    string pais = IngresarString("Ingresar el pais del boxeador");
    int peso = IngresarInt("Ingresar el peso del boxeador");
    int pG; do{ pG= IngresarInt("Ingresar la potencia de golpe del boxeador (Entre 1 y 100)");} while(pG>100 || pG<1);
    int vP; do{ vP= IngresarInt("Ingresar la velocidad de piernas del boxeador (Entre 1 y 100)");} while(vP>100 || vP<1);

    return b = new Boxeador(nom,pais,peso,pG,vP);

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

void Pelear()
{





}