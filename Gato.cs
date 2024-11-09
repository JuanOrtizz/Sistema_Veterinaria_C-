﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Gato: Animal
{
    private string raza;
    private List<string> vacunas; 

    public Gato(string nombre, Cliente dueño, DateTime fecNac, double peso, Genero sexo, string raza) : base(nombre, dueño, fecNac, peso, sexo)
    {
        this.raza = raza;
        vacunas = new List<string>();
    }

    public string Raza
    {
        get { return raza; }
        set { this.raza = value; }
    }

    public List<string> Vacunas
    {
        get {return vacunas;}
    }

    public void VerVacunas()
    {
        if (vacunas.Count == 0)
        {
            Console.WriteLine("El gato no tiene vacunas registradas en el sistema\n");
        }
        else
        {
            Console.WriteLine("---Vacunas del gato---");
            int contador = 1;
            foreach (string vacuna in vacunas)
            {
                Console.WriteLine("[ " + contador + " ] Vacuna: " + vacuna);
                contador++;
            }
            Console.WriteLine();
        }
    }

    public override string ToString()
    {
        return base.ToString() + "\nRaza del Gato: " + raza;
    }
}
