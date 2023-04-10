class Boxeador {

public string Nombre {get;private set;}
public string Pais {get;private set;}
public int Peso {get;private set;}
public int PotenciaGolpes {get;set;}
public int VelocidadPiernas {get; set;}

public Boxeador(string _nom, string _pais, int _peso, int _pG, int _vP){



Nombre = _nom ;

Pais = _pais;

Peso = _peso;

PotenciaGolpes = _pG;

VelocidadPiernas = _vP; 

}


public double ObtenerSkill(){


return VelocidadPiernas *.6f + PotenciaGolpes *.8f + new Random().Next(1,10);
}



























}




