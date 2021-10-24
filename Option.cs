using System;

public class option
{
	public option(string nom, int max)
	{
		this.filnom = nom;
		this.filmax = max;
		this.placedisponible = max;
	}


	public string filnom;
	public int filmax; //le nombre max du places 
	public int placedisponible;
}