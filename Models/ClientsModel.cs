namespace Pos_Restaurant.Models;

public class ClientsModel
{
    private int id;
    private String nom;
    private String prenom;
    private String sexe;
    private String telephone;
    private String email;
    private double montantDette;
			
    public ClientsModel()
    {
    }
    public ClientsModel(int id, String nom, String prenom, String sexe, String telephone, String email, double montantDette)
    {
        this.id = id;
        this.nom = nom;
        this.prenom = prenom;
        this.sexe = sexe;
        this.telephone = telephone;
        this.email = email;
        this.montantDette = montantDette;
    }
    
		
    public int Id{
        get{ return id; }
        set { id = value; }
    }
		
    public String Nom{
        get{ return nom; }
        set { nom = value; }
    }
		
    public String Prenom{
        get{ return prenom; }
        set { prenom = value; }
    }
		
    public String Sexe{
        get{ return sexe; }
        set { sexe = value; }
    }
		
    public String Telephone{
        get{ return telephone; }
        set { telephone = value; }
    }
		
    public String Email{
        get{ return email; }
        set { email = value; }
    }
		
    public double MontantDette{
        get{ return montantDette; }
        set { montantDette = value; }
    }
}