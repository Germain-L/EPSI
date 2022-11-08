package org.cafetiere;

import java.util.HashMap;

public class Employe {
	
	String nom ; 
	HashMap<TypeCafe,Integer> listeCompetences ; 
	HashMap<Integer,Boolean> horaireDuJour ; 
	int salaireParHeureEnCentime ; 
	
	
	public Employe() {
		nom = "Jean" ;
		listeCompetences = new HashMap<TypeCafe, Integer>() ;
		for(TypeCafe type : TypeCafe.values()) {
			listeCompetences.put(type, 3) ; 
		}
		listeCompetences.remove(TypeCafe.BATARD) ; 
		
		horaireDuJour = new HashMap<Integer, Boolean>() ; 
		for(Integer a = 8 ; a <= 16 ; a++) {			
			if(a == 12)
				horaireDuJour.put(a,false) ; 
			else
				horaireDuJour.put(a,true) ; 			
		}
		
		salaireParHeureEnCentime = 1000 ; 
	}
	
	public Employe(String nom, HashMap<TypeCafe,Integer> listeCompetences, 
			HashMap<Integer,Boolean> horaireDuJour, int salaireParHeureEnCentime) 
	{
		this.nom = nom ; 
		this.listeCompetences = listeCompetences ; 
		this.horaireDuJour = horaireDuJour ; 
		this.salaireParHeureEnCentime = salaireParHeureEnCentime ; 
	}
	
}
