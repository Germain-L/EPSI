package org.cafetiere;

public class Tasse {

	double quantiteCafeMax ; 
	Cafe cafe ; 
	
	Tasse() {
		quantiteCafeMax = 100 ;
	}
	
	Tasse(float quantiteCafeMax) {
		this.quantiteCafeMax = quantiteCafeMax ; 
	}
	
	public double boire(double quantiteBut) {
		cafe.quantiteLiquideMl -= quantiteBut ; 
		return cafe.quantiteLiquideMl ; 
	}
	
	public void boire() {
		cafe.quantiteLiquideMl = 0 ;
	}
	
	public double getEspaceDisponible() {
		if(cafe == null)
			return quantiteCafeMax ; 
		else 
			return quantiteCafeMax - cafe.quantiteLiquideMl ; 
	}

	public void addCafe(Cafe commandeCafe) {
		if(cafe == null) {
			cafe = commandeCafe ;
		} else {
			cafe.quantiteLiquideMl += commandeCafe.quantiteLiquideMl ; 
			if(cafe.typeCafe != commandeCafe.typeCafe)
				cafe.typeCafe = TypeCafe.BATARD ; 
		}
		
		checkQuantite() ; 
	}
	
	public void checkQuantite() {
		if(cafe == null)
			return ; 
		if(cafe.quantiteLiquideMl > quantiteCafeMax) {
			cafe.quantiteLiquideMl = quantiteCafeMax ;
			System.out.println("Il y a trop de caf� dans la tasse !");
		}
			
	}
}