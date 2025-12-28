namespace Pos_Restaurant.Models;

public class PaiementsModel
{
    private int id;
    private String idCommande;
    private double montant;
    private DateTime datePaiement;
    private String modePaiement;
		
		
    public PaiementsModel()
    {
    }
    
    public PaiementsModel(int id, String idCommande, double montant, DateTime datePaiement, String modePaiement)
    {
        this.id = id;
        this.idCommande = idCommande;
        this.montant = montant;
        this.datePaiement = datePaiement;
        this.modePaiement = modePaiement;
    }
		
    public int Id{
        get{ return id; }
        set { id = value; }
    }
		
    public String IdCommande{
        get{ return idCommande; }
        set { idCommande = value; }
    }
		
    public double Montant{
        get{ return montant; }
        set { montant = value; }
    }
		
    public DateTime DatePaiement{
        get{ return datePaiement; }
        set { datePaiement = value; }
    }
		
    public String ModePaiement{
        get{ return modePaiement; }
        set { modePaiement = value; }
    }
}