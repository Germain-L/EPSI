package org.cafetiere;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.HashMap;

public class ListeEmployes {

	
	private static HashMap<TypeCafe,Integer> LC_LC_FULLSTACK_BOF, LC_FULLSTACK_OK, LC_FULLSTACK_PRO,
	LC_CONSIERGE, LC_NEW_EMPLOYE,
	LC_JAVA_GOD, LC_MOKA_GOD,
	LC_HALFPRO,LC_HALFPRO_SECOND
	; 
	private static HashMap<Integer,Boolean> HJ_ALL_DAY, HJ_HALFDAY_MORNING, HJ_HALFDAY_NOON, HJ_OPENNING, HJ_CLOSING; 
	
	static {
		
		// Creation des comp�tences
		LC_LC_FULLSTACK_BOF = new HashMap<TypeCafe, Integer>() ;
		for(TypeCafe cafe : TypeCafe.values())
			LC_LC_FULLSTACK_BOF.put(cafe,1) ; 
		LC_LC_FULLSTACK_BOF.remove(TypeCafe.BATARD) ;
		
		LC_FULLSTACK_OK = new HashMap<TypeCafe, Integer>() ;
		for(TypeCafe cafe : TypeCafe.values())
			LC_FULLSTACK_OK.put(cafe,2) ; 
		LC_FULLSTACK_OK.remove(TypeCafe.BATARD) ;
		
		LC_FULLSTACK_PRO = new HashMap<TypeCafe, Integer>() ;
		for(TypeCafe cafe : TypeCafe.values())
			LC_FULLSTACK_PRO.put(cafe,3) ; 
		LC_FULLSTACK_PRO.remove(TypeCafe.BATARD) ;
		
		LC_CONSIERGE = new HashMap<TypeCafe, Integer>() ;
		LC_NEW_EMPLOYE = new HashMap<TypeCafe, Integer>() ;
		LC_NEW_EMPLOYE.put(TypeCafe.JAVA, 1) ;
		
		LC_JAVA_GOD = new HashMap<TypeCafe, Integer>() ;
		LC_JAVA_GOD.put(TypeCafe.JAVA, 5) ;
		
		LC_MOKA_GOD = new HashMap<TypeCafe, Integer>() ;
		LC_MOKA_GOD.put(TypeCafe.MOKA, 5) ;
		
		LC_HALFPRO = new HashMap<TypeCafe, Integer>() ;
		LC_HALFPRO.put(TypeCafe.BOURBON, 3) ;
		LC_HALFPRO.put(TypeCafe.JAVA, 3) ;
		
		LC_HALFPRO_SECOND = new HashMap<TypeCafe, Integer>() ;
		LC_HALFPRO_SECOND.put(TypeCafe.MOKA, 3) ;
		LC_HALFPRO_SECOND.put(TypeCafe.TYPICA, 3) ;
		
		// Creation des horaires
		HJ_ALL_DAY = new HashMap<Integer,Boolean>() ;
		for(Integer a = 8 ; a <= 16 ; a++)
			if(a != 12)
				HJ_ALL_DAY.put(a, Boolean.TRUE) ; 
			else
				HJ_ALL_DAY.put(a, Boolean.FALSE) ; 
		
		
		HJ_HALFDAY_MORNING = new HashMap<Integer,Boolean>() ;
		for(Integer a = 8 ; a <= 12 ; a++) 
			HJ_HALFDAY_MORNING.put(a, Boolean.TRUE) ;
		
		HJ_HALFDAY_NOON = new HashMap<Integer,Boolean>() ;
		for(Integer a = 12 ; a <= 16 ; a++) 
			HJ_HALFDAY_NOON.put(a, Boolean.TRUE) ;
		
		HJ_OPENNING = new HashMap<Integer,Boolean>() ;
		HJ_OPENNING.put(7, Boolean.TRUE) ; 
		HJ_OPENNING.put(8, Boolean.TRUE) ; 
		
		HJ_CLOSING = new HashMap<Integer,Boolean>() ;
		HJ_OPENNING.put(17, Boolean.TRUE) ; 
		HJ_OPENNING.put(18, Boolean.TRUE) ; 
		
	}
	
	public static ArrayList<Integer> horaire = new ArrayList<Integer> (Arrays.asList(
			7,8,9,10,11,12,13,14,15,16,17,18	
			)); 		
	
	public static ArrayList<Employe> listeEmployes = new ArrayList<Employe> (Arrays.asList(
		new Employe(), 
		new Employe("Robert",LC_CONSIERGE, HJ_CLOSING, 1000),
		new Employe("Robert",LC_CONSIERGE, HJ_HALFDAY_MORNING, 1000),
		new Employe("Robert",LC_CONSIERGE, HJ_ALL_DAY, 1000),
		new Employe("Roberto",LC_CONSIERGE, HJ_CLOSING, 1000),
		new Employe("Roberto",LC_CONSIERGE, HJ_HALFDAY_MORNING, 1000),
		new Employe("Roberto",LC_CONSIERGE, HJ_ALL_DAY, 1000),
		new Employe("Roberta",LC_CONSIERGE, HJ_CLOSING, 1000),
		new Employe("Roberta",LC_CONSIERGE, HJ_HALFDAY_MORNING, 1000),
		new Employe("Roberta",LC_CONSIERGE, HJ_ALL_DAY, 1000),
		new Employe("Zoe",LC_LC_FULLSTACK_BOF, HJ_ALL_DAY, 1000),
		new Employe("Zoe",LC_LC_FULLSTACK_BOF, HJ_HALFDAY_MORNING, 1000),
		new Employe("Zoe",LC_LC_FULLSTACK_BOF, HJ_CLOSING, 1000),
		new Employe("John",LC_LC_FULLSTACK_BOF, HJ_ALL_DAY, 1000),
		new Employe("John",LC_LC_FULLSTACK_BOF, HJ_HALFDAY_MORNING, 1000),
		new Employe("John",LC_LC_FULLSTACK_BOF, HJ_CLOSING, 1000),
		new Employe("Robert",LC_FULLSTACK_OK, HJ_HALFDAY_MORNING, 1110),
		new Employe("Robert",LC_FULLSTACK_OK, HJ_ALL_DAY, 1110),
		new Employe("Marie",LC_FULLSTACK_OK, HJ_OPENNING, 1110),
		new Employe("Marie",LC_FULLSTACK_OK, HJ_ALL_DAY, 1110),
		new Employe("Owenn",LC_FULLSTACK_OK, HJ_OPENNING, 1110),
		new Employe("Owenn",LC_FULLSTACK_OK, HJ_ALL_DAY, 1110),
		new Employe("Valentin",LC_FULLSTACK_OK, HJ_OPENNING, 1110),
		new Employe("Valentin",LC_FULLSTACK_OK, HJ_ALL_DAY, 1110),
		new Employe("Cantin",LC_FULLSTACK_PRO, HJ_ALL_DAY, 1400),
		new Employe("Simon",LC_JAVA_GOD, HJ_HALFDAY_NOON, 1500),
		new Employe("Mathieu",LC_MOKA_GOD, HJ_ALL_DAY, 1500),
		new Employe("Lucas",LC_HALFPRO, HJ_HALFDAY_NOON, 1500),
		new Employe("Thibault",LC_HALFPRO, HJ_HALFDAY_NOON, 1500),
		new Employe("Adrien ",LC_HALFPRO, HJ_HALFDAY_NOON, 1500)
	)); 
		
}