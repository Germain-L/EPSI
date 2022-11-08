package org.cafetiere;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.Map.Entry;
import java.util.Random;

public class AMain_Corrige {

	public static void main(String[] arg) {
		Restaurant resto = new Restaurant("Mon resto") ;
		
		ArrayList<String> nameList = new ArrayList() ; 
		
		for(int a = 0 ; a < 5; a++) {
			tryAddEmploye(resto, nameList) ; 
		}
		
		HashMap<Integer, ArrayList<Employe>> listEmployePerHour = getListEmployerPerHour(resto) ; 
		
		HashMap<TypeCafe, Integer> competenceMap ; 
		int nbProbleme  ;

		for(Integer horaire : ListeEmployes.horaire) {
			nbProbleme = 0 ;
			if(listEmployePerHour.get(horaire).size() == 0) {
				System.out.println("Personne ne travail � " + horaire + ":00");
			} else {
				competenceMap = getEmptyCompetenceMap() ; 
				
				for(Employe employe : listEmployePerHour.get(horaire)) {
					for(Entry<TypeCafe, Integer> skills : employe.listeCompetences.entrySet()) {
						if(skills.getKey() != TypeCafe.BATARD)
							competenceMap.put(skills.getKey(), skills.getValue() + competenceMap.get(skills.getKey()))  ;
					}
				}
				
				for(Entry<TypeCafe, Integer> comps : competenceMap.entrySet()) {
					if(comps.getValue() == 0) {
						nbProbleme++ ; 
						System.out.println("Personne n'est en mesure de produire du " + comps.getKey().name() + " vers " + horaire + ":00");
					} else if(comps.getValue() < 3) {
						nbProbleme++ ; 
						System.out.println("J'ai seulement un skill total de " + comps.getValue() + " pour le "  + comps.getKey().name() + " vers " + horaire + ":00");
					}
				}
				
				
				if(nbProbleme == 0) {
					System.out.println("Tout est ok pour " + horaire + ":00");
				}
				
			}		
		}	
	}
	
	
	private static HashMap<Integer, ArrayList<Employe>> getListEmployerPerHour(Restaurant resto) {
		HashMap<Integer, ArrayList<Employe>> listEmployePerHour = new HashMap();
		
		for(Integer in : ListeEmployes.horaire) {
			listEmployePerHour.put(in, new ArrayList<Employe>()) ;
			for(Employe employe : resto.employes.values()) {
				if(Boolean.TRUE.equals(employe.horaireDuJour.get(in))) {
					listEmployePerHour.get(in).add(employe) ; 
				}
			}
		}
		
		return listEmployePerHour; 
	}

	static void tryAddEmploye(Restaurant resto, ArrayList<String> nameList) {
		Random random = new Random() ; 
		while(true) {
			Employe employe = ListeEmployes.listeEmployes.get(random.nextInt(ListeEmployes.listeEmployes.size())) ; 
			if(!nameList.contains(employe.nom)) {
				nameList.add(employe.nom) ;
				resto.employes.put(employe.nom, employe) ; 
				System.out.println("Je rajoute " + employe.nom + " avec les comp�tences" + employe.listeCompetences.values() + " et travaillant  " + employe.horaireDuJour.keySet() + ""  ); // Ici seulement pour test, pas n�c�saire dans le rendu
				break ; 
			} else {
				System.out.println("Non pas toi " + employe.nom); // Ici seulement pour test, pas n�c�saire dans le rendu	
			}
		}	
	}
		
	static HashMap<TypeCafe, Integer> getEmptyCompetenceMap() {
		HashMap<TypeCafe, Integer> returningMap = new HashMap<TypeCafe, Integer>() ; 
		
		for(TypeCafe type : TypeCafe.values()) {
			if(type != TypeCafe.BATARD)
				returningMap.put(type, 0) ; 
		}
		return returningMap ; 
	}
		
}