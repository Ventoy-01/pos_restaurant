namespace Pos_Restaurant.Services;

public interface IDao<T>
{
		int Enregistrer(T e);

		int Modifier(T e);

		int Supprimer(String id);

		T Rechercher(String id);

		List<T> Lister();

}