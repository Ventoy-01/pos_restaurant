namespace Pos_Restaurant.Models;

public class MenusModel
{
    private int id;
    private String nom;
    private String type;
	private int quantite;
	private Double prixUnitaire;
	private String description;
	private Boolean actif;

	public MenusModel()
	{
	}

	public MenusModel(int id, string nom, string type, int quantite, double prixUnitaire, string description)
    {
	    this.id = id;
	    this.nom = nom;
	    this.type = type;
	    this.quantite = quantite;
	    this.prixUnitaire = prixUnitaire;
	    this.description = description;
		this.actif = true;
    }

    	
    public int Id{
        get{ return id; }
        set { id = value; }
    }

    public string Nom
    {
	    get{ return nom; }
		set { nom = value; }
    }

    public String Type{
        get{ return type; }
        set { type = value; }
    }
		
		public int Quantite{
			get{ return quantite; }
			set { quantite = value; }
		}
		
		public double PrixUnitaire{
			get{ return prixUnitaire; }
			set { prixUnitaire = value; }
		}
		
		public String Description{
			get{ return description; }
			set { description = value; }
		}

		public bool Actif{
			get{ return actif; }
			set { actif = value; }

		}
}

