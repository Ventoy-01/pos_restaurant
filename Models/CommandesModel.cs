namespace Pos_Restaurant.Models;

public class CommandesModel
{
    private int id;
    private int idMenu;
    private int idClient;
    private int quantite;
    private Double prixTotal;
    private String description;

			
    public CommandesModel()
    {
    }
    
    public CommandesModel(int id, int idMenu, int idClient, double prixTotal, String description)
    {
        this.id = id;
        this.idMenu = idMenu;
        this.idClient = idClient;
        this.prixTotal = prixTotal;
        this.description = description;
    }
		
    public int Id{
        get{ return id; }
        set { id = value; }
    }
		
    public int IdMenu{
        get{ return idMenu; }
        set { idMenu = value; }
    }
		
    public int IdClient{
        get{ return idClient; }
        set { idClient = value; }
    }
    
    public int Quantite{
        get{ return quantite; }
        set { quantite = value; }
    }
    
    public double PrixTotal{
        get{ return prixTotal; }
        set { prixTotal = value; }
    }
		
    public String Description{
        get{ return description; }
        set { description = value; }
    }
    
}