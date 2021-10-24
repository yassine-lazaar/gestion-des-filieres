using System;
using System.Collections.Generic;

namespace choix_des_options
{
    class Program
    {
        static void Main(string[] args)
        {
            // le nombre des etudiants totale
            Console.WriteLine("Entrer le nombre des Etudiants candidats");
            int i = int.Parse(Console.ReadLine());

            // Declaration du tableau pour afficher les etudiants
            string[] tab = new string[i];


            //declarations des trois filieres  Gl , Abd , Asr
            option gl = new option("gl", 20);
            option abd = new option("abd", 20);
            option asr = new option("asr", 20);

            //declaration de la liste des etudiants 

            var liste = new List<Tuple<Etudiant, string, string, string>>() ;

            // la liste d'etudiants 
            
            for (int j = 0; j < i; j++)
            {
                Console.WriteLine("entrer le nom d'etudiant " + (j + 1));
                string nom = Convert.ToString(Console.ReadLine());

                Console.WriteLine("entrer le prenom d'etudiant " + (j+ 1));
                string prenom = Convert.ToString(Console.ReadLine());

                Console.WriteLine("entrer le CNE d'etudiant " + (j + 1));
                string cne = Convert.ToString(Console.ReadLine());

                Console.WriteLine("entrer la note d'etudiant " + (j + 1));
                double note = double.Parse(Console.ReadLine());

                Console.WriteLine("entrer le premier choix d'etudiant " + (j + 1));
                string choix1 = Convert.ToString(Console.ReadLine());

                Console.WriteLine("entrer le 2eme choix d'etudiant " + (j + 1));
                string choix2 = Convert.ToString(Console.ReadLine());

                Console.WriteLine("entrer le 3eme choix d'etudiant " + (j + 1));
                string choix3 = Convert.ToString(Console.ReadLine());

                Console.WriteLine("*********************");

                
                Etudiant etudiant = new Etudiant(nom, prenom, cne, note);

                var tuple = Tuple.Create(etudiant, choix1, choix2, choix3);
                liste.Add(tuple);
            }
           
            // Tri de la liste des etudiants selon les notes  

            liste.Sort(delegate (Tuple<Etudiant, string, string, string> x, Tuple<Etudiant, string, string, string> y) {
                return y.Item1.Etnote.CompareTo(x.Item1.Etnote);
            });

            
            // Affectation des options 

            for (int j =0; j < i; j++) { 
                   
                    switch (liste[j].Item2)
                    {
                        case "gl":
                            if (gl.placedisponible > 0)
                            {
                                tab[i] = liste[j].Item1.Etnom +"  "+ liste[j].Item1.Etprenom + "  " + liste[j].Item1.Etcne + "  " + "  -->  " + gl.filnom ;
                                --gl.placedisponible;
                            }
                            break;
                        case "abd":
                            if (abd.placedisponible > 0)
                            {
                                tab[i] = liste[j].Item1.Etnom + "  " + liste[j].Item1.Etprenom + "  " + liste[j].Item1.Etcne + "  " + "  -->  " + abd.filnom;
                                --abd.placedisponible;
                            }
                            break;
                        case "asr":
                            if (asr.placedisponible > 0)
                            {
                                tab[j] = liste[j].Item1.Etnom + "  " + liste[j].Item1.Etprenom + "  " + liste[j].Item1.Etcne + "  " + "  -->  " + asr.filnom;
                                --asr.placedisponible;
                            }
                            break;
                    }

                    if (tab[j] == null)
                    {
                        switch (liste[j].Item3)
                        {

                        case "gl":
                            if (gl.placedisponible > 0)
                            {
                                tab[j] = liste[j].Item1.Etnom + "  " + liste[j].Item1.Etprenom + "  " + liste[j].Item1.Etcne + "  " + "  -->  " + gl.filnom;
                                --gl.placedisponible;
                            }
                            break;
                        case "abd":
                            if (abd.placedisponible > 0)
                            {
                                tab[i] = liste[j].Item1.Etnom + "  " + liste[j].Item1.Etprenom + "  " + liste[j].Item1.Etcne + "  " + "  -->  " + abd.filnom;
                                --abd.placedisponible;
                            }
                            break;
                        case "asr":
                            if (asr.placedisponible > 0)
                            {
                                tab[i] = liste[j].Item1.Etnom + "  " + liste[j].Item1.Etprenom + "  " + liste[j].Item1.Etcne + "  " + "  -->  " + asr.filnom;
                                --asr.placedisponible;
                            }
                            break;
                    }

                    }


                    if (tab[j] == null)
                    {
                        switch (liste[j].Item4)
                        {

                        case "gl":
                            if (gl.placedisponible > 0)
                            {
                                tab[j] = liste[j].Item1.Etnom + "  " + liste[j].Item1.Etprenom + "  " + liste[j].Item1.Etcne + "  " + "  -->  " + gl.filnom;
                                --gl.placedisponible;
                            }
                            break;
                        case "abd":
                            if (abd.placedisponible > 0)
                            {
                                tab[j] = liste[j].Item1.Etnom + "  " + liste[j].Item1.Etprenom + "  " + liste[j].Item1.Etcne + "  " + "  -->  " + abd.filnom;
                                --abd.placedisponible;
                            }
                            break;
                        case "asr":
                            if (asr.placedisponible > 0)
                            {
                                tab[j] = liste[i].Item1.Etnom + "  " + liste[j].Item1.Etprenom + "  " + liste[j].Item1.Etcne + "  " + "  -->  " + asr.filnom;
                                --asr.placedisponible;
                            }
                            break;
                    }

                    

                }
            

            }
            
            // affichage de la liste finale des etudiants et leurs filieres 

            Console.WriteLine("La liste des etudiants et leurs filieres : ");
            Console.WriteLine("Nom   Prenom   cne   filiere");
            Console.Write("\n");
           

            for (int j = 0; j < i ; j++)
            {
                

                Console.Write(tab[j] + "\t" );
                Console.Write("\n");
                Console.Write("********************************************");
                Console.Write("\n");
            }
           
          
        }
    }
}
  
